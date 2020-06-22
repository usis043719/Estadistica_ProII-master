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
    public partial class ImpresionVentaR : Form
    {
        private int _IdVenta = 0;
        public ImpresionVentaR(int IdVent)
    {
            InitializeComponent();
             _IdVenta = IdVent;
    }

        private void ImpresionVentaR_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SistemaDataSet.rptVentaDia' Puede moverla o quitarla según sea necesario.
            this.rptVentaDiaTableAdapter.FillRptVentaDia(this.SistemaDataSet.rptVentaDia, _IdVenta);

            this.reportViewer1.RefreshReport();
        }
    }
}
