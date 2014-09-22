using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace MaterialCore.Embarques
{
   
    public partial class RehacerTarima : Form
    {

        Clases.Bitacora _Bitacora = new MaterialCore.Clases.Bitacora();
        int _idCliente; 

        public RehacerTarima()
        {   _idCliente = 70;
            InitializeComponent();
        }

        private void RehacerTarima_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'embarques.ConsecutivoEmbarque' table. You can move, or remove it, as needed.
            this.consecutivoEmbarqueTableAdapter.Fill(this.embarques.ConsecutivoEmbarque);
            // TODO: This line of code loads data into the 'embarques.MaterialesPaltetas' table. You can move, or remove it, as needed.
            this.materialesPaltetasTableAdapter.FillByNoEnviadas(this.embarques.MaterialesPaltetas);

           // string Carpeta = "Embarque - " + DateTime.Now.ToShortDateString().Replace("/", "");
            //System.IO.Directory.CreateDirectory(ConfigurationManager.AppSettings["dirPDF"].ToString() + Carpeta + "\\Proveedores\\");
            txtDirectorioArchivo.Text = ConfigurationManager.AppSettings["dirPDF"].ToString();
        }

        private void txtNombrePaleta_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = txtDirectorioArchivo.Text + "\\" + txtNombrePaleta.Text + ".txt";
        }

        void SelectTarima()
        {
            if (dgvTarimas.Rows.Count > 0)
            {
               
                /*
                materialesPaltetasBindingSource.Position = dgvTarimas.CurrentRow.Index;
                txtFechaRecibo.Text = embarques.MaterialesPaltetas[materialesPaltetasBindingSource.Position]["FechaRecibo"].ToString();
                txtNumeroPaleta.Text = embarques.MaterialesPaltetas[materialesPaltetasBindingSource.Position]["NumeroPaleta"].ToString();
                txtPlanta.Text = embarques.MaterialesPaltetas[materialesPaltetasBindingSource.Position]["Planta"].ToString();
                txtPesoBruto.Text = Convert.ToDecimal(embarques.MaterialesPaltetas[materialesPaltetasBindingSource.Position]["PesoBruto"]).ToString("N2");
           //     txtCantidadBultos.Text = //recalcular
                txtTipoEmbarque.Text = embarques.MaterialesPaltetas[materialesPaltetasBindingSource.Position]["TipoEmbarque"].ToString();
                txtContenidoBulto.Text = embarques.MaterialesPaltetas[materialesPaltetasBindingSource.Position]["ContenidoTipoBulto"].ToString();
                txtFechaEmbarque.Text = embarques.MaterialesPaltetas[materialesPaltetasBindingSource.Position]["FechaEmbarque"].ToString();
                txtConsecutivoEmbarque.Text = embarques.MaterialesPaltetas[materialesPaltetasBindingSource.Position]["ConsecutivoEmbarque"].ToString();
                //  txtDirectorioArchivo.Text = "";
                txtNombrePaleta.Text = embarques.MaterialesPaltetas[materialesPaltetasBindingSource.Position]["NombrePaleta"].ToString();
                txtNoEtiqueta.Text = embarques.MaterialesPaltetas[materialesPaltetasBindingSource.Position]["nid_sku"].ToString();
                txtTipoEmbarque.Text = embarques.MaterialesPaltetas[materialesPaltetasBindingSource.Position]["TipoEmbarque"].ToString();
                txtConsecutivo.Text = embarques.MaterialesPaltetas[materialesPaltetasBindingSource.Position]["Consecutivo"].ToString();
                */
                txtFechaRecibo.Text = dgvTarimas.CurrentRow.Cells["gFechaRecibo"].Value.ToString();
                txtNumeroPaleta.Text = dgvTarimas.CurrentRow.Cells["gNumeroTarima"].Value.ToString();
                txtPlanta.Text = dgvTarimas.CurrentRow.Cells["gPlanta"].Value.ToString();
                txtPesoBruto.Text = Convert.ToDecimal(dgvTarimas.CurrentRow.Cells["gPesoBruto"].Value).ToString("N2");
                txtTipoEmbarque.Text = dgvTarimas.CurrentRow.Cells["gTipoEmbarque"].Value.ToString();
                txtContenidoBulto.Text = dgvTarimas.CurrentRow.Cells["gContenidoTipoBulto"].Value.ToString();
                txtFechaEmbarque.Text = dgvTarimas.CurrentRow.Cells["gFechaRecibo"].Value.ToString();
                txtConsecutivoEmbarque.Text = dgvTarimas.CurrentRow.Cells["gConsecutivoEmbarque"].Value.ToString();
                txtNombrePaleta.Text = dgvTarimas.CurrentRow.Cells["gNombreTarima"].Value.ToString();
                txtNoEtiqueta.Text = dgvTarimas.CurrentRow.Cells["gnid_sku"].Value.ToString();
                txtConsecutivo.Text = dgvTarimas.CurrentRow.Cells["gConsecutivo"].Value.ToString();


                SqlDataReader datos;
                MaterialCore.Clases.Conexion conn = new MaterialCore.Clases.Conexion();

                datos = conn.getLector(string.Format("SELECT Planta, ISNULL(SUM(Bultos), 0) AS Bultos, GETDATE() AS Fecha " + 
                                                                            "FROM MaterialesEnviar " + 
                                                                            "WHERE (MaterialesPaletasId ={0}) " +
                                                                            "GROUP BY Planta", dgvTarimas.CurrentRow.Cells["gId"].Value.ToString()));


                if (datos.Read())
                {
                    txtFechaRecibo.Text = datos["Fecha"].ToString();
                    txtFechaReciboPC.Text = datos["Fecha"].ToString();
                    //txtPlanta.Text = datos["Planta"].ToString();
                    txtCantidadBultos.Text = Convert.ToDecimal(datos["Bultos"]).ToString("N0"); 
                    txtFechaEmbarque.Text = datos["Fecha"].ToString();
                }
                datos.Close();


                this.materialesPaletasGuiasTableAdapter.FillByIdPaleta(this.embarques.MaterialesPaletasGuias, Convert.ToInt32(dgvTarimas.CurrentRow.Cells["gId"].Value.ToString()));

            }
        }

        private void dgvTarimas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                SelectTarima();
        }

        private void dgvTarimas_SelectionChanged(object sender, EventArgs e)
        {
            SelectTarima();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvTarimas.RowCount == 0)
            {
                return;
            }

            if (txtConsecutivoEmbarque.Text == "")
            {
                MessageBox.Show("Debe agregar un número de embarque", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
              //MessageBox.Show("Debe agregar un número de embarque");
                return;
            }


            if (txtConsecutivo.Text == "")
            {
                MessageBox.Show("Debe agregar un número consicutivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                //MessageBox.Show("Debe agregar un número de embarque");
                txtConsecutivo.Focus();
                return;
            }

            try
            {
                Convert.ToInt32(txtConsecutivo.Text);
            }catch{
               MessageBox.Show("El consecutivo no es un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtConsecutivo.Focus();
                return;
            }

            if (txtNombrePaleta.Text != "")
            {
                //if (txtNoEtiqueta.Text != "" && txtNoEtiqueta.Text.Substring(0, 1) == "B")
                //{
                if (dgvEtiAzul.RowCount > 0)
                {
                   
                    if (EsDecimal(txtPesoBruto.Text))
                    {
                        BorrarPDFs();

                        this.AgregarPaleta();

                        this.materialesPaltetasTableAdapter.FillByNoEnviadas(this.embarques.MaterialesPaltetas);
                        this.consecutivoEmbarqueTableAdapter.Fill(this.embarques.ConsecutivoEmbarque);

                     int partidas_tar =    RehacerTarimas();//crea archivos globales de tarimas
                        int partidas_prov = RehacerProveedores(); //crea archivos por embarque consecutivo


                        MessageBox.Show("Tarima Actualizada con éxito, " + partidas_tar + " partidas procesadas para los archivos de tarima y "+
                             partidas_prov + " partidas procesadas para los archivos por proveedor.");

                    /*    this.materialesPaltetasTableAdapter.FillByNoEnviadas(this.embarques.MaterialesPaltetas);
                        this.consecutivoEmbarqueTableAdapter.Fill(this.embarques.ConsecutivoEmbarque);*/

                    }
                    else
                      //  MessageBox.Show("El peso bruto no tiene el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        MessageBox.Show("El peso bruto no tiene el formato correcto");
                }
                else
                {
                    MessageBox.Show("Verifique que el número de la etiqueta sea correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                 //   MessageBox.Show("Verifique que el numero de la etiqueta sea correcto");
                }
            }
            else
                MessageBox.Show("Debe incluir el nombre del archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
               // MessageBox.Show("Debe incluir el nombre del archivo");
        }


        //falta rebisar

        private void GenearPorProveedores(string Carpeta,int IdPaleta, string Embarque, decimal PesoBruto)
        {
          
        //   int  IdPaleta = Convert.ToInt32(embarques.MaterialesPaltetas[materialesPaltetasBindingSource.Position]["Id"].ToString());

            DataSets.EmbarquesTableAdapters.ProveedoresTXTRehacerTableAdapter proTA = new MaterialCore.DataSets.EmbarquesTableAdapters.ProveedoresTXTRehacerTableAdapter();
            DataSets.Embarques.ProveedoresTXTRehacerDataTable proDT = new MaterialCore.DataSets.Embarques.ProveedoresTXTRehacerDataTable();

           DataSets.EmbarquesTableAdapters.GenerarTXTRehacerTableAdapter txtTA = new MaterialCore.DataSets.EmbarquesTableAdapters.GenerarTXTRehacerTableAdapter();
           DataSets.Embarques.GenerarTXTRehacerDataTable txtDT = new MaterialCore.DataSets.Embarques.GenerarTXTRehacerDataTable();


            proTA.Fill(proDT, IdPaleta);

            Clases.ExportarTXT exporta = new MaterialCore.Clases.ExportarTXT();

            foreach (DataRow r in proDT.Rows)
            {
                txtTA.FillByProveedor(

                    txtDT, txtNumeroPaleta.Text, IdPaleta, Convert.ToInt32(r["ProveedorId"]));

                if (!System.IO.Directory.Exists(Carpeta))
                {
                    System.IO.Directory.CreateDirectory(Carpeta);
                }

                exporta.exportarRehacer(Carpeta + "\\" + Embarque + " - " + Convert.ToString(r["ProveedorId"]) + ".txt", txtDT, true, PesoBruto);
     
            }
        }

        private void AgregarPaleta()
        {
            Clases.Conexion conn = new MaterialCore.Clases.Conexion();

            //Actualizar palet

            conn.InsertSQL = "UPDATE MaterialesPaltetas " +
                                            "SET FechaRecibo = @FechaRecibo " +
                                            ",[NumeroPaleta] = @NumeroPaleta " +
                                            ",[Planta] = @Planta " +
                                            ",[PesoBruto] =@PesoBruto " +
                                            ",[CantidadBultos] = @CantidadBultos " +
                                            ",[TipoEmbarque] =@TipoEmbarque " +
                                            ",[ContenidoTipoBulto] = @ContenidoTipoBulto " +
                                            ",[FechaEmbarque] = @FechaEmbarque " +
                                            ",[ConsecutivoEmbarque] = @ConsecutivoEmbarque " +
                                            ",[NombrePaleta] = @NombrePaleta " +
                                            ",[Consecutivo] = @Consecutivo " +

                                            

                /* ,[nid_sku] = <nid_sku, varchar(72),>*/
                                            "WHERE Id = @Id ";

            conn.InsertParametros.Add("@FechaRecibo", SqlDbType.DateTime).Value = txtFechaRecibo.Text;
            conn.InsertParametros.Add("@NumeroPaleta", SqlDbType.VarChar, 50).Value = txtNumeroPaleta.Text;
            conn.InsertParametros.Add("@Planta", SqlDbType.VarChar, 50).Value = txtPlanta.Text;
            conn.InsertParametros.Add("@PesoBruto", SqlDbType.Decimal, 20).Value = Convert.ToDecimal(txtPesoBruto.Text);
            conn.InsertParametros.Add("@CantidadBultos", SqlDbType.Decimal, 20).Value = Convert.ToDecimal(txtCantidadBultos.Text);
            conn.InsertParametros.Add("@TipoEmbarque", SqlDbType.VarChar, 50).Value = txtTipoEmbarque.Text;
            conn.InsertParametros.Add("@ContenidoTipoBulto", SqlDbType.VarChar, 50).Value = txtContenidoBulto.Text;
            conn.InsertParametros.Add("@FechaEmbarque", SqlDbType.DateTime).Value = txtFechaEmbarque.Text;
            conn.InsertParametros.Add("@ConsecutivoEmbarque", SqlDbType.Int, 4).Value = Convert.ToInt32(txtConsecutivoEmbarque.Text);
            conn.InsertParametros.Add("@NombrePaleta", SqlDbType.VarChar, 50).Value = txtNombrePaleta.Text;
            conn.InsertParametros.Add("@Consecutivo", SqlDbType.Int, 5).Value = Convert.ToInt32(txtConsecutivo.Text);
            conn.InsertParametros.Add("@Id", SqlDbType.Int, 5).Value = Convert.ToInt32(dgvTarimas.CurrentRow.Cells["gId"].Value.ToString());
         //   conn.InsertParametros.Add("@nid_sku", SqlDbType.VarChar, 50).Value = txtNoEtiqueta.Text;

            conn.insert();

            for (int i = 0; i < dgvEtiAzul.RowCount; i++)
            {
                conn.InsertSQL = "UPDATE dbo.deploys_detail_skus SET nid_deploy =@nid_deploy " +
                                            "WHERE nid_sku = @nid_sku";

                conn.InsertParametros.Add("@nid_deploy", SqlDbType.Int, 5).Value = txtConsecutivoEmbarque.Text;
                conn.InsertParametros.Add("@nid_sku", SqlDbType.VarChar, 75).Value = dgvEtiAzul.Rows[i].Cells[0].Value.ToString();
                //conn.InsertParametros.Add("@nid_sku", SqlDbType.VarChar, 75).Value = txtNoEtiqueta.Text;

                conn.insert();
            }
        }

        private bool EsDecimal(string valor)
        {
            bool resultado = false;
            decimal conversion;

            try
            {
                conversion = Convert.ToDecimal(valor);
                resultado = true;
            }
            catch
            {
                resultado = false;
            }

            return resultado;

        }


   
      

        private void txtNombrePaleta_TextChanged_1(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = txtDirectorioArchivo.Text + "\\" + txtNombrePaleta.Text + ".txt";
        }

        private void txtDirectorioArchivo_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = txtDirectorioArchivo.Text + "\\" + txtNombrePaleta.Text + ".txt";
        }

        private void btnDespacho_Click(object sender, EventArgs e)
        {
            Ventanas.EmbarquesAbiertos objDes = new MaterialCore.Ventanas.EmbarquesAbiertos(_idCliente);
            objDes.ShowDialog();

            if (objDes.Nid_deploy != 0)
            {
                txtConsecutivoEmbarque.Text = objDes.Nid_deploy.ToString();
            }
            objDes.Close();
        }



        private void DeleteRecursiveFolder(string pFolderPath)
        {
            foreach (string Folder in Directory.GetDirectories(pFolderPath))
            {
                DeleteRecursiveFolder(Folder);
            }

            foreach (string file in Directory.GetFiles(pFolderPath))
            {
                FileInfo fi = new FileInfo(file);
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            Directory.Delete(pFolderPath);
        }

        //

        #region control forma
        


        private void txtPlanta_KeyDown(object sender, KeyEventArgs e)
        {
            Down(e, txtNumeroPaleta);
            Intro(e, txtNumeroPaleta);
        }

        private void txtNumeroPaleta_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtPlanta);
            Down(e, txtPesoBruto);
            Intro(e, txtPesoBruto);
        }



        private void txtPesoBruto_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtNumeroPaleta);
            Down(e, txtCantidadBultos);
            Intro(e, txtCantidadBultos);
        }

        private void txtCantidadBultos_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtPesoBruto);
            Down(e, txtTipoEmbarque);
            Intro(e, txtTipoEmbarque);
        }

        private void txtTipoEmbarque_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtCantidadBultos);
            Down(e, txtContenidoBulto);
            Intro(e, txtContenidoBulto);
        }

        private void txtContenidoBulto_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtTipoEmbarque);

            if (e.KeyCode == Keys.Down)
            {
                e.Handled = false;
                btnDespacho.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = false;
                btnDespacho.Focus();
            }

        }

        private void btnDespacho_KeyDown1(object sender, KeyEventArgs e)
        {
            Up(e, txtContenidoBulto);
            Down(e, txtDirectorioArchivo);
            Intro(e, txtDirectorioArchivo);
        }

        private void txtDirectorioArchivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                e.Handled = false;
                btnDespacho.Focus();
            }
            Down(e, txtNombrePaleta);
            Intro(e, txtNombrePaleta);
        }

        private void txtNombrePaleta_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtDirectorioArchivo);
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = false;
                button1.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = false;
                button1.Focus();
            }
        }

        void Up(KeyEventArgs e, TextBox ir_a)
        {
            if (e.KeyCode == Keys.Up)
            {
                e.Handled = false;
                ir_a.Focus();
            }
        }
        void Down(KeyEventArgs e, TextBox ir_a)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = false;
                ir_a.Focus();
            }
        }
        void Intro(KeyEventArgs e, TextBox ir_a)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = false;
                ir_a.Focus();
            }
        }

        private void txtPlanta_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtNumeroPaleta_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtPesoBruto_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtCantidadBultos_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtTipoEmbarque_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtContenidoBulto_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtConsecutivoEmbarque_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtDirectorioArchivo_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtNombrePaleta_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtNoEtiqueta_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void dgvTarimas_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvTarimas.RowCount > 0)
            {

                if (e.KeyCode == Keys.Insert /*|| e.KeyCode == Keys.Enter*/)
                {
                    e.Handled = false;
                    txtPlanta.Focus();
                }
            }
        }

        #endregion

       int RehacerTarimas()
        {
            int Partidas = 0;
            if (dgvTarimas.Rows.Count > 0)
            {
                string Embarque;
                string NombreTarima;
                string Planta;
                string Archivotxt;
                string CarpetaProveedores;
                decimal PesoBruto;
                int Id;
                string consecutivo;
                string NumeroTarima;
              

                BorrarPDFs();

                //crea txts
                Clases.ExportarTXT exporta = new MaterialCore.Clases.ExportarTXT();
                for (int i = 0; i < dgvTarimas.Rows.Count; i++)
                {
                    //inicia las varialbes para generar el txt
                    Embarque = dgvTarimas.Rows[i].Cells["gConsecutivoEmbarque"].Value.ToString();
                    NombreTarima = dgvTarimas.Rows[i].Cells["gNombreTarima"].Value.ToString();
                    Planta = dgvTarimas.Rows[i].Cells["gPlanta"].Value.ToString().ToUpper();
                    Id = (int)dgvTarimas.Rows[i].Cells["gId"].Value;
                    PesoBruto = (decimal)dgvTarimas.Rows[i].Cells["gPesoBruto"].Value;
                    consecutivo = dgvTarimas.Rows[i].Cells["gConsecutivo"].Value.ToString();
                    NumeroTarima = dgvTarimas.Rows[i].Cells["gNumeroTarima"].Value.ToString();

                    DataSets.EmbarquesTableAdapters.GenerarTXTRehacerTableAdapter txtTA = new MaterialCore.DataSets.EmbarquesTableAdapters.GenerarTXTRehacerTableAdapter();
                    DataSets.Embarques.GenerarTXTRehacerDataTable txtDT = new MaterialCore.DataSets.Embarques.GenerarTXTRehacerDataTable();
                    txtTA.Fill(txtDT,
                         Id, 
                         Planta);


                    Partidas += txtDT.Rows.Count;

               //     CarpetaProveedores = ConfigurationManager.AppSettings["dirPDF"].ToString() + "\\Proveedores - " + Embarque + "_" + consecutivo;

                    if (!Planta.Contains("IB"))
                    {
                        System.IO.Directory.CreateDirectory(ConfigurationManager.AppSettings["dirPDF"].ToString());
                        Archivotxt = ConfigurationManager.AppSettings["dirPDF"].ToString() + "\\" + Embarque + "_" + consecutivo + " - " + NombreTarima + ".txt";
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(ConfigurationManager.AppSettings["dirPDFINBOUND"].ToString());
                        Archivotxt = ConfigurationManager.AppSettings["dirPDFINBOUND"].ToString() + "\\" + Embarque + "_" + consecutivo + " - " + NombreTarima + ".txt";
                    }

                    //if (!System.IO.Directory.Exists(ConfigurationManager.AppSettings["dirPDFINBOUND"].ToString()))
                    //{
                    //    System.IO.Directory.CreateDirectory(ConfigurationManager.AppSettings["dirPDFINBOUND"].ToString());
                    //}

                   
                     exporta.exportarRehacer(Archivotxt, txtDT, false, PesoBruto);

                    _Bitacora.MatCreoArchivo(Embarque + "-" +consecutivo + "REHISO");


                     //if (!Planta.Contains("IB"))
                     // this.GenearPorProveedores(CarpetaProveedores,Id,Embarque,PesoBruto/ Convert.ToDecimal(txtDT.Rows.Count));

               //     this.AgregarPaleta();

                }
            }
            return Partidas;
        }
        //
        void BorrarPDFs()
        {
            int cont = 0;
            string Embarque;
            string NombreTarima;
            string Planta;
            string Archivotxt;
            string CarpetaProveedores;
            decimal PesoBruto;
            string consecutivo;
            int Id;

            for (int i = 0; i < dgvTarimas.Rows.Count; i++)
            {
            
                Embarque = dgvTarimas.Rows[i].Cells["gConsecutivoEmbarque"].Value.ToString();
                NombreTarima = dgvTarimas.Rows[i].Cells["gNombreTarima"].Value.ToString();
                Planta = dgvTarimas.Rows[i].Cells["gPlanta"].Value.ToString().ToUpper();
                consecutivo = dgvTarimas.Rows[i].Cells["gConsecutivo"].Value.ToString();
                CarpetaProveedores = ConfigurationManager.AppSettings["dirPDF"].ToString() + "\\Proveedores - " + Embarque + "_" + consecutivo;
             
                if (!Planta.Contains("IB"))
                {
                    Archivotxt = ConfigurationManager.AppSettings["dirPDF"].ToString() + "\\" + Embarque + "_" + consecutivo + " - " + NombreTarima + ".txt";
                
                    if (System.IO.Directory.Exists(CarpetaProveedores))
                    {
                        DeleteRecursiveFolder(CarpetaProveedores);
                    }
                }
                else
                {
                    Archivotxt = ConfigurationManager.AppSettings["dirPDFINBOUND"].ToString() + "\\" + Embarque + "_" + consecutivo + " - " + NombreTarima + ".txt";
                }
                try
                {
                    System.IO.File.Delete(Archivotxt);
                }
                catch { }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnProveedorPDF_Click(object sender, EventArgs e)
        {
            if (dgvConsecutivo.Rows.Count < 0)
                return;

            int Partidas;
            int Embarque = Convert.ToInt32(dgvConsecutivo.CurrentRow.Cells["g2Embarque"].Value);
            int Consecutivo = Convert.ToInt32(dgvConsecutivo.CurrentRow.Cells["g2Consecutivo"].Value);

            BorrarProveedor(Embarque, Consecutivo);

            Partidas =   GenearPorProveedores2(
                                                                        Embarque,
                                                                        Consecutivo);

         MessageBox.Show("Proceso terminado, " + Partidas + " partidas procesadas.");
        }


        void BorrarProveedor(int Embarque, int Consecutivo)
        {
            string CarpetaProveedores;

            //Consecutivo = Convert.ToInt32(dgvConsecutivo.CurrentRow.Cells["g2Consecutivo"].Value);                    
            //Embarque = Convert.ToInt32(dgvConsecutivo.CurrentRow.Cells["g2Embarque"].Value);
            CarpetaProveedores = ConfigurationManager.AppSettings["dirPDF"].ToString() + "\\Proveedores - " + Embarque + "_" + Consecutivo;

                  if (System.IO.Directory.Exists(CarpetaProveedores))
                    DeleteRecursiveFolder(CarpetaProveedores);
        }


        int GenearPorProveedores2(int Embarque, int Consecutivo)
        {
            int resultado = 0;


            DataSets.EmbarquesTableAdapters.GenerarTXTRehacerTableAdapter txtTA = new MaterialCore.DataSets.EmbarquesTableAdapters.GenerarTXTRehacerTableAdapter();
            DataSets.Embarques.GenerarTXTRehacerDataTable txtDT = new MaterialCore.DataSets.Embarques.GenerarTXTRehacerDataTable();

            DataSets.EmbarquesTableAdapters.ProveedoresConsecutivoTableAdapter proTA = new MaterialCore.DataSets.EmbarquesTableAdapters.ProveedoresConsecutivoTableAdapter();
            DataSets.Embarques.ProveedoresConsecutivoDataTable proDT = new MaterialCore.DataSets.Embarques.ProveedoresConsecutivoDataTable();

        string CarpetaProveedores = ConfigurationManager.AppSettings["dirPDF"].ToString() + "\\Proveedores - " + Embarque + "_" + Consecutivo;

        proTA.FillbyConsecutivo(proDT, Embarque, Consecutivo);

            Clases.ExportarTXT exporta = new MaterialCore.Clases.ExportarTXT();

            foreach (DataRow r in proDT.Rows)
            {
                txtTA.FillByProveedor(
                    txtDT,
                 Convert.ToString(r["ProveedorId"]),
                 Consecutivo,
                 Embarque);

                resultado += txtDT.Rows.Count;

                if (!System.IO.Directory.Exists(CarpetaProveedores))
                {
                    System.IO.Directory.CreateDirectory(CarpetaProveedores);
                }

               exporta.exportarRehacer(CarpetaProveedores + "\\" + Embarque + " - " + Convert.ToString(r["ProveedorId"]) + ".txt", txtDT, true, 0);

            }
            return resultado;
        }



        int RehacerProveedores()
        {
            int Partidas = 0;
            if (dgvConsecutivo.Rows.Count < 0)
                return 0;

            int Embarque;
            int Consecutivo;
            for (int i = 0; i < dgvConsecutivo.Rows.Count; i++)
            {

                 Embarque = Convert.ToInt32(dgvConsecutivo.Rows[i].Cells["g2Embarque"].Value);
                 Consecutivo = Convert.ToInt32(dgvConsecutivo.Rows[i].Cells["g2Consecutivo"].Value);

                BorrarProveedor(Embarque, Consecutivo);

                Partidas+= GenearPorProveedores2(
                                                                            Embarque,
                                                                            Consecutivo);
            }
            return Partidas;
        }


    }
}