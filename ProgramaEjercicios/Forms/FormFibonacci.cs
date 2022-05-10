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
    public partial class FormFibonacci : Form
    {
        int valor;
        public FormFibonacci()
        {
            InitializeComponent();
        }

        private void CalcularDescriminante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (inputValorA.Text == "")
                {
                    inputValorA.Focus();
                }
                else
                {
                    listSerie.Items.Clear();
                    valor = int.Parse(inputValorA.Text);
                    ClaseFibonacci objSerie = new ClaseFibonacci();
                    for (int i = 1; i <= valor; i++)
                    {
                        listSerie.Items.Add(objSerie.CalculoFibonacci(i));
                    }
                }
            }
        }

        private void inputValorA_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void labelValorA_Click(object sender, EventArgs e)
        {

        }
    }
}