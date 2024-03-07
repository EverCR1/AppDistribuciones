namespace AppDistribuciones
{
    partial class frmHipergeometrica
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataTab1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCurtosis = new System.Windows.Forms.TextBox();
            this.txtSesgo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObtener = new System.Windows.Forms.Button();
            this.txtDesv = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtResultadoHiper = new System.Windows.Forms.TextBox();
            this.txtPoblacion = new System.Windows.Forms.TextBox();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.cmbProb = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAceptacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTab1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTab1
            // 
            this.dataTab1.AllowUserToAddRows = false;
            this.dataTab1.AllowUserToDeleteRows = false;
            this.dataTab1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTab1.Location = new System.Drawing.Point(656, 424);
            this.dataTab1.Name = "dataTab1";
            this.dataTab1.ReadOnly = true;
            this.dataTab1.RowHeadersWidth = 51;
            this.dataTab1.RowTemplate.Height = 24;
            this.dataTab1.Size = new System.Drawing.Size(470, 272);
            this.dataTab1.TabIndex = 59;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(389, 494);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 23);
            this.label12.TabIndex = 55;
            this.label12.Text = "Curtosis";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(389, 424);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 23);
            this.label11.TabIndex = 54;
            this.label11.Text = "Sesgo";
            // 
            // txtCurtosis
            // 
            this.txtCurtosis.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurtosis.Location = new System.Drawing.Point(371, 520);
            this.txtCurtosis.Name = "txtCurtosis";
            this.txtCurtosis.ReadOnly = true;
            this.txtCurtosis.Size = new System.Drawing.Size(240, 28);
            this.txtCurtosis.TabIndex = 53;
            // 
            // txtSesgo
            // 
            this.txtSesgo.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSesgo.Location = new System.Drawing.Point(371, 450);
            this.txtSesgo.Name = "txtSesgo";
            this.txtSesgo.ReadOnly = true;
            this.txtSesgo.Size = new System.Drawing.Size(240, 28);
            this.txtSesgo.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(814, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 28);
            this.label10.TabIndex = 51;
            this.label10.Text = "Gráfica";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(378, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 23);
            this.label9.TabIndex = 50;
            this.label9.Text = "Desviación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(389, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 23);
            this.label7.TabIndex = 48;
            this.label7.Text = "Media";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(378, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 47;
            this.label6.Text = "Resultado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 46;
            this.label5.Text = "Población (N):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 23);
            this.label4.TabIndex = 45;
            this.label4.Text = "Valor q:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 44;
            this.label3.Text = "Valor p:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "Valor x:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "Valor n:";
            // 
            // btnObtener
            // 
            this.btnObtener.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObtener.Location = new System.Drawing.Point(366, 12);
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(125, 36);
            this.btnObtener.TabIndex = 41;
            this.btnObtener.Text = "Obtener";
            this.btnObtener.UseVisualStyleBackColor = true;
            this.btnObtener.Click += new System.EventHandler(this.btnObtener_Click);
            // 
            // txtDesv
            // 
            this.txtDesv.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesv.Location = new System.Drawing.Point(371, 284);
            this.txtDesv.Name = "txtDesv";
            this.txtDesv.ReadOnly = true;
            this.txtDesv.Size = new System.Drawing.Size(100, 28);
            this.txtDesv.TabIndex = 40;
            // 
            // txtMedia
            // 
            this.txtMedia.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedia.Location = new System.Drawing.Point(371, 201);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.ReadOnly = true;
            this.txtMedia.Size = new System.Drawing.Size(100, 28);
            this.txtMedia.TabIndex = 38;
            // 
            // txtResultadoHiper
            // 
            this.txtResultadoHiper.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoHiper.Location = new System.Drawing.Point(371, 120);
            this.txtResultadoHiper.Name = "txtResultadoHiper";
            this.txtResultadoHiper.ReadOnly = true;
            this.txtResultadoHiper.Size = new System.Drawing.Size(100, 28);
            this.txtResultadoHiper.TabIndex = 37;
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoblacion.Location = new System.Drawing.Point(151, 47);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(100, 28);
            this.txtPoblacion.TabIndex = 36;
            this.txtPoblacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPoblacion_KeyPress);
            // 
            // txtQ
            // 
            this.txtQ.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQ.Location = new System.Drawing.Point(151, 402);
            this.txtQ.Name = "txtQ";
            this.txtQ.ReadOnly = true;
            this.txtQ.Size = new System.Drawing.Size(100, 28);
            this.txtQ.TabIndex = 35;
            // 
            // txtP
            // 
            this.txtP.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP.Location = new System.Drawing.Point(151, 324);
            this.txtP.Name = "txtP";
            this.txtP.ReadOnly = true;
            this.txtP.Size = new System.Drawing.Size(100, 28);
            this.txtP.TabIndex = 34;
            this.txtP.TextChanged += new System.EventHandler(this.txtP_TextChanged);
            // 
            // txtX
            // 
            this.txtX.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX.Location = new System.Drawing.Point(151, 190);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 28);
            this.txtX.TabIndex = 33;
            this.txtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX_KeyPress);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(540, 92);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Distribución Binomial";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(586, 300);
            this.chart1.TabIndex = 32;
            this.chart1.Text = "chart1";
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(151, 120);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 28);
            this.txtN.TabIndex = 31;
            this.txtN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 23);
            this.label8.TabIndex = 61;
            this.label8.Text = "Valor k:";
            // 
            // txtK
            // 
            this.txtK.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtK.Location = new System.Drawing.Point(151, 258);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(100, 28);
            this.txtK.TabIndex = 60;
            this.txtK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtK_KeyPress);
            // 
            // cmbProb
            // 
            this.cmbProb.FormattingEnabled = true;
            this.cmbProb.Location = new System.Drawing.Point(39, 509);
            this.cmbProb.Name = "cmbProb";
            this.cmbProb.Size = new System.Drawing.Size(96, 24);
            this.cmbProb.TabIndex = 64;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(67, 471);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 23);
            this.label13.TabIndex = 63;
            this.label13.Text = "Prob. Aceptación:";
            // 
            // txtAceptacion
            // 
            this.txtAceptacion.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAceptacion.Location = new System.Drawing.Point(151, 506);
            this.txtAceptacion.Name = "txtAceptacion";
            this.txtAceptacion.Size = new System.Drawing.Size(100, 28);
            this.txtAceptacion.TabIndex = 62;
            // 
            // frmHipergeometrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1161, 803);
            this.Controls.Add(this.cmbProb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAceptacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.dataTab1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCurtosis);
            this.Controls.Add(this.txtSesgo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObtener);
            this.Controls.Add(this.txtDesv);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.txtResultadoHiper);
            this.Controls.Add(this.txtPoblacion);
            this.Controls.Add(this.txtQ);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.txtN);
            this.Name = "frmHipergeometrica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distribución Hipergeométrica";
            ((System.ComponentModel.ISupportInitialize)(this.dataTab1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTab1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCurtosis;
        private System.Windows.Forms.TextBox txtSesgo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObtener;
        private System.Windows.Forms.TextBox txtDesv;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtResultadoHiper;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbProb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAceptacion;
        public System.Windows.Forms.TextBox txtPoblacion;
        public System.Windows.Forms.TextBox txtX;
        public System.Windows.Forms.TextBox txtN;
        public System.Windows.Forms.TextBox txtK;
    }
}