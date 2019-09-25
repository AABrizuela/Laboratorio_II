namespace Clase_09.WindowsForm
{
    partial class FrmCatedra
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.lstAlumno = new System.Windows.Forms.ListBox();
            this.lstAlumnosCalificados = new System.Windows.Forms.ListBox();
            this.gbxAlumno = new System.Windows.Forms.GroupBox();
            this.gbxAlumnosCalificados = new System.Windows.Forms.GroupBox();
            this.gbxAlumno.SuspendLayout();
            this.gbxAlumnosCalificados.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(165, 19);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(75, 23);
            this.btnCalificar.TabIndex = 1;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(329, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cmbSort
            // 
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(6, 138);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(398, 21);
            this.cmbSort.TabIndex = 3;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // lstAlumno
            // 
            this.lstAlumno.FormattingEnabled = true;
            this.lstAlumno.Location = new System.Drawing.Point(6, 48);
            this.lstAlumno.Name = "lstAlumno";
            this.lstAlumno.Size = new System.Drawing.Size(398, 82);
            this.lstAlumno.TabIndex = 4;
            // 
            // lstAlumnosCalificados
            // 
            this.lstAlumnosCalificados.FormattingEnabled = true;
            this.lstAlumnosCalificados.Location = new System.Drawing.Point(6, 20);
            this.lstAlumnosCalificados.Name = "lstAlumnosCalificados";
            this.lstAlumnosCalificados.Size = new System.Drawing.Size(398, 121);
            this.lstAlumnosCalificados.TabIndex = 5;
            // 
            // gbxAlumno
            // 
            this.gbxAlumno.Controls.Add(this.cmbSort);
            this.gbxAlumno.Controls.Add(this.btnAgregar);
            this.gbxAlumno.Controls.Add(this.btnCalificar);
            this.gbxAlumno.Controls.Add(this.lstAlumno);
            this.gbxAlumno.Controls.Add(this.btnModificar);
            this.gbxAlumno.Location = new System.Drawing.Point(12, 12);
            this.gbxAlumno.Name = "gbxAlumno";
            this.gbxAlumno.Size = new System.Drawing.Size(410, 170);
            this.gbxAlumno.TabIndex = 6;
            this.gbxAlumno.TabStop = false;
            this.gbxAlumno.Text = "Alumno";
            // 
            // gbxAlumnosCalificados
            // 
            this.gbxAlumnosCalificados.Controls.Add(this.lstAlumnosCalificados);
            this.gbxAlumnosCalificados.Location = new System.Drawing.Point(12, 188);
            this.gbxAlumnosCalificados.Name = "gbxAlumnosCalificados";
            this.gbxAlumnosCalificados.Size = new System.Drawing.Size(410, 153);
            this.gbxAlumnosCalificados.TabIndex = 0;
            this.gbxAlumnosCalificados.TabStop = false;
            this.gbxAlumnosCalificados.Text = "Alumnos Calificados";
            // 
            // FrmCatedra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 353);
            this.Controls.Add(this.gbxAlumnosCalificados);
            this.Controls.Add(this.gbxAlumno);
            this.Name = "FrmCatedra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCatedra";
            this.gbxAlumno.ResumeLayout(false);
            this.gbxAlumnosCalificados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.ListBox lstAlumno;
        private System.Windows.Forms.ListBox lstAlumnosCalificados;
        private System.Windows.Forms.GroupBox gbxAlumno;
        private System.Windows.Forms.GroupBox gbxAlumnosCalificados;
    }
}