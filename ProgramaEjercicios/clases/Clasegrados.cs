using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaEjercicios
{
    internal class Clasegrados
    {
        double gradosFah, gradosCel;
        public Clasegrados(double gradosFah)
        {
            this.gradosFah = gradosFah;
        }
        public double convertCelcius()
        {
            gradosCel = (gradosFah - 32) * 5 / 9;
            gradosCel = Math.Round(gradosCel, 3);
            return gradosCel;
        }
    }
}
