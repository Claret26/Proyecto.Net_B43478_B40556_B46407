<%@ Page Title="" Language="C#" MasterPageFile="~/SolicitantePage.Master" AutoEventWireup="true" CodeBehind="ConfirmarRegistro.aspx.cs" Inherits="Proyecto_B43478_B40556_B46407.Solicitante.ConfirmarRegistro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-4"></div>
    <div class="col-md-4">
        <div class="row">
            <div class="col-md-8">
                <asp:Label ID="Label1" runat="server" Text="¡Completar mi Curriculum!"></asp:Label><br /><br />
                <asp:Label ID="Label2" runat="server" Text="¿Desea guardar su curriculum?"></asp:Label><br />
                <asp:RadioButtonList ID="rblConfirmaRegistro" runat="server">
                    <asp:ListItem Value="Si">Sí</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:RadioButtonList><br /><br /><br />
                <asp:Button ID="btnConfirmaRegistro" CssClass="btn btn-success btn-block" runat="server" Text="Guardar" OnClick="btnConfirmaRegistro_Click" />
            </div>
            <div class="col-md-4">
                <div class="row">
                    <asp:RequiredFieldValidator ID="rfvConfirmacion" ControlToValidate="rblConfirmaRegistro" CssClass="alert-danger" runat="server" ErrorMessage="RequiredFieldValidator">Es necesario confirmar la petición</asp:RequiredFieldValidator>
                </div>
            </div>
        </div>
        <nav>
           <ul class="pager">
               <li class="next"><a href="Experiencia.aspx">Previous</a></li>
           </ul>
        </nav>
        <div class="progress">
           <div class="progress-bar progress-bar-info" role="progressbar" aria-valuenow="100" aria-valuemin="0" aria-valuemax="100" style="width:100%">
                100% 
           </div>
        </div>
    </div>
</asp:Content>
