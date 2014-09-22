using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Data;
using System.Data.SqlTypes;
using Excel = Microsoft.Office.Interop.Excel;

namespace MaterialCore.Clases
{
    class PalletExcel
    {
        public enum TextAlignment { Left, Right }

        #region sin uso
        public void exportar(string archivo, DataSets.Embarques.GenerarTXTDataTable txtDT, bool EsProveedores, decimal peso)
        {
            string linea = "";




            using (StreamWriter sw = new StreamWriter(archivo, true))
            {
                for (int i = 0; i < txtDT.Rows.Count; i++)
                {

                    // linea = FormatoCampoEspacios(String.Format("yyyy-mm-dd", txtDT[i]["FechaRecibo"]), 11, TextAlignment.Left) +
                    linea = FormatoCampoEspacios(Convert.ToDateTime(txtDT[i]["FechaRecibo"]).ToString("yyyy-MM-dd"), 11, TextAlignment.Left) +
                    FormatoCampoCeros(Convert.ToString(txtDT[i]["ProveedorId"]), 5, TextAlignment.Right) + " " +
                            FormatoCampoEspacios(Convert.ToString(txtDT[i]["FacturaProveedor"]), 16, TextAlignment.Left) +
                            FormatoCampoEspacios(Convert.ToString(txtDT[i]["Id"]), 7, TextAlignment.Left) +
                            FormatoCampoEspacios(FormatoCampoCeros(Convert.ToString(txtDT[i]["RenglonId"]), 3, TextAlignment.Right), 4, TextAlignment.Left) +
                            FormatoCampoEspacios(Convert.ToString(txtDT[i]["NumeroParte"]), 16, TextAlignment.Left) +
                            FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(txtDT[i]["CantidadRecibida"]), 12, 2, TextAlignment.Right), 13, TextAlignment.Left) +
                            FormatoCampoEspacios(Convert.ToString(txtDT[i]["UnidadMedida"]), 3, TextAlignment.Left);

                    //parte del peso
                    if (!EsProveedores) //archivo global
                    {
                        if (i == 0)
                        {
                            linea +=
                            FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(peso), 17, 8, TextAlignment.Right), 18, TextAlignment.Left) +
                            FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(peso), 17, 8, TextAlignment.Right), 18, TextAlignment.Left);
                        }
                        else
                        {
                            linea +=
                            FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(0), 17, 8, TextAlignment.Right), 18, TextAlignment.Left) +
                            FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(0), 17, 8, TextAlignment.Right), 18, TextAlignment.Left);
                        }
                    }
                    else //SI es el archivo de proveedor
                    {
                        linea +=
                        FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(peso), 17, 8, TextAlignment.Right), 18, TextAlignment.Left) +
                        FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(peso), 17, 8, TextAlignment.Right), 18, TextAlignment.Left);
                    }

                    string pais = Convert.ToString(txtDT[i]["Pais"]);
                    if (pais.Length > 2)
                        pais = pais.Substring(0, 2);


                    linea +=
                        //FormatoCampoEspacios(Convert.ToString(txtDT[i]["Pais"]).Substring(0, 2), 7, TextAlignment.Left) + //corta la cadena a 2 caracteres
                      FormatoCampoEspacios(Convert.ToString(pais), 7, TextAlignment.Left) + //corta la cadena a 2 caracteres
                      FormatoCampoEspacios(Convert.ToString(txtDT[i]["Moneda"]), 4, TextAlignment.Left) +
                      FormatoCampoEspacios(FormatoCampoCeros(Convert.ToString(txtDT[i]["Numero2"]), 9, TextAlignment.Left), 10, TextAlignment.Left);

                    if (EsProveedores)
                    {
                        linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["NoGuia"]), 41, TextAlignment.Left) +
                             FormatoCampoEspacios(Convert.ToString(txtDT[i]["EmbarquePlanta"]), 8, TextAlignment.Left) +
                             FormatoCampoEspacios(Convert.ToString(txtDT[i]["Tarima"]), 42, TextAlignment.Left);
                        //aqui debe de ir el nombre dde la tabla

                        //   FormatoCampoEspacios(Convert.ToString(txtDT[i]["NoGuia"]), txtDT[i]["NoGuia"].ToString().Length, TextAlignment.Left);
                    }
                    else
                        linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["NoGuia"]), txtDT[i]["NoGuia"].ToString().Length, TextAlignment.Left);

                    sw.WriteLine(linea);
                }
            }

        }
        #endregion

        public void exportarRehacer(string archivo, DataSets.Embarques.GenerarTXTRehacerDataTable txtDT, bool EsProveedores, decimal peso)
        {
            int i = 0;
            Excel.Application oExcel = new Excel.Application();
           
            Excel.Workbook oLibro;
     
            Excel.Worksheet oHoja;
            
            
            oExcel.Visible = false;
            oExcel.DisplayAlerts = false;

            oLibro = oExcel.Workbooks.Add(1);
            oHoja = (Excel.Worksheet)oLibro.Sheets[1];

            int bultos = 0;
            for (int x = 0; x < txtDT.Rows.Count; x++)
            {
                bultos += Convert.ToInt32(txtDT[x]["bultos"]);
            }
         
           int columns = txtDT.Columns.Count;
            int rows = txtDT.Rows.Count;
    
            for (int rowNumber = 0; rowNumber < rows; rowNumber++)
            {
                for (int columnNumber = 0; columnNumber < columns; columnNumber++)
                {
                    oHoja.Cells[rowNumber + 1, 1] = Convert.ToDateTime(txtDT.Rows[rowNumber]["FechaRecibo"]).ToString("yyyy-MM-dd");
                    oHoja.Cells[rowNumber + 1, 2] = txtDT.Rows[rowNumber]["ProveedorId"];
                    oHoja.Cells[rowNumber + 1, 3] = txtDT.Rows[rowNumber]["FacturaProveedor"];
                    oHoja.Cells[rowNumber + 1, 4] = txtDT.Rows[rowNumber]["Id"];
                    oHoja.Cells[rowNumber + 1, 5] = txtDT.Rows[rowNumber]["RenglonId"];
                    oHoja.Cells[rowNumber + 1, 6] = txtDT.Rows[rowNumber]["NumeroParte"];
                    oHoja.Cells[rowNumber + 1, 7] = txtDT.Rows[rowNumber]["CantidadRecibida"];
                    oHoja.Cells[rowNumber + 1, 8] = txtDT.Rows[rowNumber]["UnidadMedida"];

                    if (!EsProveedores) //archivo global
                    {
                        if (rowNumber == 0)
                        {

                            oHoja.Cells[rowNumber + 1, 9] = Convert.ToString(peso);
                            oHoja.Cells[rowNumber + 1, 10] = Convert.ToString(peso);
                        }
                        else
                        {

                            oHoja.Cells[rowNumber + 1, 9] = Convert.ToString(0);
                            oHoja.Cells[rowNumber + 1, 10] = Convert.ToString(0);
                        }
                    }
                    else //SI es el archivo de proveedor
                    {

                        oHoja.Cells[rowNumber + 1, 9] = Convert.ToString(txtDT[rowNumber]["Peso"]);
                        oHoja.Cells[rowNumber + 1, 10] = Convert.ToString(txtDT[rowNumber]["Peso"]);
                    }

                    string pais = Convert.ToString(txtDT[rowNumber]["Pais"]);
                    if (pais.Length > 2)
                        pais = pais.Substring(0, 2);

                    oHoja.Cells[rowNumber + 1, 11] = Convert.ToString(pais);
                    oHoja.Cells[rowNumber + 1, 12] = Convert.ToString(txtDT[rowNumber]["Moneda"]);

                    //Cantidad de bultos solo en primer renglon
                    if (rowNumber == 0)
                        oHoja.Cells[rowNumber + 1, 13] = bultos.ToString();
                    else
                        oHoja.Cells[rowNumber + 1, 13] = "0";

                    if (rowNumber == 0)
                    {

                        oHoja.Cells[rowNumber + 1, 14] = Convert.ToString(txtDT[rowNumber]["Bu1"]);
                        oHoja.Cells[rowNumber + 1, 15] = Convert.ToString(txtDT[rowNumber]["Bu2"]);
                    }
                    else
                    {

                        oHoja.Cells[rowNumber + 1, 14] = Convert.ToString("");
                        oHoja.Cells[rowNumber + 1, 15] = Convert.ToString("");
                    }

                    oHoja.Cells[rowNumber + 1, 16] = Convert.ToString(txtDT[rowNumber]["NumeroPaleta"]);

                    if (EsProveedores)
                    {

                        oHoja.Cells[rowNumber + 1, 17] = Convert.ToString(txtDT[rowNumber]["NoGuia"]);
                        oHoja.Cells[rowNumber + 1, 18] = Convert.ToString(txtDT[rowNumber]["EmbarquePlanta"]); //consecutivo + nombrepaleta
                   
                        //aqui debe de ir el nombre dde la tabla
                    }
                    else
                        oHoja.Cells[rowNumber + 1, 17] = Convert.ToString(txtDT[rowNumber]["NoGuia"]);

                    //FIN DE CICLO
                }
            }

            oHoja.get_Range("Q1", "Q6500").NumberFormat = "0";

                    oLibro.SaveAs(archivo, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
            false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                     

                    oLibro.Close(true, true, Type.Missing);

                    // Eliminamos lo que hemos creado

                    oExcel.Quit();

                    oExcel = null;
                   
                    oLibro = null;
                   
                    oHoja = null;
                     System.GC.Collect();
                  
        }

        public void exportarRehacerArray(string archivo, DataSets.Embarques.GenerarTXTRehacerDataTable txtDT, bool EsProveedores, decimal peso)
        {
            int i = 0;
            Excel.Application oExcel = new Excel.Application();

            Excel.Workbook oLibro;

            Excel.Worksheet oHoja;


            oExcel.Visible = false;
            oExcel.DisplayAlerts = false;

            oLibro = oExcel.Workbooks.Add(1);
            oHoja = (Excel.Worksheet)oLibro.Sheets[1];

            int bultos = 0;
            for (int x = 0; x < txtDT.Rows.Count; x++)
            {
                bultos += Convert.ToInt32(txtDT[x]["bultos"]);
            }

            int columns = txtDT.Columns.Count;
            int rows = txtDT.Rows.Count;
            object[,] data = new object[rows, columns];
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    data[row, column] = txtDT.Rows[row][column];

                    data[row, 0] = Convert.ToDateTime(txtDT.Rows[row]["FechaRecibo"]).ToString("yyyy-MM-dd");
                    data[row, 1] = txtDT.Rows[row]["ProveedorId"];
                    data[row, 2] = txtDT.Rows[row]["FacturaProveedor"];
                    data[row, 3] = txtDT.Rows[row]["Id"];
                    data[row, 4] = txtDT.Rows[row]["RenglonId"];
                    data[row, 5] = txtDT.Rows[row]["NumeroParte"];
                    data[row, 6] = txtDT.Rows[row]["CantidadRecibida"];
                    data[row, 7] = txtDT.Rows[row]["UnidadMedida"];

                    if (!EsProveedores) //archivo global
                    {
                        if (row == 0)
                        {

                            data[row, 8] = Convert.ToString(peso);
                            data[row, 9] = Convert.ToString(peso);
                        }
                        else
                        {

                            data[row, 8] = Convert.ToString(0);
                            data[row, 9] = Convert.ToString(0);
                        }
                    }
                    else //SI es el archivo de proveedor
                    {

                        data[row,8] = Convert.ToString(txtDT[row]["Peso"]);
                        data[row, 9] = Convert.ToString(txtDT[row]["Peso"]);
                    }

                    string pais = Convert.ToString(txtDT[row]["Pais"]);
                    if (pais.Length > 2)
                        pais = pais.Substring(0, 2);

                    data[row, 10] = Convert.ToString(pais);
                    data[row, 11] = Convert.ToString(txtDT[row]["Moneda"]);

                    //Cantidad de bultos solo en primer renglon
                    if (row == 0)
                        data[row, 12] = bultos.ToString();
                    else
                        data[row, 12] = "0";

                    if (row == 0)
                    {

                        data[row, 13] = Convert.ToString(txtDT[row]["Bu1"]);
                        data[row, 14] = Convert.ToString(txtDT[row]["Bu2"]);
                    }
                    else
                    {

                        data[row, 13] = Convert.ToString("");
                        data[row, 14] = Convert.ToString("");
                    }

                    data[row, 15] = Convert.ToString(txtDT[row]["NumeroPaleta"]);

                    if (EsProveedores)
                    {

                        data[row, 16] = Convert.ToString(txtDT[row]["NoGuia"]);
                        data[row, 17] = Convert.ToString(txtDT[row]["EmbarquePlanta"]); //consecutivo + nombrepaleta

                        //aqui debe de ir el nombre dde la tabla
                    }
                    else
                        data[row, 16] = Convert.ToString(txtDT[row]["NoGuia"]);

                //FIN CICLO
                }
            }

            object startCell = oHoja.Cells[1, 1];
            object endCell = oHoja.Cells[rows, 17];
            oHoja.get_Range(startCell, endCell).Value2=data;
            oHoja.get_Range("Q1", "Q6500").NumberFormat = "0";

            oLibro.SaveAs(archivo, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
    false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);


            oLibro.Close(true, true, Type.Missing);

            // Eliminamos lo que hemos creado

            oExcel.Quit();

            oExcel = null;

            oLibro = null;

            oHoja = null;
            System.GC.Collect();

        }

        public void exportarMQ(string archivo, DataSets.Maquinaria.GenerarTXTDataTable txtDT)
        {
            string linea = "";
            DataSets.MaquinariaTableAdapters.MaterialesMaquinariaTableAdapter MeQ = new MaterialCore.DataSets.MaquinariaTableAdapters.MaterialesMaquinariaTableAdapter();


            using (StreamWriter sw = new StreamWriter(archivo, false))
            {
                for (int i = 0; i < txtDT.Rows.Count; i++)
                {
                    linea = FormatoCampoEspacios(Convert.ToDateTime(txtDT[i]["Fecha"]).ToString("yyyy-MM-dd"), 11, TextAlignment.Left);
                    linea += FormatoCampoCeros(Convert.ToString(txtDT[i]["Proveedor"]), 5, TextAlignment.Right) + " ";
                    linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["FacturaImportacion"]), 16, TextAlignment.Left);
                    linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["numPO"]), 7, TextAlignment.Left);
                    linea += FormatoCampoEspacios(FormatoCampoCeros(Convert.ToString(txtDT[i]["LineaPO"]), 3, TextAlignment.Right), 4, TextAlignment.Left);
                    linea += FormatoCampoEspacios(FormatoCampoCeros(Convert.ToString(txtDT[i]["Hijo"]), 2, TextAlignment.Right), 3, TextAlignment.Left);
                    //linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["NumeroParte"]), 16 + 8, TextAlignment.Left) ;
                    linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["NumeroParte"]), 13, TextAlignment.Left);
                    //   linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["salvacion"]), 16, TextAlignment.Left);
                    linea += FormatoCampoEspacios(Convert.ToString("0000000000"), 11, TextAlignment.Left); //correspondiente a familia
                    linea += FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(txtDT[i]["CantidadRecibida"]), 12, 2, TextAlignment.Right), 13, TextAlignment.Left);
                    linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["UnidadMedida"]), 3, TextAlignment.Left);
                    linea += FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(txtDT[i]["PesoBruto"]), 17, 8, TextAlignment.Right), 18, TextAlignment.Left);
                    linea += FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(txtDT[i]["PesoNeto"]), 17, 8, TextAlignment.Right), 18, TextAlignment.Left);

                    if (txtDT[i]["PaisOrigen"].ToString().Length > 2)
                        linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["PaisOrigen"]).Substring(0, 2), 7, TextAlignment.Left);
                    else
                        linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["PaisOrigen"]), 7, TextAlignment.Left);


                    //      linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["Moneda"]), 4, TextAlignment.Left) ;
                    linea += FormatoCampoEspacios(Convert.ToString("   "), 4, TextAlignment.Left);
                    linea += FormatoCampoEspacios(FormatoCampoCeros(Convert.ToString(txtDT[i]["CantidadBultos"]), 9, TextAlignment.Right), 10, TextAlignment.Left);
                    linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["TipoBulto"]), 5, TextAlignment.Left);
                    linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["ContenidoTipoBulto"]), 5, TextAlignment.Left);
                    linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["NumeroGuia"]), 41, TextAlignment.Left);

                    linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["Transportista"]), 41, TextAlignment.Left);
                    linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["Marca"]), 41, TextAlignment.Left);
                    linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["Modelo"]), 41, TextAlignment.Left);
                    linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["Serie"]), 48, TextAlignment.Left);

                    try
                    {
                        sw.WriteLine(linea);
                        //descativar para probar que lo desactiva
                        //MeQ.UpdateEnviado(Convert.ToInt32(txtDT[i]["Id"]));
                    }
                    catch
                    {

                    }


                }
            }

        }


        #region funciones




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
