using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AppDistribuciones
{
    public partial class frmMM1 : Form
    {
        Formulas formulas = new Formulas();
        ErrorProvider errorP = new ErrorProvider();
        int num = 0, tipo = 1;
        List<Tuple<string, int>> items = new List<Tuple<string, int>>
        {
            new Tuple<string, int>("Ls", 1),
            new Tuple<string, int>("Lq", 2),
            new Tuple<string, int>("Ws", 3),
            new Tuple<string, int>("Wq", 4),
            new Tuple<string, int>("Probabilidad de Uso", 5),
            new Tuple<string, int>("P(n)", 6)
        };
        public frmMM1()
        {
            InitializeComponent();
            setItems();
        }

        public void setItems()
        {
            // Asigna los elementos al ComboBox
            cmbTipos.DisplayMember = "Item1"; // Establece el texto visible
            cmbTipos.ValueMember = "Item2"; // Establece el valor asociado
            cmbTipos.DataSource = items; // Asigna la lista de elementos al ComboBox
        }
        private void btnObtener_Click(object sender, EventArgs e)
        {
            if (VerificarTextBoxLlenos())
            {
                getMM1();
            }
            else
            {
                formulas.MostrarMensajeError("Debe llenar los campos requeridos");
            }
        }

        private void txtLambda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                return;
            }

            // Verifica si el punto decimal ya se ha ingresado
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                errorP.Clear();
                txtMiu.Focus();
                e.Handled = true;
            }
        }

        private void txtMiu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                return;
            }

            // Verifica si el punto decimal ya se ha ingresado
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == (char)Keys.Enter && tipo == 6)
            {
                errorP.Clear();
                txtNum.Focus();
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                errorP.Clear();
                btnObtener.Focus();
                e.Handled = true;
            }
        }

        public bool VerificarTextBoxLlenos()
        {

            if (!string.IsNullOrWhiteSpace(txtLambda.Text) &&
                !string.IsNullOrWhiteSpace(txtMiu.Text)
            )
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public void setData()
        {
            formulas.λ = double.Parse(txtLambda.Text);
            formulas.µ = double.Parse(txtMiu.Text);

            if (!string.IsNullOrWhiteSpace(txtNum.Text))
            {
                num = int.Parse(txtNum.Text);
            }

        }

        public void getMM1()
        {
            setData();
            
            tipo = (int)cmbTipos.SelectedValue;

            switch(tipo)
            {
                case 1:
                    txtResultado.Text = formulas.getLs().ToString();
                    break;
                case 2:
                    txtResultado.Text = formulas.getLq().ToString();
                    break;
                case 3:
                    txtResultado.Text = formulas.getWs().ToString();
                    break;
                case 4:
                    txtResultado.Text = formulas.getWq().ToString();
                    break;
                case 5:
                    txtResultado.Text = formulas.getP().ToString();
                    break;
                case 6:
                    txtResultado.Text = formulas.getPn(num).ToString();
                    break;
                default: 
                    break;
            }

            setGraphs();
        }

        private void cmbTipos_ValueMemberChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipos_SelectedValueChanged(object sender, EventArgs e)
        {
            // Verifica si cmbTipos está inicializado y tiene elementos
            if (cmbTipos != null && cmbTipos.Items.Count > 0)
            {
                tipo = (int)cmbTipos.SelectedValue;
                if (tipo == 6)
                {
                    labelCantidad.Visible = true;
                    txtNum.Visible = true;
                }
                else
                {
                    labelCantidad.Visible = false;
                    txtNum.Visible = false;
                    txtNum.Text = "";
                }
            }
        }

        public void setGraphs()
        {
            // Limpiar las existentes
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart2.Series.Clear();
            chart2.ChartAreas.Clear();

            // Crear nueva de área de gráfico para chart1
            string chartAreaName1 = "Default1";
            ChartArea chartArea1 = new ChartArea(chartAreaName1);
            chart1.ChartAreas.Add(chartArea1);
            chart1.ChartAreas["Default1"].AxisX.Title = "Valores de λ";
            chart1.ChartAreas["Default1"].AxisY.Title = "Valores de µ";

            // Crear nueva serie para el gráfico chart1
            Series series1 = new Series("Gráfico de Líneas");
            series1.ChartType = SeriesChartType.Line; // Tipo de gráfico: Línea
            series1.ChartArea = chartAreaName1;
            chart1.Series.Add(series1);

            chartArea1.AxisX.Minimum = 0;
            chartArea1.AxisX.Maximum = double.Parse(txtLambda.Text); // Valor máximo igual a λ
            chartArea1.AxisY.Minimum = 0;
            chartArea1.AxisY.Maximum = double.Parse(txtMiu.Text); // Valor máximo igual a µ

            // Añadir puntos al gráfico basados en los valores de λ y µ
            series1.Points.AddXY(0, 0); 
            series1.Points.AddXY(double.Parse(txtLambda.Text), double.Parse(txtMiu.Text)); 

            // Crear nueva área de gráfico
            string chartAreaName = "Default";
            ChartArea chartArea = new ChartArea(chartAreaName);

            // Agregar el área de gráfico al control Chart
            chart2.ChartAreas.Add(chartArea);
            chart2.ChartAreas["Default"].AxisX.Title = "Valores de λ";
            chart2.ChartAreas["Default"].AxisY.Title = "Valores de µ";

            // Crear nueva serie para el gráfico de dispersión
            Series series = new Series("Gráfico de Dispersión");
            series.ChartType = SeriesChartType.Point; // Tipo de gráfico: Dispersión
            series.ChartArea = chartAreaName;

            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = double.Parse(txtLambda.Text); // Valor máximo igual a λ

            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Maximum = double.Parse(txtMiu.Text); // Valor máximo igual a µ

            // Agregar puntos al gráfico basados en los valores de λ y µ
            series.Points.AddXY(double.Parse(txtLambda.Text), double.Parse(txtMiu.Text));

            // Añadir la serie al control Chart
            chart2.Series.Add(series);

        }

    }
}
