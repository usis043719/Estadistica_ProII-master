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
    public partial class Busquedaproductos : Form
    {
        conexion objConexion = new conexion();
        public int _IdProductos;
        public Busquedaproductos()
        {
            InitializeComponent();
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaProductos.RowCount > 0)
            {
                _IdProductos = int.Parse(grdBusquedaProductos.CurrentRow.Cells["IdProductos"].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Productos",
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
            bs.DataSource = grdBusquedaProductos.DataSource;
            bs.Filter = "Descripcion like '%" + valor + "%' or Marca like '%" + valor +
                 "%' or Categoria like '%" + valor + "%'";
            grdBusquedaProductos.DataSource = bs;
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbusqueda.Text);
        }
        private void Busquedaproductos_Load(object sender, EventArgs e)
        {
            grdBusquedaProductos.DataSource =
              objConexion.obtener_datos().Tables["Productos_Categoria"].DefaultView;
        }
    }
}
