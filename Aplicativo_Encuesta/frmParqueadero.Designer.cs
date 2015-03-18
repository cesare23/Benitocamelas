namespace Aplicativo_Encuesta
{
    partial class frmParqueadero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnfacturar = new System.Windows.Forms.Button();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.txtidentificacion = new System.Windows.Forms.TextBox();
            this.cbovehiculo = new System.Windows.Forms.ComboBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.dtfecha_entrada = new System.Windows.Forms.DateTimePicker();
            this.dtfecha_salida = new System.Windows.Forms.DateTimePicker();
            this.txtnumero_hora = new System.Windows.Forms.TextBox();
            this.txttarifa = new System.Windows.Forms.TextBox();
            this.txtcostopagar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Vehiculo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Placa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero de Identificacion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de Ingreso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de Salida:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Numero de Horas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tarifa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Costo a Pagar:";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(182, 184);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(141, 23);
            this.btnguardar.TabIndex = 9;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnfacturar
            // 
            this.btnfacturar.Location = new System.Drawing.Point(182, 322);
            this.btnfacturar.Name = "btnfacturar";
            this.btnfacturar.Size = new System.Drawing.Size(141, 23);
            this.btnfacturar.TabIndex = 10;
            this.btnfacturar.Text = "Facturar";
            this.btnfacturar.UseVisualStyleBackColor = true;
            this.btnfacturar.Click += new System.EventHandler(this.btnfacturar_Click);
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(182, 22);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(141, 20);
            this.txtcliente.TabIndex = 11;
            // 
            // txtidentificacion
            // 
            this.txtidentificacion.Location = new System.Drawing.Point(182, 47);
            this.txtidentificacion.Name = "txtidentificacion";
            this.txtidentificacion.Size = new System.Drawing.Size(141, 20);
            this.txtidentificacion.TabIndex = 12;
            // 
            // cbovehiculo
            // 
            this.cbovehiculo.FormattingEnabled = true;
            this.cbovehiculo.Items.AddRange(new object[] {
            "carro",
            "moto"});
            this.cbovehiculo.Location = new System.Drawing.Point(182, 71);
            this.cbovehiculo.Name = "cbovehiculo";
            this.cbovehiculo.Size = new System.Drawing.Size(141, 21);
            this.cbovehiculo.TabIndex = 13;
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(182, 95);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(141, 20);
            this.txtplaca.TabIndex = 14;
            // 
            // dtfecha_entrada
            // 
            this.dtfecha_entrada.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtfecha_entrada.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtfecha_entrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtfecha_entrada.Location = new System.Drawing.Point(182, 121);
            this.dtfecha_entrada.Name = "dtfecha_entrada";
            this.dtfecha_entrada.Size = new System.Drawing.Size(141, 20);
            this.dtfecha_entrada.TabIndex = 15;
            // 
            // dtfecha_salida
            // 
            this.dtfecha_salida.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtfecha_salida.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtfecha_salida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtfecha_salida.Location = new System.Drawing.Point(182, 147);
            this.dtfecha_salida.Name = "dtfecha_salida";
            this.dtfecha_salida.Size = new System.Drawing.Size(141, 20);
            this.dtfecha_salida.TabIndex = 16;
            // 
            // txtnumero_hora
            // 
            this.txtnumero_hora.Location = new System.Drawing.Point(182, 234);
            this.txtnumero_hora.Name = "txtnumero_hora";
            this.txtnumero_hora.Size = new System.Drawing.Size(141, 20);
            this.txtnumero_hora.TabIndex = 17;
            // 
            // txttarifa
            // 
            this.txttarifa.Location = new System.Drawing.Point(182, 258);
            this.txttarifa.Name = "txttarifa";
            this.txttarifa.Size = new System.Drawing.Size(141, 20);
            this.txttarifa.TabIndex = 18;
            // 
            // txtcostopagar
            // 
            this.txtcostopagar.Location = new System.Drawing.Point(182, 283);
            this.txtcostopagar.Name = "txtcostopagar";
            this.txtcostopagar.Size = new System.Drawing.Size(141, 20);
            this.txtcostopagar.TabIndex = 19;
            // 
            // frmParqueadero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 364);
            this.Controls.Add(this.txtcostopagar);
            this.Controls.Add(this.txttarifa);
            this.Controls.Add(this.txtnumero_hora);
            this.Controls.Add(this.dtfecha_salida);
            this.Controls.Add(this.dtfecha_entrada);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.cbovehiculo);
            this.Controls.Add(this.txtidentificacion);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.btnfacturar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmParqueadero";
            this.Text = "Parqueadero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnfacturar;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.TextBox txtidentificacion;
        private System.Windows.Forms.ComboBox cbovehiculo;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.DateTimePicker dtfecha_entrada;
        private System.Windows.Forms.DateTimePicker dtfecha_salida;
        private System.Windows.Forms.TextBox txtnumero_hora;
        private System.Windows.Forms.TextBox txttarifa;
        private System.Windows.Forms.TextBox txtcostopagar;
    }
}