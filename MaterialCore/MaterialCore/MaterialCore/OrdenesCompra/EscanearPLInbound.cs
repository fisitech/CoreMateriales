using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace MaterialCore.OrdenesCompra
{
    public partial class EscanearPLInbound : Form
    {
       string _PL;
        string _Nid_sku = "";

        Clases.Bitacora _Bitacora = new MaterialCore.Clases.Bitacora();
        Clases.Conexion _con;

        public EscanearPLInbound()
        {
            InitializeComponent();
        }

        public EscanearPLInbound(string nid_sku)
        {
            _Nid_sku = nid_sku.ToUpper();
            InitializeComponent();

        }



        private void EscanearPL_Load(object sender, EventArgs e)
        {
            _con = new MaterialCore.Clases.Conexion();

      //      this.sku_escanearTableAdapter.Fill(this.embarques.sku_escanear, 70, chkEscaneados.Checked );

            if (_Nid_sku != "") //modo automatico
            {
                txtBuscarsku.Text = _Nid_sku;
                button2_Click_1(0, e);
                dgvEscanear.Enabled = false;
                txtBuscarsku.Enabled = false;
                btnBuscar.Enabled = false;
                groupBox1.Visible = false;
                if (Digitalizar())
                {
                    btnAsosiar_Click(0, e);
                }
              //  btnAsosiar.Focus();

            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dgvEscanear.RowCount <= 0)
            {
                MessageBox.Show("Debe de agregar al menos una guia");
                return;
            }





            lblMensaje.Visible = false;


            DialogResult escanearD;

            //escanearD = MessageBox.Show("Para continuar asegurese que las hojas esten colocadas en el escaner, " +
            //                            "y corresponden a los n�mero de guia marcados " +
            //                            ", Para proceder a digitalizar presione aceptar.", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            escanearD = DialogResult.OK;

            if (escanearD == DialogResult.OK)
            {
                dgvEscanear.Enabled = false;
                btnAsosiar.Enabled = false;

                string directorio = ConfigurationManager.AppSettings["dirOUT"].ToString();
                Twain.Principal tw = new Twain.Principal();

                string dir = directorio;
                string PLnombre;

                try
                {

              string opc = tw.SelectScaner();
               if (opc == "Success")
               {
                           PLnombre = PLautomatico();
                           _PL = PLnombre;
                           if (PLnombre == "0")
                           {
                               MessageBox.Show("Error al intentar crear el PL automatico");
                               return;
                           }
                          tw.ScanPDF(PLnombre, directorio);
                   //por si se buelve a cambiar
                    //      btnAsosiar.Enabled = true;
                          btnAsosiar_Click(0, e);

                }

                }
                catch (Exception)
                {

                }

            }
        }

        void ActualizarSKUEscaneados(int id )
        {
            _con.InsertSQL = "update sku_escanear set escaneado = 1 where id = " + id;
            _con.insert();
        }

                void InsertaSKUEscaneados(string guia )
        {
            _con.InsertSQL = string.Format("insert into sku_escanear (nid_sku,escaneado,nid_cliente) " +
                                          "values('{0}',1,70)", guia);
            _con.insert();
        }






        string PLautomatico()
        {
            string PL;
            _con.StoredProcedureName = "PLAutomatico";
            _con.SpParametros.Add("@Cliente", SqlDbType.Int, 10).Value = 70;
            _con.SpParametros.Add("@PL", SqlDbType.VarChar, 75).Direction = ParameterDirection.Output;
            PL = _con.execSP("@PL").ToString();

          //  _con.FinConexion();

            return PL;
        }




        public void AsociaPL(string sku, string nid_opl_in)
        {
            _con.InsertSQL = " DECLARE @nid_sku VARCHAR(75) SET @nid_sku =  '" + sku + "' " +
                            "DECLARE @nid_opl_in VARCHAR(20) SET @nid_opl_in =   '" + nid_opl_in + "' " +
                           "DECLARE @nid_opl INT " +
                /*el bulto insertado y asociado lo asocia a un PL, si no existe lo crea*/
                                 "SET @nid_opl = (SELECT  nid_opl FROM origin_packing_list WHERE nid_opl_in =    @nid_opl_in) " +

                                "IF(@nid_opl IS NULL) " +
                                "BEGIN " +
                                   "INSERT INTO dbo.origin_packing_list (nid_opl_in) " +
                                  "VALUES (@nid_opl_in) " +
                                   "SET @nid_opl = (SELECT SCOPE_IDENTITY()) " +
                                  "END " +

                                 "INSERT INTO dbo.packing_list_breakdown (nid_opl,nid_sku) " +
                                "VALUES (@nid_opl,@nid_sku) ";

            _con.insert();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dgvEscanear.Enabled == false)
                return;

            bool error = false;
            if (dgvEscanear.RowCount > 0)
            {
                if (txtBuscarsku.Text != "")
                {
                    for (int i = 0; i < dgvEscanear.RowCount; i++)
                    {
                        if (dgvEscanear.Rows[i].Cells["gNid_sku"].Value.ToString().ToUpper() == txtBuscarsku.Text.ToUpper())
                        {
                            dgvEscanear.Rows[i].Cells["gEscanear"].Value = true;
                            if (_Nid_sku == "")
                            {
                                txtBuscarsku.Clear();
                                txtBuscarsku.Focus();
                                MessageBox.Show("Guia encontrada y marcada para digitalizar", "Aviso");
                            }
                            return;
                        }
                        else
                        {
                            error = true;
                        }
                    }
                    if (error)
                    {
                        MessageBox.Show("No se encontr� la guia", "Error");
                    }
                }
            }
        }

            bool Digitalizar()
            {
                bool resultado = true;
               dgvEscanear.Enabled = false;
                btnAsosiar.Enabled = false;

                string directorio = ConfigurationManager.AppSettings["dirOUT"].ToString();
                Twain.Principal tw = new Twain.Principal();

                string dir = directorio;
                string PLnombre;

                try
                {
              string opc = tw.SelectScaner();
              if (opc == "Success")
              {
                  PLnombre = PLautomatico();
                  _PL = PLnombre;
                  if (PLnombre == "0")
                  {
                      MessageBox.Show("Error al intentar crear el PL automatico");
                      return false;
                  }
                  tw.ScanPDF(PLnombre, directorio);
                  btnAsosiar.Enabled = true;
              }
              else
              {
                  if (_Nid_sku != "")
                  {

                      this.Close();
                      return false;
                  }
              }

                }
                catch (Exception)
                {

                }
                return resultado;
            }



        private void txtBuscarsku_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnBuscar_Click(0, e);
            }
        }

        private void txtBuscarsku_Enter(object sender, EventArgs e)
        {
            txtBuscarsku.SelectAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //
            DialogResult escanearD;

            escanearD = MessageBox.Show("Para continuar asegurese que las hojas estan colocadas en el escaner, " +
                                        "y corresponden a los n�mero de guia marcados " +
                                        ", Para proceder a escanear presione aceptar.", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (escanearD == DialogResult.OK)
            {
                string directorio = @"C:\prueba\pdf\"; //ConfigurationManager.AppSettings["dirOUT"].ToString();
                Twain.Principal tw = new Twain.Principal();
                string dir = directorio;
  
                string opc = tw.SelectScaner();

                if (opc == "Success")
                   tw.ScanPDF("prueba", directorio) ;
                    btnAsosiar.Enabled = true;
                }

            }

        private void btnAsosiar_Click(object sender, EventArgs e)
        {
            string Guias = "";

            if (_PL == "")
            {
                return;
            }

            for (int i = 0; i < dgvEscanear.RowCount; i++)
            {

                //if (Convert.ToBoolean(dgvEscanear.Rows[i].Cells[3].Value))
                //{
                    AsociaPL(LimpiaGuia( dgvEscanear.Rows[i].Cells[0].Value.ToString()), _PL);
                //    ActualizarSKUEscaneados(
                //Convert.ToInt32(dgvEscanear.Rows[i].Cells[0].Value));

                InsertaSKUEscaneados(LimpiaGuia( dgvEscanear.Rows[i].Cells[0].Value.ToString()));


                    //BITACORA
                    _Bitacora.MixDigitalizo(dgvEscanear.Rows[i].Cells[0].Value.ToString(), _PL);

                    Guias += dgvEscanear.Rows[i].Cells[0].Value.ToString() + ", ";
                //}

                
            }
            Guias = Guias.Substring(0, Guias.Length - 2);

       //     this.sku_escanearTableAdapter.Fill(this.embarques.sku_escanear, 70,chkEscaneados.Checked);

            lblMensaje.Text = "Guias: " + Guias+" asociadas exitosamente al PL: [" + _PL + "]";
            lblMensaje.Visible = true;
    

   //         MessageBox.Show("Los n�meros de guia se asociaron con �xito al  PL: ["+ _PL+"] . Ya pueden ser rastreados desde el portal web.");


            if (_Nid_sku != "")
            {
                this.Close();
            }



            dgvEscanear.Enabled = true;
            btnAsosiar.Enabled = false;


            dgvEscanear.Rows.Clear();
          //  int i = 0;
          //while(dgvEscanear.RowCount > 0)
          //  {
          //    dgvEscanear.sele
              

          //  }

        }

        private void btnBuscaArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "Archivo PDF (*.pdf)|*.pdf";
            dialogo.FilterIndex = 1;
            dialogo.Multiselect = false;
            dialogo.RestoreDirectory = true;

            DialogResult resultado = dialogo.ShowDialog();

            if (resultado == DialogResult.OK)
             txtArchivo.Text = dialogo.FileName.ToString();
        }

        private void btnCargaArchivo_Click(object sender, EventArgs e)
        {
            string directorioDestino = ConfigurationManager.AppSettings["dirOUT"].ToString();
            string directorioOrigen = txtArchivo.Text;
            string PLnombre;

            if (dgvEscanear.RowCount <= 0)
            {
                MessageBox.Show("Debe de agregar al menos una guia");
                return;
            }



            if (!File.Exists(directorioOrigen))//si no existe el archivo 
            {
                MessageBox.Show("El archivo no existe");
                return;
            }
            else
            {
                PLnombre = PLautomatico();
                _PL = PLnombre;
                if (PLnombre == "0")
                {
                    MessageBox.Show("Error al intentar crear el PL automatico");
                    return;
                }

                File.Copy(directorioOrigen, directorioDestino + _PL + ".pdf");
                
                    btnAsosiar_Click(0, e);
                    txtArchivo.Clear();

            }
        }

  

        private void chkEscaneados_CheckedChanged(object sender, EventArgs e)
        {
           // this.sku_escanearTableAdapter.Fill(this.embarques.sku_escanear, 70, chkEscaneados.Checked);
        }

        private void txtBuscarsku_Click(object sender, EventArgs e)
        {
            txtBuscarsku.SelectAll();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtBuscarsku.Text == "")
            {
                txtBuscarsku.Focus();
                return;
            }



            string guia = txtBuscarsku.Text;

            for (int i = 0; i < dgvEscanear.RowCount; i++)
            {
                if (dgvEscanear.Rows[i].Cells[0].Value.ToString().ToUpper() == guia.ToUpper())
                {
                    MessageBox.Show("Ya se agreg� esta Guia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    //    MessageBox.Show("error ya existe la etiqueta");
                    return;
                }


            }

            dgvEscanear.Rows.Add(LimpiaGuia(guia));
            txtBuscarsku.Clear();
            txtBuscarsku.Focus();


        }

        private void dgvEscanear_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEscanear.RowCount > 0)
                dgvEscanear.Rows.RemoveAt(dgvEscanear.CurrentRow.Index);
        }

        string LimpiaGuia(string guia)
        {
            string resultado = "";

            resultado = guia.Replace(" ", "");
       //     resultado = guia.Replace("(","-");
          //  resultado = guia.Replace(")", "");


            return resultado;
        }

        private void txtBuscarsku_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                button2_Click_1(0,e);
            }

        }

    }
}