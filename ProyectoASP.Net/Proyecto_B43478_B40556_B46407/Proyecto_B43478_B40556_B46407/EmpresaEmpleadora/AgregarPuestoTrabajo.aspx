<%@ Page Title="" Language="C#" MasterPageFile="~/Cliente.Master" AutoEventWireup="true" CodeBehind="AgregarPuestoTrabajo.aspx.cs" Inherits="Proyecto_B43478_B40556_B46407.EmpresaEmpleadora.AgregarPuestoTrabajo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
     <asp:Label ID="l8" runat="server" class="label label-info" Text="Nuevo Puesto" Font-Italic="True" Font-Size="18px"></asp:Label>
     <br />
     <br />

      <div class="row" id="fila0">

        <div class="col-sm-5">
            <label class="text-base" for="ddlCategorias">Categoria</label>             
            <asp:DropDownList ID="ddlCategorias" class="form-control" runat="server" AutoPostBack="True">
            </asp:DropDownList><br/>
        </div>               
    </div>

     <div class="row" id="fila1">

        <div class="col-sm-5">
            <label class="text-base" for="tbDescripcion">Descripción del Puesto</label>             
            <asp:TextBox ID="tbDescripcion" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server"
                ControlToValidate="tbDescripcion"
                Display = "Dynamic"
                ErrorMessage="Campo Requerido.<br/>"
                ForeColor="Red">
            </asp:RequiredFieldValidator><br/>
        </div>               
    </div> 

    <div class="row" id="fila2">

        <div class="col-sm-5">
            <label class="text-base" for="tbexperiencia">Años de experiencia requeridos</label>            
            <asp:TextBox ID="tbexperiencia" runat="server" class="form-control" TextMode="Number" min="0"></asp:TextBox>
            <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server"
                ControlToValidate="tbexperiencia"
                Display = "Dynamic"
                ErrorMessage="Campo Requerido.<br/>"
                ForeColor="Red">
            </asp:RequiredFieldValidator><br/>
        </div>
                     
    </div>

    <div class="row" id="fila6">

        <div class="col-sm-5">
            <label class="text-base" for="tbVacantes">Puestos Vacantes</label>            
            <asp:TextBox ID="tbVacantes" runat="server" class="form-control" TextMode="Number" min="1"></asp:TextBox>
            <asp:RequiredFieldValidator id="RequiredFieldValidator5" runat="server"
                ControlToValidate="tbVacantes"
                Display = "Dynamic"
                ErrorMessage="Campo Requerido.<br/>"
                ForeColor="Red">
            </asp:RequiredFieldValidator><br/>
        </div>
                     
    </div>

    <div class="row" id="fila7">

        <div class="col-sm-5">
            <label class="text-base" for="tbDias">Días a laborar</label>            
            <asp:TextBox ID="tbDias" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator id="RequiredFieldValidator6" runat="server"
                ControlToValidate="tbDias"
                Display = "Dynamic"
                ErrorMessage="Campo Requerido.<br/>"
                ForeColor="Red">
            </asp:RequiredFieldValidator><br/>
        </div>
                     
    </div>

    <div class="row" id="fila8">

        <div class="col-sm-5">
            <label class="text-base" for="tbHora">Hora de entrada</label>            
            <asp:TextBox ID="tbHora" runat="server" class="form-control" TextMode="Time"></asp:TextBox>
            <asp:RequiredFieldValidator id="RequiredFieldValidator7" runat="server"
                ControlToValidate="tbHora"
                Display = "Dynamic"
                ErrorMessage="Campo Requerido.<br/>"
                ForeColor="Red">
            </asp:RequiredFieldValidator><br/>
        </div>
                     
    </div>

    <div class="row" id="fila9">

        <div class="col-sm-5">
            <label class="text-base" for="tbSalida">Hora de salida</label>            
            <asp:TextBox ID="tbSalida" runat="server" class="form-control" TextMode="Time"></asp:TextBox>
            <asp:RequiredFieldValidator id="RequiredFieldValidator8" runat="server"
                ControlToValidate="tbSalida"
                Display = "Dynamic"
                ErrorMessage="Campo Requerido.<br/>"
                ForeColor="Red">
            </asp:RequiredFieldValidator><br/>
        </div>
                     
    </div>

    <div class="row" id="fila10">

        <div class="col-sm-5">
            <label class="text-base" for="tbSalario">Salario</label>            
            <asp:TextBox ID="tbSalario" runat="server" class="form-control" placeholder="$" TextMode="Number" min="0"></asp:TextBox>
            <asp:RequiredFieldValidator id="RequiredFieldValidator9" runat="server"
                ControlToValidate="tbSalario"
                Display = "Dynamic"
                ErrorMessage="Campo Requerido.<br/>"
                ForeColor="Red">
            </asp:RequiredFieldValidator><br/>
        </div>
                     
    </div>

    <label class="text-base" ><h4>Ubicación</h4></label><br />

    <div class="row" id="fila5">

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
                    
    <div class="row" id="fila">
        <div class="col-sm-4">
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" class="btn btn-primary" OnClick="btnAgregar_Click" />
        </div>
    </div>

</asp:Content>
