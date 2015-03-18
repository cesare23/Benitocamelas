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
using System.Diagnostics;

namespace Aplicativo_Encuesta
{
    public partial class frmParqueadero : Form
    {
        public frmParqueadero()
        {
            InitializeComponent();
            
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            clParqueadero parqueadero =new clParqueadero();
            parqueadero.TipoVehiculo = cbovehiculo.Text;
            int tarifa = parqueadero.TarifaVehiculo;
            TimeSpan horas = dtfecha_salida.Value - dtfecha_entrada.Value;
            double totalhoras=horas.TotalHours;
            double totalpagar = tarifa * totalhoras;
            txtcostopagar.Text = totalpagar.ToString();
            txtnumero_hora.Text = totalhoras.ToString();
            txttarifa.Text = tarifa.ToString();

            
            
        }

        private void btnfacturar_Click(object sender, EventArgs e)
        {
            StreamWriter guardar = new StreamWriter("factura.txt");
            guardar.Write("Fecha de entrada: " + dtfecha_entrada.Value);
            guardar.Write(System.Environment.NewLine + "Tipo de vehiculo: " + cbovehiculo.SelectedText);
            guardar.Write(System.Environment.NewLine + "Nombre: " + txtcliente.Text);
            guardar.Write(System.Environment.NewLine + "Indetificación: " + txtidentificacion.Text);
            guardar.Write(System.Environment.NewLine + "Placa: " + txtplaca.Text);
            guardar.Write(System.Environment.NewLine + "Fecha salida: " + dtfecha_salida.Text);
            guardar.Write(System.Environment.NewLine + "Numero de horas: " + txtnumero_hora.Text);
            guardar.Write(System.Environment.NewLine + "Tarifa: " + txttarifa.Text);
            guardar.Write(System.Environment.NewLine + "Total a pagar: " + txtcostopagar.Text);
            guardar.Close();

            Process notepad = Process.Start("notepad.exe", "factura.txt");
            this.Close();
        }
    }
}
