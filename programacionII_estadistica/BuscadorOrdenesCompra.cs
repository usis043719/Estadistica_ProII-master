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
    public partial class BuscadorOrdenesCompra : Form
    {
        conexion objconexion = new conexion();
        public int _IdOrden;
        public BuscadorOrdenesCompra()
        {
            InitializeComponent();
        }

        private void BuscadorOrdenesCompra_Load(object sender, EventArgs e)
        {
            grdBusquedaOrdencompra.DataSource =
              objconexion.obtener_datos().Tables["Ordenes"].DefaultView;
        }

        private void txtbusquedaordencompra_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbusquedaordencompra.Text);
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaOrdencompra.RowCount > 0)
            {
                _IdOrden = int.Parse(grdBusquedaOrdencompra.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Ordenes",
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
            bs.DataSource = grdBusquedaOrdencompra.DataSource;
            bs.Filter = "descripcion like '%" + valor + "%'";
            grdBusquedaOrdencompra.DataSource = bs;
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbusquedaordencompra.Text);
        }
        private void Busquedaproductos_Load(object sender, EventArgs e)
        {
            grdBusquedaOrdencompra.DataSource =
              objconexion.obtener_datos().Tables["Ordenes"].DefaultView;
        }
    }
    }
