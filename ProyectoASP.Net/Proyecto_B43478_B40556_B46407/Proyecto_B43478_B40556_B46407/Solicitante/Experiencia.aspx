<%@ Page Title="" Language="C#" MasterPageFile="~/SolicitantePage.Master" AutoEventWireup="true" CodeBehind="Experiencia.aspx.cs" Inherits="Proyecto_B43478_B40556_B46407.Solicitante.Experiencia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-4"></div>
    <div class="col-md-4">
        <div class="row">
            <div class="col-md-8">
                <asp:Label ID="Label1" runat="server" Text="Experiencia Laboral: "></asp:Label><br />
                <asp:Label ID="Label7" runat="server" Text="¿Tiene experiencia laboral?"></asp:Label><br />
                <br /><asp:RadioButtonList ID="rblExperiencia"  runat="server" OnSelectedIndexChanged="rblExperiencia_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem Value="Si">Sí</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:RadioButtonList><br />
                <asp:Label ID="lblPuesto" runat="server" Text="Puesto: " Visible="false"></asp:Label>
                <asp:TextBox ID="tbPuesto" CssClass="form-control" runat="server" Visible="false"></asp:TextBox><br />
                <asp:Label ID="lblEmpresa" runat="server" Text="Empresa" Visible="false"></asp:Label>
                <asp:TextBox ID="tbEmpresa" CssClass="form-control" runat="server" Visible="false"></asp:TextBox><br />
                <asp:Label ID="lblAnoInicio" runat="server" Text="Año inicio: " Visible="false"></asp:Label>
                <asp:TextBox ID="tbFechaInicio" CssClass="form-control" runat="server" Visible="false"></asp:TextBox><br />
                <asp:Label ID="lblAnoFin" runat="server" Text="Año fin:" Visible="false"></asp:Label>
                <asp:TextBox ID="tbFechaFin" CssClass="form-control" runat="server" Visible="false"></asp:TextBox><br />
                <asp:Label ID="lblFunciones" runat="server" Text="Funciones:" Visible="false"></asp:Label>
                <textarea id="txtFunciones" class="form-control" runat="server" cols="20" Visible="false" style="resize:none" rows="5"></textarea><br />
                <asp:Button ID="btnAgregarExperiencia" CssClass="form-control" Visible="false" runat="server" Text="Agregar Experiencia" OnClick="btnAgregarExperiencia_Click" /><br />
                <asp:GridView ID="gvExperiencia" CssClass="table table-bordered" runat="server"></asp:GridView>   
            </div>
            <div class="col-md-4">
                <div class="row">
                    <br /><br /><br /><br /><br /><br /><br />
                    <asp:RequiredFieldValidator ID="rfvPuesto" ControlToValidate="tbPuesto" CssClass="alert-danger" runat="server" ErrorMessage="RequiredFieldValidator">* Campo Requerido</asp:RequiredFieldValidator><br /><br /><br /><br />
                    <asp:RequiredFieldValidator ID="rfvEmpresa" ControlToValidate="tbEmpresa" CssClass="alert-danger" runat="server" ErrorMessage="RequiredFieldValidator">* Campo Requerido</asp:RequiredFieldValidator><br /><br /><br /><br />
                    <asp:RequiredFieldValidator ID="rfvAnoInicio" ControlToValidate="tbFechaInicio" CssClass="alert-danger" runat="server" ErrorMessage="RequiredFieldValidator">* Campo Requerido</asp:RequiredFieldValidator><br /><br /><br /><br />
                    <asp:RequiredFieldValidator ID="rfvFechaFin" ControlToValidate="tbFechaFin" CssClass="alert-danger" runat="server" ErrorMessage="RequiredFieldValidator">* Campo Requerido</asp:RequiredFieldValidator><br /><br /><br /><br />
                    <asp:RequiredFieldValidator ID="rfvFunciones" ControlToValidate="txtFunciones" CssClass="alert-danger" runat="server" ErrorMessage="RequiredFieldValidator">* Campo Requerido</asp:RequiredFieldValidator><br /><br /><br /><br />
                </div>
            </div>
        </div>
        <nav>
           <ul class="pager">
               <li class="previous"><a href="Estudios.aspx">Previous</a></li>
               <li class="next"><a href="ConfirmarRegistro.aspx">Next</a></li>
           </ul>
        </nav>
        <div class="progress">
           <div class="progress-bar progress-bar-info" role="progressbar" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100" style="width:75%">
                75% 
           </div>
        </div>
    </div>
</asp:Content>
