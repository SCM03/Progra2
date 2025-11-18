using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeBcalculadora
{
    public partial class Calculadora : System.Web.UI.Page
    {
        private static string operacionActual = "";
        private static float valor1 = 0;
        private static bool nuevaOperacion = false;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // Botones numéricos del 0 al 9
        protected void b0_Click(object sender, EventArgs e)
        {
            AgregarNumero("0");
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            AgregarNumero("1");
        }

        protected void b2_Click(object sender, EventArgs e)
        {
            AgregarNumero("2");
        }

        protected void b3_Click(object sender, EventArgs e)
        {
            AgregarNumero("3");
        }

        protected void b4_Click(object sender, EventArgs e)
        {
            AgregarNumero("4");
        }

        protected void b5_Click(object sender, EventArgs e)
        {
            AgregarNumero("5");
        }

        protected void b6_Click(object sender, EventArgs e)
        {
            AgregarNumero("6");
        }

        protected void b7_Click(object sender, EventArgs e)
        {
            AgregarNumero("7");
        }

        protected void b8_Click(object sender, EventArgs e)
        {
            AgregarNumero("8");
        }

        protected void b9_Click(object sender, EventArgs e)
        {
            AgregarNumero("9");
        }

        protected void bpunto_Click(object sender, EventArgs e)
        {
            if (!lresultado.Text.Contains("."))
            {
                if (string.IsNullOrEmpty(lresultado.Text))
                    lresultado.Text = "0.";
                else
                    lresultado.Text += ".";
            }
        }

        private void AgregarNumero(string numero)
        {
            if (nuevaOperacion)
            {
                lresultado.Text = "";
                nuevaOperacion = false;
            }
            lresultado.Text += numero;
        }

        // Operaciones básicas
        protected void bsuma_Click(object sender, EventArgs e)
        {
            PrepararOperacion("+");
        }

        protected void bresta_Click(object sender, EventArgs e)
        {
            PrepararOperacion("-");
        }

        protected void bmultiplicar_Click(object sender, EventArgs e)
        {
            PrepararOperacion("*");
        }

        protected void bdividir_Click(object sender, EventArgs e)
        {
            PrepararOperacion("/");
        }

        private void PrepararOperacion(string operacion)
        {
            if (float.TryParse(lresultado.Text, out float valor))
            {
                valor1 = valor;
                operacionActual = operacion;
                nuevaOperacion = true;
            }
            else
            {
                lresultado.Text = "Error";
            }
        }

        protected void bresultado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(operacionActual))
            {
                return;
            }

            if (float.TryParse(lresultado.Text, out float valor2))
            {
                try
                {
                    float resultado = 0;
                    switch (operacionActual)
                    {
                        case "+":
                            resultado = ClsOperacion.metodo_sumar(valor1, valor2);
                            break;
                        case "-":
                            resultado = ClsOperacion.metodo_restar(valor1, valor2);
                            break;
                        case "*":
                            resultado = ClsOperacion.metodo_multiplicar(valor1, valor2);
                            break;
                        case "/":
                            resultado = ClsOperacion.metodo_dividir(valor1, valor2);
                            break;
                    }
                    lresultado.Text = resultado.ToString();
                    operacionActual = "";
                    nuevaOperacion = true;
                }
                catch (Exception ex)
                {
                    lresultado.Text = ex.Message;
                    operacionActual = "";
                }
            }
            else
            {
                lresultado.Text = "Error";
            }
        }

        // Operaciones avanzadas (usan solo el valor actual en pantalla)
        protected void bpot2_Click(object sender, EventArgs e)
        {
            if (float.TryParse(lresultado.Text, out float v1))
            {
                lresultado.Text = ClsOperacion.metodo_exponente2(v1).ToString();
                nuevaOperacion = true;
            }
            else
                lresultado.Text = "Error";
        }

        protected void bpot3_Click(object sender, EventArgs e)
        {
            if (float.TryParse(lresultado.Text, out float v1))
            {
                lresultado.Text = ClsOperacion.metodo_exponente3(v1).ToString();
                nuevaOperacion = true;
            }
            else
                lresultado.Text = "Error";
        }

        protected void braiz_Click(object sender, EventArgs e)
        {
            if (float.TryParse(lresultado.Text, out float v1))
            {
                try
                {
                    lresultado.Text = ClsOperacion.metodo_raiz(v1).ToString();
                    nuevaOperacion = true;
                }
                catch (Exception ex)
                {
                    lresultado.Text = ex.Message;
                }
            }
            else
                lresultado.Text = "Error";
        }

        protected void bfactorial_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lresultado.Text, out int v1))
            {
                try
                {
                    lresultado.Text = ClsOperacion.metodo_factorial(v1).ToString();
                    nuevaOperacion = true;
                }
                catch (Exception ex)
                {
                    lresultado.Text = ex.Message;
                }
            }
            else
                lresultado.Text = "Error";
        }

        protected void bfibonacci_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lresultado.Text, out int v1))
            {
                try
                {
                    lresultado.Text = ClsOperacion.metodo_fibonacci(v1).ToString();
                    nuevaOperacion = true;
                }
                catch (Exception ex)
                {
                    lresultado.Text = ex.Message;
                }
            }
            else
                lresultado.Text = "Error";
        }

        protected void bclear_Click(object sender, EventArgs e)
        {
            lresultado.Text = "";
            valor1 = 0;
            operacionActual = "";
            nuevaOperacion = false;
        }
    }
}