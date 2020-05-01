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
    public partial class BusquedaAlquiler : Form
    {
        conexion objConexion = new conexion();
        public int _IdAlquiler;
        public BusquedaAlquiler()
        {
            InitializeComponent();
        }

        private void BusquedaAlquiler_Load(object sender, EventArgs e)
        {
            grdBusquedaAlquiler.DataSource =
             objConexion.obtener_datos().Tables["alquiler"].DefaultView;
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbusqueda.Text);

        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaAlquiler.RowCount > 0)
            {
                _IdAlquiler = int.Parse(grdBusquedaAlquiler.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busquedaalquiler",
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
            bs.DataSource = grdBusquedaAlquiler.DataSource;
            bs.Filter = "valor like '%" + valor + "%' or FechaPrestamo like '%" + valor + "%' or FechaDevolucion like '%" + valor + "%'";
            grdBusquedaAlquiler.DataSource = bs;
        }
    }
}
