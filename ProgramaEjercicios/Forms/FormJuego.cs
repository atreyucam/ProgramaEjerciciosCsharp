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
    public partial class FormJuego : Form
    {
        int contador = 0;
        RespuestaCorrecta correcta = new RespuestaCorrecta();
        mensajeError error = new mensajeError();
        public FormJuego()
        {
            InitializeComponent();
        }

        int randomNUmber = new Random().Next(0,50);

        private void ButtonAdivina_Click(object sender, EventArgs e)
        {
            int input = int.Parse(inputValorA.Text);

            if (input > randomNUmber)
            {
                error.respuestaError("El números es menor");  
                error.ShowDialog();
                inputValorA.Text = "";
                    
            }
            else if (input < randomNUmber)
            {
                error.respuestaError("El números es mayor");
                error.ShowDialog();
                inputValorA.Text = "";
            }
            contador++;

            if (input == randomNUmber)
            {
                correcta.mostrarRespuestaTexto("Felicidades encontraste el números");
                correcta.ShowDialog();
                correcta.mostrarRespuestaTexto("números de intentos: " + contador);
                correcta.ShowDialog();
            }

            
        }

    }
}
