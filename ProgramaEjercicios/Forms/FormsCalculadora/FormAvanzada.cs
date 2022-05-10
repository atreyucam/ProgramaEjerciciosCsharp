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
    public partial class FormAvanzada : Form
    {
        ClaseCalculadora objCalAvanzado = new ClaseCalculadora();
        RespuestaCorrecta objRespuesta = new RespuestaCorrecta();   
        validacion objValidacion = new validacion();

        public FormAvanzada()
        {
            InitializeComponent();
            panelSimple.Visible = false;
            panelComplejo.Visible = false;
            buttonCalcular.Visible = false;
        }
        private void mostrarPaneles()
        {
            labelTitleOperacion.Text = "";
            labelTitleComplejo.Text = "";
            panelSimple.Visible = false;
            panelComplejo.Visible = false;
            buttonCalcular.Visible = false;
            inputValorA.Clear();

        }
        private void buttonSimple_KeyPress(object sender, KeyPressEventArgs e)
        {
            objValidacion.validacionNumeros(inputValorA, e);
        }
        private void buttonComplejo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            objValidacion.validacionNumeros(inputValor1Complejo, e);
        }
        private void buttonComplejo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            objValidacion.validacionNumeros(inputValor2Complejo, e);
        }


        private void buttonPotencia2_Click(object sender, EventArgs e)
        {
            mostrarPaneles();
            labelTitleOperacion.Text = buttonPotencia2.Text;
            panelSimple.Visible = true;
            buttonCalcular.Visible = true;
        }

        private void buttonPotenciaX_Click(object sender, EventArgs e)
        {
            mostrarPaneles();
            labelTitleComplejo.Text = buttonPotenciaX.Text;
            labelTexto1F.Text = "Ingrese la base:";
            labelTexto2F.Text = "Ingrese el exponente:";
            panelComplejo.Visible = true;
            buttonCalcular.Visible = true;
        }
        private void buttonRaiz2_Click(object sender, EventArgs e)
        {
            mostrarPaneles();
            labelTitleOperacion.Text = buttonRaiz2.Text;
            panelSimple.Visible=true;
            buttonCalcular.Visible=true;
        }
        private void buttonLogx_Click(object sender, EventArgs e)
        {
            mostrarPaneles();
            labelTitleOperacion.Text=buttonLogx.Text;
            panelSimple.Visible = true;
            buttonCalcular.Visible = true;
        }
        private void buttonValorMax_Click(object sender, EventArgs e)
        {
            mostrarPaneles();
            labelTitleComplejo.Text = buttonValorMax.Text;
            labelTexto1F.Text = "Ingrese el valor 1:";
            labelTexto2F.Text = "Ingrese el valor 2:";
            panelComplejo.Visible = true;
            buttonCalcular.Visible = true;
        }
        private void buttonValormin_Click(object sender, EventArgs e)
        {
            mostrarPaneles();
            labelTitleComplejo.Text = buttonValormin.Text;
            labelTexto1F.Text = "Ingrese el valor 1:";
            labelTexto2F.Text = "Ingrese el valor 2:";
            panelComplejo.Visible = true;
            buttonCalcular.Visible = true;
        }
        private void buttonCoseno_Click(object sender, EventArgs e)
        {
            mostrarPaneles();
            labelTitleOperacion.Text = buttonCoseno.Text;
            panelSimple.Visible = true;
            buttonCalcular.Visible = true;
        }
        private void buttonSeno_Click(object sender, EventArgs e)
        {
            mostrarPaneles();
            labelTitleOperacion.Text = buttonSeno.Text;
            panelSimple.Visible = true;
            buttonCalcular.Visible = true;
        }
        private void buttonTangente_Click(object sender, EventArgs e)
        {
            mostrarPaneles();
            labelTitleOperacion.Text = buttonTangente.Text;
            panelSimple.Visible = true;
            buttonCalcular.Visible = true;
        }
        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (labelTitleOperacion.Text == buttonPotencia2.Text)
            {
                int valor = int.Parse(inputValorA.Text);
                objRespuesta.mostrarRespuesta(objCalAvanzado.calcularPotencia2(valor), "");
                objRespuesta.ShowDialog();
                inputValorA.Clear();
            }
            else if (labelTitleComplejo.Text == buttonPotenciaX.Text)
            {
                double valor1C = double.Parse(inputValor1Complejo.Text);
                double valor2C = double.Parse(inputValor2Complejo.Text);
                objRespuesta.mostrarRespuesta(objCalAvanzado.calcularPotenciaX(valor1C, valor2C), "");
                objRespuesta.ShowDialog();
                inputValor1Complejo.Clear();
                inputValor2Complejo.Clear();
            }
            else if (labelTitleOperacion.Text == buttonRaiz2.Text)
            {
                double valor = double.Parse(inputValorA.Text);
                objRespuesta.mostrarRespuesta(objCalAvanzado.calcularRaizCuadrada(valor), "");
                objRespuesta.ShowDialog();
                inputValorA.Clear();
            }
            else if (labelTitleOperacion.Text == buttonLogx.Text)
            {
                double valor1 = double.Parse(inputValorA.Text);
                objRespuesta.mostrarRespuesta(objCalAvanzado.calcularLogXY(valor1), "");
                objRespuesta.ShowDialog();
                inputValorA.Clear();
            }
            else if (labelTitleComplejo.Text == buttonValormin.Text)
            {
                int valor1C = int.Parse(inputValor1Complejo.Text);
                int valor2C = int.Parse(inputValor2Complejo.Text);
                objRespuesta.mostrarRespuesta(objCalAvanzado.calcularValorMin(valor1C, valor2C), "");
                objRespuesta.ShowDialog();
                inputValor1Complejo.Clear();
                inputValor2Complejo.Clear();
            }
            else if (labelTitleComplejo.Text == buttonValorMax.Text)
            {
                int valor1C = int.Parse(inputValor1Complejo.Text);
                int valor2C = int.Parse(inputValor2Complejo.Text);
                objRespuesta.mostrarRespuesta(objCalAvanzado.calcularValorMax(valor1C, valor2C), "");
                objRespuesta.ShowDialog();
                inputValor1Complejo.Clear();
                inputValor2Complejo.Clear();
            }
            else if (labelTitleOperacion.Text == buttonCoseno.Text)
            {
                double valor1 = double.Parse(inputValorA.Text);
                objRespuesta.mostrarRespuesta(objCalAvanzado.calcularCoseno(valor1), "");
                objRespuesta.ShowDialog();
                inputValorA.Clear();
            }
            else if (labelTitleOperacion.Text == buttonSeno.Text)
            {
                double valor1 = double.Parse(inputValorA.Text);
                objRespuesta.mostrarRespuesta(objCalAvanzado.calcularSeno(valor1), "");
                objRespuesta.ShowDialog();
                inputValorA.Clear();
            }
            else if (labelTitleOperacion.Text == buttonTangente.Text)
            {
                double valor1 = double.Parse(inputValorA.Text);
                objRespuesta.mostrarRespuesta(objCalAvanzado.calcularTangente(valor1), "");
                objRespuesta.ShowDialog();
                inputValorA.Clear();
            }
            else
            {
                //Si ves esto, Wow :D te deseo un lindo dia :v
            }
        }


    }
}
