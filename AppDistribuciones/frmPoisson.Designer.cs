namespace AppDistribuciones
{
    partial class frmPoisson
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCurtosis = new System.Windows.Forms.TextBox();
            this.txtSesgo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObtener = new System.Windows.Forms.Button();
            this.txtDesv = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtResultadoPoisson = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataTab1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.cmbProb = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAceptacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTab1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(60, 481);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 23);
            this.label12.TabIndex = 52;
            this.label12.Text = "Curtosis";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(60, 411);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 23);
            this.label11.TabIndex = 51;
            this.label11.Text = "Sesgo";
            // 
            // txtCurtosis
            // 
            this.txtCurtosis.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurtosis.Location = new System.Drawing.Point(42, 507);
            this.txtCurtosis.Name = "txtCurtosis";
            this.txtCurtosis.ReadOnly = true;
            this.txtCurtosis.Size = new System.Drawing.Size(240, 28);
            this.txtCurtosis.TabIndex = 50;
            // 
            // txtSesgo
            // 
            this.txtSesgo.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSesgo.Location = new System.Drawing.Point(42, 437);
            this.txtSesgo.Name = "txtSesgo";
            this.txtSesgo.ReadOnly = true;
            this.txtSesgo.Size = new System.Drawing.Size(240, 28);
            this.txtSesgo.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(415, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 23);
            this.label9.TabIndex = 48;
            this.label9.Text = "Desviación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 46;
            this.label7.Text = "Media u:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(421, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 45;
            this.label6.Text = "Resultado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Muestra n:";
            // 
            // btnObtener
            // 
            this.btnObtener.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObtener.Location = new System.Drawing.Point(112, 17);
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(175, 36);
            this.btnObtener.TabIndex = 39;
            this.btnObtener.Text = "ObtenerPoisson";
            this.btnObtener.UseVisualStyleBackColor = true;
            this.btnObtener.Click += new System.EventHandler(this.btnObtener_Click);
            // 
            // txtDesv
            // 
            this.txtDesv.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesv.Location = new System.Drawing.Point(414, 194);
            this.txtDesv.Name = "txtDesv";
            this.txtDesv.ReadOnly = true;
            this.txtDesv.Size = new System.Drawing.Size(100, 28);
            this.txtDesv.TabIndex = 38;
            // 
            // txtMedia
            // 
            this.txtMedia.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedia.Location = new System.Drawing.Point(137, 312);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(100, 28);
            this.txtMedia.TabIndex = 36;
            this.txtMedia.TextChanged += new System.EventHandler(this.txtMedia_TextChanged);
            this.txtMedia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMedia_KeyPress);
            // 
            // txtResultadoPoisson
            // 
            this.txtResultadoPoisson.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoPoisson.Location = new System.Drawing.Point(414, 90);
            this.txtResultadoPoisson.Name = "txtResultadoPoisson";
            this.txtResultadoPoisson.ReadOnly = true;
            this.txtResultadoPoisson.Size = new System.Drawing.Size(100, 28);
            this.txtResultadoPoisson.TabIndex = 35;
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(137, 90);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 28);
            this.txtN.TabIndex = 30;
            this.txtN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(835, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 28);
            this.label10.TabIndex = 57;
            this.label10.Text = "Gráfica";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(619, 59);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Distribución de Poisson";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(516, 266);
            this.chart1.TabIndex = 56;
            this.chart1.Text = "chart1";
            // 
            // dataTab1
            // 
            this.dataTab1.AllowUserToAddRows = false;
            this.dataTab1.AllowUserToDeleteRows = false;
            this.dataTab1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTab1.Location = new System.Drawing.Point(619, 342);
            this.dataTab1.Name = "dataTab1";
            this.dataTab1.ReadOnly = true;
            this.dataTab1.RowHeadersWidth = 51;
            this.dataTab1.RowTemplate.Height = 24;
            this.dataTab1.Size = new System.Drawing.Size(470, 272);
            this.dataTab1.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 64;
            this.label3.Text = "Valor p:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 63;
            this.label2.Text = "Valor x:";
            // 
            // txtP
            // 
            this.txtP.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP.Location = new System.Drawing.Point(137, 239);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(100, 28);
            this.txtP.TabIndex = 62;
            this.txtP.TextChanged += new System.EventHandler(this.txtP_TextChanged);
            this.txtP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtP_KeyPress);
            // 
            // txtX
            // 
            this.txtX.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX.Location = new System.Drawing.Point(137, 168);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 28);
            this.txtX.TabIndex = 61;
            this.txtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX_KeyPress);
            // 
            // cmbProb
            // 
            this.cmbProb.FormattingEnabled = true;
            this.cmbProb.Location = new System.Drawing.Point(364, 285);
            this.cmbProb.Name = "cmbProb";
            this.cmbProb.Size = new System.Drawing.Size(96, 24);
            this.cmbProb.TabIndex = 67;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(392, 247);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 23);
            this.label13.TabIndex = 66;
            this.label13.Text = "Prob. Aceptación:";
            // 
            // txtAceptacion
            // 
            this.txtAceptacion.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAceptacion.Location = new System.Drawing.Point(476, 282);
            this.txtAceptacion.Name = "txtAceptacion";
            this.txtAceptacion.Size = new System.Drawing.Size(100, 28);
            this.txtAceptacion.TabIndex = 65;
            // 
            // frmPoisson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1207, 649);
            this.Controls.Add(this.cmbProb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAceptacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.dataTab1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCurtosis);
            this.Controls.Add(this.txtSesgo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObtener);
            this.Controls.Add(this.txtDesv);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.txtResultadoPoisson);
            this.Controls.Add(this.txtN);
            this.Name = "frmPoisson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distribución de Poisson";
            this.Load += new System.EventHandler(this.frmPoisson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTab1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCurtosis;
        private System.Windows.Forms.TextBox txtSesgo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObtener;
        private System.Windows.Forms.TextBox txtDesv;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtResultadoPoisson;
        public System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataTab1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtP;
        public System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.ComboBox cmbProb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAceptacion;
    }
}