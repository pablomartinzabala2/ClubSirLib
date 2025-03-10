﻿using System;
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
    public partial class FrmLogin : FormBase
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            cFunciones fun = new cFunciones();
          //  fun.EstiloBotones(btnIngreso);
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Ingresar Nombre de Usuario");
                return;
            }

            if (txtContraseña.Text == "")
            {
                MessageBox.Show("Ingresar una Contraseña");
                return;
            }

            Clases.cUsuario USUARIO = new Clases.cUsuario();
            DataTable trdo = USUARIO.GetUsuario(txtUsuario.Text, txtContraseña.Text);
            if (trdo.Rows.Count > 0)
            {
                Principal.CodUsuarioLogueado = Convert.ToInt32(trdo.Rows[0]["CodUsuario"].ToString());
                Principal.NombreUsuarioLogueado = txtUsuario.Text;
                txtUsuario.Text = "";
                txtContraseña.Text = "";
                Principal p = new Principal();
                p.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario incorrecto", "Información");
                return;
            }
        }
    }
}
