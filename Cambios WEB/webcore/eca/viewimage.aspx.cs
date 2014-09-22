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
using System.IO;

public partial class ECA_viewimage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //string FilePath = Directory.GetParent(Server.MapPath(".")) + "\\Archivos\\PDF\\" + Request.QueryString["nid_file"].ToString() + ".pdf";
        string FilePath = Server.MapPath("..").Replace("\\WEBCORE", "") + "\\Archivos\\PDF\\" + Request.QueryString["nid_file"].ToString();
               
        if (File.Exists(FilePath))
        {
            Response.AddHeader("Content-type", "image/jpeg");
            if (Convert.ToBoolean(Request.QueryString["inline"]))
                Response.AddHeader("Content-Disposition", "inline;");
            
            Response.Flush();
            Response.WriteFile(FilePath);
        }
        else
        {
            Response.Write("No se pudo encontrar el archivo o no ha sido cargado aun!");
        }
    }
}
