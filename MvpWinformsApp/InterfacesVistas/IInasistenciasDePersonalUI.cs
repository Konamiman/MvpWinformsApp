using System;
using System.Collections.Generic;
using MvpWinformsApp.Vistas.Vistas.Modelo;

namespace MvpWinformsApp.InterfacesVistas
{
    interface IInasistenciasDePersonalUI : IElementoDeUI
    {
        void EstablecerInasistencias(IEnumerable<Inasistencia> personas);

        event EventHandler CierreSolicitado;
    }
}
