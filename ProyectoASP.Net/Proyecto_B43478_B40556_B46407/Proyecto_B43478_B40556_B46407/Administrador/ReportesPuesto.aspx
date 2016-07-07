<%@ Page Title="" Language="C#" MasterPageFile="~/AdministratorPage.Master" AutoEventWireup="true" CodeBehind="ReportesPuesto.aspx.cs" Inherits="Proyecto_B43478_B40556_B46407.Administrador.ReportesPuesto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-lg-9">
        <asp:Label ID="Label1" runat="server" CssClass="label label-primary" Text="Reportes" Font-Size="X-Large"></asp:Label><br /><br />
        <asp:Label ID="Label2" runat="server" CssClass="label label-info" Text="Puesto"></asp:Label><br />
        <asp:Label ID="lblNombrePuesto" runat="server" Text=""></asp:Label><br /><br />
        <asp:Label ID="Label3" runat="server" CssClass="label label-info" Text="Empresa"></asp:Label><br />
        <asp:Label ID="lblCompania" runat="server" Text=""></asp:Label><br /><br />
        <asp:Label ID="Label4" runat="server" CssClass="label label-info" Text="Entrevistas"></asp:Label><br /><br />
        <asp:GridView ID="gvEntrevistas" runat="server" CssClass="table table-condensed" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
            <Columns>
                <asp:BoundField DataField="IdEntrevista" HeaderText="ID" />
                <asp:BoundField DataField="TipoeEntrevista" HeaderText="Tipo" />
                <asp:BoundField DataField="FechaEntrevista" HeaderText="Fecha" />
                <asp:BoundField DataField="HoraEntrevista" HeaderText="Hora" />
                <asp:BoundField DataField="SolicitanteTrabajo.Nombre" HeaderText="Solicitante" />
                <asp:BoundField DataField="SolicitanteTrabajo.Apellidos" HeaderText="Apellidos" />
                <asp:BoundField DataField="SolicitanteTrabajo.IdSolicitante" HeaderText="Identificación" />
                <asp:BoundField DataField="PuestoOfertado.DescripcionPuesto" HeaderText="Puesto" />
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
</asp:Content>
