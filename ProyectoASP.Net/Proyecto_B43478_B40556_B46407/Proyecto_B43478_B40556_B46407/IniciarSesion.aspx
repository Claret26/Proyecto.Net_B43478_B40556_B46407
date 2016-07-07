<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="IniciarSesion.aspx.cs" Inherits="Proyecto_B43478_B40556_B46407.IniciarSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="ingrUser">
<div  class="col-xs-12 col-sm-6 col-md-3 col-sm-offset-6 col-md-offset-4 " >
<div class="form-group">
&nbsp;
    <asp:Label ID="Label1" runat="server" Text="Usuario:"></asp:Label>
    <br />
    <asp:TextBox ID="tbUsuario" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Contraseña:" ></asp:Label>
    <br />
    <asp:TextBox ID="tbContrasena" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnIniciarSesion" runat="server" Text="Ingresar" CssClass="btn btn-primary" OnClick="btnIniciarSesion_Click"/>
    <br />
    <br />
    <div id="alertUsuarioIncorrecto" runat="server" class="alert alert-danger" role="alert">Usuario y/o Contraseña incorrectos o usuario no activo</div>
</div>
</div>
</div>
</asp:Content>
