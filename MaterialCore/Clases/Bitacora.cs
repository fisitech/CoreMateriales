using System;
using System.Collections.Generic;
using System.Text;

namespace MaterialCore.Clases
{
    class Bitacora
    {
        DataSets.BitacoraTableAdapters.MaterialesBitacoraTableAdapter _adaptador = new MaterialCore.DataSets.BitacoraTableAdapters.MaterialesBitacoraTableAdapter();
 
        /*TIPOS*/
        string Meq = "MEQ";
        string Mat = "MAT";
        string Mix = "MIX"; 
        
        
        /*MOVIMIENTOS*/
        string Inserto = "INSERTO";
        string Actualizo = "ACTUALIZO";
        string Borro = "BORRO";
        string CreoArchivo = "CREOARCHIVO";
        string Importo = "IMPORTO";
        string Digitalizo = "DIGITALIZO";
        string Desmarco = "DESMARCO";
        string Logueo = "LOGUEO";
        string CreaDespacho = "CREODESPACHO";
        string CerroSistema = "CERROSISTEMA";
        string Clono = "CLONO";

        int Usuario;

        public Bitacora()
        {
            Usuario = Clases.Logueado.nid_usuario;
        }

        /*Materia Prima*/

        public void MatInserto(int IdPartida, int PO, int Linea, string NoGuia)
        {
            _adaptador.InsertQuery(Usuario, Mat, Inserto, IdPartida, PO, Linea, NoGuia, null);
        }

        public void MatCreaDespacho(string Despacho)
        {
            _adaptador.InsertQuery(Usuario, Mat, CreaDespacho, null, null, null, null, Despacho);
        }

        public void MatINBOUNDAutomatico(int IdPartida, int PO, int Linea, string NoGuia)
        {
            _adaptador.InsertQuery(Usuario, Mat, Inserto, IdPartida, PO, Linea, NoGuia, "INBOUND AUTOMATICO");
        }

        public void MatActualizo(int IdPartida, int PO, int Linea, string NoGuia)
        {
            _adaptador.InsertQuery(Usuario, Mat, Actualizo, IdPartida, PO, Linea, NoGuia, null);
        }

        public void MatDesmarco(int IdPartida, int PO, int Linea, string NoGuia)
        {
            _adaptador.InsertQuery(Usuario, Mat, Desmarco, IdPartida, PO, Linea, NoGuia, null);
        }

       public  void MatBorro(int IdPartida, int PO, int Linea, string NoGuia)
        {
            _adaptador.InsertQuery(
                Usuario, Mat, Borro, IdPartida, PO, Linea, NoGuia, null);
        }

 

        public void MatCreoArchivo(string TarimaConsecutivo)
        {
            _adaptador.InsertQuery(
                Usuario, Mat, CreoArchivo, null, null, null, null, TarimaConsecutivo);
        }

        public void MatImporto()
        {
            _adaptador.InsertQuery(
                Usuario, Mat, Importo, null, null, null, null, null);
        }

        /*Maquinaria y Equipo*/

        public void MeqInserto(int IdPartida, int PO, int Linea, string NoGuia, bool hijo)
        {
            if(hijo)
                 _adaptador.InsertQuery(Usuario, Meq, Inserto, IdPartida, PO, Linea, NoGuia, "Hijo");
            else
                 _adaptador.InsertQuery(Usuario, Meq, Inserto, IdPartida, PO, Linea, NoGuia, null);
           
        }
        public void MeqClono(int IdPartida)
        {
               _adaptador.InsertQuery(Usuario, Meq, Clono, IdPartida,null,null,null,null);
        }
        public void MeqActualizo(int IdPartida, int PO, int Linea, string NoGuia)
        {
            _adaptador.InsertQuery(Usuario, Meq, Actualizo, IdPartida, PO, Linea, NoGuia, null);
        }

        public void MeqCreoArchivo(string Consecutivo)
        {
            _adaptador.InsertQuery(
                Usuario, Meq, CreoArchivo, null, null, null, null, Consecutivo);
        }
        public void MeqBorro(int IdPartida, int PO, int Linea, string NoGuia)
        {
            _adaptador.InsertQuery(
                Usuario, Meq, Borro, IdPartida, PO, Linea, NoGuia, null);
        }

        public void MeqImporto()
        {
            _adaptador.InsertQuery(
                Usuario, Meq, Importo, null, null, null, null, null);
        }

        /*MIX*/

        public void MixLogueo()
        {
            try
            {
                _adaptador.InsertQuery(
                    Usuario, Mix, Logueo, null, null, null, null, null);
            }
            catch
            {
            }
        }
        public void MixCerro()
        {
            if (Usuario != 0)
            {
                _adaptador.InsertQuery(
                    Usuario, Mix, CerroSistema, null, null, null, null, null);
            }
        }
        public void MixDigitalizo(string NoGuia, string PL)
        {
            _adaptador.InsertQuery(
                Usuario, Mix, Digitalizo, null, null, null, NoGuia, PL);
        }
   
    }
}
