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
    public partial class frmTransito : Form
    {
        List<clTransito> listatransitocolombia = new List<clTransito>();
        public frmTransito()
        {
            InitializeComponent();

            //declarar primer combobox

            clCiudad obciudad;
            List<clCiudad> listaciudades = new List<clCiudad>();

            obciudad= new clCiudad() ;
            obciudad.CodigoCiudad="01";
            obciudad.NombreCiudad="Medellin";
            listaciudades.Add(obciudad);

            obciudad=new clCiudad();
            obciudad.CodigoCiudad="02";
            obciudad.NombreCiudad="Bello";
            listaciudades.Add(obciudad);

            obciudad=new clCiudad();
            obciudad.CodigoCiudad="03";
            obciudad.NombreCiudad="Itagui";
            listaciudades.Add(obciudad);

            obciudad=new clCiudad();
            obciudad.CodigoCiudad="04";
            obciudad.NombreCiudad="Envigado";
            listaciudades.Add(obciudad);

            obciudad = new clCiudad();
            obciudad.CodigoCiudad = "05";
            obciudad.NombreCiudad = "Bogota";
            listaciudades.Add(obciudad);

            
            //declarar segundo combobox
            clTransito obtransito;

            obtransito = new clTransito();
            obtransito.CodigoCiudad = "01";
            obtransito.NombreCiudad= "Medellin";
            obtransito.CodigoTransito = "001";
            obtransito.NombreTransito = "Caribe";
            listatransitocolombia.Add(obtransito);

            obtransito = new clTransito();
            obtransito.CodigoCiudad = "01";
            obtransito.NombreTransito= "Medellin";
            obtransito.CodigoTransito="0001";
            obtransito.NombreTransito="Municipal";
            listatransitocolombia.Add(obtransito);

            obtransito = new clTransito();
            obtransito.CodigoCiudad = "02";
            obtransito.NombreCiudad = "Bello";
            obtransito.CodigoTransito = "002";
            obtransito.NombreTransito = "Bello";
            listatransitocolombia.Add(obtransito);

            obtransito = new clTransito();
            obtransito.CodigoCiudad = "03";
            obtransito.NombreCiudad = "Itagui";
            obtransito.CodigoTransito = "003";
            obtransito.NombreTransito = "Itagui";
            listatransitocolombia.Add(obtransito);

            obtransito = new clTransito();
            obtransito.CodigoCiudad = "04";
            obtransito.NombreCiudad = "Envigado";
            obtransito.CodigoTransito = "004";
            obtransito.NombreTransito = "Envigado";
            listatransitocolombia.Add(obtransito);

            obtransito = new clTransito();
            obtransito.CodigoCiudad = "05";
            obtransito.NombreCiudad = "Bogota";
            obtransito.CodigoTransito = "005";
            obtransito.NombreTransito = "Bogota";
            listatransitocolombia.Add(obtransito);

            obtransito = new clTransito();
            obtransito.CodigoCiudad = "05";
            obtransito.NombreCiudad = "Bogota";
            obtransito.CodigoTransito = "0005";
            obtransito.NombreTransito = "Cundinamarca";
            listatransitocolombia.Add(obtransito);


            //llenar combobox
            cmbciudad.DataSource = listaciudades;
            cmbciudad.DisplayMember = "NombreCiudad";
            cmbciudad.ValueMember = "CodigoCiudad";

            //llenar combo
            cmbciudad.DataSource = listaciudades;
            cmbciudad.DisplayMember = "nombreCiudad";
            cmbciudad.ValueMember = "codigoCiudad";

            


        }

        private void frmTransito_Load(object sender, EventArgs e)
        {

        }

        private void cmbciudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            //expresion lambda c#
            string CodigoCiudadSeleccionado = cmbciudad.SelectedValue.ToString();
            List<clTransito> listatransitofiltrada =
            listatransitocolombia.Where(w => w.CodigoCiudad == CodigoCiudadSeleccionado).ToList();

            //llenar combobox
            cmbtransito.DataSource = null;
            cmbtransito.DataSource = listatransitofiltrada;
            cmbtransito.DisplayMember = "NombreTransito";
            cmbtransito.ValueMember = "CodigoTransito"; 
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            clTransito transito = new clTransito();
            transito.NombreTransito = cmbtransito.Text;
            int tarifa = transito.tarifatransito;
            double cantidad = Convert.ToDouble(txtcantidad.Text);
            double valortarifa = tarifa * cantidad;
            txtvalorlicencia.Text = tarifa.ToString();
            txtValor_total.Text = valortarifa.ToString();
        }
    }
}
