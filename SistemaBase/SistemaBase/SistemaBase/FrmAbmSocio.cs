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
            txtCodigo.Text = "";
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
            CargarTipoDoc();
            
        }

        private void CargarTipoDoc()
        {
            string sql = "select * from TipoDocumento order by Nombre ";
            DataTable trdo = cDb.GetDatatable(sql);
            cFunciones fun = new cFunciones();
            fun.LlenarComboDatatable(cmb_CodTipoDoc, trdo, "Nombre", "CodTipoDoc");
        }

        private void CargarGenero()
        {  
            string sql = "select * from Genero order by Nombre ";
            DataTable trdo = cDb.GetDatatable(sql);
            cFunciones fun = new cFunciones();
            fun.LlenarComboDatatable(cmb_CodGenero, trdo, "Nombre", "Codigo");
        }

        private void CargarCategoria()
        {
            cCategoria cat = new cCategoria();
            DataTable trdo = cat.GetCategoria();
            fun.LlenarComboDatatable(cmb_CodCategoria, trdo, "Nombre", "CodCategoria");
        }

       

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            txt_FechaAsociacion.Text = dpFecha.Value.ToShortDateString();
            txt_FechaNac.Text = daFechaNac.Value.ToShortDateString();
            //cFunciones fun = new Clases.cFunciones();
            if (txtCodigo.Text == "")
            {
                fun.GuardarNuevoGenerico(this, "Socio");
                cSocio socio = new cSocio();
                txtCodigo.Text = socio.GetMaxSocio().ToString();
            }
                
            else
            {
                // if (txt_Ruta.Text != "")
                //   txt_Ruta.Text = txt_Ruta.Text.Replace("\\", "\\\\");
                fun.ModificarGenerico(this, "Socio", "CodSocio", txtCodigo.Text);

            }
            Principal.CodSocio = Convert.ToInt32(txtCodigo.Text);
            MessageBox.Show("Datos grabados correctamente");
            fun.LimpiarGenerico(this);
            Botonera(1);
            FrmReporteSociocs frm = new FrmReporteSociocs();
            frm.Show();
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
                if (txt_FechaAsociacion.Text !="")
                {
                    DateTime Fecha = Convert.ToDateTime(txt_FechaAsociacion.Text);
                    dpFecha.Value = Fecha;
                }
                  
                if (txt_FechaNac.Text != "")
                {
                    DateTime Fecha = Convert.ToDateTime(txt_FechaNac.Text);
                    daFechaNac.Value = Fecha;
                }

                ArmarNumeroSoxio();

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

           // ArmarNumeroSoxio();
        }

        private void ArmarNumeroSoxio()
        {
            string Genero = "0";
            string CatSocio = "0";
            string NroSocio = "";
            string NroDocumento = "";
            if (cmb_CodGenero.SelectedIndex >0)
            {
                int i = Convert.ToInt32 (cmb_CodGenero.SelectedValue);
                switch(i)
                {
                    case  1:
                        Genero = "10";
                        break;
                    case 2:
                        Genero = "20";
                        break;
                    case 3:
                        Genero = "30";
                        break;
                }            
            }

            if (cmb_CodCategoria.SelectedIndex >0 )
            {
                int Codigo = Convert.ToInt32(cmb_CodCategoria.SelectedValue);
                string Nombre = GetCategoria(Codigo);
                if (Nombre !="")
                {
                    string[] Vec = Nombre.Split('-');
                    CatSocio = Vec[0];  
                }
            }

            NroDocumento = txt_NroDoc.Text;
            NroSocio = Genero + "-" + NroDocumento + "-" + CatSocio;
            txt_NumeroSocio.Text = NroSocio;
        }

        private string GetCategoria (int CodCategoria)
        {
            string Nombre = "";
            string sql = "select Nombre from Categoria ";
            sql = sql + " where CodCategoria =" + CodCategoria.ToString();
            DataTable trdo = cDb.GetDatatable(sql);
            if (trdo.Rows.Count >0)
            {
                if (trdo.Rows[0]["Nombre"].ToString() != "")
                    Nombre = trdo.Rows[0]["Nombre"].ToString();
            }
            return Nombre;
        }

        private void cmb_CodCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_CodCategoria.SelectedIndex > 0)
                ArmarNumeroSoxio();
        }

        private void btnIGregarColor_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text =="")
            {
                MessageBox.Show("Debe seleccionar un socio ");
                return;
            }
            Principal.CodSocio = Convert.ToInt32(txtCodigo.Text);
            FrmReporteSociocs frm = new FrmReporteSociocs();
            frm.Show();
        }
    }
}
