using System;
using System.Windows.Forms;
using MvpWinformsApp.Infraestructura;
using MvpWinformsApp.InterfacesVistas;
using MvpWinformsApp.Logica;
using MvpWinformsApp.Modelo;

namespace MvpWinformsApp.Vistas
{
    static class Program
    {
        private static Presentador presentador;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //En una aplicación real se usaría algún contenedor de inyección de dependencias
            var formPrincipal = new frmMain();
            var factoriaDeUI = new FactoriaDeUI(formPrincipal);
            var repositorio = new RepositorioDePersonal();
            presentador = new Presentador(formPrincipal, factoriaDeUI, repositorio);

            Application.Run(formPrincipal);
        }
    }
}
