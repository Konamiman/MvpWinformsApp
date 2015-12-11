using System;
using System.ComponentModel;
using System.Windows.Forms;
using MvpWinformsApp.InterfacesVistas;

namespace MvpWinformsApp.Vistas
{
    public partial class FormBase : Form, IElementoDeUI
    {
        public FormBase()
        {
            InitializeComponent();
        }

        public event EventHandler CierreSolicitado;

        private bool CerrarInvocado = false;

        protected void EmitirCierreSolicitado()
        {
            CierreSolicitado(this, EventArgs.Empty);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            if (!CerrarInvocado)
            {
                e.Cancel = true;
                CierreSolicitado(this, EventArgs.Empty);
            }
        }

        public void Cerrar()
        {
            CerrarInvocado = true;
            Close();
        }
    }
}
