<%@ Control Language="C#" AutoEventWireup="true" CodeFile="paqueteriaMateriales.ascx.cs" Inherits="CBB_paqueteriaMateriales" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="../Minicontrols/DescargarSubirOPL.ascx" TagName="DescargarSubirOPL"
    TagPrefix="uc5" %>
<%@ Register Src="../Minicontrols/SubirArchivo.ascx" TagName="SubirArchivo" TagPrefix="uc3" %>
<%@ Register Src="../Minicontrols/SubirArchivoPDFl.ascx" TagName="SubirArchivoPDFl"
    TagPrefix="uc2" %>
    
<style type="text/css">
    .DataGridFixedHeader {background-color: white; position:relative; top:expression(this.ParentNode.ParentNode.ParentNode.scrollTop);}
</style>   

<asp:Label ID="Label2" runat="server" Text="Cliente: "></asp:Label>
<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1"
    DataTextField="nombre" DataValueField="nid_filial" OnDataBound="DropDownList1_DataBound" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" >
</asp:DropDownList>
<asp:CheckBox ID="chkMateriales" runat="server" AutoPostBack="True" OnCheckedChanged="chkMateriales_CheckedChanged"
    Text="Materiales" Visible="False" />
<cc1:ListSearchExtender ID="lsecliente" runat="server" TargetControlID="DropDownList1">
</cc1:ListSearchExtender>
<br />
<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}"
    SelectMethod="GetFilials" TypeName="localhost.GeneralFrame" OnSelecting="ObjectDataSource1_Selecting">
    <SelectParameters>
        <asp:Parameter Name="SessionID" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<table style="width:773;">
    <tr>
        <td>
            <asp:Label ID="lblfiltro" runat="server" Text="Filtro por fecha : "></asp:Label></td>
        <td>
            <asp:TextBox ID="txtfecha1" runat="server"></asp:TextBox>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/webapp_images/Calendar_scheduleHS.png" />
            <cc1:CalendarExtender ID="CalendarExtender1" runat="server" Format="dd/MM/yyyy" PopupButtonID="Image1"
                TargetControlID="txtfecha1" PopupPosition="TopLeft">
            </cc1:CalendarExtender>
        </td>
        <td>
            <asp:TextBox ID="txtfecha2" runat="server"></asp:TextBox>
            <asp:Image ID="Image2" runat="server" ImageUrl="~/webapp_images/Calendar_scheduleHS.png" />
            <cc1:CalendarExtender ID="CalendarExtender2" runat="server" Format="dd/MM/yyyy" PopupButtonID="Image2"
                TargetControlID="txtfecha2" PopupPosition="TopLeft">
            </cc1:CalendarExtender>
        </td>
        <td>
        <asp:Button ID="btnfiltrofecha" runat="server" Text="Filtrar" OnClick="btnfiltrofecha_Click" /><br />    
        </td>
    </tr>
        <tr><td><asp:Label ID="Label1" runat="server" Text="Busqueda por Guía: "></asp:Label> </td>
            <td><asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox></td>
        </tr>
        <tr>
          <td><asp:Label ID="Label3" runat="server" Text="Busqueda por Ubicación:"></asp:Label>  </td>
          <td><asp:TextBox ID="txtUbicacion" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox></td>
        </tr>
    <tr>
        <td>
            <asp:Label ID="Label4" runat="server" Text="Busqueda por Orden de compra:" Visible="False"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtPO" runat="server" Width="79px" Visible="False" OnTextChanged="txtPO_TextChanged">1</asp:TextBox>
            <asp:TextBox ID="txtRenglon" runat="server" Width="41px" Visible="False">1</asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label5" runat="server" Text="Busqueda código 7:" Visible="False"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtNoParte" runat="server" Visible="False">1</asp:TextBox></td>
    </tr>
</table>
<asp:LinkButton ID="lkbLimpiar" runat="server" OnClick="lkbLimpiar_Click">Limpiar busqueda</asp:LinkButton>
<asp:ObjectDataSource ID="odsMateriales" runat="server" SelectMethod="recibo_por_paqueteria_materiales"
    TypeName="localhost.paqueteria" OldValuesParameterFormatString="original_{0}">
    <SelectParameters>
        <asp:ControlParameter ControlID="DropDownList1" Name="ncliente" PropertyName="SelectedValue"
            Type="Int32" />
        <asp:ControlParameter ControlID="txtfecha1" Name="date1" PropertyName="Text" Type="String" />
        <asp:ControlParameter ControlID="txtfecha2" Name="date2" PropertyName="Text" Type="String" />
        <asp:ControlParameter ControlID="txtUbicacion" Name="location" PropertyName="Text"
            Type="String" />
        <asp:ControlParameter ControlID="TextBox1" Name="sku" PropertyName="Text" Type="String" />
        <asp:ControlParameter ControlID="txtPO" DefaultValue="0" Name="PO" PropertyName="Text"
            Type="Int32" />
        <asp:ControlParameter ControlID="txtRenglon" DefaultValue="0" Name="Renglon" PropertyName="Text"
            Type="Int32" />
        <asp:ControlParameter ControlID="txtNoParte" DefaultValue="" Name="NoParte" PropertyName="Text"
            Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
&nbsp; &nbsp;
&nbsp; &nbsp;&nbsp;<br />
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <TABLE>
            <TBODY>
                <TR>
                    <TD vAlign=bottom style="height: 321px">
                        <DIV style="OVERFLOW: auto; HEIGHT: 300px">

                            <asp:GridView id="dgvMateriales" runat="server" DataSourceID="odsMateriales" Font-Size="Small" AutoGenerateColumns="False" DataKeyNames="numllegada,nid_opl_in" OnRowDataBound="gvmaestro_RowDataBound" Visible="False" AllowSorting="True">
                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="guia" HeaderText="Numero de Guia" SortExpression="guia">
                                        <ItemStyle Width="95px" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="fecha" DataFormatString="{0:d/M/yyyy h:mm tt}" HeaderText="Fecha Recibo" SortExpression="fecha">
                                        <ItemStyle Width="200px" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="paqueteria" HeaderText="Paqueteria" SortExpression="paqueteria">
                                        <ItemStyle Width="170px" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="estado" HeaderText="Estado" SortExpression="Estado">
                                        <ItemStyle Width="75px" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Id" HeaderText="PO" />
                                    <asp:BoundField DataField="RenglonId" HeaderText="Renglon" />
                                    <asp:BoundField DataField="NumeroParte" HeaderText="Codigo 7" />
                                    <asp:BoundField DataField="FacturaProveedor" HeaderText="Factura" />
                                    <asp:BoundField DataField="FechaDespacho" DataFormatString="{0:d/M/yyyy h:mm tt}" HeaderText="Fecha Despacho">
                                        <ItemStyle Width="105px" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="cbox_number" HeaderText="Caja" />
                                    <asp:BoundField DataField="nombre" HeaderText="Transportista" />
                                    <asp:HyperLinkField DataNavigateUrlFields="nid_opl_in" DataNavigateUrlFormatString="~/ECA/viewpdf.aspx?nid_file={0}&amp;inline=True"
                                                                    Target="_blank" Text="Descargar PDF" NavigateUrl="~/ECA/viewpdf.aspx?nid_file={0}&amp;inline=True" />
                                    <asp:BoundField DataField="numpaqueteria" HeaderText="# Paqueteria" SortExpression="numpaqueteria" Visible="False">
                                        <ItemStyle Width="88px" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="numllegada" HeaderText="# Llegada" SortExpression="numllegada" Visible="False">
                                        <ItemStyle Width="70px" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="nid_opl_in" HeaderText="No Packing List Interno" SortExpression="nid_opl_in" />
                                    <asp:CommandField ShowSelectButton="True" SelectText="Seleccionar" Visible="False" />
                                    <asp:BoundField DataField="Comentario" HeaderText="Comentario" />
                                    <asp:BoundField DataField="ubicacion" HeaderText="Ubicacion" SortExpression="ubicacion" Visible="False">
                                        <ItemStyle Width="75px" />
                                    </asp:BoundField>
                                </Columns>
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#5D7B9D" CssClass="ms-formlabel DataGridFixedHeader" Font-Bold="True"
                                    ForeColor="White" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            </asp:GridView>
                        </DIV>
                    </TD>
                </TR>
            </TBODY>
        </TABLE>
    </ContentTemplate>
</asp:UpdatePanel> 

