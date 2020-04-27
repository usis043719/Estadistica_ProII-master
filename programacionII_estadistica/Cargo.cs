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
    public partial class Cargo : Form
    {
        conexion objconexion = new conexion();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();
        public Cargo()
        {
            InitializeComponent();
        }

        private void Cargo_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();
        }
        void actualizarDs()
        {
            tbl = objconexion.obtener_datos().Tables["Cargo"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdCargo"] };
        }
        void mostrarDatos()
        {
            try
            {
                txtidcargo.Text = tbl.Rows[posicion].ItemArray[0].ToString();

                txtcargo.Text = tbl.Rows[posicion].ItemArray[1].ToString();
               
                lblncargo.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }

            catch (Exception)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de Cargo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_cajas();
            }
        }

        private void btnagregarc_Click(object sender, EventArgs e)
        {
            if (btnagregarc.Text == "Nuevo")
            {//boton de nuevo
                btnagregarc.Text = "Guardar";
                btnmodific.Text = "Cancelar";
                accion = "nuevo";
                limpiar_cajas();
                controles(false);
            }
            else
            { //boton de guardar 
                String[] valores = {
                    txtidcargo.Text,
                    txtcargo.Text,
                   

                };

                objconexion.mantenimiento_datos_cargo(valores, accion);
                actualizarDs();
                posicion = tbl.Rows.Count - 1;
                mostrarDatos();

                controles(true);

                btnagregarc.Text = "Nuevo";
                btnmodific.Text = "Modificar";
            }
        }

        private void btnmodific_Click(object sender, EventArgs e)
        {
            if (btnmodific.Text == "Modificar")
            {//boton de modificar
                btnagregarc.Text = "Guardar";
                btnmodific.Text = "Cancelar";
                accion = "modificar";

                controles(false);

                btnagregarc.Text = "Guardar";
                btnmodific.Text = "Cancelar";

            }
            else
            { //boton de cancelar
                controles(true);
                mostrarDatos();

                btnagregarc.Text = "Nuevo";
                btnmodific.Text = "Modificar";
            }
        }

        private void btneliminarc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de elimina a " + txtcargo.Text, "Registro de Cargo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { txtidcargo.Text };

                objconexion.mantenimiento_datos_cargo(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }
        }

        private void btnbuscarc_Click(object sender, EventArgs e)
        {
            BusquedaCargo frmBusquedacargo = new BusquedaCargo();
            frmBusquedacargo.ShowDialog();

            if (frmBusquedacargo._IdCargo > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedacargo._IdCargo));
                mostrarDatos();
            }
        }

        private void btn1registroc_Click(object sender, EventArgs e)
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
                MessageBox.Show("Primer Registro...", "Registros de Cargo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnultimoregistroc_Click(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            mostrarDatos();
        }
        void limpiar_cajas()
        {
            txtidcargo.Text = "";
            txtcargo.Text = "";
           


        }
        void controles(Boolean valor)
        {
            grbnavegacioncargo.Enabled = valor;
            btneliminarc.Enabled = valor;
            btnbuscarc.Enabled = valor;
            grbdatosCargo.Enabled = !valor;
        }

        private void btnregistrosiguientec_Click(object sender, EventArgs e)
        {
            if (posicion < tbl.Rows.Count - 1)
            {

                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Ultimo Registro...", "Registros de Cargo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
