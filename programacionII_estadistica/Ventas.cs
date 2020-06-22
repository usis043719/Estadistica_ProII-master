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
    public partial class Ventas : Form
    {
        private int _IdVenta = 0;
        public Ventas()
        {

            InitializeComponent();
        }

        private void ventaDiaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ventaDiaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaDataSet);

        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            
                actualziarDs();
            }
            private void actualziarDs()
            {
                try
                {
                    // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Factura' Puede moverla o quitarla según sea necesario.
                    this.facturaTableAdapter.Fill(this.sistemaDataSet.Factura);
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.sistemaDataSet.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.DataTable1' Puede moverla o quitarla según sea necesario.

            this.dataTable1TableAdapter.FillDetalleVentas(this.sistemaDataSet.DataTable1);
           
                // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.VentaDia' Puede moverla o quitarla según sea necesario.
                this.ventaDiaTableAdapter.Fill(this.sistemaDataSet.VentaDia);
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
            nfilas = dataTable1DataGridView.RowCount;
            DataGridViewRow fila = new DataGridViewRow();
            for (int i = 0; i < nfilas; i++)
            {
                fila = dataTable1DataGridView.Rows[i];
                Unidades = double.Parse(fila.Cells["Unidades"].Value.ToString());
                Descuento = int.Parse(fila.Cells["Descuento"].Value.ToString());
                PrecioUnitario = double.Parse(fila.Cells["PrecioUnitario"].Value.ToString());

                suma += Unidades * PrecioUnitario * (1 - Descuento / 100);
            }
            iva = int.Parse(idClienteComboBox.SelectedValue.ToString()) == 2 ? suma * 13 / 100 : 0;
            total = suma + iva;
            lblSumaVenta.Text = "$" + Math.Round(suma, 2);
            lblIvaVenta.Text = "$" + Math.Round(iva, 2);
            lblTotalVenta.Text = "$" + Math.Round(total, 2);

            lblregistroxden.Text = ventaDiaBindingSource.Position + 1 + " de " + ventaDiaBindingSource.Count;


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

        private void idClienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (btnagregar.Text == "Nuevo")
            {//nuevo
                btnagregar.Text = "Guardar";
                btnmodificar.Text = "Cancelar";

                habdes_controles(false);//habilitar los controles...
                ventaDiaBindingSource.AddNew();//agregamos un registro nuevo...
            }
            else
            {//guardar
                _IdVenta = int.Parse(idClienteComboBox.Text);
                this.Validate();
                this.ventaDiaBindingSource.EndEdit();

                /**
                 * Abrimos la conexion a la BD
                 */
                ventaDiaTableAdapter.Connection.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = ventaDiaTableAdapter.Connection;

                if (_IdVenta > 0)
                {//modificando...
                    sqlCmd.CommandText = "delete from DetalleDeVenta where IdVenta=" + _IdVenta;
                    sqlCmd.ExecuteNonQuery();
                }
                else
                {//nuevo....
                    sqlCmd.CommandText = "select ident_current('VentaDia') + 1 AS IdVenta";
                    _IdVenta = int.Parse(sqlCmd.ExecuteScalar().ToString());

                }
                int nfilas = dataTable1DataGridView.RowCount;
                string[,] DetalleDeVenta = new string[nfilas, 5];
                DataGridViewRow fila = new DataGridViewRow();
                for (int i = 0; i < nfilas; i++)
                {
                    fila = dataTable1DataGridView.Rows[i];

                    DetalleDeVenta[i, 0] = fila.Cells["IdProductos"].Value.ToString();
                    DetalleDeVenta[i, 1] = fila.Cells["Unidades"].Value.ToString();
                    DetalleDeVenta[i, 2] = fila.Cells["PrecioUnitario"].Value.ToString();
                    DetalleDeVenta[i, 3] = fila.Cells["Precio_total"].Value.ToString();
                    DetalleDeVenta[i, 4] = fila.Cells["Descuento"].Value.ToString();
                    DetalleDeVenta[i, 5] = fila.Cells["Descripcion"].Value.ToString();
                    DetalleDeVenta[i, 5] = fila.Cells["Fecha_de_compra"].Value.ToString();
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
                ventaDiaTableAdapter.Connection.Close();
                actualziarDs();
                ventaDiaBindingSource.MoveLast();

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
                ventaDiaBindingSource.CancelEdit();
                dataTable1BindingSource.CancelEdit();

                habdes_controles(true);//deshabilitar los controles...
                btnagregar.Text = "Nuevo";
                btnmodificar.Text = "Modificar";
            }
        }
        private void habdes_controles(Boolean estado)
        {
            idClienteComboBox.Enabled = !estado;
            fechaDateTimePicker.Enabled = !estado;
            idEmpleado_ComboBox.Enabled = !estado;
            nfacturaComboBox.Enabled = !estado;

            idDetalleTextBox.ReadOnly = estado;
            dataTable1DataGridView.ReadOnly = estado;
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
                dataTable1BindingSource.AddNew();

                dataTable1DataGridView.CurrentRow.Cells["IdProductos"].Value = frmBusquedaproducto._IdProductos;
                dataTable1DataGridView.CurrentRow.Cells["Marca"].Value = frmBusquedaproducto._MarcaProductos;
                dataTable1DataGridView.CurrentRow.Cells["Descripcion"].Value = frmBusquedaproducto._DescripcionProductos;
                dataTable1DataGridView.CurrentRow.Cells["Unidades"].Value = 1;



            }
        }

        private void btnQuitarProductosGrid_Click(object sender, EventArgs e)
        {
            {
                if (dataTable1DataGridView.RowCount > 0)
                {
                    dataTable1DataGridView.Rows.Remove(dataTable1DataGridView.CurrentRow);
                }
            }
        }

        private void dataTable1DataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
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

        private void btnimprimir_Click(object sender, EventArgs e)
        {
    }
    }
}
        
        
    
    
    



