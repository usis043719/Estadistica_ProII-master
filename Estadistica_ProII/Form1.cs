using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estadistica_ProII
{
    public partial class Form1 : Form
    {
        estadsitica objEstadisticas = new estadsitica();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmedia_aritmetica_Click(object sender, EventArgs e)
        {
            lblrespuesta_serie.Text = "x=" + objEstadisticas.media(txtserie.Text.Split(','));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnestandar_Click(object sender, EventArgs e)
        {
            lblrespuesta_serie.Text = "estandar=" + objEstadisticas.estandar(txtserie.Text.Split(','));
        }

        private void btntipica_Click(object sender, EventArgs e)
        {
            lblrespuesta_serie.Text = "tipica=" + objEstadisticas.tipica(txtserie.Text.Split(','));
        }

        private void btnmoda_Click(object sender, EventArgs e)
        {


            lblrespuesta_serie.Text = "moda=" + objEstadisticas.tipica(txtserie.Text.Split(','));
        }

        private void grdEstadistica_KeyDow(object sender, KeyEventArgs e)
        {
            try
            {
                int nfilas = grdEstadistica.Rows.Count - 1,
                    sumaf1 = 0,
                    sumaxixfi = 0;
                double sumax2ixfi = 0;
                DataGridViewRow fila;

                for (int i = 0; i < nfilas; i++)
                {
                    fila = grdEstadistica.Rows[i];
                    int x1 = int.Parse(fila.Cells["x1"].Value.ToString()),
                        f1 = int.Parse(fila.Cells["f1"].Value.ToString());
                    sumaf1 += f1;
                    sumaxixfi += x1 * f1;
                    sumax2ixfi += Math.Pow(x1, 2) * f1;

                    fila.Cells["fi"].Value = sumaf1.ToString();
                    fila.Cells["xixfi"].Value = (x1 * f1).ToString();
                    fila.Cells["x2ixfi"].Value = (Math.Pow(x1, 2) * f1).ToString();
                }
                lbltotalf1.Text = sumaf1.ToString();
                lbltotalxixfi.Text = sumaxixfi.ToString();
                lbltotalx2ixfi.Text = sumax2ixfi.ToString();

                double media = sumaxixfi / sumaf1,
                    standar = sumax2ixfi / sumaf1 - Math.Pow(media, 2),
                    tipica = Math.Sqrt(standar);

                lblmedia.Text = media.ToString();
                lblestandar.Text = standar.ToString();
                lbltipica.Text = tipica.ToString();
            }
            catch (Exception error)
            {

            }
        }

        private void btnarmonica_Click(object sender, EventArgs e)
        {
            lblrespuesta_serie.Text = " armonica=" + objEstadisticas.tipica(txtserie.Text.Split(','));
        }
    }
    }
