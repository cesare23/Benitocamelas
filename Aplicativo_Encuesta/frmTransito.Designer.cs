namespace Aplicativo_Encuesta
{
    partial class frmTransito
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbciudad = new System.Windows.Forms.ComboBox();
            this.cmbtransito = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtvalorlicencia = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtValor_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 10);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(112, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Moto (2 Categoria)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(178, 10);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(158, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Servicio Public (4 Categoria)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(9, 51);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(129, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Vehiculo (3 Categoria)";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(178, 51);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(134, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Camiones (5 Categoria)";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ciudad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Transito:";
            // 
            // cmbciudad
            // 
            this.cmbciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbciudad.FormattingEnabled = true;
            this.cmbciudad.Location = new System.Drawing.Point(113, 131);
            this.cmbciudad.Name = "cmbciudad";
            this.cmbciudad.Size = new System.Drawing.Size(243, 21);
            this.cmbciudad.TabIndex = 6;
            this.cmbciudad.SelectedIndexChanged += new System.EventHandler(this.cmbciudad_SelectedIndexChanged);
            // 
            // cmbtransito
            // 
            this.cmbtransito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtransito.FormattingEnabled = true;
            this.cmbtransito.Location = new System.Drawing.Point(113, 158);
            this.cmbtransito.Name = "cmbtransito";
            this.cmbtransito.Size = new System.Drawing.Size(243, 21);
            this.cmbtransito.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(25, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 79);
            this.panel1.TabIndex = 8;
            // 
            // txtvalorlicencia
            // 
            this.txtvalorlicencia.Location = new System.Drawing.Point(113, 216);
            this.txtvalorlicencia.Name = "txtvalorlicencia";
            this.txtvalorlicencia.Size = new System.Drawing.Size(118, 20);
            this.txtvalorlicencia.TabIndex = 9;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(113, 242);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(118, 20);
            this.txtcantidad.TabIndex = 10;
            // 
            // txtValor_total
            // 
            this.txtValor_total.Location = new System.Drawing.Point(113, 268);
            this.txtValor_total.Name = "txtValor_total";
            this.txtValor_total.Size = new System.Drawing.Size(118, 20);
            this.txtValor_total.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Valor Licensia:";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(270, 215);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(105, 72);
            this.btncalcular.TabIndex = 13;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Valor Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cantidad:";
            // 
            // frmTransito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 312);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValor_total);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtvalorlicencia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbtransito);
            this.Controls.Add(this.cmbciudad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTransito";
            this.Text = "Transito";
            this.Load += new System.EventHandler(this.frmTransito_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbciudad;
        private System.Windows.Forms.ComboBox cmbtransito;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtvalorlicencia;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtValor_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}