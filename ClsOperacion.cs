using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WeBcalculadora
{
    public class ClsOperacion
    {
        public static float valor1 { get; set; }
        public static float valor2 { get; set; }

        public static bool sumar = false;
        public static bool restar = false;
        public static bool multiplicar = false;
        public static bool dividir = false;
        public static bool factorial = false;
        public static bool exponente2 = false;
        public static bool exponente3 = false;
        public static bool raiz = false;
        public static bool fibonacci = false;

        public static float metodo_sumar(float v1, float v2)
        {
            return v1 + v2;
        }

        public static float metodo_restar(float v1, float v2)
        {
            return v1 - v2;
        }
        public static float metodo_multiplicar(float v1, float v2)
        {
            return v1 * v2;
        }
        public static float metodo_dividir(float v1, float v2)
        {
            if (v2 == 0)
                throw new ArgumentException("No se puede dividir por cero.");
            return v1 / v2;
        }
        public static float metodo_exponente2(float v)
        {
            return v * v;
        }
        public static float metodo_exponente3(float v)
        {
            return v * v * v;
        }
        public static float metodo_raiz(float v)
        {
            if (v < 0)
                throw new ArgumentException("No se puede calcular la raíz cuadrada de un número negativo.");
            return (float)Math.Sqrt(v);
        }
        public static long metodo_factorial(int v)
        {
            if (v < 0)
                throw new ArgumentException("No se puede calcular el factorial de un número negativo.");
            long result = 1;
            for (int i = 2; i <= v; i++)
                result *= i;
            return result;
        }
        public static long metodo_fibonacci(int v)
        {
            if (v < 0)
                throw new ArgumentException("No se puede calcular Fibonacci de un número negativo.");
            if (v == 0) return 0;
            if (v == 1) return 1;
            long a = 0, b = 1, temp;
            for (int i = 2; i <= v; i++)
            {
                temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }
    }
}

