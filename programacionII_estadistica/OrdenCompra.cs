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

        private void ordenesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordenesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaDataSet);

        }

        private void OrdenCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.VentaDia' Puede moverla o quitarla según sea necesario.
            this.ventaDiaTableAdapter.Fill(this.sistemaDataSet.VentaDia);
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.sistemaDataSet.Proveedor);
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.sistemaDataSet.Inventario);
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.OrdenesDatos' Puede moverla o quitarla según sea necesario.
            this.ordenesDatosTableAdapter.FillOrdenes(this.sistemaDataSet.OrdenesDatos);
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Ordenes' Puede moverla o quitarla según sea necesario.
            this.ordenesTableAdapter.Fill(this.sistemaDataSet.Ordenes);

        }

        private void btnprimero_Click(object sender, EventArgs e)
        {
            ordenesBindingSource.MovePrevious();
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            ordenesBindingSource.MoveFirst();

        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            ordenesBindingSource.MoveLast();

        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            ordenesBindingSource.MoveNext();

        }
    }
}
