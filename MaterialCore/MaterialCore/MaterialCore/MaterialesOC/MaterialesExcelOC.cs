using System;
using System.Collections.Generic;
using System.Text;

namespace MaterialCore.MaterialesOC
{
    class MaterialesExcelOC
    {
        private Int32 _id;

        public Int32 Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private Int32 _clienteId;

        public Int32 ClienteId
        {
            get { return _clienteId; }
            set { _clienteId = value; }
        }
        private Int32 _renglonId;

        public Int32 RenglonId
        {
            get { return _renglonId; }
            set { _renglonId = value; }
        }
        private string _numeroParte;


        public string NumeroParte
        {
            get { return _numeroParte; }
            set { _numeroParte = value; }
        }
        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        private Decimal _cantidad;

        public Decimal Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
        private Decimal _pqOrd;

        public Decimal PqOrd
        {
            get { return _pqOrd; }
            set { _pqOrd = value; }
        }
        private Decimal _precio;

        public Decimal Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        private string _proveedor;

        public string Proveedor
        {
            get { return _proveedor; }
            set { _proveedor = value; }
        }
        private string _descripcion_P;

        public string Descripcion_P
        {
            get { return _descripcion_P; }
            set { _descripcion_P = value; }
        }
        private string unidadMedida;

        public string UnidadMedida
        {
            get { return unidadMedida; }
            set { unidadMedida = value; }
        }
        private string _facturaProveedor;

        public string FacturaProveedor
        {
            get { return _facturaProveedor; }
            set { _facturaProveedor = value; }
        }
        private string _pais;

        public string Pais
        {
            get { return _pais; }
            set { _pais = value; }
        }
        private string _planta;

        public string Planta
        {
            get { return _planta; }
            set { _planta = value; }
        }
        private string _moneda;

        public string Moneda
        {
            get { return _moneda; }
            set { _moneda = value; }
        }

        private string _ProgramaId;

        public string ProgramaId
        {
            get { return _ProgramaId; }
            set { _ProgramaId = value; }
        }
        private string _drawingId;

        public string DrawingId
        {
            get { return _drawingId; }
            set { _drawingId = value; }
        }
    }
}
