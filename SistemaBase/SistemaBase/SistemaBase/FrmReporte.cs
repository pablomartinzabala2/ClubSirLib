using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBase
{
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            // this.Reporte1TableAdapter.Fill(this.DsReportes.Reporte1);
            // TODO: This line of code loads data into the 'CONCESIONARIADataSet.Reporte' table. You can move, or remove it, as needed.

            // this.ReporteTableAdapter.Fill(this.CONCESIONARIADataSet.Reporte);



              
            this.reportViewer1.RefreshReport();
        }
    }
}
