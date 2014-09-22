using System;
using System.Collections.Generic;
using System.Text;

namespace MaterialCore.Detenidos
{
    class Detenidos
    {

        public string _Guia;
        public bool _SinEmbiar;
        public bool _ConTarima;


        public bool SinEmbiarb
        {
            get { return _SinEmbiar;}
        }
        public bool ConTarimab
        {
            get { return _ConTarima; }
        }

              

        public Detenidos(string guia)
        {
            _Guia = guia;
            _SinEmbiar = SinTarima();
            _ConTarima = ConTarima();

        }

        bool ConTarima()
        {
            bool resultado = true;
            DataSets.EmbarquesTableAdapters.DetenerPartidaConTarimaTableAdapter ta = new MaterialCore.DataSets.EmbarquesTableAdapters.DetenerPartidaConTarimaTableAdapter();
            DataSets.Embarques.DetenerPartidaConTarimaDataTable tabla = new MaterialCore.DataSets.Embarques.DetenerPartidaConTarimaDataTable();
            ta.FillByGuia(tabla, _Guia);

            if (tabla.Rows.Count > 0)
            {
                resultado = false;
            }
            return resultado;
        }

        bool SinTarima()
        {
            bool resultado = true;

            DataSets.EmbarquesTableAdapters.DetenerPartidaSinEnviarTableAdapter ta = new MaterialCore.DataSets.EmbarquesTableAdapters.DetenerPartidaSinEnviarTableAdapter();
            DataSets.Embarques.DetenerPartidaSinEnviarDataTable tabla = new MaterialCore.DataSets.Embarques.DetenerPartidaSinEnviarDataTable();

            ta.FillByGuia(tabla, _Guia);

            if (tabla.Rows.Count > 0)
            {
                resultado = false;
            }
            return resultado;
        }





        














    }
}
