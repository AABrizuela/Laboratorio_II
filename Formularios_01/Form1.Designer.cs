namespace Formularios_01
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
            this.pepe = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pepe
            // 
            this.pepe.Location = new System.Drawing.Point(12, 102);
            this.pepe.Name = "pepe";
            this.pepe.Size = new System.Drawing.Size(86, 23);
            this.pepe.TabIndex = 0;
            this.pepe.Text = "Mostrar Texto";
            this.pepe.UseVisualStyleBackColor = true;
            this.pepe.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Limpiar Texto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(12, 12);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(246, 20);
            this.txtTexto.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 139);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pepe);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pepe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTexto;
    }
}

