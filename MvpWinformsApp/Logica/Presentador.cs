using System;
using MvpWinformsApp.Infraestructura;
using MvpWinformsApp.InterfacesVistas;
using MvpWinformsApp.Modelo;

namespace MvpWinformsApp.Logica
{
    //Esta clase contiene la (en este caso muy simple) lógica de la aplicación
    class Presentador
    {
        private readonly IVentanaPrincipalUI ventanaPrincipal;
        private readonly IFactoriaDeUI factoriaDeUi;
        private readonly IRepositorioDePersonal repositorioDePersonal;

        private string solicitud; //Tipo string para simplificar, se podría usar un enum

        public Presentador(
            IVentanaPrincipalUI ventanaPrincipal, 
            IFactoriaDeUI factoriaDeUi, 
            IRepositorioDePersonal repositorioDePersonal)
        {
            this.ventanaPrincipal = ventanaPrincipal;
            this.factoriaDeUi = factoriaDeUi;
            this.repositorioDePersonal = repositorioDePersonal;

            ventanaPrincipal.DatosSolicitados += VentanaPrincipal_DatosSolicitados;
            ventanaPrincipal.InasistenciasSolicitadas += VentanaPrincipal_InasistenciasSolicitadas;
        }

        private void VentanaPrincipal_DatosSolicitados(object sender, EventArgs eventArgs)
        {
            solicitud = "datos";
            MostrarListadoDeUsuarios();
        }

        private void VentanaPrincipal_InasistenciasSolicitadas(object sender, EventArgs eventArgs)
        {
            solicitud = "inasistencias";
            MostrarListadoDeUsuarios();
        }

        private void MostrarListadoDeUsuarios()
        {
            var usuarios = repositorioDePersonal.ObtenerPersonas();
            var uiParaListado = ObtenerInstanciaDe<IListadoDePersonalUI>();
            uiParaListado.EstablecerPersonas(usuarios);

            uiParaListado.PersonaSeleccionada += UiParaListado_PersonaSeleccionada;

            factoriaDeUi.Mostrar(uiParaListado);
        }

        T ObtenerInstanciaDe<T>() where T : class, IElementoDeUI
        {
            //Por simplicidad asumimos que siempre cerramos los formularios cuando éstos lo solicitan.
            //En una aplicación real podríamos no permitir el cierre en algunos casos.
            var instancia = factoriaDeUi.ObtenerInstanciaDe<T>();
            instancia.CierreSolicitado += (sender, args) => { (sender as IElementoDeUI).Cerrar(); };
            return instancia;
        }

        private void UiParaListado_PersonaSeleccionada(object sender, PersonaSeleccionadaEventArgs personaSeleccionadaEventArgs)
        {
            IElementoDeUI ui = null;
            var dni = personaSeleccionadaEventArgs.DniSeleccionado;

            if(solicitud == "datos")
            {
                var datosDePersona = repositorioDePersonal.ObtenerPersona(dni);
                var uiParaDatos = ObtenerInstanciaDe<IDatosDePersonalUI>();
                uiParaDatos.EstablecerPersona(datosDePersona);
                ui = uiParaDatos;

            }
            else if(solicitud == "inasistencias")
            {
                var datosDeInasistencias =
                    repositorioDePersonal.ObtenerInasistencias(dni);
                var uiParaInasistencias = ObtenerInstanciaDe<IInasistenciasDePersonalUI>();
                uiParaInasistencias.EstablecerInasistencias(datosDeInasistencias);
                ui = uiParaInasistencias;
            }
            else
            {
                throw new InvalidOperationException("Esto no debería estar pasando...");
            }

            factoriaDeUi.Mostrar(ui);
        }
    }
}
