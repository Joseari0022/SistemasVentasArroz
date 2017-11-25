<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="ClientesWebForm.aspx.cs" Inherits="WebSistemaGonzalez.UI.Registros.ClientesWebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!DOCTYPE html>

    <html>
    <head>
        <title>Registro Usuario</title>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

        <%-- Fecha --%>
        <script src="//code.jquery.com/jquery-3.1.1.min.js"></script>
        <script src="/Toastr/toastr.min.js"></script>
        <link href="/Toastr/toastr.min.css" rel="stylesheet" />
        <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/angularjs/1.0.7/angular.min.js"></script>

    </head>
    <body>
        <div class="text-center">
            <div class="container">
                <h2 class="auto-style1">Registro Clientes</h2>

            <%-- Fecha --%>
            <div class="text-center">
                <div>
                    <label for="id Usuario">Id Cliente</label>
                </div>
            </div>
            <div class="text-center">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="idClienteTextbox" runat="server" Width="190px" Height="33px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="BuscarButton" runat="server" Text="Buscar" class="btn btn-Button4" OnClick="BuscarButton_Click" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="**" ValidationGroup="buscar" ControlToValidate="idClienteTextbox" Font-Bold="True" ForeColor="Black"></asp:RequiredFieldValidator>
            </div>
                <%-- Fecha --%>
            <div class="text-center">
                <div>
                    <label for="Nombres Usuario">Nombres</label>
                </div>
            </div>
            <div class="text-center">
                <asp:TextBox ID="NombreTextBox" runat="server" Width="190px" Height="33px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="**" ValidationGroup="buscar" ControlToValidate="NombreTextBox" Font-Bold="True" ForeColor="Black"></asp:RequiredFieldValidator>
            </div>
                <%-- Fecha --%>
            <div class="text-center">
                <div>
                    <label for="Nombres">Cedula</label>
                </div>
            </div>
            <div class="text-center">
                <asp:TextBox ID="CedulaTextBox" runat="server" Width="190px" Height="33px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="**" ValidationGroup="buscar" ControlToValidate="CedulaTextBox" Font-Bold="True" ForeColor="Black"></asp:RequiredFieldValidator>
            </div>
                <%-- Fecha --%>
            <div class="text-center">
                <div>
                    <label for="Contraseña">Direccion</label>
                </div>
            </div>
            <div class="text-center">
                <asp:TextBox ID="DireccionTextBox" runat="server" Width="190px" Height="33px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="**" ValidationGroup="buscar" ControlToValidate="DireccionTextBox" Font-Bold="True" ForeColor="Black"></asp:RequiredFieldValidator>
            </div>
                <%-- Fecha --%>
            <div class="text-center">
                <div>
                    <label for="Contraseña">Telefono</label>
                </div>
            </div>
            <div class="text-center">
                <asp:TextBox ID="TelefonoTextBox" runat="server" Width="190px" Height="33px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="**" ValidationGroup="buscar" ControlToValidate="TelefonoTextBox" Font-Bold="True" ForeColor="Black"></asp:RequiredFieldValidator>
            </div>
                <%-- Fecha --%>
            <div class="text-center">
                <div>
                    <label for="Fecha">Fecha Nacimiento<br />
                    </label>
                &nbsp;</div>
            </div>
            <div class="text-center">
                <asp:TextBox ID="FechaTextBox" runat="server" Width="190px" Height="33px" TextMode="Date"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="**" ValidationGroup="buscar" ControlToValidate="FechaTextBox" Font-Bold="True" ForeColor="Black"></asp:RequiredFieldValidator>
            </div>
                <%-- Fecha --%>
            <div class="text-center">
                <div>
                    <label for="Fecha">Fecha</label>
                </div>
            </div>
            <div class="text-center">
                <asp:TextBox ID="FechaCreacTextBox" runat="server" Width="190px" Height="33px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="**" ValidationGroup="buscar" ControlToValidate="FechaCreacTextBox" Font-Bold="True" ForeColor="Black"></asp:RequiredFieldValidator>
            </div>
            <br />

            <!--botones del formulario-->

            <div class="text-center">


    </body>
    </html>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
        <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" class="btn btn-Button4" OnClick="NuevoButton_Click" />
        <asp:Button ID="GuardarButton" runat="server" Text="Guardar" class="btn btn-Button4" OnClick="GuardarButton_Click" />
        <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" class="btn btn-Button4" OnClick="EliminarButton_Click" />
     </div>
     </div>
     </div>
</asp:Content>
