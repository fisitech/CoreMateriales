using System;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data.SqlClient;
using System.Data;


/// <summary>
/// Summary description for paqueteria
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class paqueteria : System.Web.Services.WebService
{

    public paqueteria()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public DataTable recibo_por_paqueteria(int ncliente, string date1, string date2, string location, string sku)
    {
        DSPaqueteria.MasterpaqueteriaDataTable master = new DSPaqueteria.MasterpaqueteriaDataTable();
        DSPaqueteriaTableAdapters.MasterpaqueteriaTableAdapter da = new DSPaqueteriaTableAdapters.MasterpaqueteriaTableAdapter();
        da.Fillpaqueteria(master, ncliente, date1, date2, location, sku);
        da.Dispose();
        return master;
    }

    [WebMethod]
    public DataTable recibo_por_paqueteria_materiales(int ncliente, string date1, string date2, string location, string sku, int PO, int Renglon, string NoParte)
    {
        DSPaqueteria.DeliveryFilter_materialesDataTable master = new DSPaqueteria.DeliveryFilter_materialesDataTable();
        DSPaqueteriaTableAdapters.DeliveryFilter_materialesTableAdapter da = new DSPaqueteriaTableAdapters.DeliveryFilter_materialesTableAdapter();
        da.Fill(master, ncliente, date1, date2, sku, PO, Renglon, NoParte);
        da.Dispose();
        return master;
    }

    [WebMethod]
    public DataTable recibo_por_paqueteria_materialesINBOUND( string date1, string date2, string sku)
    {
        DSPaqueteria.GuiasINBOUNDDataTable master = new DSPaqueteria.GuiasINBOUNDDataTable();
        DSPaqueteriaTableAdapters.GuiasINBOUNDTableAdapter da = new DSPaqueteriaTableAdapters.GuiasINBOUNDTableAdapter();
        da.Fill(master,date1, date2, sku);
        da.Dispose();
        return master;
    }

    [WebMethod]
    public DataTable Incidencias()
    {
        DSPaqueteria.IncidenciasDataTable master = new DSPaqueteria.IncidenciasDataTable();
        DSPaqueteriaTableAdapters.IncidenciasTableAdapter da = new DSPaqueteriaTableAdapters.IncidenciasTableAdapter();
        da.Fill(master);
        da.Dispose();
        return master;
    }
    //[WebMethod]
    //public DataTable recibo_por_paqueteria_detalle(int nid_arrive, string nsku, string clocation)
    //{
    //    DSPaqueteria.detalleDataTable detalle = new DSPaqueteria.detalleDataTable();
    //    DSPaqueteriaTableAdapters.detalleTableAdapter da = new DSPaqueteriaTableAdapters.detalleTableAdapter();
    //    if (nsku == "")
    //        nsku = null;
    //    if (clocation == "")
    //        clocation = null;
    //    da.FillDetail(detalle, nid_arrive, nsku,clocation);
    //    da.Dispose();
    //    return detalle;
    //}
    
    //[WebMethod]
    //public DataTable bultos_pendientes()
    //{
    //    DSPaqueteria.delivery_PQ_MTDataTable detalle = new DSPaqueteria.delivery_PQ_MTDataTable();
    //    DSPaqueteriaTableAdapters.delivery_PQ_MTTableAdapter da = new DSPaqueteriaTableAdapters.delivery_PQ_MTTableAdapter();
    //    da.FillBultoPendiente(detalle);
    //    da.Dispose();
    //    return detalle;
    //}

    //[WebMethod]
    //public bool update_bultos_pendientes(int cliente, int delivery)
    //{
    //    try
    //    {
    //        DSPaqueteria.delivery_PQ_MTDataTable detalle = new DSPaqueteria.delivery_PQ_MTDataTable();
    //        DSPaqueteriaTableAdapters.delivery_PQ_MTTableAdapter da = new DSPaqueteriaTableAdapters.delivery_PQ_MTTableAdapter();
    //        da.UpdateBultoPendiente(cliente, delivery);
    //        da.Dispose();
    //        return true;
    //    }
    //    catch { return false; }
    //}

    //[WebMethod]
    //public DataTable Maestro_bultos_pendientes(String fecha)
    //{
    //    DSPaqueteria.MaestroBultoPendienteDataTable detalle = new DSPaqueteria.MaestroBultoPendienteDataTable();
    //    DSPaqueteriaTableAdapters.MaestroBultoPendienteTableAdapter da = new DSPaqueteriaTableAdapters.MaestroBultoPendienteTableAdapter();
    //    if (fecha == "")
    //        fecha = null;
    //    da.FillMaestroBultoPendiente(detalle, fecha);
    //    da.Dispose();
    //    return detalle;
    //}

    //    [WebMethod]
    //public DataTable Detalle_bultos_pendientes (int delivery, string sku)
    //{
    //    DSPaqueteria.DetalleBultoPendieteDataTable detalle = new DSPaqueteria.DetalleBultoPendieteDataTable();
    //    DSPaqueteriaTableAdapters.DetalleBultoPendieteTableAdapter da = new DSPaqueteriaTableAdapters.DetalleBultoPendieteTableAdapter();
    //    if (sku == "")
    //        sku = null;
    //    da.FillDetalleBultoPendiente(detalle, delivery, sku);
    //    da.Dispose();
    //    return detalle;
    //    }

    //[WebMethod]
    //public DataTable sp_sku_paqueteria(int operacion, string clocation, int nid_sku_type, int peso,
    //                                   int nid_sku_level, int nid_sku_state,int idCliente,
    //                                    int id_arrive, string nid_sku)
    //{
    //    DataTable Tabla = new DataTable();

    //    SqlConnection sqlCon = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["coredbConnectionString"].ConnectionString);
    //    string sql = "sp_SKU_Paqueteria";
    //    sqlCon.Open();

    //    SqlCommand sqlCom = new SqlCommand(sql, sqlCon);
    //    sqlCom.CommandType = CommandType.StoredProcedure;

    //    SqlParameter sqlPar = new SqlParameter("@operacion", SqlDbType.Int);
    //    sqlPar.Value = operacion;
    //    sqlCom.Parameters.Add(sqlPar);

    //    sqlPar = new SqlParameter("@clocation", SqlDbType.VarChar);
    //    sqlPar.Value = clocation;
    //    sqlCom.Parameters.Add(sqlPar);

    //    sqlPar = new SqlParameter("@nid_sku_type", SqlDbType.Int);
    //    sqlPar.Value = nid_sku_type;
    //    sqlCom.Parameters.Add(sqlPar);

    //    sqlPar = new SqlParameter("@peso", SqlDbType.Int);
    //    sqlPar.Value = peso;
    //    sqlCom.Parameters.Add(sqlPar);

    //    sqlPar = new SqlParameter("@nid_sku_level", SqlDbType.Int);
    //    sqlPar.Value = nid_sku_level;
    //    sqlCom.Parameters.Add(sqlPar);


    //    sqlPar = new SqlParameter("@nid_sku_state", SqlDbType.Int);
    //    sqlPar.Value = nid_sku_state;
    //    sqlCom.Parameters.Add(sqlPar);

    //    sqlPar = new SqlParameter("@idCliente", SqlDbType.Int);
    //    sqlPar.Value = idCliente;
    //    sqlCom.Parameters.Add(sqlPar);

    //    sqlPar = new SqlParameter("@id_arrive", SqlDbType.Int);
    //    sqlPar.Value = id_arrive;
    //    sqlCom.Parameters.Add(sqlPar);

    //    sqlPar = new SqlParameter("@nid_sku", SqlDbType.VarChar);
    //    sqlPar.Value = nid_sku;
    //    sqlCom.Parameters.Add(sqlPar);

    //    SqlDataAdapter sqlAdap = new SqlDataAdapter(sqlCom);
    //    sqlAdap.Fill(Tabla);

    //    return Tabla;
    //}

    [WebMethod]
    public DataTable GetPrintDuplicateTag()
    {
        DSPaqueteria.cola_impresion_etq_paqueteriaDataTable detalle = new DSPaqueteria.cola_impresion_etq_paqueteriaDataTable();
        DSPaqueteriaTableAdapters.cola_impresion_etq_paqueteriaTableAdapter da = new DSPaqueteriaTableAdapters.cola_impresion_etq_paqueteriaTableAdapter();

        da.Fill(detalle);
        da.Dispose();
        return detalle;
    }

    [WebMethod]
    public bool InsertQueuePrintDuplicateTag(string nombre_reporte, string codigo_barras, string texto, string impresiora)
    {
        DSPaqueteriaTableAdapters.cola_impresion_etq_paqueteriaTableAdapter da = new DSPaqueteriaTableAdapters.cola_impresion_etq_paqueteriaTableAdapter();
        da.Insert(nombre_reporte, codigo_barras, texto, impresiora);
        da.Dispose();

        return true;        
    }

    [WebMethod]
    public bool RemoveQueuePrintDuplicateTag(string codigo_barras)
    {
        DSPaqueteriaTableAdapters.cola_impresion_etq_paqueteriaTableAdapter da = new DSPaqueteriaTableAdapters.cola_impresion_etq_paqueteriaTableAdapter();
        da.Delete(codigo_barras);
        da.Dispose();

        return true;
    }

    [WebMethod]
    public bool RemoveQueuePrintByPrinter(string impresora)
    {
        DSPaqueteriaTableAdapters.cola_impresion_etq_paqueteriaTableAdapter da = new DSPaqueteriaTableAdapters.cola_impresion_etq_paqueteriaTableAdapter();
        da.DeleteQueueByPrinter(impresora);
        da.Dispose();

        return true;
    }


}

