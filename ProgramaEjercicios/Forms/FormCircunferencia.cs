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
    public partial class FormCircunferencia : Form
    {
        public FormCircunferencia()
        {
            InitializeComponent();
        }

        private void inputRadio_TextChanged(object sender, KeyPressEventArgs e)
        {
            validacion objValidacion = new validacion();
            objValidacion.validacionNumeros(inputRadio, e);
        }

        private void ButtonCalcularArea_Click(object sender, EventArgs e)
        {
            double radio = double.Parse(inputRadio.Text);
            ClassCircunferencia objCircun = new ClassCircunferencia(radio);
            RespuestaCorrecta objRes = new RespuestaCorrecta();
            objRes.mostrarRespuesta(objCircun.calcularArea(), " m2");
            objRes.ShowDialog();
        }

        private void ButtonCalcularLongitud_Click(object sender, EventArgs e)
        {
            double radio = double.Parse(inputRadio.Text);
            ClassCircunferencia objCircun = new ClassCircunferencia(radio);
            RespuestaCorrecta objRes = new RespuestaCorrecta();
            objRes.mostrarRespuesta(objCircun.calcularLongitud(), " m2");
            objRes.ShowDialog();
        }
    }
}
