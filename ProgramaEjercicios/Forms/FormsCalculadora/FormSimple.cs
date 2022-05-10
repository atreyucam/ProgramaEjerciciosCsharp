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
    public partial class FormSimple : Form
    {
        validacion objValidacion = new validacion();
        ClaseCalculadora objCalSimple = new ClaseCalculadora();
        RespuestaCorrecta objRespuesta = new RespuestaCorrecta();
        public FormSimple()
        {
            InitializeComponent();
        }

        private void inputvalor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            objValidacion.validacionNumeros(inputvalor1, e);
        }

        private void inputValor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            objValidacion.validacionNumeros(inputValor2, e);
        }

        private void ButtonSuma_Click(object sender, EventArgs e)
        {
            int value1 = int.Parse(inputvalor1.Text);
            int value2 = int.Parse(inputValor2.Text);
            objRespuesta.mostrarRespuesta(objCalSimple.calcularSuma(value1, value2), "");
            objRespuesta.ShowDialog();
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            int value1 = int.Parse(inputvalor1.Text);
            int value2 = int.Parse(inputValor2.Text);
            objRespuesta.mostrarRespuesta(objCalSimple.calcularResta(value1, value2), "");
            objRespuesta.ShowDialog();
        }

        private void buttonProducto_Click(object sender, EventArgs e)
        {
            int value1 = int.Parse(inputvalor1.Text);
            int value2 = int.Parse(inputValor2.Text);
            objRespuesta.mostrarRespuesta(objCalSimple.calcularProducto(value1, value2), "");
            objRespuesta.ShowDialog();
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            int value1 = int.Parse(inputvalor1.Text);
            int value2 = int.Parse(inputValor2.Text);
            objRespuesta.mostrarRespuesta(objCalSimple.calcularDivision(value1, value2), "");
            objRespuesta.ShowDialog();
        }
    }
}
