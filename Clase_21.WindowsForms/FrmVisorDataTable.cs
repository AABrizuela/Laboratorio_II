using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Data.SqlClient;

using Clase_20.Entidades;

namespace AdminPersonas
{
    public partial class FrmVisorDataTable : frmVisorPersona
    {
        private DataTable dataTable;
        
        //private SqlConnection conexionSql;

        public FrmVisorDataTable(DataTable dt) : base()
        {
            InitializeComponent();
            dataTable = dt;
            this.cargarDataTable();
        }

        public DataTable DataTable { get => this.dataTable; }

        protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                //try
                //{
                //    using (this.conexionSql = new SqlConnection(Properties.Settings.Default.Conexion))
                //    {
                //        conexionSql.Open();
                //        SqlCommand command = new SqlCommand();
                //        command.Connection = this.conexionSql;
                //        command.CommandType = CommandType.Text;
                //        command.CommandText = "INSERT INTO personas([nombre], [apellido], [edad]) VALUES (@nombre, @apellido, @edad)";
                //        command.Parameters.AddWithValue("@nombre", frm.Persona.nombre);
                //        command.Parameters.AddWithValue("@apellido", frm.Persona.apellido);
                //        command.Parameters.AddWithValue("@edad", frm.Persona.Edad);
                //        command.ExecuteNonQuery();
                //    }
                //}
                //catch (Exception excep)
                //{
                //    MessageBox.Show(excep.Message);
                //}

                DataRow dataRow = DataTable.NewRow();
                dataRow[1] = frm.Persona.nombre;
                dataRow[2] = frm.Persona.apellido;
                dataRow[3] = frm.Persona.Edad;
                dataTable.Rows.Add(dataRow);
                this.cargarDataTable();
            }
        }

        protected override void btnModificar_Click(object sender, EventArgs e)
        {
            DataRow aux = this.dataTable.Rows[this.lstVisor.SelectedIndex];
            frmPersona frm = new frmPersona(aux[1].ToString(), aux[2].ToString(), Convert.ToInt32(aux[3]));
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                //try
                //{
                //    using (this.conexionSql = new SqlConnection(Properties.Settings.Default.Conexion))
                //    {
                //        conexionSql.Open();
                //        SqlCommand command = new SqlCommand();
                //        command.Connection = this.conexionSql;
                //        command.CommandType = CommandType.Text;
                //        command.CommandText = "UPDATE personas SET [nombre] = @nombre, [apellido] = @apellido, [edad] = @edad WHERE id = @where";
                //        command.Parameters.AddWithValue("@nombre", frm.Persona.nombre);
                //        command.Parameters.AddWithValue("@apellido", frm.Persona.apellido);
                //        command.Parameters.AddWithValue("@edad", frm.Persona.Edad);
                //        command.Parameters.AddWithValue("@where", aux[0].ToString());
                //        command.ExecuteNonQuery();
                //    }
                //}
                //catch (Exception excep)
                //{
                //    MessageBox.Show(excep.Message);
                //}

                aux[1] = frm.Persona.nombre;
                aux[2] = frm.Persona.apellido;
                aux[3] = frm.Persona.Edad;                
            }
            this.cargarDataTable();
        }

        protected override void btnEliminar_Click(object sender, EventArgs e)
        {
            DataRow aux = this.dataTable.Rows[this.lstVisor.SelectedIndex];
            frmPersona frm = new frmPersona(aux[1].ToString(), aux[2].ToString(), Convert.ToInt32(aux[3]));
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                //try
                //{
                //    using (this.conexionSql = new SqlConnection(Properties.Settings.Default.Conexion))
                //    {
                //        conexionSql.Open();
                //        SqlCommand command = new SqlCommand();
                //        command.Connection = this.conexionSql;
                //        command.CommandType = CommandType.Text;
                //        command.CommandText = "DELETE FROM personas WHERE id = " + aux[0].ToString() + "";
                //        command.ExecuteNonQuery();
                //    }
                //}
                //catch (Exception excep)
                //{
                //    MessageBox.Show(excep.Message);
                //}

                aux.Delete();
            }
            this.cargarDataTable();
        }

        #region Metodos
        private void cargarDataTable()
        {
            this.lstVisor.Items.Clear();
            foreach (DataRow item in dataTable.Rows)
            {
                if(item.RowState != DataRowState.Deleted)
                    this.lstVisor.Items.Add("Nombre: " + item[1].ToString() + " - Apellido: " + item[2].ToString() + " - Edad: " + item[3].ToString());
            }
        }
        #endregion
    }
}
