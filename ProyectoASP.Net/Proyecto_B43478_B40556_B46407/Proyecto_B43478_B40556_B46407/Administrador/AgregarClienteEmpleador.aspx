<%@ Page Title="" Language="C#" MasterPageFile="~/AdministratorPage.Master" AutoEventWireup="true" CodeBehind="AgregarClienteEmpleador.aspx.cs" Inherits="Proyecto_B43478_B40556_B46407.Administrador.AgregarClienteEmpleador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br />
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:Label ID="l8" runat="server" class="label label-info" Text="Registrar Empresa" Font-Italic="True" Font-Size="18px"></asp:Label>
     <br />
     <br />

     <div class="row" id="fila1">

        <div class="col-sm-5">
            <label class="text-base" for="tbCompania">Empresa</label>             
            <asp:TextBox ID="tbCompania" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server"
                ControlToValidate="tbCompania"
                Display = "Dynamic"
                ErrorMessage="Campo Requerido.<br/>"
                ForeColor="Red">
            </asp:RequiredFieldValidator><br/>
        </div>
                     
    </div> 
<label class="text-base"><h3>Ubicación</h3></label> <br />

    <div class="row" id="fila15">

        <div class="row">

            <div class="col-sm-5">

                <div class="col-sm-3">

                    <label class="text-base" for="tbProvincia">Provincia: </label>

                </div>

                <div class="col-sm-9">
                       
                    <asp:TextBox ID="tbProvincia" runat="server" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator id="RequiredFieldValidator10" runat="server"
                        ControlToValidate="tbProvincia"
                        Display = "Dynamic"
                        ErrorMessage="Campo Requerido.<br/>"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator><br/>
              </div>

            </div>
            
        </div>                     
    </div>

    <div class="row" id="fila3">

        <div class="row">

            <div class="col-sm-5">

                <div class="col-sm-3">

                    <label class="text-base" for="tbCiudad">Ciudad: </label>

                </div>

                <div class="col-sm-9">
                       
                    <asp:TextBox ID="tbCiudad" runat="server" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator id="RequiredFieldValidator11" runat="server"
                        ControlToValidate="tbCiudad"
                        Display = "Dynamic"
                        ErrorMessage="Campo Requerido.<br/>"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator><br/>
              </div>

            </div>
            
        </div>                     
    </div>

    
    <div class="row" id="fila4">

        <div class="row">

            <div class="col-sm-5">

                <div class="col-sm-3">

                    <label class="text-base" for="tbDireccion">Dirección: </label>

                </div>

                <div class="col-sm-9">
                       
                    <asp:TextBox ID="tbDireccion" runat="server" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator id="RequiredFieldValidator3" runat="server"
                        ControlToValidate="tbDireccion"
                        Display = "Dynamic"
                        ErrorMessage="Campo Requerido.<br/>"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator><br/>
              </div>

            </div>
            
        </div>                     
    </div>

    <div class="row" id="fila5">
                     
        <div class="col-sm-5">
        <label class="text-base" for="tbDireccion">Código Postal</label> 
        <asp:TextBox ID="tbCodigo" runat="server" class="form-control" TextMode="Number" min="1"></asp:TextBox><br />

        </div>
    </div>
                    
    <div class="row" id="fila">
        <div class="col-sm-4">
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" class="btn btn-primary" OnClick="btnAgregar_Click" />
        </div>
    </div>
</asp:Content>
