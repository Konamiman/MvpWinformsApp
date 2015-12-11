using System;
using System.Collections.Generic;
using MvpWinformsApp.Infraestructura;
using MvpWinformsApp.InterfacesVistas;
using MvpWinformsApp.Vistas.Vistas.Modelo;

namespace MvpWinformsApp.Vistas
{
    public partial class frmListadoDePersonal : FormBase, IListadoDePersonalUI
    {
        public frmListadoDePersonal()
        {
            InitializeComponent();
            btnOk.Enabled = false;
        }

        public event EventHandler<PersonaSeleccionadaEventArgs> PersonaSeleccionada;

        public void EstablecerPersonas(IEnumerable<PersonaResumida> personas)
        {
            gridPersonas.DataSource = personas;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            EmitirCierreSolicitado();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var dni = (gridPersonas.SelectedRows[0].DataBoundItem as PersonaResumida).Dni;
            PersonaSeleccionada(this, new PersonaSeleccionadaEventArgs {DniSeleccionado = dni});
        }

        private void gridPersonas_SelectionChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = true;
        }
    }
}
