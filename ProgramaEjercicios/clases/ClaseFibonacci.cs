using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaEjercicios
{
    internal class ClaseFibonacci
    {
        public ClaseFibonacci()
        {

        }
        public int CalculoFibonacci(int num)
        {
            if (num < 2)
                return num;
            else
                return (CalculoFibonacci(num - 1) + CalculoFibonacci(num - 2));
        }
    }

}
