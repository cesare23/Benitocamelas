namespace Aplicativo_Encuesta
{
    partial class frminformacion
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
            this.cbxciudad = new System.Windows.Forms.ComboBox();
            this.btnsiguiente1 = new System.Windows.Forms.Button();
            this.clbpregrados = new System.Windows.Forms.CheckedListBox();
            this.dtpfecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxciudad
            // 
            this.cbxciudad.FormattingEnabled = true;
            this.cbxciudad.Items.AddRange(new object[] {
            "Medellin.",
            "Bogota.",
            "Manizales.",
            "Barranquilla.",
            "Leticia."});
            this.cbxciudad.Location = new System.Drawing.Point(153, 144);
            this.cbxciudad.Name = "cbxciudad";
            this.cbxciudad.Size = new System.Drawing.Size(199, 21);
            this.cbxciudad.TabIndex = 39;
            // 
            // btnsiguiente1
            // 
            this.btnsiguiente1.Location = new System.Drawing.Point(264, 376);
            this.btnsiguiente1.Name = "btnsiguiente1";
            this.btnsiguiente1.Size = new System.Drawing.Size(88, 26);
            this.btnsiguiente1.TabIndex = 38;
            this.btnsiguiente1.Text = "Siguiente";
            this.btnsiguiente1.UseVisualStyleBackColor = true;
            this.btnsiguiente1.Click += new System.EventHandler(this.btnsiguiente1_Click);
            // 
            // clbpregrados
            // 
            this.clbpregrados.FormattingEnabled = true;
            this.clbpregrados.Items.AddRange(new object[] {
            "Ingenieria de sistemas.",
            "Ingenieria Industrial.",
            "Ingenieria Civil.",
            "Mecatronica.",
            "Negocios Internacionales.",
            "Medicina.",
            "Derecho.",
            "Otro."});
            this.clbpregrados.Location = new System.Drawing.Point(28, 228);
            this.clbpregrados.Name = "clbpregrados";
            this.clbpregrados.Size = new System.Drawing.Size(296, 124);
            this.clbpregrados.TabIndex = 37;
            // 
            // dtpfecha_nacimiento
            // 
            this.dtpfecha_nacimiento.Location = new System.Drawing.Point(153, 81);
            this.dtpfecha_nacimiento.Name = "dtpfecha_nacimiento";
            this.dtpfecha_nacimiento.Size = new System.Drawing.Size(199, 20);
            this.dtpfecha_nacimiento.TabIndex = 36;
            this.dtpfecha_nacimiento.ValueChanged += new System.EventHandler(this.dtpfecha_nacimiento_ValueChanged);
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(153, 53);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(199, 20);
            this.txtapellido.TabIndex = 35;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(153, 115);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(199, 20);
            this.txtedad.TabIndex = 34;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(153, 25);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(199, 20);
            this.txtnombre.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Fecha de Nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Edad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Seleccionar el/los Pregados que esta Cursando Actualmente.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Ciudad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Apellido Completo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre Completo:";
            // 
            // frminformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 414);
            this.Controls.Add(this.cbxciudad);
            this.Controls.Add(this.btnsiguiente1);
            this.Controls.Add(this.clbpregrados);
            this.Controls.Add(this.dtpfecha_nacimiento);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frminformacion";
            this.Text = "Datos Personales.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxciudad;
        private System.Windows.Forms.Button btnsiguiente1;
        private System.Windows.Forms.CheckedListBox clbpregrados;
        private System.Windows.Forms.DateTimePicker dtpfecha_nacimiento;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}