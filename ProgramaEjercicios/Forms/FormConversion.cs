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
    public partial class FormConversion : Form
    {
        RespuestaCorrecta objRespuesta = new RespuestaCorrecta();
        mensajeError error = new mensajeError();
        validacion ovjValidacion = new validacion();    
        public FormConversion()
        {
            InitializeComponent();
        }
        private void inputValorA_KeyPress(object sender, KeyPressEventArgs e)
        {
            ovjValidacion.validacionNumeros(inputValorA, e);
        }
        public double calcularTalla(double valor)
        {
            return valor * 2.54;
        }

        private void CalcularDescriminante_Click(object sender, EventArgs e)
        {
            int valorx = int.Parse(inputValorA.Text);
            if (valorx >=48 && valorx <= 84)
            {
                double respuesta = calcularTalla(valorx);
                objRespuesta.mostrarRespuestaTexto("La talla en cm es: " + respuesta);
                objRespuesta.ShowDialog();
            }
            else
            {
                error.respuestaError("EL valor debe ser entre 48 y 84");
                error.ShowDialog();
            }
        }
    }
}
