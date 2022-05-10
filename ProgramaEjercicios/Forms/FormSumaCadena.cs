using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaEjercicios.Forms
{
    public partial class FormSumaCadena : Form
    {
        validacion validacion = new validacion();
        public FormSumaCadena()
        {
            InitializeComponent();
        }



        private void CalcularCifras_Click(object sender, EventArgs e)
        {
            string texto = inputCadena.Text;
            string salida = string.Empty;
            int val;
            int suma = 0, valorx;

            for (int i = 0; i < texto.Length; i++)
            {
                if (char.IsDigit(texto[i]))
                {
                    salida = salida + texto[i];
                    valorx = int.Parse(salida);
                    suma += (valorx);
                }
                else
                {
                    salida = string.Empty;
                }
            }

            MessageBox.Show("total: " + (suma-1));
        }
    }
}
