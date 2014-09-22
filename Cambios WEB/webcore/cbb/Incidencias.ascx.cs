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

public partial class CBB_Incidencias : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Title = "::AI:: ..:: Incidencias/ Recibido por Paqueteria INBOUND::..";
        ((Label)Parent.Parent.Parent.FindControl("lblNivel1")).Text = "Recibido por Paqueteria";
        this.LimpiarFiltros();
    }

    protected void btnfiltrofecha_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.Text == "Labinal")
        {
            odsMateriales.DataBind();
        }
        else
        {

     
        }

    }
    protected void ObjectDataSource1_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        e.InputParameters[0] = Session["SessionID"];
    }
    protected void DropDownList1_DataBound(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.Text == "Labinal")
        {
    
            dgvMateriales.Visible = true;
        

            odsMateriales.DataBind();

        
        }

    }

    private void LimpiarFiltros()
    {
        txtfecha1.Text = Convert.ToString(DateTime.Today.AddDays(-7)).Substring(0, 11).Trim();
        txtfecha2.Text = Convert.ToString(DateTime.Today).Substring(0, 11).Trim();
        TextBox1.Text = "";
     
    }
    protected void lkbLimpiar_Click(object sender, EventArgs e)
    {
        this.LimpiarFiltros();
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.Text == "Labinal")
        {
       
            dgvMateriales.Visible = true;


        }
        else
        {
       
            dgvMateriales.Visible = false;

        
      
        }
    }



}
