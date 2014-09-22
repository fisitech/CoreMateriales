using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MaterialCore
{
    public partial class Login : Form
    {
        private Clases.Usuario _usuario;
    

        public Login()
        {
            InitializeComponent();
            mostrarVersion();
        }

        public Clases.Usuario usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            this.Aceptar();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (txtUsuario.Text == "")
                    txtUsuario.Focus();
                else
                    this.Aceptar();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (txtPassword.Text == "")
                    txtPassword.Focus();
                else
                    this.Aceptar();
            }
        }

        private void Aceptar()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _usuario = new Clases.Usuario(txtUsuario.Text, txtPassword.Text);
                if (_usuario.autentificado)
                {
                    Clases.Logueado.nid_usuario = _usuario.nid_user;
                    Clases.Logueado.Login = _usuario.clogin;
                    Clases.Bitacora _Bitacora = new MaterialCore.Clases.Bitacora();
                    _Bitacora.MixLogueo();

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    lblAccesoDenegado.Visible = true;

                _usuario.FinConexion();

                Cursor.Current = Cursors.Default;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        void mostrarVersion()
        {

            string Version = this.GetType().Assembly.GetName().Version.ToString();
            lblVersion.Text = Version;
        }
      
    }
}