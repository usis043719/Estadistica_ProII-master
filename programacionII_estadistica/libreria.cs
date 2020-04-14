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
    public partial class libreria : Form
    {
        public libreria()
        {
            InitializeComponent();
        }

        private void btnbusquedaclientes_Click(object sender, EventArgs e)
        {
            clientes clientes = new clientes();

            clientes.Show();
        }

        private void btnbusquedaempleados_Click(object sender, EventArgs e)
        {
            {
                Productos productos = new Productos();

                productos.Show();

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            {
                Empleado empleado = new Empleado();
           
                empleado.Show();
            }
        }
        private void libreria_Load(object sender, EventArgs e)
        {
    
        }
    }
}
//hola mundo.%
//base.