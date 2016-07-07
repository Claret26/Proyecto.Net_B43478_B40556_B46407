<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Proyecto_B43478_B40556_B46407.Principal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-sm-5">
        <asp:Label ID="label3" runat="server" Font-Bold="True" ForeColor="Black"><h4>Búsqueda específica</h4></asp:Label><br />
            <div class="row">

               <div class="col-sm-5">

                        <label class="text-base">Caregoría: </label>

                    </div>

                    <div class="col-sm-7">
                       <asp:DropDownList ID="ddlCategorias" class="form-control" runat="server" AutoPostBack="True">
                       </asp:DropDownList><br />
                    </div> 
            </div>
            
            <div class="row">

               <div class="col-sm-5">

                        <label class="text-base" for="tbPalabra">Palabra Clave: </label>

                    </div>

                    <div class="col-sm-7">
                        <asp:TextBox ID="tbPalabra" runat="server" class="form-control"></asp:TextBox><br />
                    </div> 
            </div>
            
            <div class="row">
                <div class="col-sm-5">
                         <asp:Button ID="btnBuscar" runat="server" Text="Buscar" class="btn btn-primary" OnClick="btnBuscar_Click" /><br /><br /><br /><br />
                </div>
          </div>  
        </div>
        <div class="col-sm-4"></div>
        <div class="col-sm-4"></div>
    </div>

     <div class="row">

         <div class="col-sm-1"></div>

          <div class="col-sm-5">

             <asp:Label ID="label2" runat="server" Font-Bold="True" ForeColor="Black"><h4>Cantidad de puestos disponibles</h4></asp:Label>

             <div class="table-responsive">

                 <asp:GridView ID="gvPuestos" class="table table-striped" runat="server">
                 </asp:GridView>

            </div> 
         </div>

          <div class="col-sm-5">

              <asp:Label ID="label1" runat="server" Font-Bold="True" ForeColor="Black"><h4>Cantidad de puestos ofertados</h4></asp:Label>

             <div class="table-responsive">

                 <asp:GridView ID="gvOfertados" class="table table-striped" runat="server">
                 </asp:GridView>

            </div> 
        </div>
     </div>

</asp:Content>
