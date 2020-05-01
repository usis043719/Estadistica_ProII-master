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
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            clientes clientes = new clientes();

            clientes.Show();
        }

        private void btnpelis_Click(object sender, EventArgs e)
        {
            Peliculas Peliculas = new Peliculas();

            Peliculas.Show();
        }

        private void btnalquiler_Click(object sender, EventArgs e)
        {
            Alquiler Alquiler = new Alquiler();

            Alquiler.Show();
        }
    }
}
