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
    public partial class homePage : Form
    {
        bool siderBarExpand;
        private Form activeForm;
        
        public homePage()
        {
            InitializeComponent();
            menuExt.Visible = false;
        }

        //Animacion del sideBar - izquierdo
        private void siderBarTimer_tick(object sender, EventArgs e)
        {
            if (siderBarExpand)
            {
                siderBarContainer.Width -= 10;
                if (siderBarContainer.Width == siderBarContainer.MinimumSize.Width)
                {
                    siderBarExpand = false;
                    SiderBarTimer.Stop();
                    menuExt.Visible = true;
                }
            }
            else
            {
                siderBarContainer.Width += 10;
                menuExt.Visible = false;
                if (siderBarContainer.Width == siderBarContainer.MaximumSize.Width)
                {
                    siderBarExpand = true;
                    SiderBarTimer.Stop();
                }
            }
        }
        private void Menubutton_Click(object sender, EventArgs e)
        {
            SiderBarTimer.Start();
            
        }
        private void menuExt_Click(object sender, EventArgs e)
        {
            SiderBarTimer.Start();
        }
        //=======================================================
        //Cambio de ventanas
        private void openChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
            InicioButton.Enabled = true;
        }
        //=======================================================
        //Regreso a homepage.
        private void InicioButton_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }
        private void Reset()
        {
            labelTitle.Text = "Home";
        }
        //=======================================================
        //Forms
        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormCifrasNumEntero(), sender);
        }
        private void buttonCifrasLink_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormCifrasNumEntero(), sender);
        }
        private void discriminantebutton_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormDiscriminante(), sender);
        }
        private void buttonDiscriminanteLink_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormDiscriminante(), sender);
        }
        private void buttonConversion_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormConversionGrados(), sender);
        }
        private void buttonConversorLink_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormConversionGrados(), sender);
        }
        private void buttonCircunferencia_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormCircunferencia(), sender);
        }
        private void buttonCircunferenciaLink_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormCircunferencia(), sender);
        }

        private void buttonCalculadora_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormCalculadora(), sender);
        }

        private void buttonCalculadoraLink_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormCalculadora(), sender);

        }
        private void buttonTriangulos_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.tiposTriangulos(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormServicioTransporte(), e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormCompraInteractiva(), e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormCoordenadas(), e);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormPI(), e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormFibonacci(), e);
        }

        private void buttonConver_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormConversion(), e);
        }

        private void buttoninfoNum_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormNumero(), e);
        }

        private void buttonEditorTexto_Click(object sender, EventArgs e)
        {
            openChildForm(new WinAppEditorTexto.Form1(), e);
        }

        private void buttonCadena_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormSumaCadena(), e);
        }

        private void buttonJuego_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormJuego(), e);
        }
    }
}
