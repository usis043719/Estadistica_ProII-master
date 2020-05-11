using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programacionII_estadistica
{
    public partial class BusquedaCargo : Form
    {
        conexion objConexion = new conexion();
        public int _IdCargo;
        public BusquedaCargo()
        {
            InitializeComponent();
        }

        private void BusquedaCargo_Load(object sender, EventArgs e)
        {
            grdbusquedacargo.DataSource =
             objConexion.obtener_datos().Tables["Cargo"].DefaultView;
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdbusquedacargo.RowCount > 0)
            {
                _IdCargo = int.Parse(grdbusquedacargo.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Cargo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdbusquedacargo.DataSource;
            bs.Filter = "Cargo like '%" + valor + "%'";
            grdbusquedacargo.DataSource = bs;
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbusqueda.Text);
        }

        private void lblbusqueda_Click(object sender, EventArgs e)
        {

        }
    }
    
}

