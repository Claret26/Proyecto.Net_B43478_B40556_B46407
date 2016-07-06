<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Proyecto_B43478_B40556_B46407.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="col-lg-4"></div> 
     <div class="col-md-3">
       <div class="row">
            <asp:Label ID="Label1" runat="server" Text="Registro" Font-Size="Larger"></asp:Label>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Nombre de usuario:"></asp:Label><br />
                <asp:TextBox ID="tbNombreUsuario" runat="server" CssClass="form-control"></asp:TextBox><br />
                <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label><br />
                <asp:TextBox ID="tbEmail" CssClass="form-control" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label4" runat="server" Text="Password:"></asp:Label><br />
                <asp:TextBox ID="tbPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox><br />
                <asp:Label ID="Label5" runat="server" Text="Confirm Password:"></asp:Label><br />
                <asp:TextBox ID="tbConfirmPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                <br />
                <asp:CheckBox ID="checkTerminosYCondiciones" runat="server" Text=" Acepto términos y condiciones" />
                <asp:Button ID="btnRegistrar" runat="server" CssClass="btn btn-primary btn-block" Text="Registrar" OnClick="btnRegistrar_Click" OnClientClick="True" />
             </div>
        </div>
       <div id="alertContrasenasIncorrectas" runat="server" class="alert alert-danger" role="alert">Hay errores en el llenado del formulario</div>
   </div>
    <div class="col-lg-3">
        <div class="row">
            <br /><asp:RequiredFieldValidator ID="rfNombreUsuario" ControlToValidate="tbNombreUsuario" runat="server" ErrorMessage="Campo requerido">* Campo Requerido</asp:RequiredFieldValidator><br /><br /><br /><br />
            <!--<asp:RegularExpressionValidator ID="revEmail" ControlToValidate="tbEmail" ValidationExpression="^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@ [A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$" runat="server" ErrorMessage="RegularExpressionValidator">Formato de email incorrecto</asp:RegularExpressionValidator>-->
            <br /><br /><br /><asp:RequiredFieldValidator ID="rfEmail" ControlToValidate="tbEmail" runat="server" ErrorMessage="Campo requerido">* Campo Requerido</asp:RequiredFieldValidator><br />
            <br /><br /><br /><asp:CompareValidator ID="cvContrasenas" ControlToValidate="tbPassword" ControlToCompare="tbConfirmPassword" Type="String" runat="server">Las contraseñas no coinciden</asp:CompareValidator>
        </div>
    </div>
</asp:Content>
