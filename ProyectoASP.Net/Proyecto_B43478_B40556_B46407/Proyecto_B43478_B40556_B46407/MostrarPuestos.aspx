<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarPuestos.aspx.cs" Inherits="Proyecto_B43478_B40556_B46407.EmpresaEmpleadora.MostrarPuestos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="row">
        <div class="col-sm-6">
        <asp:Label ID="label3" runat="server" Font-Bold="True" ForeColor="Black"><h4>Puestos:</h4></asp:Label>
            
            <div class="row">
               &nbsp;&nbsp;&nbsp;
               <asp:Label ID="labelCategoria" runat="server" Font-Bold="True" ForeColor="Black"><h5>Categoría</h5></asp:Label>
            </div>
            
            <div class="row">
               &nbsp;&nbsp;&nbsp;
               <asp:Label ID="labelCantidad" runat="server" Font-Bold="True" ForeColor="Black"><h5>Cantidad: </h5></asp:Label>
            </div> 
        </div>
        <div class="col-sm-3"></div>
        <div class="col-sm-3"></div>
    </div>

     <div class="row">

          <div class="col-sm-12">

              <br />

             <asp:Label ID="label2" runat="server" Font-Bold="True" ForeColor="Black"><h4>Puestos disponibles</h4></asp:Label>

             <div class="table-responsive">

                 <asp:GridView ID="gvPuestos" class="table table-striped" runat="server" OnSelectedIndexChanged="gvPuestos_SelectedIndexChanged">
                     <Columns>
                         <asp:CommandField SelectText="Aplicar" ShowSelectButton="True" />
                     </Columns>
                 </asp:GridView>

            </div> 
         </div>

          <div class="col-sm-6"></div>
     </div>
</asp:Content>
