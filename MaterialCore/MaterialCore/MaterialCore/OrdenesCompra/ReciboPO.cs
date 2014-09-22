using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MaterialCore
{
    public partial class ReciboPO : Form
    {

      //  Twain.Principal objTW = new Twain.Principal();

        private int _materialesPaletasId;
        private string _Planta = "";
        private bool _Inbound = false;
        private bool _Automatico = false;

        Clases.Bitacora _Bitacora = new MaterialCore.Clases.Bitacora();

        private void ReciboPO_Load(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }


            this.Height = 438;

            lblInbound.Visible = _Inbound;

            //validacion para INBOUND AUTOMATICO
            if (_Automatico)
            {
                this.BackColor = Color.LightSteelBlue;
                lblInbound.Text = "INBOUND Automatico";
                lblInbound.BackColor = Color.LightSteelBlue;
            }



        }





        public string Planta
        {
            get { return _Planta; }
            set { _Planta = value; }
        }

        public int MaterialesPaletasId
        {
            get { return _materialesPaletasId; }
            set { _materialesPaletasId = value; }
        }

        public ReciboPO()
        {//modo normal
            InitializeComponent();
        }
        
        public ReciboPO(bool Inbound)
        {//modo inbound
            _Inbound = Inbound;
            InitializeComponent();
        }

        public ReciboPO(bool Inbound, bool automatico)
        {//modo inbound
            _Inbound = Inbound;
            _Automatico = automatico;
            InitializeComponent();
        }


        //codigo para evitar que se abra varias veces la forma
        private static ReciboPO m_FormDefInstance;
        public static ReciboPO DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new ReciboPO();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        #region HotKeys
        //permite cachar las teclas precionadas en el teclado y realizar cierta operacion.
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                //case Keys.Control | Keys.N: //nuevo
                 //   MessageBox.Show("Borra todos los textbox y se empiesa a capturar");
                 //   return true;
                case Keys.Home:
                        txtBuscarPO.Focus();
                        txtBuscarPO.SelectAll();
                    return true;
                    
                case Keys.Control | Keys.G: //guardar
                    if (this.Height >= 488)
                    {
                        btnGuardar_Click(0, null);
                    }
                    return true;

                case Keys.Escape: //cancelar
                    if (this.Height >= 488)
                    {
                        btnCancelar_Click(0, null);
                    }
                    return true;    

               case Keys.Control | Keys.S://scanear
                   if (this.Height >= 488)
                   {
                   //    MessageBox.Show("Empieza a escanear");
                       try
                       {
                           MaterialCore.OrdenesCompra.EscanearPL epl = new MaterialCore.OrdenesCompra.EscanearPL();
                           epl.ShowDialog();
                       }
                       catch (Exception ex)
                       {
                           MessageBox.Show(ex.Message , "Error");
                       }
                   }
                     return true;

                 //case Keys.Alt | Keys.S://scanear
          
                 //    return true;
            }
            return false;
        }
        #endregion



        //void Escanear()
        //{
        //    string guia = txtNoGuia.Text;
        //    string dir = System.Configuration.ConfigurationManager.AppSettings["dirOUT"].ToString();
        //    try
        //    {
        //        objTW.ScanPDF(guia, dir);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        
        private void btnMas_Click(object sender, EventArgs e)
        {
            POActivos pos = new POActivos();
            pos.ShowDialog();
            txtBuscarPO.Text = pos.Nid_po;
            pos.Dispose();
            BuscarPO();

        }        

        private void ReciboPO_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (DialogResult.No ==
            //    MessageBox.Show("¿Esta seguro de salir de la ventana?", "Aviso", MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            //{
            //    e.Cancel = true;
            //}
        }

        private void txtNumPO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                this.BuscarPO();
            }
        }

        private void dgvPos_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvPos.RowCount > 0)
            {

                ActualizaTextos();


                lblQuimico.Visible = false;
                lblSkip.Visible = false;
                lblITAR.Visible = false;
                lblCon.Visible = false;


                if ("1" == dgvPos.CurrentRow.Cells["gQuimico"].Value.ToString())
                    lblQuimico.Visible = true;

                //if (Esquimico(dgvPos.CurrentRow.Cells["gNumeroParte"].Value.ToString()))
                //    lblQuimico.Visible = true;

                if ("SKIP-LOT" == dgvPos.CurrentRow.Cells["gSkipLot"].Value.ToString().ToUpper())
                    lblSkip.Visible = true;

                //if ("1" == dgvPos.CurrentRow.Cells["gConsignacion"].Value.ToString())
                //    lblCon.Visible = true;

                if ("CC" == dgvPos.CurrentRow.Cells["gPlanta"].Value.ToString().ToUpper())
                    lblCon.Visible = true;


                if ("1" == dgvPos.CurrentRow.Cells["gITAR"].Value.ToString())
                    lblITAR.Visible = true;

            }
        }

        private void dgvPos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {           

            if (/*dgvPos.CurrentCell.RowIndex != -1 && */dgvPos.RowCount > 0)
            {
                this.Height = 651;
                dgvPos.Enabled = false;
                txtBuscarPO.Enabled = false;
                btnBuscar.Enabled = false;
                btnMas.Enabled = false;
                ActualizaTextos();
                txtCantidadRecibida.Focus();
            }
        }

        void ActualizaTextos()
        {
            if (dgvPos.RowCount > 0)
            {
                materialesOCBindingSource.Position = dgvPos.CurrentRow.Index;
                txtFechaRecibo.Text = quimicos.MaterialesOC[materialesOCBindingSource.Position]["fecha_sku"].ToString();
                //ErrorBlinkStyle al mandar valores nulos
                //dtpHora.Value = Convert.ToDateTime(quimicos.MaterialesOC[materialesOCBindingSource.Position]["FechaRecibo"]);
                //dtpFecha.Value = Convert.ToDateTime(quimicos.MaterialesOC[materialesOCBindingSource.Position]["FechaRecibo"]);
                txtDescripcion.Text = quimicos.MaterialesOC[materialesOCBindingSource.Position]["Descripcion"].ToString(); ;
                txtNumeroProveedor.Text = quimicos.MaterialesOC[materialesOCBindingSource.Position]["ProveedorID"].ToString(); ;
                txtProveedor.Text = quimicos.MaterialesOC[materialesOCBindingSource.Position]["NombreProveedor"].ToString(); ;
                txtNumeroPo.Text = quimicos.MaterialesOC[materialesOCBindingSource.Position]["Id"].ToString();
                txtRenglonID.Text = quimicos.MaterialesOC[materialesOCBindingSource.Position]["RenglonId"].ToString();
                txtNumeroParte.Text = quimicos.MaterialesOC[materialesOCBindingSource.Position]["NumeroParte"].ToString();
                txtUnidadMedida.Text = quimicos.MaterialesOC[materialesOCBindingSource.Position]["UnidadMedida"].ToString();
                txtUOM.Text = quimicos.MaterialesOC[materialesOCBindingSource.Position]["UnidadMedida"].ToString();
                txtFacturaProveedor.Text = quimicos.MaterialesOC[materialesOCBindingSource.Position]["FacturaProveedor"].ToString();
                txtPaisOC.Text = quimicos.MaterialesOC[materialesOCBindingSource.Position]["Pais"].ToString();
                txtPais.Text = quimicos.MaterialesOC[materialesOCBindingSource.Position]["Pais"].ToString();
                txtMoneda.Text = quimicos.MaterialesOC[materialesOCBindingSource.Position]["Moneda"].ToString();
                txtMoneda1.Text = quimicos.MaterialesOC[materialesOCBindingSource.Position]["Moneda"].ToString();
                txtPlantaOriginal.Text = quimicos.MaterialesOC[materialesOCBindingSource.Position]["Planta"].ToString();
                txtPrecio.Text = Convert.ToDecimal(quimicos.MaterialesOC[materialesOCBindingSource.Position]["Precio"]).ToString("N2");



                if (txtPlanta.Text == "")
                    txtPlanta.Text = txtPlantaOriginal.Text;

                if (_Planta != "")
                {
                    txtPlanta.Text = _Planta;
                    txtPlanta.Enabled = false;
                }

                txtCantidadRecibida.Text = Convert.ToDecimal(quimicos.MaterialesOC[materialesOCBindingSource.Position]["CantidadAbierta"]).ToString("N0");
     //           string Noguia = quimicos.MaterialesOC[materialesOCBindingSource.Position]["NoGuia"].ToString();

        /*        if (Noguia != "")
                {
                    txtNoGuia.Text = Noguia;
                }*/

                txtBultos.Text = quimicos.MaterialesOC[materialesOCBindingSource.Position]["Bultos"].ToString();
                txtProgramaID.Text = quimicos.MaterialesOC[materialesOCBindingSource.Position]["ProgramaID"].ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lblITAR.Visible)
            {
                MessageBox.Show("No se puede marcar un Número de parte ITAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            if (txtPais.Text == "")
            {
                 MessageBox.Show("Verifique el pais", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                 txtPais.Focus();
                return;
            }
 
            //en modo modificacion la planta siempre será igual al padre
            if (_Planta != "")
            {
                txtPlanta.Text = _Planta;
            }

            if (txtPlanta.Text == "")
            {
                MessageBox.Show("Verifique la planta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            if (_Inbound && !txtPlanta.Text.ToUpper().Contains("IB"))
            {
                MessageBox.Show("Para los recibos del tipo INBOUND la planta debe contener IB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtPlanta.Focus();
                txtPlanta.SelectAll();
                return;
            }

            if (!EsDecimal(txtCantidadRecibida.Text))
            {
                  MessageBox.Show("Verifique el valor de la cantidad recibida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtCantidadRecibida.Focus();
                return;
            }

            if (Convert.ToDecimal(txtCantidadRecibida.Text)< 1 )
            {
                MessageBox.Show("La cantidad recibida no puede ser menor a 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtCantidadRecibida.Focus();
                return;
            }

            if (!_Inbound && txtNoGuia.Text != "LOCAL")
            {
                if (!ValidarGuia(txtNoGuia.Text, 70))
                {
                    txtNoGuia.Focus();
                    return;
                }
            }

            if (txtFacturaProveedor.Text == "")
            {
                MessageBox.Show("Falta el valor de Factura del proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtFacturaProveedor.Focus();
                return;
            }

                if (txtBultos.Text == "")
                    txtBultos.Text = "0";

                if (!EsEntero(txtBultos.Text))
                {
                    MessageBox.Show("Verifique el valor del total de bultos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtBultos.Focus();
                    return;
                }

            if (Convert.ToInt32(txtBultos.Text) < 0)
            {
                MessageBox.Show("El número de bultos no puede ser menor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }






        //las validaciones entorpesen el sistema, se puede agregar lineras con misma po linea, guia.... pero diferente factura provedor
         
            //if (!LineaCargada(Convert.ToInt32(txtNumeroPo.Text),   70, Convert.ToInt32(txtRenglonID.Text), txtPlanta.Text,txtNoGuia.Text))
            //{
            //    return;
            //}

                if(!ValidaPartida( Convert.ToInt32(txtNumeroPo.Text)   ,70, Convert.ToInt32(txtRenglonID.Text), txtNumeroParte.Text,txtFacturaProveedor.Text))
                {




                    if (DialogResult.Yes ==
                         MessageBox.Show("Esta partida ya ha sido capturada, ¿Quiere volver a capturarla de nuevo?"
                         , "Aviso", MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {

                    }
                    else
                        return;



                }





            //Valida Detenidos
            if (txtPlanta.Text.ToUpper().Contains("DD"))
            {
                Detenidos.Detenidos objDet = new MaterialCore.Detenidos.Detenidos(txtNoGuia.Text);

                if (!objDet.ConTarimab || !objDet.SinEmbiarb)
                {
                    Detenidos.DetenidosForma objForma = new MaterialCore.Detenidos.DetenidosForma(txtNoGuia.Text, txtPlanta.Text);

                    objForma.ShowDialog();

                    if (!objForma.Resultado)
                    {
                        return;
                    }
                    else
                    {
                        objForma.Dispose();
                    }

                }
                //todo normal no hay ninguna partida con guia igual a esta que es de detenido
            }

            //quita los espacios en la guias para no tener prblemas con inbound
            txtNoGuia.Text = LimpiaGuia(txtNoGuia.Text);


            //if(quimicos.MaterialesOC[materialesOCBindingSource.Position].CantidadRecibida + Convert.ToDecimal(txtCantidadRecibida.Text) >
            //    quimicos.MaterialesOC[materialesOCBindingSource.Position].CantidadAbierta  )
            //{
            //    MessageBox.Show("No se puede recibir mas material del solicitado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //             return;
            //}

            if (!_Automatico) //si no es inbound automatico
            {


                materialesOCTableAdapter.UpdateQuery(Convert.ToDecimal(txtCantidadRecibida.Text),
                    txtComentario.Text,
                                               Convert.ToInt32(txtBultos.Text),
                                               txtNoGuia.Text,
                                               Convert.ToInt32(txtNumeroPo.Text),
                                               Convert.ToInt32(txtRenglonID.Text));

                //Si la ventana se abre desde el menu principal
                if (_materialesPaletasId == 0)
                {

                    _Bitacora.MatInserto(

     Convert.ToInt32(this.InsertaMaterialesEnviar(Convert.ToInt32(txtNumeroPo.Text),
                                          70,
                                          Convert.ToInt32(txtRenglonID.Text),
                                          Convert.ToDecimal(txtCantidadRecibida.Text),
                                          txtNoGuia.Text, txtPlanta.Text,
                                          txtFacturaProveedor.Text,

                                          txtNumeroParte.Text,
                                          txtDescripcion.Text,
                                          txtNumeroProveedor.Text,
                                          txtProveedor.Text,
                                          txtUnidadMedida.Text,
                                          txtPais.Text,
                                          txtMoneda.Text,

                                          Convert.ToInt32(txtBultos.Text),
                                          txtComentario.Text,
                                          txtProgramaID.Text,
                                          Convert.ToDecimal(txtPrecio.Text)

                                           )), Convert.ToInt32(txtNumeroPo.Text),
                                                Convert.ToInt32(txtRenglonID.Text),
                                                     txtNoGuia.Text);
              

                }
                else //Si la ventana se abre desde modificar embarques
                {
                       _Bitacora.MatInserto(

     Convert.ToInt32(this.ModificaraMaterialesEnviar(Convert.ToInt32(txtNumeroPo.Text),
                                                70,
                                                Convert.ToInt32(txtRenglonID.Text),
                                                Convert.ToDecimal(txtCantidadRecibida.Text),
                                                  txtNoGuia.Text, txtPlanta.Text,
                                                  txtFacturaProveedor.Text,

                                                txtNumeroParte.Text,
                                                txtDescripcion.Text,
                                                txtNumeroProveedor.Text,
                                                txtProveedor.Text,
                                                txtUnidadMedida.Text,
                                                txtPais.Text,
                                                txtMoneda.Text,

                                               Convert.ToInt32(txtBultos.Text),
                                                txtComentario.Text,
                                                txtProgramaID.Text,
                                                Convert.ToDecimal(txtPrecio.Text)

                                               )), Convert.ToInt32(txtNumeroPo.Text),
                                                Convert.ToInt32(txtRenglonID.Text),
                                                     txtNoGuia.Text);
                }

            }
            else
            {
                //else para guardar inbound automatico
                InboundAutomatico(Convert.ToInt32( txtNumeroPo.Text));



            }


            //if (!_Inbound) no fue util lo del lanzador de digitalizacion automatica inbound
            //{
            //    if (!ValidarGuiaDigitalizada(txtNoGuia.Text))
            //    {
            //        //Validar si ya se digitalizo el numero de guia
            //        OrdenesCompra.EscanearPL escaner = new MaterialCore.OrdenesCompra.EscanearPL(txtNoGuia.Text);
            //        escaner.ShowDialog();
            //    }
            //}
            //else
            //{
            //    if (!ValidarGuiaDigitalizadaInbound(LimpiaGuia(txtNoGuia.Text  )))
            //    {
            //        //Validar si ya se digitalizo el numero de guia
            //        OrdenesCompra.EscanearPLInbound escaner = new MaterialCore.OrdenesCompra.EscanearPLInbound(LimpiaGuia(txtNoGuia.Text  ));
            //        escaner.ShowDialog();
            //    }
            //}
            if (!_Inbound)
            {

                if (!ValidarGuiaDigitalizada(txtNoGuia.Text))
                {
                    //Validar si ya se digitalizo el numero de guia
                    OrdenesCompra.EscanearPL escaner = new MaterialCore.OrdenesCompra.EscanearPL(txtNoGuia.Text);
                    escaner.ShowDialog();


                }
            }


            this.Height = 438;
            btnBuscar.Enabled = true;
            dgvPos.Enabled = true;
            txtBuscarPO.Enabled = true;
            btnMas.Enabled = true;
            txtCantidadRecibida.Clear();
            BuscarPO();
            txtBuscarPO.Focus();
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Height = 438;
            btnBuscar.Enabled = true;
            dgvPos.Enabled = true;
            txtBuscarPO.Enabled = true;
            btnMas.Enabled = true;
            txtCantidadRecibida.Clear();
            txtBuscarPO.Focus();
        }

        private void CapturarPO(bool Habilitado)
        {
            this.Height = 651;
            dgvPos.Enabled = !Habilitado;
            txtBuscarPO.ReadOnly = Habilitado;
            btnMas.Enabled = !Habilitado; 
        }

        private void BuscarPO()
        {
     if(       EsEntero(txtBuscarPO.Text))
            {
            if(txtBuscarPO.Text != "")
                materialesOCTableAdapter.FillById(quimicos.MaterialesOC, Convert.ToInt32(txtBuscarPO.Text),chkCerradas.Checked);

            FormatoColorGrid();

            if (dgvPos.RowCount > 0)
                dgvPos.Focus();

            else
                txtBuscarPO.SelectAll();



            }
     
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarPO();
        }

        private int InsertaMaterialesEnviar(int MaterialesOCId, int ClienteID, int RenglonId, Decimal CantidadRecibida, string Guia, string Planta,string FacturaProveedor,
                                                string	NumeroParte ,
                                                string	Descripcion ,
                                                string	ProveedorId ,
                                                string	NombreProveedor ,
                                                string	UnidadMedida ,
                                                string	Pais ,
                                                string	Moneda, 
                                                int Bultos,
                                                string Comentario,
                                                string ProgramaId,
                                                decimal Precio
            )
        {
            int id = 0;
            Clases.Conexion conn = new MaterialCore.Clases.Conexion();
           /* SqlDataReader datos;

            string sql = string.Format("  SELECT * FROM MaterialesEnviar  " + 
                                                    "  WHERE MaterialesOCId = {0} " + 
                                                    "  AND ClienteID = {1} " + 
                                                    "  AND RenglonId = {2} " + 
                                                    "  AND NoGuia = '{3}' " + 
                                                    "  AND Planta = '{4}' " + 
                                                    "  AND MaterialesPaletasId is NULL " + 
                                                    "  AND preparado = 0",MaterialesOCId,ClienteID,RenglonId,Guia,Planta);
            datos = conn.getLector(sql);

            if (datos.Read())
            {
                datos.Close();

                conn.InsertSQL = "Update  MaterialesEnviar   set CantidadRecibida= CantidadRecibida +  @CantidadRecibida "+
                    "  WHERE MaterialesOCId = @MaterialesOCId " + 
                                                    "  AND ClienteID = @ClienteID " + 
                                                    "  AND RenglonId = @RenglonId " + 
                                                    "  AND NoGuia = @Guia " + 
                                                    "  AND Planta = @Planta " + 
                                                    "  AND MaterialesPaletasId is NULL " + 
                                                    "  AND preparado = 0";
                
                conn.InsertParametros.Add("@MaterialesOCId", SqlDbType.Int, 4, "").Value = MaterialesOCId;
                conn.InsertParametros.Add("@ClienteID", SqlDbType.Int, 4, "").Value = ClienteID;
                conn.InsertParametros.Add("@RenglonId", SqlDbType.Int, 4, "").Value = RenglonId;
                conn.InsertParametros.Add("@CantidadRecibida", SqlDbType.Decimal, 18, "").Value = CantidadRecibida;
                conn.InsertParametros.Add("@Guia", SqlDbType.VarChar, 75, "").Value = Guia;
                conn.InsertParametros.Add("@Planta", SqlDbType.VarChar, 10, "").Value = Planta;
                conn.insert();

            }
            else
            {
                datos.Close();*/






            conn.InsertSQL = "INSERT INTO MaterialesEnviar VALUES (null, @MaterialesOCId,@ClienteID, @RenglonId, @CantidadRecibida, GETDATE(), 0, 0,@Guia,@Planta,@FacturaProveedor,@NumeroParte,@Descripcion,@ProveedorId,@NombreProveedor,@UnidadMedida,@Pais,@Moneda,@Bultos, @Comentario, @ProgramaId, @Precio);";

                conn.InsertParametros.Add("@MaterialesOCId", SqlDbType.Int, 4, "").Value = MaterialesOCId;
                conn.InsertParametros.Add("@ClienteID", SqlDbType.Int, 4, "").Value = ClienteID;
                conn.InsertParametros.Add("@RenglonId", SqlDbType.Int, 4, "").Value = RenglonId;
                conn.InsertParametros.Add("@CantidadRecibida", SqlDbType.Decimal, 18, "").Value = CantidadRecibida;
                conn.InsertParametros.Add("@Guia", SqlDbType.VarChar, 75, "").Value = Guia;
                conn.InsertParametros.Add("@Planta", SqlDbType.VarChar, 10, "").Value = Planta;
                conn.InsertParametros.Add("@FacturaProveedor", SqlDbType.VarChar, 50, "").Value = FacturaProveedor;

                conn.InsertParametros.Add("@NumeroParte", SqlDbType.VarChar, 50, "").Value = NumeroParte;
                conn.InsertParametros.Add("@Descripcion", SqlDbType.VarChar, 200, "").Value = Descripcion;
                conn.InsertParametros.Add("@ProveedorId", SqlDbType.VarChar, 150, "").Value = ProveedorId;
                conn.InsertParametros.Add("@NombreProveedor", SqlDbType.VarChar, 250, "").Value = NombreProveedor;
                conn.InsertParametros.Add("@UnidadMedida", SqlDbType.VarChar, 10, "").Value = UnidadMedida;
                conn.InsertParametros.Add("@Pais", SqlDbType.VarChar, 10, "").Value = Pais;
                conn.InsertParametros.Add("@Moneda", SqlDbType.VarChar, 10, "").Value = Moneda;

                conn.InsertParametros.Add("@Bultos", SqlDbType.Int, 4, "").Value = Bultos;
                conn.InsertParametros.Add("@Comentario", SqlDbType.VarChar, 250, "").Value = @Comentario;
                conn.InsertParametros.Add("@ProgramaId", SqlDbType.VarChar, 50, "").Value = @ProgramaId;
                conn.InsertParametros.Add("@Precio", SqlDbType.Decimal, 18, "").Value = Precio;

            conn.insert();
            //}


            SqlDataReader despachosDR;
            despachosDR = conn.getLector(//"SET DATEFORMAT YMD;" +
                            "select IDENT_CURRENT('MaterialesEnviar') as id");

            if (despachosDR.Read())
            {
                id = Convert.ToInt32(despachosDR["id"]);
            }
            despachosDR.Close();

            return id;

        }

        private int ModificaraMaterialesEnviar(int MaterialesOCId, int ClienteID, int RenglonId, Decimal CantidadRecibida, string Guia, string Planta,string FacturaProveedor,
                        string NumeroParte,
string Descripcion,
string ProveedorId,
string NombreProveedor,
string UnidadMedida,
string Pais,
string Moneda,
            
int Bultos,
string Comentario,
string ProgramaId,
decimal Precio
            
            )
        {
            int id = 0;
            Clases.Conexion conn = new MaterialCore.Clases.Conexion();
          /*  SqlDataReader datos;

            string sql = string.Format("  SELECT * FROM MaterialesEnviar  " + 
                                                    "  WHERE MaterialesOCId = {0} " + 
                                                    "  AND ClienteID = {1} " + 
                                                    "  AND RenglonId = {2} " + 
                                                    "  AND NoGuia = '{3}' " + 
                                                    "  AND Planta = '{4}' " + 
                                                    "  AND MaterialesPaletasId = {5} " +
                                                    "  AND preparado = 1", MaterialesOCId, ClienteID, RenglonId, Guia, Planta, _materialesPaletasId);
            datos = conn.getLector(sql);

            if (datos.Read())
            {
                datos.Close();
                conn.InsertSQL = "Update  MaterialesEnviar   set CantidadRecibida= CantidadRecibida +  @CantidadRecibida " +
                    "  WHERE MaterialesOCId = @MaterialesOCId " +
                                                    "  AND ClienteID = @ClienteID " +
                                                    "  AND RenglonId = @RenglonId " +
                                                    "  AND NoGuia = @Guia " +
                                                    "  AND Planta = @Planta " +
                                                    "  AND MaterialesPaletasId = @MaterialesPaletasId " +
                                                    "  AND preparado = 1";

                conn.InsertParametros.Add("@MaterialesPaletasId", SqlDbType.Int, 4, "").Value = _materialesPaletasId;
                conn.InsertParametros.Add("@MaterialesOCId", SqlDbType.Int, 4, "").Value = MaterialesOCId;
                conn.InsertParametros.Add("@ClienteID", SqlDbType.Int, 4, "").Value = ClienteID;
                conn.InsertParametros.Add("@RenglonId", SqlDbType.Int, 4, "").Value = RenglonId;
                conn.InsertParametros.Add("@CantidadRecibida", SqlDbType.Decimal, 18, "").Value = CantidadRecibida;
                conn.InsertParametros.Add("@Guia", SqlDbType.VarChar, 75, "").Value = Guia;
                conn.InsertParametros.Add("@Planta", SqlDbType.VarChar, 10, "").Value = Planta;
                conn.insert();

            }
            else
            {
                datos.Close();*/
            conn.InsertSQL = "INSERT INTO MaterialesEnviar VALUES (@MaterialesPaletasId, @MaterialesOCId,@ClienteID, @RenglonId, @CantidadRecibida, GETDATE(), 1, 0,@Guia,@Planta,@FacturaProveedor,@NumeroParte,@Descripcion,@ProveedorId,@NombreProveedor,@UnidadMedida,@Pais,@Moneda,@Bultos, @Comentario, @ProgramaId, @Precio);";

                conn.InsertParametros.Add("@MaterialesPaletasId", SqlDbType.Int, 4, "").Value = _materialesPaletasId;
                conn.InsertParametros.Add("@MaterialesOCId", SqlDbType.Int, 4, "").Value = MaterialesOCId;
                conn.InsertParametros.Add("@ClienteID", SqlDbType.Int, 4, "").Value = ClienteID;
                conn.InsertParametros.Add("@RenglonId", SqlDbType.Int, 4, "").Value = RenglonId;
                conn.InsertParametros.Add("@CantidadRecibida", SqlDbType.Decimal, 18, "").Value = CantidadRecibida;
                conn.InsertParametros.Add("@Guia", SqlDbType.VarChar, 75, "").Value = Guia;
                conn.InsertParametros.Add("@Planta", SqlDbType.VarChar, 10, "").Value = Planta;
                conn.InsertParametros.Add("@FacturaProveedor", SqlDbType.VarChar, 50, "").Value = FacturaProveedor;

                conn.InsertParametros.Add("@NumeroParte", SqlDbType.VarChar, 50, "").Value = NumeroParte;
                conn.InsertParametros.Add("@Descripcion", SqlDbType.VarChar, 200, "").Value = Descripcion;
                conn.InsertParametros.Add("@ProveedorId", SqlDbType.VarChar, 150, "").Value = ProveedorId;
                conn.InsertParametros.Add("@NombreProveedor", SqlDbType.VarChar, 250, "").Value = NombreProveedor;
                conn.InsertParametros.Add("@UnidadMedida", SqlDbType.VarChar, 10, "").Value = UnidadMedida;
                conn.InsertParametros.Add("@Pais", SqlDbType.VarChar, 10, "").Value = Pais;
                conn.InsertParametros.Add("@Moneda", SqlDbType.VarChar, 10, "").Value = Moneda;

                conn.InsertParametros.Add("@Bultos", SqlDbType.Int, 4, "").Value = Bultos;
                conn.InsertParametros.Add("@Comentario", SqlDbType.VarChar, 250, "").Value = @Comentario;
                conn.InsertParametros.Add("@ProgramaId", SqlDbType.VarChar, 50, "").Value = @ProgramaId;
                conn.InsertParametros.Add("@Precio", SqlDbType.Decimal, 18, "").Value = Precio;

            conn.insert();
            //}


            SqlDataReader despachosDR;
            despachosDR = conn.getLector(//"SET DATEFORMAT YMD;" +
                            "select IDENT_CURRENT('MaterialesEnviar') as id");

            if (despachosDR.Read())
            {
                id = Convert.ToInt32(despachosDR["id"]);
            }
            despachosDR.Close();

            return id;

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

        private bool EsEntero(string valor)
        {
            bool resultado = true;
            int prueba;

            if (!int.TryParse(valor, out prueba))
                resultado = false;

            return resultado;
        }

        private void FormatoColorGrid()
        {

    /*        for (int i = 0; i < dgvPos.RowCount; i++)
            {
                dgvPos.Rows[i].DefaultCellStyle.BackColor = Color.White;
                dgvPos.Rows[i].DefaultCellStyle.ForeColor = Color.Black;

                if (dgvPos.Rows[i].Cells["gSkipLot"].Value.ToString() == "SKIP-LOT")
                  dgvPos.Rows[i].DefaultCellStyle.Font = new Font(dgvPos.Font,FontStyle.Bold);

                if (dgvPos.Rows[i].Cells["gQuimico"].Value.ToString() == "1")
                    dgvPos.Rows[i].DefaultCellStyle.BackColor = Color.Orange;

                if (dgvPos.Rows[i].Cells["gITAR"].Value.ToString() == "1")
                {
                    dgvPos.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dgvPos.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }

            }*/

            for (int i = 0; i < dgvPos.RowCount; i++)
            {
                dgvPos.Rows[i].DefaultCellStyle.BackColor = Color.White;
                dgvPos.Rows[i].DefaultCellStyle.ForeColor = Color.Black;

                if (dgvPos.Rows[i].Cells["gSkipLot"].Value.ToString() == "SKIP-LOT")
                {
                    dgvPos.Rows[i].DefaultCellStyle.Font = new Font(dgvPos.Font, FontStyle.Bold);
                    dgvPos.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(228, 53, 97);
                }

                if (dgvPos.Rows[i].Cells["gQuimico"].Value.ToString() == "1")
                {
                    dgvPos.Rows[i].DefaultCellStyle.Font = new Font(dgvPos.Font, FontStyle.Bold);
                    dgvPos.Rows[i].DefaultCellStyle.BackColor = Color.Peru; 
                }

                if (dgvPos.Rows[i].Cells["gITAR"].Value.ToString() == "1")
                {
                    dgvPos.Rows[i].DefaultCellStyle.Font = new Font(dgvPos.Font, FontStyle.Bold);
                    dgvPos.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dgvPos.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }

                if (dgvPos.Rows[i].Cells["gPlanta"].Value.ToString().ToUpper() == "CC") //consignacion
                {
                  //  dgvPos.Rows[i].Cells["gDrawingId"].DefaultCellStyle.Font = new Font(dgvPos.Font, FontStyle.Bold);
                    dgvPos.Rows[i].Cells["gDrawingId"].Style.BackColor = Color.RoyalBlue;
                    dgvPos.Rows[i].Cells["gNumeroParte"].Style.BackColor = Color.RoyalBlue;
                   // dgvPos.Rows[i].Cells["gDrawingId"].DefaultCellStyle.ForeColor = Color.White;
                }



            }


        }

        private bool Esquimico(string NumeroParte)
        {
            Clases.Conexion conn = new MaterialCore.Clases.Conexion();

            SqlDataReader quimicosDR =  conn.getLector("select * from MaterialesQuimicos where NumeroParte = '" + NumeroParte + "'");

            return quimicosDR.Read();            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNumeroParte.Text != "")
            {
                string desc = txtDescripcion.Text;
                string id = txtNumeroParte.Text;

                try
                {
                        if (DialogResult.Yes ==
                            MessageBox.Show("¿Está seguro de agregar este Numero de parte como químico?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button1))
                        {
                            MaterialCore.DataSets.QuimicosTableAdapters.MaterialesQuimicosTableAdapter Quimicos = new MaterialCore.DataSets.QuimicosTableAdapters.MaterialesQuimicosTableAdapter();
                            Quimicos.InsertQuery(id, desc, 70);
                            btnBuscar_Click(0, e);
                          //  MessageBox.Show("Numero de parte añadido como Químicos");
                        }
                }
                catch
                {
                    MessageBox.Show("Puede que el número de parte ya este agregado en en catálogo de químicos ó que el número de parte este mal escrito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                 //   MessageBox.Show("Puede que el Numero de parte ya este agregado en en catalogo de químicos ó que el Numero de parte este mal escrito.");
                }
            }


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }



        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //

         

            if (!EsDecimal(txtBultos.Text))
            {
                MessageBox.Show("Verifique el valor del total de bultos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
             //   MessageBox.Show("Verifique el valor del total de bultos");
                return;
            }

            if (Convert.ToInt32(txtBultos.Text) < 1)
            {
                MessageBox.Show("El número de bultos no puede ser menor a 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
             //   MessageBox.Show("El número de bultos no puede ser menor a 1");
                return;
            }


            //if (txtNoGuia.Text != "")
            //{
            //    if (!ValidarGuia(txtNoGuia.Text, 70))
            //    {
            //        txtNoGuia.Focus();
            //        return;
            //    }
            //}


            materialesOCTableAdapter.UpdateSoloInfo(
                txtNumeroParte.Text,
                                            txtDescripcion.Text,                                            
                                            txtUnidadMedida.Text,
                                            txtFacturaProveedor.Text,
                                            txtPais.Text,
                                            txtPlanta.Text,
                                            txtComentario.Text,
                                            Convert.ToInt32(txtBultos.Text),
                                            txtMoneda.Text,
                                            txtProgramaID.Text,
                                                 txtNoGuia.Text,
                                            Convert.ToInt32(txtNumeroPo.Text),
                                            Convert.ToInt32(txtRenglonID.Text));
            
 
         //   MessageBox.Show("Datos actualizados con éxito");

            this.Height = 438;
            btnBuscar.Enabled = true;
            dgvPos.Enabled = true;
            txtBuscarPO.Enabled = true;
            btnMas.Enabled = true;
            txtCantidadRecibida.Clear();
            BuscarPO();
        
            //
        }


        private void dgvPos_Sorted(object sender, EventArgs e)
        {
            FormatoColorGrid();
        }



        bool ValidarGuia(string sku, int cliente)
        {
            Clases.Bultos bulto = new MaterialCore.Clases.Bultos(sku);

             if(bulto.BultoValidacion(sku,true,true))
             {
               if(  bulto.idCliente  == cliente)
               {
                   return true;
               }
               
               else
               {
                   MessageBox.Show("El cliente asociado a este bulto no es de Labinal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                //   MessageBox.Show("El cliente asociado a este bulto no es de Labinal");
                   return false;
               }
             }
             else
             {
                 return false;
             }
        }


        bool ValidarGuiaDigitalizada(string guia)
        {
            SqlDataReader datos;

            MaterialCore.Clases.Conexion conn = new MaterialCore.Clases.Conexion();
            bool resultado = true;

            datos = conn.getLector("SELECT     id, nid_sku, fecha, escaneado, nid_cliente " + 
                                                "FROM         sku_escanear " + 
                                                "WHERE     (nid_cliente = 70) AND (escaneado = 0) AND nid_sku = '"+ guia + "'" +
                                                " ORDER BY fecha DESC");

            if (datos.Read())
            {
                resultado = false;
            }

            datos.Close();
            return resultado;
        }

        bool ValidarGuiaDigitalizadaInbound(string guia)
        {
            SqlDataReader datos;

            MaterialCore.Clases.Conexion conn = new MaterialCore.Clases.Conexion();
            bool resultado = false;

            datos = conn.getLector("SELECT     id, nid_sku, fecha, escaneado, nid_cliente " +
                                                "FROM         sku_escanear " +
                                                "WHERE     (nid_cliente = 70) AND (escaneado = 1) AND nid_sku = '" + guia + "'" +
                                                " ORDER BY fecha DESC");

            if (datos.Read())
            {
                resultado = true;
            }

            datos.Close();
            return resultado;
        }




        #region SelectAll
        private void txtFechaRecibo_Enter(object sender, EventArgs e)
        {
            txtFechaRecibo.SelectAll();
        }

        private void txtNumeroPo_Enter(object sender, EventArgs e)
        {
            txtNumeroPo.SelectAll();
        }

        private void txtRenglonID_Enter(object sender, EventArgs e)
        {
            txtRenglonID.SelectAll();
        }

        private void txtNumeroParte_Enter(object sender, EventArgs e)
        {
            txtNumeroParte.SelectAll();
        }

        private void txtFacturaProveedor_Enter(object sender, EventArgs e)
        {
            txtFacturaProveedor.SelectAll();
        }

        private void txtPais_Enter(object sender, EventArgs e)
        {
            txtPais.SelectAll();
        }

        private void txtPlanta_Enter(object sender, EventArgs e)
        {
            txtPlanta.SelectAll();
        }

        private void txtUOM_Enter(object sender, EventArgs e)
        {
            txtUOM.SelectAll();
        }

        private void txtMoneda1_Enter(object sender, EventArgs e)
        {
            txtMoneda1.SelectAll();
        }

        private void txtCantidadRecibida_Enter(object sender, EventArgs e)
        {
            txtCantidadRecibida.SelectAll();
        }

        private void txtNoGuia_Enter(object sender, EventArgs e)
        {
            txtNoGuia.SelectAll();
        }

        private void txtComentario_Enter(object sender, EventArgs e)
        {
            txtComentario.Select();
        }


        private void txtBultos_Enter(object sender, EventArgs e)
        {
            txtBultos.SelectAll();
        }


        ///click
        ///
        private void txtFechaRecibo_Click(object sender, EventArgs e)
        {
            txtFechaRecibo.SelectAll();
        }

        private void txtNumeroPo_Click(object sender, EventArgs e)
        {
            txtNumeroPo.SelectAll();
        }

        private void txtRenglonID_Click(object sender, EventArgs e)
        {
            txtRenglonID.SelectAll();
        }

        private void txtNumeroParte_Click(object sender, EventArgs e)
        {
            txtNumeroParte.SelectAll();
        }

        private void txtFacturaProveedor_Click(object sender, EventArgs e)
        {
            txtFacturaProveedor.SelectAll();
        }

        private void txtPais_Click(object sender, EventArgs e)
        {
            txtPais.SelectAll();
        }

        private void txtPlanta_Click(object sender, EventArgs e)
        {
            txtPlanta.SelectAll();
        }

        private void txtUOM_Click(object sender, EventArgs e)
        {
            txtUOM.SelectAll();
        }

        private void txtMoneda1_Click(object sender, EventArgs e)
        {
            txtMoneda1.SelectAll();
        }

        private void txtCantidadRecibida_Click(object sender, EventArgs e)
        {
            txtCantidadRecibida.SelectAll();
        }


        private void txtBultos_Click(object sender, EventArgs e)
        {
            txtBultos.SelectAll();
        }

        private void txtNoGuia_Click(object sender, EventArgs e)
        {
            txtNoGuia.SelectAll();
        }

        private void txtComentario_Click(object sender, EventArgs e)
        {
            txtComentario.SelectAll();
        }
        #endregion

        #region Entern en textbox

   
     
        private void txtFechaRecibo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((Keys)e.KeyChar == Keys.Enter)
            {
                txtNumeroPo.Focus();
            }

        }

        private void txtNumeroPo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                txtRenglonID.Focus();
            }

        }

        private void txtRenglonID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                txtNumeroParte.Focus();
            }

        }

        private void txtNumeroParte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                txtMoneda1.Focus();
            }

        }

        private void txtMoneda1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                //txtPais.Focus();
                btnGuardar_Click(0, e);
            }

        }

        private void txtUOM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnGuardar_Click(0, e);
            }
          
        }

        private void txtComentario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnGuardar_Click(0, e);
            }
  
        }
        #endregion

        private void txtBuscarPO_Enter(object sender, EventArgs e)
        {
                txtBuscarPO.SelectAll();
        }

        private void txtCantidadRecibida_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtPais);
            Down(e, txtFacturaProveedor);
            //Enter(e, txtFacturaProveedor);
        }
        private void txtFacturaProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtCantidadRecibida);
            Down(e, txtPlanta);
           // Enter(e, txtPlanta);

        }
        private void txtPlanta_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtFacturaProveedor);
            Down(e, txtNoGuia);
            //Enter(e, txtNoGuia);
        }
        private void txtNoGuia_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtPlanta);
            Down(e, txtBultos);
           // Enter(e, txtBultos);
        }
        private void txtBultos_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtNoGuia);
            Down(e, txtComentario);
            //Enter(e, txtComentario);
        }
        private void txtComentario_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtBultos);
        }
        private void dgvPos_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvPos.RowCount > 0)
            {
                //al poner el enter primero da un salto de rengln y luego ejecuta la accio ¿?¿?
                if (e.KeyCode == Keys.Insert /*|| e.KeyCode == Keys.Enter*/)
                {
                    e.Handled = false;
                    dgvPos_CellDoubleClick(0, null);
                }
            }
          }

        private void txtBuscarPO_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarPO.Text.Length >= 6)
            {
                this.BuscarPO();
            }
        }




        bool LineaCargada(int po, int idcliente, int renglon, string plantaCapturada, string guiaCapturada)
        {
            bool resultado = true;
            Clases.Conexion conn = new MaterialCore.Clases.Conexion();
            SqlDataReader datos;

            bool preparado;
            int paleta;
            string planta;
            string nombrePaleta;
            string numeroPaleta;
            bool cerrado;
            string guia;

            string sql = string.Format("SELECT    ISNULL( MaterialesEnviar.MaterialesPaletasId,0) AS MaterialesPaletasId, MaterialesEnviar.MaterialesOCId, MaterialesEnviar.ClienteID, MaterialesEnviar.RenglonId,  " + 
                                                    "MaterialesEnviar.Preparado, MaterialesEnviar.Planta,  " + 
                                         
                                                    "ISNULL(    MaterialesPaltetas.NumeroPaleta,'') AS NumeroPaleta,  " + 
                                                    "ISNULL(  MaterialesPaltetas.NombrePaleta,'') AS NombrePaleta,  " +
                                                    "iSNULL(   deploys.bclosed,0) AS bclosed, MaterialesEnviar.noguia " + 
                                             
                                                    "FROM         MaterialesEnviar LEFT OUTER JOIN " + 
                                                    "MaterialesPaltetas ON MaterialesEnviar.MaterialesPaletasId = MaterialesPaltetas.Id LEFT OUTER JOIN " + 
                                                    "deploys ON MaterialesPaltetas.ConsecutivoEmbarque = deploys.nid_deploy " + 
                                                    "WHERE     (MaterialesEnviar.MaterialesOCId = {0}) AND (MaterialesEnviar.ClienteID = {1}) AND (MaterialesEnviar.RenglonId = {2})",
                                                        po,idcliente,renglon);
            datos = conn.getLector(sql);

            if (datos.Read())
            {
                preparado = Convert.ToBoolean(datos["Preparado"]);
                planta = datos["Planta"].ToString();
                paleta = Convert.ToInt32(datos["MaterialesPaletasId"]);
                numeroPaleta = datos["NumeroPaleta"].ToString();
                nombrePaleta = datos["NombrePaleta"].ToString();
                cerrado = Convert.ToBoolean(datos["bclosed"]);
                guia = datos["MaterialesEnviar.noguia"].ToString();

                if(cerrado && (guia == guiaCapturada))
                {
                     MessageBox.Show("Esta partida ya a sido capturada y embiada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return false;
                }
                else
                {
                    if (paleta != 0 && (guia == guiaCapturada))//se refiere a que la ya se a creado la tarima de esta partida (linea,renglon)
                    {
                        MessageBox.Show("Esta partida ya a sido capturada y cargada en la tarima con planta: " + planta + " IdPaleta: " + paleta
                                , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return false;

                   /*     if(planta == plantaCapturada)
                        {
                        //mensaje de pregunta paelta ya capturada, quiere sumar la cantidad?
                                 if (DialogResult.No ==
                                   MessageBox.Show( "Esta partida ya a sido capturada y cargada en la tarima con planta: " + planta+ " IdPaleta: " + paleta+ ", ¿Quiere sumar la cantidad recibida de esta partida?"
                                   , "Aviso", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                                {
                                 return true;
                                }
                                 else
                                    return false;
                        }
                        else //no corresponde la planta
                        {
                                      MessageBox.Show("Esta partida ya a sido capturada y cargada en la tarima con planta: " + planta+ " IdPaleta: " + paleta
                                          ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            return false;
                        }*/
                    }else // si no se a crado el txt
                    {
                        if (planta == plantaCapturada)
                        {
                              if (DialogResult.Yes ==
                                   MessageBox.Show( "Esta partida ya a sido capturada y cargada con planta: " + planta+ ", ¿Quiere sumar la cantidad recibida de esta partida?"
                                   , "Aviso", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                                {
                                 return true;
                                }
                                 else
                                    return false;
                         }
                         else
                         {
                              MessageBox.Show("Esta partida ya a sido capturada y cargada en la tarima con planta: " + planta
                                          ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            return false;
                         }
                    }

                }

            } //si no se le nada en el reader

            return resultado;
        }


        void Up(KeyEventArgs e,TextBox ir_a)
        {
            if (e.KeyCode == Keys.Up)
            {
                e.Handled = false;
                ir_a.Focus();
            }
        }
        void Down(KeyEventArgs e,TextBox ir_a)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = false;
                ir_a.Focus();
            }
        }
        void Enter(KeyEventArgs e, TextBox ir_a)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = false;
                ir_a.Focus();
            }
        }

        private void txtNoGuia_TextChanged(object sender, EventArgs e)
        {
            txtNoGuia.Text = txtNoGuia.Text.ToUpper();
            txtNoGuia.SelectionStart = txtNoGuia.Text.Length;
        }



        bool ValidaPartida(int PO, int IdCliente, int Renglon, string NoParte, string FacturaProveedor)
        {
            bool resultado = true;

            Clases.Conexion conn = new MaterialCore.Clases.Conexion();
            SqlDataReader datos;
         
            string planta = "";
            int paleta = 0;

            string sql = string.Format("SELECT Planta, isnull(MaterialesPaletasId,0) as MaterialesPaletasId    " + 
                                                    "FROM MaterialesEnviar    " + 
                                                    "WHERE (MaterialesOCId = {0})     " + 
                                                    "AND (ClienteID = {1})    " + 
                                                    " AND (RenglonId = {2})     " + 
                                                    " AND (NumeroParte = {3})     " + 
                                                    " AND (FacturaProveedor = '{4}')",PO,IdCliente,Renglon,NoParte,FacturaProveedor);

            datos = conn.getLector(sql);

            if (datos.Read())
            {
                planta = datos["Planta"].ToString();
                paleta = Convert.ToInt32(datos["MaterialesPaletasId"]);
                resultado = false;
            }
                  return resultado;
        }




        void InboundAutomatico(int PO)
        {
            DataSets.QuimicosTableAdapters.MaterialesOCTableAdapter taPO = new MaterialCore.DataSets.QuimicosTableAdapters.MaterialesOCTableAdapter();
            DataSets.Quimicos.MaterialesOCDataTable tabla = new MaterialCore.DataSets.Quimicos.MaterialesOCDataTable();
            taPO.FillById(tabla, PO, true);

             int Bultos = Convert.ToInt32( txtBultos.Text);

            for (int i = 0; i < tabla.Rows.Count; i++)
            {

                //Parque solo guarde bultos en la primera linea
                if(i != 0)
                    Bultos = 0;

                materialesOCTableAdapter.UpdateQuery(Convert.ToDecimal(tabla.Rows[i]["CantidadAbierta"]),
                                                                                txtComentario.Text,
                                                                                Bultos,
                                                                                txtNoGuia.Text,
                                                                                PO,
                                                                                Convert.ToInt32(tabla.Rows[i]["RenglonId"]));

                _Bitacora.MatINBOUNDAutomatico(Convert.ToInt32(

                                 this.InsertaMaterialesEnviar(


                                     Convert.ToInt32(tabla.Rows[i]["Id"]),
                                                                            70,
                                                                            Convert.ToInt32(tabla.Rows[i]["RenglonId"]),
                                                                            Convert.ToDecimal(tabla.Rows[i]["CantidadAbierta"]),
                                                                            txtNoGuia.Text,
                                                                            txtPlanta.Text,
                                                                            txtFacturaProveedor.Text,
                                                                            tabla.Rows[i]["NumeroParte"].ToString(),
                                                                            tabla.Rows[i]["Descripcion"].ToString(),
                                                                            tabla.Rows[i]["ProveedorID"].ToString(),
                                                                            tabla.Rows[i]["NombreProveedor"].ToString(),
                                                                            tabla.Rows[i]["UnidadMedida"].ToString(),
                                                                            tabla.Rows[i]["Pais"].ToString(),
                                                                            tabla.Rows[i]["Moneda"].ToString(),
                                                                            Bultos,
                                                                            txtComentario.Text,
                                                                            tabla.Rows[i]["ProgramaId"].ToString(),
                                                                            Convert.ToDecimal(tabla.Rows[i]["Precio"]))),
                                Convert.ToInt32(tabla.Rows[i]["Id"]),
                                    Convert.ToInt32(tabla.Rows[i]["RenglonId"]),
                                         txtNoGuia.Text);



                
            }

            



        }

        private void txtPais_KeyDown(object sender, KeyEventArgs e)
        {
       //     Up(e, txtFacturaProveedor);
            Down(e, txtCantidadRecibida);
           // Enter(e, txtCantidadRecibida);
        }



        string LimpiaGuia(string guia)
        {
            string resultado = "";

            resultado = guia.Replace(" ", "");
            //     resultado = guia.Replace("(","-");
            //  resultado = guia.Replace(")", "");


            return resultado;
        }

        private void txtPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnGuardar_Click(0, e);
            }
        }

        private void txtPlanta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnGuardar_Click(0, e);
            }
        }

        private void txtCantidadRecibida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnGuardar_Click(0, e);
            }
        }

        private void txtFacturaProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnGuardar_Click(0, e);
            }
        }

        private void txtNoGuia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnGuardar_Click(0, e);
            }
        }

        private void txtBultos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnGuardar_Click(0, e);
            }
        }




    }
}