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

        private void button2_Click(object sender, EventArgs e)
        {
            {
                Proveedor Proveedor = new Proveedor();

                Proveedor.Show();
            }
        }

        private void btninventario_Click(object sender, EventArgs e)
        {
            Inventario Inventario = new Inventario();

            Inventario.Show();
        }

        private void btnoc_Click(object sender, EventArgs e)
        {
            OrdenesdeCompra OrdenesdeCompra = new OrdenesdeCompra();

            OrdenesdeCompra.Show();
        }

        private void btndesc_Click(object sender, EventArgs e)
        {
            Descuento Descuento = new Descuento();

            Descuento.Show();
        }
    }
}
//hola mundo.%
//base.