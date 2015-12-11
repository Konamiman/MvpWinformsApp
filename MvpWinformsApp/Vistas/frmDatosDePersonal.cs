using System;
using MvpWinformsApp.InterfacesVistas;
using MvpWinformsApp.Vistas.Vistas.Modelo;

namespace MvpWinformsApp.Vistas
{
    public partial class frmDatosDePersonal : FormBase, IDatosDePersonalUI
    {
        public frmDatosDePersonal()
        {
            InitializeComponent();
        }

        public void EstablecerPersona(PersonaEnDetalle persona)
        {
            lblDatosAdicionales.Text = persona.InformacionAdicional;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            EmitirCierreSolicitado();
        }
    }
}
