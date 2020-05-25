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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void facturaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facturaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaDataSet);

        }

        private void Factura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.Factura' Puede moverla o quitarla según sea necesario.
            this.facturaTableAdapter.Fill(this.sistemaDataSet.Factura);

        }
    }
}
