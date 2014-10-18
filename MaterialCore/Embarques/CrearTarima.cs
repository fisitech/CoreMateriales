using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace MaterialCore.Embarques
{
    public partial class CrearTarima : Form
    {

        Clases.Bitacora _Bitacora = new MaterialCore.Clases.Bitacora();

        int _NumeroTarimaInsertada;
        int _idCliente;
        Clases.Conexion _con = new MaterialCore.Clases.Conexion();

        public CrearTarima()
        {
            //cliente labinal
            _idCliente = 70;

            InitializeComponent();
        }

        public CrearTarima(string planta)
        {
            //cliente labinal
            _idCliente = 70;

            InitializeComponent();
            txtPlanta.Text = planta;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (txtPlanta.Text == "")
            {
                MessageBox.Show("Debe agregar la planta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            if (txtPlanta.Text.ToUpper().Contains("DD"))
            {
                MessageBox.Show("No se puede crear tarimas de Partidas detenidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }


            if (txtConsecutivoEmbarque.Text == "")
            {
                MessageBox.Show("Debe agregar un número de embarque", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            if (txtConsecutivo.Text == "")
            {
                try
                {
                    Convert.ToInt32(txtConsecutivo.Text);
                }
                catch
                {
                    MessageBox.Show("Consecutivo no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtConsecutivo.Focus();
                    txtConsecutivo.SelectAll();
                    return;
                }


                //TODO validar que sea entero
                MessageBox.Show("Debe agregar el consecutivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtConsecutivo.Focus();
                return;
            }




            if (txtNombrePaleta.Text != "")
            {
            if (dgvEtiAzul.RowCount > 0)
            {
                //if (txtNoEtiqueta.Text != "" && txtNoEtiqueta.Text.Substring(0, 1) == "B")
                //{
                    DataSets.EmbarquesTableAdapters.GenerarTXTTableAdapter txtTA = new DataSets.EmbarquesTableAdapters.GenerarTXTTableAdapter();
                    DataSets.Embarques.GenerarTXTDataTable txtDT = new DataSets.Embarques.GenerarTXTDataTable();

               //     txtTA.EnforceConstraints = false;

                    txtTA.Fill(txtDT,txtNumeroPaleta.Text,   txtPlanta.Text);


                    if (txtDT.Rows.Count == 0 )
                    {
                        MessageBox.Show("No hay ninguna partida para esta planta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }


                    if (EsDecimal(txtPesoBruto.Text))
                    {

                        this.AgregarPaleta();
             

                        //asocial el bulto a un PL generado para evitar problemas en el port5al web
                       string PL=  PLautomatico();
                       for (int i = 0; i < dgvEtiAzul.RowCount; i++)
                       {
                           string guia = dgvEtiAzul.Rows[i].Cells[0].Value.ToString();
                           AgregarPaletaDespacho(Convert.ToInt32(txtConsecutivoEmbarque.Text),guia);
                           AsociaPL(guia,PL);
                           AgregarGuiaTarima(_NumeroTarimaInsertada, guia);
                       }

                       RehacerTarimas();


                        

                        MessageBox.Show("Tarima creada con exito, se procesaron "+ txtDT.Rows.Count + " partidas.");
                        this.Close();
                    }
                    else
                        MessageBox.Show("El peso bruto no tiene el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                 //MessageBox.Show("El peso bruto no tiene el formato correcto");
                }
                else
                {
                    MessageBox.Show("Debe de agregar al menos una etiqueta Azul", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //MessageBox.Show("Verifique que el numero de la etiqueta sea correcto");
                }
            }
            else
                MessageBox.Show("Debe incluir el nombre del archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
             //MessageBox.Show("Debe incluir el nombre del archivo");
        }
        //FIN DE CREAR TARIMA

        private void GenearPorProveedores(string Carpeta,decimal PesoProveedor)
        {
            //TODO: Codigo para crear carpeta automatica
            DataSets.EmbarquesTableAdapters.ProveedoresTXTTableAdapter proTA = new DataSets.EmbarquesTableAdapters.ProveedoresTXTTableAdapter();
            DataSets.Embarques.ProveedoresTXTDataTable proDT = new DataSets.Embarques.ProveedoresTXTDataTable();

            DataSets.EmbarquesTableAdapters.GenerarTXTTableAdapter txtTA = new DataSets.EmbarquesTableAdapters.GenerarTXTTableAdapter();
            DataSets.Embarques.GenerarTXTDataTable txtDT = new DataSets.Embarques.GenerarTXTDataTable();



            proTA.Fill(proDT,txtPlanta.Text);
            
            Clases.ExportarTXT exporta = new MaterialCore.Clases.ExportarTXT();

            foreach(DataRow r in proDT.Rows)
            {
                txtTA.FillByProveedor(txtDT,txtNumeroPaleta.Text,                   
                    
                    txtPlanta.Text, Convert.ToString(r["ProveedorId"]));



                if (!System.IO.Directory.Exists(Carpeta))
                {
                    System.IO.Directory.CreateDirectory(Carpeta);
                }

                exporta.exportar(Carpeta + "\\" + txtConsecutivoEmbarque.Text + "-" + Convert.ToString(r["ProveedorId"]) + ".txt", txtDT, true, PesoProveedor);
            }
        }

        private void CrearTarima_Load(object sender, EventArgs e)
        {
            CargardatosTarima();
        }

        private void txtNombrePaleta_TextChanged(object sender, EventArgs e)
        {
            DirArchivo();
       }

        void DirArchivo()
        {
            toolStripStatusLabel1.Text = txtDirectorioArchivo.Text + "\\" + txtConsecutivoEmbarque.Text + "_" + txtConsecutivo.Text + " - " + txtNombrePaleta.Text + ".txt";
        }


        private void AgregarPaleta()
        {
            Clases.Conexion conn = new MaterialCore.Clases.Conexion();


            conn.InsertSQL = "INSERT INTO MaterialesPaltetas " +
                                   "(FechaRecibo,NumeroPaleta,Planta,PesoBruto ,CantidadBultos " +
                                   ",TipoEmbarque,ContenidoTipoBulto,FechaEmbarque ,ConsecutivoEmbarque " +
                                   ",NombrePaleta,nid_sku,consecutivo)" +
                             "VALUES " +
                                   "(@FechaRecibo, @NumeroPaleta, @Planta, @PesoBruto, " +
                                   "@CantidadBultos, @TipoEmbarque, @ContenidoTipoBulto, @FechaEmbarque, " +
                                   "@ConsecutivoEmbarque, @NombrePaleta,@nid_sku,@consecutivo) select IDENT_CURRENT('MaterialesPaltetas')";

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
            conn.InsertParametros.Add("@nid_sku", SqlDbType.VarChar, 50).Value = dgvEtiAzul.Rows[0].Cells[0].Value.ToString();
            conn.InsertParametros.Add("@consecutivo", SqlDbType.Int, 4).Value = Convert.ToInt32(txtConsecutivo.Text);
            //  conn.InsertParametros.Add("@nid_sku", SqlDbType.VarChar, 50).Value = txtNoEtiqueta.Text;

            conn.insert();

         SqlDataReader despachosDR;
            despachosDR = conn.getLector(//"SET DATEFORMAT YMD;" +
                            "select IDENT_CURRENT('MaterialesPaltetas') as id") ;

            if (despachosDR.Read())
            {
                _NumeroTarimaInsertada = Convert.ToInt32(despachosDR["id"]);
            }
                despachosDR.Close();


            conn.InsertSQL = "UPDATE  materialesenviar " +
                             "SET MaterialesPaletasId = (select IDENT_CURRENT('MaterialesPaltetas')) " +
                             ", Preparado = 1" +
                             " where Enviado = 0 and Preparado = 0 and Planta = '" + txtPlanta.Text + "'";
            conn.insert();
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

        //creado por erik, pasar al catalogo de embarques/despachos
        private void CrearDespacho()
        {
            //Verifica si hay creado un despacho para el día sino lo crea
            int nDespacho = this.GenerarDespacho();

            //Agrega el palet al despacho para ir conformando el embarque
           // this.AgregarPaletaDespacho(nDespacho);
        }

        private int GenerarDespacho()
        {
            Clases.Conexion conn = new MaterialCore.Clases.Conexion();
            SqlDataReader despachosDR;
            int resultado = 0;

            despachosDR = conn.getLector(//"SET DATEFORMAT YMD;" +
                            "SELECT nid_deploy " +
                            "FROM deploys " +
                            "WHERE " +
                                "CONVERT(DATETIME,CONVERT(VARCHAR(11),dcreation)) = " +
                                    "CONVERT(DATETIME,CONVERT(VARCHAR(11),GETDATE())) " +
                                "AND nid_filial = 70 and bclosed = 0");

            if (despachosDR.Read())
            {
                resultado = Convert.ToInt32(despachosDR["nid_deploy"]);
            }
            else
            {
                despachosDR.Close();

                conn.InsertSQL = "INSERT INTO deploys " +
                                       "(nid_filial, dcreation , dEndSelection,bclosed, nid_user) " +
                                 "VALUES " +
                                       "(@nid_filial, GETDATE(), GETDATE(), 0, @nid_user);";

                conn.InsertParametros.Add("@nid_filial", SqlDbType.Int, 4).Value = 70;
                conn.InsertParametros.Add("@nid_user", SqlDbType.Int, 4).Value = 1;

                conn.insert();

                despachosDR = conn.getLector("SELECT IDENT_CURRENT('deploys') as nid_deploy");

                if (despachosDR.Read())
                {
                    resultado = Convert.ToInt32(despachosDR["nid_deploy"]);

                }

                //Inserta un trasportista ficticio en la tabla, este se puede cambiar desde el sistema por el rela
                conn.InsertSQL = "insert into carriers_deploys values (getdate(), 'SOTELO', 'X', " + resultado + ", 1, 0, 0, null)";
                conn.insert();
                
            }
            conn.FinConexion();

            return resultado;
        }

        private void AgregarPaletaDespacho(int nDespacho, string guia)
        {
            Clases.Conexion conn = new MaterialCore.Clases.Conexion();
            conn.InsertSQL = "INSERT INTO deploys_detail_skus " +
                                   "(nid_deploy, nid_sku) " +
                             "VALUES " +
                                   "(@nid_deploy, @nid_sku)";

            conn.InsertParametros.Add("@nid_deploy", SqlDbType.Int, 4).Value = nDespacho;
            conn.InsertParametros.Add("@nid_sku", SqlDbType.VarChar, 75).Value = guia;

            conn.insert();
           
            //Agrega el bulto a la tabla de sku_arrivals
             conn.InsertSQL = "INSERT INTO sku_arrivals VALUES (2080, '" + guia + "' ,'', 4,	1,	0,	NULL,	1,	0,	1,	NULL,	70,	15,	GETDATE(), GETDATE(),	1)";
             conn.insert();

            conn.FinConexion();
        }

        private void AgregarGuiaTarima(int nTarima, string guia)
        {
            Clases.Conexion conn = new MaterialCore.Clases.Conexion();
            conn.InsertSQL = "INSERT INTO MaterialesPaletasGuias " +
                                   "(IdPaleta, nid_sku) " +
                             "VALUES " +
                                   "(@IdPaleta, @nid_sku)";

            conn.InsertParametros.Add("@IdPaleta", SqlDbType.Int, 4).Value = nTarima;
            conn.InsertParametros.Add("@nid_sku", SqlDbType.VarChar, 75).Value = guia;

            conn.insert();
        }


        private void txtDirectorioArchivo_TextChanged(object sender, EventArgs e)
        {
            DirArchivo();
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

        void CargardatosTarima()
        {
            SqlDataReader datos;

            MaterialCore.Clases.Conexion conn = new MaterialCore.Clases.Conexion();

            datos = conn.getLector(string.Format("SELECT Planta, ISNULL(SUM(Bultos), 0) AS Bultos, GETDATE() AS Fecha " + 
                                                "FROM MaterialesEnviar " + 
                                                "WHERE (Enviado = 0) AND (Preparado = 0) AND (Planta = '{0}') " + 
                                                "GROUP BY Planta", txtPlanta.Text));

            if (datos.Read())
            {
                txtFechaRecibo.Text = datos["Fecha"].ToString();
                txtFechaReciboPC.Text = datos["Fecha"].ToString();
                txtCantidadBultos.Text = datos["Bultos"].ToString();
                txtFechaEmbarque.Text = datos["Fecha"].ToString();
            }

            datos.Close();

            //datos = conn.getLector("SELECT ClienteID ,Consecutivo FROM MaterialesConsecutivos WHERE ClienteID = 70");

            //if (datos.Read())
            //{
            //    txtConsecutivoEmbarque.Text = datos["Consecutivo"].ToString();
            //    txtConsecutivoEmbarquePC.Text = datos["Consecutivo"].ToString();
            //}

           


            if (txtPlanta.Text.ToUpper().Contains("IB"))
            {
           //     System.IO.Directory.CreateDirectory(ConfigurationManager.AppSettings["dirPDFINBOUN"].ToString() +  "\\Proveedores\\"); //este no se usa
                txtDirectorioArchivo.Text = ConfigurationManager.AppSettings["dirPDFINBOUND"].ToString();
            }
            else
            {
    
             //   System.IO.Directory.CreateDirectory(ConfigurationManager.AppSettings["dirPDF"].ToString()+ "\\Proveedores - " + txtConsecutivoEmbarque.Text);
                txtDirectorioArchivo.Text = ConfigurationManager.AppSettings["dirPDF"].ToString();
            }
        }

        private void txtPlanta_TextChanged(object sender, EventArgs e)
        {
            CargardatosTarima();
        }

        //bool VerificarEtiquetas()
        //{
        //    for (int i = 0; i < dgvEtiAzul.RowCount ; i++)
        //    {
               
        //    }
        //}

        bool AgregarEtiqueta(string guia)
        {
            //agregar validacio para no agregar etiquetas que ya est4en como bultos en el sistema

            if ((guia != "" && txtNoEtiqueta.Text.Substring(0, 1) == "B" )|| (guia != "" && txtNoEtiqueta.Text.Substring(0, 1) == "b"))
            {

                //Valida si ya existe la etiqueta

                if (!ExisteEtiquetaAzul(guia)) //indica que si ya existe se sale de la funcion
                {
                   return false;
                }

                





                for (int i = 0; i < dgvEtiAzul.RowCount; i++)
                {
                    if (dgvEtiAzul.Rows[i].Cells[0].Value.ToString().ToUpper() == guia.ToUpper())
                    {
                        MessageBox.Show("Ya escaneo esta etiqueta Azul", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    //    MessageBox.Show("error ya existe la etiqueta");
                        return false;
                    }


                }

                dgvEtiAzul.Rows.Add(guia);

                return true;
            }
            else
            {
                MessageBox.Show("La etiqueta escaneada no es del tipo Azul", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //    MessageBox.Show("error por tipo de etiqueta");
                return false;
            }
        }

        private void txtNoEtiqueta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (AgregarEtiqueta(txtNoEtiqueta.Text))
                {
                    txtNoEtiqueta.Clear();
                    txtNoEtiqueta.Focus();
                }
                else
                {
                    txtNoEtiqueta.Clear();
                    txtNoEtiqueta.Focus();
                }
            }
        }


        private void txtPlanta_KeyDown(object sender, KeyEventArgs e)
        {
            Down(e, txtNumeroPaleta);
            Intro(e, txtNumeroPaleta);
        }

        private void txtNumeroPaleta_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtPlanta);
            Down(e,txtPesoBruto);
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
            Down(e, txtConsecutivo);
            Intro(e, txtConsecutivo);
        }

        private void txtConsecutivo_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtContenidoBulto);

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
            Down(e,txtNoEtiqueta);
            Intro(e, txtNoEtiqueta);
        }

        private void txtNoEtiqueta_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtNombrePaleta);
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

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtNoEtiqueta);
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



        private void txtNombrePaleta_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtNoEtiqueta_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtConsecutivoEmbarque_TextChanged(object sender, EventArgs e)
        {
            DirArchivo();
        }

        private void txtConsecutivo_TextChanged(object sender, EventArgs e)
        {
            DirArchivo();
        }


        bool ExisteEtiquetaAzul(string sku)
        {
            Clases.Bultos bulto = new MaterialCore.Clases.Bultos(sku);

            if (bulto.BultoValidacion(sku, false, false))
            {
                return true;
            }
            else
            {
                return false;
            }
        }






        void RehacerTarimas()
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
                String archivoExcel;


                Clases.ExportarTXT exporta = new MaterialCore.Clases.ExportarTXT();
                Clases.PalletExcel pallet = new MaterialCore.Clases.PalletExcel();

                    //inicia las varialbes para generar el txt
                Embarque = txtConsecutivoEmbarque.Text;
                NombreTarima = txtNombrePaleta.Text;
                    Planta = txtPlanta.Text.ToUpper();
                    Id = _NumeroTarimaInsertada;
                    PesoBruto = Convert.ToDecimal(txtPesoBruto.Text);
                    consecutivo = txtConsecutivo.Text;
                    NumeroTarima = txtNumeroPaleta.Text;


                    DataSets.EmbarquesTableAdapters.GenerarTXTRehacerTableAdapter txtTA = new MaterialCore.DataSets.EmbarquesTableAdapters.GenerarTXTRehacerTableAdapter();
                    DataSets.Embarques.GenerarTXTRehacerDataTable txtDT = new MaterialCore.DataSets.Embarques.GenerarTXTRehacerDataTable();
                    txtTA.Fill(txtDT,
                         Id,
                         Planta);

                   if (!Planta.Contains("IB"))
                    {
                        System.IO.Directory.CreateDirectory(ConfigurationManager.AppSettings["dirPDF"].ToString());
                        Archivotxt = ConfigurationManager.AppSettings["dirPDF"].ToString() + "\\" + Embarque + "_" + consecutivo + " - " + NombreTarima + ".txt";
                        archivoExcel = ConfigurationManager.AppSettings["dirPDF"].ToString() + "" + Embarque + "_" + consecutivo + " - " + NombreTarima + ".xls"; 
                   }
                    else
                    {
                        System.IO.Directory.CreateDirectory(ConfigurationManager.AppSettings["dirPDFINBOUND"].ToString());
                        Archivotxt = ConfigurationManager.AppSettings["dirPDFINBOUND"].ToString() + "\\" + Embarque + "_" + consecutivo + " - " + NombreTarima + ".txt";
                        archivoExcel = ConfigurationManager.AppSettings["dirPDFINBOUND"].ToString() + "" + Embarque + "_" + consecutivo + " - " + NombreTarima + ".txt"; 
                   }
                   exporta.exportarRehacer(Archivotxt, txtDT, false, PesoBruto, chkComas.Checked);
                    //pallet.exportarRehacerArray(archivoExcel, txtDT, false, PesoBruto);


            _Bitacora.MatCreoArchivo(Embarque+"-"+consecutivo);
        }




    }

}