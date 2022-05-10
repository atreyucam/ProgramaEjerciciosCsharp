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
    public partial class FormDiscriminante : Form
    {
        public FormDiscriminante()
        {
            InitializeComponent();
        }

        private void inputValorA_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion valor = new validacion();
            valor.validacionNumeros(inputValorA, e);
        }
        private void inputValorB_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion valor = new validacion();
            valor.validacionNumeros(inputValorB, e);
        }
        private void inputValorC_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion valor = new validacion();
            valor.validacionNumeros(inputValorC, e);
        }
        private void CalcularDescriminante_Click(object sender, EventArgs e)
        {
            double valorA = int.Parse(inputValorA.Text);
            double valorB = int.Parse(inputValorB.Text);
            double valorC = int.Parse(inputValorC.Text);

            ClaseDiscriminante objDiscriminante = new ClaseDiscriminante(valorA, valorB, valorC);
            RespuestaCorrecta objRespuesta = new RespuestaCorrecta();
            objRespuesta.mostrarRespuesta(objDiscriminante.calculoDiscriminante(),"");
            objRespuesta.ShowDialog();

        }
    }
}
