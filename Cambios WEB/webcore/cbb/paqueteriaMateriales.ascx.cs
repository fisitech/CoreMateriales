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

public partial class CBB_paqueteriaMateriales : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Title = "::AI:: ..:: Consulta de Bienes en Bodega  / Recibido por Paqueteria ::..";
        ((Label)Parent.Parent.Parent.FindControl("lblNivel1")).Text = "Recibido por Paqueteria";
        this.LimpiarFiltros();
    }
    
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    
    
    protected void btnfiltrofecha_Click(object sender, EventArgs e)
    {
            odsMateriales.DataBind();
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
            Label4.Visible = true;
            Label5.Visible = true;
            txtPO.Visible = true;
            txtRenglon.Visible = true;
            txtNoParte.Visible = true;

            odsMateriales.DataBind();

            txtUbicacion.Visible = false;
            Label3.Visible = false;

            txtUbicacion.Text = "1231231";
        }



    }

    private void LimpiarFiltros()
    {
        txtfecha1.Text = Convert.ToString(DateTime.Today.AddDays(-3)).Substring(0, 11).Trim();
        txtfecha2.Text = Convert.ToString(DateTime.Today).Substring(0, 11).Trim();
        TextBox1.Text = "";
        txtUbicacion.Text = "";
        txtPO.Text = "";
        txtRenglon.Text = "";
        txtNoParte.Text = "";
    }
    protected void lkbLimpiar_Click(object sender, EventArgs e)
    {
        this.LimpiarFiltros();
    }
    protected void gvmaestro_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            //((ASP.minicontrols_descargarsubiropl_ascx)e.Row.Controls[7].FindControl("DescargarSubirOPL1")).nid_opl = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "nid_opl"));
            //((ASP.minicontrols_descargarsubiropl_ascx)e.Row.Controls[7].FindControl("DescargarSubirOPL1")).nid_opl_in = Convert.ToString(DataBinder.Eval(e.Row.DataItem, "nid_opl_in"));
            //((ASP.minicontrols_descargarsubiropl_ascx)e.Row.Controls[7].FindControl("DescargarSubirOPL1")).EnEdicion = true;
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.Text == "Labinal")
        {
          //  chkMateriales.Visible = true;
            //    gvmaestro.Visible = !chkMateriales.Checked;
            //    dgvMateriales.Visible = chkMateriales.Checked;

         
            dgvMateriales.Visible = true;

            txtUbicacion.Visible = false;
            Label3.Visible = false;

            Label4.Visible = true;
            Label5.Visible = true;
            txtPO.Visible = true;
            txtRenglon.Visible = true;
            txtNoParte.Visible = true;

        }
        else
        {
         //   chkMateriales.Checked = false;

         
            dgvMateriales.Visible = false;

            txtUbicacion.Visible = true;
            Label3.Visible = true;


            Label4.Visible = false;
            Label5.Visible = false;
            txtPO.Visible = false;
            txtRenglon.Visible = false;
            txtNoParte.Visible = false;
            chkMateriales.Visible = false;
        }
    }
    protected void chkMateriales_CheckedChanged(object sender, EventArgs e)
    {
        //gvmaestro.Visible = !chkMateriales.Checked;
        //dgvMateriales.Visible = chkMateriales.Checked;
        //Label4.Visible = chkMateriales.Checked;
        //Label5.Visible = chkMateriales.Checked;
        //txtPO.Visible = chkMateriales.Checked;
        //txtRenglon.Visible = chkMateriales.Checked;
        //txtNoParte.Visible = chkMateriales.Checked;
    }
    protected void txtPO_TextChanged(object sender, EventArgs e)
    {

    }
}
