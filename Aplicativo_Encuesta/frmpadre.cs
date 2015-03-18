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
    public partial class frmpadre : Form
    {
        public frmpadre()
        {
            InitializeComponent();
        }

        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frminformacion datos = new frminformacion();
            //datos.MdiParent = this;
            datos.Show();
        }

        private void encuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmseccion1 callseccion1 = new frmseccion1();
            //callseccion1.MdiParent = this;
            callseccion1.Show();
        }

        private void parqueaderoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParqueadero callpark = new frmParqueadero();
            callpark.Show();
        }

        private void transitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransito calltransit = new frmTransito();
            calltransit.Show();
        }

        private void salariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSalarioMinimo callsalario = new FrmSalarioMinimo();
            callsalario.Show();
        }
    }
}
