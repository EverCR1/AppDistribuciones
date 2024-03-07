using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace AppDistribuciones
{
    internal class Formulas
    {
        public int n { get; set; } // Población Muestra
        public int x { get; set; } // Números de intentos
        public double p { get; set; } // Probabilidad de éxito
        public double q { get; set; } // Probabilidad de fracaso
        public double Fc { get; set; } // Factor de corrección
        public double o { get; set; } // Desviación estándar Pob Finita
        public int N { get; set; } // Población Total
        public string Se { get; set; } // Sesgo
        public string Cu { get; set; } // Curtosis
        public int K { get; set; } // K para la distribución hipergeométrica

        public double e = 2.7182818284; // Número de Euler
        public double u { get; set; } // Media para Poisson

        private Dictionary<int, double> factoriales;

        public Formulas()
        {
            factoriales = new Dictionary<int, double>();
        }

        private double CalcularFactorial(int numero)
        {
            if (numero <= 1)
                return 1;

            if (factoriales.ContainsKey(numero))
                return factoriales[numero];

            double factorial = 1;
            for (int i = 2; i <= numero; i++)
            {
                factorial *= i;
            }

            factoriales[numero] = factorial;
            return factorial;
        }

        public double formBinomial()
        {
            double nN = CalcularFactorial(n);
            double nX = CalcularFactorial(x);
            double nN_X = CalcularFactorial(n - x);

            double pX = Math.Pow(p, x);
            double qN_X = Math.Pow(1 - p, n - x);

            double resFinal = (nN / (nX * nN_X)) * (pX * qN_X);

            return resFinal;
        }


        //Media de población
        public double getMedia()
        {
            double res = n * p;
            return res;
        }

        //Desviación Población Infinita
        public double calcDesv()
        {
            double res1 = n * p * q;


            double result = Math.Sqrt(res1);

            return result;
        }

        //Factor de Corrección
        public double calcFc()
        {
            double prev = (double)(N - n) / (N - 1);


            double res = Math.Sqrt(prev);
            return res;
        }

        //Desviación Estándar con Población Finita
        public double calcDesvFi()
        {
            double FactCo = calcFc();

            double prev = (double)(n * p * q);

            double res = FactCo * Math.Sqrt(prev);

            return res;
        }

        //Calcular Sesgo
        public double calcSesgo()
        {
            double prev1 = q - p;
            double prev2 = (double)(n * p * q);

            double prev3 = Math.Sqrt(prev2);

            double res = prev1 / prev3;

            if (res < 0)
            {
                Se = "Negativo";
            }
            else if (res == 0)
            {
                Se = "Neutro";
            }

            else
            {
                Se = "Positivo";
            }

            return res;
        }

        //Calcular Curtosis
        public double calcCurtosis()
        {
            double prev1 = 1 - (6 * p * q);
            double prev2 = (double)(n * p * q);

            double prev3 = Math.Sqrt(prev2);

            double res = 3 + prev1 / prev3;

            if (res < 0)
            {
                Cu = "Platicúrtica";
            }
            else if (res == 0)
            {
                Cu = "Mesocúrtica";
            }

            else
            {
                Cu = "Leptocúrtica";
            }

            return res;
        }


        //Distribución Hipergeométrica
        public double formHipergeometrica()
        {
            double numerador = CalcularFactorial(N - K) * CalcularFactorial(K) * CalcularFactorial(n) * CalcularFactorial(N - n);
            double denominador = CalcularFactorial(n - x) * CalcularFactorial(N - K - n + x) * CalcularFactorial(x) * CalcularFactorial(K - x) * CalcularFactorial(N);

            double res = (double)numerador / (double)denominador;
            return res;
        }


        // Obtener la media de la distribución hipergeométrica
        public double getMediaHiper()
        {
            double res = (n * K) / N;
            return res;
        }

        // Obtener la desviación estándar de la distribución hipergeométrica
        public double getDesvHiper()
        {
            //p = (double)K / N;

            //q = 1 - p;

            double prev = (n * p * q) * ((double)(N - n) / (N - 1));

            double res = Math.Sqrt(prev);

            return res;
        }


        // Fórmula de Poisson
        public double getPoisson()
        {
            double numerador = (Math.Pow(e, -u)) * (Math.Pow(u, x));
            double denominador = CalcularFactorial(x);

            double resultado = numerador / denominador;
            return resultado;
        }

        // Desviación Estándar de Poisson
        public double getDesvPoisson()
        {
            double desviacion = Math.Sqrt(u);

            return desviacion;
        }


    }
}


