using MvpWinformsApp.InterfacesVistas;

namespace MvpWinformsApp.Infraestructura
{
    interface IFactoriaDeUI
    {
        T ObtenerInstanciaDe<T>() where T : class, IElementoDeUI;

        void Mostrar<T>(T elementoDeUI) where T : class, IElementoDeUI;
    }
}
