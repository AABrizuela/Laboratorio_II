namespace Clase_04.WindowsForm
{
    partial class Form1
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
            this.txtTextoEntero = new System.Windows.Forms.TextBox();
            this.txtTextoFecha = new System.Windows.Forms.TextBox();
            this.txtTextoCadena = new System.Windows.Forms.TextBox();
            this.btnBoton1 = new System.Windows.Forms.Button();
            this.lblLabel1 = new System.Windows.Forms.Label();
            this.lblLabel2 = new System.Windows.Forms.Label();
            this.lblLabel3 = new System.Windows.Forms.Label();
            this.lstListaCosa = new System.Windows.Forms.ListBox();
            this.btnBotonRojo = new System.Windows.Forms.Button();
            this.btnBotonNegro = new System.Windows.Forms.Button();
            this.btnBotonAzul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTextoEntero
            // 
            this.txtTextoEntero.Location = new System.Drawing.Point(89, 21);
            this.txtTextoEntero.Name = "txtTextoEntero";
            this.txtTextoEntero.Size = new System.Drawing.Size(230, 20);
            this.txtTextoEntero.TabIndex = 0;
            this.txtTextoEntero.TextChanged += new System.EventHandler(this.txtTextoEntero_TextChanged);
            // 
            // txtTextoFecha
            // 
            this.txtTextoFecha.Location = new System.Drawing.Point(89, 73);
            this.txtTextoFecha.Name = "txtTextoFecha";
            this.txtTextoFecha.Size = new System.Drawing.Size(230, 20);
            this.txtTextoFecha.TabIndex = 0;
            // 
            // txtTextoCadena
            // 
            this.txtTextoCadena.Location = new System.Drawing.Point(89, 47);
            this.txtTextoCadena.Name = "txtTextoCadena";
            this.txtTextoCadena.Size = new System.Drawing.Size(230, 20);
            this.txtTextoCadena.TabIndex = 0;
            // 
            // btnBoton1
            // 
            this.btnBoton1.Location = new System.Drawing.Point(130, 203);
            this.btnBoton1.Name = "btnBoton1";
            this.btnBoton1.Size = new System.Drawing.Size(75, 23);
            this.btnBoton1.TabIndex = 1;
            this.btnBoton1.Text = "Crear";
            this.btnBoton1.UseVisualStyleBackColor = true;
            this.btnBoton1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblLabel1
            // 
            this.lblLabel1.AutoSize = true;
            this.lblLabel1.Location = new System.Drawing.Point(12, 24);
            this.lblLabel1.Name = "lblLabel1";
            this.lblLabel1.Size = new System.Drawing.Size(38, 13);
            this.lblLabel1.TabIndex = 2;
            this.lblLabel1.Text = "Entero";
            // 
            // lblLabel2
            // 
            this.lblLabel2.AutoSize = true;
            this.lblLabel2.Location = new System.Drawing.Point(12, 50);
            this.lblLabel2.Name = "lblLabel2";
            this.lblLabel2.Size = new System.Drawing.Size(44, 13);
            this.lblLabel2.TabIndex = 2;
            this.lblLabel2.Text = "Cadena";
            // 
            // lblLabel3
            // 
            this.lblLabel3.AutoSize = true;
            this.lblLabel3.Location = new System.Drawing.Point(12, 76);
            this.lblLabel3.Name = "lblLabel3";
            this.lblLabel3.Size = new System.Drawing.Size(37, 13);
            this.lblLabel3.TabIndex = 2;
            this.lblLabel3.Text = "Fecha";
            this.lblLabel3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lstListaCosa
            // 
            this.lstListaCosa.FormattingEnabled = true;
            this.lstListaCosa.Location = new System.Drawing.Point(15, 99);
            this.lstListaCosa.Name = "lstListaCosa";
            this.lstListaCosa.Size = new System.Drawing.Size(304, 69);
            this.lstListaCosa.TabIndex = 3;
            // 
            // btnBotonRojo
            // 
            this.btnBotonRojo.Location = new System.Drawing.Point(49, 174);
            this.btnBotonRojo.Name = "btnBotonRojo";
            this.btnBotonRojo.Size = new System.Drawing.Size(75, 23);
            this.btnBotonRojo.TabIndex = 4;
            this.btnBotonRojo.Text = "Rojo";
            this.btnBotonRojo.UseVisualStyleBackColor = true;
            this.btnBotonRojo.Click += new System.EventHandler(this.btnBotonRojo_Click);
            // 
            // btnBotonNegro
            // 
            this.btnBotonNegro.Location = new System.Drawing.Point(130, 174);
            this.btnBotonNegro.Name = "btnBotonNegro";
            this.btnBotonNegro.Size = new System.Drawing.Size(75, 23);
            this.btnBotonNegro.TabIndex = 5;
            this.btnBotonNegro.Text = "Negro";
            this.btnBotonNegro.UseVisualStyleBackColor = true;
            this.btnBotonNegro.Click += new System.EventHandler(this.btnBotonNegro_Click);
            // 
            // btnBotonAzul
            // 
            this.btnBotonAzul.Location = new System.Drawing.Point(212, 175);
            this.btnBotonAzul.Name = "btnBotonAzul";
            this.btnBotonAzul.Size = new System.Drawing.Size(75, 23);
            this.btnBotonAzul.TabIndex = 6;
            this.btnBotonAzul.Text = "Azul";
            this.btnBotonAzul.UseVisualStyleBackColor = true;
            this.btnBotonAzul.Click += new System.EventHandler(this.btnBotonAzul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 232);
            this.Controls.Add(this.btnBotonAzul);
            this.Controls.Add(this.btnBotonNegro);
            this.Controls.Add(this.btnBotonRojo);
            this.Controls.Add(this.lstListaCosa);
            this.Controls.Add(this.lblLabel3);
            this.Controls.Add(this.lblLabel2);
            this.Controls.Add(this.lblLabel1);
            this.Controls.Add(this.btnBoton1);
            this.Controls.Add(this.txtTextoCadena);
            this.Controls.Add(this.txtTextoFecha);
            this.Controls.Add(this.txtTextoEntero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextoEntero;
        private System.Windows.Forms.TextBox txtTextoFecha;
        private System.Windows.Forms.TextBox txtTextoCadena;
        private System.Windows.Forms.Button btnBoton1;
        private System.Windows.Forms.Label lblLabel1;
        private System.Windows.Forms.Label lblLabel2;
        private System.Windows.Forms.Label lblLabel3;
        private System.Windows.Forms.ListBox lstListaCosa;
        private System.Windows.Forms.Button btnBotonRojo;
        private System.Windows.Forms.Button btnBotonNegro;
        private System.Windows.Forms.Button btnBotonAzul;
    }
}

