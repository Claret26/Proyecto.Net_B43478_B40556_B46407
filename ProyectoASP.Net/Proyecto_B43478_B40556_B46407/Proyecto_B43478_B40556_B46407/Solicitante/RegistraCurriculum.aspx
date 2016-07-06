<%@ Page Title="" Language="C#" MasterPageFile="~/SolicitantePage.Master" AutoEventWireup="true" CodeBehind="RegistraCurriculum.aspx.cs" Inherits="Proyecto_B43478_B40556_B46407.Solicitante.RegistraCurriculum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-4"></div>
    <div class="col-md-4">
        <div class="row">
            <div class="col-md-7">
                <asp:Label ID="Label13" runat="server" Text="Cédula:"></asp:Label>
                <asp:TextBox ID="tbCedulaSolicitante" CssClass="form-control" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
                <asp:TextBox ID="tbNombreSolicitante" CssClass="form-control" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label2" runat="server" Text="Apellidos: "></asp:Label>
                <asp:TextBox ID="tbApellidosSolicitantes" CssClass="form-control" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label3" runat="server" Text="Fecha nacimiento"></asp:Label>
                <asp:TextBox ID="tbFechaNacimiento" CssClass="form-control" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label4" runat="server" Text="Género: " Font-Size="Medium"></asp:Label>
                <asp:RadioButtonList ID="rblGenero" runat="server">
                    <asp:ListItem>Femenino</asp:ListItem>
                    <asp:ListItem>Masculino</asp:ListItem>
                    <asp:ListItem>Otro</asp:ListItem>
                </asp:RadioButtonList><br />
                <asp:Label ID="Label5" runat="server" Text="Estado Civil"></asp:Label>
                <asp:DropDownList ID="ddlEstadoCivil" CssClass="form-control" runat="server">
                    <asp:ListItem Value="Casado">Casado(a)</asp:ListItem>
                    <asp:ListItem Value="Divorciado">Divorciado(a)</asp:ListItem>
                    <asp:ListItem Value="Soltero">Soltero (a)</asp:ListItem>
                    <asp:ListItem Value="UnionLibre">Union Libre</asp:ListItem>
                    <asp:ListItem Value="Viudo">Viudo (a)</asp:ListItem>
                </asp:DropDownList><br />
                <asp:Label ID="Label6" runat="server" Text="Dirección: "></asp:Label>
                <asp:Label ID="Label7" runat="server" Text="Provincia"></asp:Label>
                <asp:DropDownList ID="ddlProvincias" CssClass="form-control" runat="server">
                    <asp:ListItem Value="SanJose">San José</asp:ListItem>
                    <asp:ListItem Value="Alajuela">Alajuela</asp:ListItem>
                    <asp:ListItem Value="Cartago">Cartago</asp:ListItem>
                    <asp:ListItem Value="Heredia">Heredia</asp:ListItem>
                    <asp:ListItem Value="Puntarenas">Puntarenas</asp:ListItem>
                    <asp:ListItem Value="Guanacaste">Guanacaste</asp:ListItem>
                    <asp:ListItem Value="Limon">Limón</asp:ListItem>
                </asp:DropDownList><br />
                <asp:Label ID="Label11" runat="server" Text="Ciudad: "></asp:Label>
                <asp:TextBox ID="tbCiudad" CssClass="form-control" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label12" runat="server" Text="Dirección exacta: "></asp:Label>
                <textarea id="txtDireccion" runat="server" cols="20" class="form-control" style="resize:none" rows="6"></textarea><br />
                <asp:Label ID="Label8" runat="server" Text="Teléfonos de Contacto: " Font-Size="Medium"></asp:Label><br />
                <asp:Label ID="Label9" runat="server" Text="Celular"></asp:Label>
                <asp:TextBox ID="tbCelularSolicitante" CssClass="form-control" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label10" runat="server" Text="Casa: "></asp:Label>
                <asp:TextBox ID="tbTelefonoCasa" CssClass="form-control" runat="server"></asp:TextBox><br />

                </div>
            <div class="col-lg-4">
        <div class="row">
            <br /><asp:RequiredFieldValidator ID="rfvCedula" ControlToValidate="tbCedulaSolicitante" runat="server" ErrorMessage="RequiredFieldValidator" CssClass="alert-danger">* Campo requerido</asp:RequiredFieldValidator><br /><br /><br />
            
            <asp:RequiredFieldValidator ID="rfvNombre" ControlToValidate="tbNombreSolicitante" runat="server" ErrorMessage="RequiredFieldValidator" CssClass="alert-danger">* Campo requerido</asp:RequiredFieldValidator><br /><br /><br /><br />
            <asp:RequiredFieldValidator ID="rfvApellidos" ControlToValidate="tbApellidosSolicitantes" runat="server" ErrorMessage="RequiredFieldValidator" CssClass="alert-danger">* Campo requerido</asp:RequiredFieldValidator><br /><br /><br /><br />
            <asp:RequiredFieldValidator ID="rfvFechaNacimiento" ControlToValidate="tbFechaNacimiento" runat="server" ErrorMessage="RequiredFieldValidator" CssClass="alert-danger">* Campo requerido</asp:RequiredFieldValidator><br /><br /><br />
            <asp:RequiredFieldValidator ID="rfvGenero" ControlToValidate="rblGenero" runat="server" ErrorMessage="RequiredFieldValidator" CssClass="alert-danger">* Campo requerido</asp:RequiredFieldValidator><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
            <asp:RequiredFieldValidator ID="rfvCiudad" ControlToValidate="tbCiudad" runat="server" ErrorMessage="RequiredFieldValidator" CssClass="alert-danger">* Campo requerido</asp:RequiredFieldValidator><br /><br /><br /><br /><br />
            <asp:RequiredFieldValidator ID="rfvDireccion" ControlToValidate="txtDireccion" runat="server" ErrorMessage="RequiredFieldValidator" CssClass="alert-danger">* Campo requerido</asp:RequiredFieldValidator><br /><br /><br /><br /><br /><br /><br /><br /><br />
            <asp:RequiredFieldValidator ID="rfvCelular" ControlToValidate="tbCelularSolicitante" runat="server" ErrorMessage="RequiredFieldValidator" CssClass="alert-danger">* Campo requerido</asp:RequiredFieldValidator><br /><br /><br /><br />
            <asp:RequiredFieldValidator ID="rfvTelefono" ControlToValidate="tbTelefonoCasa" runat="server" ErrorMessage="RequiredFieldValidator" CssClass="alert-danger">* Campo requerido</asp:RequiredFieldValidator>
        </div>
    </div>


            </div>
            <nav>
                <ul class="pager">
                    <li class="next"><a><asp:Button ID="btnNext" CssClass="btn btn-default" runat="server" Text="Next" OnClick="btnNext_Click"/></a></li>
                </ul>
            </nav>
            <div class="progress">
                    <div class="progress-bar progress-bar-info" role="progressbar" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100" style="width:25%">
                        25% 
                    </div>
            </div>
    </div>
    
    <footer></footer>
</asp:Content>
