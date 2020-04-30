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
    public partial class clientes : Form
    {
        conexion objconexion = new conexion();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();
        public clientes()
        {
            InitializeComponent();
        }
        void actualizarDs()
        {
            tbl = objconexion.obtener_datos().Tables["clientes"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdCliente"] };
        }
        void mostrarDatos()
        {
            try
            {

                txtidcliente.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtnombrecliente.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txtdireccion.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txttelefono.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txtDui.Text = tbl.Rows[posicion].ItemArray[4].ToString();

                lblcliente.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }
            catch (Exception)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_cajas();
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            if (btnnuevo.Text == "Nuevo")
            {//boton de nuevo
                btnnuevo.Text = "Guardar";
                btnmodificar.Text = "Cancelar";
                accion = "nuevo";
                limpiar_cajas();
                controles(false);
            }
            else
            { //boton de guardar 
                String[] valores = {
                    txtidcliente.Text,
                    txtnombrecliente.Text,
                    txtdireccion.Text,
                    txttelefono.Text,
                    txtDui.Text,
                };

                objconexion.mantenmiento_datos(valores, accion);
                actualizarDs();
                posicion = tbl.Rows.Count - 1;
                mostrarDatos();

                controles(true);

                btnnuevo.Text = "Nuevo";
                btnmodificar.Text = "Modificar";
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (btnmodificar.Text == "Modificar")
            {//boton de modificar
                btnnuevo.Text = "Guardar";
                btnmodificar.Text = "Cancelar";
                accion = "modificar";

                controles(false);

                btnnuevo.Text = "Guardar";
                btnmodificar.Text = "Cancelar";

            }
            else
            { //boton de cancelar
                controles(true);
                mostrarDatos();

                btnnuevo.Text = "Nuevo";
                btnmodificar.Text = "Modificar";
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de elimina a " + txtnombrecliente.Text, "Registro de Clientes",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { txtidcliente.Text };

                objconexion.mantenmiento_datos(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Busquedacliente frmBusquedacliente = new Busquedacliente();
            frmBusquedacliente.ShowDialog();

            if (frmBusquedacliente._IdCliente > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedacliente._IdCliente));
                mostrarDatos();
            }
        }

        private void Registro1_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void btnsiguienteregistro_Click(object sender, EventArgs e)
        {
            if (posicion < tbl.Rows.Count - 1)
            {

                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Ultimo Registro...", "Registros de Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnregistroanterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Primer Registro...", "Registros de Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnultimoregistro_Click(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            mostrarDatos();
        }

        private void clientes_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();
        }

        void limpiar_cajas()
        {
            txtidcliente.Text = "";
            txtnombrecliente.Text = "";
            txtdireccion.Text = "";
            txttelefono.Text = "";
            txtDui.Text = "";
        }
        void controles(Boolean valor)
        {
            grbnavegacion.Enabled = valor;
            btneliminar.Enabled = valor;
            btnbuscar.Enabled = valor;
            grbdatosClientes.Enabled = !valor;
        }
    }

  }

