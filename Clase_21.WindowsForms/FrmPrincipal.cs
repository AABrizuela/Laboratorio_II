using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

using Clase_20.Entidades;
using System.Xml.Serialization;
using System.IO;
using System.Data.SqlClient;

namespace AdminPersonas
{
    public partial class FrmPrincipal : Form
    {
        private List<Persona> lista;

        private SqlConnection conexionSql;

        private DataTable tablaPersonas;

        private SqlDataAdapter sqlAdapter;

        Thread nuevoHilo;

        public FrmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            
            this.lista = new List<Persona>();
            this.tablaPersonas = new DataTable();
            CargarDataTable();
        }

        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer archivo = new XmlSerializer(typeof(List<Persona>));
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.ShowDialog();
                using (StreamReader reader = new StreamReader(openFile.FileName))
                {
                    this.lista = (List<Persona>)archivo.Deserialize(reader);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void guardarEnArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer archivo = new XmlSerializer(typeof(List<Persona>));
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.ShowDialog();
                using (StreamWriter writer = new StreamWriter(saveFile.FileName))
                {
                    archivo.Serialize(writer, this.lista);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisorPersona frm = new frmVisorPersona(this.lista);

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();

            this.lista = frm.Lista;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.conexionSql = new SqlConnection(Properties.Settings.Default.Conexion);
                this.conexionSql.Open();
                SqlCommand comandoSql = new SqlCommand();
                comandoSql.Connection = this.conexionSql;
                comandoSql.CommandType = CommandType.Text;
                comandoSql.CommandText = "SELECT TOP 1000 [id],[nombre],[apellido],[edad] FROM[personas_bd].[dbo].[personas]";
                SqlDataReader dataReader = comandoSql.ExecuteReader();
                while(dataReader.Read())
                {
                    MessageBox.Show(dataReader["id"].ToString() + " - " + dataReader["nombre"].ToString());
                }
                this.conexionSql.Close();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void traerTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.conexionSql = new SqlConnection(Properties.Settings.Default.Conexion);
                this.conexionSql.Open();
                SqlCommand comandoSql = new SqlCommand();
                comandoSql.Connection = this.conexionSql;
                comandoSql.CommandType = CommandType.Text;
                comandoSql.CommandText = "SELECT TOP 1000 [id],[nombre],[apellido],[edad] FROM[personas_bd].[dbo].[personas]";
                SqlDataReader dataReader = comandoSql.ExecuteReader();
                while (dataReader.Read())
                {
                    Persona persona = new Persona(dataReader["nombre"].ToString(), 
                                                  dataReader["apellido"].ToString(), 
                                                  Convert.ToInt32(dataReader["edad"].ToString()), 
                                                  Convert.ToInt32(dataReader["id"].ToString()));
                    this.lista.Add(persona);                    
                }
                this.conexionSql.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void CargarDataTable()
        {
            //using (this.conexionSql = new SqlConnection(Properties.Settings.Default.Conexion))
            //{
                try
                {
                    this.conexionSql = new SqlConnection(Properties.Settings.Default.Conexion);
                    //this.conexionSql.Open();
                    SqlCommand comandoSql = new SqlCommand();
                    comandoSql.Connection = this.conexionSql;
                    comandoSql.CommandType = CommandType.Text;
                    comandoSql.CommandText = "SELECT * FROM Personas";
                    //SqlDataReader dataReader = comandoSql.ExecuteReader();

                    //tablaPersonas.Load(dataReader);

                    this.sqlAdapter = new SqlDataAdapter(comandoSql);
                    this.sqlAdapter.Fill(this.tablaPersonas);
                    this.sqlAdapter.InsertCommand = new SqlCommand("INSERT INTO personas VALUES (@nombre, @apellido, @edad)", conexionSql);
                    this.sqlAdapter.UpdateCommand = new SqlCommand("UPDATE personas SET [nombre] = @nombre, [apellido] = @apellido, [edad] = @edad WHERE id = @where", conexionSql);
                    this.sqlAdapter.DeleteCommand = new SqlCommand("DELETE FROM personas WHERE id = @id", conexionSql);
                    sqlAdapter.InsertCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "nombre");
                    sqlAdapter.InsertCommand.Parameters.Add("@apellido", SqlDbType.VarChar, 50, "apellido");
                    sqlAdapter.InsertCommand.Parameters.Add("@edad", SqlDbType.Int, 10, "edad");

                    sqlAdapter.UpdateCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "nombre");
                    sqlAdapter.UpdateCommand.Parameters.Add("@apellido", SqlDbType.VarChar, 50, "apellido");
                    sqlAdapter.UpdateCommand.Parameters.Add("@edad", SqlDbType.Int, 10, "edad");
                    sqlAdapter.UpdateCommand.Parameters.Add("@where", SqlDbType.Int, 10, "id");

                    sqlAdapter.DeleteCommand.Parameters.Add("@id", SqlDbType.Int, 10, "id");

                    
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }                
            //}
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVisorDataTable frmDataTable = new FrmVisorDataTable(tablaPersonas);            

            frmDataTable.StartPosition = FormStartPosition.CenterScreen;

            frmDataTable.ShowDialog();

            this.lista = frmDataTable.Lista;
        }

        private void sincronizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoHilo = new Thread(SincronizarDB);

            nuevoHilo.Start();
        }

        private void SincronizarDB()
        {
            try 
            {
                this.sqlAdapter.Update(this.tablaPersonas);

                Thread.Sleep(2000);
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }
    }
}
