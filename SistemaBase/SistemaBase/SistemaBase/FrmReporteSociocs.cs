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
    public partial class FrmReporteSociocs : Form
    {
        public FrmReporteSociocs()
        {
            InitializeComponent();
        }

        private void FrmReporteSociocs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Socio' table. You can move, or remove it, as needed.
            Int32 CodSocio = Principal.CodSocio;
            this.SocioTableAdapter.Fill(this.DataSet1.Socio, CodSocio);

            //   this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
