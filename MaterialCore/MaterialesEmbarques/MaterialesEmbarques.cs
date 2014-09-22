using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MaterialCore.MaterialesEmbarques
{
    public partial class MaterialesEmbarques : Form
    {
        int matEmbarqID;
        public MaterialesEmbarques()
        {
            
            InitializeComponent();
        }

        private void MaterialesEmbarques_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'embarques.MaterialesEmbarquesTipoEmbarque' table. You can move, or remove it, as needed.
            this.materialesEmbarquesTipoEmbarqueTableAdapter.FillTipoEmbarque(this.embarques.MaterialesEmbarquesTipoEmbarque);
            // TODO: This line of code loads data into the 'core_v2DataSet3.MaterialesEmbarques' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'embarques.MaterialesEmbarquesTransportista' table. You can move, or remove it, as needed.
            this.materialesEmbarquesTransportistaTableAdapter.FillTransportista(this.embarques.MaterialesEmbarquesTransportista);
            // TODO: This line of code loads data into the 'core_v2DataSet1.MaterialesEmbarques' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'core_v2DataSet.MaterialesEmbarques' table. You can move, or remove it, as needed.
            this.materialesEmbarquesTableAdapter.Fill(this.embarques.MaterialesEmbarques);
            comboTransportista.Text = String.Empty;

            comboTipoEmbarque.Text = String.Empty;
        }

        

        void Insertar()
        {
            try
            {
                String noTrailer = textNoTrailer.Text.Trim();
                comboTransportista.Focus();
                String transportista = comboTransportista.SelectedText;
                int noPaletas = Convert.ToInt32(textNoPaletas.Text.Trim());
                String noFactura = textNoFactura.Text.Trim();
                String packingList = textPackingList.Text.Trim();
                decimal costo = Convert.ToDecimal(textCosto.Text.Trim());
                comboTipoEmbarque.Focus();
                String tipoEmbarque = comboTipoEmbarque.SelectedText;
                DateTime fechaCaptura = Convert.ToDateTime(dateCaptura.Text);
                String comentarios = textComentarios.Text.Trim();
      
                this.materialesEmbarquesTableAdapter.Insert(fechaCaptura, noTrailer, transportista, noPaletas, noFactura, packingList, costo, comentarios, tipoEmbarque);
                this.materialesEmbarquesTableAdapter.Fill(this.embarques.MaterialesEmbarques);

                Limpiar();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        void Limpiar()
        {
            textNoTrailer.Clear();
            comboTransportista.Text = String.Empty;
            comboTipoEmbarque.Text = String.Empty;
            textNoPaletas.Clear();
            textNoFactura.Clear();
            textPackingList.Clear();
            textCosto.Clear();
          
            dateCaptura.Value=DateTime.Today;
            textComentarios.Clear();
        }
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            buttonGuardar.Enabled = false;
            buttonInsertar.Enabled = true;
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                
                Insertar();
                MaterialesEmbarques_Load(null, null);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        void Guardar()
        {
            comboTransportista.Focus();
            String transportista = comboTransportista.SelectedText.Trim(); 

            String noTrailer = textNoTrailer.Text.Trim();
            int noPaletas = Convert.ToInt32(textNoPaletas.Text.Trim());
            String noFactura = textNoFactura.Text.Trim();
            String packingList = textPackingList.Text.Trim();
            decimal costo = Convert.ToDecimal(textCosto.Text.Trim());

            comboTipoEmbarque.Focus();
            String tipoEmbarque = comboTipoEmbarque.SelectedText.Trim();

            DateTime fechaCaptura = Convert.ToDateTime(dateCaptura.Text);
            String comentarios = textComentarios.Text.Trim();
            materialesEmbarquesTableAdapter.UpdateQuery(fechaCaptura, noTrailer, transportista, noPaletas, noFactura, packingList, costo, comentarios, tipoEmbarque, matEmbarqID);
            Limpiar();
            buttonGuardar.Enabled = false;
            buttonInsertar.Enabled = true;
            this.materialesEmbarquesTableAdapter.ClearBeforeFill = true;
            this.materialesEmbarquesTableAdapter.Fill(this.embarques.MaterialesEmbarques);
            MaterialesEmbarques_Load(null, null);
            this.dgvMaterialesEmbarques.CurrentRow.Selected = false;
            this.dgvMaterialesEmbarques.Rows[matEmbarqID].Selected = true;
        }


        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace,ex.Message);
            }
        }

        private void dgvMaterialesEmbarques_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                buttonInsertar.Enabled = false;
                matEmbarqID = int.Parse(dgvMaterialesEmbarques.CurrentRow.Cells["id"].Value.ToString());
                textNoTrailer.Text = dgvMaterialesEmbarques.CurrentRow.Cells["noTrailerDataGridViewTextBoxColumn"].Value.ToString();
                comboTransportista.Text = String.Empty;
                comboTransportista.SelectedText = dgvMaterialesEmbarques.CurrentRow.Cells["transportistaDataGridViewTextBoxColumn"].Value.ToString();
                textNoPaletas.Text = dgvMaterialesEmbarques.CurrentRow.Cells["noPaletasDataGridViewTextBoxColumn"].Value.ToString();
                textNoFactura.Text = dgvMaterialesEmbarques.CurrentRow.Cells["noFacturaDataGridViewTextBoxColumn"].Value.ToString();
                textPackingList.Text = dgvMaterialesEmbarques.CurrentRow.Cells["packingListDataGridViewTextBoxColumn"].Value.ToString();
                textCosto.Text = dgvMaterialesEmbarques.CurrentRow.Cells["costoDataGridViewTextBoxColumn"].Value.ToString();
                comboTipoEmbarque.Text = String.Empty;
                comboTipoEmbarque.Text = dgvMaterialesEmbarques.CurrentRow.Cells["tipoEmbarqueDataGridViewTextBoxColumn"].Value.ToString();
                dateCaptura.Value = DateTime.Parse(dgvMaterialesEmbarques.CurrentRow.Cells["fechaCapturaDataGridViewTextBoxColumn"].Value.ToString());
                textComentarios.Text = dgvMaterialesEmbarques.CurrentRow.Cells["comentariosDataGridViewTextBoxColumn"].Value.ToString();
                buttonGuardar.Enabled = true;           
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }        
}

     

     


      

       

       

       

       

        

       

        
    }
}