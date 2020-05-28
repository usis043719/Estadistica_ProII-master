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
    public partial class Devoluciones : Form
    {
        public Devoluciones()
        {
            InitializeComponent();
        }

        private void devolucionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.devolucionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaDataSet);

        }

        private void Devoluciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.DataTable4' Puede moverla o quitarla según sea necesario.
            this.dataTable4TableAdapter.FillDetalleDevolucion(this.sistemaDataSet.DataTable4);
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Devoluciones' Puede moverla o quitarla según sea necesario.
                this.devolucionesTableAdapter.Fill(this.sistemaDataSet.Devoluciones);
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
            nfilas = dataTable4DataGridView.RowCount;
            DataGridViewRow fila = new DataGridViewRow();
            for (int i = 0; i < nfilas; i++)
            {
                fila = dataTable4DataGridView.Rows[i];
                Unidades = double.Parse(fila.Cells["Unidades"].Value.ToString());
                Descuento = int.Parse(fila.Cells["Descuento"].Value.ToString());
                PrecioUnitario = double.Parse(fila.Cells["PrecioUnitario"].Value.ToString());

                suma += Unidades * PrecioUnitario * (1 - Descuento / 100);
            }
            iva = int.Parse(idDcProductosComboBox.SelectedValue.ToString()) == 1 ? suma * 13 / 100 : 0;
            total = suma + iva;
            lblSumaVenta.Text = "$" + Math.Round(suma, 1);
            lblIvaVenta.Text = "$" + Math.Round(iva, 1);
            lblTotalVenta.Text = "$" + Math.Round(total, 1);

            lblregistroxden.Text = devolucionesBindingSource.Position + 1 + " de " + devolucionesBindingSource.Count;


        }

        private void btnprimero_Click(object sender, EventArgs e)
        {
            devolucionesBindingSource.MoveFirst();
            totalizar();
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            devolucionesBindingSource.MovePrevious();
            totalizar();
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            devolucionesBindingSource.MoveNext();
            totalizar();

        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            devolucionesBindingSource.MoveLast();
            totalizar();
        }
    }
}
