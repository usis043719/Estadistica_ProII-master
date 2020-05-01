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
    public partial class BusquedaPeliculas : Form
    {
        conexion objConexion = new conexion();
        public int _IdPelicula;
        public BusquedaPeliculas()
        {
            InitializeComponent();
        }

        private void BusquedaPeliculas_Load(object sender, EventArgs e)
        {
            grdBusquedaPeliculas.DataSource =
               objConexion.obtener_datos().Tables["peliculas"].DefaultView;
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbusqueda.Text);
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaPeliculas.RowCount > 0)
            {
                _IdPelicula = int.Parse(grdBusquedaPeliculas.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busquedapelicula",
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
            bs.DataSource = grdBusquedaPeliculas.DataSource;
            bs.Filter = "descripcion like '%" + valor + "%' or sinopsis like '%" + valor + "%' or genero like '%" + valor + "%'";

            grdBusquedaPeliculas.DataSource = bs;
        }
    }
}

        

