<%@ Page Title="" Language="C#" MasterPageFile="~/AdministratorPage.Master" AutoEventWireup="true" CodeBehind="AgregarContactoEmpleador.aspx.cs" Inherits="Proyecto_B43478_B40556_B46407.Administrador.AgregarContactoEmpleador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:Label ID="l8" runat="server" class="label label-info" Text="Ingrese los datos del Cliente Empleador" Font-Italic="True" Font-Size="18px"></asp:Label>
     <br />
     <br />

    <div class="row" id="fila1">

        <div class="col-sm-5"> 
            <label class="text-base" for="tbCedula">Cédula</label>           
            <asp:TextBox ID="tbCedula" runat="server" class="form-control" TextMode="Number" min="1"></asp:TextBox>
            <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server"
                ControlToValidate="tbCedula"
                ErrorMessage="Campo Requerido."
                ForeColor="Red">
           </asp:RequiredFieldValidator>
        </div>
                     
        <div class="col-sm-5">
            <label class="text-base" for="tbNombre">Nombre</label>  
            <asp:TextBox ID="tbNombre" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server"
                ControlToValidate="tbNombre"
                Display = "Dynamic"
                ErrorMessage="Campo Requerido.<br/>"
                ForeColor="Red">
            </asp:RequiredFieldValidator><br/>
        </div>
     </div> 
     <div class="row" id="fila2">
                     
        <div class="col-sm-5">

            <label class="text-base" for="tbAsignacion">Asignación</label> 
            <asp:TextBox ID="tbAsignacion" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator id="RequiredFieldValidator3" runat="server"
                ControlToValidate="tbAsignacion"
                ErrorMessage="Campo Requerido."
                ForeColor="Red">
            </asp:RequiredFieldValidator>

        </div>

         <div class="col-sm-5">

            <label class="text-base" for="tbCorreo">Correo</label> 
            <asp:TextBox ID="tbCorreo" runat="server" class="form-control" TextMode="Email"></asp:TextBox>
             <asp:RequiredFieldValidator id="RequiredFieldValidator4" runat="server"
                ControlToValidate="tbCorreo"
                Display = "Dynamic"
                ErrorMessage="Campo Requerido.<br/>"
                ForeColor="Red">
            </asp:RequiredFieldValidator><br/>
        </div>
    </div> 

    <div class="row" id="fila3">

        <div class="col-sm-5">
             
            <label class="text-base" for="tbTelefono">Teléfono</label>            
            <asp:TextBox ID="tbTelefono" runat="server" class="form-control" TextMode="Number" min="1"></asp:TextBox>
             <asp:RequiredFieldValidator id="RequiredFieldValidator5" runat="server"
                ControlToValidate="tbTelefono"
                Display = "Dynamic"
                ErrorMessage="Campo Requerido."
                ForeColor="Red">
            </asp:RequiredFieldValidator>
        
        </div>

                     
        <div class="col-sm-5">

            <label class="text-base" for="tbExt">Extensión</label> 
            <asp:TextBox ID="tbExt" runat="server" class="form-control" TextMode="Number" min="1"></asp:TextBox><br/>
            <asp:RequiredFieldValidator id="RequiredFieldValidator6" runat="server"
                ControlToValidate="tbExt"
                Display = "Dynamic"
                ErrorMessage="<br/>"
                ForeColor="Red">
            </asp:RequiredFieldValidator>
        </div>
    </div>

    <div class="row" id="fila4">

        <div class="col-sm-5">
             
            <label class="text-base" for="tbUsuario">Usuario</label>            
            <asp:TextBox ID="tbUsuario" runat="server" class="form-control"></asp:TextBox>
             <asp:RequiredFieldValidator id="RequiredFieldValidator7" runat="server"
                ControlToValidate="tbUsuario"
                Display = "Dynamic"
                ErrorMessage="Campo Requerido."
                ForeColor="Red">
            </asp:RequiredFieldValidator>
        
        </div>

                     
        <div class="col-sm-5">

            <label class="text-base" for="tbContrasena">Contraseña</label>    
            <asp:TextBox ID="tbContrasena" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator id="RequiredFieldValidator8" runat="server"
                ControlToValidate="tbContrasena"
                Display = "Dynamic"
                ErrorMessage="Campo Requerido.<br/>"
                ForeColor="Red">
            </asp:RequiredFieldValidator><br/>
        </div>
    </div>

    <div class="row" id="fila5">

        <div class="col-sm-5">
            <label class="text-base" for="tbFax">Fax</label>    
            <asp:TextBox ID="tbFax" runat="server" class="form-control"></asp:TextBox><br/>
        </div>
                     
    </div>
                    
    <div class="row" id="fila">
        <div class="col-sm-4">
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" class="btn btn-primary" OnClick="btnAgregar_Click" />
        </div>
    </div>
</asp:Content>
