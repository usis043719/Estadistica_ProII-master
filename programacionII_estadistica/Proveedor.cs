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
    public partial class Proveedor : Form
    {
        conexion objconexion = new conexion();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();
        public Proveedor()
        {
            InitializeComponent();
        }

        private void lbltelefonopro_Click(object sender, EventArgs e)
        {

        }

        private void btnnuevoproveedor_Click(object sender, EventArgs e)
        {
            if (btnnuevoproveedor.Text == "Nuevo")
            {//boton de nuevo
                btnnuevoproveedor.Text = "Guardar";
                btnmodificarproveedor.Text = "Cancelar";
                accion = "nuevo";
                limpiar_cajas();
                controles(false);
                lblejemplo.Visible = true;
            }
            else
            { //boton de guardar 
                String[] valores = {

                    txtidproveedor.Text,
                    txtdireccionproveedor.Text,
                    txttelpro.Text,
                    txtidinventarioprovee.Text,
                    txtnombreproveedor.Text,
                    txtempresa.Text,

            };

                objconexion.mantenimiento_datos_proveedor(valores, accion);
                actualizarDs();
                posicion = tbl.Rows.Count - 1;
                mostrarDatos();

                controles(true);

                btnnuevoproveedor.Text = "Nuevo";
                btnmodificarproveedor.Text = "Modificar";
            }
    }

        private void btnmodificarproveedor_Click(object sender, EventArgs e)
        {
            if (btnmodificarproveedor.Text == "Modificar")
            {//boton de modificar
                btnnuevoproveedor.Text = "Guardar";
                btnmodificarproveedor.Text = "Cancelar";
                accion = "modificar";

                controles(false);

                btnnuevoproveedor.Text = "Guardar";
                btnmodificarproveedor.Text = "Cancelar";

            }
            else
            { //boton de cancelar
                controles(true);
                mostrarDatos();

                btnnuevoproveedor.Text = "Nuevo";
                btnmodificarproveedor.Text = "Modificar";
            }
    }

        private void btneliminarproveedor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de elimina a " + txtdireccionproveedor.Text, "Registro de Proveedor",
               MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { txtidproveedor.Text };

                objconexion.mantenimiento_datos_proveedor(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }
        }
    
    private void btnbuscarproveedor_Click(object sender, EventArgs e)
        {
                BusquedaProveedor frmBusquedaproveedor = new BusquedaProveedor();
                frmBusquedaproveedor.ShowDialog();

                if (frmBusquedaproveedor._IdProveedor > 0)
                {
                    posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedaproveedor._IdProveedor));
                    mostrarDatos();
            }
        }

        private void Registro1pro_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void btnregistroanteriorpro_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Primer Registro...", "Registros de Proveedor",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
    }

        private void btnultimoregistropro_Click(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            mostrarDatos();
        }
        void limpiar_cajas()
        {
            txtidproveedor.Text = "";
            txtdireccionproveedor.Text = "";
            txttelpro.Text = "";
            txtidinventarioprovee.Text = "";
            txtnombreproveedor.Text = "";
            txtempresa.Text = "";


        }
        void controles(Boolean valor)
        {
            grbdatosProveedor.Enabled = valor;
            btneliminarproveedor.Enabled = valor;
            btnbuscarproveedor.Enabled = valor;
            grbdatosProveedor.Enabled = !valor;
        }

        private void btnsiguienteregistropro_Click(object sender, EventArgs e)
        {
            if (posicion < tbl.Rows.Count - 1)
            {

                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Ultimo Registro...", "Registros de Proveedor",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();
        }
        void actualizarDs()
        {
            tbl = objconexion.obtener_datos().Tables["Proveedor"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdProveedor"] };
        }
        void mostrarDatos()
        {
            try
            {
                lblejemplo.Visible = false;

                txtidproveedor.Text = tbl.Rows[posicion].ItemArray[0].ToString();

                txtdireccionproveedor.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txttelpro.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtidinventarioprovee.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txtnombreproveedor.Text = tbl.Rows[posicion].ItemArray[4].ToString();
                txtempresa.Text = tbl.Rows[posicion].ItemArray[5].ToString();

                lblprovee.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }

            catch (Exception)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de Proveedor",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_cajas();
            }
        }

        private void btnbuscarproveedor_Click_1(object sender, EventArgs e)
        {
            BusquedaProveedor frmBusquedaproveedor = new BusquedaProveedor();
            frmBusquedaproveedor.ShowDialog();

            if (frmBusquedaproveedor._IdProveedor > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedaproveedor._IdProveedor));
                mostrarDatos();
            }
        }
    }
}
