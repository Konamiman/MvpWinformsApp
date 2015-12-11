using System;
using System.Windows.Forms;
using MvpWinformsApp.InterfacesVistas;

namespace MvpWinformsApp.Vistas
{
    partial class frmMain : Form, IVentanaPrincipalUI
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public event EventHandler DatosSolicitados;
        public event EventHandler InasistenciasSolicitadas;

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosSolicitados(this, EventArgs.Empty);
        }

        private void inasistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InasistenciasSolicitadas(this, EventArgs.Empty);
        }
    }
}
