<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/AdministratorPage.Master" AutoEventWireup="true" CodeBehind="PuestosSolicitados.aspx.cs" Inherits="Proyecto_B43478_B40556_B46407.Administrador.PuestosSolicitados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--Siempre va a ser mejor tener las librerias descargadas en el fichero del proyecto pero así funciona -->
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
  	<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.2/jquery.min.js"></script>
	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-3 col-sm-offset-2">
        <h3 style="color: cornflowerblue">Puestos Solicitados</h3><br/>
        <asp:GridView ID="GridView1" runat="server" Height="98px" Width="418px" class="table table-table-hover" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDataBound="GridView1_RowDataBound" OnPageIndexChanged="Page_Load" OnSelectedIndexChanged="Page_Load">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
        <asp:Button ID="btn_ver" runat="server" OnClick="btn_ver_Click" Text="Ver Informacion Solicitante" class="btn btn-info" Height="41px" Width="254px"/>
    </div>
</asp:Content>
