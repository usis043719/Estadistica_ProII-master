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
    private int _nfactura = 0;
    public partial class ImpresionFactura : Form
    {
        public ImpresionFactura(int nfact)
        { 

            InitializeComponent();
            _nfactura = nfact;
        }

        private void ImpresionFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SistemaDataSet.rptFacturas' Puede moverla o quitarla según sea necesario.
            this.rptFacturasTableAdapter.FillrptFactura(this.SistemaDataSet.rptFacturas,_nfactura);

        }
    }
}
