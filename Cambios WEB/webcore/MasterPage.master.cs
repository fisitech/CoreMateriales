using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Contenido.Controls[1].Controls.Clear();
        localhost.UsersWS user = new localhost.UsersWS();
        if (user.GetAcces(Session.SessionID) > 0 && Session["SessionID"] != null)
        {
            LoadMain();
            lblUsuario.Text = Convert.ToString(((DataTable)user.GetUsersById(user.GetUsersIdBySessionID(Session.SessionID))).Rows[0][6]);
            user.Dispose();
        }
        else
        {
            if (!Request.Url.PathAndQuery.Contains("Carrier"))
            {
                user.Logout(Session.SessionID);
                LoadLogin();
            }
            else
            {
                Control obj;
                obj = LoadControl("~/Login.ascx");
                this.Contenido.Controls[1].Controls.Add(obj);
                this.Contenido.Controls[1].Controls.Clear();
            }
            user.Dispose();
        }
        

        localhost.GeneralFrame GF = new localhost.GeneralFrame();
        lblVersion.Text = Convert.ToString(((DataTable)GF.getVersion("WebCore")).Rows[0][2]); ;
    }

    private void LoadLogin()
    {
        Control obj;
        obj = LoadControl("~/Login.ascx");
        this.Contenido.Controls[1].Controls.Add(obj);
    }

    private void LoadMain()
    {
        Control menu;
        Control obj;
        menu = LoadControl("~/Menu.ascx");
        this.Menu.Controls.Add(menu);

        switch (Request.QueryString["mod"])
        {
            case "cat":
                switch (Request.QueryString["sub"])
                {
                    case "bill":
                        obj = LoadControl("~/Catalogs/bill_types.ascx");
                        this.Contenido.Controls[1].Controls.Add(obj);
                        break;
                    case "carrier":
                        obj = LoadControl("~/Catalogs/carriers.ascx");
                        this.Contenido.Controls[1].Controls.Add(obj);
                        break;
                    case "move":
                        obj = LoadControl("~/Catalogs/move_types.ascx");
                        this.Contenido.Controls[1].Controls.Add(obj);
                        break;
                    case "dock":
                        obj = LoadControl("~/Catalogs/docks.ascx");
                        this.Contenido.Controls[1].Controls.Add(obj);
                        break;
                    case "trantype":
                        obj = LoadControl("~/Catalogs/transports_types.ascx");
                        this.Contenido.Controls[1].Controls.Add(obj);
                        break;
                }                       
                break;
            case "usu":
                obj = LoadControl("~/Users/Users.ascx");
                this.Contenido.Controls[1].Controls.Add(obj);
                break;
            case "pack":
                switch (Request.QueryString["sub"])
                {
                    case "dis":
                        obj = LoadControl("~/ECA/OPL_in.ascx");
                        this.Contenido.Controls[1].Controls.Add(obj);
                        break;
                }
                break;
            case "des":
                switch (Request.QueryString["sub"])
                {
                    case "nvo":
                        obj = LoadControl("~/Despachos/CrearDespacho.ascx");
                        this.Contenido.Controls[1].Controls.Add(obj);
                        break;

                    case "brr":
                        obj = LoadControl("~/Despachos/BorrarDespacho.ascx");
                        this.Contenido.Controls[1].Controls.Add(obj);
                        break;
                }
                break;
            case "gb":
                switch (Request.QueryString["sub"])
                {
                    case "ar":
                        obj = LoadControl("~/GB/ArrivesCP.ascx");
                        this.Contenido.Controls[1].Controls.Add(obj);
                        break;
                    case "trwt":
                        obj = LoadControl("~/GB/truckwaiting.ascx");
                        this.Contenido.Controls[1].Controls.Add(obj);
                        break;
                    case "lges":
                        obj = LoadControl("~/GB/ArriveGeneralList.ascx");
                        this.Contenido.Controls[1].Controls.Add(obj);
                        break;
                }
                break;
            case "pick":
                 switch (Request.QueryString["sub"])
                {
                     case "OC":
                         obj = LoadControl("~/OCOracle/OCOracle.ascx");
                         this.Contenido.Controls[1].Controls.Add(obj);
                         break; 
                 }
                break;
            case "clie":
                obj = LoadControl("~/Catalogs/Customer.ascx");
                this.Contenido.Controls[1].Controls.Add(obj);
                break;

            case "per":
                switch (Request.QueryString["sub"])
                {
                    case "reg":
                        obj = LoadControl("~/Catalogs/Perfiles_Config.ascx");
                        this.Contenido.Controls[1].Controls.Add(obj);
                        break;
                }
                break;
            case "consul":
                switch (Request.QueryString["sub"])
                {
                    case "paqueteria":
                        obj = LoadControl("~/CBB/paqueteria.ascx");
                        this.Contenido.Controls[1].Controls.Add(obj);
                        break;

                        //labinal
                    case "paqueteriaMateriales":
                        obj = LoadControl("~/CBB/paqueteriaMateriales.ascx");
                        this.Contenido.Controls[1].Controls.Add(obj);
                        break;

                    case "paqueteriaINBOUND":
                        obj = LoadControl("~/CBB/paqueteriaINBOUND.ascx");
                        this.Contenido.Controls[1].Controls.Add(obj);
                        break;

                    case "Incidencias":
                        obj = LoadControl("~/CBB/Incidencias.ascx");
                        this.Contenido.Controls[1].Controls.Add(obj);
                        break;

                    case "camion":
                        obj = LoadControl("~/CBB/camion.ascx"); //Obtiene los bultos en bodega
                        this.Contenido.Controls[1].Controls.Add(obj);
                        break;
                    case "newsku":
                        obj = LoadControl("~/CBB/newsku.ascx");
                        this.Contenido.Controls[1].Controls.Add(obj);
                        break;
                    case "trkshp":
                        obj = LoadControl("~/Parcel/TrackShipments.ascx");
                        this.Contenido.Controls[1].Controls.Add(obj);
                        break;
                }
                break;
            case "rep":                      
                obj = LoadControl("~/Reportes/Reportes.ascx");
                this.Contenido.Controls[1].Controls.Add(obj);
                break;


            case "sku":
                switch (Request.QueryString["sub"])
                {
                    case "edt":
                        obj = LoadControl("~/SKU/Sku_Cuts.ascx");
                        this.Contenido.Controls[1].Controls.Add(obj);
                        break;
                }
                break;


        }      
    }
}
