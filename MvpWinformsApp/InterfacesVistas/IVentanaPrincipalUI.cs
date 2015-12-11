using System;

namespace MvpWinformsApp.InterfacesVistas
{
    interface IVentanaPrincipalUI
    {
        event EventHandler DatosSolicitados;

        event EventHandler InasistenciasSolicitadas;
    }
}
