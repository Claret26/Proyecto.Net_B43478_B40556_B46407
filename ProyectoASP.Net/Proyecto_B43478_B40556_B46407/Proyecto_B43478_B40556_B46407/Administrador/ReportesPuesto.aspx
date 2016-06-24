<%@ Page Title="" Language="C#" MasterPageFile="~/AdministratorPage.Master" AutoEventWireup="true" CodeBehind="ReportesPuesto.aspx.cs" Inherits="Proyecto_B43478_B40556_B46407.Administrador.ReportesPuesto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-lg-6">
        <asp:Label ID="Label1" runat="server" CssClass="label label-primary" Text="Reportes" Font-Size="X-Large"></asp:Label><br /><br />
        <asp:Label ID="Label2" runat="server" CssClass="label label-info" Text="Puesto"></asp:Label><br />
        <asp:Label ID="lblNombrePuesto" runat="server" Text=""></asp:Label><br /><br />
        <asp:Label ID="Label3" runat="server" CssClass="label label-info" Text="Empresa"></asp:Label><br />
        <asp:Label ID="lblCompania" runat="server" Text=""></asp:Label><br /><br />
        <asp:Label ID="Label4" runat="server" CssClass="label label-info" Text="Entrevistas"></asp:Label><br />
        <asp:GridView ID="gvEntrevistas" runat="server"></asp:GridView>

    </div>
</asp:Content>
