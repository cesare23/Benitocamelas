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
    public partial class frmseccion2 : Form
    {
        public frmseccion2()
        {
            InitializeComponent();
        }
        private clEncuesta objencuesta_seccion2 = new clEncuesta();
        
        public frmseccion2(clEncuesta encuesta, int contadorpositivos ,int contadornegativos)
        {
            InitializeComponent();
            objencuesta_seccion2 = encuesta;
            this.CenterToScreen();


            this.contadorpositivos = contadorpositivos;
            this.contadornegativos = contadornegativos;


            List<string> listaRespuestas2 = objencuesta_seccion2.NombreControRptaS2;
            if (listaRespuestas2 != null)
            {
                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= 4; j++)
                    {
                        string nomcontrol = "chk" + i.ToString() + "_" + j.ToString();
                        Control[] controles = this.Controls.Find(nomcontrol, true);

                        if (null != controles && controles.Count() > 0)
                        {
                            if (controles[0] is CheckBox)
                            {
                                CheckBox chk = (CheckBox)controles[0];


                                for (int a = 0; a < listaRespuestas2.Count; a++)
                                {
                                    if (nomcontrol == listaRespuestas2[a])
                                    {
                                        chk.Checked = true;
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

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            List<string> misrpta = new List<string>();
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    string nomControl = "chk" + i.ToString() + "_" + j.ToString();
                    Control[] control = this.Controls.Find(nomControl, true);
                    if (control != null && control.Count() > 0)
                    {
                        if (control[0] is CheckBox)
                        {
                            CheckBox ch = ((CheckBox)control[0]);
                            if (ch.Checked == true)
                            {
                                misrpta.Add(nomControl);
                            }
                        }
                    }
                }
            }

            if (chk1_1.Checked == true && chk1_2.Checked == true && chk1_3.Checked == true)
            {
                contadorpositivos += 1;
            }
            else
            {
                contadornegativos += 1;
            }
            if (chk2_1.Checked == true && chk2_2.Checked == true)
            {
                contadorpositivos += 1;
            }
            else
            {
                contadornegativos += 1;
            }
            if (chk3_1.Checked == true && chk3_2.Checked == true && chk3_4.Checked == true)
            {
                contadorpositivos += 1;
            }
            else
            {
                contadornegativos += 1;
            }
            if (chk4_1.Checked == true && chk4_2.Checked == true && chk4_3.Checked == true)
            {
                contadorpositivos += 1;
            }
            else
            {
                contadornegativos += 1;
            }


            objencuesta_seccion2.NombreControRptaS2 = misrpta;
            frmseccion3 callseccion3 = new frmseccion3(objencuesta_seccion2, contadorpositivos, contadornegativos);
            callseccion3.Show();
            this.Close();
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            frmseccion1 callseccion1 = new frmseccion1(objencuesta_seccion2);
            callseccion1.Show();
            this.Close();
        }

        private void frmseccion2_Load(object sender, EventArgs e)
        {
            txtprueba.Text = Convert.ToString(contadorpositivos);
            txtprueba2.Text = Convert.ToString(contadornegativos);
        }
    }
}
