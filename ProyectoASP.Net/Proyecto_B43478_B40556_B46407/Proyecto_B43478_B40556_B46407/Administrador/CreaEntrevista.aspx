<%@ Page Title="" Language="C#" MasterPageFile="~/AdministratorPage.Master" AutoEventWireup="true" CodeBehind="CreaEntrevista.aspx.cs" Inherits="Proyecto_B43478_B40556_B46407.Administrador.CreaEntrevista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
  	<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.2/jquery.min.js"></script>
	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-3 col-sm-offset-2">
       <label>Solicitante: </label> <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

        <br />
        <label>Puestos:</label><br/>
        <asp:DropDownList ID="ddl_puestos" runat="server"  class="form-control">
        </asp:DropDownList>
        <br />
        <br />
        <label>Fecha:</label><br/>
       <asp:TextBox ID="tb_fecha"  type="date" runat="server" class="form-control"></asp:TextBox>
        <br />
        <br />
        <label>Hora:
        </label>
        <br />
        <asp:TextBox ID="tb_hora" runat="server" type="time" class="form-control"></asp:TextBox>
        <br />
        <br />
        <label>Tipo:</label><br/>
        <asp:DropDownList ID="ddl_tipo" runat="server"  class="form-control">
            <asp:ListItem Text="Personal" Value="Presencial"></asp:ListItem>
            <asp:ListItem Text="No personal" Value="Presencial Practica"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <label>Lugar:</label>
        

        <br />
        <asp:TextBox ID="tb_lugar" runat="server" class="form-control"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btn_crear" runat="server" OnClick="btn_crear_Click" Text="Crear"   class="btn btn-info"/>
        

     </div>


</asp:Content>
