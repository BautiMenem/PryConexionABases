using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryConexionABases
{
    public partial class frmConexion : Form
    {
        public string cadenaConexion;
        public frmConexion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblBaseCon_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboComlumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsConexion clsBaseDeDatos = new ClsConexion();
            clsBaseDeDatos.MostrarTablas(cboColumna, cadenaConexion, dgvDatos);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ClsConexion clsBaseDeDatos = new ClsConexion();
            cadenaConexion = clsBaseDeDatos.ListarTablas(cboColumna, dgvDatos, lblBase);
           
        }
    }
}
