namespace AppDistribuciones
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.distribucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distribuciónBinomialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distribuciónHipergeométricaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distribuciónDePoissonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeloMM1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.distribucionesToolStripMenuItem,
            this.modelosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // distribucionesToolStripMenuItem
            // 
            this.distribucionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.distribuciónBinomialToolStripMenuItem,
            this.distribuciónHipergeométricaToolStripMenuItem,
            this.distribuciónDePoissonToolStripMenuItem});
            this.distribucionesToolStripMenuItem.Name = "distribucionesToolStripMenuItem";
            this.distribucionesToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.distribucionesToolStripMenuItem.Text = "Distribuciones";
            // 
            // distribuciónBinomialToolStripMenuItem
            // 
            this.distribuciónBinomialToolStripMenuItem.Name = "distribuciónBinomialToolStripMenuItem";
            this.distribuciónBinomialToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.distribuciónBinomialToolStripMenuItem.Text = "Distribución Binomial";
            this.distribuciónBinomialToolStripMenuItem.Click += new System.EventHandler(this.distribuciónBinomialToolStripMenuItem_Click);
            // 
            // distribuciónHipergeométricaToolStripMenuItem
            // 
            this.distribuciónHipergeométricaToolStripMenuItem.Name = "distribuciónHipergeométricaToolStripMenuItem";
            this.distribuciónHipergeométricaToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.distribuciónHipergeométricaToolStripMenuItem.Text = "Distribución Hipergeométrica";
            this.distribuciónHipergeométricaToolStripMenuItem.Click += new System.EventHandler(this.distribuciónHipergeométricaToolStripMenuItem_Click);
            // 
            // distribuciónDePoissonToolStripMenuItem
            // 
            this.distribuciónDePoissonToolStripMenuItem.Name = "distribuciónDePoissonToolStripMenuItem";
            this.distribuciónDePoissonToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.distribuciónDePoissonToolStripMenuItem.Text = "Distribución de Poisson";
            this.distribuciónDePoissonToolStripMenuItem.Click += new System.EventHandler(this.distribuciónDePoissonToolStripMenuItem_Click);
            // 
            // modelosToolStripMenuItem
            // 
            this.modelosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeloMM1ToolStripMenuItem});
            this.modelosToolStripMenuItem.Name = "modelosToolStripMenuItem";
            this.modelosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.modelosToolStripMenuItem.Text = "Modelos";
            // 
            // modeloMM1ToolStripMenuItem
            // 
            this.modeloMM1ToolStripMenuItem.Name = "modeloMM1ToolStripMenuItem";
            this.modeloMM1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.modeloMM1ToolStripMenuItem.Text = "Modelo MM1";
            this.modeloMM1ToolStripMenuItem.Click += new System.EventHandler(this.modeloMM1ToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Modelos Discretos y Continuos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem distribucionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distribuciónBinomialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distribuciónHipergeométricaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distribuciónDePoissonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeloMM1ToolStripMenuItem;
    }
}

