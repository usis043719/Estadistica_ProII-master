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

    public partial class Devoluciones : Form
    {
        private int _IdProductosDv = 0;

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

            actualziarDs();
        }
        private void actualziarDs()
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.DataTable4' Puede moverla o quitarla según sea necesario.
                this.dataTable4TableAdapter.FillDetalleDevolucion(this.sistemaDataSet.DataTable4);
          
                // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Devoluciones' Puede moverla o quitarla según sea necesario.
                this.devolucionesTableAdapter.Fill(this.sistemaDataSet.Devoluciones);
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

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (btnagregar.Text == "Nuevo")
            {//nuevo
                btnagregar.Text = "Guardar";
                btnmodificar.Text = "Cancelar";

                habdes_controles(false);//habilitar los controles...
                devolucionesBindingSource.AddNew();//agregamos un registro nuevo...
            }
            else
            {//guardar
                _IdProductosDv = int.Parse(idDcProductosComboBox.Text);
                this.Validate();
                this.devolucionesBindingSource.EndEdit();

                /**
                 * Abrimos la conexion a la BD
                 */
                devolucionesTableAdapter.Connection.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = devolucionesTableAdapter.Connection;

                if (_IdProductosDv > 0)
                {//modificando...
                    sqlCmd.CommandText = "delete from DetalleDeDevoluciones where IdProductosDv=" + _IdProductosDv;
                    sqlCmd.ExecuteNonQuery();
                }
                else
                {//nuevo....
                    sqlCmd.CommandText = "select ident_current('Devoluciones') + 1 AS IdProductosDv";
                    _IdProductosDv = int.Parse(sqlCmd.ExecuteScalar().ToString());

                }
                int nfilas = dataTable4DataGridView.RowCount;
                string[,] DetalleDeVenta = new string[nfilas, 5];
                DataGridViewRow fila = new DataGridViewRow();
                for (int i = 0; i < nfilas; i++)
                {
                    fila = dataTable4DataGridView.Rows[i];

                    DetalleDeVenta[i, 0] = fila.Cells["IdProductos"].Value.ToString();
                    DetalleDeVenta[i, 1] = fila.Cells["Unidades"].Value.ToString();
                    DetalleDeVenta[i, 2] = fila.Cells["PrecioUnitario"].Value.ToString();
                    DetalleDeVenta[i, 3] = fila.Cells["Precio_total"].Value.ToString();
                    DetalleDeVenta[i, 4] = fila.Cells["Descuento"].Value.ToString();
                 
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
                devolucionesBindingSource.CancelEdit();
                dataTable4BindingSource.CancelEdit();

                habdes_controles(true);//deshabilitar los controles...
                btnagregar.Text = "Nuevo";
                btnmodificar.Text = "Modificar";
            }
        }
        private void habdes_controles(Boolean estado)
        {
            nombre_ClienteComboBox.Enabled = !estado;
            fecha_DevolucionDateTimePicker.Enabled = !estado;
            idProductosDvComboBox.Enabled = !estado;
            idDcProductosComboBox.Enabled = !estado;

            idOrdenTextBox.ReadOnly = estado;
            dataTable4DataGridView.ReadOnly = estado;
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
                dataTable4BindingSource.AddNew();

                dataTable4DataGridView.CurrentRow.Cells["IdProductos"].Value = frmBusquedaproducto._IdProductos;
                dataTable4DataGridView.CurrentRow.Cells["Marca"].Value = frmBusquedaproducto._MarcaProductos;
                dataTable4DataGridView.CurrentRow.Cells["Descripcion"].Value = frmBusquedaproducto._DescripcionProductos;
                dataTable4DataGridView.CurrentRow.Cells["Unidades"].Value = 1;



            }
        }

        private void btnQuitarProductosGrid_Click(object sender, EventArgs e)
        {
            {
                if (dataTable4DataGridView.RowCount > 0)
                {
                    dataTable4DataGridView.Rows.Remove(dataTable4DataGridView.CurrentRow);
                }
            }
        }

        private void dataTable4DataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
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
        
  