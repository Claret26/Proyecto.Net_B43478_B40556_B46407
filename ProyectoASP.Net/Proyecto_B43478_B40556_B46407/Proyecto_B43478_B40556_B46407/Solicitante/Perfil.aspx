<%@ Page Title="" Language="C#" MasterPageFile="~/SolicitantePage.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="Proyecto_B43478_B40556_B46407.Solicitante.Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
  	<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.2/jquery.min.js"></script>
	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="col-md-3 col-sm-offset-2">
        <h2 style="color:dodgerblue">Perfil</h2>

        
        <label id="label_nombre">Nombre:</label>
        <asp:Label ID="lb_nombre" runat="server" Text="Label"></asp:Label>
        <br>
        <label>Apellidos: </label>
        <asp:Label ID="lb_apellidos" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <br>
         <label>Direccion:</label>&nbsp;
         <asp:Label ID="lb_direcion" runat="server" Text="Label"></asp:Label>
         
         <br/>
         <label>Numero celular:</label><asp:Label ID="lb_celular" runat="server" Text="Label"></asp:Label>
         <br/>
          <label>Telefono Casa:</label><asp:Label ID="lb_casa" runat="server" Text="Label"></asp:Label>
         
         <br/>
          <label>Fecha Naciminto:</label><asp:Label ID="lb_fechaNacimiento" runat="server" Text="Label"></asp:Label>
         <br/>

        <h3>Titulos</h3><br>
    
        <asp:DropDownList ID="ddl_titulosExistentes" runat="server"  class="form-control">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="btn_eliminar" runat="server" OnClick="btn_eliminar_Click" class="btn btn-danger" Text="X" Height="31px" Width="46px" />
        &nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;<br />
        <br />
        
        
            <label>Agregar titulos</label><br/><br/>
            
            <label>Especialidad: </label><asp:DropDownList ID="ddl_areaEspecialidad" runat="server" class="form-control">
            </asp:DropDownList>
            <br />
            <label>Instirucion: </label><asp:DropDownList ID="ddl_InstitucionEstudio" runat="server" class="form-control">
            </asp:DropDownList>
            <br />
            <label>Nivel estudio: </label><asp:DropDownList ID="ddl_nivelEstudio" runat="server" class="form-control">
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Ano Inicio   / Ano Finalizacion"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Width="43px" class="form-control"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="--"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Width="52px" class="form-control"></asp:TextBox>
            <br />
            <label>Nombre titulo: </label><asp:TextBox ID="TextBox3" runat="server" class="form-control"></asp:TextBox>
            <br />
            <br />
&nbsp;

        <asp:Button ID="btn_agregar" runat="server" OnClick="btn_agregar_Click" Text="Agregar"  class="btn btn-info"/>
        <br>


        </div>
</asp:Content>
