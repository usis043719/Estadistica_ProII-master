using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace programacionII_estadistica
{
    public partial class OrdenesCompra : Form
    {
        private int _IdOrden = 0;

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

            actualziarDs();
        }
        private void actualziarDs()
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.DetalleOrdenes' Puede moverla o quitarla según sea necesario.
                this.detalleOrdenesTableAdapter.Fill(this.sistemaDataSet.DetalleOrdenes);
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.DataTable3' Puede moverla o quitarla según sea necesario.
            this.ordenesTableAdapter.Fill(this.sistemaDataSet.Ordenes);

            this.dataTable2TableAdapter.FillOrdenesDetalles(this.sistemaDataSet.DataTable2);

            //this.detalleOrdenesTableAdapter.FillDetalleOrdenes(this.sistemaDataSet.DetalleOrdenes);
           
                // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Ordenes' Puede moverla o quitarla según sea necesario.
                this.ordenesTableAdapter.Fill(this.sistemaDataSet.Ordenes);
                totalizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (btnagregar.Text == "Nuevo")
            {//nuevo
                btnagregar.Text = "Guardar";
                btnmodificar.Text = "Cancelar";

                habdes_controles(false);//habilitar los controles...
                ordenesBindingSource.AddNew();//agregamos un registro nuevo...
            }
            else
            {//guardar
                _IdOrden = int.Parse(idOrdenComboBox.Text);
                this.Validate();
                this.ordenesBindingSource.EndEdit();

                /**
                 * Abrimos la conexion a la BD
                 */
                ordenesTableAdapter.Connection.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = ordenesTableAdapter.Connection;

                if (_IdOrden > 0)
                {//modificando...
                    sqlCmd.CommandText = "delete from DetalleOrdenes where IdOrden=" + _IdOrden;
                    sqlCmd.ExecuteNonQuery();
                }
                else
                {//nuevo....
                    sqlCmd.CommandText = "select ident_current('Ordenes') + 1 AS IdOrden";
                    _IdOrden = int.Parse(sqlCmd.ExecuteScalar().ToString());

                }
                int nfilas = dataTable2DataGridView.RowCount;
                string[,] DetalleDeVenta = new string[nfilas, 4];
                DataGridViewRow fila = new DataGridViewRow();
                for (int i = 0; i < nfilas; i++)
                {
                    fila = dataTable2DataGridView.Rows[i];

                    DetalleDeVenta[i, 0] = fila.Cells["IdProductos"].Value.ToString();
                    DetalleDeVenta[i, 1] = fila.Cells["Unidades"].Value.ToString();
                    DetalleDeVenta[i, 2] = fila.Cells["PrecioUnitario"].Value.ToString();
                    DetalleDeVenta[i, 3] = fila.Cells["Descuento"].Value.ToString();
                
                }
                this.tableAdapterManager.UpdateAll(this.sistemaDataSet);
                // for (int i = 0; i < nfilas; i++)
                // {
                // ventaDiaTableAdapter.Insert(
                // _IdVenta,
                // int.Parse(DetalleDeVenta[i, 0]),
                // int.Parse(DetalleDeVenta[i, 1]),
                // char.Parse(DetalleDeVenta[i, 2]),
                // char.Parse(DetalleDeVenta[i, 3]),
               
                // );
                //}
                //ventaDiaTableAdapter.Connection.Close();
                // actualziarDs();
                // ventaDiaBindingSource.MoveLast();


                //habdes_controles(true);
                // btnagregar.Text = "Nuevo";
                // btnmodificar.Text = "Modificar";

            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (btnmodificar.Text == "Modificar")
            {//modificar
                btnagregar.Text = "Guardar";
                btnmodificar.Text = "Cancelar";

                habdes_controles(false);//habilitar los controles...

            }
            else
            {//cancelar
                ordenesBindingSource.CancelEdit();
                dataTable2BindingSource.CancelEdit();

                habdes_controles(true);//deshabilitar los controles...
                btnagregar.Text = "Nuevo";
                btnmodificar.Text = "Modificar";
            }
        }
        private void habdes_controles(Boolean estado)
        {
            nombreProveedorComboBox.Enabled = !estado;
            fechaCompraDateTimePicker.Enabled = !estado;
            idOrdenComboBox.Enabled = !estado;
            empresaComboBox.Enabled = !estado;

            idProveedorTextBox.ReadOnly = estado;
            dataTable2DataGridView.ReadOnly = estado;
            pnlProductosGrid.Visible = !estado;

            grbnavegacion.Visible = estado;
            btneliminar.Enabled = estado;
            btnbuscar.Enabled = estado;
        }


        private void btnAgregarProductosGrid_Click(object sender, EventArgs e)
        {
            Busquedaproductos frmBusquedaproducto = new Busquedaproductos();
            frmBusquedaproducto.ShowDialog();
            if (frmBusquedaproducto._IdProductos > 0)
            {
                dataTable2BindingSource.AddNew();

                dataTable2DataGridView.CurrentRow.Cells["idProductos"].Value = frmBusquedaproducto._IdProductos;
                dataTable2DataGridView.CurrentRow.Cells["Marca"].Value = frmBusquedaproducto._MarcaProductos;
                dataTable2DataGridView.CurrentRow.Cells["Descripcion"].Value = frmBusquedaproducto._DescripcionProductos;
                dataTable2DataGridView.CurrentRow.Cells["Unidades"].Value = 1;



            }
        }

        private void btnQuitarProductosGrid_Click(object sender, EventArgs e)
        {
            {
                if (dataTable2DataGridView.RowCount > 0)
                {
                    dataTable2DataGridView.Rows.Remove(dataTable2DataGridView.CurrentRow);
                }
            }
        }

        private void dataTable2DataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //totalizar();
            }
            catch (Exception)
            {
                //
            }
        }
    }
}
      