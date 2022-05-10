using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaEjercicios
{
    internal class ClaseCalculadora
    {
        public ClaseCalculadora(){}

        //Operaciones calculadora simple
        public int calcularSuma(int value1, int value2)  { return value1 + value2; }
        public int calcularResta(int value1, int value2) { return value1 - value2; }
        public int calcularProducto(int value1, int value2) { return value1 * value2; }
        public double calcularDivision(int value1, int value2) { return value1 / value2; }

        //Operaciones calculadora avanzada
        public double calcularPotencia2(double value1)
        {
            return Math.Pow(value1, 2);
        }
        public double calcularPotenciaX(double baseNum, double exponente)
        {
            return Math.Pow(baseNum, exponente);
        }
        public double calcularRaizCuadrada(double valor)
        {
            double x = Math.Sqrt(valor);
            x = Math.Round(x, 3);
            return x;
        }
        public double calcularLogXY(double valor1)
        {
            return Math.Round(Math.Log10(valor1), 3);
        }
        public int calcularMaximo(int valor1, int valor2)
        {
            return Math.Max(valor1, valor2);
        }
        public int calcularValorMin(int valor1, int valor2)
        {
            if (valor1 < valor2)
            {
                return valor1;
            }
            return valor2;
        }
        public int calcularValorMax(int valor1, int valor2)
        {
            if (valor1 > valor2)
            {
                return valor1;
            }
            return valor2;
        }
        public double calcularCoseno(double valor)
        {
            return Math.Round(Math.Cos(valor),3);
        }
        public double calcularSeno(double valor)
        {
            return Math.Round(Math.Sin(valor), 3);
        }
        public double calcularTangente(double valor)
        {
            return Math.Round(Math.Tan(valor), 3);
        }
    }
}
