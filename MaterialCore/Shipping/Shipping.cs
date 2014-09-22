using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MaterialCore.Shipping
{
    public partial class Shipping : Form
    {
        public Shipping()
        {
            InitializeComponent();
        }

        private void Shipping_Load(object sender, EventArgs e)
        {
            this.materialesShippingTableAdapter.Fill(this.maquinaria.MaterialesShipping);

            validaMaskedTxt();
            txtNoCamion.Focus();
            //tabStopper();
          }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //int  id;
            //id = Convert.ToInt32(dgvShipping.CurrentRow.Cells["gid"].Value);
            //MessageBox.Show(id.ToString());           
        }

       
        void Insertar( )
        {
            string PackSum = txtPackSum.Text.Trim();
            DateTime fechaRBI = Convert.ToDateTime(txtFechaRBI.Text);
            string Transportista = txtTransportista.Text.Trim();
            string Consignee = txtConsignee.Text.Trim();
            string Domestic = txtDomestic.Text.Trim();
            DateTime fechaLlegada = Convert.ToDateTime(txtFechaLlegada.Text);
            DateTime fechaDespacho = Convert.ToDateTime(txtFechaDespacho.Text);
            string NoGuia = txtNoGuia.Text.Trim();
            string Comentario = txtComentarios.Text.Trim();
            string NoCamion = txtNoCamion.Text.Trim();

            this.materialesShippingTableAdapter.InsertQuery(PackSum, fechaRBI, Transportista, Consignee,
            Domestic, fechaLlegada, fechaDespacho, NoGuia, Comentario, NoCamion);
            txtComentarios.Text = string.Empty;
            txtConsignee.Text = string.Empty;
            txtDomestic.Text = string.Empty;           
            txtNoGuia.Text = string.Empty;
            txtPackSum.Text = string.Empty;
            txtTransportista.Text = string.Empty;
            txtFechaDespacho.Text = string.Empty;
            txtFechaLlegada.Text = String.Empty;
            txtFechaRBI.Text = string.Empty;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Limpiar(this);
            txtComentarios.Text = string.Empty;
            txtConsignee.Text = string.Empty;
            txtDomestic.Text = string.Empty;
            txtNoCamion.Text = string.Empty;
            txtNoGuia.Text = string.Empty;
            txtPackSum.Text = string.Empty;
            txtTransportista.Text = string.Empty;
            txtFechaDespacho.Text = string.Empty;
            txtFechaLlegada.Text = String.Empty;
            txtFechaRBI.Text = string.Empty;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Insertar();
            this.materialesShippingTableAdapter.Fill(this.maquinaria.MaterialesShipping);
           
            Cursor = Cursors.Default;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            actualizar();
            Cursor = Cursors.Default;
        }

        private void filtroFechas()
        {
          //  this.materialesShippingTableAdapter.Fill(this.maquinaria.MaterialesShipping);
            this.materialesShippingTableAdapter.FillByFecha(this.maquinaria.MaterialesShipping, mtxtFechaInicio.Text.Trim(), mtxtFechaFin.Text.Trim(), null);
        }

        private void mtxtFechaFin_Enter(object sender, EventArgs e)
        {
           
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (mtxtFechaInicio.Text.Trim(' ', '/') != "" && mtxtFechaFin.Text.Trim(' ', '/') != "")
            {
                
                this.materialesShippingTableAdapter.FillByFecha(this.maquinaria.MaterialesShipping, mtxtFechaInicio.Text.Trim(), mtxtFechaFin.Text.Trim(), null);
                
            }
            else
            {
                MessageBox.Show("Debe de introducir las fechas a filtrar.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mtxtFechaFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                this.materialesShippingTableAdapter.FillByFecha(this.maquinaria.MaterialesShipping, mtxtFechaInicio.Text.Trim(), mtxtFechaFin.Text.Trim(), null);
            }
        }

      

        private void actualizar()
        {
            foreach (DataGridViewRow row in this.dgvShipping.Rows)
            {
                int id = int.Parse(row.Cells["gid"].Value.ToString());
                string PackSum = row.Cells["gPackSum"].Value.ToString();
                DateTime fechaRBI = Convert.ToDateTime(row.Cells["gfechaRBI"].Value.ToString());
                string Transportista = row.Cells["gTransportista"].Value.ToString();
                string Consignee = row.Cells["gConsignee"].Value.ToString();
                string Domestic = row.Cells["gDomestic"].Value.ToString();
                DateTime fechaLlegada = Convert.ToDateTime(row.Cells["gfechaLlegada"].Value.ToString());
                DateTime fechaDespacho = Convert.ToDateTime(row.Cells["gfechaDespacho"].Value.ToString());
                string NoGuia = row.Cells["gnoGuia"].Value.ToString();
                string Comentarios = row.Cells["gComentarios"].Value.ToString();
                string NoCamion = row.Cells["NoCamion"].Value.ToString();

                this.materialesShippingTableAdapter.UpdateQuery(
                    PackSum,
                    fechaRBI,
                    Transportista,
                    Consignee,
                    Domestic,
                    fechaLlegada,
                    fechaDespacho,
                    NoGuia,
                    Comentarios,
                    NoCamion,
                    id
                    );
            }
        }

        private void dgvShipping_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyUp += new KeyEventHandler(Control_KeyUp);

        }

        void Control_KeyUp(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyValue == (int)Keys.Enter)
            {
                actualizar();
                //base.OnKeyPress(e);
            }
        }

        private void dgvShipping_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvShipping.BeginEdit(false);
        }


        private void validaMaskedTxt()
        {
            mtxtFechaInicio.Mask = "00/00/0000";
            mtxtFechaInicio.ValidatingType = typeof(System.DateTime);
            mtxtFechaInicio.TypeValidationCompleted += new TypeValidationEventHandler(mtxtFechaInicio_TypeValidationCompleted);
            mtxtFechaInicio.KeyDown += new KeyEventHandler(mtxtFechaInicio_KeyDown);
            //toolTip1.IsBalloon = true;
            mtxtFechaFin.Mask = "00/00/0000";
            mtxtFechaFin.ValidatingType = typeof(System.DateTime);
            mtxtFechaFin.TypeValidationCompleted += new TypeValidationEventHandler(mtxtFechaFin_TypeValidationCompleted);
            mtxtFechaFin.KeyDown += new KeyEventHandler(mtxtFechaFin_KeyDown);
        }

        private void mtxtFechaInicio_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                //toolTip1.ToolTipTitle = "Error!: Fecha Invalida";
                //toolTip1.Show("Favor de ingresar la fecha en formato: dd/mm/yyyy.", mtxtFechaInicio, 0, -20, 5000);
                MessageBox.Show("Debe Introducir la fecha en un formato: dd/mm/yyyy .", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtFechaInicio.Text = string.Empty;
            }
        }

        private void mtxtFechaInicio_KeyDown(object sender, KeyEventArgs e)
        {
            //toolTip1.Hide(mtxtFechaInicio);
        }

        private void mtxtFechaFin_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                //toolTip1.ToolTipTitle = "Error!: Fecha Invalida";
                //toolTip1.Show("Favor de ingresar la fecha en formato: dd/mm/yyyy.", mtxtFechaInicio, 0, -20, 5000);
                MessageBox.Show("Debe Introducir la fecha en un formato: dd/mm/yyyy .", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtFechaFin.Text = string.Empty;
            }
        }

        private void mtxtFechaFin_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {
            if (mtxtFechaInicio.Text.Trim(' ', '/') != "" && mtxtFechaFin.Text.Trim(' ', '/') != "")
            {
               
                this.materialesShippingTableAdapter.FillByFecha(this.maquinaria.MaterialesShipping, mtxtFechaInicio.Text.Trim(), mtxtFechaFin.Text.Trim(), null);
                this.dgvShipping.ReadOnly = true;
                this.txtNoCamion.Focus();
                this.dgvShipping.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("Debe de introducir las fechas a filtrar.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Insertar();
            this.materialesShippingTableAdapter.Fill(this.maquinaria.MaterialesShipping);

            Cursor = Cursors.Default;
        }

        private void BtnActualizar_Click_1(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            actualizar();
            Cursor = Cursors.Default;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            txtComentarios.Text = string.Empty;
            txtConsignee.Text = string.Empty;
            txtDomestic.Text = string.Empty;
            txtNoCamion.Text = string.Empty;
            txtNoGuia.Text = string.Empty;
            txtPackSum.Text = string.Empty;
            txtTransportista.Text = string.Empty;
            txtFechaDespacho.Text = string.Empty;
            txtFechaLlegada.Text = String.Empty;
            txtFechaRBI.Text = string.Empty;
        }

        private void btnNoFiltro_Click(object sender, EventArgs e)
        {
            
            this.materialesShippingTableAdapter.Fill(this.maquinaria.MaterialesShipping);
            this.dgvShipping.ReadOnly = true;
            this.txtNoCamion.Focus();
            this.dgvShipping.ReadOnly = false;
        }

      

        


        //private void DisableTabstops(Control.ControlCollection controls)
        //{
        //    foreach (Control control in controls)
        //    {

        //        if (control.GetType() == typeof(Label))
        //        {
        //            control.TabStop = false;
        //        }


        //        if (control.Controls.Count > 0)
        //        {
        //            DisableTabstops(control.Controls);
        //        }

        //    }
        //}

        //private void tabStopper()
        //{
        //    label1.TabStop = true;
        //    label2.TabStop = true;
        //    //label3.TabStop = true;
        //    label4.TabStop = true;
        //    label5.TabStop = true;
        //    label6.TabStop = true;
        //    label7.TabStop = true;
        //    label8.TabStop = true;
        //   // label9.TabStop = true;
        //    label10.TabStop = true;
        //}

        

     



      


    }
}