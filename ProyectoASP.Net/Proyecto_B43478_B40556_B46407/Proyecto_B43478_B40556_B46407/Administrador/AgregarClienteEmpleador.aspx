<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AgregarClienteEmpleador.aspx.cs" Inherits="Proyecto_B43478_B40556_B46407.Administrador.AgregarClienteEmpleador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <br />
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:Label ID="l8" runat="server" class="label label-info" Text="Ingrese los datos del Cliente Empleador" Font-Italic="True" Font-Size="18px"></asp:Label>
     <br />
     <br />

    <div class="row" id="fila">

        <div class="col-sm-5">            
            <asp:TextBox ID="tbCedula" runat="server" placeholder="Cédula" class="form-control"></asp:TextBox>
        </div>
                     
        <div class="col-sm-5">
        <asp:TextBox ID="tbNombre" runat="server" placeholder="Nombre" class="form-control"></asp:TextBox><br />

        </div>
     </div> 
     <div class="row" id="fila">

        <div class="col-sm-5">            
            <asp:TextBox ID="tbCompania" runat="server" placeholder="Empresa" class="form-control"></asp:TextBox>
        </div>
                     
        <div class="col-sm-5">
        <asp:TextBox ID="tbAsignacion" runat="server" placeholder="Asignación" class="form-control"></asp:TextBox><br />

        </div>
    </div> 

    <div class="row" id="fila">

        <div class="col-sm-5">            
            <asp:TextBox ID="tbProvincia" runat="server" placeholder="Provincia" class="form-control"></asp:TextBox>
        </div>
                     
        <div class="col-sm-5">
        <asp:TextBox ID="tbCanton" runat="server" placeholder="Cantón" class="form-control"></asp:TextBox><br />

        </div>
    </div>

    <div class="row" id="fila">

        <div class="col-sm-5">            
            <asp:TextBox ID="tbDireccion" runat="server" placeholder="Dirección" class="form-control"></asp:TextBox>
        </div>
                     
        <div class="col-sm-5">
        <asp:TextBox ID="tbCorreo" runat="server" placeholder="Correo" class="form-control"></asp:TextBox><br />

        </div>
    </div>

    <div class="row" id="fila">

        <div class="col-sm-5">            
            <asp:TextBox ID="tbTelefono" runat="server" placeholder="Teléfono" class="form-control"></asp:TextBox>
        </div>
                     
        <div class="col-sm-5">
        <asp:TextBox ID="tbExt" runat="server" placeholder="Extensión" class="form-control"></asp:TextBox><br />

        </div>
    </div>

    <div class="row" id="fila">

        <div class="col-sm-5">            
            <asp:TextBox ID="tbFax" runat="server" placeholder="Fax" class="form-control"></asp:TextBox>
        </div>
                     
        <div class="col-sm-5">
        <asp:TextBox ID="tbCodigo" runat="server" placeholder="Código Postal" class="form-control"></asp:TextBox><br />

        </div>
    </div>
                    
    <div class="row" id="fila">
        <div class="col-sm-4">
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" class="btn btn-primary" OnClick="btnAgregar_Click" />
        </div>
    </div>
</asp:Content>
