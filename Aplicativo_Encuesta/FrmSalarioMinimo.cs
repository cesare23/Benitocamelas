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
    public partial class FrmSalarioMinimo : Form
    {
        List<clSMestado> listaestado = new List<clSMestado>();
        List<clSMCiudad> listaciudad = new List<clSMCiudad>();
       
        
        public FrmSalarioMinimo()
        {
            InitializeComponent();

            //declarar primer combobox
            clSMpais objpais;
            List<clSMpais> listapais = new List<clSMpais>();

            objpais = new clSMpais();
            objpais.CodigoPais = "01";
            objpais.NombrePais = "Colombia";
            listapais.Add(objpais);

            objpais = new clSMpais();
            objpais.CodigoPais = "02";
            objpais.NombrePais="Estado Unidos";
            listapais.Add(objpais);

            objpais = new clSMpais();
            objpais.CodigoPais = "03";
            objpais.NombrePais = "Brasil";
            listapais.Add(objpais);

            //declarar segundo combobox
            clSMestado objestado;
            

            objestado = new clSMestado();
            objestado.CodigoPais = "01";
            objestado.NombrePais = "Colombia";
            objestado.CodigoEstado = "001";
            objestado.NombreEstado = "Antioquia";
            listaestado.Add(objestado);

            objestado = new clSMestado();
            objestado.CodigoPais = "01";
            objestado.NombrePais = "Colombia";
            objestado.CodigoEstado = "0001";
            objestado.NombreEstado = "Cundinamarca";
            listaestado.Add(objestado);

            objestado = new clSMestado();
            objestado.CodigoPais = "01";
            objestado.NombrePais = "Colombia";
            objestado.CodigoEstado = "00001";
            objestado.NombreEstado = "Amazonas";
            listaestado.Add(objestado);

            objestado = new clSMestado();
            objestado.CodigoPais = "02";
            objestado.NombrePais = "Estados Unidos";
            objestado.CodigoEstado = "002";
            objestado.NombreEstado = "Nueva York";
            listaestado.Add(objestado);

            objestado = new clSMestado();
            objestado.CodigoPais = "02";
            objestado.NombrePais = "Estados Unidos";
            objestado.CodigoEstado = "0002";
            objestado.NombreEstado = "Florida";
            listaestado.Add(objestado);

            objestado = new clSMestado();
            objestado.CodigoPais = "02";
            objestado.NombrePais = "Estados Unidos";
            objestado.CodigoEstado = "00002";
            objestado.NombreEstado = "California";
            listaestado.Add(objestado);

            objestado = new clSMestado();
            objestado.CodigoPais = "03";
            objestado.NombrePais = "Brasil";
            objestado.CodigoEstado = "003";
            objestado.NombreEstado = "Rio de Janeiro";
            listaestado.Add(objestado);

            objestado = new clSMestado();
            objestado.CodigoPais = "03";
            objestado.NombrePais = "Brasil";
            objestado.CodigoEstado = "0003";
            objestado.NombreEstado = "Sao Paulo";
            listaestado.Add(objestado);

            objestado = new clSMestado();
            objestado.CodigoPais = "03";
            objestado.NombrePais = "Brasil";
            objestado.CodigoEstado = "00003";
            objestado.NombreEstado = "Bahia";
            listaestado.Add(objestado);

            //llenar tercer combobox
            clSMCiudad objciuda;
            
            
            objciuda = new clSMCiudad();
            objciuda.CodigoPais = "01";
            objciuda.NombrePais = "Colombia";
            objciuda.CodigoEstado = "001";
            objciuda.NombreEstado = "Antioquia";
            objciuda.CodigoCiudad = "011";
            objciuda.NombreCiudad = "Medellin";
            listaciudad.Add(objciuda);

            objciuda = new clSMCiudad();
            objciuda.CodigoPais = "01";
            objciuda.NombrePais = "Colombia";
            objciuda.CodigoEstado = "001";
            objciuda.NombreEstado = "Antioquia";
            objciuda.CodigoCiudad = "0011";
            objciuda.NombreCiudad = "Itagui";
            listaciudad.Add(objciuda);

            objciuda = new clSMCiudad();
            objciuda.CodigoPais = "01";
            objciuda.NombrePais = "Colombia";
            objciuda.CodigoEstado = "001";
            objciuda.NombreEstado = "Antioquia";
            objciuda.CodigoCiudad = "00011";
            objciuda.NombreCiudad = "Envigado";
            listaciudad.Add(objciuda);

            objciuda = new clSMCiudad();
            objciuda.CodigoPais = "01";
            objciuda.NombrePais = "Colombia";
            objciuda.CodigoEstado = "0001";
            objciuda.NombreEstado = "Cundinamarca";
            objciuda.CodigoCiudad = "021";
            objciuda.NombreCiudad = "Riohacha";
            listaciudad.Add(objciuda);

            objciuda = new clSMCiudad();
            objciuda.CodigoPais = "01";
            objciuda.NombrePais = "Colombia";
            objciuda.CodigoEstado = "0001";
            objciuda.NombreEstado = "Cundinamarca";
            objciuda.CodigoCiudad = "00211";
            objciuda.NombreCiudad = "Mesa Cundinamarca";
            listaciudad.Add(objciuda);

            objciuda = new clSMCiudad();
            objciuda.CodigoPais = "01";
            objciuda.NombrePais = "Colombia";
            objciuda.CodigoEstado = "0001";
            objciuda.NombreEstado = "Cundinamarca";
            objciuda.CodigoCiudad = "000211";
            objciuda.NombreCiudad = "Bogota";
            listaciudad.Add(objciuda);

            objciuda = new clSMCiudad();
            objciuda.CodigoPais = "01";
            objciuda.NombrePais = "Colombia";
            objciuda.CodigoEstado = "00001";
            objciuda.NombreEstado = "Amazonas";
            objciuda.CodigoCiudad = "031";
            objciuda.NombreCiudad = "Leticia";
            listaciudad.Add(objciuda);

            objciuda = new clSMCiudad();
            objciuda.CodigoPais = "01";
            objciuda.NombrePais = "Colombia";
            objciuda.CodigoEstado = "00001";
            objciuda.NombreEstado = "Amazonas";
            objciuda.CodigoCiudad = "00311";
            objciuda.NombreCiudad = "Amazonia";
            listaciudad.Add(objciuda);

            objciuda = new clSMCiudad();
            objciuda.CodigoPais = "01";
            objciuda.NombrePais = "Colombia";
            objciuda.CodigoEstado = "00001";
            objciuda.NombreEstado = "Amazonas";
            objciuda.CodigoCiudad = "000311";
            objciuda.NombreCiudad = "Junglares";
            listaciudad.Add(objciuda);

            objciuda = new clSMCiudad();
            objciuda.CodigoPais = "02";
            objciuda.NombrePais = "Estados Unidos";
            objciuda.CodigoEstado = "002";
            objciuda.NombreEstado = "Nueva York";
            objciuda.CodigoCiudad = "022";
            objciuda.NombreCiudad = "Brooklin";
            listaciudad.Add(objciuda);

            objciuda = new clSMCiudad();
            objciuda.CodigoPais = "02";
            objciuda.NombrePais = "Estados Unidos";
            objciuda.CodigoEstado = "002";
            objciuda.NombreEstado = "Nueva York";
            objciuda.CodigoCiudad = "0022";
            objciuda.NombreCiudad = "Jersey";
            listaciudad.Add(objciuda);

            objciuda = new clSMCiudad();
            objciuda.CodigoPais = "02";
            objciuda.NombrePais = "Estados Unidos";
            objciuda.CodigoEstado = "002";
            objciuda.NombreEstado = "Nueva York";
            objciuda.CodigoCiudad = "00022";
            objciuda.NombreCiudad = "Manhattan";
            listaciudad.Add(objciuda);

            objciuda = new clSMCiudad();
            objciuda.CodigoPais = "02";
            objciuda.NombrePais = "Estados Unidos";
            objciuda.CodigoEstado = "0002";
            objciuda.NombreEstado = "Florida";
            objciuda.CodigoCiudad = "031";
            objciuda.NombreCiudad = "Los Angeles";
            listaciudad.Add(objciuda);

            objciuda = new clSMCiudad();
            objciuda.CodigoPais = "02";
            objciuda.NombrePais = "Estados Unidos";
            objciuda.CodigoEstado = "0002";
            objciuda.NombreEstado = "Florida";
            objciuda.CodigoCiudad = "0031";
            objciuda.NombreCiudad = "San diego";
            listaciudad.Add(objciuda);

            objciuda = new clSMCiudad();
            objciuda.CodigoPais = "02";
            objciuda.NombrePais = "Estados Unidos";
            objciuda.CodigoEstado = "0002";
            objciuda.NombreEstado = "Florida";
            objciuda.CodigoCiudad = "00031";
            objciuda.NombreCiudad = "San Francisco";
            listaciudad.Add(objciuda);

            objciuda = new clSMCiudad();
            objciuda.CodigoPais = "02";
            objciuda.NombrePais = "Estados Unidos";
            objciuda.CodigoEstado = "00002";
            objciuda.NombreEstado = "California";
            objciuda.CodigoCiudad = "041";
            objciuda.NombreCiudad = "Universal";
            listaciudad.Add(objciuda);

            objciuda = new clSMCiudad();
            objciuda.CodigoPais = "02";
            objciuda.NombrePais = "Estados Unidos";
            objciuda.CodigoEstado = "00002";
            objciuda.NombreEstado = "California";
            objciuda.CodigoCiudad = "0041";
            objciuda.NombreCiudad = "Walt disney";
            listaciudad.Add(objciuda);

            objciuda = new clSMCiudad();
            objciuda.CodigoPais = "02";
            objciuda.NombrePais = "Estados Unidos";
            objciuda.CodigoEstado = "00002";
            objciuda.NombreEstado = "California";
            objciuda.CodigoCiudad = "00041";
            objciuda.NombreCiudad = "Darkside";
            listaciudad.Add(objciuda);

            objciuda = new clSMCiudad();
            objciuda.CodigoPais = "03";
            objciuda.NombrePais = "Brasil";
            objciuda.CodigoEstado = "003";
            objciuda.NombreEstado = "Rio de Janeiro";
            objciuda.CodigoCiudad = "033";
            objciuda.NombreCiudad = "Fabellas";
            listaciudad.Add(objciuda);

            objciuda = new clSMCiudad();
            objciuda.CodigoPais = "03";
            objciuda.NombrePais = "Brasil";
            objciuda.CodigoEstado = "003";
            objciuda.NombreEstado = "Rio de Janeiro";
            objciuda.CodigoCiudad = "0033";
            objciuda.NombreCiudad = "Copacabana";
            listaciudad.Add(objciuda);

            objciuda = new clSMCiudad();
            objciuda.CodigoPais = "03";
            objciuda.NombrePais = "Brasil";
            objciuda.CodigoEstado = "003";
            objciuda.NombreEstado = "Rio de Janeiro";
            objciuda.CodigoCiudad = "00033";
            objciuda.NombreCiudad = "Botafogo";
            listaciudad.Add(objciuda);

            //llenar combobox
            
            cmbpais.DataSource = listapais;
            cmbpais.DisplayMember = "NombrePais";
            cmbpais.ValueMember = "CodigoPais";
           // cmbpais.DataSource = null;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmSalarioMinimo_Load(object sender, EventArgs e)
        {

        }

        private void cmbpais_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CodigopaisSeleccionado = cmbpais.SelectedValue.ToString();
            List<clSMestado> listaestadofiltrada =
            listaestado.Where(w => w.CodigoPais == CodigopaisSeleccionado).ToList();

            //llenar combobox
            cmbdepartamento.DataSource = null;
            cmbdepartamento.DataSource = listaestadofiltrada;
            cmbdepartamento.DisplayMember = "NombreEstado";
            cmbdepartamento.ValueMember = "CodigoEstado";
        }

        private void cmbdepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CodigoEstadoSeleccionado = null;
            if (cmbdepartamento.SelectedValue != null)
            {
                CodigoEstadoSeleccionado = cmbdepartamento.SelectedValue.ToString();
                List<clSMCiudad> listadofiltradoEstado =
                listaciudad.Where(j => j.CodigoEstado == CodigoEstadoSeleccionado).ToList();


                //llenar combobox
                cmbciudad.DataSource = null;
                cmbciudad.DataSource = listadofiltradoEstado;
                cmbciudad.DisplayMember = "NombreCiudad";
                cmbciudad.ValueMember = "Codigociudad";
            }

        }
    }
}
