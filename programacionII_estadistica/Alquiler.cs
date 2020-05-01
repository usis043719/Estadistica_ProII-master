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
    public partial class Alquiler : Form
    {
        conexion objconexion = new conexion();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();
        public Alquiler()
        {
            InitializeComponent();
        }

        private void Alquiler_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();
        }
        void actualizarDs()
        {
            tbl = objconexion.obtener_datos().Tables["alquiler"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdAlquiler"] };
        }
        void mostrarDatos()
        {
            try
            {

                txtidalquiler.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtidcliente.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txtidpelicula.Text = tbl.Rows[posicion].ItemArray[2].ToString();

                txtfechaprestamo.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txtfechadevolucion.Text = tbl.Rows[posicion].ItemArray[4].ToString();
                txtvalor.Text = tbl.Rows[posicion].ItemArray[5].ToString();



                lblidalquiler.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }

            catch (Exception)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de alquiler",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_cajas();
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
                MessageBox.Show("Ultimo Registro...", "Registros de alquiler",
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
                MessageBox.Show("Primer Registro...", "Registros de alquiler",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void btnultimoregistro_Click(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            mostrarDatos();
        }
        void limpiar_cajas()
        {
            txtidalquiler.Text = "";
            txtidcliente.Text = "";
            txtidpelicula.Text = "";
            txtfechaprestamo.Text = "";
            txtfechadevolucion.Text = "";
            txtvalor.Text = "";


        }
        void controles(Boolean valor)
        {
            grbnavegacion.Enabled = valor;
            btneliminar.Enabled = valor;
            btnbuscar.Enabled = valor;
            grbdatosAlquiler.Enabled = !valor;
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
                    txtidalquiler.Text,
                    txtidcliente.Text,
                    txtidpelicula.Text,

                    txtfechaprestamo.Text,
                    txtfechadevolucion.Text,                
                    txtvalor.Text,

                };

                objconexion.mantenmiento_datos_alquiler(valores, accion);
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
            if (MessageBox.Show("Esta seguro de elimina a " + txtidcliente.Text, "Registro de alquiler",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { txtidalquiler.Text };

                objconexion.mantenmiento_datos_alquiler(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }
    }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BusquedaAlquiler frmBusquedaalquiler = new BusquedaAlquiler();
            frmBusquedaalquiler.ShowDialog();

            if (frmBusquedaalquiler._IdAlquiler > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedaalquiler._IdAlquiler));
                mostrarDatos();
            }
        }
    }
    }