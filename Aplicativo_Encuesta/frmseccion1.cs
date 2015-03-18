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
    public partial class frmseccion1 : Form
    {
        public frmseccion1()
        {
            InitializeComponent();
            objEncuesta_seccion1 = new clEncuesta();
            
        }

        int contadorpositivos = 0;
        int contadornegativos = 0;


        private clEncuesta objEncuesta_seccion1 = new clEncuesta();


        public frmseccion1(clEncuesta objEncuesta)
        {
            InitializeComponent();
            objEncuesta_seccion1 = objEncuesta;
            this.CenterToScreen();

            List<string> listaRespuestas = objEncuesta_seccion1.NombresControlesRptaS1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    string nomcontrol = "rb" + i.ToString() + "_" + j.ToString();
                    Control[] controles = this.Controls.Find(nomcontrol, true);

                    if (null != controles && controles.Count() > 0)
                    {
                        if (controles[0] is RadioButton)
                        {
                            RadioButton rd = (RadioButton)controles[0];

                            for (int y = 0; y < listaRespuestas.Count; y++)
                            {
                                if (nomcontrol ==  listaRespuestas[y])
                                {
                                    rd.Checked = true;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            List<string> mirspt = new List<string>();
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    string nomcontrol = "rb" + i.ToString() + "_" + j.ToString();
                    Control[] controles = this.Controls.Find(nomcontrol, true);

                    if (null != controles && controles.Count() > 0)
                    {
                        if (controles[0] is RadioButton)
                        {
                            RadioButton rd = (RadioButton)controles[0];
                            if (rd.Checked == true)
                            {
                                mirspt.Add(nomcontrol);
                            }
                        }
                    }
                }
            }

            if (rb1_1.Checked == true)
            {
                contadorpositivos += 1;
            }
            else
            {
                contadornegativos += 1;
            }
            if (rb2_1.Checked == true)
            {
                contadorpositivos += 1;
            }
            else
            {
                contadornegativos += 1;
            }
            if (rb3_2.Checked == true)
            {
                contadorpositivos += 1;
            }
            else
            {
                contadornegativos += 1;
            }
            if (rb4_2.Checked == true)
            {
                contadorpositivos += 1;
            }
            else
            {
                contadornegativos += 1;
            }

            objEncuesta_seccion1.NombresControlesRptaS1 = mirspt;

            frmseccion2 callseccion2 = new frmseccion2(objEncuesta_seccion1, contadorpositivos, contadornegativos);
            callseccion2.Show();
            this.Close();
        }
    }
}
