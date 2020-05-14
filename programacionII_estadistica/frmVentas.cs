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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void ventaDiaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ventaDiaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaDataSet);

        }

        private void ventaDiaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.ventaDiaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaDataSet);

        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaDataSet.VentaDia' Puede moverla o quitarla según sea necesario.
            this.ventaDiaTableAdapter.Fill(this.sistemaDataSet.VentaDia);

        }

    }
}
