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
    public partial class frmPoisson : Form
    {
        Formulas formulas = new Formulas();
        ErrorProvider errorP = new ErrorProvider();
        public frmPoisson()
        {
            InitializeComponent();
            chart1.MouseWheel += Chart1_MouseWheel;
            
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            
            if (VerificarTextBoxLlenos())
            {
                if (txtP.Text.Length > 0)
                {
                    getMedia();

                    showPoisson();

                    //txtMedia.Text = formulas.u.ToString();

                }
                if (txtMedia.Text.Length > 0)
                {
                    getProbExito();

                    showPoisson();

                    //txtP.Text = formulas.p.ToString();
                }
            }
            else
            {
                MostrarMensajeError("Debe llenar todos los campos requeridos");
            }
        }

        public void getPoisson()
        {

            formulas.n = int.Parse(txtN.Text);
            formulas.x = int.Parse(txtX.Text);

            double resultado = formulas.getPoisson();
            txtResultadoPoisson.Text = resultado.ToString();

            // Desviación estándar
            getDesviacion();

            // Sesgo
            getSesgo();

            // Curtosis
            getCurtosis();

            // Llenar la gráfica
            GenerarGrafico();

            // Llenar la tabla
            llenarTabla();

            
        }

        private void GenerarGrafico()
        {
            //Limpiar las existentes
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            //Crear nuevas instancias
            string chartAreaName = "Default";
            ChartArea chartArea = new ChartArea(chartAreaName);

            //Agregar las nuevas instancias al gráfico
            chart1.ChartAreas.Add(chartArea);
            chart1.ChartAreas["Default"].AxisX.Title = "Aciertos";
            chart1.ChartAreas["Default"].AxisY.Title = "Probabilidad";

            Series series = new Series("Distribución de Poisson");
            series.ChartType = SeriesChartType.Column;
            series.ChartArea = chartAreaName;

            //Ajustar la escala del eje X
            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = formulas.n;
            //chartArea.AxisX.Interval = 1;

            //Ajustar la escala del eje Y
            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Maximum = 1;
            //chartArea.AxisY.Interval = 0.1;

            //Calcular y agregar los datos a la serie
            for (int i = 0; i <= formulas.n; i++)
            {
                formulas.x = i; // Actualizar el valor de x
                double probabilidad = formulas.getPoisson();
                series.Points.AddXY(i, probabilidad);

            }
            chart1.Series.Add(series);

        }

        //Generar Tabla
        public void llenarTabla()
        {
            // Limpiar el DataGridView antes de agregar nuevos datos
            dataTab1.Rows.Clear();

            // Define las columnas del DataGridView si aún no están definidas
            if (dataTab1.Columns.Count == 0)
            {
                dataTab1.Columns.Add("X", "X");
                dataTab1.Columns.Add("Probabilidad", "Probabilidad");
                dataTab1.Columns.Add("ProbabilidadAcumulada", "Probabilidad Acumulada");
                dataTab1.Columns.Add("Porcentaje", "Porcentaje");
            }

            // Calcular y agregar los datos a la serie
            double probabilidadAcumulada = 0.0;
            for (int i = 0; i <= formulas.n; i++)
            {
                formulas.x = i; // Actualizar el valor de x
                double probabilidad = formulas.getPoisson();

                // Sumar la probabilidad a la acumulada
                probabilidadAcumulada += probabilidad;

                // Calcular el porcentaje
                double porcentaje = Math.Round(probabilidadAcumulada * 100, 2);

                // Agregar fila al DataGridView
                dataTab1.Rows.Add(i, probabilidad, probabilidadAcumulada, porcentaje);
            }
        }

        private void Chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            Chart chart = sender as Chart;

            // Obtener el eje X y el eje Y del gráfico
            Axis xAxis = chart.ChartAreas[0].AxisX;
            Axis yAxis = chart.ChartAreas[0].AxisY;

            // Definir la cantidad de zoom
            double zoomFactor = 0.1; // Puedes ajustar este valor según tus necesidades

            // Calcular el factor de escala para el zoom
            double xScale = 1 + zoomFactor * (e.Delta > 0 ? 1 : -1);
            double yScale = 1 + zoomFactor * (e.Delta > 0 ? 1 : -1);

            // Aplicar el zoom a los ejes
            xAxis.ScaleView.Zoom(xAxis.ScaleView.ViewMinimum * xScale, xAxis.ScaleView.ViewMaximum * xScale);
            yAxis.ScaleView.Zoom(yAxis.ScaleView.ViewMinimum * yScale, yAxis.ScaleView.ViewMaximum * yScale);
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquea la tecla presionada
                errorP.SetError(txtN, "Solo se permiten números");
            }
            else
            {
                errorP.Clear();
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                errorP.Clear();
                txtX.Focus();
                e.Handled = true;

            }
        }

        private void txtX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquea la tecla presionada
                errorP.SetError(txtX, "Solo se permiten números");
            }
            else
            {
                errorP.Clear();
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                errorP.Clear();
                txtP.Focus();
                e.Handled = true;

            }
        }

        private void txtP_KeyPress(object sender, KeyPressEventArgs e)
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
                btnObtener.Focus();
                e.Handled = true;
            }
        }

        private void txtMedia_KeyPress(object sender, KeyPressEventArgs e)
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
                btnObtener.Focus();
                e.Handled = true;
            }
        }

        public bool VerificarTextBoxLlenos()
        {

            if (!string.IsNullOrWhiteSpace(txtN.Text) &&
                !string.IsNullOrWhiteSpace(txtX.Text) 
            )
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool validarMedia()
        {
            if (!string.IsNullOrWhiteSpace(txtMedia.Text)){
                double media = double.Parse(txtMedia.Text);
                if (media > 0 && media <= 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                double media = formulas.u;

                if (media > 0 && media <= 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


            
        }

        public bool validarProbExito()
        {
            double pExito = formulas.p;

            if(pExito > 0 && pExito < 0.10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void getProbExito()
        {
            
            double media = double.Parse(txtMedia.Text);
            int n = int.Parse(txtN.Text);

            formulas.u = media;

            double probabilidad = media / n;

            formulas.p = probabilidad;

            formulas.q = 1 - probabilidad;
            
        }

        public void getMedia()
        {
            formulas.n = int.Parse(txtN.Text);
            formulas.p = double.Parse(txtP.Text);
            
            double media = formulas.getMedia();
            formulas.u = media;

        }

        public void getDesviacion()
        {
            double desv = formulas.getDesvPoisson();
            txtDesv.Text = desv.ToString();
        }

        public void getSesgo()
        {
            //Mostrar el sesgo
            double ses = formulas.calcSesgo();
            txtSesgo.Text = formulas.Se + " = " + ses.ToString();
        }

        public void getCurtosis()
        {
            //Mostrar la curtosis
            double curt = formulas.calcCurtosis();
            txtCurtosis.Text = formulas.Cu + " = " + curt.ToString();
        }

        public void showPoisson()
        {
            if (validarMedia() && validarProbExito())
            {
                getPoisson();
                txtMedia.Text = formulas.u.ToString();
                txtP.Text = formulas.p.ToString();

                txtMedia.ReadOnly = false;
                txtP.ReadOnly = false;
            }
            else
            {
                DialogResult result = MostrarMensajeError("Este cálculo se debe resolver con distribución binomial");

                if (result == DialogResult.OK)
                {
                    frmBinomial frmBinomial = new frmBinomial();

                    frmBinomial.txtN.Text = txtN.Text;
                    frmBinomial.txtX.Text = txtX.Text;
                    frmBinomial.txtP.Text = formulas.p.ToString();
                    frmBinomial.txtQ.Text = (1-formulas.p).ToString();

                    this.Hide();
                    frmBinomial.ShowDialog();
                    this.Close();
                }

            }
        }

        private DialogResult MostrarMensajeError(string mensaje)
        {
            return MessageBox.Show(mensaje, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void txtP_TextChanged(object sender, EventArgs e)
        {
            if(txtP.Text.Length > 0)
            {
                txtMedia.ReadOnly = true;
            }
            else
            {
                txtMedia.ReadOnly = false;
            }
        }

        private void txtMedia_TextChanged(object sender, EventArgs e)
        {
            if(txtMedia.Text.Length > 0)
            {
                txtP.ReadOnly = true;
            }
            else
            {
                txtP.ReadOnly = false;
            }
        }
    }
}
