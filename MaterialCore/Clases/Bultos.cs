        using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace MaterialCore.Clases
{

    class Bultos : Clases.Conexion
    {
        protected int _nid_arrive;
        protected string _clocation;
        protected int _nid_sku_type;
        protected int _nid_sku_state;
        protected int _nid_sku_level;
        protected bool _bexists;
        protected int _idCliente;
        protected int _nid_user_mat;
        private int _no_bultos;
        protected DateTime _fecha_entrega_mat;

        public Bultos(string nid_sku)
        {

            string sql = "SELECT nid_arrive, clocation, nid_sku_type, nid_sku_state, ISNULL(nid_sku_level,0)AS nid_sku_level, " +
            "bexists, ISNULL(IdCliente, -1)AS IdCliente, ISNULL(nid_user_mat,0) AS nid_user_mat,  " +
            "ISNULL(fecha_entrega_mat,'1800-01-01 00:00:00.000') AS fecha_entrega_mat " +
            "FROM dbo.sku_arrivals WHERE nid_sku = '" + nid_sku + "' ";
            
            SqlDataReader lector = getLector(sql);
            if (lector.Read())
            {
                _nid_arrive = Convert.ToInt32(lector["nid_arrive"]);
                _clocation = lector["clocation"].ToString();
                _nid_sku_type = Convert.ToInt32(lector["nid_sku_type"]);
                _nid_sku_state = Convert.ToInt32(lector["nid_sku_state"]);
                _nid_sku_level = Convert.ToInt32(lector["nid_sku_level"]);
                _bexists = Convert.ToBoolean(lector["bexists"]);
                _idCliente = Convert.ToInt32(lector["idCliente"]);
                _nid_user_mat = Convert.ToInt32(lector["nid_user_mat"]);
                _fecha_entrega_mat = Convert.ToDateTime(lector["fecha_entrega_mat"]);
            }
            lector.Close();
        }
        #region Sets and Gets

        public int nid_arrive
        {
            get { return _nid_arrive; }
            set { _nid_arrive = value; }
        }
        public string clocation
        {
            get { return _clocation; }
            set { _clocation = value; }
        }
        public int nid_sku_type
        {
            get { return _nid_sku_type; }
            set { _nid_sku_type = value; }
        }
        public int nid_sku_state
        {
            get { return _nid_sku_state; }
            set { _nid_sku_state = value; }
        }
        public int nid_sku_level
        {
            get { return _nid_sku_level; }
            set { _nid_sku_level = value; }
        }
        public bool bexists
        {
            get { return _bexists; }
            set { _bexists = value; }
        }
        public int idCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }
        public int nid_user_mat
        {
            get { return _nid_user_mat; }
            set { _nid_user_mat = value; }
        }
        public DateTime fecha_entrega_mat
        {
            get { return _fecha_entrega_mat; }
            set { _fecha_entrega_mat = value; }
        }

        public int no_bultos
        {
            get { return _no_bultos; }
        }

        #endregion

        public Bultos()
       {

        }
        //validacion super rapida

        //public string RecortarSKU(string nid_sku)
        //{
        //    string NoGuiaCode;

        //    if (nid_sku.Length == 18)
        //        NoGuiaCode = nid_sku.ToString().Substring(1, 12);
        //    else if (nid_sku.Length == 32)
        //        NoGuiaCode = nid_sku.ToString().Substring(16, 12);
        //    else if (nid_sku.Length == 22)
        //        NoGuiaCode = nid_sku.ToString().Substring(7);
        //    else
        //        NoGuiaCode = nid_sku;

        //    return NoGuiaCode;
        //}

        public string RecortarSKU(string nid_sku, bool Fedex)
        {
            string NoGuiaCode = nid_sku;

            if (Fedex)
            {
                //if (nid_sku.Length == 18)
                //    NoGuiaCode = nid_sku.ToString().Substring(1, 12);
                //else if (nid_sku.Length == 32)
                //    NoGuiaCode = nid_sku.ToString().Substring(16, 12);
                //else if (nid_sku.Length == 22)
                //    NoGuiaCode = nid_sku.ToString().Substring(7);
                //else
                //    NoGuiaCode = nid_sku;

                /*
                    Fecha 5/oct/11;
                    Se omitio el codigo de barras de 18 caracteres de FEDEX, por conflicto con
                    el de UPS a peticion de Oscar Ruiz, y que este codigo no debe de recortarlo para 
                    FEDEX porque no pertenece a este proveedor de paqueteria
                */

                /*CAmbiar por procedimiento almacenado normal*/
                string sql = "DECLARE	@return_value int, " +
                        "		@resultado varchar(75) " +
                        " " +
                        "EXEC	@return_value = [dbo].[sku_recortar] " +
                        "		@nid_sku = '" + nid_sku + "', " +
                        "		@resultado = @resultado OUTPUT " +
                        " " +
                        "SELECT	@resultado as '@resultado' ";


                SqlDataReader lector = this.getLector(sql);
                if (lector.Read())
                    NoGuiaCode = Convert.ToString(lector["@resultado"]);
                lector.Close();

                /*
                if (nid_sku.Length == 32)
                    NoGuiaCode = nid_sku.ToString().Substring(16, 12);
                else if (nid_sku.Length == 22)
                    NoGuiaCode = nid_sku.ToString().Substring(7);
                else if (nid_sku.Length == 34)
                    NoGuiaCode = nid_sku.ToString().Substring(22, 12);
                else
                    NoGuiaCode = nid_sku;

            }
            else
                NoGuiaCode = nid_sku;
                */
            }
            return NoGuiaCode;
        }

        public bool BultoValidacion(string sku, bool v_existe, bool v_cliente)
        {
            bool Existe = false;
            bool AI = false;
            int Cliente = -1;
            bool bCliente = false;
            string Hijo = "";
            int Nivel = 1;
            string mensaje = "";
            bool resultado = true;


            string sql = "DECLARE @nid_sku VARCHAR(75) SET @nid_sku= '" + sku + "' " +
                            "DECLARE @Existe BIT SET @Existe = 0 " +
                            "DECLARE @hijo_nivel INT SET @hijo_nivel = 0 " +
                            "DECLARE @hijo VARCHAR(75) SET @hijo = '' " +
                            "DECLARE @AI BIT SET @AI = 0 " +
                            "DECLARE @idCliente INT SET @idCliente = -1  " +
                            "DECLARE @cantbultos INT SET @cantbultos = 0  " +

                            "IF EXISTS(SELECT nid_sku FROM dbo.sku_arrivals WHERE nid_sku = @nid_sku) BEGIN " +
                            "SET @Existe = 1 " +
                            "SET @cantbultos = (SELECT cantbultos FROM sku_arrivals WHERE nid_sku = @nid_sku) " +
		                                "IF  EXISTS(SELECT nid_sku FROM dbo.sku_arrivals WHERE nid_sku = @nid_sku AND nid_sku_state <> 4) BEGIN " +
		                                "SET @AI = 1 " +
						                                    "SET @hijo = (SELECT TOP 1 nid_sku FROM sku_parents WHERE nid_parent = @nid_sku) " +
                                                             "SET @hijo_nivel =(SELECT dbo.sku_arrivals.nid_sku_level FROM dbo.sku_arrivals INNER JOIN " +
                                                             "dbo.sku_levels ON dbo.sku_arrivals.nid_sku_level = dbo.sku_levels.nid_sku_level " +
                                                             "WHERE dbo.sku_arrivals.nid_sku = @hijo) " +
                                                             "IF (@hijo is NULL) BEGIN SET @hijo = ' ' SET @hijo_nivel = 1 END " +
                                                  "SET  @idCliente = (SELECT ISNULL(idCliente,-1) FROM sku_arrivals WHERE nid_sku = @nid_sku) " +
					                                "IF  NOT EXISTS (SELECT idCliente FROM sku_arrivals WHERE nid_sku = @nid_sku ) " +
						                                "BEGIN SET @idCliente = -1 END/*fin de asociacion con cliente*/ " +
		                                 "END/*fin de AI*/ " +
                             "END/*fin de Existe */" +
                            "SELECT @Existe AS  'Existe', @AI AS 'AI',@idCliente AS 'Cliente', @hijo AS 'Hijo', @hijo_nivel AS 'Nivel', @cantbultos as 'cantbultos' ";
            SqlDataReader lector = getLector(sql);
            if (lector.Read())
            {
                Existe = Convert.ToBoolean(lector["Existe"]);
                AI = Convert.ToBoolean(lector["AI"]);
                Cliente = Convert.ToInt32(lector["Cliente"]);
                Hijo = lector["Hijo"].ToString();
                Nivel = Convert.ToInt32(lector["Nivel"]);
                _no_bultos = Convert.ToInt32(lector["cantbultos"]);
                lector.Close();
                if(Cliente != -1)
                    bCliente = true;


                if (v_existe)
                {
                    if (!Existe)
                    {
                        MessageBox.Show("El bulto escaneado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                        return false;
                    }
                    else // si existe
                    {
                        if (AI == false)
                        {
                            MessageBox.Show("El bulto escaneado no pertenece a AI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                            return false;
                        }
                        else //si pertenese
                        {
                            if (v_cliente)
                            {
                                if (!bCliente)
                                {
                                    mensaje = "El bulto escaneado no a sido asociado a ningun cliente";
                                    resultado = false;
                                }
                            }
                            else
                            {
                                if (bCliente)
                                {
                                    mensaje = "El bulto escaneado ya fue asociado a un cliente";
                                    resultado = false;
                                }
                            }


                            if (Nivel != 1 && Nivel != 0)
                            {
                                if (Nivel == 2)
                                    mensaje = "El bulto escaneado DERIVA a otros bultos, uno de ellos es el bulto: " + Hijo + "  ";
                                else
                                    mensaje = "El bulto escaneado CONFORMA al bulto: " + Hijo + "";

                                resultado = false;
                            }


                        }//fin pertenece

                    }//else existe
                }//v_existe
                else// if v_exist = 0
                {
                    if (Existe != false)
                    {
                        mensaje = "El bulto escaneado ya existe";
                        resultado = false;
                    }
                    if (Nivel != 1 && Nivel != 0)
                    {
                        if (Nivel == 2)
                            mensaje = "El bulto escaneado DERIVA a otros bultos, uno de ellos es el bulto: " + Hijo + "  ";
                        else
                            mensaje = "El bulto escaneado CONFORMA al bulto: " + Hijo + "";
                        resultado = false;
                    }
                }
            }//fin de lector
            else lector.Close();

            if (resultado == false)
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
           
            return resultado;
        }

        //TODO: Validacion para despacho y shipping

        public bool BultoValidacion2(string nid_sku, bool v_deploy, bool v_shipping)
        {
            bool resultado = false;
            bool deploy = false;
            bool shipping = false;

            string sql = "DECLARE @nid_sku VARCHAR(75) SET @nid_sku = '" + nid_sku + "' " +
                            "DECLARE @nid_arrive BIT SET  @nid_arrive =0 " +
                            "DECLARE @nid_deploy bit  SET @nid_deploy =0 " +

                            "IF EXISTS ( SELECT  nid_arrive FROM dbo.shipping_arrivals_detail_skus WHERE nid_sku = @nid_sku) " +
                            "BEGIN SET @nid_arrive = 1 END " +

                            "IF EXISTS ( SELECT   nid_deploy FROM dbo.deploys_detail_skus WHERE nid_sku = @nid_sku) " +
                            "BEGIN 	SET @nid_deploy = 1 END " +

                            "SELECT ISNULL(@nid_arrive,0) AS 'nid_arrive', ISNULL(@nid_deploy,0) AS 'nid_deploy' ";

              SqlDataReader lector = getLector(sql);
              if (lector.Read())
              {
                  deploy = Convert.ToBoolean(lector["nid_deploy"]);
                  shipping = Convert.ToBoolean(lector["nid_arrive"]);
                  lector.Close();

                  if (deploy != v_deploy)
                  {
                      if (deploy) 
                          MessageBox.Show("El bulto escaneado ya fue asignado a un despacho", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                      else
                          MessageBox.Show("El bulto escaneado todavía no ha sido asignado a un despacho", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                      return false;
                  }

                  if (shipping != v_shipping)
                  {
                      if (shipping) //TODO: checar mensajes de error para shipping
                          MessageBox.Show("El bulto escaneado ya fue asignado a un embarque", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                      else
                          MessageBox.Show("El bulto escaneado todavía no ha sido asignado a un embarque", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                      return false;
                  }
                  return true;
              }
              else lector.Close();


              return false;
        
        }


        
        public bool ExisteNoGuia(string sku)
        {
            bool resultado = false;
            string sql = "Select nid_sku from sku_arrivals where nid_sku = '" + sku + "' "; 
            SqlDataReader lector = this.getLector(sql);

            if (lector.Read())
                resultado = true;

            lector.Close();
            return resultado;
        }

        public bool ExiteNoGuiaLlegada(string sku, int nid_arrive)
        {
            bool resultado = false;
            string sql = "Select nid_sku from sku_arrivals where nid_sku = '" + sku + "' and nid_arrive = " + nid_arrive;
            SqlDataReader lector = this.getLector(sql);

            if (lector.Read())
                resultado = true;

            lector.Close();
            return resultado;
        }

        public bool ExisteNoGuiaDifLlegada(string sku, int nid_arrive)
        {
            bool resultado = false;
            string sql = "Select nid_sku from sku_arrivals where nid_sku = '" + sku + "' and nid_arrive <> " + nid_arrive;
            SqlDataReader lector = this.getLector(sql);

            if (lector.Read())
                resultado = true;

            lector.Close();
            return resultado;
        }

         public bool NivelNoGuia(string sku)
        {
            bool ok = true;
            string hijo = "";
            int level_hijo = 0;
                 string sql = "DECLARE @nid_sku VARCHAR(75) " +
                                     "DECLARE @hijo VARCHAR(75) " +
                                     "DECLARE @hijo_nivel INT  " +
                                     "SET @nid_sku = '" + sku + "'   " +
                                     "SET @hijo = (SELECT TOP 1 nid_sku FROM sku_parents WHERE nid_parent = @nid_sku) " +
                                     "SET @hijo_nivel =(SELECT dbo.sku_arrivals.nid_sku_level FROM dbo.sku_arrivals INNER JOIN   " +
                                     "dbo.sku_levels ON dbo.sku_arrivals.nid_sku_level = dbo.sku_levels.nid_sku_level   " +
                                     "WHERE dbo.sku_arrivals.nid_sku = @hijo)   " +
                                     "IF (@hijo is NULL) BEGIN SET @hijo = ' ' SET @hijo_nivel = 1 END " +
                                     "SELECT @hijo AS 'hijo', @hijo_nivel AS 'level_hijo' ";
                 SqlDataReader lector = getLector(sql);
                 if (lector.Read())
                 {
                     hijo = lector["hijo"].ToString();
                     level_hijo = Convert.ToInt32(lector["level_hijo"]);
                 }

                 lector.Close();

            switch (level_hijo)
            {
                case 2:
                    ok = false;
                    MessageBox.Show("El bulto escaneado deriva a otros bultos, uno de ellos es el bulto: " + hijo + "");
                    break;
                case 3:
                    ok = false;
                    MessageBox.Show("El bulto escaneado conforma al bulto: " + hijo + "");
                    break;
            }
            return ok; // no conforma a nada
        }

        public bool GuiadeAI(string sku) //solo guias que pertenecen a american industries
        {
            bool resultado = true;
            string sql = "Select nid_sku from sku_arrivals where nid_sku =  '" + sku + "'AND nid_sku_state <> 4";
            SqlDataReader lector = this.getLector(sql);

            if (lector.Read())
                resultado = true;
            else
                resultado = false;

            lector.Close();
            return resultado;
        }
        public bool GuianoAsociada(string sku) //valida que el numero de guia no a sido asociada a un cliente
        {
            bool resultado = true;
            string sql = "Select nid_sku from sku_arrivals where nid_sku =  '" + sku + "' AND nid_user_mat is  null AND idCliente is  null";
            SqlDataReader lector = this.getLector(sql);
            if (lector.Read())
                resultado = true;
            else
                resultado = false;
            lector.Close();
            return resultado;
        }

        public int GuiaNoCliente(string sku) //Cliente espesifico
        {
            int resultado;
            string sql = "Select idCliente from sku_arrivals where nid_sku =  '" + sku + "'";
            SqlDataReader lector = this.getLector(sql);
            if (lector.Read())
                if (lector["idCliente"].ToString() != "")
                    resultado = Convert.ToInt32(lector["idCliente"]);
                else
                    resultado = -1;
            else
                resultado = -1;
            lector.Close();
            return resultado;
        }

        public string ObtEstadoBulto(string sku) //por numero de guia
        {
            string resultado = "";
             string sql = "SELECT     sku_state.cname_sku_state " +
               "FROM         sku_arrivals INNER JOIN " +
                     "    sku_state ON sku_arrivals.nid_sku_state = sku_state.nid_sku_state " +
               "where   sku_arrivals.nid_sku = '" + sku + "'";

            SqlDataReader lectorBulto = this.getLector(sql);
            if (lectorBulto.Read())
                 resultado = Convert.ToString(lectorBulto["cname_sku_state"]);
         
            lectorBulto.Close();
            return resultado;
        }
        public int Obt_nid_arriveBulto(string sku) //por numero de guia
        {
            int resultado = 0;
            string sql = "SELECT     sku_arrivals.nid_arrive, sku_arrivals.nid_sku, sku_state.cname_sku_state " +
               "FROM         sku_arrivals INNER JOIN " +
                     "    sku_state ON sku_arrivals.nid_sku_state = sku_state.nid_sku_state " +
               "where   sku_arrivals.nid_sku = '" + sku + "'";

            SqlDataReader lectorBulto = this.getLector(sql);
            if (lectorBulto.Read())
                resultado=  Convert.ToInt32(lectorBulto["nid_arrive"]);
      
                lectorBulto.Close();
                return resultado;
        }




        public int ObtEstadoBultoID(string sku) //por numero de guia
        {
            int Estado = 0;
            string sql = "SELECT     sku_state.nid_sku_state " +
               "FROM         sku_arrivals INNER JOIN " +
                     "    sku_state ON sku_arrivals.nid_sku_state = sku_state.nid_sku_state " +
               "where   sku_arrivals.nid_sku = '" + sku + "'";
            SqlDataReader lectorBulto = this.getLector(sql);

            if (lectorBulto.Read())
            {
                Estado = Convert.ToInt32(lectorBulto["nid_sku_state"]);
                lectorBulto.Close();
                return Estado;

            }
            else
            {
                lectorBulto.Close();
                return 0;
            }
        }

        public long GuardarBultos(int nid_arrive, string nid_sku, int nid_sku_type, string clocation, int nid_sku_state, int nid_sku_level)
        {
            InsertSQL = "INSERT INTO sku_arrivals " +
                              "(nid_arrive, nid_sku, nid_sku_type, clocation,  nid_sku_state, nid_sku_level, bloaded) " +
                "VALUES     (@nid_arrive,@nid_sku,@nid_sku_type,@clocation, @nid_sku_state,@nid_sku_level, 0)";

            InsertParametros.Add("@nid_arrive", SqlDbType.VarChar, 100).Value = nid_arrive;
            InsertParametros.Add("@nid_sku", SqlDbType.VarChar, 100).Value = nid_sku;
            InsertParametros.Add("@nid_sku_type", SqlDbType.VarChar, 100).Value = nid_sku_type;
            InsertParametros.Add("@clocation", SqlDbType.VarChar, 100).Value = clocation;
            InsertParametros.Add("@nid_sku_state", SqlDbType.VarChar, 100).Value = nid_sku_state;
            InsertParametros.Add("@nid_sku_level", SqlDbType.VarChar, 100).Value = nid_sku_level;

            return  this.insert();
        }

        public long ActualizaBultos(int nid_arrive, int nid_sku_type, string clocation, int nid_sku_state, int nid_sku_level, string nid_sku)
        {
            InsertSQL = "UPDATE    sku_arrivals " +
                                "SET              nid_arrive ='" + nid_arrive + "', clocation ='" + clocation + "', nid_sku_type = '" + nid_sku_type + "', nid_sku_state ='" + nid_sku_state + "', nid_sku_level ='" + nid_sku_level + "' " +
                            "WHERE     (nid_sku = '" + nid_sku + "') ";

            return this.insert();
        }

        public long AsociarBultos(string IdCliente, string nid_user_mat, string nid_sku)
        {

            InsertSQL = "UPDATE    sku_arrivals " +
            "SET       IdCliente = '" + IdCliente + "', nid_user_mat = " + nid_user_mat + ", fecha_entrega_mat = GETDATE() " +
            "WHERE     (nid_sku = '" + nid_sku + "')";
   
            return this.insert();
        }

        public void LogCambioDueno(string nid_skuLog, int nid_userLog , int idCteAnt, int idCteNvo)
        {
            //Guarda en el log el cliente que se elimino
            InsertSQL = "INSERT INTO log_cambiodueno VALUES (@nid_sku, @movimiento, GETDATE(), @nid_user, @idCliente)";

            InsertParametros.Add("@nid_sku", SqlDbType.VarChar, 100).Value = nid_skuLog;
            InsertParametros.Add("@movimiento", SqlDbType.VarChar, 40).Value = "Desasignar Cliente";
            InsertParametros.Add("@nid_user", SqlDbType.Int, 4).Value = nid_userLog;
            InsertParametros.Add("@idCliente", SqlDbType.Int, 4).Value = idCteAnt;

            insert();

            InsertSQL = "INSERT INTO log_cambiodueno VALUES (@nid_sku, @movimiento, GETDATE(), @nid_user, @idCliente)";

            InsertParametros.Add("@nid_sku", SqlDbType.VarChar, 100).Value = nid_skuLog;
            InsertParametros.Add("@movimiento", SqlDbType.VarChar, 40).Value = "Asignar Cliente";
            InsertParametros.Add("@nid_user", SqlDbType.Int, 4).Value = nid_userLog;
            InsertParametros.Add("@idCliente", SqlDbType.Int, 4).Value = idCteNvo;

            insert();           

        }

        public long DesAsoBultos(string nid_sku)
        {

            InsertSQL = "UPDATE    sku_arrivals " +
            "SET       IdCliente = NULL, dfecha_sku = NULL " +
            "WHERE     (nid_sku = '" + nid_sku + "')";

            return this.insert();
        }

        public SqlDataReader GuiasSinAsignar(string filtro)
        {
            string sql = "";

            sql =  "SELECT sku_arrivals.nid_sku " +     
                    "FROM carriers_arrivals INNER JOIN sku_arrivals ON carriers_arrivals.nid_arrive = sku_arrivals.nid_arrive " +
                    "WHERE (carriers_Arrivals.nid_transport_type = 4) AND (sku_arrivals.nid_user_mat IS  null)  AND (sku_arrivals.IdCliente IS  null) and  (nid_sku_state <> 4 ) and (bexists = 1) " + filtro;
            return this.getLector(sql);
          
            }

        public SqlDataReader GuiasCliente(string idCliente) //guias ya asosiadas unicamente con cliente
        {
            string sql = "";

            sql = "    SELECT sku_arrivals.nid_sku , sku_arrivals.nid_sku_type, 'Caja' AS cname_sku_type, 'Recibos Paqueteria'  " +
                "	AS clocation, sku_arrivals.nid_sku_state,dbo.sku_state.cname_sku_state, 1 as guardado  " +
                 "     FROM carriers_arrivals INNER JOIN sku_arrivals ON carriers_arrivals.nid_arrive = sku_arrivals.nid_arrive " +
                  "    INNER JOIN sku_state ON sku_arrivals.nid_sku_state = dbo.sku_state.nid_sku_state " +
                   "    WHERE (carriers_Arrivals.nid_transport_type = 4) AND (sku_arrivals.nid_user_mat IS  null)  and  (sku_arrivals.nid_sku_state <> 4 )  " +
                   "    AND dbo.sku_arrivals.idcliente = '" + idCliente + "' ";
                 return this.getLector(sql);
        }

        public int CountGuia()
        {
            string sql = "";
            int resultado =0;

            sql = "SELECT COUNT(sku_arrivals.nid_sku ) AS cont " +
                        "FROM carriers_arrivals INNER JOIN sku_arrivals ON carriers_arrivals.nid_arrive = sku_arrivals.nid_arrive " +
                        "WHERE (carriers_Arrivals.nid_transport_type = 4) AND (sku_arrivals.nid_user_mat IS  null)  and (sku_arrivals.IdCliente IS  null) AND (nid_sku_state <> 4 ) AND (bexists = 1 ) ";

            SqlDataReader Bulto = this.getLector(sql);

            if (Bulto.Read())
            {
                resultado = Convert.ToInt32(Bulto["cont"]);
                Bulto.Close();
                return resultado;
            }
            else
            {
                Bulto.Close();
                return 0;
            }
        }


        public void CambiaCliente(string sku, int IdCliente)
        {
            InsertSQL =  "  UPDATE sku_arrivals " +
                    " SET IdCliente = '" + IdCliente + "' " +
                  "  WHERE nid_sku = '" + sku + "'";
            this.insert();
        }

        public DataTable PLBulto(string nid_sku) //despachos pendientes
        {
            string sql = "";
            DataTable tabla = new DataTable();
            //   nid_opl  |  nid_opl_in
            sql = "SELECT   dbo.packing_list_breakdown.nid_opl, dbo.origin_packing_list.nid_opl_in " +
                    "FROM packing_list_breakdown INNER JOIN dbo.origin_packing_list " +
                    "ON dbo.packing_list_breakdown.nid_opl =dbo.origin_packing_list.nid_opl " +
                    "WHERE nid_sku = '" + nid_sku + "'  ";
            tabla.Load(this.getLector(sql));
            return tabla;
        }



        public long InsertPadre(string skuPadre, string skuHijo)
        {
            InsertSQL = "INSERT INTO sku_parents (nid_parent,	nid_sku) " +
                                "VALUES ( '" + skuPadre + "', '" + skuHijo + "')";
            return this.insert();
        }

        public long ActualizaPadre(string skuPadre)
        {
            InsertSQL = "  update sku_arrivals SET bexists = 0 " +
                                  " where nid_sku = '" + skuPadre + "' ";
            return this.insert();
        }



        public DataTable infoSKU(string nid_sku)
        {
            string sql = "";
            DataTable tabla = new DataTable();

            // nid_arrive	clocation	nid_sku_type	nid_sku_state	nid_sku_level	bexists	
            //IdCliente	nid_user_mat	NombreCliente	cname_person	cname_sku_type	cname_sku_state	 clevel_name

            sql = "SELECT sku.nid_arrive, sku.clocation,  sku.nid_sku_type,  sku.nid_sku_state,  sku.nid_sku_level, " +
                  "sku.bexists, sku.IdCliente, sku.nid_user_mat, cli.NombreCliente, per.cname_person, typ.cname_sku_type,sta.cname_sku_state, lev.clevel_name " +
                 "FROM dbo.sku_arrivals sku left JOIN dbo.meta_filials cli ON sku.IdCliente = cli.IdCliente " +
                "left JOIN dbo.sku_types typ ON sku.nid_sku_type = typ.nid_sku_type left JOIN dbo.sku_state sta " +
               "ON sku.nid_sku_state = sta.nid_sku_state left JOIN dbo.users ON sku.nid_user_mat = USERs.nid_user " +
               "LEFT JOIN dbo.persons per ON users.nid_user = per.nid_person left JOIN dbo.sku_levels lev ON sku.nid_sku_level = lev.nid_sku_level " +
                  "WHERE sku.nid_sku = '" + nid_sku + "' ";

            tabla.Load(this.getLector(sql));
            return tabla;
        }

        public DataTable infoSKU2(string nid_sku)
        {
            string sql = "";
            DataTable tabla = new DataTable();

            // si fecha completado es = null guarda un 1900-01-01 00:00:00.000
            sql = " SELECT     CA.ddate_arrive , " +
                            " isnull (D.dcreation,'') as ddate_completed, " + //abra que cambiar para que muestre el completado de verdad y no el de creacion
                            " isnull(CA.cbox_number,'')as cbox_number , " +
                            " isnull(cd.cve_transp,'')as cve_transp , " +
                            " SA.nid_sku, SA.dfecha_sku " +
                " FROM sku_arrivals AS SA INNER JOIN " +
                            " carriers_arrivals AS CA ON CA.nid_arrive = SA.nid_arrive INNER JOIN " +
                            " sku_types AS ST ON ST.nid_sku_type = SA.nid_sku_type INNER JOIN " +
                            " sku_state AS SS ON SS.nid_sku_state = SA.nid_sku_state INNER JOIN " +
                            " carriers ON CA.cve_transp = carriers.cve_transp LEFT OUTER JOIN " +
                            " meta_filials AS MF ON MF.IdCliente = SA.IdCliente LEFT OUTER JOIN " +
                            " users AS U ON U.nid_user = SA.nid_user_mat LEFT OUTER JOIN " +
                            " persons AS P ON P.nid_person = U.nid_person LEFT OUTER JOIN " +
                            " deploys_detail_skus AS DD ON DD.nid_sku = SA.nid_sku LEFT OUTER JOIN " +
                            " deploys AS D ON D.nid_deploy = DD.nid_deploy " +
                            " Left outer join carriers_deploys as cd on cd.nid_deploy = d.nid_deploy " +
            "where sa.nid_sku =  '" + nid_sku + "' ";

            tabla.Load(this.getLector(sql));
            return tabla;
        }

        public DataTable infoSKUCarrier(string nid_sku)
        {
            string sql = "";
            DataTable tabla = new DataTable();

                       sql ="SELECT     sku_arrivals.dfecha_sku, carriers.nombre " + 
                    "FROM sku_arrivals INNER JOIN " + 
                    " carriers_arrivals ON sku_arrivals.nid_arrive = carriers_arrivals.nid_arrive INNER JOIN " + 
                    " carriers ON carriers_arrivals.cve_transp = carriers.cve_transp " +
                    " WHERE dbo.sku_arrivals.nid_sku =  '" + nid_sku + "' ";


            tabla.Load(this.getLector(sql));
            return tabla;
        }

        public DataTable ObtenerBultosPL(string nid_opl_in) //Obtiene los bultos asociados aun packing list
        {
            string sql = "";
            DataTable tabla = new DataTable();

            sql = string.Format(
                                "SELECT " +    
	                                "SA.nid_arrive,  " +
	                                "SA.nid_sku,  " +
	                                "SA.clocation,  " +
	                                "SA.nid_sku_type,  " +
	                                "SA.nid_sku_state,  " +
	                                "SA.Checked_MT,  " +
	                                "SA.nid_sku_level,  " +
	                                "SA.bloaded,  " +
	                                "SA.bexists,  " +
	                                "SA.bChecked,  " +
                                    "SA.IdCliente,  " +
	                                "SA.nid_user_mat,  " +
	                                "SA.fecha_entrega_mat, " + 
	                                "SA.dfecha_sku  " +
                                "FROM          " +
	                                "packing_list_breakdown AS PLB INNER JOIN " +
                                    "origin_packing_list AS OPL ON PLB.nid_opl = OPL.nid_opl INNER JOIN " +
                                    "sku_arrivals AS SA ON SA.nid_sku = PLB.nid_sku " +
                                "WHERE      " +
                                    "(OPL.nid_opl_in = '{0}') AND  " +
	                                "(SA.bexists = 1)",  nid_opl_in);

            tabla.Load(this.getLector(sql));

            return tabla;
        }

        public DataTable ObtBultosLlegada(int nid_arrive)
        {
            string sql = "";
            DataTable tabla = new DataTable();

            sql = "SELECT " +
                        "SA.nid_sku,  " +
                        "SA.nid_sku_type,  " +
                        "ST.cname_sku_type, " +
                        "SA.clocation,  " +
                        "SA.nid_sku_state,  " +
                        "SS.cname_sku_state  " +
                    "FROM          " +
                        "sku_arrivals SA INNER JOIN dbo.sku_state SS ON SA.nid_sku_state = SS.nid_sku_state " +
                        "INNER JOIN dbo.sku_types ST ON SA.nid_sku_type = ST.nid_sku_type " +
                    "WHERE      " +
                        "SA.nid_arrive = " + nid_arrive;

            //sql = "SELECT " +
            //         "SA.nid_arrive,  " +
            //         "SA.nid_sku,  " +
            //         "SA.clocation,  " +
            //         "SA.nid_sku_type,  " +
            //         "SA.nid_sku_state,  " +
            //         "SA.Checked_MT,  " +
            //         "SA.nid_sku_level,  " +
            //         "SA.bloaded,  " +
            //         "SA.bexists,  " +
            //         "SA.bChecked,  " +
            //         "SA.IdCliente,  " +
            //         "SA.nid_user_mat,  " +
            //         "SA.fecha_entrega_mat, " +
            //         "SA.dfecha_sku,  " +
            //         "SS.cname_sku_state,  " +
            //         "ST.cname_sku_type " +
            //     "FROM          " +
            //         "sku_arrivals SA INNER JOIN dbo.sku_state SS ON SA.nid_sku_state = SS.nid_sku_state " +
            //         "INNER JOIN dbo.sku_types ST ON SA.nid_sku_type = ST.nid_sku_type " +
            //     "WHERE      " +
            //         "SA.nid_arrive = " + nid_arrive;

            tabla.Load(this.getLector(sql));

            return tabla;
        }

        public bool CambiaClienteByPL(int idCliente, string nid_opl_in, int nid_user_mat)
        {/*Busca todos los bultos que se encuentran asociados a un PL y si en la tabla users_clients esta el cliente asociado a ese materialista
            actualisa el cliente y usuaro de los bultos asociados al PL*/

            bool resultado = false;
            string sql = string.Format("DECLARE @pl VARCHAR(20) SET @pl = '{0}' " +
                                        "DECLARE @cliente INT SET @cliente = {1} " +
                                        "DECLARE @mat INT SET @mat = {2} " +

                                        "DECLARE @resultado BIT SET @resultado = 0 " +

                            "IF EXISTS( SELECT nid_filial FROM dbo.users_clients WHERE nid_filial = @cliente AND nid_user = @mat) " +
                                    "BEGIN " +
                                                    "UPDATE dbo.sku_arrivals  SET IdCliente = @cliente, nid_user_mat = @mat " +
                                                    "WHERE nid_sku IN (SELECT nid_sku FROM dbo.packing_list_breakdown WHERE nid_opl = (SELECT nid_opl  FROM dbo.origin_packing_list WHERE nid_opl_in = @pl)) " +
                                                    "SET @resultado = 1 " +
                                    "END " +
                            "SELECT @resultado AS resultado ", nid_opl_in, idCliente, nid_user_mat);
            SqlDataReader lector = this.getLector(sql);

            if (lector.Read())
                resultado = Convert.ToBoolean(lector["resultado"]);

                lector.Close();
                return resultado;
        }


        public bool ClienteAdecuadoUser(int idCliente,  int nid_user_mat)
        { //evalua si el USUARIO puede maniular un producto de cierto CLIENTE
            bool resultado = false;

            string sql = string.Format("DECLARE @cliente INT SET @cliente = {0} "+
                                                    "DECLARE @mat INT SET @mat = {1}   "+

                                                    "DECLARE @resultado BIT SET @resultado = 0  "+ 

                                                    "IF EXISTS( SELECT nid_filial FROM dbo.users_clients WHERE nid_filial = @cliente AND nid_user = @mat)   "+
                                                            "BEGIN   "+
                                                                    "SET @resultado = 1   "+
                                                            "END   " +
                                                    "SELECT @resultado AS resultado ", idCliente, nid_user_mat);

            SqlDataReader lector = this.getLector(sql);

            if (lector.Read())
                resultado = Convert.ToBoolean(lector["resultado"]);

            lector.Close();
            return resultado;
        }


        public int[] ObtDatosConf(string nid_sku) // obtiene nid: sku, arrive, shipping y despacho todo en una lectura para ahorrar tiempo
        {
            int[] arreglo = new int[4];
            string sql = string.Format("SELECT "+
                                                            "SA.IdCliente, "+
                                                            "SA.nid_arrive, "+
                                                            "ISNULL (DDS.nid_deploy,0)AS nid_deploy,  "+
                                                            "ISNULL(SADS.nid_arrive,0) AS nid_shipping "+
                                                     "FROM "+
                                                              "dbo.sku_arrivals SA "+
                                                            "LEFT JOIN dbo.deploys_detail_skus  DDS ON SA.nid_sku = DDS.nid_sku "+
                                                            "LEFT JOIN dbo.shipping_arrivals_detail_skus SADS ON SA.nid_sku = SADS.nid_sku 	  "+
                                                    "WHERE SA.nid_sku = '{0}' ", nid_sku);
            SqlDataReader lector = getLector(sql);
            if (lector.Read())
            {
                arreglo[0] = Convert.ToInt32(lector["IdCliente"]);
                arreglo[1] = Convert.ToInt32(lector["nid_arrive"]);
                arreglo[2] = Convert.ToInt32(lector["nid_deploy"]);
                arreglo[3] = Convert.ToInt32(lector["nid_shipping"]);
            }

            lector.Close();
            return arreglo;
        }

#region DuplicarEtiqueta

        public void BorrarColaImpresion(string impresora)
        {
            InsertSQL = "DELETE FROM cola_impresion_etq_paqueteria " +
                        "WHERE (impresora = '" + impresora + "') OR (impresora = '')";

            this.insert();
        }

        public void AgregarColaImpresion(string nombre_reporte, string codigo_barras, string texto, string impresora)
        {
            InsertSQL = "INSERT INTO [dbo].[cola_impresion_etq_paqueteria] ([nombre_reporte], [codigo_barras], [texto], [impresora]) " +
                "VALUES ('" + nombre_reporte + "', '" +  codigo_barras + "', '" + texto + "', '" + impresora + "')";

            this.insert();
        }

        public void QuitarColaImpresion(string CodigoBarras)
        {
            InsertSQL = "DELETE FROM cola_impresion_etq_paqueteria " +
                        "WHERE (codigo_barras = '" + CodigoBarras + "')";

            this.insert();
 
        }

        public DataTable Impresoras()
        {
            string sql = "";
            DataTable tabla = new DataTable();

            sql = "SELECT ImpresoraID, NombreImpresora FROM Impresoras";

            tabla.Load(this.getLector(sql));
            return tabla;
        }
       
#endregion DuplicarEtiqueta

        public void Borrarbulto(string nid_sku)
        {
            this.InsertSQL = "Delete from sku_arrivals where nid_sku = '" + nid_sku + "'";

            this.insert();
        }
        //___________________________

        public int MatSku(string nid_sku)
        {
            int resultado;
          string  sql = string.Format("select isnull(nid_user_mat,0)as nid_user_mat  " +
                    "from sku_arrivals  " +
                    "where nid_sku = '{0}'", nid_sku);
            SqlDataReader Llegada = this.getLector(sql);
            if (Llegada.Read())
            {
                resultado = Convert.ToInt32(Llegada["nid_user_mat"]);
                Llegada.Close();
                return resultado;
            }
            else
            {
                Llegada.Close();
                return 0;
            }
        }


    


        /////////////

















    }
}
