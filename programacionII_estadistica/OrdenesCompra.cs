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
    public partial class OrdenesCompra : Form
    {
        public OrdenesCompra()
        {
            InitializeComponent();
        }

        private void OrdenesCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.sistemaDataSet.Inventario);
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.sistemaDataSet.Proveedor);
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Descuento' Puede moverla o quitarla según sea necesario.
            this.descuentoTableAdapter.Fill(this.sistemaDataSet.Descuento);
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Ordenes' Puede moverla o quitarla según sea necesario.
            this.ordenesTableAdapter.Fill(this.sistemaDataSet.Ordenes);
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.DataTable2' Puede moverla o quitarla según sea necesario.
            this.dataTable2TableAdapter.FillOrdenesDetalles(this.sistemaDataSet.DataTable2);

        }

        private void btnprimero_Click(object sender, EventArgs e)
        {
            ordenesBindingSource.MoveFirst();

        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            ordenesBindingSource.MovePrevious();

        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            ordenesBindingSource.MoveNext();

        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            ordenesBindingSource.MoveLast();

        }
    }
}
