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
    public partial class frmreporte : Form
    {
        public frmreporte()
        {
            InitializeComponent();
            
        }
        

        private void frmreporte_Load(object sender, EventArgs e)
        {
            StreamReader MiStreamReader = new StreamReader("Test_File.txt");

            txtname.Text = MiStreamReader.ReadLine();
            txtlastname.Text = MiStreamReader.ReadLine();
            txtcity.Text = MiStreamReader.ReadLine();
            txtage.Text = MiStreamReader.ReadLine();
            txtpre.Text = MiStreamReader.ReadLine();
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
