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
    public partial class BusquedaInventario : Form
    {
        conexion objConexion = new conexion();
        public int _IdInventario;
        public BusquedaInventario()
        {
            InitializeComponent();
        }

        private void BusquedaInventario_Load(object sender, EventArgs e)
        {
            grdBusquedaInventario.DataSource =
              objConexion.obtener_datos().Tables["Inventario"].DefaultView;
        }

        private void txtbusquedainventario_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbusquedainventario.Text);

        }

        private void btnseleccionarinventario_Click(object sender, EventArgs e)
        {
            if (grdBusquedaInventario.RowCount > 0)
            {
                _IdInventario = int.Parse(grdBusquedaInventario.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busquedainventario",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
    }

        private void btncancelarinventario_Click(object sender, EventArgs e)
        {
            Close();

        }
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaInventario.DataSource;
            bs.Filter = "Descripcion like '%" + valor + "%'";
            grdBusquedaInventario.DataSource = bs;
        }
    }
}
