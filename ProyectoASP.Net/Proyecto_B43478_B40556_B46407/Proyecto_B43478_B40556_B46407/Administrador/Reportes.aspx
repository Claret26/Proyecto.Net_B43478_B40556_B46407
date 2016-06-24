<%@ Page Title="" Language="C#" MasterPageFile="~/AdministratorPage.Master" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="Proyecto_B43478_B40556_B46407.Administrador.Reportes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="col-lg-6">
        <div class="container">
            <asp:Label ID="Label1" runat="server" Text="Reportes" CssClass="label label-info" Font-Size="Larger"></asp:Label><br />
            <div class="col-lg-3">
                <br /><asp:Label ID="Label2" runat="server" Text="Puesto de trabajo:"></asp:Label>
                <asp:DropDownList ID="ddlPuestosDeTrabajo" CssClass="form-control" runat="server" OnSelectedIndexChanged="ddlPuestosDeTrabajo_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList><br />
                <asp:Button ID="btnBuscarPorPuesto" runat="server" CssClass="btn btn-primary" Visible="false" Text="Buscar" OnClick="btnBuscarPorPuesto_Click" />
            </div>
            <div class="col-lg-3">
                <br /><asp:Label ID="Label3" runat="server" Text="Compañía:"></asp:Label>
                <asp:DropDownList ID="ddlCompanias" CssClass="form-control" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCompanias_SelectedIndexChanged"></asp:DropDownList><br />
                <asp:Button ID="btnBuscarPorCompania" runat="server" CssClass="btn btn-primary" Visible="false" Text="Buscar" OnClick="btnBuscarPorCompania_Click" />
            </div>
        </div>
    </div>
</asp:Content>
