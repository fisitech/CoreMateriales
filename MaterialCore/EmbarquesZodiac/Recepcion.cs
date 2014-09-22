using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace MaterialCore.EmbarquesZodiac
{
    public partial class Recepcion : Form
    {
        Clases.Conexion _con;
        DataTable dt;
        SqlDataAdapter da;
        String directorio;
        public Recepcion()
        {
            InitializeComponent();
        }
        
        private void Recepcion_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            // TODO: This line of code loads data into the 'core_v2DataSet.EmbarquesZodiac' table. You can move, or remove it, as needed.
            this.embarquesZodiacTableAdapter.FillEmbarques(this.core_v2DataSet.EmbarquesZodiac);
            CargarDatos();
            
            _con = new MaterialCore.Clases.Conexion();
             directorio = ConfigurationManager.AppSettings["dirOUT"].ToString();
             this.Cursor = Cursors.WaitCursor;
             
             Tamaño();
             Colores();
             this.Cursor = Cursors.Default;
        }
        private void Tamaño()
        {
            foreach (DataGridViewColumn columna in dgvEmbarques.Columns)
            {
                columna.SortMode = DataGridViewColumnSortMode.Programmatic;
                this.dgvEmbarques.Sort(this.dgvEmbarques.Columns["receivedDataGridViewCheckBoxColumn"], ListSortDirection.Ascending);
                this.dgvEmbarques.Sort(this.dgvEmbarques.Columns["done"], ListSortDirection.Ascending);
                columna.MinimumWidth = 25;

            }
            dgvEmbarques.Columns["carrierTruckNumberDataGridViewTextBoxColumn"].Width = 70;
            dgvEmbarques.Columns["departureDateDataGridViewTextBoxColumn"].Width = 70;
            dgvEmbarques.Columns["coNumberDataGridViewTextBoxColumn"].Width = 70;
            dgvEmbarques.Columns["lineNumberDataGridViewTextBoxColumn"].Width = 35;
            dgvEmbarques.Columns["poNumberDataGridViewTextBoxColumn"].Width = 90;
            dgvEmbarques.Columns["trackingNumberDataGridViewTextBoxColumn"].Width = 90;
            dgvEmbarques.Columns["carrierDataGridViewTextBoxColumn"].Width = 100;
            dgvEmbarques.Columns["billingChargesDataGridViewTextBoxColumn"].Width = 70;
            dgvEmbarques.Columns["commentsChihDataGridViewTextBoxColumn"].Width = 200;
            dgvEmbarques.Columns["arrivalDateDataGridViewTextBoxColumn"].Width = 75;
            dgvEmbarques.Columns["unloadedDateDataGridViewTextBoxColumn"].Width = 75;
            dgvEmbarques.Columns["pickupDateRequestedDataGridViewTextBoxColumn"].Width = 75;
            dgvEmbarques.Columns["pickupDateDataGridViewTextBoxColumn"].Width = 75;
            dgvEmbarques.Columns["pathTrackingNumberDataGridViewTextBoxColumn"].Width = 70;
            dgvEmbarques.Columns["pickerDataGridViewTextBoxColumn"].Width = 90;
            dgvEmbarques.Columns["commentsRBIDataGridViewTextBoxColumn"].Width = 200;
        }
        private void Colores()
        {
            foreach (DataGridViewRow fila in dgvEmbarques.Rows)
            {
                if (bool.Parse(fila.Cells["urgentDataGridViewCheckBoxColumn"].Value.ToString()) == true)
                {
                    fila.DefaultCellStyle.BackColor = Color.Salmon;
                }
                if (bool.Parse(fila.Cells["receivedDataGridViewCheckBoxColumn"].Value.ToString()) == true)
                {
                    fila.DefaultCellStyle.BackColor = Color.Khaki;
                    
                }
                if (bool.Parse(fila.Cells["done"].Value.ToString()) == true)
                {
                    fila.DefaultCellStyle.BackColor = Color.LightGreen;
                }

            }
        }
        private void addComments_Click(object sender, EventArgs e)
        {
            int[] arrayIDs = new int[dgvEmbarques.SelectedRows.Count];
            string[] arrayCommnts = new string[dgvEmbarques.SelectedRows.Count];
            for (int x = 0; x <arrayIDs.Length ; x++)
            {
                arrayIDs[x] = int.Parse(dgvEmbarques.SelectedRows[x].Cells["idDataGridViewTextBoxColumn"].Value.ToString());
                arrayCommnts[x]=dgvEmbarques.SelectedRows[x].Cells["commentsRBIDataGridViewTextBoxColumn"].Value.ToString();
            }
            EmbarquesZodiac.AddCommts addCmmts = new EmbarquesZodiac.AddCommts(arrayIDs,arrayCommnts);
            DialogResult dr = new DialogResult();
            dr=addCmmts.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                RecargarDatos();
            }
           }

        

        private void dgvEmbarques_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarDatos();
        }

    

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            btnCancel.Enabled = true;
            
            for (int x = 0; x < dgvEmbarques.SelectedRows.Count; x++)
            {
                string picker = txtPicker.Text.Trim();
                string tracknum=txtTracking.Text.Trim();
                int id = int.Parse(dgvEmbarques.SelectedRows[x].Cells["idDataGridViewTextBoxColumn"].Value.ToString());
            //ARRIVAL
             if (dateArrival.Checked == true)
            {
                this.embarquesZodiacTableAdapter.UpdateArrivalDate(dateArrival.Value,id);
            }
            //PICKUP
            if (datePickup.Checked == true)
            {
                this.embarquesZodiacTableAdapter.UpdatePickupDate(datePickup.Value, id); ;
            }
            
            //PICKUP WAS REQUESTED
            if (datePickupWas.Checked == true)
            {
                this.embarquesZodiacTableAdapter.UpdatePickupDateRequested(datePickupWas.Value,id);
            }
            //UNLOADED
            if (dateUnloaded.Checked == true)
            {
                this.embarquesZodiacTableAdapter.UpdateUnloadedDate(dateUnloaded.Value,id);
            }
          this.embarquesZodiacTableAdapter.UpdatePicker(picker, id);
                //PREGUNTA SI EXISTE EL TRACKING NUMBER
          
             this.embarquesZodiacTableAdapter.UpdateTrackingNumber(tracknum, id);
       
          this.embarquesZodiacTableAdapter.UpdateReceived(chkReceived.Checked, id);
          this.embarquesZodiacTableAdapter.UpdateDone(chkDone.Checked, id);      
            }
            if (txtTracking.Text.Trim() != "")
            {
            da = _con.getDataAdapter("SELECT nid_sku FROM dbo.sku_escanear WHERE nid_cliente = 52 AND nid_sku='" + txtTracking.Text.Trim() + "'");
            dt = new DataTable();
            da.Fill(dt);
             if (dt.Rows.Count==0)
                {
                this.sku_escanearTableAdapter.InsertskuEscanear(txtTracking.Text.Trim(), DateTime.Now, false, 52);
                }
            }
            if (chkScan.Checked == true)
            {
                MaterialCore.EmbarquesZodiac.EscanearTN scanTN = new EscanearTN(txtTracking.Text);
                 scanTN.ShowDialog(this);
                
            }
            
            
            foreach (DataGridViewRow fila in dgvEmbarques.SelectedRows)
            {
                DataTable datatable=this.embarquesZodiacTableAdapter.GetDataByRegistro(int.Parse(fila.Cells["idDataGridViewTextBoxColumn"].Value.ToString()));
                object value = datatable.Rows[0]["registroRBI"];
                if(value==DBNull.Value)
                {
                 this.embarquesZodiacTableAdapter.UpdateQueryRegistro(DateTime.Now,MaterialCore.Clases.Logueado.Login.ToString(),  int.Parse(fila.Cells["idDataGridViewTextBoxColumn"].Value.ToString()));
                }
                
            }

            RecargarDatos();
            this.Cursor = Cursors.Default;
           }

 

        private void comboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboFilter.SelectedIndex)
            { 
                case 0:
                    groupFilters.Enabled = false;
                    bindingSourceEmbarquesZodiac.RemoveFilter();
                    break;
                case 1:
                    groupFilters.Enabled = true;
                    labelFilter.Text = "CO Number";
                    chkSinTrack.Enabled = false;
                    txtFilter.Enabled = true;
                    txtFilter.Text = "";
                    dateStart.Enabled = false;
                    dateEnd.Enabled = false;
                    chkSinTrack.Checked = false;
                    break;
                case 2:
                    groupFilters.Enabled = true;
                    labelFilter.Text = "PO Number";
                    chkSinTrack.Enabled = false;
                    txtFilter.Enabled = true;
                    txtFilter.Text = "";
                    dateStart.Enabled = false;
                    dateEnd.Enabled = false;
                    chkSinTrack.Checked = false;
                    break;
                case 3:
                    groupFilters.Enabled = true;
                    labelFilter.Text = "Tracking Number";
                    chkSinTrack.Enabled = true;
                    txtFilter.Enabled = true ;
                    txtFilter.Text = "";
                    dateStart.Enabled = false;
                    dateEnd.Enabled = false;
                    chkSinTrack.Checked = false;
                    break;
                case 4:
                    groupFilters.Enabled = true;
                    labelFilter.Text = "Filter";
                    chkSinTrack.Enabled = false;
                    txtFilter.Enabled = false;
                    txtFilter.Text = "";
                    dateStart.Enabled = true;
                    dateEnd.Enabled = true;
                    chkSinTrack.Checked = false;
                    break;
                case 5:
                    groupFilters.Enabled = true;
                    labelFilter.Text = "Truck Number";
                    chkSinTrack.Enabled = false;
                    txtFilter.Enabled = true;
                    txtFilter.Text = "";
                    dateStart.Enabled = false;
                    dateEnd.Enabled = false;
                    chkSinTrack.Checked = false;
                    break;
            }
        }

        private void chkSinTrack_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSinTrack.Checked == true)
            {
                txtFilter.Enabled = false;
                bindingSourceEmbarquesZodiac.Filter = "trackingNumber IS NULL OR trackingNumber = '' ";
            }
            else
            {
                txtFilter.Enabled = true;
                bindingSourceEmbarquesZodiac.RemoveFilter();
            }
            Colores();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            switch (comboFilter.SelectedIndex)
            {
                case 0:
                    bindingSourceEmbarquesZodiac.RemoveFilter();
                    break;
                case 1:
                    bindingSourceEmbarquesZodiac.Filter = "coNumber = '"+ txtFilter.Text.Trim() +"'";
                    break;
                case 2:
                    bindingSourceEmbarquesZodiac.Filter = "poNumber = '" + txtFilter.Text.Trim() + "'";
                    break;
                case 3:
                    bindingSourceEmbarquesZodiac.Filter = "trackingNumber = '" + txtFilter.Text.Trim() + "'";
                    break;
                case 4:
                    bindingSourceEmbarquesZodiac.Filter = "departureDate >= #" + dateStart.Value.ToString("MM/dd/yyyy") + "# and departureDate <= #" + dateEnd.Value.ToString("MM/dd/yyyy") + "#";
                    break;
                case 5:
                    bindingSourceEmbarquesZodiac.Filter = "carrierTruckNumber = '" + txtFilter.Text.Trim() + "'";
                    break;
            }
            Colores();
            this.Cursor = Cursors.Default;

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bindingSourceEmbarquesZodiac.RemoveFilter();
            Colores();
        }

        private void dgvEmbarques_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                CargarDatos();
                this.Cursor = Cursors.Default;
            }
            catch
            {

            }
        }

        private void CargarDatos()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                
                //for (int x = 0; x < dgvEmbarques.Rows.Count; x++)
                //{
                //    if (bool.Parse(dgvEmbarques.Rows[x].Cells["urgentDataGridViewCheckBoxColumn"].Value.ToString()) == true)
                //    {
                //        dgvEmbarques.Rows[x].DefaultCellStyle.BackColor = Color.Red;
                //        if (bool.Parse(dgvEmbarques.Rows[x].Cells["receivedDataGridViewCheckBoxColumn"].Value.ToString()) == true)
                //        {
                //            dgvEmbarques.Rows[x].DefaultCellStyle.BackColor = Color.LightBlue;
                //            if (bool.Parse(dgvEmbarques.Rows[x].Cells["done"].Value.ToString()) == true)
                //            {
                //                dgvEmbarques.Rows[x].DefaultCellStyle.BackColor = Color.Green;
                //            }
                //        }
                //    }
                //    else
                //    {
                //        dgvEmbarques.Rows[x].DefaultCellStyle.BackColor = Color.Transparent;
                //    }
                //}
                txtCommentsChih.Text = dgvEmbarques.CurrentRow.Cells["commentsChihDataGridViewTextBoxColumn"].Value.ToString();
                labelTrackingNumber.Text = dgvEmbarques.CurrentRow.Cells["trackingNumberDataGridViewTextBoxColumn"].Value.ToString();
                //AGREGA LOS LINKS
                linkPathTrackingNumber.Text = dgvEmbarques.CurrentRow.Cells["pathTrackingNumberDataGridViewTextBoxColumn"].Value.ToString();
                linkPathTrackingNumber.Links.RemoveAt(0);
                linkPathTrackingNumber.Links.Add(0, linkPathTrackingNumber.Text.ToString().Length, directorio+linkPathTrackingNumber.Text.Trim().ToString() + ".pdf");
                
                labelCONum.Text = dgvEmbarques.CurrentRow.Cells["coNumberDataGridViewTextBoxColumn"].Value.ToString();
                labelPONum.Text = dgvEmbarques.CurrentRow.Cells["poNumberDataGridViewTextBoxColumn"].Value.ToString();
                labelLineNum.Text = dgvEmbarques.CurrentRow.Cells["lineNumberDataGridViewTextBoxColumn"].Value.ToString();
                chkUrgent.Checked = bool.Parse(dgvEmbarques.CurrentRow.Cells["urgentDataGridViewCheckBoxColumn"].Value.ToString());
                labelCarrier.Text = dgvEmbarques.CurrentRow.Cells["carrierDataGridViewTextBoxColumn"].Value.ToString();
                labelBilling.Text = dgvEmbarques.CurrentRow.Cells["billingChargesDataGridViewTextBoxColumn"].Value.ToString();
                labelDepartureDate.Text = String.Format("{0:MM/dd/yyyy}", dgvEmbarques.CurrentRow.Cells["departureDateDataGridViewTextBoxColumn"].Value);
                labelChihCarrierTruckNum.Text = dgvEmbarques.CurrentRow.Cells["carrierTruckNumberDataGridViewTextBoxColumn"].Value.ToString();
                labelPickup.Text = String.Format("{0:MM/dd/yyyy hh:mm tt}", dgvEmbarques.CurrentRow.Cells["pickupDateDataGridViewTextBoxColumn"].Value);
                labelUnload.Text = String.Format("{0:MM/dd/yyyy hh:mm tt}", dgvEmbarques.CurrentRow.Cells["unloadedDateDataGridViewTextBoxColumn"].Value);
                labelPicker.Text = String.Format("{0:MM/dd/yyyy hh:mm tt}", dgvEmbarques.CurrentRow.Cells["pickerDataGridViewTextBoxColumn"].Value);
                labelPickupWas.Text = String.Format("{0:MM/dd/yyyy hh:mm tt}", dgvEmbarques.CurrentRow.Cells["pickupDateRequestedDataGridViewTextBoxColumn"].Value);
                labelArrival.Text = String.Format("{0:MM/dd/yyyy hh:mm tt}", dgvEmbarques.CurrentRow.Cells["arrivalDateDataGridViewTextBoxColumn"].Value);
                txtCommentsRBI.Text = dgvEmbarques.CurrentRow.Cells["commentsRBIDataGridViewTextBoxColumn"].Value.ToString();
                txtPicker.Text = dgvEmbarques.CurrentRow.Cells["pickerDataGridViewTextBoxColumn"].Value.ToString();
                txtTracking.Text = dgvEmbarques.CurrentRow.Cells["trackingNumberDataGridViewTextBoxColumn"].Value.ToString();
                if (dgvEmbarques.CurrentRow.Cells["receivedDataGridViewCheckBoxColumn"].Value != DBNull.Value)
                {
                    chkReceived.Checked = bool.Parse(dgvEmbarques.CurrentRow.Cells["receivedDataGridViewCheckBoxColumn"].Value.ToString());
                }
                else {chkReceived.Checked=false; }
                if (dgvEmbarques.CurrentRow.Cells["done"].Value != DBNull.Value)
                {
                    chkDone.Checked = bool.Parse(dgvEmbarques.CurrentRow.Cells["done"].Value.ToString());
                }
                else { chkDone.Checked = false; }
                if (dgvEmbarques.CurrentRow.Cells["pickupDateDataGridViewTextBoxColumn"].Value != DBNull.Value & dgvEmbarques.CurrentRow.Cells["arrivalDateDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    TimeSpan daysInTransit = Convert.ToDateTime(dgvEmbarques.CurrentRow.Cells["pickupDateDataGridViewTextBoxColumn"].Value) - Convert.ToDateTime(dgvEmbarques.CurrentRow.Cells["arrivalDateDataGridViewTextBoxColumn"].Value);
                    labelDays.Text = daysInTransit.Days.ToString();
                }
                else
                {
                    labelDays.Text = "0";
                }
                if (dgvEmbarques.CurrentRow.Cells["arrivalDateDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    dateArrival.Value = Convert.ToDateTime(dgvEmbarques.CurrentRow.Cells["arrivalDateDataGridViewTextBoxColumn"].Value);
                }
                else { dateArrival.Value = DateTime.Now; }
                if (dgvEmbarques.CurrentRow.Cells["pickupDateDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    DateTime date = Convert.ToDateTime(dgvEmbarques.CurrentRow.Cells["pickupDateDataGridViewTextBoxColumn"].Value);
                    datePickup.Value =new DateTime(date.Year,date.Month,date.Day,12,0,0);
                }
                else { datePickup.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 0, 0); }
                if (dgvEmbarques.CurrentRow.Cells["pickupDateRequestedDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    datePickupWas.Value = Convert.ToDateTime(dgvEmbarques.CurrentRow.Cells["pickupDateRequestedDataGridViewTextBoxColumn"].Value);
                }
                else { datePickupWas.Value = DateTime.Now; }
                if (dgvEmbarques.CurrentRow.Cells["unloadedDateDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    dateUnloaded.Value = Convert.ToDateTime(dgvEmbarques.CurrentRow.Cells["unloadedDateDataGridViewTextBoxColumn"].Value);
                }
                else { dateUnloaded.Value = DateTime.Now; }
                dateArrival.Checked = false;
                datePickup.Checked = false;
                datePickupWas.Checked = false;
                dateUnloaded.Checked = false;
                chkScan.Checked = false;
            }
            catch (Exception error)
            {
                //MessageBox.Show(error.StackTrace.ToString(), error.Message.ToString());
            }
            this.Cursor = Cursors.Default;
        }

        private void RecargarDatos()
        {
            this.Cursor = Cursors.WaitCursor;
            int index = dgvEmbarques.CurrentRow.Index;
            //this.embarquesZodiacTableAdapter.FillEmbarques(this.core_v2DataSet.EmbarquesZodiac);
            Recepcion_Load(null, null);
            dgvEmbarques.CurrentCell.Selected = false;
            if (index < dgvEmbarques.Rows.Count-1)
            {
                dgvEmbarques.Rows[index+1].Selected = true;
                dgvEmbarques.CurrentCell = dgvEmbarques.Rows[index + 1].Cells[0];

            }
            else
            {
                dgvEmbarques.Rows[index].Selected = true;
                dgvEmbarques.CurrentCell = dgvEmbarques.Rows[index].Cells[0];
            }
            CargarDatos();
            this.Cursor = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaterialCore.EmbarquesZodiac.EscanearTN scanTN = new EscanearTN();
            DialogResult dr = new DialogResult();
            
            dr=scanTN.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
           RecargarDatos();
              
            }
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            MaterialCore.EmbarquesZodiac.EscanearTNInbound scanTNInbound = new EscanearTNInbound();
            DialogResult dr = new DialogResult();
            dr=scanTNInbound.ShowDialog();
            if (dr == DialogResult.OK)
            {
                RecargarDatos();
            }
        }

        private void Recepcion_Shown(object sender, EventArgs e)
        {
            Colores();
        }

        private void dateArrival_Leave(object sender, EventArgs e)
        {
            dateUnloaded.Checked = true;
            dateUnloaded.Value = dateArrival.Value;
            datePickup.Checked = true;
            datePickup.Value = new DateTime(dateArrival.Value.Year,dateArrival.Value.Month,dateArrival.Value.Day,12,0,0);
            datePickupWas.Checked = true;
            datePickupWas.Value = dateArrival.Value;
        }

        private void linkPathTrackingNumber_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"\\rbiwarehouse\pdfv2\" + linkPathTrackingNumber.Text + ".pdf");
            }
            catch (Win32Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }

     

        

   


    }
}