<%@ Page Title="" Language="C#" MasterPageFile="~/AdministratorPage.Master" AutoEventWireup="true" CodeBehind="ReportesCompania.aspx.cs" Inherits="Proyecto_B43478_B40556_B46407.Administrador.ReportesCompania" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-lg-6">
        <asp:Label ID="Label1" runat="server" CssClass="label label-info" Text="Reportes" Font-Size="X-Large"></asp:Label><br /><br />
        <asp:Label ID="Label2" runat="server" Text="Compañía"></asp:Label><br />
        <asp:Label ID="lblNombreCompania" runat="server" Text=""></asp:Label><br /><br />

        <asp:GridView ID="gvPuestos" runat="server"></asp:GridView>

    </div>
</asp:Content>
