using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProgramaEjercicios
{
    internal class validacion
    {
        public validacion()
        {
            
        }

        public void validacionNumeros(TextBox input, KeyPressEventArgs e)
        {
            
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar < 255))
            {
                input.BackColor = Color.FromArgb(254, 211, 209);
                //MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mensajeError objError = new mensajeError();
                objError.ShowDialog();
                e.Handled = true;
                return;
            }
            
            input.BackColor = Color.White;
        }

        public void comprobacionNumeros(TextBox input, KeyPressEventArgs e)
        {
            
        }
    }
   
}
