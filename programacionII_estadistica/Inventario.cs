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
        public Inventario()
        {
            InitializeComponent();
        }

        private void inventarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaDataSet);

        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Devoluciones' Puede moverla o quitarla según sea necesario.
            this.devolucionesTableAdapter.Fill(this.sistemaDataSet.Devoluciones);
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.sistemaDataSet.Productos);
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.sistemaDataSet.Proveedor);
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Ordenes' Puede moverla o quitarla según sea necesario.
            this.ordenesTableAdapter.Fill(this.sistemaDataSet.Ordenes);
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.VentaDia' Puede moverla o quitarla según sea necesario.
            this.ventaDiaTableAdapter.Fill(this.sistemaDataSet.VentaDia);
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.InventarioDatos' Puede moverla o quitarla según sea necesario.
            this.inventarioDatosTableAdapter.FillInventarioDato(this.sistemaDataSet.InventarioDatos);
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.sistemaDataSet.Inventario);

        }
    }
}
