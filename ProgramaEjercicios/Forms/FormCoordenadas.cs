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
    public partial class FormCoordenadas : Form
    {
        public FormCoordenadas()
        {
            InitializeComponent();
        }

        private void inputPuntoX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-')
                && (e.KeyChar != '-') && (!char.IsNumber(e.KeyChar)) && (char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (inputPuntoX.Text == "")
                {
                    inputPuntoX.Clear();
                    inputPuntoX.Focus();
                }
                else
                    inputPuntoX.Focus();
            }
        }

        private void inputPuntoY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-')
                && (e.KeyChar != '-') && (!char.IsNumber(e.KeyChar)) && (char.IsPunctuation(e.KeyChar)))
            {
                MessageBox.Show("Solo puede ingresar números decimales");
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (inputPuntoY.Text == "")
                {
                    inputPuntoY.Clear();
                    inputPuntoY.Focus();
                }
                else
                {
                    if (double.Parse(inputPuntoX.Text) > 0 && double.Parse(inputPuntoY.Text) > 0)
                        label1.BackColor = Color.FromArgb(241, 248, 245);
                    else if (double.Parse(inputPuntoX.Text) < 0 && double.Parse(inputPuntoY.Text) > 0)
                        label2.BackColor = Color.FromArgb(241, 248, 245);
                    else if (double.Parse(inputPuntoX.Text) < 0 && double.Parse(inputPuntoY.Text) < 0)
                        label3.BackColor = Color.FromArgb(241, 248, 245);
                    else if (double.Parse(inputPuntoX.Text) > 0 && double.Parse(inputPuntoY.Text) < 0)
                        label4.BackColor = Color.FromArgb(241, 248, 245);

                    lblResCuadrante.Text = posicionCuadrante(Convert.ToDouble(inputPuntoX.Text), Convert.ToDouble(inputPuntoY.Text));

                    lblResDistancia.Text = calculoDistanciaPlano(Convert.ToDouble(inputPuntoX.Text), Convert.ToDouble(inputPuntoY.Text)).ToString();
                }
            }
        }
        public string posicionCuadrante(double posX, double posY)
        {
            if (posX > 0 && posY > 0)
                return "Uno";
            else if (posX < 0 && posY > 0)
                return "Dos";
            else if (posX < 0 && posY < 0)
                return "Tres";
            else if (posX > 0 && posY < 0)
                return "Cuatro";
            else if (posX == 0 && posY == 0)
                return "Origen";
            else
                return "Eje";
        }
        public double calculoDistanciaPlano(double posX, double posY)
        {
            return Math.Round(Math.Sqrt(Math.Pow(posX, 2) + Math.Pow(posY, 2)), 2);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int ejeX = panel1.Width / 2;
            int ejeY = panel1.Height / 2;
            Pen dibujo = new Pen(Color.Black, 2);

            dibujo = new Pen(Color.Black);
            dibujo.Color = Color.SteelBlue;

            e.Graphics.TranslateTransform(ejeX, ejeY);
            e.Graphics.ScaleTransform(1, -1);

            e.Graphics.DrawLine(dibujo, ejeX * -1, 0, ejeX * 2, 0);
            e.Graphics.DrawLine(dibujo, 0, ejeY, 0, ejeY * -2);

            for (int i = -ejeX; i < ejeX; i += 12)
            {
                e.Graphics.DrawLine(dibujo, 5, i, -5, i);
                e.Graphics.DrawLine(dibujo, i, 5, i, -5);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            inputPuntoX.Clear();
            inputPuntoY.Clear();
            lblResCuadrante.Text = "";
            lblResDistancia.Text = "";
            label1.BackColor = Color.LightBlue;
            label2.BackColor = Color.LightBlue;
            label3.BackColor = Color.LightBlue;
            label4.BackColor = Color.LightBlue;
            inputPuntoX.Focus();
        }

        private void lblResDistancia_Click(object sender, EventArgs e)
        {

        }
    }
}
