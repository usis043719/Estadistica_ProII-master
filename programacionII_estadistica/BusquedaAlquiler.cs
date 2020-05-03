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
             objConexion.obtener_datos().Tables["alquiler_clientes"].DefaultView;

            grdBusquedaAlquiler.DataSource =
            objConexion.obtener_datos().Tables["alquiler_peliculas"].DefaultView;




        }///desple

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbusqueda.Text);

        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaAlquiler.RowCount > 0)
            {
                _IdAlquiler = int.Parse(grdBusquedaAlquiler.CurrentRow.Cells["IdAlquiler"].Value.ToString());

                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de alquiler",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
    }
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaAlquiler.DataSource;
            bs.Filter = " FechaPrestamo like '%" + valor + "%'" + valor + "%' or FechaDevolucion like '%" + valor + "%' or descripcion like '%" + valor + "%'" + valor + "%' or nombre like '%";
            //prueba



        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();

       
       
        }
    }
}
