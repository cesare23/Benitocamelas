﻿using System;
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
    public partial class frmseccion3 : Form
    {
        public frmseccion3()
        {
            InitializeComponent();
        }

         private clEncuesta objEncuesta_seccion3 = new clEncuesta();
        
        public frmseccion3(clEncuesta objEncuesta, int contadorpositivos, int contadornegativos)
        {
            InitializeComponent();
            objEncuesta_seccion3 = objEncuesta;
            this.contadorpositivos = contadorpositivos;
            this.contadornegativos = contadornegativos;


            List<string> listaRespuestas3 = objEncuesta_seccion3.NombreControlRptasS3;
            if (listaRespuestas3 != null)
            {
                txtRpta1.Text = listaRespuestas3[0];
                txtRpta2.Text = listaRespuestas3[1];
                txtRpta3.Text = listaRespuestas3[2];
                txtRpta4.Text = listaRespuestas3[3];
            }
        }
        int contadorpositivos;
        int contadornegativos;

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            List<string> misrpta = new List<string>();
            for (int i = 1; i <= 4; i++)
            {
                string nomControl = "txtRpta" + i.ToString();
                Control[] vControl = this.Controls.Find(nomControl, true);

                if (vControl != null && vControl.Count() > 0)
                {
                    if (vControl[0] is TextBox)
                    {
                        TextBox text = ((TextBox)vControl[0]);
                        if (text.Text != "")
                        {
                            misrpta.Add(text.Text);
                        }
                    }
                }
            }
            objEncuesta_seccion3.NombreControlRptasS3 = misrpta;
            frmseccion4 callseccion4 = new frmseccion4(objEncuesta_seccion3, contadornegativos, contadorpositivos);
            callseccion4.Show();
            this.Close();
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            
            frmseccion2 callseccion2 = new frmseccion2();
            callseccion2.Show();
            this.Close();
        }

        private void frmseccion3_Load(object sender, EventArgs e)
        {
            txtprueba.Text = Convert.ToString(contadorpositivos);
            txtprueba2.Text = Convert.ToString(contadornegativos);
        }
    }
}
