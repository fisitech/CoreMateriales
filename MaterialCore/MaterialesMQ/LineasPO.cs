using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MaterialCore.MaterialesMQ
{
    public partial class LineasPO : Form
    {
        public bool _Resultado = false;

        public Int64 _PO;
        public int _Cliente;
        public int  _Linea;
        public string _NumeroParte;
        public string _DescripcionParte;
        public string _UnidadMedida;
        public string _ProveedorID;
        public string _Moneda;
        public decimal _PqOrd;
        public decimal _PqRec;
        public string _NombreProveedor;


        #region HotKeys
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Home:
                    txtPO.Focus();
                    txtPO.SelectAll();
                    return true;

                case Keys.Escape:
                    btnCancelar_Click(0, null);
                    return true;

            }
            return false;
        }
        #endregion

        public LineasPO(Int64 po)
        {
            InitializeComponent();
            _PO = po;
            txtPO.Text = _PO.ToString();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarLineas();
        }

        private void txtPO_TextChanged(object sender, EventArgs e)
        {
            if (txtPO.Text.Length == 6)
            {
                btnBuscar_Click(0, null);
            }
        }


        void CargarLineas()
        {
            this.materialesOCMeQTableAdapter.FillByPO2(this.maquinaria.MaterialesOCMeQ, Convert.ToInt64(txtPO.Text));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _Resultado = false;
            this.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (dgvLineas.RowCount > 0)
            {
                _Resultado = true;
                
                
                
_PO = Convert.ToInt64(dgvLineas.CurrentRow.Cells["gPO"].Value);
_Cliente = Convert.ToInt32(dgvLineas.CurrentRow.Cells["gClienteId"].Value);
_Linea= Convert.ToInt32(dgvLineas.CurrentRow.Cells["gLinea"].Value);
_NumeroParte = dgvLineas.CurrentRow.Cells["gNoParte"].Value.ToString(); //no nesesaria
_DescripcionParte = dgvLineas.CurrentRow.Cells["gDescripcionParte"].Value.ToString();
_UnidadMedida = dgvLineas.CurrentRow.Cells["gUnidadMedida"].Value.ToString();
_ProveedorID = dgvLineas.CurrentRow.Cells["gProveedorID"].Value.ToString();
_Moneda = dgvLineas.CurrentRow.Cells["gMoneda"].Value.ToString();
_PqOrd = Convert.ToDecimal( dgvLineas.CurrentRow.Cells["gPqOrd"].Value);
_PqRec = Convert.ToDecimal(dgvLineas.CurrentRow.Cells["gPqRec"].Value);
_NombreProveedor = dgvLineas.CurrentRow.Cells["gNombreProveedor"].Value.ToString();


                //inserta o algo deve aser aqui paa mandar a la otra ventana e insertar la linea seleccionada y posisionarce en ella

                this.Visible = false;
            }
        }

        private void dgvLineas_DoubleClick(object sender, EventArgs e)
        {
                btnAceptar_Click(0, null);
        }

        private void dgvLineas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                e.Handled = false;
                btnAceptar_Click(0, null);
            }
        }

        private void btnDev_Click(object sender, EventArgs e)
        {
            //Validaciones

            if(txtProveedorID.Text == "")
            {
                MessageBox.Show("Falta ingresar el Id del Proveedor", "Error");
                return;
            }

            if (txtProveedorDes.Text == "")
            {
                MessageBox.Show("Falta ingresar la descripción del Proveedor", "Error");
                return;
            }

            try
            {
                _PO = Convert.ToInt32(txtDevPO.Text);
                _Cliente = 70;
                _Linea = Convert.ToInt32(txtDevLinea.Text);
                _NumeroParte = "";
                _DescripcionParte = "";
                _UnidadMedida = "EA";
                _ProveedorID = txtProveedorID.Text;
                _Moneda = "";
                _PqOrd = 0;
                _PqRec = 0;
                _NombreProveedor = txtProveedorDes.Text;

                _Resultado = true;
                this.Visible = false;
            }
            catch
            {
                MessageBox.Show("Hay algun error en la PO ó Linea.","Error");
                return;
            }







        }

    }
}