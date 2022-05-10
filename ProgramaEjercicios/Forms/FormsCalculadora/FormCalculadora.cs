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
    public partial class FormCalculadora : Form
    {
        private Form activeForm;
        public FormCalculadora()
        {
            InitializeComponent();
        }
        public void openChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMainCalculadora.Controls.Add(childForm);
            this.panelMainCalculadora.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ButtonSimple_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormSimple(), sender);
        }

        private void buttonAvanzado_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormAvanzada(), sender);
        }
    }
}
