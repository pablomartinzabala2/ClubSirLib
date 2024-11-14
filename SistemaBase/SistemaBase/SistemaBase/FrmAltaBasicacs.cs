using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaBase.Clases;

namespace SistemaBase
{
    public partial class FrmAltaBasicacs : Form
    {
        public FrmAltaBasicacs()
        {
            InitializeComponent();
        }

        private void FrmAltaBasicacs_Load(object sender, EventArgs e)
        {
            cFunciones fun = new Clases.cFunciones();
            fun.EstiloBotones(BtnGrabar);
            fun.EstiloBotones(btnCancelar);
            txtTabla.Text = Principal.NombreTablaSecundario;
            txtCampoId.Text = Principal.CampoIdSecundario;
            txtCampoNombre.Text = Principal.CampoNombreSecundario;
            this.Text = "Formulario de alta";
        }
    }
}
