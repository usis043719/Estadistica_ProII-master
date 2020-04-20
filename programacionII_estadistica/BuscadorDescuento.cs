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
    public partial class BuscadorDescuento : Form
    {
        conexion objConexion = new conexion();
        public int _IdDcProductos;
        public BuscadorDescuento()
        {
            InitializeComponent();
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbusqueda.Text);

        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaDescuento.RowCount > 0)
            {
                _IdDcProductos = int.Parse(grdBusquedaDescuento.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busquedacliente",
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
            bs.DataSource = grdBusquedaDescuento.DataSource;
            bs.Filter = "Descripcion like '%" + valor + "%'";
            grdBusquedaDescuento.DataSource = bs;

        }

        private void BuscadorDescuento_Load(object sender, EventArgs e)
        {
            grdBusquedaDescuento.DataSource =
             objConexion.obtener_datos().Tables["descuento"].DefaultView;
        }
    
    }
}
