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


/// <summary>
/// Summary description for GuardaDatosComplementarios
/// </summary>

namespace MaterialCore.Clases
{

    public enum TextAlignment { Left, Right }

    class MeQExcel
    {



        private string _path, _sFile, _mensaje = "";
        SqlDataReader _materialesDR;
        int _Consecutivo;

        public MeQExcel(string path,int consecutivo)
        {
            _Consecutivo = consecutivo;
            _path = path;

            this.ObterDatos(consecutivo);
            this.crearExcel(false);

            this.ObterDatosSinPO(consecutivo);
            this.crearExcel(true);
        }

        //prueba que carga el objeto en para cada exel
        public MeQExcel(string path, int consecutivo, bool sinPO)
        {
            _Consecutivo = consecutivo;
            _path = path;

            if (!sinPO)
            {
                this.ObterDatos(consecutivo);
                this.crearExcel(false);
            }
            else
            {
                this.ObterDatosSinPO(consecutivo);
                this.crearExcel(true);
            }
        }



        public string path
        {
            set { _path = value; }
        }
        public string ArchivoDescargar
        {
            get { return _sFile; }
        }
        public string mensaje
        {
            get { return _mensaje; }
        }

        private void crearExcel(bool SinPO)
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
                if (SinPO)
                {
                    sFile = _path + @"MeQ\Partidas sin OC MeQ-" + _Consecutivo + ".xls";  
                }
                else
                {
                    sFile = _path + @"MeQ\MeQ-" + _Consecutivo + ".xls";  
                }
            
                sTemplate = Application.StartupPath + @"\Plantillas\Plantilla-MeQ.xls";

                if (!System.IO.Directory.Exists(_path + @"MeQ\"))
                {
                    System.IO.Directory.CreateDirectory(_path + @"MeQ\");
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

int i = 2;
while (_materialesDR.Read())
{
    try
    {oHoja.Cells[i, 1] = FormatoCampoEspacios(Convert.ToDateTime(_materialesDR["Fecha"]).ToString("yyyy-MM-dd"), 10, TextAlignment.Left);}
    catch
    {oHoja.Cells[i, 1] = FormatoCampoEspacios(DateTime.Now.ToString("yyyy-MM-dd"), 10, TextAlignment.Left);}

        oHoja.Cells[i, 2] = FormatoCampoCeros(Convert.ToString(_materialesDR["Proveedor"]), 5, TextAlignment.Right);
        oHoja.Cells[i, 3] = FormatoCampoEspacios(Convert.ToString(  _materialesDR["FacturaImportacion"]), 16, TextAlignment.Left);
        oHoja.Cells[i, 4] =FormatoCampoEspacios(Convert.ToString(_materialesDR["numPO"]), 7, TextAlignment.Left);
        oHoja.Cells[i, 5] =FormatoCampoEspacios(FormatoCampoCeros(Convert.ToString(_materialesDR["LineaPO"]), 3, TextAlignment.Right), 4, TextAlignment.Left) ;
        oHoja.Cells[i, 6] = FormatoCampoCeros(Convert.ToString(_materialesDR["identificador"]), 2, TextAlignment.Right);
        oHoja.Cells[i, 7] =FormatoCampoEspacios(Convert.ToString(_materialesDR["NumeroParte"]), 16, TextAlignment.Left);
        oHoja.Cells[i, 8] = FormatoCampoEspacios(Convert.ToString("0000000000"), 10, TextAlignment.Left);
      //  oHoja.Cells[i, 8] = FormatoCampoEspacios(Convert.ToString( _materialesDR["Familia"]), 10, TextAlignment.Left);
        oHoja.Cells[i, 9] =FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(  _materialesDR["CantidadRecibida"]), 12, 2, TextAlignment.Right), 13, TextAlignment.Left) ;
        oHoja.Cells[i, 10] =FormatoCampoEspacios(Convert.ToString( _materialesDR["UnidadMedida"]), 3, TextAlignment.Left);
        oHoja.Cells[i, 11] =FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(  _materialesDR["PesoBruto"]), 17, 8, TextAlignment.Right), 18, TextAlignment.Left) ;
        oHoja.Cells[i, 12] =FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(    _materialesDR["PesoNeto"]), 17, 8, TextAlignment.Right), 18, TextAlignment.Left) ;
        oHoja.Cells[i, 13] =FormatoCampoEspacios(Convert.ToString(    _materialesDR["PaisOrigen"]), 7, TextAlignment.Left) ;
        //oHoja.Cells[i, 14] =FormatoCampoEspacios(Convert.ToString(   _materialesDR["Moneda"]), 4, TextAlignment.Left) ;
        oHoja.Cells[i, 14] = FormatoCampoEspacios(FormatoCampoCeros(Convert.ToString(    _materialesDR["CantidadBultos"]), 9, TextAlignment.Right), 10, TextAlignment.Left) ;
        oHoja.Cells[i, 15] = FormatoCampoEspacios(Convert.ToString(_materialesDR["ContenidoTipoBulto"]), 5, TextAlignment.Left) ;
        oHoja.Cells[i, 16] = FormatoCampoEspacios(Convert.ToString(_materialesDR["TipoBulto"]), 5, TextAlignment.Left) ;
        oHoja.Cells[i, 17] = FormatoCampoEspacios(Convert.ToString(_materialesDR["NumeroGuia"]), 41, TextAlignment.Left) ;
        oHoja.Cells[i, 18] = FormatoCampoEspacios(Convert.ToString(_materialesDR["Transportista"]), 21, TextAlignment.Left) ;
        oHoja.Cells[i, 19] =FormatoCampoEspacios(Convert.ToString(_materialesDR["Marca"]), 41, TextAlignment.Left) ;
        oHoja.Cells[i, 20] = FormatoCampoEspacios(Convert.ToString(_materialesDR["Modelo"]), 41, TextAlignment.Left) ;
        oHoja.Cells[i, 21] = FormatoCampoEspacios(Convert.ToString(_materialesDR["Serie"]), 48, TextAlignment.Left);
        oHoja.Cells[i, 22] = FormatoCampoEspacios(Convert.ToString(""), 18, TextAlignment.Left);
        oHoja.Cells[i, 23] = FormatoCampoEspacios(Convert.ToString(_materialesDR["descripcion"]), 41, TextAlignment.Left);
        oHoja.Cells[i, 24] = FormatoCampoEspacios(Convert.ToDateTime(_materialesDR["fechacaptura"]).ToString("yyyy-MM-dd HH:mm"), 20, TextAlignment.Left);
        oHoja.Cells[i, 25] = _materialesDR["comentarios"].ToString();
        oHoja.Cells[i, 26] = _materialesDR["nombreproveedor"].ToString();
   
    i++;
 }

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

        private void ObterDatos(int consecutivo)
    {
        Conexion conn = new Conexion();

        _materialesDR = conn.getLector(" SELECT     Id, FechaRecibo AS Fecha, Proveedor,facturaproveedor as  FacturaImportacion, MaterialesOCId AS numPO, RenglonId AS LineaPO,  identificador, dbo.numpartemq(id) as NumeroParte, '' as Familia,CantidadRecibida,  " +
" UnidadMedida, PesoBruto,  ISNULL(pesobruto - pesobruto * .1,0) AS  PesoNeto, PaisOrigen, Moneda, CantidadBultos, TipoBulto, ContenidoTipoBulto, NumeroGuia, Transportista, Marca,  " +
" Modelo, Serie,fechacaptura,comentarios,nombreproveedor,descripcion " + 
"FROM MaterialesMaquinaria " +
"WHERE (ClienteId = 70) AND (Consecutivo = " + consecutivo + ") AND MaterialesOCId <> 0 " +
"ORDER BY MaterialesOCId, RenglonId, idPadre, Identificador");
        
    }

        private void ObterDatosSinPO(int consecutivo)
        {
            Conexion conn = new Conexion();

            _materialesDR = conn.getLector(" SELECT     Id, FechaRecibo AS Fecha, Proveedor,facturaproveedor as  FacturaImportacion, MaterialesOCId AS numPO, RenglonId AS LineaPO,  identificador, dbo.numpartemq(id) as NumeroParte, '' as Familia,CantidadRecibida,  " +
    " UnidadMedida, PesoBruto,  ISNULL(pesobruto - pesobruto * .1,0) AS  PesoNeto, PaisOrigen, Moneda, CantidadBultos, TipoBulto, ContenidoTipoBulto, NumeroGuia, Transportista, Marca,  " +
    " Modelo, Serie,fechacaptura,comentarios,nombreproveedor,descripcion " +
    "FROM MaterialesMaquinaria " +
    "WHERE (ClienteId = 70) AND (Consecutivo = " + consecutivo + ")  AND  MaterialesOCId = 0 " +
    "ORDER BY MaterialesOCId, RenglonId, idPadre, Identificador");
 

        }


    #region funciones de formato

    public static string FormatoCampoEspacios(
string campo,
int longitud,
TextAlignment alineacion
)
    {
        int contador = longitud - campo.Length;
        if (contador < 0)
            contador = 0;

        string espacios = new string(' ', contador);
        if (alineacion == TextAlignment.Left)
            return campo + espacios;
        else
            return espacios + campo;
    }

    public static string FormatoCampoCeros(
        string campo,
        int longitud,
      TextAlignment alineacion
        )
    {
        int contador = longitud - campo.Length;
        if (contador < 0)
            contador = 0;

        string espacios = new string('0', contador);
        if (alineacion == TextAlignment.Left)
            return campo + espacios;
        else
            return espacios + campo;
    }

    public static string FormatoCampoDecimal(
       string campo,
       int longitud,
       int decimales,
TextAlignment alineacion
       )
    {
        decimal resultado = 0;
        if (!decimal.TryParse(campo, out resultado))
            campo = "0";

        campo = Math.Round(Convert.ToDecimal(campo), decimales).ToString("0." + FormatoCampoCeros("0", decimales, TextAlignment.Left));

        int contador = longitud - campo.Length;
        if (contador < 0)
            contador = 0;

        string espacios = new string('0', contador);
        if (alineacion == TextAlignment.Left)
            return campo + espacios;
        else
            return espacios + campo;
    }
    #endregion


    }

}