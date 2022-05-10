using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaEjercicios
{
    public partial class RespuestaCorrecta : Form
    {
        public RespuestaCorrecta()
        {
            InitializeComponent();
        }
        private void button1Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void mostrarRespuesta(double valor, String text)
        {
           outputRespuesta.Text = valor.ToString() + text;
        }
        public void mostrarRespuestaTexto(String text)
        {
            outputRespuesta.Text = text;
        }
    }
}
