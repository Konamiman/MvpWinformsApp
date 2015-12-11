using System;
using System.Collections.Generic;
using MvpWinformsApp.Infraestructura;
using MvpWinformsApp.Vistas.Vistas.Modelo;

namespace MvpWinformsApp.InterfacesVistas
{
    interface IListadoDePersonalUI : IElementoDeUI
    {
        void EstablecerPersonas(IEnumerable<PersonaResumida> personas);

        event EventHandler<PersonaSeleccionadaEventArgs> PersonaSeleccionada;

        event EventHandler CierreSolicitado;
    }
}
