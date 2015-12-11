using System;

namespace MvpWinformsApp.InterfacesVistas
{
    interface IElementoDeUI
    {
        void Cerrar();

        event EventHandler CierreSolicitado;
    }
}
