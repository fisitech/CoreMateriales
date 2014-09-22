using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Threading;
using System.Net;

using Excel = Microsoft.Office.Interop.Excel;
using System.Configuration;


/// <summary>
/// Summary description for GuardaDatosComplementarios
/// </summary>

namespace MaterialCore.Clases
{
    class GuardaDatosComplementarios
    {

        private decimal TotalBultosMP;
        private decimal TotalBultosMEQ;
        private decimal TotalBultosPT;
        private decimal TotalPesoMP;
        private decimal TotalPesoMEQ;
        private decimal TotalPesoPT;
        private string _path, _sFile, _mensaje = "";
        private int _nid_deploy;
        SqlDataReader _complementariosDR;

        string _Caja;
        string _Transportista;
        string _Tarimas;
        string _Bultos;
        string _Peso;
        string _Despasho;

        public GuardaDatosComplementarios(int nid_deploy, string path)
        {

            _path = path;
            _nid_deploy = nid_deploy;

            this.ObterDatosComplementarios();
            this.crearExcel();
        }
        public GuardaDatosComplementarios(string caja, string transportista, string tarimas, string bultos, string peso, string despacho)
        {
            _Caja = caja;
            _Transportista = transportista;
            _Tarimas = tarimas;
            _Bultos = bultos;
            _Peso = peso;
            _Despasho = despacho;

            _path = ConfigurationManager.AppSettings["dirPDF"].ToString();



            this.crearExcel2();
        }



        public string path
        {
            set { _path = value; }
        }

        public int nid_deploy
        {
            set { _nid_deploy = value; }
        }

        public string ArchivoDescargar
        {
            get { return _sFile; }
        }

        public string mensaje
        {
            get { return _mensaje; }
        }

        private void crearExcel()
        {

            System.Globalization.CultureInfo CurrentCI = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            //try
            //{
            Excel.Application oExcel = new Excel.Application();
            Excel.Workbooks oLibros;
            Excel.Workbook oLibro;

            Excel.Sheets oHojas;
            Excel.Worksheet oHoja;

            Excel.Range oCeldas;

            string sFile, sTemplate;

            // Usamos una plantilla para crear el nuevo excel

            sFile = _path + @"Datos Complementarios\" + DateTime.Now.ToShortDateString().Replace("/", "") + "-datoscomplementarios.xls";  //Esta generado por el numero de reporte seguido por la palabra despacho
            sTemplate = Application.StartupPath + @"\Plantillas\Plantilla-DC.xls";


            if (!System.IO.Directory.Exists(_path + @"Datos Complementarios\"))
            {
                System.IO.Directory.CreateDirectory(_path + @"Datos Complementarios\");
            }


            oExcel.Visible = false;
            oExcel.DisplayAlerts = false;

            // Abrimos un nuevo libro        

            oLibros = oExcel.Workbooks;
            oLibros.Open(sTemplate, Type.Missing, true, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing);


            oLibro = oLibros.get_Item(1);
            oHojas = oLibro.Worksheets;

            oHoja = (oHojas.get_Item(1) as Excel.Worksheet);

            //         _complementariosDR.Read();

            string fecha = "", cliente = "", transportista = "", caja = "", paleta = "";
            int paletas = 0;
            int bultos = 0;
            decimal peso = 0;

            while (_complementariosDR.Read())
            {
                fecha = _complementariosDR["fecha"].ToString();
                cliente = _complementariosDR["nombrecliente"].ToString();
                transportista = _complementariosDR["Transportista"].ToString();
                bultos = bultos + Convert.ToInt32(_complementariosDR["bultos"]);
                peso = peso + Convert.ToDecimal(_complementariosDR["pesobruto"]);
                caja = _complementariosDR["cbox_number"].ToString();
                paleta = paleta + ", " + _complementariosDR["NumeroPaleta"].ToString();
                paletas = paletas + 1;
            }




            oHoja.Cells[8, 2] = fecha;
            oHoja.Cells[9, 2] = cliente;
            oHoja.Cells[10, 2] = transportista + " Caja: " + caja;
            oHoja.Cells[13, 2] = paletas;


            oHoja.Cells[19, 2] = bultos.ToString();


            oHoja.Cells[26, 2] = bultos.ToString();
            oHoja.Cells[27, 2] = peso.ToString();

            //oHoja.Cells[8, 2] = _complementariosDR["fecha"].ToString();
            //oHoja.Cells[9, 2] = _complementariosDR["NombreCliente"].ToString();
            //oHoja.Cells[10, 2] = _complementariosDR["Transportista"].ToString();


            //oHoja.Cells[19, 2] = _complementariosDR["Bultos"].ToString();


            //oHoja.Cells[26, 2] = _complementariosDR["Bultos"].ToString();
            //oHoja.Cells[27, 2] = _complementariosDR["TotalKG"].ToString();

            ///////////////////
            _sFile = sFile;
            oHoja.SaveAs(sFile, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                 Type.Missing, Type.Missing, Type.Missing);

            oLibro.Close(true, true, Type.Missing);

            // Eliminamos lo que hemos creado

            oExcel.Quit();

            oExcel = null;
            oLibros = null;
            oLibro = null;
            oHojas = null;
            oHoja = null;
            oCeldas = null;
            System.GC.Collect();
            _mensaje = "";
            //}
            //catch
            //{
            //    _mensaje = "No se puede generar los datos complementarios hasta que se solicite el camión para el despacho";
            //}
            //finally
            //{

            // restaura el CultureInfo

            System.Threading.Thread.CurrentThread.CurrentCulture = CurrentCI;
            //}


        }

        private void ObterDatosComplementarios()
        {
            Conexion conn = new Conexion();

            _complementariosDR = conn.getLector("SELECT     GETDATE() AS fecha, 'Labinal' AS nombrecliente, carriers.nombre  AS Transportista, " +
                                                                            "MaterialesPaltetas.CantidadBultos AS bultos, MaterialesPaltetas.PesoBruto as pesobruto, carriers_deploys.cbox_number,  " +
                                                                            "carriers.nombre, MaterialesPaltetas.NumeroPaleta " +
                                                                            "FROM         MaterialesPaltetas INNER JOIN " +
                                                                            "carriers_deploys ON MaterialesPaltetas.ConsecutivoEmbarque = carriers_deploys.nid_deploy INNER JOIN " +
                                                                            "carriers ON carriers_deploys.cve_transp = carriers.cve_transp " +
                                                                            "WHERE   MaterialesPaltetas.Id  in (SELECT DISTINCT  " +
                                                                            "MaterialesPaltetas.Id " +
                                                                            "FROM         MaterialesEnviar INNER JOIN " +
                                                                            "MaterialesPaltetas ON MaterialesEnviar.MaterialesPaletasId = MaterialesPaltetas.Id INNER JOIN " +
                                                                            "deploys ON MaterialesPaltetas.ConsecutivoEmbarque = deploys.nid_deploy " +
                                                                            "WHERE     (MaterialesEnviar.Enviado = 0) AND (MaterialesEnviar.Preparado = 1) AND (deploys.bclosed = 0)) ");

        }


        private void crearExcel2()
        {

            System.Globalization.CultureInfo CurrentCI = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            Excel.Application oExcel = new Excel.Application();
            Excel.Workbooks oLibros;
            Excel.Workbook oLibro;

            Excel.Sheets oHojas;
            Excel.Worksheet oHoja;

            Excel.Range oCeldas;

            string sFile, sTemplate;

            // Usamos una plantilla para crear el nuevo excel

            sFile = _path + @"Datos Complementarios\" + _Despasho + " - DC.xls";  //Esta generado por el numero de reporte seguido por la palabra despacho
            sTemplate = Application.StartupPath + @"\Plantillas\Plantilla-DC.xls";


            if (!System.IO.Directory.Exists(_path + @"Datos Complementarios\"))
            {
                System.IO.Directory.CreateDirectory(_path + @"Datos Complementarios\");
            }


            oExcel.Visible = false;
            oExcel.DisplayAlerts = false;

            // Abrimos un nuevo libro        

            oLibros = oExcel.Workbooks;
            oLibros.Open(sTemplate, Type.Missing, true, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing);


            oLibro = oLibros.get_Item(1);
            oHojas = oLibro.Worksheets;

            oHoja = (oHojas.get_Item(1) as Excel.Worksheet);

            //parde donde se empieza a cargar la info

            oHoja.Cells[8, 2] = DateTime.Now.ToString();
            oHoja.Cells[9, 2] = "Labinal";
            oHoja.Cells[10, 2] = _Transportista + " Caja: " + _Caja;
            oHoja.Cells[13, 2] = _Tarimas;
            oHoja.Cells[19, 2] = _Bultos;
            oHoja.Cells[26, 2] = _Bultos;
            oHoja.Cells[27, 2] = _Peso;

            _sFile = sFile;
            oHoja.SaveAs(sFile, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                 Type.Missing, Type.Missing, Type.Missing);

            oLibro.Close(true, true, Type.Missing);

            // Eliminamos lo que hemos creado

            oExcel.Quit();

            oExcel = null;
            oLibros = null;
            oLibro = null;
            oHojas = null;
            oHoja = null;
            oCeldas = null;
            System.GC.Collect();
            _mensaje = "";


            System.Threading.Thread.CurrentThread.CurrentCulture = CurrentCI;



        }

    }

}