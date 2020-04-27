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
    public partial class Busquedacategoria : Form
    {
        conexion objConexion = new conexion();
        public int _IdCategoria;
        public Busquedacategoria()
        {
            InitializeComponent();
        }

        private void Busquedacategoria_Load(object sender, EventArgs e)
        {
            grdbusquedacategoria.DataSource =
              objConexion.obtener_datos().Tables["Categoria"].DefaultView;
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbusqueda.Text);

        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdbusquedacategoria.RowCount > 0)
            {
                _IdCategoria = int.Parse(grdbusquedacategoria.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "BusquedaCategoria",
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
            bs.DataSource = grdbusquedacategoria.DataSource;
            bs.Filter = "Categoria like '%" + valor + "%'";
            grdbusquedacategoria.DataSource = bs;
        }
    }
    }

