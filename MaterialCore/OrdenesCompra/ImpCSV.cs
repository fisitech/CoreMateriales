using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using ClosedXML.Excel;
//Excel
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.Threading;

namespace MaterialCore
{
    public partial class ImpCSV : Form
    {  
        public ImpCSV()
        {
            InitializeComponent();
        }

        //codigo para evitar que se abra varias veces la forma
        Clases.Bitacora _Bitacora = new MaterialCore.Clases.Bitacora();
        Clases.SSIS paquete = new MaterialCore.Clases.SSIS();
        private static ImpCSV m_FormDefInstance;
        public static ImpCSV DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new ImpCSV();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }


        public int RenglonesCSV(string dir)
        {
            FileStream fs = new FileStream(dir, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader archivo = new StreamReader(fs);

            int numero_renglones = 0;
            archivo.ReadLine();

            while (!archivo.EndOfStream)
            {
                numero_renglones++;
                archivo.ReadLine();
            }
            return numero_renglones+1;
            fs.Close();
            archivo.Close();
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtAutomatico.Checked)
            {
                lblDirCSV.Text =    System.Configuration.ConfigurationManager.AppSettings["dirCSV"].ToString();
                btnBuscar.Visible = false;

                lblMeQ.Text = System.Configuration.ConfigurationManager.AppSettings["dirXLSMeQ"].ToString();
                btnBuscarMeQ.Visible = false;
            }
            else
            {
                btnBuscar.Visible = true;
                lblDirCSV.Text = "";

                btnBuscarMeQ.Visible = true;
                lblMeQ.Text = "";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "Libro de Excel (*.xls,*.xlsx)|*.xls;*.xlsx"+
                             "|Archivo CSV (*.csv)|*.csv";
            dialogo.FilterIndex = 1;
            dialogo.Multiselect = false;
            dialogo.RestoreDirectory = true;

            DialogResult resultado = dialogo.ShowDialog();

            if (resultado == DialogResult.OK )
                lblDirCSV.Text = dialogo.FileName.ToString();
        }

        private bool ExtencionCorrecta(string archivo)
        {
            bool resultado = false;

            FileInfo extencion = new FileInfo(archivo);

            if (extencion.Extension == ".xls" || extencion.Extension == ".xlsx")
                resultado = true;

            return resultado;
        }

        //archivo CSV
        private bool CargaArchivo(string dir)
        {
            if (!File.Exists(dir))//si no existe el archivo 
            {
                MessageBox.Show("El archivo no existe");
                return false;
            }
            else
            {
                
                Barra.Value = 10;
                tslblEstado.Text = "Leyendo archivo de Excel.";
                paquete.Execute_Package(Application.StartupPath + @"\Paquetes\Materiales.dtsx", dir);
                statusStrip1.Refresh();
                //ExcelProvider provider = new ExcelProvider(dir,70);
                //DataTable registrosExcel = provider.GetWorkSheet("Open PO"); //cambio carlos el nombre de la hoja
                //Barra.Value = 65;

                //tslblEstado.Text = "Actualizando Base de datos.";
                //statusStrip1.Refresh();
                //this.BorrarMaterialesExcelOC();
                //Barra.Value = 75;
                //this.CopiarTablaBD("MaterialesExcelOC",registrosExcel);
                //statusStrip1.Refresh();
                //Barra.Value = 88;

                //tslblEstado.Text = "Sincronizando registros.";
                //statusStrip1.Refresh();
                //this.SincronizarOC();
                Barra.Value = 100;

                tslblEstado.Text = "Proceso finalizado";
                _Bitacora.MatImporto();
            //    MessageBox.Show("Archivo insertado a la base de datos");             
   
            }
            
            return true;
        }

        private bool CargaArchivoMeQ(string dir)
        {
            if (!File.Exists(dir))//si no existe el archivo 
            {
                MessageBox.Show("El archivo no existe");
                return false;
            }
            else
            {
                Barra.Value = 10;
                tslblEstado.Text = "Leyendo archivo de Excel.";
                paquete.Execute_Package(Application.StartupPath + @"\Paquetes\MaquinariaEquipo.dtsx", dir);//@"C:\MRO.CSV"
                statusStrip1.Refresh();
                //ExcelProvider provider = new ExcelProvider(dir, 70);
                //DataTable registrosExcel = provider.GetWorkSheetMeQ("ME2N");
                ////DataTable registrosExcel = provider.GetWorkSheetMeQ("Sheet1");
                //Barra.Value = 65;

                //tslblEstado.Text = "Actualizando Base de datos.";
                //statusStrip1.Refresh();
                //this.BorrarMaterialesExcelOCMeQ();
                //Barra.Value = 75;
                //this.CopiarTablaBDMeQ("MaterialesExcelOCMeQ", registrosExcel);
                //statusStrip1.Refresh();
                //Barra.Value = 88;

                //tslblEstado.Text = "Sincronizando registros.";
                //statusStrip1.Refresh();
                //this.SincronizarOCMeQ();
                Barra.Value = 100;

                tslblEstado.Text = "Proceso finalizado";
                _Bitacora.MeqImporto();
            //    MessageBox.Show("Archivo insertado a la base de datos");
            }

            return true;
        }

        private void BorrarMaterialesExcelOC()
        {
            Clases.Conexion conn = new MaterialCore.Clases.Conexion();
            conn.ExecSQL("DELETE FROM dbo.MaterialesExcelOC;");
            conn.FinConexion();
        }

        private void BorrarMaterialesExcelOCMeQ()
        {
            Clases.Conexion conn = new MaterialCore.Clases.Conexion();
            conn.ExecSQL("DELETE FROM dbo.MaterialesExcelOCMeQ;");
            conn.FinConexion();
        }

        private void CopiarTablaBD(string Tabla, DataTable registros)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MaterialCore.Properties.Settings.CoreConnectionString"].ConnectionString;

            using (SqlConnection destinationConnection =new SqlConnection(connectionString))
            {
                destinationConnection.Open();

                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(destinationConnection))
                {
                    bulkCopy.DestinationTableName = Tabla;

                    SqlBulkCopyColumnMapping mapID =
                        new SqlBulkCopyColumnMapping(" PO  Number", "Id");//int hay valores ke no caben en int ej 4500016208
                    bulkCopy.ColumnMappings.Add(mapID);

                    SqlBulkCopyColumnMapping mapClienteId =
                        new SqlBulkCopyColumnMapping("ClienteId", "ClienteId");//int
                    bulkCopy.ColumnMappings.Add(mapClienteId);

                    SqlBulkCopyColumnMapping mapRenglonId =
                        new SqlBulkCopyColumnMapping("Item", "RenglonId");//int
                    bulkCopy.ColumnMappings.Add(mapRenglonId);

                    SqlBulkCopyColumnMapping mapNumeroParte =
                        new SqlBulkCopyColumnMapping("Material", "NumeroParte");
                    bulkCopy.ColumnMappings.Add(mapNumeroParte);

                    SqlBulkCopyColumnMapping mapDescripcion =
                        new SqlBulkCopyColumnMapping("Material Description", "Descripcion");
                    bulkCopy.ColumnMappings.Add(mapDescripcion);

                    SqlBulkCopyColumnMapping mapCantidad =
                        new SqlBulkCopyColumnMapping("Quantity Ordered", "Cantidad");//numeric
                    bulkCopy.ColumnMappings.Add(mapCantidad);

                    SqlBulkCopyColumnMapping mapPqOrd =
                        new SqlBulkCopyColumnMapping("Quantity Ordered", "PqOrd");//numeric
                    bulkCopy.ColumnMappings.Add(mapPqOrd);

                    SqlBulkCopyColumnMapping mapPqRec =
                    new SqlBulkCopyColumnMapping("Quantity to be delivered", "PqRec");//numeric
                    bulkCopy.ColumnMappings.Add(mapPqRec);

                    SqlBulkCopyColumnMapping mapPrecio =
                        new SqlBulkCopyColumnMapping(" Std Cost", "Precio"); //numeric
                    bulkCopy.ColumnMappings.Add(mapPrecio);
                    
                    SqlBulkCopyColumnMapping mapProveedor =
                    new SqlBulkCopyColumnMapping("Vendor", "ProveedorID");
                    bulkCopy.ColumnMappings.Add(mapProveedor);

                    SqlBulkCopyColumnMapping mapNombreProveedor =
                    new SqlBulkCopyColumnMapping("Vendor Name", "NombreProveedor");
                    bulkCopy.ColumnMappings.Add(mapNombreProveedor);

                    //SqlBulkCopyColumnMapping mapDescripcion_P =
                    //    new SqlBulkCopyColumnMapping("IDESC", "Descripcion_P");
                    //bulkCopy.ColumnMappings.Add(mapDescripcion_P);

                    SqlBulkCopyColumnMapping mapUnidadMedida =
                        new SqlBulkCopyColumnMapping("PO UoM", "UnidadMedida");
                    bulkCopy.ColumnMappings.Add(mapUnidadMedida);

                    //SqlBulkCopyColumnMapping mapFacturaProveedor =
                    //    new SqlBulkCopyColumnMapping("HVDUE", "FacturaProveedor");
                    //bulkCopy.ColumnMappings.Add(mapFacturaProveedor);

                    //SqlBulkCopyColumnMapping mapPais =
                    //    new SqlBulkCopyColumnMapping("VCOUN", "Pais");
                    //bulkCopy.ColumnMappings.Add(mapPais);

                    SqlBulkCopyColumnMapping mapPlanta =
                        new SqlBulkCopyColumnMapping("Plant", "Planta");
                    bulkCopy.ColumnMappings.Add(mapPlanta);

                    SqlBulkCopyColumnMapping mapMoneda =
                        new SqlBulkCopyColumnMapping("Currency", "Moneda");
                    bulkCopy.ColumnMappings.Add(mapMoneda);

                    //SqlBulkCopyColumnMapping mapProgramaId =
                    //    new SqlBulkCopyColumnMapping("ICCOM", "ProgramaId");
                    //bulkCopy.ColumnMappings.Add(mapProgramaId);

                    //SqlBulkCopyColumnMapping mapDrawingId =
                    //    new SqlBulkCopyColumnMapping("IDRAW", "DrawingId");
                    //bulkCopy.ColumnMappings.Add(mapDrawingId);

                    //SqlBulkCopyColumnMapping mapText1 =
                    //    new SqlBulkCopyColumnMapping("TEXT1", "Text1");
                    //bulkCopy.ColumnMappings.Add(mapText1);

                    try
                    {
                        bulkCopy.WriteToServer(registros);  
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                    finally
                    {
                        // Close the SqlDataReader. The SqlBulkCopy
                        // object is automatically closed at the end
                        // of the using block.

                    }
                }
            }
        }
        private void CopiarTablaBD2(string Tabla, DataTable registros)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MaterialCore.Properties.Settings.CoreConnectionString"].ConnectionString;

            using (SqlConnection destinationConnection =
                   new SqlConnection(connectionString))
            {
                destinationConnection.Open();

                using (SqlBulkCopy bulkCopy =
                           new SqlBulkCopy(destinationConnection))
                {
                    bulkCopy.DestinationTableName =
                        Tabla;

                    SqlBulkCopyColumnMapping mapID =
                        new SqlBulkCopyColumnMapping("PORD", "Id");
                    bulkCopy.ColumnMappings.Add(mapID);

                    SqlBulkCopyColumnMapping mapClienteId =
                        new SqlBulkCopyColumnMapping("IDCTE", "ClienteId");
                    bulkCopy.ColumnMappings.Add(mapClienteId);

                    SqlBulkCopyColumnMapping mapRenglonId =
                        new SqlBulkCopyColumnMapping("PLINE", "RenglonId");
                    bulkCopy.ColumnMappings.Add(mapRenglonId);

                    SqlBulkCopyColumnMapping mapNumeroParte =
                        new SqlBulkCopyColumnMapping("PPROD", "NumeroParte");
                    bulkCopy.ColumnMappings.Add(mapNumeroParte);

                    SqlBulkCopyColumnMapping mapDescripcion =
                        new SqlBulkCopyColumnMapping("PODESC", "Descripcion");
                    bulkCopy.ColumnMappings.Add(mapDescripcion);

                    SqlBulkCopyColumnMapping mapCantidad =
                        new SqlBulkCopyColumnMapping("PQORD", "Cantidad");
                    bulkCopy.ColumnMappings.Add(mapCantidad);

                    SqlBulkCopyColumnMapping mapPqOrd =
                        new SqlBulkCopyColumnMapping("PQORD", "PqOrd");
                    bulkCopy.ColumnMappings.Add(mapPqOrd);

                    SqlBulkCopyColumnMapping mapPqRec =
                    new SqlBulkCopyColumnMapping("PQREC", "PqRec");
                    bulkCopy.ColumnMappings.Add(mapPqRec);

                    SqlBulkCopyColumnMapping mapPrecio =
                        new SqlBulkCopyColumnMapping("PECST", "Precio");
                    bulkCopy.ColumnMappings.Add(mapPrecio);

                    SqlBulkCopyColumnMapping mapProveedor =
                    new SqlBulkCopyColumnMapping("PVEND", "ProveedorID");
                    bulkCopy.ColumnMappings.Add(mapProveedor);

                    SqlBulkCopyColumnMapping mapNombreProveedor =
                    new SqlBulkCopyColumnMapping("VNDNAM", "NombreProveedor");
                    bulkCopy.ColumnMappings.Add(mapNombreProveedor);

                    SqlBulkCopyColumnMapping mapDescripcion_P =
                        new SqlBulkCopyColumnMapping("IDESC", "Descripcion_P");
                    bulkCopy.ColumnMappings.Add(mapDescripcion_P);

                    SqlBulkCopyColumnMapping mapUnidadMedida =
                        new SqlBulkCopyColumnMapping("PUM", "UnidadMedida");
                    bulkCopy.ColumnMappings.Add(mapUnidadMedida);

                    SqlBulkCopyColumnMapping mapFacturaProveedor =
                        new SqlBulkCopyColumnMapping("HVDUE", "FacturaProveedor");
                    bulkCopy.ColumnMappings.Add(mapFacturaProveedor);

                    SqlBulkCopyColumnMapping mapPais =
                        new SqlBulkCopyColumnMapping("VCOUN", "Pais");
                    bulkCopy.ColumnMappings.Add(mapPais);

                    SqlBulkCopyColumnMapping mapPlanta =
                        new SqlBulkCopyColumnMapping("PWHSE", "Planta");
                    bulkCopy.ColumnMappings.Add(mapPlanta);

                    SqlBulkCopyColumnMapping mapMoneda =
                        new SqlBulkCopyColumnMapping("POCUR", "Moneda");
                    bulkCopy.ColumnMappings.Add(mapMoneda);

                    SqlBulkCopyColumnMapping mapProgramaId =
                        new SqlBulkCopyColumnMapping("ICCOM", "ProgramaId");
                    bulkCopy.ColumnMappings.Add(mapProgramaId);

                    SqlBulkCopyColumnMapping mapDrawingId =
                        new SqlBulkCopyColumnMapping("IDRAW", "DrawingId");
                    bulkCopy.ColumnMappings.Add(mapDrawingId);

                    SqlBulkCopyColumnMapping mapText1 =
                        new SqlBulkCopyColumnMapping("TEXT1", "Text1");
                    bulkCopy.ColumnMappings.Add(mapText1);

                    try
                    {
                        bulkCopy.WriteToServer(registros);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                    finally
                    {
                        // Close the SqlDataReader. The SqlBulkCopy
                        // object is automatically closed at the end
                        // of the using block.

                    }
                }
            }
        }


        private void CopiarTablaBDMeQ(string Tabla, DataTable registros)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MaterialCore.Properties.Settings.CoreConnectionString"].ConnectionString;

            using (SqlConnection destinationConnection =
                   new SqlConnection(connectionString))
            {
                destinationConnection.Open();

                using (SqlBulkCopy bulkCopy =
                           new SqlBulkCopy(destinationConnection))
                {
                    bulkCopy.DestinationTableName =
                        Tabla;

                    SqlBulkCopyColumnMapping mapID =
                        new SqlBulkCopyColumnMapping("PORD", "Id");
                    bulkCopy.ColumnMappings.Add(mapID);

                    SqlBulkCopyColumnMapping mapClienteId =
                        new SqlBulkCopyColumnMapping("IDCTE", "ClienteId");
                    bulkCopy.ColumnMappings.Add(mapClienteId);

                    SqlBulkCopyColumnMapping mapRenglonId =
                        new SqlBulkCopyColumnMapping("PLINE", "RenglonId");
                    bulkCopy.ColumnMappings.Add(mapRenglonId);

                    SqlBulkCopyColumnMapping mapNumeroParte =
                        new SqlBulkCopyColumnMapping("PPROD", "NumeroParte");
                    bulkCopy.ColumnMappings.Add(mapNumeroParte);

                    SqlBulkCopyColumnMapping mapDescripcion =
                        new SqlBulkCopyColumnMapping("PODESC", "Descripcion");
                    bulkCopy.ColumnMappings.Add(mapDescripcion);

                    SqlBulkCopyColumnMapping mapCantidad =
                        new SqlBulkCopyColumnMapping("PQORD", "Cantidad");
                    bulkCopy.ColumnMappings.Add(mapCantidad);

                    SqlBulkCopyColumnMapping mapPqOrd =
                        new SqlBulkCopyColumnMapping("PQORD", "PqOrd");
                    bulkCopy.ColumnMappings.Add(mapPqOrd);

                    SqlBulkCopyColumnMapping mapPqRec =
                    new SqlBulkCopyColumnMapping("PQREC", "PqRec");
                    bulkCopy.ColumnMappings.Add(mapPqRec);

                    SqlBulkCopyColumnMapping mapPrecio =
                        new SqlBulkCopyColumnMapping("PECST", "Precio");
                    bulkCopy.ColumnMappings.Add(mapPrecio);

                    SqlBulkCopyColumnMapping mapProveedor =
                    new SqlBulkCopyColumnMapping("PVEND", "ProveedorID");
                    bulkCopy.ColumnMappings.Add(mapProveedor);

                    SqlBulkCopyColumnMapping mapNombreProveedor =
                    new SqlBulkCopyColumnMapping("VNDNAM", "NombreProveedor");
                    bulkCopy.ColumnMappings.Add(mapNombreProveedor);

                    SqlBulkCopyColumnMapping mapUnidadMedida =
                        new SqlBulkCopyColumnMapping("PUM", "UnidadMedida");
                    bulkCopy.ColumnMappings.Add(mapUnidadMedida);

                    //SqlBulkCopyColumnMapping mapFacturaProveedor =
                    //    new SqlBulkCopyColumnMapping("HVDUE", "FacturaProveedor");
                    //bulkCopy.ColumnMappings.Add(mapFacturaProveedor);


                    SqlBulkCopyColumnMapping mapPlanta =
                        new SqlBulkCopyColumnMapping("PWHSE", "Planta");
                    bulkCopy.ColumnMappings.Add(mapPlanta);

                    SqlBulkCopyColumnMapping mapMoneda =
                        new SqlBulkCopyColumnMapping("POCUR", "Moneda");
                    bulkCopy.ColumnMappings.Add(mapMoneda);


                    try
                    {
                        bulkCopy.WriteToServer(registros);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        // Close the SqlDataReader. The SqlBulkCopy
                        // object is automatically closed at the end
                        // of the using block.

                    }
                }
            }
        }

        private void SincronizarOC()
        {
            Clases.Conexion conn = new MaterialCore.Clases.Conexion();
            conn.StoredProcedureName = "MaterialesSyncOC";
            conn.SpParametros.Add("NoCliente", SqlDbType.Int, 4).Value = 70;
            conn.exec();

            conn.FinConexion();
        }

        private void SincronizarOCMeQ()
        {
            Clases.Conexion conn = new MaterialCore.Clases.Conexion();
            conn.StoredProcedureName = "MaterialesSyncOCMeQ";
            conn.SpParametros.Add("NoCliente", SqlDbType.Int, 4).Value = 70;
            conn.exec();

            conn.FinConexion();
        }

        void CargarCSV(string dir)
        {
            int total_registros = RenglonesCSV(dir);

            FileStream fs = new FileStream(dir, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader archivo = new StreamReader(fs);

            string linea;
            string[] datos;

            int registro = 0;
            linea = archivo.ReadLine();
            while (linea != null)
            {
                datos = linea.Split(',');
                //insertar, actualizar registros

                Barra.Value = Convert.ToInt32((registro * 100) / total_registros);
                registro++;
                linea = archivo.ReadLine();
            }
            archivo.Close();
            MessageBox.Show("Archivo cargado a la base de datos con exito");
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            if (rbtAutomatico.Checked)
            {
                if (!chkMat.Checked && !chkMeQ.Checked)
                {
                    MessageBox.Show("Debe de especificar que archivos va a cargar");
                    return;
                }

                if (chkMat.Checked)
                {
                    lblDirCSV.Text =    System.Configuration.ConfigurationManager.AppSettings["dirCSV"].ToString();
                    btnCargar.Visible = false;
                    CargaArchivo(lblDirCSV.Text);
                    btnCargar.Visible = true;
                }
              if( chkMeQ.Checked)
                {
                    lblMeQ.Text = System.Configuration.ConfigurationManager.AppSettings["dirXLSMeQ"].ToString();
                    btnCargar.Visible = false;
                    CargaArchivoMeQ(lblMeQ.Text);
                    btnCargar.Visible = true;
                }
                //MessageBox.Show("Archivo cargado con éxito");
                this.Close();
            }
            else //Modo manual
            {
                if (!chkMat.Checked && !chkMeQ.Checked)
                {
                    MessageBox.Show("Debe de especificar que archivo va a cargar");
                    return;
                }

                if (chkMat.Checked)
                {
                    btnCargar.Visible = false;
                    CargaArchivo(lblDirCSV.Text);
                    btnCargar.Visible = true;
                }
                if (chkMeQ.Checked)
                {
                    btnCargar.Visible = false;
                    CargaArchivoMeQ(lblMeQ.Text);
                    btnCargar.Visible = true;
                }
                MessageBox.Show("Archivo cargado con éxito");
                this.Close();
            }




            //if(chkCortos.Checked)
                //TODO: Programar para importarlos cortos a una tabla y vefificar procedimiento con los mismos
          //  CargarCSV(lblDirCSV.Text);
         
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        delegate void RefreshProgressDelegate(int percent);
        public void RefreshProgress(int value)
            {
                if (this == null) return;
                Barra.Value = (int)value;
            }

        delegate void RefreshTextDelegate(string texto);
        public void RefreshText(string value)
            {
                if (this == null) return;
                lblmensaje.Text = (string)value;
            }

        private void ImpCSV_Load(object sender, EventArgs e)
        {
            rbtAutomatico.Checked = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Control | Keys.C:
                   
                    btnCargar_Click(0,null);
                    return true;

                case Keys.Control | Keys.B:
                     if(btnBuscar.Visible)
                        btnBuscar_Click(0, null);
                    return true;

                case Keys.Escape:
                    this.Close();
                    return true;
            }
            return false;
        }

        private void btnBuscarMeQ_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "Libro de Excel (*.xls,*.xlsx)|*.xls;*.xlsx" +
                             "|Archivo CSV (*.csv)|*.csv";
            dialogo.FilterIndex = 1;
            dialogo.Multiselect = false;
            dialogo.RestoreDirectory = true;

            DialogResult resultado = dialogo.ShowDialog();

            if (resultado == DialogResult.OK)
                lblMeQ.Text = dialogo.FileName.ToString();
        }


        }

    public class ExcelProvider
    {
        private string _filename;
        private int _IdCLiente;
        /// <summary>
        /// Gets or sets the Excel filename
        /// </summary>
        private string FileName
        {
            get { return _filename; }
            set { _filename = value; }
        }

        private int IdCliente
        {
            get { return _IdCLiente; }
            set { _IdCLiente = value; }
        }

        /// <summary>
        /// Template connectionstring for Excel connections
        /// </summary>

        //private const string ConnectionStringTemplate = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=Excel 8.0;";
        private const string ConnectionStringTemplate = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\'Excel 12.0 Xml;HDR=Yes;IMEX=1\'";

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="fileName">The Excel file to process</param>
        public ExcelProvider(string fileName,int idCliente)
        {
            FileName = fileName;
            _IdCLiente = idCliente;
        }

        /// <summary>
        /// Returns a worksheet as a linq-queryable enumeration
        /// </summary>
        /// <param name="sheetName">The name of the worksheet</param>
        /// <returns>An enumerable collection of the worksheet</returns>
        public DataTable GetWorkSheet(string sheetName)
        {
            // Build the connectionstring
            string connectionString = string.Format(ConnectionStringTemplate, FileName);

            // Query the specified worksheet
            string sql_query = string.Format("SELECT " +
                                               " ` PO  Number`, {1} AS ClienteId,Item,Material,`Material Description`,`Quantity Ordered`,`Quantity to be delivered`,` Std Cost`,Plant " +
                                               ",`PO UoM`,Vendor,`Vendor Name`,Currency FROM [{0}$]", sheetName, _IdCLiente);

            OleDbDataAdapter dataAdapter = new
                    OleDbDataAdapter(sql_query, connectionString);

            // Fill the dataset from the data adapter
            DataSet myDataSet = new DataSet();
            dataAdapter.Fill(myDataSet, "ExcelInfo");

            // Initialize a data table which we can use to enumerate the contents based on the dataset
            DataTable dataTable = myDataSet.Tables["ExcelInfo"];

            // Return the data table contents as a queryable enumeration
            return dataTable;
        }
        public DataTable GetWorkSheetMeQ(string sheetName)
        {
            // Build the connectionstring
            string connectionString = string.Format(ConnectionStringTemplate, FileName);

            string sql_query = string.Format("SELECT " +
                                              "PORD, {1} AS IDCTE, PLINE, PPROD, PODESC, PQORD,PQREC, PECST, PWHSE, NULL as HVDUE," +
                                              "PUM, Llave,PVEND,VNDNAM, POFAC,POCUR, PCQTY " +
                                              "FROM [{0}$Query_from_QHPOARM]", sheetName, _IdCLiente);// cambio para poder mostrar los encabezados

            // Query the specified worksheet
            OleDbDataAdapter dataAdapter = new
                OleDbDataAdapter(sql_query, connectionString);
            //dataAdapter.SelectCommand.Parameters.AddWithValue("@PORD","''");
            // Fill the dataset from the data adapter
            DataSet myDataSet = new DataSet();
            dataAdapter.Fill(myDataSet, "ExcelInfo");

            // Initialize a data table which we can use to enumerate the contents based on the dataset
            DataTable dataTable = myDataSet.Tables["ExcelInfo"];

            // Return the data table contents as a queryable enumeration
            return dataTable;
        }
    }    
 }
