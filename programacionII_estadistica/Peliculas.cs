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
    public partial class Peliculas : Form
    {
        conexion objconexion = new conexion();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();
        public Peliculas()
        {
            InitializeComponent();
        }
        void actualizarDs()
        {
            tbl = objconexion.obtener_datos().Tables["peliculas"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdPelicula"] };
        }
        void mostrarDatos()
        {
            try
            {

                txtidpelicula.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtdescripcion.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txtsinopsis.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtgenero.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txtduracion.Text = tbl.Rows[posicion].ItemArray[4].ToString();

                lblidpelicula.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }
            catch (Exception)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de Pelicula",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_cajas();
            }
        }

        private void Peliculas_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();
        }

        void limpiar_cajas()
        {
            txtidpelicula.Text = "";
            txtdescripcion.Text = "";
            txtsinopsis.Text = "";
            txtgenero.Text = "";
            txtduracion.Text = "";
        }
        void controles(Boolean valor)
        {
            grbnavegacion.Enabled = valor;
            btneliminar.Enabled = valor;
            btnbuscar.Enabled = valor;
            grbdatosPeliculas.Enabled = !valor;
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
                MessageBox.Show("Ultimo Registro...", "Registros de Pelicula",
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
                MessageBox.Show("Primer Registro...", "Registros de Pelicula",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnultimoregistro_Click(object sender, EventArgs e)
        {

            posicion = tbl.Rows.Count - 1;
            mostrarDatos();
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
                    txtidpelicula.Text,
                    txtdescripcion.Text,
                    txtsinopsis.Text,
                    txtgenero.Text,
                    txtduracion.Text,
                };

                objconexion.mantenmiento_datos_peliculas(valores, accion);
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
            if (MessageBox.Show("Esta seguro de elimina a " + txtdescripcion.Text, "Registro de Peliculas",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { txtidpelicula.Text };

                objconexion.mantenmiento_datos_peliculas(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BusquedaPeliculas frmBusquedapeliculas = new BusquedaPeliculas();
            frmBusquedapeliculas.ShowDialog();

            if (frmBusquedapeliculas._IdPelicula > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedapeliculas._IdPelicula));
                mostrarDatos();
            }
        }
    }
}
