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
    public partial class Empleado : Form
    {
        conexion objconexion = new conexion();
        int posicion = 0;
        string accion = "agregar";
        DataTable tbl = new DataTable();
        public Empleado()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();
        }
        void actualizarDs()
        {
            tbl = objconexion.obtener_datos().Tables["Empleados"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["idEmpleado"] };
        }
        void mostrarDatos()
        {
            try
            {
                txtidempleado.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txtnombreempleado.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtdireccion.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txttelefono.Text = tbl.Rows[posicion].ItemArray[4].ToString();


            }
            catch (Exception)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de empleado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_cajas();
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (btnagregar.Text == "Agregar")
            {//boton de nuevo

                btnagregar.Text = "Guardar";
                btnmodificar.Text = "Cancelar";
                accion = "agregar";

                limpiar_cajas();
                controles(true);
            }
            else
            { //boton de guardar
                String[] valores = {
                    lblempleado.Text,
                    txtidempleado.Text,
                    txtnombreempleado.Text,
                    txtdireccion.Text,
                    txttelefono.Text,

                };
                objconexion.mantenmiento_datos(valores, accion);
                actualizarDs();
                posicion = tbl.Rows.Count - 1;
                mostrarDatos();

                controles(true);

                btnagregar.Text = "Agregar";
                btnmodificar.Text = "Modificar";
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (btnmodificar.Text == "Modificar")
            {//boton de modificar
                btnagregar.Text = "Guardar";
                btnmodificar.Text = "Cancelar";
                accion = "modificar";

                controles(false);

                btnagregar.Text = "Guardar";
                btnmodificar.Text = "Cancelar";
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de elimina a " + txtnombreempleado.Text, "Registro de empleado",
  MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblempleado.Text };
                objconexion.mantenmiento_datos(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Busquedaempleado frmBusquedaempleado = new Busquedaempleado
             ();
            frmBusquedaempleado.ShowDialog();

            if (frmBusquedaempleado._IdEmpleado > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedaempleado._IdEmpleado));
                mostrarDatos();
            }
        }

        private void registro1_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
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
                MessageBox.Show("Primer Registro...", "Registros de empleado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            {
                actualizarDs();
                mostrarDatos();
            }
        }


        private void btnultimoregistro_Click(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            mostrarDatos();
        }
        void limpiar_cajas()
        {
            txtidempleado.Text = "";
            txtnombreempleado.Text = "";
            txttelefono.Text = "";
            txtdireccion.Text = "";

        }
        void controles(Boolean valor)
        {
            grbnavegacion.Enabled = valor;
            btneliminar.Enabled = valor;
            btnbuscar.Enabled = valor;
            grbcliente.Enabled = !valor;
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
                MessageBox.Show("Ultimo Registro...", "Registros de Empleado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
 }
