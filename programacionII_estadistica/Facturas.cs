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
    public partial class Facturas : Form
    {
        public Facturas()
        {
            InitializeComponent();
        }

        private void facturaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facturaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaDataSet);

        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Ordenes' Puede moverla o quitarla según sea necesario.
            this.facturaTableAdapter.Fill(this.sistemaDataSet.Factura);

            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.DataTable3' Puede moverla o quitarla según sea necesario.
            this.dataTable3TableAdapter.FillDetalleFactura(this.sistemaDataSet.DataTable3);
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Factura' Puede moverla o quitarla según sea necesario.
                this.facturaTableAdapter.Fill(this.sistemaDataSet.Factura);
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
            double Unidades = 0, PrecioUnitario = 0, suma = 0, iva = 0, total = 0;
            nfilas = dataTable3DataGridView.RowCount;
            DataGridViewRow fila = new DataGridViewRow();
            for (int i = 0; i < nfilas; i++)
            {
                fila = dataTable3DataGridView.Rows[i];
                Unidades = double.Parse(fila.Cells["Unidades"].Value.ToString());
                Descuento = int.Parse(fila.Cells["Descuento"].Value.ToString());
                PrecioUnitario = double.Parse(fila.Cells["PrecioUnitario"].Value.ToString());

                suma += Unidades * PrecioUnitario * (1 - Descuento / 100);
            }
            iva = int.Parse(nfacturaComboBox.SelectedValue.ToString()) == 2 ? suma * 13 / 100 : 0;
            total = suma + iva;
            lblSumaVenta.Text = "$" + Math.Round(suma, 2);
            lblIvaVenta.Text = "$" + Math.Round(iva, 2);
            lblTotalVenta.Text = "$" + Math.Round(total, 2);

            lblregistroxden.Text = facturaBindingSource.Position + 1 + " de " + facturaBindingSource.Count;



        

    }

        private void idProductosDvLabel_Click(object sender, EventArgs e)
        {

        }

        private void nfacturaLabel_Click(object sender, EventArgs e)
        {

        }

        private void idClienteLabel_Click(object sender, EventArgs e)
        {

        }

        private void idClienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nfacturaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void idProductosDvTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fecha_de_ventaLabel_Click(object sender, EventArgs e)
        {

        }

        private void fecha_de_ventaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void descripcionLabel_Click(object sender, EventArgs e)
        {

        }

        private void descripcionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombre_del_clienteLabel_Click(object sender, EventArgs e)
        {

        }

        private void nombre_del_clienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void unidadesLabel_Click(object sender, EventArgs e)
        {

        }

        private void unidadesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void precioUnitarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void precioUnitarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idDetalleFacturaLabel_Click(object sender, EventArgs e)
        {

        }

        private void idDetalleFacturaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnprimero_Click(object sender, EventArgs e)
        {
            facturaBindingSource.MoveFirst();
            totalizar();
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            facturaBindingSource.MovePrevious();
            totalizar();
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            facturaBindingSource.MoveNext();
            totalizar();
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            facturaBindingSource.MoveLast();
            totalizar();
        }
    }
}
