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

            try
            {
                // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Detalle' Puede moverla o quitarla según sea necesario.            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.VentaDia' Puede moverla o quitarla según sea necesario.
                this.ventaDiaTableAdapter.Fill(this.sistemaDataSet.VentaDia);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            totalizar();
        }

        private void totalizar()
        {
            int Descuento = 0, nfilas = 0;
            double Unidades = 0, Precio_total = 0, suma = 0, iva = 0, total = 0;
            nfilas = detalleDeVentaDataGridView1.RowCount;
            DataGridViewRow fila = new DataGridViewRow();
            for (int i = 0; i < nfilas; i++)
            {
                fila = detalleDeVentaDataGridView1.Rows[i];
                Unidades = double.Parse(fila.Cells["Unidades"].Value.ToString());
                Descuento= int.Parse(fila.Cells["Descuento"].Value.ToString());
                Precio_total = double.Parse(fila.Cells["Precio_total"].Value.ToString());

                suma += Unidades * Precio_total * (1 - Descuento / 100);
            }
            iva = int.Parse(idClienteComboBox.SelectedValue.ToString()) == 2 ? suma * 13 / 100 : 0;
            total = suma + iva;
            lblSumaVenta.Text = "$" + Math.Round(suma, 2);
            lblIvaVenta.Text = "$" + Math.Round(iva, 2);
            lblTotalVenta.Text = "$" + Math.Round(total, 2);

            lblregistroxden.Text = ventaDiaBindingSource.Position + 1 + " de " + ventaDiaBindingSource.Count;
        
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnprimero_Click(object sender, EventArgs e)
        {
            ventaDiaBindingSource.MoveFirst();
            totalizar();

        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            ventaDiaBindingSource.MovePrevious();
            totalizar();

        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            ventaDiaBindingSource.MoveNext();
            totalizar();

        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            ventaDiaBindingSource.MoveLast();
            totalizar();

        }

        private void Lblnregistros_Click(object sender, EventArgs e)
        {

        }
    }
}
