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
    public partial class tiposTriangulos : Form
    {
        validacion objvalidacion = new validacion();
        RespuestaCorrecta objRepuesta = new RespuestaCorrecta();
        public tiposTriangulos()
        {
            InitializeComponent();
        }

        private void inputValorA_TextChanged(object sender, KeyPressEventArgs e)
        {
            objvalidacion.validacionNumeros(inputValorA, e);
        }

        private void inputValorB_KeyPress(object sender, KeyPressEventArgs e)
        {
            objvalidacion.validacionNumeros(inputValorB, e);
        }

        private void inputValorC_KeyPress(object sender, KeyPressEventArgs e)
        {
            objvalidacion.validacionNumeros(inputValorC, e);
        }

        private void ButtonCalcularArea_Click(object sender, EventArgs e)
        {
            int valorA = int.Parse(inputValorA.Text);
            int valorB = int.Parse(inputValorB.Text);
            int valorC = int.Parse(inputValorC.Text);
            if (valorA == valorB && valorA == valorC)
            {
                objRepuesta.mostrarRespuestaTexto("Es un triángulo equilátero");
                objRepuesta.ShowDialog();
            }
            else if (valorA == valorB || valorB == valorC)
            {
                objRepuesta.mostrarRespuestaTexto("Es un triángulo  isósceles");
                objRepuesta.ShowDialog();
            }
            else
            {
                objRepuesta.mostrarRespuestaTexto("Es un triángulo  escaleno");
                objRepuesta.ShowDialog();
            }
        }
    }
}
