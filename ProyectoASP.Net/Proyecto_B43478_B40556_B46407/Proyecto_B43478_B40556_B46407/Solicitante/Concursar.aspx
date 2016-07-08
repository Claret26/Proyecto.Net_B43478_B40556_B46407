<%@ Page Title="" Language="C#" MasterPageFile="~/SolicitantePage.Master" AutoEventWireup="true" CodeBehind="Concursar.aspx.cs" Inherits="Proyecto_B43478_B40556_B46407.Solicitante.Concursar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-sm-6">

            <div class="col-sm-2"></div>

            <div class="col-sm-8">
             <asp:Label ID="label2" runat="server" Font-Bold="True" ForeColor="Black"><h3>Concursar para plaza</h3></asp:Label><br />
           </div>

            <div class="col-sm-2"></div>

        </div>
    </div>

    <div class="row">
        <div class="col-sm-6">


            <div class="row">
               &nbsp;&nbsp;&nbsp;
               <asp:Label ID="labelPuesto" runat="server" Font-Bold="True" ForeColor="Black"><h5>Puesto</h5></asp:Label>
            </div>
            
            <div class="row">
               &nbsp;&nbsp;&nbsp;
               <asp:Label ID="labelEmpresa" runat="server" Font-Bold="True" ForeColor="Black"><h5>Empresa: </h5></asp:Label>
            </div><br />

            <div class="row">
               &nbsp;&nbsp;&nbsp;
               <asp:Label ID="labelPostulante" runat="server" Font-Bold="True" ForeColor="Black"><h5>Postulante: </h5></asp:Label>
            </div>

            <div class="row">
               &nbsp;&nbsp;&nbsp;
               <asp:Label ID="labelTel" runat="server" Font-Bold="True" ForeColor="Black"><h5>Teléfono: </h5></asp:Label>
            </div> 

            <div class="row">
               &nbsp;&nbsp;&nbsp;
               <asp:Label ID="labelMail" runat="server" Font-Bold="True" ForeColor="Black"><h5>Correo: </h5></asp:Label>
            </div> 

            <div class="row">
               &nbsp;&nbsp;&nbsp;
               <asp:Label ID="label1" runat="server" Font-Bold="True" ForeColor="Black"><h4>Datos adicionales: </h4></asp:Label>
            </div> 

            <div class="row">
               &nbsp;&nbsp;&nbsp;

                <textarea id="TextArea1" class="form-control" cols="20" name="S1" rows="5"></textarea><br />

            </div> 

            <div class="row">

                <div class="col-sm-2"></div>
                <div class="col-sm-8">
                    <asp:Button ID="btnConcursar" class="btn btn-success btn-block" runat="server" Text="Concursar" />
                </div>
                <div class="col-sm-2"></div>
           
            </div>

        </div>
        <div class="col-sm-3"></div>
        <div class="col-sm-3"></div>
    </div>
</asp:Content>