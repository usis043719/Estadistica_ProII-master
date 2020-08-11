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
    public partial class Facturas : Form
    {
        private int _nfactura = 0;

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
            

                actualziarDs();
            }
            private void actualziarDs()
            {
                try
                {
                    // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Ordenes' Puede moverla o quitarla según sea necesario.
                    this.facturaTableAdapter.Fill(this.sistemaDataSet.Factura);

            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.DataTable3' Puede moverla o quitarla según sea necesario.
            this.dataTable3TableAdapter.FillDetalleFactura(this.sistemaDataSet.DataTable3);
            
                // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Factura' Puede moverla o quitarla según sea necesario.
                this.facturaTableAdapter.Fill(this.sistemaDataSet.Factura);
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

        private void dataTable3DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (btnagregar.Text == "Nuevo")
            {//nuevo
                btnagregar.Text = "Guardar";
                btnmodificar.Text = "Cancelar";

                habdes_controles(false);//habilitar los controles...
                facturaBindingSource.AddNew();//agregamos un registro nuevo...
            }
            else
            {//guardar
                _nfactura = int.Parse(idClienteComboBox.Text);
                this.Validate();
                this.facturaBindingSource.EndEdit();

                /**
                 * Abrimos la conexion a la BD
                 */
                facturaTableAdapter.Connection.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = facturaTableAdapter.Connection;

                if (_nfactura > 0)
                {//modificando...
                    sqlCmd.CommandText = "delete from DetalleDeFactura where nfactura=" + _nfactura;
                    sqlCmd.ExecuteNonQuery();
                }
                else
                {//nuevo....
                    sqlCmd.CommandText = "select ident_current('Factura') + 1 AS nfactura";
                    _nfactura = int.Parse(sqlCmd.ExecuteScalar().ToString());

                }
                int nfilas = dataTable3DataGridView.RowCount;
                string[,] DetalleDeVenta = new string[nfilas, 6];
                DataGridViewRow fila = new DataGridViewRow();
                for (int i = 0; i < nfilas; i++)
                {
                    fila = dataTable3DataGridView.Rows[i];

                    DetalleDeVenta[i, 0] = fila.Cells["IdProductos"].Value.ToString();
                    DetalleDeVenta[i, 1] = fila.Cells["Unidades"].Value.ToString();
                    DetalleDeVenta[i, 2] = fila.Cells["PrecioUnitario"].Value.ToString();
                    DetalleDeVenta[i, 3] = fila.Cells["Precio_total"].Value.ToString();
                    DetalleDeVenta[i, 4] = fila.Cells["Descuento"].Value.ToString();
                    DetalleDeVenta[i, 5] = fila.Cells["Marca"].Value.ToString();
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
                // int.Parse(DetalleDeVenta[i, 4])
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
                facturaBindingSource.CancelEdit();
                dataTable3BindingSource.CancelEdit();

                habdes_controles(true);//deshabilitar los controles...
                btnagregar.Text = "Nuevo";
                btnmodificar.Text = "Modificar";
            }
        }
        private void habdes_controles(Boolean estado)
        {
            nombre_del_clienteComboBox.Enabled = !estado;
            fecha_de_ventaDateTimePicker.Enabled = !estado;
            idClienteComboBox.Enabled = !estado;
            nfacturaComboBox.Enabled = !estado;

            idProductosDvTextBox.ReadOnly = estado;
            dataTable3DataGridView.ReadOnly = estado;
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
                dataTable3BindingSource.AddNew();

                dataTable3DataGridView.CurrentRow.Cells["IdProductos"].Value = frmBusquedaproducto._IdProductos;
                dataTable3DataGridView.CurrentRow.Cells["Marca"].Value = frmBusquedaproducto._MarcaProductos;
                dataTable3DataGridView.CurrentRow.Cells["Descripcion"].Value = frmBusquedaproducto._DescripcionProductos;
                dataTable3DataGridView.CurrentRow.Cells["Unidades"].Value = 1;



            }
        }

        private void btnQuitarProductosGrid_Click(object sender, EventArgs e)
        {
            {
                if (dataTable3DataGridView.RowCount > 0)
                {
                    dataTable3DataGridView.Rows.Remove(dataTable3DataGridView.CurrentRow);
                }
            }
        }

        private void dataTable3DataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
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

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Busquedaproductos frmBusquedaproducto = new Busquedaproductos();
            frmBusquedaproducto.ShowDialog();
            if (frmBusquedaproducto._IdProductos > 0)
            {
                dataTable3BindingSource.AddNew();

                dataTable3DataGridView.CurrentRow.Cells["IdProductos"].Value = frmBusquedaproducto._IdProductos;
                dataTable3DataGridView.CurrentRow.Cells["Marca"].Value = frmBusquedaproducto._MarcaProductos;
                dataTable3DataGridView.CurrentRow.Cells["Descripcion"].Value = frmBusquedaproducto._DescripcionProductos;
                dataTable3DataGridView.CurrentRow.Cells["Unidades"].Value = 1;

            }
        }
    }
}
