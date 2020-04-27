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
    public partial class Categoria : Form
    {
        conexion objconexion = new conexion();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();
        public Categoria()

        {
            InitializeComponent();
    }
    private void Categoria_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();
        }
        void actualizarDs()
        {
            tbl = objconexion.obtener_datos().Tables["Categoria"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdCategoria"] };
        }
        void mostrarDatos()
        {
            try
            {
                txtidcategoria.Text = tbl.Rows[posicion].ItemArray[0].ToString();

                txtcategoria.Text = tbl.Rows[posicion].ItemArray[1].ToString();

                lblncategoria.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }

            catch (Exception)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de Categoria",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_cajas();
            }
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
            }
            else
            { //boton de guardar 
                String[] valores = {
                    txtidcategoria.Text,
                    txtcategoria.Text,


                };

                objconexion.mantenimiento_datos_Categoria(valores, accion);
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
            if (MessageBox.Show("Esta seguro de elimina a " + txtcategoria.Text, "Registro de Categoria",
             MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { txtidcategoria.Text };

                objconexion.mantenimiento_datos_Categoria(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Busquedacategoria frmBusquedacategoria = new Busquedacategoria();
            frmBusquedacategoria.ShowDialog();

            if (frmBusquedacategoria._IdCategoria > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedacategoria._IdCategoria));
                mostrarDatos();
            }
        }

        private void btn1registro_Click(object sender, EventArgs e)
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
                MessageBox.Show("Primer Registro...", "Registros de Categoria",
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
            txtidcategoria.Text = "";
            txtcategoria.Text = "";



        }
        void controles(Boolean valor)
        {
            grbnavegacion.Enabled = valor;
            btneliminar.Enabled = valor;
            btnbuscar.Enabled = valor;
            grbdatos.Enabled = !valor;
        }

        private void btnregistrosiguiente_Click(object sender, EventArgs e)
        {
            if (posicion < tbl.Rows.Count - 1)
            {

                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Ultimo Registro...", "Registros de Categoria",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    }
    
    

