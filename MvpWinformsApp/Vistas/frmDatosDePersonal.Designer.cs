namespace MvpWinformsApp.Vistas
{
    partial class frmDatosDePersonal
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
            this.lblDatosAdicionales = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDatosAdicionales
            // 
            this.lblDatosAdicionales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatosAdicionales.AutoSize = true;
            this.lblDatosAdicionales.Location = new System.Drawing.Point(28, 13);
            this.lblDatosAdicionales.Name = "lblDatosAdicionales";
            this.lblDatosAdicionales.Size = new System.Drawing.Size(46, 17);
            this.lblDatosAdicionales.TabIndex = 0;
            this.lblDatosAdicionales.Text = "label1";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(329, 220);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(90, 41);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmDatosDePersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 283);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblDatosAdicionales);
            this.Name = "frmDatosDePersonal";
            this.Text = "Datos del Personal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatosAdicionales;
        private System.Windows.Forms.Button btnCerrar;
    }
}