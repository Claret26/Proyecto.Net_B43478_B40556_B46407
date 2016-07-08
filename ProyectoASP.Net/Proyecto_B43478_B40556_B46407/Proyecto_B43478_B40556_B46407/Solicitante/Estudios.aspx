<%@ Page Title="" Language="C#" MasterPageFile="~/SolicitantePage.Master" AutoEventWireup="true" CodeBehind="Estudios.aspx.cs" Inherits="Proyecto_B43478_B40556_B46407.Solicitante.Estudios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-2"></div>
    <div class="col-md-5">
        <div class="row">
            <div class="col-md-9">
                <asp:Label ID="Label1" runat="server" Text="Nivel de estudio"></asp:Label>
                <asp:DropDownList ID="ddlNivelesDeEstudio" CssClass="form-control" runat="server" OnSelectedIndexChanged="ddlNivelesDeEstudio_SelectedIndexChanged" AutoPostBack="True">
                </asp:DropDownList><br />
                <asp:Label ID="lblInstitucion" runat="server"  Text="Institución: "></asp:Label><br />
                <asp:DropDownList ID="ddlInstituciones" CssClass="form-control" runat="server" OnSelectedIndexChanged="ddlInstituciones_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList><br />
                <asp:TextBox ID="tbInstitucion" CssClass="form-control" runat="server" Visible="false"></asp:TextBox><br />
                <asp:Label ID="lblEspecialidad" runat="server" Text="Especialidad: " Visible="false"></asp:Label>
                <asp:DropDownList ID="ddlEspecialidades" CssClass="form-control" runat="server" Visible="false"></asp:DropDownList><br />
                <asp:Label ID="Label7" runat="server" Text="Título Obtenido"></asp:Label>
                <asp:TextBox ID="tbTituloObtenido" CssClass="form-control" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label8" runat="server" Text="Año inicio: "></asp:Label>
                <asp:TextBox ID="tbAnoInicio" CssClass="form-control" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label9" runat="server" Text="Año finalización: "></asp:Label>
                <asp:TextBox ID="tbAnoFinalizacion" CssClass="form-control" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label6" runat="server" Text="Curriculum: "></asp:Label>
                <asp:Button ID="btnCargarCurriculum" CssClass="btn btn-default" runat="server" Text="Cargar" /><br /><br />
                <asp:Button ID="btnAgregarEstudio" CssClass="btn btn-default" runat="server" Text="Agregar estudio" OnClick="btnAgregarEstudio_Click" />
                <br />
                <br />
                <asp:Label ID="lblEstudios" runat="server" Text="Estudios realizados:" Visible="false"></asp:Label>
                <br />
                <br />
                <asp:GridView ID="gvEstudios" CssClass="table table-responsive" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
                    <Columns>
                        <asp:BoundField DataField="NivelEstudio.DescripcionNivelEstudio" HeaderText="Nivel" />
                        <asp:BoundField DataField="AnoInicio" HeaderText="Año Inicio" />
                        <asp:BoundField DataField="AnoFinalizacion" HeaderText="Año Fin" />
                        <asp:BoundField DataField="InstitucionEstudio.NombreInstitucion" HeaderText="Institución" />
                        <asp:BoundField DataField="NombreTituloObtenido" HeaderText="Título" />
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#487575" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#275353" />
                </asp:GridView>
            </div>
            <div class="col-md-4">
                <div class="row">
                    <br /><br /><br /><br /><br /><br /><br />
                    <asp:RequiredFieldValidator ID="rfvInstitucion" ControlToValidate="tbInstitucion" CssClass="alert-danger" runat="server" ErrorMessage="RequiredFieldValidator" Enabled="false">* Campo Requerido</asp:RequiredFieldValidator>
                    <br /><br /><br /><br />
                    <asp:RequiredFieldValidator ID="rfvTituloObtenido" ControlToValidate="tbTituloObtenido" runat="server" ErrorMessage="RequiredFieldValidator" CssClass="alert-danger">* Campo Requerido</asp:RequiredFieldValidator><br /><br /><br /><br />
                    <asp:RequiredFieldValidator ID="rfvAnoInicio" ControlToValidate="tbAnoInicio" CssClass="alert-danger" runat="server" ErrorMessage="RequiredFieldValidator">* Campo Requerido</asp:RequiredFieldValidator><br /><br /><br /><br />
                    <asp:RequiredFieldValidator ID="rfvAnoFin" ControlToValidate="tbAnoFinalizacion" CssClass="alert-danger" runat="server" ErrorMessage="RequiredFieldValidator">* Campo Requerido</asp:RequiredFieldValidator>
                </div>
            </div>
        </div>
        <nav>
           <ul class="pager">
               <li class="previous"><a href="RegistrarCurriculum.aspx">Previous</a></li>
               <li class="next"><a><asp:Button ID="btnNext" CssClass="btn btn-default" runat="server" Text="Next" OnClick="btnNext_Click" /></a></li>
           </ul>
        </nav>
        <div class="progress">
           <div class="progress-bar progress-bar-info" role="progressbar" aria-valuenow="25" aria-valuemin="50" aria-valuemax="100" style="width:50%">
                50% 
           </div>
        </div>
    </div>
</asp:Content>
