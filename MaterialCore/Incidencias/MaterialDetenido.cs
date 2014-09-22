using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace MaterialCore.Incidencias
{
    public partial class MaterialDetenido : Form
    {
        int gId;
        public MaterialDetenido()
        {
            InitializeComponent();
        }



        private void MaterialDetenido_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'incidencias.MaterialesDetenido' table. You can move, or remove it, as needed.
            this.materialesDetenidoTableAdapter.Fill(this.incidencias.MaterialesDetenido);
            // TODO: This line of code loads data into the 'maquinaria.MaterialesDetenido' table. You can move, or remove it, as needed.
           // this.materialesDetenidoTableAdapter.Fill(this.maquinaria.MaterialesDetenido);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {

        }


       

        public static void Limpiar(Form ofrm)
        {
            // Checar todos los textbox del formulario
            foreach (Control oControls in ofrm.Controls)
            {
                if (oControls is TextBox)
                {
                    oControls.Text = ""; // Eliminar el texto del TextBox
                }
            }
        }

        Int32? AInteger(string numero)
        {
            int? resultado;

            if (numero == "")
                resultado = null;
            else
                resultado = Convert.ToInt32(numero);

            return resultado;
        }

        private void txtPO_KeyPress(object sender, KeyPressEventArgs e)
        {
        //    if ((e.KeyChar > 47 && e.KeyChar < 58) || (Keys)e.KeyChar == Keys.Enter || (Keys)e.KeyChar == Keys.Back)
        //    {
        //    }
        //    else
        //        e.Handled = true;
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtLinea_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((e.KeyChar > 47 && e.KeyChar < 58) || (Keys)e.KeyChar == Keys.Enter || (Keys)e.KeyChar == Keys.Back)
            //{
            //}
            //else
            //    e.Handled = true;
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar(this);
            dtpFecha.Value = DateTime.Now;
            dtpFechaResuelto.Value = DateTime.Now;
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
            txtResolvio.Text = string.Empty;
            chkResuelto.Checked = false;
            btnGuardar.Enabled = true;
            btnActualizar.Enabled = false;
        }

        private void cheResuelto_CheckedChanged(object sender, EventArgs e)
        {
            pnlResuelto.Visible = chkResuelto.Checked;
            if (chkResuelto.Checked == false)
            {
                dtpFechaResuelto.Value = DateTime.Now;
                txtResolvio.Text = string.Empty;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //if (txtPO.Text == "" || txtLinea.Text == "" || txtNoPackingList.Text == "" || txtNoGuia.Text == "" || txtCantidad.Text == "" || txtNoParte.Text == "")
            //{
            //    MessageBox.Show("Omitio insertar algunos datos. Favor de revisar.", "Advertencia",
            //    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else
            //{

            Cursor = Cursors.WaitCursor;
            if (chkResuelto.Checked == true && txtResolvio.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el nombre de la persona que resolvio.", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                guardar();
                Limpiar(this);
                txtResolvio.Text = string.Empty;
                this.materialesDetenidoTableAdapter.Fill(this.incidencias.MaterialesDetenido);
                txtPO.Focus();
                
            }
            Cursor = Cursors.Default;
         //}
        }

        private void guardar()
        {            
            DateTime? fechaResolvio;
            string Resolvio;
            if (chkResuelto.Checked == true)
            {
                fechaResolvio = dtpFechaResuelto.Value;
                Resolvio = txtResolvio.Text.Trim();
            }
            else
            {
                fechaResolvio = null;
                Resolvio = null;
            }

            if (txtPO.Text == "" || txtPO.Text == string.Empty)
            {
                txtPO.Text = "0";
            }
            if (txtLinea.Text == "" || txtLinea.Text == string.Empty)
            {
                txtLinea.Text = "0";
            }
            if(txtCantidad.Text == "" || txtCantidad.Text == string.Empty)
            {
                txtCantidad.Text = "0";
            }
            int PO = int.Parse(txtPO.Text);
            int Linea = int.Parse(txtLinea.Text);
            string NoPacking = txtNoPackingList.Text;
            string NoGuia = txtNoGuia.Text;
            Decimal Cantidad = decimal.Parse(txtCantidad.Text);
            string UM = txtUM.Text;
            string NoParte = txtNoParte.Text;
            string NombreProveedor = txtNombreProveedor.Text;
            string Razon = txtRazon.Text;
            string Comentario = txtComentario.Text;


            this.materialesDetenidoTableAdapter.InsertQuery(
                          ////int.Parse(txtPO.Text.Trim()),
                          //txtPO.Text,
                          ////int.Parse(txtLinea.Text.Trim()),
                          //txtLinea.Text,
                          //txtNoPackingList.Text,
                          //Convert.ToDateTime(dtpFecha.Value),
                          //txtNoGuia.Text,
                          ////decimal.Parse(txtCantidad.Text.Trim()),
                          //txtCantidad.Text,
                          //txtUM.Text,
                          //txtNoParte.Text,
                          //txtNombreProveedor.Text,
                          //txtRazon.Text,
                          //txtComentario.Text,
                          //chkResuelto.Checked,
                          //fechaResolvio,
                          //Resolvio             
                          PO, Linea, NoPacking, Convert.ToDateTime(dtpFecha.Value), NoGuia,
                          Cantidad, UM, NoParte, NombreProveedor, Razon, Comentario, chkResuelto.Checked,
                          fechaResolvio, Resolvio
                          );
        }

        public static bool isDigit(KeyPressEventArgs e, string texto)
        {
            bool IsDec = false;
            int nroDec = 0;

            try
            {
                if (e.KeyChar == 8) { return false; }

                for (int i = 0; i < texto.Length; i++)
                {
                    if (texto[i] == '.') { IsDec = true; }
                    if (IsDec && nroDec++ >= 2) { return true; }
                }

                if (e.KeyChar >= 48 && e.KeyChar <= 57)
                {
                    return false;
                }
                else if (e.KeyChar == 46)
                {
                    if (IsDec) { return true; }
                    else { return false; }
                }
                else { return true; }
            }
            catch (Exception Ex)
            {
                throw;
            }

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = isDigit(e, txtCantidad.Text);
        }

        private void txtResolvio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtResolvio.Text != string.Empty || txtResolvio.Text != "")
            {                
                if ((Keys)e.KeyChar == Keys.Enter)
                {
                    Cursor = Cursors.WaitCursor;
                    guardar();
                    this.materialesDetenidoTableAdapter.Fill(this.incidencias.MaterialesDetenido);
                    Cursor = Cursors.Default;
                }
            }
            else
            {
                if ((Keys)e.KeyChar == Keys.Enter)
                {
                    if (txtResolvio.Text == string.Empty || txtResolvio.Text == "")
                    {
                        MessageBox.Show("Debe ingresar el nombre de la persona que resolvio.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void actualizar()
        {
            DateTime? fechaResolvio;
            string Resolvio;
            if (chkResuelto.Checked == true)
            {
                fechaResolvio = dtpFechaResuelto.Value;
                Resolvio = txtResolvio.Text.Trim();
            }
            else
            {
                fechaResolvio = null;
                Resolvio = null;
            }

            if (txtPO.Text == "" || txtPO.Text == string.Empty)
            {
                txtPO.Text = "0";
            }
            if (txtLinea.Text == "" || txtLinea.Text == string.Empty)
            {
                txtLinea.Text = "0";
            }
            if (txtCantidad.Text == "" || txtCantidad.Text == string.Empty)
            {
                txtCantidad.Text = "0";
            }
            //foreach (DataGridViewRow row in this.dgvIncidencias.Rows)
            //{
            //    int id = int.Parse(row.Cells["idDataGridViewTextBoxColumn"].Value.ToString());
            //    int PO = int.Parse(row.Cells["pODataGridViewTextBoxColumn"].Value.ToString());
            //    int Linea = int.Parse(row.Cells["lineaDataGridViewTextBoxColumn"].Value.ToString());
            //    string NoPacking = row.Cells["noPackingDataGridViewTextBoxColumn"].Value.ToString();
            //    DateTime Fecha = Convert.ToDateTime(row.Cells["fechaDataGridViewTextBoxColumn"].Value.ToString());
            //    string NoGuia = row.Cells["noGuiaDataGridViewTextBoxColumn"].Value.ToString();
            //    Decimal Cantidad = decimal.Parse(row.Cells["cantidadDataGridViewTextBoxColumn"].Value.ToString());
            //    string UnidadMedida = row.Cells["unidadMedidaDataGridViewTextBoxColumn"].Value.ToString();
            //    string NoParte = row.Cells["noParteDataGridViewTextBoxColumn"].Value.ToString();
            //    string NombreProveedor = row.Cells["nombreProveedorDataGridViewTextBoxColumn"].Value.ToString();
            //    string Razon = row.Cells["razonDataGridViewTextBoxColumn"].Value.ToString();
            //    string Comentario = row.Cells["comentarioDataGridViewTextBoxColumn"].Value.ToString();
            //    bool bResuelto = bool.Parse(row.Cells["bResueltoDataGridViewCheckBoxColumn"].Value.ToString());
            //    DateTime FechaResolvio = Convert.ToDateTime(row.Cells["fechaResolvioDataGridViewTextBoxColumn"].Value.ToString());
            //    string Resolvio = row.Cells["resolvioDataGridViewTextBoxColumn"].Value.ToString();

                //if (string.IsNullOrEmpty(row.Cells["fechaResolvioDataGridViewTextBoxColumn"].Value.ToString()))
                //{
                //    DateTime? FechaResolvio;
                //    FechaResolvio = null;
                //    string Resolvio = null;
                //}
                //else
                //{
                //    DateTime FechaResolvio = Convert.ToDateTime(row.Cells["fechaResolvioDataGridViewTextBoxColumn"].Value.ToString());
                //    string Resolvio = row.Cells["resolvioDataGridViewTextBoxColumn"].Value.ToString();
                //}



            //PO,
            //Linea,
            //NoPacking,
            //Fecha,
            //NoGuia,
            //Cantidad,
            //UnidadMedida,
            //NoParte,
            //NombreProveedor,
            //Razon,
            //Comentario,
            //bResuelto,
            //FechaResolvio,
            //Resolvio,
            //id 

                this.materialesDetenidoTableAdapter.UpdateQuery(                                   
                      int.Parse(txtPO.Text.Trim()),
                      int.Parse(txtLinea.Text.Trim()),
                      txtNoPackingList.Text.Trim(),
                      Convert.ToDateTime(dtpFecha.Value),
                      txtNoGuia.Text.Trim(),
                      decimal.Parse(txtCantidad.Text.Trim()),
                      txtUM.Text.Trim(),
                      txtNoParte.Text.Trim(),
                      txtNombreProveedor.Text.Trim(),
                      txtRazon.Text.Trim(),
                      txtComentario.Text,
                      chkResuelto.Checked,
                      fechaResolvio,
                      Resolvio,
                      gId                      
                    );                
            //}
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (chkResuelto.Checked == true && txtResolvio.Text == string.Empty )
            {

                MessageBox.Show("Debe ingresar el nombre de la persona que resolvio.", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                actualizar();
                Limpiar(this);
                dtpFecha.Value = DateTime.Now;
                dtpFechaResuelto.Value = DateTime.Now;
                chkResuelto.Checked = false;
                btnActualizar.Enabled = false;
                btnGuardar.Enabled = true;
                this.materialesDetenidoTableAdapter.Fill(this.incidencias.MaterialesDetenido);
            }
        }

        private void dgvIncidencias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gId = int.Parse(dgvIncidencias.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value.ToString());
            txtPO.Text = dgvIncidencias.CurrentRow.Cells["pODataGridViewTextBoxColumn"].Value.ToString();
            txtLinea.Text = dgvIncidencias.CurrentRow.Cells["lineaDataGridViewTextBoxColumn"].Value.ToString();
            txtNoPackingList.Text = dgvIncidencias.CurrentRow.Cells["noPackingDataGridViewTextBoxColumn"].Value.ToString();
            dtpFecha.Value = Convert.ToDateTime(dgvIncidencias.CurrentRow.Cells["fechaDataGridViewTextBoxColumn"].Value.ToString());
            txtNoGuia.Text = dgvIncidencias.CurrentRow.Cells["noGuiaDataGridViewTextBoxColumn"].Value.ToString();
            txtCantidad.Text = dgvIncidencias.CurrentRow.Cells["cantidadDataGridViewTextBoxColumn"].Value.ToString();
            txtUM.Text = dgvIncidencias.CurrentRow.Cells["unidadMedidaDataGridViewTextBoxColumn"].Value.ToString();
            txtNoParte.Text = dgvIncidencias.CurrentRow.Cells["noParteDataGridViewTextBoxColumn"].Value.ToString();
            txtNombreProveedor.Text = dgvIncidencias.CurrentRow.Cells["nombreProveedorDataGridViewTextBoxColumn"].Value.ToString();
            txtRazon.Text = dgvIncidencias.CurrentRow.Cells["razonDataGridViewTextBoxColumn"].Value.ToString();
            txtComentario.Text  = dgvIncidencias.CurrentRow.Cells["comentarioDataGridViewTextBoxColumn"].Value.ToString();
            chkResuelto.Checked = bool.Parse(dgvIncidencias.CurrentRow.Cells["bResueltoDataGridViewCheckBoxColumn"].Value.ToString());
            string validaFechaResuelto;
            validaFechaResuelto = dgvIncidencias.CurrentRow.Cells["fechaResolvioDataGridViewTextBoxColumn"].Value.ToString();
            if (string.IsNullOrEmpty(validaFechaResuelto))
            {
                dtpFechaResuelto.Value = DateTime.Now;
            }
            else
            {
                dtpFechaResuelto.Value = Convert.ToDateTime(dgvIncidencias.CurrentRow.Cells["fechaResolvioDataGridViewTextBoxColumn"].Value.ToString());
            }
            txtResolvio.Text = dgvIncidencias.CurrentRow.Cells["resolvioDataGridViewTextBoxColumn"].Value.ToString();
            txtPO.Focus();
            btnActualizar.Enabled = true;
            btnGuardar.Enabled = false;
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            //this.materialesDetenidoTableAdapter.Fill(this.incidencias.MaterialesDetenido);
            this.materialesDetenidoTableAdapter.FillBy(this.incidencias.MaterialesDetenido,
                dtpFechaInicio.Value,
                dtpFechaFin.Value);
        }

     

    }
}