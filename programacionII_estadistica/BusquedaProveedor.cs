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
    public partial class BusquedaProveedor : Form
    {
        conexion objConexion = new conexion();
        public int _IdProveedor;
        public BusquedaProveedor()
        {
            InitializeComponent();
        }

        private void BusquedaProveedor_Load(object sender, EventArgs e)
        {
            grdBusquedaProveedores.DataSource =
               objConexion.obtener_datos().Tables["Proveedor"].DefaultView;
        }

        private void txtbusquedaproveedor_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbusquedaproveedor.Text);
        }

        private void btnseleccionarproveedor_Click(object sender, EventArgs e)
        {
            if (grdBusquedaProveedores.RowCount > 0)
            {
                _IdProveedor = int.Parse(grdBusquedaProveedores.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "BusquedaProveedor",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
    }

        private void btncancelarpro_Click(object sender, EventArgs e)
        {
            Close();



        }
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaProveedores.DataSource;
            bs.Filter = "Nombre_del_proveedor like '%" + valor + "%'";
            grdBusquedaProveedores.DataSource = bs;
        }
      
    }

}
