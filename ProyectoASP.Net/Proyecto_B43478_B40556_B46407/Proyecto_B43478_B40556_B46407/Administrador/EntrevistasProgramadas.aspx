<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/AdministratorPage.Master" AutoEventWireup="true" CodeBehind="EntrevistasProgramadas.aspx.cs" Inherits="Proyecto_B43478_B40556_B46407.Administrador.EntrevistasProgramadas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
  	<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.2/jquery.min.js"></script>
	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-3 col-sm-offset-2">
        <h2>Entrevistas Programadas</h2>
        <p>&nbsp;</p>
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="Page_Load" OnLoad="Page_Load" OnPageIndexChanged="Page_Load" OnRowDataBound="GridView1_RowDataBound" OnSorted="Page_Load" CellPadding="4" ForeColor="#333333" GridLines="None" Height="123px" Width="266px" >
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
        <asp:Button ID="btn_consultar" runat="server" OnClick="btn_consultar_Click" Text="Consultar" class="btn btn-info"/>
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Solicitante: " style="color:cornflowerblue"></asp:Label>
        <asp:Label ID="lb_solicitante" runat="server" Text="Label"></asp:Label>
    
        <br />
        <asp:Label ID="Label2" runat="server" Text="Puesto: " style="color:cornflowerblue"></asp:Label>
    
        <asp:Label ID="lb_puesto" runat="server" Text="Label"></asp:Label>
    
        <br/>
    
        <asp:Label ID="Label3" runat="server" Text="Tipo Entrevista:" style="color:cornflowerblue"></asp:Label>
        &nbsp;<asp:Label ID="lb_tipo" runat="server" Text="Label"></asp:Label>
   
        <br/>
        <asp:Label ID="Label4" runat="server" Text="Lugar: " style="color:cornflowerblue"></asp:Label>
    &nbsp;<asp:Label ID="lb_lugar" runat="server" Text="Label"></asp:Label>
    
        <br/>
    </div>
</asp:Content>
