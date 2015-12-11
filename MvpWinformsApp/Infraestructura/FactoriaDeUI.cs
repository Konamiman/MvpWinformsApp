using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MvpWinformsApp.InterfacesVistas;
using MvpWinformsApp.Vistas;

namespace MvpWinformsApp.Infraestructura
{
    class FactoriaDeUI : IFactoriaDeUI
    {
        private readonly Form formPrincipal;

        public FactoriaDeUI(Form formPrincipal)
        {
            this.formPrincipal = formPrincipal;
        }

        //En una aplicación real se usaría algún mecanismo más avanzado,
        //como reflexión basada en un convenio de nombres,
        //o atributos aplicados a las clases de formulario.
        private static IDictionary<Type, Type> formsSegunInterfaces = new Dictionary<Type, Type>
        {
            { typeof(IListadoDePersonalUI), typeof(frmListadoDePersonal) },
            { typeof(IInasistenciasDePersonalUI), typeof(frmInasistenciasDePersonal) },
            { typeof(IDatosDePersonalUI), typeof(frmDatosDePersonal) }
        };

        public T ObtenerInstanciaDe<T>() where T : class, IElementoDeUI
        {
            var tipo = formsSegunInterfaces[typeof(T)];
            var form = Activator.CreateInstance(tipo);
            return form as T;
        }

        public void Mostrar<T>(T elementoDeUI) where T : class, IElementoDeUI
        {
            (elementoDeUI as Form).Show(owner: formPrincipal);
        }
    }
}
