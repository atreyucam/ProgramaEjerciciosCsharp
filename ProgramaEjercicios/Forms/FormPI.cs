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
    public partial class FormPI : Form
    {
        validacion validacion = new validacion();   
        RespuestaCorrecta respuesta = new RespuestaCorrecta();
        public FormPI()
        {
            InitializeComponent();
        }


        private void inputValorA_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.validacionNumeros(inputValorA, e);
        }

        private void CalcularDescriminante_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(inputValorA.Text);
            double resultado;

            resultado = calculo(valor);

            respuesta.mostrarRespuestaTexto("El resultado de PI es: "+ resultado);
            respuesta.ShowDialog();

        }
        public double calculo(int valor)
        {
            int d = 1, sig = 1;
            double t, s = 0;
            for (int i = 1; i <= valor; i++)
            {
                t = (double)1 / d * sig;
                s += t;
                d += 2;
                sig *= -1;
            }
            return s * 4;
        }
    }
}
