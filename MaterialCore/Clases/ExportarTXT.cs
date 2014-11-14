using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Data;
using System.Data.SqlTypes;

namespace MaterialCore.Clases
{
    class ExportarTXT
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

        public void exportarRehacer(string archivo, DataSets.Embarques.GenerarTXTRehacerDataTable txtDT, bool EsProveedores, decimal peso,bool comas)
        {
            string linea = "";

            int bultos = 0;
            for (int i = 0; i < txtDT.Rows.Count; i++)
            {
                bultos += Convert.ToInt32(txtDT[i]["bultos"]);
            }
            
            using (StreamWriter sw = new StreamWriter(archivo,true))
            {
                if (comas == true)
                {

                    for (int i = 0; i < txtDT.Rows.Count; i++)
                    {

                        linea = FormatoCampoEspacios(Convert.ToDateTime(txtDT[i]["FechaRecibo"]).ToString("yyyy-MM-dd"), 10, TextAlignment.Left) + "," +
                        FormatoCampoCeros(Convert.ToString(txtDT[i]["ProveedorId"]), 10, TextAlignment.Right) + " " + "," +
                                FormatoCampoEspacios(Convert.ToString(txtDT[i]["FacturaProveedor"]), 30, TextAlignment.Left) + "," +
                                FormatoCampoEspacios(Convert.ToString(txtDT[i]["Id"]), 20, TextAlignment.Left) + "," +
                                FormatoCampoEspacios(FormatoCampoCeros(Convert.ToString(txtDT[i]["RenglonId"]), 10, TextAlignment.Right), 10, TextAlignment.Left) + "," +
                                FormatoCampoEspacios(Convert.ToString(txtDT[i]["NumeroParte"]), 30, TextAlignment.Left) + "," +
                                FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(txtDT[i]["CantidadRecibida"]), 12, 2, TextAlignment.Right), 12, TextAlignment.Left) + "," +
                                FormatoCampoEspacios(Convert.ToString(txtDT[i]["UnidadMedida"]), 2, TextAlignment.Left) + ",";


                        //parte del peso
                        if (!EsProveedores) //archivo global
                        {
                            if (i == 0)
                            {
                                linea +=
                                FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(peso), 17, 8, TextAlignment.Right), 17, TextAlignment.Left) + "," +
                                FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(peso), 17, 8, TextAlignment.Right), 17, TextAlignment.Left) + ",";
                            }
                            else
                            {
                                linea +=
                                FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(0), 17, 8, TextAlignment.Right), 17, TextAlignment.Left) + "," +
                                FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(0), 17, 8, TextAlignment.Right), 17, TextAlignment.Left) + ",";
                            }
                        }
                        else //SI es el archivo de proveedor
                        {
                            linea +=
                            FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(txtDT[i]["Peso"]), 17, 8, TextAlignment.Right), 17, TextAlignment.Left) + "," +
                            FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(txtDT[i]["Peso"]), 17, 8, TextAlignment.Right), 17, TextAlignment.Left) + ",";
                        }

                        string pais = Convert.ToString(txtDT[i]["Pais"]);
                        if (pais.Length > 2)
                            pais = pais.Substring(0, 2);

                        linea +=
                            //FormatoCampoEspacios(Convert.ToString(txtDT[i]["Pais"]).Substring(0, 2), 7, TextAlignment.Left) +
                        FormatoCampoEspacios(Convert.ToString(pais), 2, TextAlignment.Left) + "," +
                        FormatoCampoEspacios(Convert.ToString(txtDT[i]["Moneda"]), 3, TextAlignment.Left) + ",";

                        //Cantidad de bultos solo en primer renglon
                        if (i == 0)
                            linea += FormatoCampoEspacios(FormatoCampoCeros(bultos.ToString(), 9, TextAlignment.Right), 9, TextAlignment.Left) + ",";
                        else
                            linea += FormatoCampoEspacios(FormatoCampoCeros("0", 9, TextAlignment.Right), 9, TextAlignment.Left) + ",";

                        if (i == 0)
                        {
                            linea +=
                               FormatoCampoEspacios(Convert.ToString(txtDT[i]["Bu1"]), 5, TextAlignment.Left) + "," +
                               FormatoCampoEspacios(Convert.ToString(txtDT[i]["Bu2"]), 5, TextAlignment.Left) + ",";
                        }
                        else
                        {
                            linea +=
                               FormatoCampoEspacios(Convert.ToString(""), 5, TextAlignment.Left) + "," +
                               FormatoCampoEspacios(Convert.ToString(""), 5, TextAlignment.Left) + ",";
                        }

                        linea +=
                                FormatoCampoEspacios(Convert.ToString(txtDT[i]["NumeroPaleta"]), 30, TextAlignment.Left) + ",";



                        if (EsProveedores)
                        {

                            linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["NoGuia"]), 30, TextAlignment.Left) + "," +
                                FormatoCampoEspacios(Convert.ToString(txtDT[i]["EmbarquePlanta"]), 8, TextAlignment.Left) + ","; //consecutivo + nombrepaleta
                            //   FormatoCampoEspacios(Convert.ToString(txtDT[i]["Tarima"]), 42, TextAlignment.Left);
                            //aqui debe de ir el nombre dde la tabla

                            //   FormatoCampoEspacios(Convert.ToString(txtDT[i]["NoGuia"]), txtDT[i]["NoGuia"].ToString().Length, TextAlignment.Left);
                        }
                        else
                            linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["NoGuia"]), 30, TextAlignment.Left) + ",";


                        sw.WriteLine(linea);
                    }
                }
                else
                {
                    for (int i = 0; i < txtDT.Rows.Count; i++)
                    {

                        linea = FormatoCampoEspacios(Convert.ToDateTime(txtDT[i]["FechaRecibo"]).ToString("yyyy-MM-dd"), 10, TextAlignment.Left) + " " +
                        FormatoCampoCeros(Convert.ToString(txtDT[i]["ProveedorId"]), 10, TextAlignment.Right) + " " +
                                FormatoCampoEspacios(Convert.ToString(txtDT[i]["FacturaProveedor"]), 30, TextAlignment.Left) + " " +
                                FormatoCampoEspacios(Convert.ToString(txtDT[i]["Id"]), 20, TextAlignment.Left) + " " +
                                FormatoCampoEspacios(FormatoCampoCeros(Convert.ToString(txtDT[i]["RenglonId"]), 10, TextAlignment.Right), 10, TextAlignment.Left) + " " +
                                FormatoCampoEspacios(Convert.ToString(txtDT[i]["NumeroParte"]), 30, TextAlignment.Left) + " " +
                                FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(txtDT[i]["CantidadRecibida"]), 12, 2, TextAlignment.Right), 12, TextAlignment.Left) + " " +
                                FormatoCampoEspacios(Convert.ToString(txtDT[i]["UnidadMedida"]), 2, TextAlignment.Left)+ " " ;


                        //parte del peso
                        if (!EsProveedores) //archivo global
                        {
                            if (i == 0)
                            {
                                linea +=
                                FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(peso), 17, 8, TextAlignment.Right), 17, TextAlignment.Left) + " " +
                                FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(peso), 17, 8, TextAlignment.Right), 17, TextAlignment.Left) + " ";
                            }
                            else
                            {
                                linea +=
                                FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(0), 17, 8, TextAlignment.Right), 17, TextAlignment.Left) + " " +
                                FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(0), 17, 8, TextAlignment.Right), 17, TextAlignment.Left) + " ";
                            }
                        }
                        else //SI es el archivo de proveedor
                        {
                            linea +=
                            FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(txtDT[i]["Peso"]), 17, 8, TextAlignment.Right), 17, TextAlignment.Left) + " " +
                            FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(txtDT[i]["Peso"]), 17, 8, TextAlignment.Right), 17, TextAlignment.Left) + " ";
                        }

                        string pais = Convert.ToString(txtDT[i]["Pais"]);
                        if (pais.Length > 2)
                            pais = pais.Substring(0, 2);

                        linea +=
                            //FormatoCampoEspacios(Convert.ToString(txtDT[i]["Pais"]).Substring(0, 2), 7, TextAlignment.Left) +
                        FormatoCampoEspacios(Convert.ToString(pais), 2, TextAlignment.Left) + " " +
                        FormatoCampoEspacios(Convert.ToString(txtDT[i]["Moneda"]), 3, TextAlignment.Left) + " ";

                        //Cantidad de bultos solo en primer renglon
                        if (i == 0)
                            linea += FormatoCampoEspacios(FormatoCampoCeros(bultos.ToString(), 9, TextAlignment.Right), 10, TextAlignment.Left) + " ";
                        else
                            linea += FormatoCampoEspacios(FormatoCampoCeros("0", 9, TextAlignment.Right), 10, TextAlignment.Left) + " ";

                        if (i == 0)
                        {
                            linea +=
                               FormatoCampoEspacios(Convert.ToString(txtDT[i]["Bu1"]), 5, TextAlignment.Left) + " " +
                               FormatoCampoEspacios(Convert.ToString(txtDT[i]["Bu2"]), 5, TextAlignment.Left) + " ";
                        }
                        else
                        {
                            linea +=
                               FormatoCampoEspacios(Convert.ToString(""), 5, TextAlignment.Left) +  " " +
                               FormatoCampoEspacios(Convert.ToString(""), 5, TextAlignment.Left) + " ";
                        }

                        linea +=
                                FormatoCampoEspacios(Convert.ToString(txtDT[i]["NumeroPaleta"]), 30, TextAlignment.Left) + " ";



                        if (EsProveedores)
                        {

                            linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["NoGuia"]), 30, TextAlignment.Left) + " " +
                                FormatoCampoEspacios(Convert.ToString(txtDT[i]["EmbarquePlanta"]), 8, TextAlignment.Left) + " "; //consecutivo + nombrepaleta
                            //   FormatoCampoEspacios(Convert.ToString(txtDT[i]["Tarima"]), 42, TextAlignment.Left);
                            //aqui debe de ir el nombre dde la tabla

                            //   FormatoCampoEspacios(Convert.ToString(txtDT[i]["NoGuia"]), txtDT[i]["NoGuia"].ToString().Length, TextAlignment.Left);
                        }
                        else
                            linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["NoGuia"]), 30, TextAlignment.Left);

                        sw.WriteLine(linea);
                    }
                }
            }

        }


        public void exportarMQ(string archivo, DataSets.Maquinaria.GenerarTXTDataTable txtDT)
        {
            string linea = "";
            DataSets.MaquinariaTableAdapters.MaterialesMaquinariaTableAdapter MeQ = new MaterialCore.DataSets.MaquinariaTableAdapters.MaterialesMaquinariaTableAdapter();


            using (StreamWriter sw = new StreamWriter(archivo,false))
            {
                for (int i = 0; i < txtDT.Rows.Count; i++)
                {
                    linea = FormatoCampoEspacios(Convert.ToDateTime(txtDT[i]["Fecha"]).ToString("yyyy-MM-dd"), 10, TextAlignment.Left) + " ";
                    linea += FormatoCampoCeros(Convert.ToString(txtDT[i]["Proveedor"]), 10, TextAlignment.Right) + " " ;
                    linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["FacturaImportacion"]), 30, TextAlignment.Left) + " ";
                    linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["numPO"]), 20, TextAlignment.Left) + " ";
                    linea += FormatoCampoEspacios(FormatoCampoCeros(Convert.ToString(txtDT[i]["LineaPO"]), 3, TextAlignment.Right), 4, TextAlignment.Left) + " ";
                    linea += FormatoCampoEspacios(FormatoCampoCeros(Convert.ToString(txtDT[i]["Hijo"]), 2, TextAlignment.Right), 3, TextAlignment.Left) + " ";
                    //linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["NumeroParte"]), 16 + 8, TextAlignment.Left) ;
                    linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["NumeroParte"]), 30, TextAlignment.Left) + " ";
                 //   linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["salvacion"]), 16, TextAlignment.Left);
                    linea += FormatoCampoEspacios(Convert.ToString("0000000000"), 11, TextAlignment.Left); //correspondiente a familia
                    linea += FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(txtDT[i]["CantidadRecibida"]), 12, 2, TextAlignment.Right), 12, TextAlignment.Left) + " ";
                    linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["UnidadMedida"]), 2, TextAlignment.Left) + " ";
                    linea += FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(txtDT[i]["PesoBruto"]), 17, 8, TextAlignment.Right), 17, TextAlignment.Left) + " ";
                    linea += FormatoCampoEspacios(FormatoCampoDecimal(Convert.ToString(txtDT[i]["PesoNeto"]), 17, 8, TextAlignment.Right), 17, TextAlignment.Left) + " ";

                    if (txtDT[i]["PaisOrigen"].ToString().Length > 2)
                        linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["PaisOrigen"]).Substring(0, 2), 2, TextAlignment.Left) + " ";
                    else
                        linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["PaisOrigen"]), 2, TextAlignment.Left) + " ";


              //      linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["Moneda"]), 4, TextAlignment.Left) ;
                    linea += FormatoCampoEspacios(Convert.ToString("   "), 4, TextAlignment.Left) + " ";
                    linea += FormatoCampoEspacios(FormatoCampoCeros(Convert.ToString(txtDT[i]["CantidadBultos"]), 9, TextAlignment.Right), 9, TextAlignment.Left) + " ";
                    linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["TipoBulto"]), 5, TextAlignment.Left) + " ";
                    linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["ContenidoTipoBulto"]), 5, TextAlignment.Left) + " ";
                    linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["NumeroGuia"]), 30, TextAlignment.Left) + " ";

                    linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["Transportista"]), 41, TextAlignment.Left) + " ";
                    linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["Marca"]), 41, TextAlignment.Left) + " ";
                    linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["Modelo"]), 41, TextAlignment.Left) + " ";
                    linea += FormatoCampoEspacios(Convert.ToString(txtDT[i]["Serie"]), 48, TextAlignment.Left) + " ";

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
