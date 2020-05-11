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
        string accion = "nuevo";
        DataTable tbl = new DataTable();
        public Empleado()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (btnagregar.Text == "Nuevo")
            {//boton de nuevo
                btnagregar.Text = "Guardar";
                btnmodificar.Text = "Cancelar";
                accion = "nuevo";
                limpiar_cajas();
                controles(false);
                lblejemplo.Visible = true;
            }
            else
            { //boton de guardar 
                String[] valores = {

                    txtidempleado.Text,
                    txtnombreempleado.Text,
                    txttelefono.Text,
                    txtdireccion.Text,
                    cboCargoEmpleado.SelectedValue.ToString(),
                };

                objconexion.mantenimiento_datos_Empleado(valores, accion);
                actualizarDs();
                posicion = tbl.Rows.Count - 1;
                mostrarDatos();

                controles(true);

                btnagregar.Text = "Nuevo";
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
            else
            { //boton de cancelar
                controles(true);
                mostrarDatos();

                btnagregar.Text = "Nuevo";
                btnmodificar.Text = "Modificar";
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de elimina a " + txtnombreempleado.Text, "Registro de Empleados",
             MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { txtidempleado.Text };
                objconexion.mantenimiento_datos_Empleado(valores, "eliminar");

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
                MessageBox.Show("Primer Registro...", "Registros de Empleados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();
        }
        void actualizarDs()
        {
            tbl = objconexion.obtener_datos().Tables["Empleados"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdEmpleado"] };

            cboCargoEmpleado.DataSource = objconexion.obtener_datos().Tables["Cargo"];
            cboCargoEmpleado.DisplayMember = "Cargo";
            cboCargoEmpleado.ValueMember = "Cargo.IdCargo";

        }
        void mostrarDatos()
        {
            try
            {
                lblejemplo.Visible = false;

                cboCargoEmpleado.SelectedValue = tbl.Rows[posicion].ItemArray[4].ToString();

                txtidempleado.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtnombreempleado.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txttelefono.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtdireccion.Text = tbl.Rows[posicion].ItemArray[3].ToString();


                lblempleado.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }
            catch (Exception)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registro de Empleados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_cajas();
            }
        }





        private void btnultimoregistro_Click(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            mostrarDatos();
        }
        void limpiar_cajas()
        {
            txtnombreempleado.Text = "";
            txttelefono.Text = "";
            txtdireccion.Text = "";

        }
        void controles(Boolean valor)
        {
            grbnavegacion.Enabled = valor;
            btneliminar.Enabled = valor;
            btnbuscar.Enabled = valor;
            grbdatosEmpleado.Enabled = !valor;

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
                MessageBox.Show("Ultimo Registro...", "Registro de Empleados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscarCargoEmpleados_Click(object sender, EventArgs e)
        {
            BusquedaCargo frmbusquedacargo = new BusquedaCargo();
            frmbusquedacargo.ShowDialog();

            if (frmbusquedacargo._IdCargo > 0)
            {
               cboCargoEmpleado.SelectedValue = frmbusquedacargo._IdCargo;
            }
        }
    }
 }
