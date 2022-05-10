using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaEjercicios
{
    internal class ClassCircunferencia
    {
        double radio, area, longitud;
        public ClassCircunferencia(double radio)
        {
            this.radio = radio;
        }
        public double calcularArea()
        {
            area = Math.PI * Math.Pow(radio, 2);
            area = Math.Round(area, 3);
            return area;
        }
        public double calcularLongitud()
        {
            longitud = 2 * Math.PI * radio;
            longitud = Math.Round(longitud, 3);
            return longitud;
        }
    }
}
