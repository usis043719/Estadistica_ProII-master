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
    public partial class Busquedacliente : Form
    {
        conexion objConexion = new conexion();
        public int _IdCliente;
        public Busquedacliente()
        {
            InitializeComponent();
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaClientes.RowCount > 0)
            {
                _IdCliente = int.Parse(grdBusquedaClientes.CurrentRow.Cells[0].Value.ToString());
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
            bs.DataSource = grdBusquedaClientes.DataSource;
            bs.Filter = "Nombre_cliente like '%" + valor + "%'";
            bs.Filter = "Direccion like '%" + valor + "%'";
            bs.Filter = "Telefono like '%" + valor + "%'";
            grdBusquedaClientes.DataSource = bs;

        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbusqueda.Text);
        }

        private void Busquedacliente_Load(object sender, EventArgs e)
        {

            grdBusquedaClientes.DataSource =
               objConexion.obtener_datos().Tables["clientes"].DefaultView;
        }
    }
}
