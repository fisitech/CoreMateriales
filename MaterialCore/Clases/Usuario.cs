using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MaterialCore.Clases
{
    public class Usuario : Conexion
    {
        private string _session = "";

        protected int _nid_person = 0;
        protected string _cname_person = "";
        protected int _nid_user = 0;
        protected string _clogin = "";
        protected string _cemail = "";
        protected Int64 _naccess = 0;
        protected string _ccodigo_barras_usuario = "";
        protected bool _autentificado = false;

        public Usuario()
        {           
                _session = "";
                _nid_person = 0;
                _cname_person = "";
                _nid_user = 0;
                _clogin = "";
                _cemail = "";
                _naccess = 0;
                _ccodigo_barras_usuario = "";
                _autentificado = false;
        }

        public Usuario(string usuario, string clave)
        {
            SqlDataReader lectorUsuario;

            string sql = "SELECT " +
                         "   persons.nid_person, " +
                         "   persons.cname_person, " +
                         "   users.nid_user, " +
                         "   users.clogin, " +
                         "   users.cemail, " +
                         "   users.naccess, " +
                         "   MT_codes.ccodigo_barras " +
                         "FROM " +
                         "   persons INNER JOIN " +
                         "   users ON persons.nid_person = users.nid_person LEFT JOIN " +
                         "   MT_codes ON users.nid_user = MT_codes.nid_user and MT_codes.bactivo = 1 " +
                         "WHERE " +
                         "   (users.clogin = '" + usuario + "') AND " +
                         "   (CONVERT(VARCHAR(300), DECRYPTBYPASSPHRASE('$$AIIG9770$$', users.cpassword)) = '" + clave + "') AND " +
                         "   (users.bactive = 1)";

            lectorUsuario = getLector(sql);

            if (lectorUsuario.Read())
            {
                _session = DateTime.Now.Ticks.ToString();
                _nid_person = Convert.ToInt32(lectorUsuario["nid_person"]);
                _cname_person = Convert.ToString(lectorUsuario["cname_person"]);
                _nid_user = Convert.ToInt32(lectorUsuario["nid_user"]);
                _clogin = Convert.ToString(lectorUsuario["clogin"]);
                _cemail = Convert.ToString(lectorUsuario["cemail"]);
                _naccess = Convert.ToInt64(lectorUsuario["naccess"]);
                _ccodigo_barras_usuario = Convert.ToString(lectorUsuario["ccodigo_barras"]);
                _autentificado = true;
            }
            else
            {
                _autentificado = false;
            }
            lectorUsuario.Close();
        }

        public DataTable Roles(int nid_user)
        {
            string sql;
            DataTable tabla = new DataTable();
            sql = "sELECT users_types.cname_user_type  FROM users_roles  " +
                    "INNER JOIN users_types ON users_roles.nid_user_type = users_types.nid_user_type   " +
                    "WHERE (users_roles.nid_user = '" + nid_user + "') order by cname_user_type   ";
            tabla.Load(this.getLector(sql));
            return tabla;
        }

        #region set and gets

        public string session
        {
            get { return _session; }
            set { _session = value; }
        }

        public int nid_person
        {
            get { return _nid_person; }
            set { _nid_person = value; }
        }

        public string cname_person
        {
            get { return _cname_person; }
            set { _cname_person = value; }
        }

        public int nid_user
        {
            get { return _nid_user; }
            set { _nid_user = value; }
        }

        public string clogin
        {
            get { return _clogin; }
            set { _clogin = value; }
        }

        public string cemail
        {
            get { return _cemail; }
            set { _cemail = value; }
        }

        public Int64 naccess
        {
            get { return _naccess; }
            set { _naccess = value; }
        }

        public string ccodigo_barras_usuario
        {
            get { return _ccodigo_barras_usuario; }
            set { _ccodigo_barras_usuario = value; }
        }

        public bool autentificado
        {
            get { return _autentificado; }
            set { _autentificado = value; }
        }
        #endregion

    }
}
