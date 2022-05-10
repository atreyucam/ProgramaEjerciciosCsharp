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
    public partial class FormCompraInteractiva : Form
    {
        string nombreProducto, cantidadProducto, precioUnitarioProducto, codigoCliente;
        double total = 0, aux;
        public FormCompraInteractiva()
        {
            InitializeComponent();
            labelNombre.Visible = false;
            labelInfoPago.Visible = false;
            LabelCedula.Visible = false;
            labelTotal.Visible = false;
        }

        private void inputCantidad_TextChanged(object sender, EventArgs e)
        {
            nombreProducto = listProducto.Text;
            switch (nombreProducto)
            {
                case "Leche":
                    inputValorUnitario.Text = "0.75";
                    break;
                case "Yogurt":
                    inputValorUnitario.Text = "1.75";
                    break;
                case "Queso":
                    inputValorUnitario.Text = "1.00";
                    break;
                case "Nata":
                    inputValorUnitario.Text = "0.50";
                    break;
                case "Mantequilla":
                    inputValorUnitario.Text = "1.50";
                    break;
                case "Salchicha":
                    inputValorUnitario.Text = "2.25";
                    break;
                case "Pollo":
                    inputValorUnitario.Text = "3.50";
                    break;
                case "Carne":
                    inputValorUnitario.Text = "2.25";
                    break;
                case "Aceite":
                    inputValorUnitario.Text = "1.80";
                    break;
                case "Tomate":
                    inputValorUnitario.Text = "0.80";
                    break;
                case "Lechuga":
                    inputValorUnitario.Text = "0.50";
                    break;
                case "Manzana":
                    inputValorUnitario.Text = "0.25";
                    break;
                case "Uva":
                    inputValorUnitario.Text = "0.15";
                    break;
                default:
                    break;
            }
        }

        private void nuevaCompra_Click(object sender, EventArgs e)
        {
            labelNombre.Text = inputNombre.Text;
            LabelCedula.Text = inputCedula.Text;
            labelNombre.Visible = true;
            LabelCedula.Visible=true;
        }

        private void buttonAgregarCarrito_Click(object sender, EventArgs e)
        {
            nombreProducto = listProducto.Text;
            cantidadProducto = inputCantidad.Text;
            codigoCliente = inputCodigoCliente.Text;
            precioUnitarioProducto = inputValorUnitario.Text;
            labelTotal.Visible = true;
            labelInfoPago.Visible = true;
            double precio = double.Parse(inputValorUnitario.Text);
            int cantidades = int.Parse(inputCantidad.Text);

            dataGridView1.Rows.Add(codigoCliente, nombreProducto, cantidadProducto, precioUnitarioProducto);

           

            aux = precio * cantidades;
            total += aux;

            labelTotal.Text = total.ToString();

        }
    }
}
