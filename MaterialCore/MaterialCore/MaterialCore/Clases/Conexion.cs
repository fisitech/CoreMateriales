using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace MaterialCore.Clases
{
    public class Conexion
    {
        public SqlConnection MiConexion;
        public SqlDataReader Lector;
        public SqlCommand ComandoR;
        public SqlCommand ComandoI;
        public SqlCommand ComandoSP;
        public SqlCommand Comando;
        public SqlDataAdapter Adaptador;
        public SqlTransaction transaccion;
        public string _connectionString;

        public Conexion()
        {
            this.ReadConnectionString();
            MiConexion = new SqlConnection(_connectionString);

            try
            {
                MiConexion.Open();

            }
            catch (SqlException) 
           {

               MiConexion.Close();
            }
        }

        public Conexion(bool error)
        {
          this.ReadConnectionString();
            MiConexion = new SqlConnection(_connectionString);
            MiConexion.Close();
        }

        public void FinConexion()
        {
            MiConexion.Close();
            MiConexion.Dispose();
            MiConexion = null;
        }

        public SqlDataReader getLector(string consulta)
        {
            Error_conexion(); //muestra la forma que reconecta a la aplicacion
            ComandoR = new SqlCommand(consulta, MiConexion);
            Lector = ComandoR.ExecuteReader();
            return Lector;
        }

        public SqlDataAdapter getDataAdapter(string consulta)
        {
            Error_conexion(); 
            Adaptador = new SqlDataAdapter(consulta, MiConexion);
            return Adaptador;
        }

        public string InsertSQL
        {
            set
            {
                Error_conexion(); 
                ComandoI = new SqlCommand(value, MiConexion);
            }
        }
        public SqlParameterCollection InsertParametros
        {
            get
            {
                Error_conexion(); 
                return ComandoI.Parameters;
            }
        }
        public long insert()
        {
         //   Error_conexion();  no es nesesario porue en el insertSQL se checa la coneccion
            return ComandoI.ExecuteNonQuery();
        }

        public string StoredProcedureName
        {
            set
            {
                Error_conexion(); 
                ComandoSP = new SqlCommand(value, MiConexion);
                ComandoSP.CommandType = System.Data.CommandType.StoredProcedure;
            }
        }
        public SqlParameterCollection SpParametros
        {
            get
            {
                return ComandoSP.Parameters;
            }
        }
        public Int64 exec()
        {
#if !DEBUG
            if (transaccion != null)
                ComandoSP.Transaction = transaccion;
#endif  
            Int64 test = ComandoSP.ExecuteNonQuery();
            return test;
        }

        public System.Data.DataSet execData()
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            SqlDataAdapter ad = new SqlDataAdapter(ComandoSP);
            ad.Fill(ds);
            return ds;
        }


        public object execSP(string campo)
        {
            if (transaccion != null)
                ComandoSP.Transaction = transaccion;
            ComandoSP.ExecuteNonQuery();
            return ComandoSP.Parameters[campo].Value;
        }

        public void execSP()
        {
            if (transaccion != null)
                ComandoSP.Transaction = transaccion;
            ComandoSP.ExecuteNonQuery();
        }

        public int ExecSQL(string sql)
        {
            Comando = new SqlCommand(sql, MiConexion);
#if !DEBUG
            if (transaccion != null)
                Comando.Transaction = transaccion;
#endif
            int test = Comando.ExecuteNonQuery();
            return test;
        }

        public void BeginTransaction()
        {
            if (MiConexion.State != System.Data.ConnectionState.Open)
            {
                MiConexion = new SqlConnection(_connectionString);
                MiConexion.Open();
            }
            transaccion = MiConexion.BeginTransaction();
        }

        public bool Reconectar()
        {
            bool ok = true;
           if (MiConexion.State != System.Data.ConnectionState.Open)
            {
                try
                {
             //       FinConexion();
               //     MiConexion = new SqlConnection(_connectionString);
                    MiConexion.Open();

                }
                catch (SqlException ex) 
                {
                    ok = false;
                }
            }
           return ok;
        }

        public void CommitTransaction()
        {
            transaccion.Commit();
            transaccion.Dispose();
            transaccion = null;
        }

        public void RollBackTransaction()
        {
            transaccion.Rollback();
            transaccion.Dispose();
            transaccion = null;
        }

        private void ReadConnectionString()
        {
            _connectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();
            //string AppPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
            //string ConfigFile = Path.Combine(AppPath, "Config.xml");
            //XmlDocument oXml = new XmlDocument();
            //oXml.Load(ConfigFile);
            //XmlNodeList oList = oXml.GetElementsByTagName("appSettings");
            //_connectionString = oList.Item(0).ChildNodes[0].ChildNodes[0].Attributes["value"].Value;

        }

        public string ConnectionString
        {
            get
            {
                return _connectionString;
            }
        }

        public void Error_conexion()
        {
            if (MiConexion.State != System.Data.ConnectionState.Open)
            {
                MaterialCore.ErrorConeccion conexion = new ErrorConeccion();
                conexion.ShowDialog();
                MiConexion.Open();
                conexion.Dispose();

            }
        }


    }//---------------------------
}
