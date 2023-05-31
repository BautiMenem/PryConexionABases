using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PryConexionABases
{
    internal class ClsConexion
    {
        public OleDbConnection Conexion = new OleDbConnection();
        public OleDbDataReader Lector;
        public OleDbCommand Comando = new OleDbCommand();

        public string ListarTablas(ComboBox cboColumna, DataGridView dgvDatos, Label lblBase)
        {
            dgvDatos.DataSource = null;
            cboColumna.SelectedIndex = -1;
            string cadenaConexion = "";
            using (OpenFileDialog OpenFileDialog = new OpenFileDialog())
            {
                if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string archivo = OpenFileDialog.FileName;
                    lblBase.Text = Path.GetFileName(archivo);

                    if (Path.GetExtension(archivo) == ".accdb")
                    {
                        cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + archivo + ";Persist Security Info=False;";
                    }
                    else
                    {
                        cadenaConexion = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + archivo + ";";
                    }

                    Conexion.ConnectionString = cadenaConexion;

                    cboColumna.Items.Clear();

                    try
                    {
                        Conexion.Open();

                        DataTable tablas = Conexion.GetSchema("Tables");

                        foreach (DataRow tabla in tablas.Rows)
                        {
                            if (tabla[3].ToString() == "TABLE")
                            {
                                cboColumna.Items.Add(tabla[2].ToString());
                            }
                        }
                        Conexion.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
            return cadenaConexion;
        }

        public void MostrarTablas(ComboBox cboColumna, string cadenaConexion, DataGridView dgvDatos)
        {
            if (cboColumna.SelectedIndex != -1)
            {
                Conexion.ConnectionString = cadenaConexion;

                try
                {
                    Comando.Connection = Conexion;
                    Comando.CommandText = cboColumna.Text;
                    Comando.CommandType = CommandType.TableDirect;
                    Comando.Connection.Open();

                    Lector = Comando.ExecuteReader();

                    DataTable tabla = new DataTable();
                    tabla.Load(Lector);

                    dgvDatos.DataSource = tabla;

                    Comando.Connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

    }
}
