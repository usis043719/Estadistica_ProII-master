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
    public partial class OrdenesdeCompra : Form
    {
        conexion objconexion = new conexion();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();
        public OrdenesdeCompra()
        {
            InitializeComponent();
        }

        private void OrdenesdeCompra_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();
        }
        void actualizarDs()
            {
                tbl = objconexion.obtener_datos().Tables["Ordenes"];
                tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdOrden"] };
            }

            void mostrarDatos()
            {
                try{
                cboIdProveedorOrdenes.DataSource = objconexion.obtener_datos().Tables["Proveedor"];
                cboIdProveedorOrdenes.DisplayMember = "Proveedor";
                cboIdProveedorOrdenes.ValueMember = "Proveedor.IdProveedor";
                cboIdProveedorOrdenes.SelectedValue = tbl.Rows[posicion].ItemArray[2].ToString();


                lblidcatego.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                    txtfechacompra.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                    txtnombrepr.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                    txtempresa.Text = tbl.Rows[posicion].ItemArray[4].ToString();
                txtdescripcion.Text = tbl.Rows[posicion].ItemArray[5].ToString();
                txtunidadesproducto.Text = tbl.Rows[posicion].ItemArray[6].ToString();

                    lblnidnumorden.Text = (posicion + 1) + " de " + tbl.Rows.Count;
                }
                catch (Exception)
                {
                    MessageBox.Show("No hay Datos que mostrar", "Registro de ordenes",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar_cajas();
            }
        }
        void limpiar_cajas()
            {
                txtidnumorden.Text = "";

                txtfechacompra.Text = "";
                txtnombrepr.Text = "";
                cboIdProveedorOrdenes.Text = "";
                txtempresa.Text = "";
                txtdescripcion.Text = "";
                txtunidadesproducto.Text = "";



            }
            void controles(Boolean valor)
            {
                grbnavegacionordenes.Enabled = valor;
                btneliminarorden.Enabled = valor;
                btnbuscarorden.Enabled = valor;
                grbedicionOrdenes.Enabled = !valor;
            }

        private void btnnuevaorden_Click(object sender, EventArgs e)
        {
            if (btnnuevaorden.Text == "Nuevo")
            {//boton de nuevo
                btnnuevaorden.Text = "Guardar";
                btnmodifcarorden.Text = "Cancelar";
                accion = "nuevo";

                limpiar_cajas();
                controles(false);
            }
            else
            { //boton de guardar
                String[] valores = {
                    lblnidnumorden.Text,
                                        txtfechacompra.Text,
                                                            cboIdProveedorOrdenes.SelectedValue.ToString(),

                    txtnombrepr.Text,
                                        txtempresa.Text,

                    cboIdProveedorOrdenes.SelectedValue.ToString(),
                    txtdescripcion.Text,
                    txtunidadesproducto.Text,
                };
                objconexion.mantenmiento_datos_Ordenes(valores, accion);
                actualizarDs();
                posicion = tbl.Rows.Count - 1;
                mostrarDatos();

                controles(true);

                btnnuevaorden.Text = "Nuevo";
                btnmodifcarorden.Text = "Modificar";
            }
    }

        private void btnmodifcarorden_Click(object sender, EventArgs e)
        {
            if (btnmodifcarorden.Text == "Modificar")
            {//boton de modificar
                btnnuevaorden.Text = "Guardar";
                btnmodifcarorden.Text = "Cancelar";
                accion = "modificar";

                controles(false);

                btnnuevaorden.Text = "Guardar";
                btnmodifcarorden.Text = "Cancelar";

            }
            else
            { //boton de cancelar
                controles(true);
                mostrarDatos();

                btnnuevaorden.Text = "Nuevo";
                btnmodifcarorden.Text = "Modificar";
            }
    }

        private void btneliminarorden_Click(object sender, EventArgs e)
        {

        }
    }
}




