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
    public partial class FormNumero : Form
    {
        ClaseInfonumero infonumero = new ClaseInfonumero();
        public FormNumero()
        {
            InitializeComponent();
        }

        private void CalcularDescriminante_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(inputValorA.Text);
            infonumero.primo(valor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(inputValorA.Text);
            infonumero.capicua(valor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(inputValorA.Text);
            infonumero.perfecto(valor);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(inputValorA.Text);
            infonumero.factorion(valor);
        }
    }
}
