namespace AppDistribuciones
{
    partial class frmBinomial
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
            this.txtN = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.txtPoblacion = new System.Windows.Forms.TextBox();
            this.txtResultadoBinomial = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtPob = new System.Windows.Forms.TextBox();
            this.txtDesv = new System.Windows.Forms.TextBox();
            this.btnObtener = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSesgo = new System.Windows.Forms.TextBox();
            this.txtCurtosis = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFC = new System.Windows.Forms.TextBox();
            this.labelFC = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAceptacion = new System.Windows.Forms.TextBox();
            this.cmbProb = new System.Windows.Forms.ComboBox();
            this.dataTab1 = new System.Windows.Forms.DataGridView();
            this.dataTab2 = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.checkPoisson = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTab1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTab2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(145, 120);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 28);
            this.txtN.TabIndex = 0;
            this.txtN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(542, 92);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Distribución Binomial";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(663, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.AxisViewChanged += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ViewEventArgs>(this.chart1_AxisViewChanged);
            // 
            // txtX
            // 
            this.txtX.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX.Location = new System.Drawing.Point(145, 190);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 28);
            this.txtX.TabIndex = 2;
            this.txtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX_KeyPress);
            // 
            // txtP
            // 
            this.txtP.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP.Location = new System.Drawing.Point(145, 261);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(100, 28);
            this.txtP.TabIndex = 3;
            this.txtP.TextChanged += new System.EventHandler(this.txtP_TextChanged);
            this.txtP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtP_KeyPress);
            // 
            // txtQ
            // 
            this.txtQ.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQ.Location = new System.Drawing.Point(145, 339);
            this.txtQ.Name = "txtQ";
            this.txtQ.ReadOnly = true;
            this.txtQ.Size = new System.Drawing.Size(100, 28);
            this.txtQ.TabIndex = 4;
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoblacion.Location = new System.Drawing.Point(145, 47);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(100, 28);
            this.txtPoblacion.TabIndex = 5;
            this.txtPoblacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPoblacion_KeyPress);
            // 
            // txtResultadoBinomial
            // 
            this.txtResultadoBinomial.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoBinomial.Location = new System.Drawing.Point(365, 120);
            this.txtResultadoBinomial.Name = "txtResultadoBinomial";
            this.txtResultadoBinomial.ReadOnly = true;
            this.txtResultadoBinomial.Size = new System.Drawing.Size(100, 28);
            this.txtResultadoBinomial.TabIndex = 6;
            // 
            // txtMedia
            // 
            this.txtMedia.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedia.Location = new System.Drawing.Point(365, 201);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.ReadOnly = true;
            this.txtMedia.Size = new System.Drawing.Size(100, 28);
            this.txtMedia.TabIndex = 7;
            // 
            // txtPob
            // 
            this.txtPob.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPob.Location = new System.Drawing.Point(365, 372);
            this.txtPob.Name = "txtPob";
            this.txtPob.ReadOnly = true;
            this.txtPob.Size = new System.Drawing.Size(100, 28);
            this.txtPob.TabIndex = 8;
            // 
            // txtDesv
            // 
            this.txtDesv.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesv.Location = new System.Drawing.Point(365, 284);
            this.txtDesv.Name = "txtDesv";
            this.txtDesv.ReadOnly = true;
            this.txtDesv.Size = new System.Drawing.Size(100, 28);
            this.txtDesv.TabIndex = 9;
            // 
            // btnObtener
            // 
            this.btnObtener.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObtener.Location = new System.Drawing.Point(360, 12);
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(125, 36);
            this.btnObtener.TabIndex = 10;
            this.btnObtener.Text = "Obtener";
            this.btnObtener.UseVisualStyleBackColor = true;
            this.btnObtener.Click += new System.EventHandler(this.btnObtener_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Valor n:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Valor x:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Valor p:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Valor q:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Población (N):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(372, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Resultado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(383, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Media";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(339, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tipo de Población";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(372, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Desviación";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(808, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 28);
            this.label10.TabIndex = 20;
            this.label10.Text = "Gráfica";
            // 
            // txtSesgo
            // 
            this.txtSesgo.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSesgo.Location = new System.Drawing.Point(33, 539);
            this.txtSesgo.Name = "txtSesgo";
            this.txtSesgo.ReadOnly = true;
            this.txtSesgo.Size = new System.Drawing.Size(240, 28);
            this.txtSesgo.TabIndex = 21;
            // 
            // txtCurtosis
            // 
            this.txtCurtosis.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurtosis.Location = new System.Drawing.Point(33, 609);
            this.txtCurtosis.Name = "txtCurtosis";
            this.txtCurtosis.ReadOnly = true;
            this.txtCurtosis.Size = new System.Drawing.Size(240, 28);
            this.txtCurtosis.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(51, 513);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 23);
            this.label11.TabIndex = 23;
            this.label11.Text = "Sesgo";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(51, 583);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 23);
            this.label12.TabIndex = 24;
            this.label12.Text = "Curtosis";
            // 
            // txtFC
            // 
            this.txtFC.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFC.Location = new System.Drawing.Point(33, 688);
            this.txtFC.Name = "txtFC";
            this.txtFC.ReadOnly = true;
            this.txtFC.Size = new System.Drawing.Size(100, 28);
            this.txtFC.TabIndex = 25;
            this.txtFC.Visible = false;
            // 
            // labelFC
            // 
            this.labelFC.AutoSize = true;
            this.labelFC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFC.Location = new System.Drawing.Point(35, 652);
            this.labelFC.Name = "labelFC";
            this.labelFC.Size = new System.Drawing.Size(167, 23);
            this.labelFC.TabIndex = 26;
            this.labelFC.Text = "Factor de Corrección";
            this.labelFC.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(61, 415);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 23);
            this.label13.TabIndex = 28;
            this.label13.Text = "Prob. Aceptación:";
            // 
            // txtAceptacion
            // 
            this.txtAceptacion.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAceptacion.Location = new System.Drawing.Point(145, 450);
            this.txtAceptacion.Name = "txtAceptacion";
            this.txtAceptacion.Size = new System.Drawing.Size(100, 28);
            this.txtAceptacion.TabIndex = 27;
            // 
            // cmbProb
            // 
            this.cmbProb.FormattingEnabled = true;
            this.cmbProb.Location = new System.Drawing.Point(33, 453);
            this.cmbProb.Name = "cmbProb";
            this.cmbProb.Size = new System.Drawing.Size(96, 24);
            this.cmbProb.TabIndex = 29;
            // 
            // dataTab1
            // 
            this.dataTab1.AllowUserToAddRows = false;
            this.dataTab1.AllowUserToDeleteRows = false;
            this.dataTab1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTab1.Location = new System.Drawing.Point(360, 440);
            this.dataTab1.Name = "dataTab1";
            this.dataTab1.ReadOnly = true;
            this.dataTab1.RowHeadersWidth = 51;
            this.dataTab1.RowTemplate.Height = 24;
            this.dataTab1.Size = new System.Drawing.Size(403, 272);
            this.dataTab1.TabIndex = 30;
            // 
            // dataTab2
            // 
            this.dataTab2.AllowUserToAddRows = false;
            this.dataTab2.AllowUserToDeleteRows = false;
            this.dataTab2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTab2.Location = new System.Drawing.Point(813, 440);
            this.dataTab2.Name = "dataTab2";
            this.dataTab2.ReadOnly = true;
            this.dataTab2.RowHeadersWidth = 51;
            this.dataTab2.RowTemplate.Height = 24;
            this.dataTab2.Size = new System.Drawing.Size(403, 272);
            this.dataTab2.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(522, 409);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 28);
            this.label14.TabIndex = 32;
            this.label14.Text = "Binomial";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(830, 409);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(363, 28);
            this.label15.TabIndex = 33;
            this.label15.Text = "Poisson como Aproximación a Binomial";
            // 
            // checkPoisson
            // 
            this.checkPoisson.AutoSize = true;
            this.checkPoisson.Location = new System.Drawing.Point(145, 12);
            this.checkPoisson.Name = "checkPoisson";
            this.checkPoisson.Size = new System.Drawing.Size(200, 20);
            this.checkPoisson.TabIndex = 34;
            this.checkPoisson.Text = "Poisson como Aproximación";
            this.checkPoisson.UseVisualStyleBackColor = true;
            // 
            // frmBinomial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1234, 724);
            this.Controls.Add(this.checkPoisson);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataTab2);
            this.Controls.Add(this.dataTab1);
            this.Controls.Add(this.cmbProb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAceptacion);
            this.Controls.Add(this.labelFC);
            this.Controls.Add(this.txtFC);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCurtosis);
            this.Controls.Add(this.txtSesgo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObtener);
            this.Controls.Add(this.txtDesv);
            this.Controls.Add(this.txtPob);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.txtResultadoBinomial);
            this.Controls.Add(this.txtPoblacion);
            this.Controls.Add(this.txtQ);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.txtN);
            this.Name = "frmBinomial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distribución Binomial";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTab1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTab2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txtResultadoBinomial;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtPob;
        private System.Windows.Forms.TextBox txtDesv;
        private System.Windows.Forms.Button btnObtener;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSesgo;
        private System.Windows.Forms.TextBox txtCurtosis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFC;
        private System.Windows.Forms.Label labelFC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAceptacion;
        private System.Windows.Forms.ComboBox cmbProb;
        private System.Windows.Forms.DataGridView dataTab1;
        public System.Windows.Forms.TextBox txtN;
        public System.Windows.Forms.TextBox txtX;
        public System.Windows.Forms.TextBox txtPoblacion;
        public System.Windows.Forms.TextBox txtP;
        public System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.DataGridView dataTab2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkPoisson;
    }
}