using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaEjercicios
{
    internal class ClaseEnteros
    {
        double valor;
        public ClaseEnteros(double valor)
        {
            this.valor = valor;
        }
        public int calcularFormula()
        {
            return Convert.ToInt32(Math.Log(valor) / Math.Log(10)) + 1;
        }
    }
}
