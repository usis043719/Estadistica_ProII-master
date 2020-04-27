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
    public partial class Busquedaempleado : Form
    {
        conexion objConexion = new conexion();
        public int _IdEmpleado;
        public Busquedaempleado()
        {
            InitializeComponent();
        }
        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaEmpleados.RowCount > 0)
            {
                _IdEmpleado = int.Parse(grdBusquedaEmpleados.CurrentRow.Cells["IdEmpleado"].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Empleados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
            void filtrar_datos(String valor)
        {
                BindingSource bs = new BindingSource();
                bs.DataSource = grdBusquedaEmpleados.DataSource;
            bs.Filter = "Nombre_empleado like '%" + valor + "%' or Telefono like '%" + valor + "%' or Direccion like '%" + valor +
                 "%' or Cargo like '%" + valor + "%'";


            grdBusquedaEmpleados.DataSource = bs;
            }
        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbusqueda.Text);
        }

        private void Busquedaempleado_Load(object sender, EventArgs e)
        {
            grdBusquedaEmpleados.DataSource =
             objConexion.obtener_datos().Tables["Empleados_Cargo"].DefaultView;
        }

        private void btncancelarempleado_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
