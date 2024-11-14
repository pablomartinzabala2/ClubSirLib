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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cFunciones fun = new Clases.cFunciones();
            fun.LlenarCombo(cmbTipo, "Tipo", "Nombre", "CodTipo");
            txtNombre.Tag = "Nombre";
            string xxx = txtNombre.Tag.ToString();
            txtCodigo.Tag = "Codigo";
            TxtStock.Tag = "Stock";
            cmbTipo.Tag = "CodTipo";
            fun.CargarControlesxTabla(Grupo, "Joya","CodJoya","1");
            
        }
    }
}
