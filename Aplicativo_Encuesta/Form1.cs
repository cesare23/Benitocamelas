using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicativo_Encuesta
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "admin" && txtcontraseña.Text == "123" && txtcontraseña != null && txtusuario != null)
            {

                frmpadre menu = new frmpadre();
                menu.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Por favor verificar todos los campos", "Autenticacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Desea Salir de la Aplicacion", "Aplicativo Encuesta", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
