using System;
using System.Collections.Generic;
using MvpWinformsApp.InterfacesVistas;
using MvpWinformsApp.Vistas.Vistas.Modelo;

namespace MvpWinformsApp.Vistas
{
    public partial class frmInasistenciasDePersonal : FormBase, IInasistenciasDePersonalUI
    {
        public frmInasistenciasDePersonal()
        {
            InitializeComponent();
        }

        public void EstablecerInasistencias(IEnumerable<Inasistencia> personas)
        {
            gridInasistencias.DataSource = personas;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            EmitirCierreSolicitado();
        }
    }
}
