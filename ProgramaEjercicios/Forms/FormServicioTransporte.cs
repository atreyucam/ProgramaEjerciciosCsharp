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
    public partial class FormServicioTransporte : Form
    {
        mensajeError objError = new mensajeError();
        RespuestaCorrecta objCorrecta = new RespuestaCorrecta();
        public FormServicioTransporte()
        {
            InitializeComponent();
        }

        private void calcularPaquete_click(object sender, EventArgs e)
        {
            double valor = double.Parse(inputkilogramos.Text);
            double valorTotal;
            string opcion = DestinosList.Text;

            if (valor >= 5)
            {
                objError.respuestaError("Su paquete no cumple nuestras \npolíticas  de 5kg");
                objError.ShowDialog();
            }
            else
            {
                switch (opcion)
                {
                    case "America del Norte":
                        valorTotal = valor * 24;
                        objCorrecta.mostrarRespuestaTexto("El valor a pagar es de: $" + valorTotal);
                        objCorrecta.ShowDialog();
                        break;

                    case "America Central":
                        valorTotal = (valor * 20);
                        objCorrecta.mostrarRespuestaTexto("El valor a pagar es de: $" + valorTotal);
                        objCorrecta.ShowDialog();
                        break;

                    case "America del Sur":
                        valorTotal = valor * 21;
                        objCorrecta.mostrarRespuestaTexto("El valor a pagar es de: $" + valorTotal);
                        objCorrecta.ShowDialog();
                        break;
                    case "Europa":
                        valorTotal = valor * 10;
                        objCorrecta.mostrarRespuestaTexto("El valor a pagar es de: $" + valorTotal);
                        objCorrecta.ShowDialog();
                        break;

                    case "Asia":
                        valorTotal = valor * 18;
                        objCorrecta.mostrarRespuestaTexto("El valor a pagar es de: $" + valorTotal);
                        objCorrecta.ShowDialog();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
