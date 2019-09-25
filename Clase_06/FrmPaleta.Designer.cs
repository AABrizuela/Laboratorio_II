namespace Clase_06
{
    partial class FrmPaleta
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
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPaletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarTemperasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxPaleta = new System.Windows.Forms.GroupBox();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.lstPaleta = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.gbxPaleta.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearPaletaToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administracionToolStripMenuItem.Text = "Administracion";
            // 
            // crearPaletaToolStripMenuItem
            // 
            this.crearPaletaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarTemperasToolStripMenuItem});
            this.crearPaletaToolStripMenuItem.Name = "crearPaletaToolStripMenuItem";
            this.crearPaletaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.crearPaletaToolStripMenuItem.Text = "Crear Paleta";
            this.crearPaletaToolStripMenuItem.Click += new System.EventHandler(this.crearPaletaToolStripMenuItem_Click);
            // 
            // agregarTemperasToolStripMenuItem
            // 
            this.agregarTemperasToolStripMenuItem.Name = "agregarTemperasToolStripMenuItem";
            this.agregarTemperasToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.agregarTemperasToolStripMenuItem.Text = "Agregar Temperas";
            this.agregarTemperasToolStripMenuItem.Click += new System.EventHandler(this.agregarTemperasToolStripMenuItem_Click);
            // 
            // gbxPaleta
            // 
            this.gbxPaleta.Controls.Add(this.btnMenos);
            this.gbxPaleta.Controls.Add(this.btnMas);
            this.gbxPaleta.Controls.Add(this.lstPaleta);
            this.gbxPaleta.Location = new System.Drawing.Point(12, 27);
            this.gbxPaleta.Name = "gbxPaleta";
            this.gbxPaleta.Size = new System.Drawing.Size(381, 276);
            this.gbxPaleta.TabIndex = 1;
            this.gbxPaleta.TabStop = false;
            this.gbxPaleta.Text = "Paleta";
            this.gbxPaleta.Enter += new System.EventHandler(this.gbxPaleta_Enter);
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(199, 247);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(75, 23);
            this.btnMenos.TabIndex = 2;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMas
            // 
            this.btnMas.Location = new System.Drawing.Point(118, 247);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(75, 23);
            this.btnMas.TabIndex = 1;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // lstPaleta
            // 
            this.lstPaleta.FormattingEnabled = true;
            this.lstPaleta.Location = new System.Drawing.Point(3, 16);
            this.lstPaleta.Name = "lstPaleta";
            this.lstPaleta.Size = new System.Drawing.Size(372, 225);
            this.lstPaleta.TabIndex = 0;
            this.lstPaleta.SelectedIndexChanged += new System.EventHandler(this.lstPaleta_SelectedIndexChanged);
            // 
            // FrmPaleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxPaleta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPaleta";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxPaleta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPaletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarTemperasToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxPaleta;
        private System.Windows.Forms.ListBox lstPaleta;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMas;
    }
}

