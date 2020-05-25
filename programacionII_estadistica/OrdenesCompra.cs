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

        private void ordenesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordenesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaDataSet);

        }

        private void OrdenesCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.DetalleOrdenes' Puede moverla o quitarla según sea necesario.
            this.detalleOrdenesTableAdapter.Fill(this.sistemaDataSet.DetalleOrdenes);
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.DataTable3' Puede moverla o quitarla según sea necesario.
            this.ordenesTableAdapter.Fill(this.sistemaDataSet.Ordenes);

            this.dataTable2TableAdapter.FillOrdenesDetalles(this.sistemaDataSet.DataTable2);

            //this.detalleOrdenesTableAdapter.FillDetalleOrdenes(this.sistemaDataSet.DetalleOrdenes);
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Ordenes' Puede moverla o quitarla según sea necesario.
                this.ordenesTableAdapter.Fill(this.sistemaDataSet.Ordenes);
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
            nfilas = dataTable2DataGridView.RowCount;
            DataGridViewRow fila = new DataGridViewRow();
            for (int i = 0; i < nfilas; i++)
            {
                fila = dataTable2DataGridView.Rows[i];
                Unidades = double.Parse(fila.Cells["Unidades"].Value.ToString());
                Descuento = int.Parse(fila.Cells["Descuento"].Value.ToString());
                PrecioUnitario = double.Parse(fila.Cells["PrecioUnitario"].Value.ToString());

                suma += Unidades * PrecioUnitario * (1 - Descuento / 100);
            }
            iva = int.Parse(idOrdenComboBox.SelectedValue.ToString()) == 1 ? suma * 13 / 100 : 0;
            total = suma + iva;
            lblSumaVenta.Text = "$" + Math.Round(suma, 1);
            lblIvaVenta.Text = "$" + Math.Round(iva, 1);
            lblTotalVenta.Text = "$" + Math.Round(total, 1);

            lblregistroxden.Text = ordenesBindingSource.Position + 1 + " de " + ordenesBindingSource.Count;

    }

        private void btnprimero_Click(object sender, EventArgs e)
        {
            ordenesBindingSource.MoveFirst();
            totalizar();

        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            ordenesBindingSource.MovePrevious();
            totalizar();

        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            ordenesBindingSource.MoveNext();
            totalizar();

        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            ordenesBindingSource.MoveLast();
            totalizar();

        }
    }
}
