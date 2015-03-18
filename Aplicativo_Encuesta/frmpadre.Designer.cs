namespace Aplicativo_Encuesta
{
    partial class frmpadre
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosPersonalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encuestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primerActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segundaActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parqueaderoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terceraActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.primerActividadToolStripMenuItem,
            this.segundaActividadToolStripMenuItem,
            this.terceraActividadToolStripMenuItem,
            this.examenesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosPersonalesToolStripMenuItem,
            this.encuestaToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // datosPersonalesToolStripMenuItem
            // 
            this.datosPersonalesToolStripMenuItem.Name = "datosPersonalesToolStripMenuItem";
            this.datosPersonalesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.datosPersonalesToolStripMenuItem.Text = "Datos Personales";
            this.datosPersonalesToolStripMenuItem.Click += new System.EventHandler(this.datosPersonalesToolStripMenuItem_Click);
            // 
            // encuestaToolStripMenuItem
            // 
            this.encuestaToolStripMenuItem.Name = "encuestaToolStripMenuItem";
            this.encuestaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.encuestaToolStripMenuItem.Text = "Encuesta";
            this.encuestaToolStripMenuItem.Click += new System.EventHandler(this.encuestaToolStripMenuItem_Click);
            // 
            // primerActividadToolStripMenuItem
            // 
            this.primerActividadToolStripMenuItem.Name = "primerActividadToolStripMenuItem";
            this.primerActividadToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.primerActividadToolStripMenuItem.Text = "Primer Actividad";
            // 
            // segundaActividadToolStripMenuItem
            // 
            this.segundaActividadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parqueaderoToolStripMenuItem});
            this.segundaActividadToolStripMenuItem.Name = "segundaActividadToolStripMenuItem";
            this.segundaActividadToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.segundaActividadToolStripMenuItem.Text = "Segunda Actividad";
            // 
            // parqueaderoToolStripMenuItem
            // 
            this.parqueaderoToolStripMenuItem.Name = "parqueaderoToolStripMenuItem";
            this.parqueaderoToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.parqueaderoToolStripMenuItem.Text = "Parqueadero";
            this.parqueaderoToolStripMenuItem.Click += new System.EventHandler(this.parqueaderoToolStripMenuItem_Click);
            // 
            // terceraActividadToolStripMenuItem
            // 
            this.terceraActividadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transitoToolStripMenuItem,
            this.salariosToolStripMenuItem});
            this.terceraActividadToolStripMenuItem.Name = "terceraActividadToolStripMenuItem";
            this.terceraActividadToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.terceraActividadToolStripMenuItem.Text = "Tercera Actividad";
            // 
            // transitoToolStripMenuItem
            // 
            this.transitoToolStripMenuItem.Name = "transitoToolStripMenuItem";
            this.transitoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.transitoToolStripMenuItem.Text = "Transito";
            this.transitoToolStripMenuItem.Click += new System.EventHandler(this.transitoToolStripMenuItem_Click);
            // 
            // examenesToolStripMenuItem
            // 
            this.examenesToolStripMenuItem.Name = "examenesToolStripMenuItem";
            this.examenesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.examenesToolStripMenuItem.Text = "Examenes";
            // 
            // salariosToolStripMenuItem
            // 
            this.salariosToolStripMenuItem.Name = "salariosToolStripMenuItem";
            this.salariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salariosToolStripMenuItem.Text = "Salarios";
            this.salariosToolStripMenuItem.Click += new System.EventHandler(this.salariosToolStripMenuItem_Click);
            // 
            // frmpadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmpadre";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosPersonalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encuestaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primerActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segundaActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parqueaderoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terceraActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salariosToolStripMenuItem;
    }
}