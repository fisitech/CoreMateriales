using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MaterialCore.MaterialesMQ
{
    public partial class NumClones : Form
    {
   public   bool  _Resultado = false;
      public  int _Copias = 0;


        public NumClones()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
         _Resultado = false;
         this.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
        
            try
            {
                _Copias =   Convert.ToInt32(txtNumero.Text);
                _Resultado = true;
                this.Visible = false;
            }
            catch
            {
                MessageBox.Show("Verifice que numero de copias","Error");
                txtNumero.Focus();
            }


        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnAceptar_Click(0, null);
            }
        }
    }
}