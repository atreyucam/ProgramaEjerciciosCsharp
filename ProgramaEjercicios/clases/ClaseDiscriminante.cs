using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaEjercicios
{
    internal class ClaseDiscriminante
    {
        double valorA, valorB,valorC;
        public ClaseDiscriminante(double valorA, double valorB, double valorC)
        {
            this.valorA = valorA;
            this.valorB = valorB;
            this.valorC = valorC;
        }
        public double calculoDiscriminante()
        {
            return Math.Pow(valorB, 2) - 4 * (valorA) * (valorC);
        }
    }
}
