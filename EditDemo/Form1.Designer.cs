namespace EditDemo
{
    partial class EditDemo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDemo));
            this.lblTipoEvento = new System.Windows.Forms.Label();
            this.lblTextoImprimir = new System.Windows.Forms.Label();
            this.lblNombreImpresora = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbTipoEvento = new System.Windows.Forms.TextBox();
            this.tbTextoImprimir = new System.Windows.Forms.TextBox();
            this.tbNombreImpresora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEstablecimiento = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTipoEvento
            // 
            resources.ApplyResources(this.lblTipoEvento, "lblTipoEvento");
            this.lblTipoEvento.Name = "lblTipoEvento";
            // 
            // lblTextoImprimir
            // 
            resources.ApplyResources(this.lblTextoImprimir, "lblTextoImprimir");
            this.lblTextoImprimir.Name = "lblTextoImprimir";
            // 
            // lblNombreImpresora
            // 
            resources.ApplyResources(this.lblNombreImpresora, "lblNombreImpresora");
            this.lblNombreImpresora.Name = "lblNombreImpresora";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.btnGuardar, "btnGuardar");
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbTipoEvento
            // 
            resources.ApplyResources(this.tbTipoEvento, "tbTipoEvento");
            this.tbTipoEvento.Name = "tbTipoEvento";
            // 
            // tbTextoImprimir
            // 
            resources.ApplyResources(this.tbTextoImprimir, "tbTextoImprimir");
            this.tbTextoImprimir.Name = "tbTextoImprimir";
            // 
            // tbNombreImpresora
            // 
            resources.ApplyResources(this.tbNombreImpresora, "tbNombreImpresora");
            this.tbNombreImpresora.Name = "tbNombreImpresora";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cbEstablecimiento
            // 
            this.cbEstablecimiento.FormattingEnabled = true;
            resources.ApplyResources(this.cbEstablecimiento, "cbEstablecimiento");
            this.cbEstablecimiento.Name = "cbEstablecimiento";
            // 
            // EditDemo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.cbEstablecimiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNombreImpresora);
            this.Controls.Add(this.tbTextoImprimir);
            this.Controls.Add(this.tbTipoEvento);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblNombreImpresora);
            this.Controls.Add(this.lblTextoImprimir);
            this.Controls.Add(this.lblTipoEvento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditDemo";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTipoEvento;
        private System.Windows.Forms.Label lblTextoImprimir;
        private System.Windows.Forms.Label lblNombreImpresora;
        private System.Windows.Forms.TextBox tbTipoEvento;
        private System.Windows.Forms.TextBox tbTextoImprimir;
        private System.Windows.Forms.TextBox tbNombreImpresora;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEstablecimiento;
    }
}

