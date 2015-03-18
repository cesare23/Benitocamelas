using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Aplicativo_Encuesta
{
    public partial class frminformacion : Form
    {
        public frminformacion()
        {
            InitializeComponent();
        }

        private void btnsiguiente1_Click(object sender, EventArgs e)
        {
            StreamWriter File = new StreamWriter("Test_File.txt");
            File.Write(txtnombre.Text + ("\n"));
            File.Write(txtapellido.Text + ("\n"));
            File.Write(cbxciudad.Text + ("\n"));
            File.Write(txtedad.Text + ("\n"));
            File.Write(clbpregrados.Text + ("\n"));

            File.Close();
            frmseccion1 callseccion1 = new frmseccion1();
            callseccion1.Show();
            this.Close();
        }

        private void dtpfecha_nacimiento_ValueChanged(object sender, EventArgs e)
        {
            txtedad.Text = (DateTime.Today.AddTicks(-dtpfecha_nacimiento.Value.Ticks).Year - 1).ToString();
        }
    }
}
