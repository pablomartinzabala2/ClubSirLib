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
    public partial class FrmAbmSocio : FormBase     {
        cFunciones fun;
        public FrmAbmSocio()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Botonera(2);
            Grupo.Enabled = true;
            fun.LimpiarGenerico(this);
        }

        private void Botonera(int Jugada)
        {
            switch (Jugada)
            {
                //estado inicial
                case 1:
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnAceptar.Enabled = false;
                    btnCancelar.Enabled = false;
                    break;
                case 2:
                    btnNuevo.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnAceptar.Enabled = true;
                    btnCancelar.Enabled = true;
                    break;
                case 3:
                    //viene del buscador
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnAceptar.Enabled = false;
                    btnCancelar.Enabled = false;
                    break;
            }
        }

        private void FrmAbmSocio_Load(object sender, EventArgs e)
        {
            Botonera(1);
            Grupo.Enabled = false;
            fun = new cFunciones();
            CargarGenero();
            CargarCategoria();
        }

        private void CargarCategoria()
        {
            cCategoria cat = new cCategoria();
            DataTable trdo = cat.GetCategoria();
            fun.LlenarComboDatatable(cmb_CodCategoria, trdo, "Nombre", "CodCategoria");
        }

        private void CargarGenero()
        {
            cFunciones fun = new cFunciones();
            DataTable tb = fun.CrearTabla("Codigo;Nombre");
            tb = fun.AgregarFilas(tb, "1;Masculino");
            tb = fun.AgregarFilas(tb, "2;Femenino");
            tb = fun.AgregarFilas(tb, "3;Sin Definir");
            fun.LlenarComboDatatable(cmb_Sexo, tb, "Nombre", "Codigo");
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //cFunciones fun = new Clases.cFunciones();
            if (txtCodigo.Text == "")
                fun.GuardarNuevoGenerico(this, "Socio");
            else
            {
                // if (txt_Ruta.Text != "")
                //   txt_Ruta.Text = txt_Ruta.Text.Replace("\\", "\\\\");
                fun.ModificarGenerico(this, "Socio", "CodSocio", txtCodigo.Text);

            }
            MessageBox.Show("Datos grabados correctamente");
            fun.LimpiarGenerico(this);
            Botonera(1);
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Principal.OpcionesdeBusqueda = "Nombre;Apellido;NroDoc";
            Principal.TablaPrincipal = "Socio";
            Principal.OpcionesColumnasGrilla = "CodSocio;Nombre;Apellido;NroDoc";
            Principal.ColumnasVisibles = "0;1;1;1";
            Principal.ColumnasAncho = "0;250;250;80";
            FrmBuscadorGenerico form = new FrmBuscadorGenerico();
            form.FormClosing += new FormClosingEventHandler(form_FormClosing);
            form.ShowDialog();
        }

        private void form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Principal.CodigoPrincipalAbm != null)
            {
                Botonera(3);
                txtCodigo.Text = Principal.CodigoPrincipalAbm.ToString();

                fun.CargarControles(this, "Socio", "CodSocio", txtCodigo.Text);

            }
            Grupo.Enabled = false;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Botonera(2);
            Grupo.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string msj = "Confirma eliminar el Cliente ";
            var result = MessageBox.Show(msj, "Información",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.No)
            {
                return;
            }

            Clases.cFunciones fun = new Clases.cFunciones();
            fun.EliminarGenerico("Socio", "CodSocio", txtCodigo.Text);
            MessageBox.Show("El cliente se ha eliminado de la base", "Sistema");
            fun.LimpiarGenerico(this);
            txtCodigo.Text = "";
            Botonera(1);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {  
            Botonera(1);
            Clases.cFunciones fun = new Clases.cFunciones();
            fun.LimpiarGenerico(this);
            txtCodigo.Text = "";
        }

        private void txt_NroDoc_Leave(object sender, EventArgs e)
        {
            string NroDoc = "";
            cSocio Socio = new cSocio();
            if (txt_NroDoc.Text !="")
            {
                NroDoc = txt_NroDoc.Text;
                DataTable trdo = Socio.GetSocioxNroDoc(NroDoc);
                if (trdo.Rows.Count >0)
                {
                    if (trdo.Rows[0]["CodSocio"].ToString ()!="")
                    {
                        txtCodigo.Text = trdo.Rows[0]["CodSocio"].ToString();
                        fun.CargarControles(this, "Socio", "CodSocio", txtCodigo.Text);
                    }
                }
            }
        }
    }
}
