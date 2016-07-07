<%@ Page Title="" Language="C#" MasterPageFile="~/AdministratorPage.Master" AutoEventWireup="true" CodeBehind="ReportesCompania.aspx.cs" Inherits="Proyecto_B43478_B40556_B46407.Administrador.ReportesCompania" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-lg-9">
        <asp:Label ID="Label1" runat="server" CssClass="label label-info" Text="Reportes" Font-Size="X-Large"></asp:Label><br /><br />
        <asp:Label ID="Label2" runat="server" Text="Compañía: "></asp:Label><br /><br />
        <asp:Label ID="lblNombreCompania" runat="server" Text=""></asp:Label><br /><br />

        <asp:GridView ID="gvPuestos" runat="server" CssClass="table table-condensed" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
            <Columns>
                <asp:BoundField DataField="ClavePuesto" HeaderText="Clave" />
                <asp:BoundField DataField="DescripcionPuesto" HeaderText="Descripción" />
                <asp:BoundField DataField="ExperienciaRequerida" HeaderText="Experiencia" />
                <asp:BoundField DataField="Abierto" HeaderText="Abierto" />
                <asp:BoundField DataField="NumeroVacantes" HeaderText="Vacantes" />
                <asp:BoundField DataField="DiasLaborar" HeaderText="Días Laborales" />
                <asp:BoundField DataField="HoraEntrada" HeaderText="Entrada" />
                <asp:BoundField DataField="HoraSalida" HeaderText="Salida" />
                <asp:BoundField DataField="Sueldo" HeaderText="Sueldo" />
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
