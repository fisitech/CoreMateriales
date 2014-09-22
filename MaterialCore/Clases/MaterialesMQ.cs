using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace MaterialCore.Clases
{
    class MaterialesMQ : Clases.Conexion
    {
        //hacer funcion para que de nulo convierta a "" para llenar txt
        int _MaterialesOCId ;
        int _ClienteId;
        int _RenglonId;
        string _NumeroParte;
        decimal _CantidadPiezas;  
        string _UnidadMedida;
        decimal _PesoNeto;
        decimal _PesoBruto;  
        string _PaisOrigen;  
        decimal _CantidadBultos  ;
        string _TipoBulto  ;
        string _ContenidoTipoBulto  ;
        string _NumeroGuia  ;
        string _Marca  ;
        string _Modelo  ;
        string _Serie;
        bool _enviado;
        string _Descripcion;


        public MaterialesMQ()
        {
            LimpiarVars();
        }

        #region GET SET

        public int MaterialesOCId
        {
            get { return _MaterialesOCId; }
            set { _MaterialesOCId = value; }
        }

        public int ClienteId
        {
            get { return _ClienteId; }
            set { _ClienteId = value; }
        }

        public int RenglonId
        {
            get { return _RenglonId; }
            set { _RenglonId = value; }
        }

        public string NumeroParte
        {
            get { return _NumeroParte; }
            set { _NumeroParte = value; }
        }

        public decimal CantidadPiezas
        {
            get { return _CantidadPiezas; }
            set { _CantidadPiezas = value; }
        }

        public string UnidadMedida
        {
            get { return _UnidadMedida; }
            set { _UnidadMedida = value; }
        }

        public decimal PesoNeto
        {
            get { return _PesoNeto; }
            set { _PesoNeto = value; }
        }

        public decimal PesoBruto
        {
            get { return _PesoBruto; }
            set { _PesoBruto = value; }
        }

        public string PaisOrigen
        {
            get { return _PaisOrigen; }
            set { _PaisOrigen = value; }
        }

        public decimal CantidadBultos
        {
            get { return _CantidadBultos; }
            set { _CantidadBultos = value; }
        }

        public string TipoBulto
        {
            get { return _TipoBulto; }
            set { _TipoBulto = value; }
        }

        public string ContenidoTipoBulto
        {
            get { return _ContenidoTipoBulto; }
            set { _ContenidoTipoBulto = value; }
        }

        public string NumeroGuia
        {
            get { return _NumeroGuia; }
            set { _NumeroGuia = value; }
        }

        public string Marca
        {
            get { return _Marca; }
            set { _Marca = value; }
        }

        public string Modelo//light
        {
            get { return _Modelo; }
            set { _Modelo = value; }
        }

        public string Serie
        {
            get { return _Serie; }
            set { _Serie = value; }
        }

        public bool enviado
        {
            get { return _enviado; }
            set { _enviado = value; }
        }


        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }


        #endregion



        public void SelectMQbyID(int MaterialesOCId, int ClienteId, int RenglonId)
        {
            string sql = string.Format("SELECT " +
                                                            "MaterialesOCId " +
                                                            ",ClienteId " +
                                                            ",RenglonId " +
                                                             ",ISNULL(NumeroParte,'')  NumeroParte " + 
                                                            ",ISNULL(CantidadPiezas,0)  CantidadPiezas " + 
                                                            ",ISNULL(UnidadMedida,'')  UnidadMedida " + 
                                                            ",ISNULL(PesoNeto,0)  PesoNeto " + 
                                                            ",ISNULL(PesoBruto,0)  PesoBruto " + 
                                                            ",ISNULL(PaisOrigen,'')  PaisOrigen " + 
                                                            ",ISNULL(CantidadBultos,0)  CantidadBultos " + 
                                                            ",ISNULL(TipoBulto,'')  TipoBulto " + 
                                                            ",ISNULL(ContenidoTipoBulto,'')  ContenidoTipoBulto " + 
                                                            ",ISNULL(NumeroGuia,'')  NumeroGuia " + 
                                                            ",ISNULL(Marca,'')  Marca " + 
                                                            ",ISNULL(Modelo,'')  Modelo " + 
                                                            ",ISNULL(Serie,'')  Serie " + 
                                                            ",ISNULL(enviado,0)  enviado " +
                                                            ",ISNULL(Descripcion,'')  Descripcion " + 
                                                    "  FROM MaterialesMaquinaria " +
                                                    "  WHERE MaterialesOCId = {0} " +
                                                            "  AND ClienteId = {1} " +
                                                            "  AND RenglonId = {2}", MaterialesOCId, ClienteId, RenglonId);

            SqlDataReader lector = getLector(sql);
            if (lector.Read())
            {
                _MaterialesOCId = Convert.ToInt32(lector["MaterialesOCId"]);
                _ClienteId = Convert.ToInt32(lector["ClienteId"]);
                _RenglonId = Convert.ToInt32(lector["RenglonId"]);
                _NumeroParte = Convert.ToString(lector["NumeroParte"]);
                _CantidadPiezas = Convert.ToDecimal(lector["CantidadPiezas"]);
                _UnidadMedida = Convert.ToString(lector["UnidadMedida"]);
                _PesoNeto = Convert.ToInt32(lector["PesoNeto"]);
                _PesoBruto = Convert.ToInt32(lector["PesoBruto"]);
                _PaisOrigen = Convert.ToString(lector["PaisOrigen"]);
                _CantidadBultos = Convert.ToInt32(lector["CantidadBultos"]);
                _TipoBulto = Convert.ToString(lector["TipoBulto"]);
                _ContenidoTipoBulto = Convert.ToString(lector["ContenidoTipoBulto"]);
                _NumeroGuia = Convert.ToString(lector["NumeroGuia"]);
                _Marca = Convert.ToString(lector["Marca"]);
                _Modelo = Convert.ToString(lector["Modelo"]);
                _Serie = Convert.ToString(lector["Serie"]);
                _enviado = Convert.ToBoolean(lector["enviado"]);
                _Descripcion = Convert.ToString(lector["Descripcion"]);
            }
            else
                LimpiarVars();
            lector.Close();
        
        
        
        }

        public DataTable SelectMQbyNoEnviado()
        {
            string sql = "SELECT " +
                             "MaterialesOCId " +
                            ",ClienteId " +
                            ",RenglonId " +
                            ",ISNULL(NumeroParte,'')  NumeroParte " + 
                            ",ISNULL(CantidadPiezas,0)  CantidadPiezas " + 
                            ",ISNULL(UnidadMedida,'')  UnidadMedida " + 
                            ",ISNULL(PesoNeto,0)  PesoNeto " + 
                            ",ISNULL(PesoBruto,0)  PesoBruto " + 
                            ",ISNULL(PaisOrigen,'')  PaisOrigen " + 
                            ",ISNULL(CantidadBultos,0)  CantidadBultos " + 
                            ",ISNULL(TipoBulto,'')  TipoBulto " + 
                            ",ISNULL(ContenidoTipoBulto,'')  ContenidoTipoBulto " + 
                            ",ISNULL(NumeroGuia,'')  NumeroGuia " + 
                            ",ISNULL(Marca,'')  Marca " + 
                            ",ISNULL(Modelo,'')  Modelo " + 
                            ",ISNULL(Serie,'')  Serie " + 
                            ",ISNULL(enviado,0)  enviado " +
                             ",ISNULL(Descripcion,'')  Descripcion " + 
                            "FROM MaterialesMaquinaria   " + 
                            "WHERE enviado = 0" ;

            DataTable tabla = new DataTable();
            tabla.Load(this.getLector(sql));
            return tabla;

        }



        public void InsertMQ(int MaterialesOCId, int ClienteId, int RenglonId, string NumeroParte, decimal CantidadPiezas,
                                         string UnidadMedida,  decimal PesoNeto, decimal PesoBruto, string PaisOrigen, decimal CantidadBultos,
                                         string TipoBulto, string ContenidoTipoBulto, string NumeroGuia, string Marca, string Modelo, string Serie, string Descripcion )
        {

            InsertSQL = string.Format( "INSERT INTO [MaterialesMaquinaria] " +
                                        "([MaterialesOCId] " +
                                        ",[ClienteId] " +
                                        ",[RenglonId] " +
                                        ",[NumeroParte] " +
                                        ",[CantidadPiezas] " +
                                        ",[UnidadMedida] " +
                                        ",[PesoNeto] " +
                                        ",[PesoBruto] " +
                                        ",[PaisOrigen] " +
                                        ",[CantidadBultos] " +
                                        ",[TipoBulto] " +
                                        ",[ContenidoTipoBulto] " +
                                        ",[NumeroGuia] " +
                                        ",[Marca] " +
                                        ",[Modelo] " +
                                        ",[Serie] "+
                                        ",[Descripcion]) " +
                                "VALUES " +
                                        "({0} " +
                                        ",{1} " +
                                        ",{2} " +
                                        ",'{3}' " +
                                        ",'{4}' " +
                                        ",'{5}' " +
                                        ",{6} " +
                                        ",{7} " +
                                        ",'{8}' " +
                                        ",{9} " +
                                        ",'{10}' " +
                                        ",'{11}' " +
                                        ",'{12}' " +
                                        ",'{13}' " +
                                        ",'{14}' " +
                                        ",'{15}' "+
                                        ",'{16}' )", MaterialesOCId, ClienteId, RenglonId, NumeroParte, CantidadPiezas,
                                        UnidadMedida, PesoNeto, PesoBruto, PaisOrigen, CantidadBultos, TipoBulto, ContenidoTipoBulto,
                                        NumeroGuia, Marca, Modelo, Serie, Descripcion);
            this.insert();
        }




        public void UpdateMQ(int MaterialesOCId, int ClienteId, int RenglonId, string NumeroParte, decimal CantidadPiezas,
                                     string UnidadMedida, decimal PesoNeto, decimal PesoBruto, string PaisOrigen, decimal CantidadBultos,
                                     string TipoBulto, string ContenidoTipoBulto, string NumeroGuia, string Marca, string Modelo, string Serie, string Descripcion)
        {
            InsertSQL = string.Format("UPDATE MaterialesMaquinaria set  NumeroParte = '{3}', " + 
                                                            "CantidadPiezas = {4}, " + 
                                                            "UnidadMedida  = '{5}', " + 
                                                            "PesoNeto  = {6}, " + 
                                                            "PesoBruto  = {7}, " + 
                                                            "PaisOrigen  = '{8}', " + 
                                                            "CantidadBultos =   {9}, " + 
                                                            "TipoBulto  = '{10}', " + 
                                                            "ContenidoTipoBulto  = '{11}', " + 
                                                            "NumeroGuia  = '{12}', " + 
                                                            "Marca  = '{13}', " + 
                                                            "Modelo =  '{14}', " + 
                                                            "Serie  = '{15}', " +
                                                             "Descripcion  = '{16}' " + 
                                                    "WHERE MaterialesOCId = {0} " + 
                                                            "AND ClienteId = {1} " +
                                                            "AND RenglonId ={2}", MaterialesOCId, ClienteId, RenglonId, NumeroParte, CantidadPiezas,
                                        UnidadMedida, PesoNeto, PesoBruto, PaisOrigen, CantidadBultos, TipoBulto, ContenidoTipoBulto,
                                        NumeroGuia, Marca, Modelo, Serie, Descripcion);
            this.insert();
        }

        //las variables en el compack frameworck no haceptan valores nulos
        string VarNull(object Variable)
        {
            string Resultado = "NULL";
            if (Variable != null)
            {
                if (Variable.GetType() == Type.GetType("System.String"))
                {
                    Resultado = "'" + Convert.ToString(Variable) + "'";
                }

                if (Variable.GetType() == Type.GetType("System.Boolean"))
                {
                    if (Convert.ToBoolean(Variable))
                        Resultado = "1";
                    else
                        Resultado = "0";
                }

                if (Variable.GetType() == Type.GetType("System.DateTime"))
                {
                    Resultado = "'" + Convert.ToString(Variable) + "'";
                }

                if (Variable.GetType() == Type.GetType("System.Decimal") ||
                    Variable.GetType() == Type.GetType("System.Double")   ||
                    Variable.GetType() == Type.GetType("System.Int16")      ||
                    Variable.GetType() == Type.GetType("System.Int32")      ||
                    Variable.GetType() == Type.GetType("System.Int64"))
                  {
                      Resultado = Convert.ToString(Variable);
                  }
                }
                return Resultado;
            }

        void LimpiarVars()
        {
            _MaterialesOCId = 0;
            _ClienteId = 0;
            _RenglonId = 0;
            _NumeroParte = "";
            _CantidadPiezas = 0;
            _UnidadMedida = "";
            _PesoNeto = 0;
            _PesoBruto = 0;
            _PaisOrigen = "";
            _CantidadBultos = 0;
            _TipoBulto = "";
            _ContenidoTipoBulto = "";
            _NumeroGuia = "";
            _Marca = "";
            _Modelo = "";
            _Serie = "";
            _enviado = false;
            _Descripcion = "";
        }


    }
}
