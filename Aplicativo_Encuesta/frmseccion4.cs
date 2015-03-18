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
    public partial class frmseccion4 : Form
    {
        public frmseccion4()
        {
            InitializeComponent();
        }
        private clEncuesta objEncuesta_seccion4 = new clEncuesta();
        public frmseccion4(clEncuesta objEncuesta, int contadorpositivos, int contadornegativos)
        {
            InitializeComponent();
            objEncuesta_seccion4 = objEncuesta;

            this.contadorpositivos = contadorpositivos;
            this.contadornegativos = contadornegativos;

            List<string> listaRespuestas = objEncuesta_seccion4.NombreControRptasS4;
            if (listaRespuestas != null)
            {
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 4; j++)
                    {
                        string nomcontrol = "rbS" + i.ToString() + "_" + j.ToString();
                        Control[] controles = this.Controls.Find(nomcontrol, true);

                        if (null != controles && controles.Count() > 0)
                        {
                            if (controles[0] is RadioButton)
                            {
                                RadioButton rd = (RadioButton)controles[0];

                                for (int y = 0; y < listaRespuestas.Count; y++)
                                {
                                    if (nomcontrol == listaRespuestas[y])
                                    {
                                        rd.Checked = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        int contadorpositivos;
        int contadornegativos;

        private void frmseccion4_Load(object sender, EventArgs e)
        {
            txtprueba.Text = Convert.ToString(contadornegativos);
            txtprueba2.Text = Convert.ToString(contadorpositivos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmseccion3 callseccion3 = new frmseccion3();
            callseccion3.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clEncuesta encuesta = new clEncuesta();
            List<string> misrpta = new List<string>();

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 4; j++)
                {

                    string nomControl = "rd" + i.ToString() + "_" + j.ToString();
                    Control[] controles = this.Controls.Find(nomControl, true);

                    if (null != controles && controles.Count() > 0)
                    {
                        if (controles[0] is RadioButton)
                        {
                            RadioButton rd = ((RadioButton)controles[0]);
                            if (rd.Checked == true)
                            {
                                misrpta.Add(nomControl);
                            }
                        }
                    }
                }
            }

            objEncuesta_seccion4.NombreControRptasS4 = misrpta;
            frmreporte callresultados = new frmreporte();
            callresultados.txtra.Text = txtprueba.Text;
            callresultados.txtre.Text = txtprueba2.Text;
            callresultados.Show();
            this.Close();
        }
    }
}
