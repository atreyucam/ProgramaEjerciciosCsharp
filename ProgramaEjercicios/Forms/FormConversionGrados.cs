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
    public partial class FormConversionGrados : Form
    {
        public FormConversionGrados()
        {
            InitializeComponent();
        }
        private void inputGradosFah_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion objVal = new validacion();
            objVal.validacionNumeros(inputGradosFah, e);
        }

        private void CalcularGrados_Click(object sender, EventArgs e)
        {
            double grados = double.Parse(inputGradosFah.Text);
            Clasegrados objGrados = new Clasegrados(grados);
            RespuestaCorrecta objRespuesta = new RespuestaCorrecta();
            objRespuesta.mostrarRespuesta(objGrados.convertCelcius(), " grados celcius");
            objRespuesta.ShowDialog();
        }
    }
}
