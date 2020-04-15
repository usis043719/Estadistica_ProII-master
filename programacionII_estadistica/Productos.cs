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
    public partial class Productos : Form
    {
        conexion objconexion = new conexion();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();
        public Productos()
        {
            InitializeComponent();
        }
        private void btnagregarproducto_Click(object sender, EventArgs e)
        {
            if (btnagregarproducto.Text == "Nuevo")
            {//boton de nuevo
                btnagregarproducto.Text = "Guardar";
                btnmodificarproducto.Text = "Cancelar";
                accion = "nuevo";
                limpiar_cajas();
                controles(false);
            }
            else
            { //boton de guardar 
                String[] valores = {
                    txtidproducto.Text,
                    txtdescripcionproducto.Text,
                    txtiddescuento.Text
                };

                objconexion.mantenmiento_datos_Productos(valores, accion);
                actualizarDs();
                posicion = tbl.Rows.Count - 1;
                mostrarDatos();

                controles(true);

                btnagregarproducto.Text = "Nuevo";
                btnmodificarproducto.Text = "Modificar";
            }
        }

        private void btnmodificarproducto_Click(object sender, EventArgs e)
        {
            if (btnmodificarproducto.Text == "Modificar")
            {//boton de modificar
                btnagregarproducto.Text = "Guardar";
                btnmodificarproducto.Text = "Cancelar";
                accion = "modificar";

                controles(false);

                btnagregarproducto.Text = "Guardar";
                btnmodificarproducto.Text = "Cancelar";

            }
            else
            { //boton de cancelar
                controles(true);
                mostrarDatos();

                btnagregarproducto.Text = "Nuevo";
                btnmodificarproducto.Text = "Modificar";
            }
        }

        private void btneliminarproducto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de elimina a " + txtdescripcionproducto.Text, "Registro de Productos",
             MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { txtidproducto.Text };
                objconexion.mantenmiento_datos_Productos(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }
        }

        private void btnguardarproducto_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            Busquedaproductos frmBusquedaproducto = new Busquedaproductos();
            frmBusquedaproducto.ShowDialog();

            if (frmBusquedaproducto._idProductos > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedaproducto._idProductos));
                mostrarDatos();
            }
        }
        void limpiar_cajas()
        {
            txtdescripcionproducto.Text = "";

        }
        void controles(Boolean valor)
        {
            grbnavegacionproducto.Enabled = valor;
            btneliminarproducto.Enabled = valor;
            btnbuscarproducto.Enabled = valor;
            grbdatosProducto.Enabled = !valor;
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();
        }
        void actualizarDs()
        {
            tbl = objconexion.obtener_datos().Tables["Productos"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdProductos"] };
        }

        void mostrarDatos()
        {
            try
            {

                txtidproducto.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtdescripcionproducto.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txtiddescuento.Text = tbl.Rows[posicion].ItemArray[2].ToString();

                lblnpruduto.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registro de Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_cajas();
            }
        }

        private void btn1registroproductos_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void btnregistroanteriorproducto_Click_1(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Primer Registro...", "Registros de producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnregistroanteriorproducto_Click(object sender, EventArgs e)
        {
           if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Primer Registro...", "Registro de productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnultimoregistroproducto_Click(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            mostrarDatos();
        }

        private void btnregistrosiguienteproducto_Click(object sender, EventArgs e)
        {
            if (posicion < tbl.Rows.Count - 1)
            {

                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Ultimo Registro...", "Registro de Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
