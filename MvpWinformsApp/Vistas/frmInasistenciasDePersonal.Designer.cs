namespace MvpWinformsApp.Vistas
{
    partial class frmInasistenciasDePersonal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridInasistencias = new System.Windows.Forms.DataGridView();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridInasistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // gridInasistencias
            // 
            this.gridInasistencias.AllowUserToAddRows = false;
            this.gridInasistencias.AllowUserToDeleteRows = false;
            this.gridInasistencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridInasistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInasistencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Motivo,
            this.Desde,
            this.Hasta});
            this.gridInasistencias.Location = new System.Drawing.Point(1, 2);
            this.gridInasistencias.Name = "gridInasistencias";
            this.gridInasistencias.ReadOnly = true;
            this.gridInasistencias.RowTemplate.Height = 24;
            this.gridInasistencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridInasistencias.Size = new System.Drawing.Size(627, 309);
            this.gridInasistencias.TabIndex = 0;
            // 
            // Motivo
            // 
            this.Motivo.DataPropertyName = "Motivo";
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.MinimumWidth = 200;
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            this.Motivo.Width = 200;
            // 
            // Desde
            // 
            this.Desde.DataPropertyName = "Desde";
            this.Desde.HeaderText = "Desde";
            this.Desde.Name = "Desde";
            this.Desde.ReadOnly = true;
            // 
            // Hasta
            // 
            this.Hasta.DataPropertyName = "Hasta";
            this.Hasta.HeaderText = "Hasta";
            this.Hasta.Name = "Hasta";
            this.Hasta.ReadOnly = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(513, 330);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(95, 37);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmInasistenciasDePersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 388);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gridInasistencias);
            this.Name = "frmInasistenciasDePersonal";
            this.Text = "Inasistencias del Personal";
            ((System.ComponentModel.ISupportInitialize)(this.gridInasistencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridInasistencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hasta;
        private System.Windows.Forms.Button btnCerrar;
    }
}