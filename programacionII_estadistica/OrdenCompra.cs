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
    public partial class OrdenCompra : Form
    {
        public OrdenCompra()
        {
            InitializeComponent();
        }

        private void InventarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaDataSet);

        }

        private void InventarioBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.inventarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaDataSet);

        }

        private void OrdenesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordenesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaDataSet);

        }

        private void OrdenCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.sistemaDataSet.Inventario);
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.sistemaDataSet.Proveedor);
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.sistemaDataSet.Productos);
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Ordenes' Puede moverla o quitarla según sea necesario.
            this.ordenesTableAdapter.Fill(this.sistemaDataSet.Ordenes);

        }

        private void IdOrdenLabel_Click(object sender, EventArgs e)
        {

        }

        private void IdOrdenTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnprimero_Click(object sender, EventArgs e)
        {
            
        }

        private void Btnultimo_Click(object sender, EventArgs e)
        {

        }

        private void Btnsiguiente_Click(object sender, EventArgs e)
        {

        }

        private void Lblnregistros_Click(object sender, EventArgs e)
        {

        }

        private void Btnanterior_Click(object sender, EventArgs e)
        {

        }
    }
}
