using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MaterialCore.MaterialesMQ
{

    //crear Log de insersiones borrados y updates.







    public partial class ReciborMQ : Form
    {

        #region copi
                string _PO ; 
                string _Cliente ;
        string _Renglon;
                string _Proveedor ; 
                string _Transportista ;
                string _NoGuia ; 
                string _CantPiezas ; 
                string _UnidadMedida ; 
                string _Descripcion ; 
                string _Marca ; 
                string _Modelo ; 
                string _Serie ;
                string _PaisOrigen ; 
                string _PesoBruto ; 
                string _CantBultos ; 
                string _TipoBulto ; 
                string _ContenidoTipoBulto ; 
                string _Comentario ; 
                string _NoParte ; 
                string _FechaRecibido ; 
                string _CantRecibida ;
                string _Moneda ; 
                string _Consecutivo2 ; 
                string _NombreProveedor ; 
                string _FacturaImportacion ; 
                int _id_padre;
        #endregion

        Clases.Bitacora _Bitacora = new MaterialCore.Clases.Bitacora();

        string _sFacturaProveedor = "";
        string _sNoGuia = "";

        bool _ClonarNoParte = false;
        string _DirTXT;
        public ReciborMQ()
        {
            InitializeComponent();
        }

        private void ReciborMQ_Load(object sender, EventArgs e)
        {
            _DirTXT = System.Configuration.ConfigurationManager.AppSettings["dirPDF"].ToString();
         


            // TODO: This line of code loads data into the 'catalogos.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.catalogos.Clientes);

            cmbCliente.SelectedValue = 70;
            SelectMQNoEnviados();

            mtxtFecha1.Text = DateTime.Now.AddDays(-3).ToString("MM/dd/yyy");
            mtxtFecha2.Text = DateTime.Now.ToString("MM/dd/yyy");


        }
        #region HotKeys
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Home:

                    txtBuscarPO.Focus();
                    txtBuscarPO.SelectAll();

                    return true;

                case Keys.Control | Keys.G:
                  btnEditar_Click(0,null);

                    return true;

                case Keys.Escape: 


                    return true;

                case Keys.Control | Keys.S:

                    return true;

                case Keys.Control | Keys.D:

                    btnCopiarPartida_Click(0, null);

                    return true;

                case Keys.Control | Keys.P:
                    PegarInfo();
                    return true;
            }
            return false;
        }
        #endregion
     

    /*    void SelectMQbyID2()
        {
            if (dgbMQ.RowCount > 0)
            {

                materialesMaquinariaBindingSource.Position = dgbMQ.CurrentRow.Index;

                txtOCId.Text = maquinaria.MaterialesMaquinaria[materialesMaquinariaBindingSource.Position]["MaterialesOCId"].ToString();
                cmbCliente.SelectedValue = Convert.ToInt32(maquinaria.MaterialesMaquinaria[materialesMaquinariaBindingSource.Position]["ClienteId"]);
                txtRenglon.Text = maquinaria.MaterialesMaquinaria[materialesMaquinariaBindingSource.Position]["RenglonId"].ToString();
                txtProveedor.Text = maquinaria.MaterialesMaquinaria[materialesMaquinariaBindingSource.Position]["Proveedor"].ToString();
                txtTransportista.Text = maquinaria.MaterialesMaquinaria[materialesMaquinariaBindingSource.Position]["Transportista"].ToString();
                txtNoGuia.Text = maquinaria.MaterialesMaquinaria[materialesMaquinariaBindingSource.Position]["NumeroGuia"].ToString();
                txtCantPiezas.Text = maquinaria.MaterialesMaquinaria[materialesMaquinariaBindingSource.Position]["CantidadPiezas"].ToString();
                txtUnidadMedida.Text = maquinaria.MaterialesMaquinaria[materialesMaquinariaBindingSource.Position]["UnidadMedida"].ToString();
                txtDescripcion.Text = maquinaria.MaterialesMaquinaria[materialesMaquinariaBindingSource.Position]["Descripcion"].ToString();
                txtMarca.Text = maquinaria.MaterialesMaquinaria[materialesMaquinariaBindingSource.Position]["Marca"].ToString();
                txtModelo.Text = maquinaria.MaterialesMaquinaria[materialesMaquinariaBindingSource.Position]["Modelo"].ToString();
                txtSerie.Text = maquinaria.MaterialesMaquinaria[materialesMaquinariaBindingSource.Position]["Serie"].ToString();
                txtPaisOrigen.Text = maquinaria.MaterialesMaquinaria[materialesMaquinariaBindingSource.Position]["PaisOrigen"].ToString();
                txtPesoBruto.Text = maquinaria.MaterialesMaquinaria[materialesMaquinariaBindingSource.Position]["PesoBruto"].ToString();
                txtCantBultos.Text = maquinaria.MaterialesMaquinaria[materialesMaquinariaBindingSource.Position]["CantidadBultos"].ToString();
                txtTipoBulto.Text = "BU";//maquinaria.MaterialesMaquinaria[materialesMaquinariaBindingSource.Position]["TipoBulto"].ToString();
                txtContenidoTipoBulto.Text = "BU";
                txtFechaRecibido.Text = maquinaria.MaterialesMaquinaria[materialesMaquinariaBindingSource.Position]["FechaRecibo"].ToString();
                txtComentario.Text = maquinaria.MaterialesMaquinaria[materialesMaquinariaBindingSource.Position]["Comentarios"].ToString();
              //  txtFacturaImportacion.Text = maquinaria.MaterialesMaquinaria[materialesMaquinariaBindingSource.Position]["FacturaImportacion"].ToString();
                //txtFechaImportacion.Text = maquinaria.MaterialesMaquinaria[materialesMaquinariaBindingSource.Position]["FechaImportacion"].ToString();
              //  txtStatus.Text = maquinaria.MaterialesMaquinaria[materialesMaquinariaBindingSource.Position]["Estado"].ToString();
                txtNoParte.Text = maquinaria.MaterialesMaquinaria[materialesMaquinariaBindingSource.Position]["NumeroParte"].ToString();
               txtCantRecibida.Text = maquinaria.MaterialesMaquinaria[materialesMaquinariaBindingSource.Position]["CantidadRecibida"].ToString();
                txtMoneda.Text = maquinaria.MaterialesMaquinaria[materialesMaquinariaBindingSource.Position]["Moneda"].ToString();
            }

        }*/

        void SelectMQbyID()
        {
            if (dgbMQ.RowCount > 0)
            {
                txtOCId.Text = dgbMQ.CurrentRow.Cells["gPO"].Value.ToString();
                cmbCliente.SelectedValue = Convert.ToInt32( dgbMQ.CurrentRow.Cells["gClienteId"].Value);
                txtRenglon.Text = dgbMQ.CurrentRow.Cells["gLinea"].Value.ToString();
                txtProveedor.Text = dgbMQ.CurrentRow.Cells["gProveedor"].Value.ToString();
                txtTransportista.Text = dgbMQ.CurrentRow.Cells["gTransportista"].Value.ToString();

                if (dgbMQ.CurrentRow.Cells["gNoGuia"].Value.ToString() != "")
                    txtNoGuia.Text = dgbMQ.CurrentRow.Cells["gNoGuia"].Value.ToString();
                else
                    txtNoGuia.Text = _sNoGuia;

                txtCantPiezas.Text = dgbMQ.CurrentRow.Cells["gCantidadPriezas"].Value.ToString();

                if (dgbMQ.CurrentRow.Cells["gUnidadMedida"].Value.ToString() != "")
                    txtUnidadMedida.Text = dgbMQ.CurrentRow.Cells["gUnidadMedida"].Value.ToString();
                else
                    txtUnidadMedida.Text = "EA";

                txtDescripcion.Text = dgbMQ.CurrentRow.Cells["gDescripcion"].Value.ToString();
                txtMarca.Text = dgbMQ.CurrentRow.Cells["gMarca"].Value.ToString();
                txtModelo.Text = dgbMQ.CurrentRow.Cells["gModelo"].Value.ToString();
                txtSerie.Text = dgbMQ.CurrentRow.Cells["gSerie"].Value.ToString();
                txtPaisOrigen.Text = dgbMQ.CurrentRow.Cells["gPais"].Value.ToString();
                //txtPesoBruto.Text = Convert.ToDecimal(dgbMQ.CurrentRow.Cells["gPesoBruto"].Value.ToString()).ToString("N2");
                //txtCantBultos.Text = Convert.ToDecimal(dgbMQ.CurrentRow.Cells["gCantBultos"].Value.ToString()).ToString("N0");
                txtPesoBruto.Text = dgbMQ.CurrentRow.Cells["gPesoBruto"].Value.ToString();
                txtCantBultos.Text = dgbMQ.CurrentRow.Cells["gCantBultos"].Value.ToString();
                txtTipoBulto.Text = "BU";//dgbMQ.CurrentRow.Cells["gTipoBulto"].Value.ToString();
                txtContenidoTipoBulto.Text = "BU";//dgbMQ.CurrentRow.Cells["gContenidoTipoBulto"].Value.ToString();
                txtComentario.Text = dgbMQ.CurrentRow.Cells["gComentario"].Value.ToString();
                txtNoParte.Text = dgbMQ.CurrentRow.Cells["gNoParte"].Value.ToString();


                try
                {
                    txtFechaRecibido.Text = Convert.ToDateTime(dgbMQ.CurrentRow.Cells["gFechaRecibo"].Value).ToString("dd-MM-yyyy HH:mm");
                }
                catch
                {
                    txtFechaRecibido.Text = "";
                }

                //txtCantRecibida.Text = Convert.ToInt32(dgbMQ.CurrentRow.Cells["gCantidadRecibida"].Value.ToString()).ToString("N2");
                txtCantRecibida.Text = dgbMQ.CurrentRow.Cells["gCantidadRecibida"].Value.ToString();
                txtMoneda.Text = dgbMQ.CurrentRow.Cells["gMoneda"].Value.ToString();
                txtConsecutivo2.Text = dgbMQ.CurrentRow.Cells["gConsecutivo"].Value.ToString();
                txtNombreProveedor.Text = dgbMQ.CurrentRow.Cells["gNombreProveedor"].Value.ToString();


                if (dgbMQ.CurrentRow.Cells["gFacturaProveedor"].Value.ToString() != "")
                    txtFacturaImportacion.Text = dgbMQ.CurrentRow.Cells["gFacturaProveedor"].Value.ToString();
                else
                    txtFacturaImportacion.Text = _sFacturaProveedor;

                if (txtOCId.Text != "0")
                {
                    txtOCId.ReadOnly = true;
                    txtRenglon.ReadOnly = true;
               //     txtNoParte.ReadOnly = true;
                }
                else
                {
                    txtOCId.ReadOnly = false;
                    txtRenglon.ReadOnly = false;
                 //   txtNoParte.ReadOnly = false;
                }
            }

        }

        void SelectMQProcesados()
        {
            string fecha1 = mtxtFecha1.Text;
            string fecha2 = mtxtFecha2.Text;

            DateTime dfecha1;
            DateTime dfecha2;

            dfecha1 = DateTime.ParseExact(fecha1 + " 01:00:01", "MM/dd/yyyy HH:mm:ss", null);
            dfecha2 = DateTime.ParseExact(fecha2 + " 23:59:59", "MM/dd/yyyy HH:mm:ss", null);



            try
            {
                this.materialesMaquinariaTableAdapter.FillByProcesados(this.maquinaria.MaterialesMaquinaria, dfecha1, dfecha2);
                FormatoColorGrid();
            }
            catch
            {
                MessageBox.Show("Verifique las fechas.","Error");
            }
            
        }

        void SelectMQNoEnviados()
        {
            chkProcesados.Checked = false;
            this.materialesMaquinariaTableAdapter.FillByNoEnviados(this.maquinaria.MaterialesMaquinaria);
            FormatoColorGrid();
        }


        void InsertMQ()
        {
            this.materialesMaquinariaTableAdapter.InsertQuery(ALong(txtOCId.Text),
                                                        Convert.ToInt32(cmbCliente.SelectedValue),
                                                        AInteger(txtRenglon.Text),
                                                        txtNoParte.Text,
                                                        ADecimal(txtCantPiezas.Text),
                                                        txtUnidadMedida.Text,
                                                   ADecimal(txtPesoNeto.Text),
                                                        ADecimal(txtPesoBruto.Text),
                                                        txtPaisOrigen.Text,
                                                        ADecimal(txtCantBultos.Text),
                                                        txtTipoBulto.Text,
                                                     txtContenidoTipoBulto.Text,
                                                        txtNoGuia.Text,
                                                        txtMarca.Text,
                                                        txtModelo.Text,
                                                        txtSerie.Text,
                                                        false, txtDescripcion.Text,
                                                        txtProveedor.Text,
                                                        txtTransportista.Text,
                                                        AFecha(txtFechaRecibido.Text),
                                                        txtComentario.Text,
                                                        ADecimal(txtFacturaImportacion.Text),
                                                        AFecha(txtFechaImportacion.Text),
                                                        txtStatus.Text,
                                                        ADecimal(txtCantRecibida.Text),
                                                        txtMoneda.Text);
        }

        void UpdateMQ()
        {
            //validar si esta bloqueado el textbox de PO, si si hace el update normal, si no

          //si no evalua si el po y linea existen en meq y actualiza normal, tambien evalua si existe en maquinaria pera no repeter renglones

         int id = Convert.ToInt32(dgbMQ.CurrentRow.Cells["gid"].Value);

            if (txtOCId.ReadOnly == true)// si es un update normal para una po valida
            {

                if (txtFacturaImportacion.Text != "")
                    _sFacturaProveedor = txtFacturaImportacion.Text;

                _sNoGuia = txtNoGuia.Text;

                this.materialesMaquinariaTableAdapter.UpdateQuery(
                    ALong(txtOCId.Text),
                                                             Convert.ToInt32(cmbCliente.SelectedValue),
                                                            AInteger(txtRenglon.Text),
                                                            txtNoParte.Text,
                                                             ADecimal(txtCantPiezas.Text),
                                                            txtUnidadMedida.Text,
                                                            ADecimal(txtPesoNeto.Text),
                                                             ADecimal(txtPesoBruto.Text),
                                                            txtPaisOrigen.Text,
                                                             ADecimal(txtCantBultos.Text),
                                                            txtTipoBulto.Text,
                                                           txtContenidoTipoBulto.Text,
                                                            txtNoGuia.Text,
                                                            txtMarca.Text,
                                                            txtModelo.Text,
                                                            txtSerie.Text,
                                                            false, txtDescripcion.Text,
                                                            txtProveedor.Text,
                                                            txtTransportista.Text,
                                                            AFecha(txtFechaRecibido.Text),
                                                            txtComentario.Text,
                                                            ADecimal(txtCantRecibida.Text),
                                                            txtMoneda.Text,
                                                            Convert.ToInt32(txtConsecutivo2.Text),
                                                                      txtNombreProveedor.Text,
                                                                      txtFacturaImportacion.Text,
                                                             Convert.ToInt32(dgbMQ.CurrentRow.Cells["gid"].Value)
                                                             );

                _Bitacora.MeqActualizo( id,Convert.ToInt64(txtOCId.Text),
                       Convert.ToInt32(txtRenglon.Text), txtNoGuia.Text);

                 SelectMeQ();

                MostrarGuardado();
                //index del renglon guardado despues de actualizar;
                SeleccionarLinea2(id);


            }
            else//para una po sin po
            {
                if (txtOCId.Text == "0")//update si validar normal
                {
                    txtRenglon.Text = "0";


                    if (txtFacturaImportacion.Text != "")
                        _sFacturaProveedor = txtFacturaImportacion.Text;

                    _sNoGuia = txtNoGuia.Text;

               this.materialesMaquinariaTableAdapter.UpdateQuery(
                ALong(txtOCId.Text),
                                                         Convert.ToInt32(cmbCliente.SelectedValue),
                                                        AInteger(txtRenglon.Text),
                                                        txtNoParte.Text,
                                                         ADecimal(txtCantPiezas.Text),
                                                        txtUnidadMedida.Text,
                                                        ADecimal(txtPesoNeto.Text),
                                                         ADecimal(txtPesoBruto.Text),
                                                        txtPaisOrigen.Text,
                                                         ADecimal(txtCantBultos.Text),
                                                        txtTipoBulto.Text,
                                                       txtContenidoTipoBulto.Text,
                                                        txtNoGuia.Text,
                                                        txtMarca.Text,
                                                        txtModelo.Text,
                                                        txtSerie.Text,
                                                        false, txtDescripcion.Text,
                                                        txtProveedor.Text,
                                                        txtTransportista.Text,
                                                        AFecha(txtFechaRecibido.Text),
                                                        txtComentario.Text,
                                                        ADecimal(txtCantRecibida.Text),
                                                        txtMoneda.Text,
                                                        Convert.ToInt32(txtConsecutivo2.Text),
                                                                  txtNombreProveedor.Text,
                                                                  txtFacturaImportacion.Text,
                                                         Convert.ToInt32(dgbMQ.CurrentRow.Cells["gid"].Value)
                                                         );
               _Bitacora.MeqActualizo(id, Convert.ToInt64(txtOCId.Text),
                          Convert.ToInt32(txtRenglon.Text), txtNoGuia.Text);

               SelectMeQ();
                    MostrarGuardado();
                       SeleccionarLinea2(id);
                }
                else//update validando si existe la po en la base de datos
                {
                          DataSets.MaquinariaTableAdapters.MaterialesOCMeQTableAdapter da = new MaterialCore.DataSets.MaquinariaTableAdapters.MaterialesOCMeQTableAdapter();
                DataSets.Maquinaria.MaterialesOCMeQDataTable tabla = new MaterialCore.DataSets.Maquinaria.MaterialesOCMeQDataTable();

                da.FillbyPO(
                    tabla, Convert.ToInt64(txtOCId.Text), Convert.ToInt32(txtRenglon.Text));

                if (tabla.Rows.Count > 0)
                {
                    //VALIDACION PARA NO REPETIR POS NI RENGLON
                    //if (tabla.Rows[0]["MaterialesMaquinariaID"].ToString() == "0")
                    //{
                        DataSets.MaquinariaTableAdapters.MaterialesMaquinariaTableAdapter daM = new MaterialCore.DataSets.MaquinariaTableAdapters.MaterialesMaquinariaTableAdapter();
                       
                       //update especial para cargar la info de la po que si eciste en este caso

                        if (txtFacturaImportacion.Text != "")
                            _sFacturaProveedor = txtFacturaImportacion.Text;

                        _sNoGuia = txtNoGuia.Text;

                        txtProveedor.Text = tabla.Rows[0]["ProveedorID"].ToString();
                        txtNombreProveedor.Text = tabla.Rows[0]["NombreProveedor"].ToString();


                        this.materialesMaquinariaTableAdapter.UpdateQuery(
                                                        ALong(txtOCId.Text),
                                                        Convert.ToInt32(cmbCliente.SelectedValue),
                                                        AInteger(txtRenglon.Text),
                                                        txtNoParte.Text,
                                                        ADecimal(txtCantPiezas.Text),
                                                        txtUnidadMedida.Text,
                                                        ADecimal(txtPesoNeto.Text),
                                                        ADecimal(txtPesoBruto.Text),
                                                        txtPaisOrigen.Text,
                                                        ADecimal(txtCantBultos.Text),
                                                        txtTipoBulto.Text,
                                                        txtContenidoTipoBulto.Text,
                                                        txtNoGuia.Text,
                                                        txtMarca.Text,
                                                        txtModelo.Text,
                                                        txtSerie.Text,
                                                        false, txtDescripcion.Text,
                                                        txtProveedor.Text,
                                                        txtTransportista.Text,
                                                        AFecha(txtFechaRecibido.Text),
                                                        txtComentario.Text,
                                                        ADecimal(txtCantRecibida.Text),
                                                        txtMoneda.Text,
                                                        Convert.ToInt32(txtConsecutivo2.Text),
                                                        txtNombreProveedor.Text,
                                                        txtFacturaImportacion.Text,
                                                        Convert.ToInt32(dgbMQ.CurrentRow.Cells["gid"].Value)
                                                         );
                        _Bitacora.MeqActualizo(id, Convert.ToInt64(txtOCId.Text),
                                        Convert.ToInt32(txtRenglon.Text), txtNoGuia.Text);

                        SelectMeQ(); 
                        MostrarGuardado();
                        SeleccionarLinea2(id);
                  

                    //} VALIDACION PARA NO REPETIR POS Y RENGLON
                    //else
                    //{
                    //    MessageBox.Show("Esta PO y linea ya ha sido agregada anteriormente");
                    //    txtBuscarPO.Focus();
                    //    txtBuscarPO.SelectAll();
                    //}
                }
                else
                {
                    MessageBox.Show("No existe la PO y linea");
                    txtBuscarPO.Focus();
                    txtBuscarPO.SelectAll();
                    return;
                    //borrar textos de POs
                }
                }

            }
                                                        
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgbMQ.RowCount > 0 )
            {
                if (txtNoGuia.Text.ToUpper() != "LOCAL")
                {
                    if (!ValidarGuia(txtNoGuia.Text, 70))
                    {
                        txtNoGuia.Focus();
                        return;
                    }
                }
                else//si la guia es local
                {
                    txtTransportista.Text = "LOCAL";
                    txtFechaRecibido.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm");
                }

                if (txtPaisOrigen.Text == "")
                {
                    MessageBox.Show("Falta capturar el Pais", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtPaisOrigen.Focus();
                    return;
                }

                // if (txtNoParte.Text == "")
                //{
                //    MessageBox.Show("Falta capturar el Numero de parte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                //    txtNoParte.Focus();
                //    return;
                //}

                if (txtUnidadMedida.Text == "")
                {
                    MessageBox.Show("Falta capturar la Unidad de medida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtUnidadMedida.Focus();
                    return;
                }


                //validar que los datos esten correctos igual  que en insertar.

                if (txtModelo.Text == "")
                    txtModelo.Text = "SIN MODELO";

                if (txtSerie.Text == "")
                    txtSerie.Text = "SIN SERIE";

                if (txtMarca.Text == "")
                    txtMarca.Text = "SIN MARCA";



                UpdateMQ();

                if (!ValidarGuiaDigitalizada(txtNoGuia.Text))
                {
                    //Validar si ya se digitalizo el numero de guia
                    OrdenesCompra.EscanearPL escaner = new MaterialCore.OrdenesCompra.EscanearPL(txtNoGuia.Text);
                    escaner.ShowDialog();


                }

           
               // SelectMQNoEnviados();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            int indexScrol;
    
            if (dgbMQ.RowCount > 0 )
            {
                if (DialogResult.Yes ==
                    MessageBox.Show("Si la partida a borrar es padre, tambien se borraran sus hijos, ¿Está seguro de borrar el registro? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1))
                {
                   // materialesMaquinariaBindingSource.Position = dgbMQ.CurrentRow.Index; //coloca el index del binding igual que en el grid

                    indexScrol = dgbMQ.FirstDisplayedScrollingRowIndex;
       


                    this.materialesMaquinariaTableAdapter.DeleteQuery(
                        Convert.ToInt32(dgbMQ.CurrentRow.Cells["gid"].Value)
               );
                    SelectMeQ();

                    dgbMQ.FirstDisplayedScrollingRowIndex =indexScrol;
               //     dgbMQ.CurrentCell = indexRenglon;

                   


                }
            }
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
          //validar guia





            //VAlidar que todos los datos esten en formato correcto

            //validar que no se repirta maquinaria 

            InsertMQ();
            SelectMQNoEnviados();
        }

        //conviertes string a fecha, entero y decmal con posibilidad de regresar null cuando es ""
        //espacio en blanco

        DateTime? AFecha(string textofecha)
        {
            DateTime? fecha;
            string formato = "dd-MM-yyyy HH:mm";

            if (textofecha == "")
            {
                fecha = null;
            }
            else
            {
                fecha = DateTime.ParseExact(textofecha, formato, null);
            }
            return fecha;
        }

        decimal? ADecimal(string numero)
        {
            decimal? resultado;

            if (numero == "")
                resultado = null;
            else
                resultado = Convert.ToDecimal(numero);

            return resultado;
        }

        Int32? AInteger(string numero)
        {
            Int32? resultado;

            if (numero == "")
                resultado = null;
            else
                resultado = Convert.ToInt32(numero);

            return resultado;
        }

        Int64? ALong(string numero)
        {
            Int64? resultado;

            if (numero == "")
                resultado = null;
            else
                resultado = Convert.ToInt64(numero);

            return resultado;
        }

        //private void btnPDF_Click(object sender, EventArgs e)
        //{
        //    DataSets.MaquinariaTableAdapters.GenerarTXTTableAdapter txtTA = new MaterialCore.DataSets.MaquinariaTableAdapters.GenerarTXTTableAdapter();
        //    DataSets.Maquinaria.GenerarTXTDataTable txtDT = new MaterialCore.DataSets.Maquinaria.GenerarTXTDataTable();

        //    string directorio = ConfigurationManager.AppSettings["dirPDF"].ToString() + "\\MEQ - " + DateTime.Now.ToString("yyyyMMdd") + "\\";

        //    if (!System.IO.Directory.Exists(directorio))
        //    {
        //        System.IO.Directory.CreateDirectory(directorio);
        //    }
            
        //    string nombreArchivo = directorio + "MEQ -  " + DateTime.Now.ToString("HHmmss") + ".txt";
           
        //    //70 se puede cambiar por cliente
        //    //txtTA.Fill(txtDT, 70);

        //    //Clases.ExportarTXT ojbTXT = new MaterialCore.Clases.ExportarTXT();
        //    //ojbTXT.exportarMQ(nombreArchivo, txtDT);

        //    MessageBox.Show("Archivo creado correctamente");
        //    SelectMQNoEnviados();


        //    Clases.MeQExcel GDC = new MaterialCore.Clases.MeQExcel(ConfigurationManager.AppSettings["dirPDF"].ToString(),Convert.ToInt32(txtca );
 
        //    if (GDC.mensaje == "")
        //        MessageBox.Show("Datos complementarios creados correctamente en el directorio: " + ConfigurationManager.AppSettings["dirPDF"].ToString());
        //    else
        //        MessageBox.Show(GDC.mensaje);



        //}





        #region Validaciones


    /*    private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8 && e.KeyChar != 46) || e.KeyChar > 57)
            {
                e.Handled = true;
            }
        }*/

        bool EsNumero(string numero)
        {
            bool resultado = true;

            if (numero != "")
            {
                try
                {
                    Convert.ToInt32(numero);
                }
                catch
                {
                    resultado = false;
                }
            }

            return resultado;
        }




        #endregion

        private void dgbMQ_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectMQbyID();
        }

        private void dgbMQ_SelectionChanged(object sender, EventArgs e)
        {
            SelectMQbyID();
        }



        bool ValidarGuia(string sku, int cliente)
        {
            Clases.Bultos bulto = new MaterialCore.Clases.Bultos(sku);

            if (bulto.BultoValidacion(sku, true, true))
            {
                if (bulto.idCliente == cliente)
                {

                    DataTable tabla = bulto.infoSKUCarrier(sku);
                 if (tabla.Rows.Count > 0)
                 {
                     txtTransportista.Text = tabla.Rows[0]["nombre"].ToString();
                     txtFechaRecibido.Text = Convert.ToDateTime(tabla.Rows[0]["dfecha_sku"]).ToString("dd-MM-yyyy HH:mm");
                 }

                    //cargar transportista y fecha en txtbox
                    return true;
                }

                else
                {
                    MessageBox.Show("El cliente asociado a este bulto no es de Labinal");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Clases.Conexion conn = new MaterialCore.Clases.Conexion();
            SqlDataReader datos;
           

            if (txtConsecutivo1.Text == "")
            {
                MessageBox.Show("Debe de especificar un consecutivo","Error");
                txtConsecutivo1.Focus();
                return;
            }



            if (txtBuscarPO.Text == "")
            {
                txtBuscarPO.Text = "0";
            }
            if (txtBuscarPO.Text == "0")
            {

                string sql = string.Format("Select Identidad =  IDENT_CURRENT('MaterialesMaquinaria')  + 1");
                datos = conn.getLector(sql);
                if (datos.Read())
                {
                    _id_padre = int.Parse(datos["Identidad"].ToString());
                }
                this.materialesMaquinariaTableAdapter.InsertByConsIdPadre(Convert.ToInt32(txtConsecutivo1.Text.Trim()), _id_padre);
                SelectMQNoEnviados();
                SeleccionarLinea2(_id_padre);
            }
            else//si es diferente de 0 la po a incresar
            {


                MaterialesMQ.LineasPO ven = new LineasPO(Convert.ToInt64(txtBuscarPO.Text));
                ven.ShowDialog();


                if (ven._Resultado == true)
                {

                    DataSets.MaquinariaTableAdapters.MaterialesMaquinariaTableAdapter daM = new MaterialCore.DataSets.MaquinariaTableAdapters.MaterialesMaquinariaTableAdapter();
                    int id;
                    id = Convert.ToInt32(daM.InsertPadre(
                                                                               ven._PO,
                                                                               ven._Cliente,
                                                                               ven._Linea,
                                                                        //       ven._NumeroParte,
                                                                               ven._DescripcionParte,
                                                                               ven._UnidadMedida,
                                                                               ven._ProveedorID,
                                                                               ven._Moneda,
                                                                               Convert.ToInt32(txtConsecutivo1.Text),
                                                                               ven._PqOrd,
                                                                               ven._PqRec,
                                                                               ven._NombreProveedor
                                                                               ));
                    //si es padre lo actualiza como padre
                    daM.UpdatePadreID(id);


                    _Bitacora.MeqInserto(                       
                        id, ven._PO, ven._Linea, null,false);

                    SelectMQNoEnviados();
                    SeleccionarLinea2(id);

                }
                else
                {
                    txtBuscarPO.Focus();
                    txtBuscarPO.SelectAll();
                }

            
            }
            //Busca PO y renglon del tipo MEQ en MaterialesOC
        }

        private void txtBuscarPO_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarPO.Text.Length >= 10)
            {
                btnBuscar_Click(0, e);
            }
        }

        void SeleccionarLinea(int PO, int Linea, int Identificador)
        {
            for (int i = 0; i < dgbMQ.Rows.Count; i++)
            {
                if ((PO == Convert.ToInt32(dgbMQ.Rows[i].Cells["gPO"].Value)) &&
                    (Linea == Convert.ToInt32(dgbMQ.Rows[i].Cells["gLinea"].Value)) &&
                     (Identificador == Convert.ToInt32(dgbMQ.Rows[i].Cells["gIdentificador"].Value)))
                {
                    dgbMQ.FirstDisplayedScrollingRowIndex = i;
                    dgbMQ.CurrentCell = dgbMQ[0, i];
                    SelectMQbyID();
                    return;
                }
            }
        }

        void SeleccionarLinea2(int id)
        {
            //para poder usar este, se necesita el id de renglon insertadob (identiti)
            for (int i = 0; i < dgbMQ.Rows.Count; i++)
            {
                if ((id == Convert.ToInt32(dgbMQ.Rows[i].Cells["gid"].Value)) )
                {
                    dgbMQ.FirstDisplayedScrollingRowIndex = i;
                    dgbMQ.CurrentCell = dgbMQ[0, i];
                    SelectMQbyID();
                    txtNoGuia.Focus();
                    return;
                }
            }
        }


        private void btnHijo_Click(object sender, EventArgs e)
        {
            int id;
            int idOrigen = Convert.ToInt32(dgbMQ.Rows[dgbMQ.CurrentRow.Index].Cells["gid"].Value);
            int po =  Convert.ToInt32(dgbMQ.Rows[dgbMQ.CurrentRow.Index].Cells["gPO"].Value);
            int linea = Convert.ToInt32(dgbMQ.Rows[dgbMQ.CurrentRow.Index].Cells["gLinea"].Value);
            string guia = dgbMQ.Rows[dgbMQ.CurrentRow.Index].Cells["gNoGuia"].Value.ToString();
            id = Convert.ToInt32(this.materialesMaquinariaTableAdapter.InsertHijo(idOrigen));
            _Bitacora.MeqInserto(id, po, linea, guia, true);
            SelectMeQ();
            SeleccionarLinea2(id);
        }



        private void txtBuscarPO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (txtBuscarPO.Text == "")
                {
                    txtBuscarPO.Text = "0";
                }
                btnBuscar_Click(0, e);
            }

        }

        private void txtNoGuia_Leave(object sender, EventArgs e)
        {
            //valida guia
            if (txtNoGuia.Text != "")
            {
                if (txtNoGuia.Text.ToUpper() != "LOCAL")
                {
                    if (!ValidarGuia(txtNoGuia.Text, 70))
                    {
                        txtNoGuia.Focus();
                        return;
                    }
                }
                else//si la guia es local
                {
                    txtTransportista.Text = "LOCAL";
                    txtFechaRecibido.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm");
                }
            }
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            CopiarInfo();

        }

        private void btnPegar_Click(object sender, EventArgs e)
        {
            PegarInfo();
        }

        void PegarInfo()
        {

            //    txtOCId.Text=_PO;
            //   txtRenglon.Text=_Renglon;

            txtProveedor.Text = _Proveedor;
            txtTransportista.Text = _Transportista;
            txtNoGuia.Text = _NoGuia;
            txtCantPiezas.Text = _CantPiezas;
            txtUnidadMedida.Text = _UnidadMedida;
            txtDescripcion.Text = _Descripcion;
            txtMarca.Text = _Marca;
            txtModelo.Text = _Modelo;
            txtSerie.Text = _Serie;
            txtPaisOrigen.Text = _PaisOrigen;
            txtPesoBruto.Text = _PesoBruto;
            txtCantBultos.Text = _CantBultos;
            txtTipoBulto.Text = _TipoBulto;
            txtContenidoTipoBulto.Text = _ContenidoTipoBulto;
            txtComentario.Text = _Comentario;
            txtNoParte.Text = _NoParte;
            txtFechaRecibido.Text = _FechaRecibido;
            txtCantRecibida.Text = _CantRecibida;
            txtMoneda.Text = _Moneda;
            txtConsecutivo2.Text = _Consecutivo2;
            txtNombreProveedor.Text = _NombreProveedor;
            txtFacturaImportacion.Text = _FacturaImportacion;
        }


        void CopiarInfo()
        {
            //     _PO = dgbMQ.CurrentRow.Cells["gPO"].Value.ToString();
            ////    _Cliente = Convert.ToInt32( dgbMQ.CurrentRow.Cells["gClienteId"].Value);
            //    _Renglon = dgbMQ.CurrentRow.Cells["gLinea"].Value.ToString();
            //    _Proveedor = dgbMQ.CurrentRow.Cells["gProveedor"].Value.ToString();
            //    _Transportista = dgbMQ.CurrentRow.Cells["gTransportista"].Value.ToString();
            //    _NoGuia = dgbMQ.CurrentRow.Cells["gNoGuia"].Value.ToString();
            //    _CantPiezas = dgbMQ.CurrentRow.Cells["gCantidadPriezas"].Value.ToString();
            //    _UnidadMedida = dgbMQ.CurrentRow.Cells["gUnidadMedida"].Value.ToString();
            //    _Descripcion = dgbMQ.CurrentRow.Cells["gDescripcion"].Value.ToString();
            //    _Marca = dgbMQ.CurrentRow.Cells["gMarca"].Value.ToString();
            //    _Modelo = dgbMQ.CurrentRow.Cells["gModelo"].Value.ToString();
            //    _Serie = dgbMQ.CurrentRow.Cells["gSerie"].Value.ToString();
            //    _PaisOrigen = dgbMQ.CurrentRow.Cells["gPais"].Value.ToString();
            //    _PesoBruto = dgbMQ.CurrentRow.Cells["gPesoBruto"].Value.ToString();
            //    _CantBultos = dgbMQ.CurrentRow.Cells["gCantBultos"].Value.ToString();
            //    _TipoBulto = "BU";//dgbMQ.CurrentRow.Cells["gTipoBulto"].Value.ToString();
            //    _ContenidoTipoBulto = "BU";//dgbMQ.CurrentRow.Cells["gContenidoTipoBulto"].Value.ToString();
            //    _Comentario = dgbMQ.CurrentRow.Cells["gComentario"].Value.ToString();
            //    _NoParte = dgbMQ.CurrentRow.Cells["gNoParte"].Value.ToString();
            //    _FechaRecibido = Convert.ToDateTime(dgbMQ.CurrentRow.Cells["gFechaRecibo"].Value).ToString("yyyy-MM-dd HH:mm");
            //    _CantRecibida = dgbMQ.CurrentRow.Cells["gCantidadRecibida"].Value.ToString();
            //    _Moneda = dgbMQ.CurrentRow.Cells["gMoneda"].Value.ToString();
            //    _Consecutivo2 = dgbMQ.CurrentRow.Cells["gConsecutivo"].Value.ToString();
            //    _NombreProveedor = dgbMQ.CurrentRow.Cells["gNombreProveedor"].Value.ToString();
            //    _FacturaImportacion = dgbMQ.CurrentRow.Cells["gFacturaProveedor"].Value.ToString();

            _PO = txtOCId.Text;
            _Renglon = txtRenglon.Text;
            _Proveedor = txtProveedor.Text;
            _Transportista = txtTransportista.Text;
            _NoGuia = txtNoGuia.Text;
            _CantPiezas = txtCantPiezas.Text;
            _UnidadMedida = txtUnidadMedida.Text;
            _Descripcion = txtDescripcion.Text;
            _Marca = txtMarca.Text;
            _Modelo = txtModelo.Text;
            _Serie = txtSerie.Text;
            _PaisOrigen = txtPaisOrigen.Text;
            _PesoBruto = txtPesoBruto.Text;
            _CantBultos = txtCantBultos.Text;
            _TipoBulto = txtTipoBulto.Text;
            _ContenidoTipoBulto = txtContenidoTipoBulto.Text;
            _Comentario = txtComentario.Text;
            _NoParte = txtNoParte.Text;
            _FechaRecibido = txtFechaRecibido.Text;
            _CantRecibida = txtCantRecibida.Text;
            _Moneda = txtMoneda.Text;
            _Consecutivo2 = txtConsecutivo2.Text;
            _NombreProveedor = txtNombreProveedor.Text;
            _FacturaImportacion = txtFacturaImportacion.Text;
        }

        private void tmlblGuardado_Tick(object sender, EventArgs e)
        {
            tmlblGuardado.Enabled = false;
            lblGuardada.Visible = false;


        }
        void MostrarGuardado()
        {
            lblGuardada.Visible = true;
            tmlblGuardado.Enabled = false;
            tmlblGuardado.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaterialesMQ.form forma = new form();

            forma.ShowDialog();
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

        private void txtConsecutivo1_KeyDown(object sender, KeyEventArgs e)
        {
    
        }

        private void txtOCId_KeyDown(object sender, KeyEventArgs e)
        {
            Intro(e, txtRenglon);
            Down(e, txtRenglon);
        }

        private void txtRenglon_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtOCId);
            Intro(e, txtProveedor);
            Down(e, txtProveedor);
        }

        private void txtNoParte_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtPesoBruto);
            Intro(e, txtDescripcion);
            Down(e, txtDescripcion);
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtNoParte);
            Intro(e, txtModelo);
            Down(e, txtModelo);
        }

        private void txtProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtRenglon);
            Intro(e, txtNombreProveedor);
            Down(e, txtNombreProveedor);
        }

        private void txtNombreProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtProveedor);
            Intro(e, txtUnidadMedida);
            Down(e, txtUnidadMedida);
        }

        private void txtUnidadMedida_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtNombreProveedor);
            Intro(e, txtConsecutivo2);
            Down(e, txtConsecutivo2);
        }

        private void txtConsecutivo2_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtUnidadMedida);
            Intro(e, txtNoGuia);
            Down(e, txtNoGuia);
        }

        private void txtNoGuia_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtConsecutivo2);
            Intro(e, txtCantRecibida);
            Down(e, txtCantRecibida);
        }

        private void txtCantRecibida_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtNoGuia);
            Intro(e, txtPaisOrigen);
            Down(e, txtPaisOrigen);
        }

        private void txtPaisOrigen_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtCantRecibida);
            Intro(e, txtFacturaImportacion);
            Down(e, txtFacturaImportacion);
        }

        private void txtFacturaImportacion_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtPaisOrigen);
            Intro(e, txtFechaRecibido);
            Down(e, txtFechaRecibido);
        }

        private void txtFechaRecibido_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtFacturaImportacion);
            Intro(e, txtCantBultos);
            Down(e, txtCantBultos);
        }

        private void txtCantBultos_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtFechaRecibido);
            Intro(e, txtPesoBruto);
            Down(e, txtPesoBruto);
        }

        private void txtPesoBruto_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtCantBultos);
            Intro(e, txtNoParte);
            Down(e, txtNoParte);
        }

        private void txtModelo_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtDescripcion);
            Intro(e, txtSerie);
            Down(e, txtSerie);
        }

        private void txtSerie_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtModelo);
            Intro(e, txtMarca);
            Down(e, txtMarca);
        }

        private void txtMarca_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtSerie);
            Intro(e, txtComentario);
            Down(e, txtComentario);
        }

        private void txtComentario_KeyDown(object sender, KeyEventArgs e)
        {
            Up(e, txtMarca);

        }

        private void txtComentario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnEditar_Click(0, e);
            }
        }

        private void txtConsecutivo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnBuscar_Click(0, e);
            }
        }

        private void dgbMQ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert /*|| e.KeyCode == Keys.Enter*/)
            {
                e.Handled = false;
                txtNoGuia.Focus();
            }
        }

        private void btnProcesados_Click(object sender, EventArgs e)
        {
            SelectMQProcesados();
            }

        private void chkProcesados_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProcesados.Checked)
            {
                pnlFiltroPRocesados.Visible = true;
            }
            else
            {
                pnlFiltroPRocesados.Visible = false;
                SelectMQNoEnviados();
            }


        }


        private void FormatoColorGrid()
        {

            for (int i = 0; i < dgbMQ.RowCount; i++)
            {
                dgbMQ.Rows[i].DefaultCellStyle.BackColor = Color.White;
                dgbMQ.Rows[i].DefaultCellStyle.ForeColor = Color.Black;


                if (Convert.ToInt32(dgbMQ.Rows[i].Cells["gIdentificador"].Value) == 0)
                {
                    dgbMQ.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(141, 180, 227);
                }
                else
                {
                    dgbMQ.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(197, 217, 241);

                }
            }
        }

        private void dgbMQ_Sorted(object sender, EventArgs e)
        {
            FormatoColorGrid();
        }

        private void txtNoParte_Enter(object sender, EventArgs e)
        {
            _ClonarNoParte = true;
        }

        private void txtNoParte_Leave(object sender, EventArgs e)
        {
            _ClonarNoParte = false;
        }

        private void txtNoParte_TextChanged(object sender, EventArgs e)
        {
            if (_ClonarNoParte)
            {
                txtModelo.Text = txtNoParte.Text;
            }
        }

        void ClonarPartida(int id )
        {
            MaterialesMQ.NumClones ventana = new NumClones();

            ventana.ShowDialog();

            if (ventana._Resultado == true)
            {
                for (int i = 0; i < ventana._Copias; i++)
                {
                    int identity =   Convert.ToInt32(this.materialesMaquinariaTableAdapter.InsertClonar(id));
                    this.materialesMaquinariaTableAdapter.UpdatePadreID(identity);

                    _Bitacora.MeqClono(identity);
                }

                MessageBox.Show("Partida clonada con éxito", "Aviso");
                SelectMeQ();
                SeleccionarLinea2(id);
            }
        }


        void SelectMeQ()
        {
            if (chkProcesados.Checked)
                SelectMQProcesados();
            else
                SelectMQNoEnviados();
        }

        private void btnCopiarPartida_Click(object sender, EventArgs e)
        {
            if (dgbMQ.RowCount > 0)
            {
                ClonarPartida(Convert.ToInt32(dgbMQ.CurrentRow.Cells["gid"].Value));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MaterialesMQ.LineasPO ven = new LineasPO(Convert.ToInt64(txtBuscarPO.Text));
            ven.ShowDialog();


            if (ven._Resultado == true)
            {
                MessageBox.Show("Debe de cargarla po y posisionarce en su info");
            }
            else
            {
                txtBuscarPO.Focus();
                txtBuscarPO.SelectAll();
            }
        }



        bool ValidarGuiaDigitalizada(string guia)
        {
            SqlDataReader datos;

            MaterialCore.Clases.Conexion conn = new MaterialCore.Clases.Conexion();
            bool resultado = true;

            datos = conn.getLector("SELECT     id, nid_sku, fecha, escaneado, nid_cliente " +
                                                "FROM         sku_escanear " +
                                                "WHERE     (nid_cliente = 70) AND (escaneado = 0) AND nid_sku = '" + guia + "'" +
                                                " ORDER BY fecha DESC");

            if (datos.Read())
            {
                resultado = false;
            }

            datos.Close();
            return resultado;
        }

        private void txtConsecutivo1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}