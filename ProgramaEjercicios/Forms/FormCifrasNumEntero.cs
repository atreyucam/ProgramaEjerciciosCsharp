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
    public partial class FormCifrasNumEntero : Form
    {
        public FormCifrasNumEntero()
        {
            InitializeComponent();
        }

        private void inputValorFormula_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion objValidacion = new validacion();
            objValidacion.validacionNumeros(inputValorFormula, e);
        }

        private void CalcularEnterosF_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(inputValorFormula.Text);
            ClaseEnteros objEnteros = new ClaseEnteros(valor);
            RespuestaCorrecta objRespuesta = new RespuestaCorrecta();
            objRespuesta.mostrarRespuesta(objEnteros.calcularFormula(), "");
            objRespuesta.ShowDialog();
        }
    }
}
