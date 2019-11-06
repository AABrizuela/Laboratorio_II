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
    public partial class frmVisorPersona : Form
    {
        protected List<Persona> listaAux;

        private SqlConnection conexionSql;

        public frmVisorPersona()
        {
            InitializeComponent();
            this.listaAux = new List<Persona>();
        }

        public frmVisorPersona(List<Persona> lista) : this()
        {
            this.listaAux = lista;
            this.cargarListBox();
        }

        public List<Persona> Lista
        {
            get
            {
                return this.listaAux;
            }
        }

        protected virtual void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.OK)
            {
                try
                {
                    using (this.conexionSql = new SqlConnection(Properties.Settings.Default.Conexion))
                    {
                        conexionSql.Open();
                        SqlCommand command = new SqlCommand();
                        command.Connection = this.conexionSql;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT INTO personas([nombre], [apellido], [edad]) VALUES (@nombre, @apellido, @edad)";
                        command.Parameters.AddWithValue("@nombre", frm.Persona.nombre);
                        command.Parameters.AddWithValue("@apellido", frm.Persona.apellido);
                        command.Parameters.AddWithValue("@edad", frm.Persona.Edad);
                        command.ExecuteNonQuery();                        
                    }
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }
                
                this.listaAux.Add(frm.Persona);
                this.cargarListBox();
            }
        }

        protected virtual void btnModificar_Click(object sender, EventArgs e)
        {
            Persona aux = listaAux[this.lstVisor.SelectedIndex];
            frmPersona frm = new frmPersona(aux.apellido, aux.nombre, aux.Edad);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                try
                {
                    using (this.conexionSql = new SqlConnection(Properties.Settings.Default.Conexion))
                    {
                        conexionSql.Open();
                        SqlCommand command = new SqlCommand();
                        command.Connection = this.conexionSql;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "UPDATE personas SET [nombre] = @nombre, [apellido] = @apellido, [edad] = @edad WHERE id = @where";
                        command.Parameters.AddWithValue("@nombre", frm.Persona.nombre);
                        command.Parameters.AddWithValue("@apellido", frm.Persona.apellido);
                        command.Parameters.AddWithValue("@edad", frm.Persona.Edad);
                        command.Parameters.AddWithValue("@where", aux.id);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }

                listaAux[this.lstVisor.SelectedIndex] = frm.Persona;
            }
            this.cargarListBox();
        }

        protected virtual void btnEliminar_Click(object sender, EventArgs e)
        {
            Persona aux = listaAux[this.lstVisor.SelectedIndex];
            frmPersona frm = new frmPersona(aux.apellido, aux.nombre, aux.Edad);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                try
                {
                    using (this.conexionSql = new SqlConnection(Properties.Settings.Default.Conexion))
                    {
                        conexionSql.Open();
                        SqlCommand command = new SqlCommand();
                        command.Connection = this.conexionSql;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "DELETE FROM personas WHERE id = " + aux.id + "";                        
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);                    
                }

                listaAux.Remove(aux);               
            }
            this.cargarListBox();
        }

        private void cargarListBox()
        {
            this.lstVisor.Items.Clear();
            foreach (Persona item in this.listaAux)
            {
                this.lstVisor.Items.Add(item.ToString());
            }
        }
    }
}
