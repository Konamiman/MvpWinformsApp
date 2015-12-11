using MvpWinformsApp.Vistas.Vistas.Modelo;

namespace MvpWinformsApp.InterfacesVistas
{
    interface IDatosDePersonalUI : IElementoDeUI
    {
        void EstablecerPersona(PersonaEnDetalle persona);
    }
}
