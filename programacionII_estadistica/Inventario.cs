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
    public partial class Inventario : Form
    {
        conexion objconexion = new conexion();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();

        public Inventario()
        {
            InitializeComponent();
        }

        private void btnnuevoinventario_Click(object sender, EventArgs e)
        {
            if (btnnuevoinventario.Text == "Nuevo")
            {//boton de nuevo
                btnnuevoinventario.Text = "Guardar";
                btnmodificarinventario.Text = "Cancelar";
                accion = "nuevo";
                limpiar_cajas();
                controles(false);
            }
            else
            { //boton de guardar 
                String[] valores = {
                    txtidinventario.Text,
                    txtunidadesinvent.Text,
                    txtidproductoinventario.Text,

                    txtdescripcioninventario.Text,


                };

                objconexion.mantenmiento_datos_Inventario(valores, accion);
                actualizarDs();
                posicion = tbl.Rows.Count - 1;
                mostrarDatos();

                controles(true);

                btnnuevoinventario.Text = "Nuevo";
                btnmodificarinventario.Text = "Modificar";
            }
    }

        private void btnmodificarinventario_Click(object sender, EventArgs e)
        {
            if (btnmodificarinventario.Text == "Modificar")
            {//boton de modificar
                btnnuevoinventario.Text = "Guardar";
                btnmodificarinventario.Text = "Cancelar";
                accion = "modificar";

                controles(false);

                btnnuevoinventario.Text = "Guardar";
                btnmodificarinventario.Text = "Cancelar";

            }
            else
            { //boton de cancelar
                controles(true);
                mostrarDatos();

                btnnuevoinventario.Text = "Nuevo";
                btnmodificarinventario.Text = "Modificar";
            }
    }

        private void btneliminarinventario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de elimina a " + txtidinventario.Text, "Registro de Inventario",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { txtidinventario.Text };

                objconexion.mantenmiento_datos_Inventario(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }
        }

        private void btnbuscarinventario_Click(object sender, EventArgs e)
        {
            BusquedaInventario frmBusquedainventario = new BusquedaInventario();
            frmBusquedainventario.ShowDialog();

            if (frmBusquedainventario._IdInventario > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedainventario._IdInventario));
                mostrarDatos();
            }
        }

        private void Registro1inventario_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void btnregistroanteriorinventario_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Primer Registro...", "Registros de Inventario",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
    }

        private void btnultimoregistroinventario_Click(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            mostrarDatos();
        }
        void limpiar_cajas()
        {
            txtidinventario.Text = "";
            txtunidadesinvent.Text = "";
            txtdescripcioninventario.Text = "";

        }
        void controles(Boolean valor)
        {
            grbnavegacioninventario.Enabled = valor;
            btneliminarinventario.Enabled = valor;
            btneliminarinventario.Enabled = valor;
            grbdatosInventario.Enabled = !valor;
        }

        private void btnsiguienteregistroinventario_Click(object sender, EventArgs e)
        {
            if (posicion < tbl.Rows.Count - 1)
            {

                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Ultimo Registro...", "Registros de Inventario",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();
        }
        void actualizarDs()
        {
            tbl = objconexion.obtener_datos().Tables["Inventario"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdInventario"] };
        }
        void mostrarDatos()
        {
            try
            {

                txtidinventario.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtunidadesinvent.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txtidproductoinventario.Text = tbl.Rows[posicion].ItemArray[2].ToString();

                txtdescripcioninventario.Text = tbl.Rows[posicion].ItemArray[3].ToString();



                lblninventario.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }

            catch (Exception)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de Inventario",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_cajas();
            }
    }
    }
}


