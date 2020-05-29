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

       

        private void button3_Click(object sender, EventArgs e)
        {
            Categoria Categoria = new Categoria();

            Categoria.Show();
        }

        private void btncargo_Click(object sender, EventArgs e)
        {
            Cargo Cargo = new Cargo();

            Cargo.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ventas Ventas = new Ventas();

            Ventas.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OrdenesCompra OrdenesCompra = new OrdenesCompra();

            OrdenesCompra.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Facturas Facturas = new Facturas();

            Facturas.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Devoluciones Devoluciones = new Devoluciones();

            Devoluciones.Show();
        }
    }
}
//hola mundo.%
//base.