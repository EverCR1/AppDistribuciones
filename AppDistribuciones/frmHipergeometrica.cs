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
    public partial class frmHipergeometrica : Form
    {

        Formulas formulas = new Formulas();
        ErrorProvider errorP = new ErrorProvider();
        public string resultadoPob = "Infinita";

        List<Tuple<string, int>> items = new List<Tuple<string, int>>
        {
            new Tuple<string, int>(">", 1),
            new Tuple<string, int>(">=", 2),
            new Tuple<string, int>("<", 3),
            new Tuple<string, int>("<=", 4),
            new Tuple<string, int>("=", 5)
        };

        public frmHipergeometrica()
        {
            
            InitializeComponent();
            chart1.MouseWheel += Chart1_MouseWheel;
            // Asigna los elementos al ComboBox
            cmbProb.DisplayMember = "Item1"; // Establece el texto visible
            cmbProb.ValueMember = "Item2"; // Establece el valor asociado
            cmbProb.DataSource = items; // Asigna la lista de elementos al ComboBox
        }

        //Acción de obtener los datos (Calcularlos)
        private void btnObtener_Click(object sender, EventArgs e)
        {
            if (VerificarTextBoxLlenos())
            {
                if (valPob())
                {
                    if (validarXmenorN())
                    {
                        if (validarPobMayor())
                        {
                            getP();
                            calcularHiper();
                            poissonAproximacion();
                        }
                        else
                        {
                            MostrarMensajeError("La muestra (n) no puede ser mayor a la población (N)");
                        }

                    }
                    else if (!validarXmenorN())
                    {
                        MostrarMensajeError("x no puede ser mayor que n");
                    }

                }
                else
                {
                    MostrarMensajeError("Este problema se debe resolver con distribución binomial");
                    frmBinomial frmBinomial = new frmBinomial();
                    
                    frmBinomial.txtPoblacion.Text = txtPoblacion.Text;
                    frmBinomial.txtN.Text = txtN.Text;
                    frmBinomial.txtX.Text = txtX.Text;

                    this.Hide();
                    frmBinomial.ShowDialog();
                    this.Close();
                }
                
            }
            else
            {
                MostrarMensajeError("Debe llenar todos los campos requeridos");
            }

        }


        //Obtener dinámicamente el valor de q
        private void txtP_TextChanged(object sender, EventArgs e)
        {
            if (txtP.Text.Length == 0)
            {
                txtQ.Text = "";
            }
            else
            {
                decimal resQ = 1 - decimal.Parse(txtP.Text);

                txtQ.Text = resQ.ToString();
            }


        }
        //Validar campos vacíos
        private bool VerificarTextBoxLlenos()
        {

            if (!string.IsNullOrWhiteSpace(txtN.Text) &&
                !string.IsNullOrWhiteSpace(txtX.Text) &&
                !string.IsNullOrWhiteSpace(txtK.Text) &&
                !string.IsNullOrWhiteSpace(txtPoblacion.Text)
            )
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        //Evento tras presionar una tecla en el TextBox N
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
                errorP.SetError(txtX, "Solo se permiten números enteros");
            }
            else
            {
                errorP.Clear();
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                errorP.Clear();
                txtK.Focus();
                e.Handled = true;

            }
        }

        private void txtK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquea la tecla presionada
                errorP.SetError(txtK, "Solo se permiten números enteros");
            }
            else
            {
                errorP.Clear();
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                errorP.Clear();
                btnObtener.Focus();
                e.Handled = true;

            }
        }

        private void txtPoblacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquea la tecla presionada
                errorP.SetError(txtPoblacion, "Solo se permiten números");
            }
            else
            {
                errorP.Clear();
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                errorP.Clear();
                txtN.Focus();
                e.Handled = true;
            }
        }

        //Función para generar el gráfico de distribución hipergeométrica
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

            Series series = new Series("Distribución Hipergeométrica");
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
                double probabilidad = formulas.formHipergeometrica();
                series.Points.AddXY(i, probabilidad);

            }
            chart1.Series.Add(series);

        }

        //Validar coherencia
        private bool validarXmenorN()
        {
            int n = int.Parse(txtN.Text);
            int x = int.Parse(txtX.Text);

            if (x > n)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Obtener p
        private void getP()
        {
            double valor = double.Parse(txtK.Text) / double.Parse(txtPoblacion.Text);
            formulas.p = valor;
            formulas.q = 1 - valor;
            txtP.Text = formulas.p.ToString("0.00");
        }

        //Validar Coherencia 2
        private bool validarPobMayor()
        {
            int n = int.Parse(txtN.Text);
            int N = int.Parse(txtPoblacion.Text);

            if (n > N)
            {
                return false;
            }
            else
            {
                return true;
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
                double probabilidad = formulas.formHipergeometrica();

                // Sumar la probabilidad a la acumulada
                probabilidadAcumulada += probabilidad;

                // Calcular el porcentaje
                double porcentaje = Math.Round(probabilidadAcumulada * 100, 2);

                // Agregar fila al DataGridView
                dataTab1.Rows.Add(i, probabilidad, probabilidadAcumulada, porcentaje);
            }
        }

        //Obtener el tipo de población
        public bool valPob()
        {
            int poblacion = int.Parse(txtPoblacion.Text);
            int muestra = int.Parse(txtN.Text);

            decimal porcentaje = (muestra * 100) / poblacion;

            if (porcentaje <= 20.00m)
            {
                return false;
            }
            else
            {
                return true;
            }

        }


        public void calcularHiper()
        {
            formulas.N = int.Parse(txtPoblacion.Text);
            formulas.n = int.Parse(txtN.Text);
            formulas.x = int.Parse(txtX.Text);
            formulas.K = int.Parse(txtK.Text);
            //formulas.p = double.Parse(txtP.Text);
            //formulas.q = 1 - double.Parse(txtP.Text);

            // Calcular la distribución hipergeométrica
            double result = formulas.formHipergeometrica();
            txtResultadoHiper.Text = result.ToString();

            // Mostrar la media
            double med = formulas.getMediaHiper();
            txtMedia.Text = med.ToString();

            // Mostrar la desviación estándar
            double desv = formulas.getDesvHiper();
            txtDesv.Text = desv.ToString();

            //Mostrar el sesgo
            double ses = formulas.calcSesgo();
            txtSesgo.Text = formulas.Se + " = " + ses.ToString();

            //Mostrar la curtosis
            double curt = formulas.calcCurtosis();
            txtCurtosis.Text = formulas.Cu + " = " + curt.ToString();

            llenarTabla();

            GenerarGrafico();

            getAceptacion();
        }

        private void ResaltarFila(double valorAceptacion, int tipoComparacion)
        {
            DataGridViewCellStyle estiloResaltado = new DataGridViewCellStyle();
            estiloResaltado.BackColor = Color.LightGreen;

            int indiceFilaResaltada = -1; // Índice de la fila que se resaltará

            // Iterar sobre las filas y encontrar la fila más cercana al valor de aceptación
            double diferenciaMinima = double.MaxValue;
            foreach (DataGridViewRow fila in dataTab1.Rows)
            {
                double valorFila = Convert.ToDouble(fila.Cells["Porcentaje"].Value);

                // Comparar el valor de la fila con el valor de aceptación según el tipo de comparación
                bool comparacionValida = false;
                switch (tipoComparacion)
                {
                    case 1: // Mayor que
                        comparacionValida = valorFila > valorAceptacion;
                        break;
                    case 2: // Mayor o igual que
                        comparacionValida = valorFila >= valorAceptacion;
                        break;
                    case 3: // Menor que
                        comparacionValida = valorFila < valorAceptacion;
                        break;
                    case 4: // Menor o igual que
                        comparacionValida = valorFila <= valorAceptacion;
                        break;
                    case 5: // Igual que
                        if (Math.Abs(valorFila - valorAceptacion) < diferenciaMinima)
                        {
                            diferenciaMinima = Math.Abs(valorFila - valorAceptacion);
                            indiceFilaResaltada = fila.Index;
                        }
                        continue;
                }

                // Si la comparación es válida y la diferencia es menor, actualizar el índice de la fila resaltada
                if (comparacionValida && Math.Abs(valorFila - valorAceptacion) < diferenciaMinima)
                {
                    diferenciaMinima = Math.Abs(valorFila - valorAceptacion);
                    indiceFilaResaltada = fila.Index;
                }
            }

            // Resaltar la fila encontrada (si se encontró alguna)
            if (indiceFilaResaltada != -1)
            {
                dataTab1.Rows[indiceFilaResaltada].DefaultCellStyle = estiloResaltado;
            }
            else
            {
                // Mensaje de prueba
                if (tipoComparacion == 5)
                {
                    Console.WriteLine("No existe");
                }
            }
        }

        // Cálculos para la Probabilidad de Aceptación
        private void getAceptacion()
        {
            if (!string.IsNullOrWhiteSpace(txtAceptacion.Text))
            {

                // Obtener valores del textbox Aceptación y del ComboBox del tipo
                double valorAceptacion = double.Parse(txtAceptacion.Text);
                int tipoComparacion = (int)cmbProb.SelectedValue;

                if (valorAceptacion < 0 || valorAceptacion > 100)
                {
                    MostrarMensajeError("El porcentaje de valor de aceptación debe estar entre 0 y 100");
                }
                else
                {
                    ResaltarFila(valorAceptacion, tipoComparacion);
                }

            }
            else
            {

            }
        }

        private void poissonAproximacion()
        {
            if (checkPoisson.Checked)
            {
                formulas.u = formulas.getMedia();
                tablaPoissonBinomial();
            }
            else
            {

            }
        }

        public void tablaPoissonBinomial()
        {
            // Limpiar el DataGridView antes de agregar nuevos datos
            dataTab2.Rows.Clear();

            // Define las columnas del DataGridView si aún no están definidas
            if (dataTab2.Columns.Count == 0)
            {
                dataTab2.Columns.Add("X", "X");
                dataTab2.Columns.Add("Hipergeométrica", "Hipergeométrica");
                dataTab2.Columns.Add("Poisson", "Poisson");
                dataTab2.Columns.Add("Diferencia", "Diferencia");
            }

            // Calcular y agregar los datos a la serie

            for (int i = 0; i <= formulas.n; i++)
            {
                formulas.x = i; // Actualizar el valor de x
                double hiper = formulas.formHipergeometrica();

                double poisson = formulas.getPoisson();

                double diferencia = hiper - poisson;

                // Agregar fila al DataGridView
                dataTab2.Rows.Add(i, hiper, poisson, hiper);
            }
        }

        private void MostrarMensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
