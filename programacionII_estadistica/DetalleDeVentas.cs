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
    public partial class DetalleDeVentas : Form
    {
        public DetalleDeVentas()
        {
            InitializeComponent();
        }

        private void ventaDiaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ventaDiaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaDataSet);

        }

        private void DetalleDeVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Factura' Puede moverla o quitarla según sea necesario.
            this.facturaTableAdapter.Fill(this.sistemaDataSet.Factura);
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.sistemaDataSet.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Detalle' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.DetalleDeVenta' Puede moverla o quitarla según sea necesario.
            this.detalleDeVentaTableAdapter.Fill(this.sistemaDataSet.DetalleDeVenta);
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Detalle' Puede moverla o quitarla según sea necesario.            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.VentaDia' Puede moverla o quitarla según sea necesario.
            this.ventaDiaTableAdapter.Fill(this.sistemaDataSet.VentaDia);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnprimero_Click(object sender, EventArgs e)
        {
            ventaDiaBindingSource.MovePrevious();
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            ventaDiaBindingSource.MoveFirst();
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            ventaDiaBindingSource.MoveLast();
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            ventaDiaBindingSource.MoveNext();
        }

        private void Lblnregistros_Click(object sender, EventArgs e)
        {

        }
    }
}
