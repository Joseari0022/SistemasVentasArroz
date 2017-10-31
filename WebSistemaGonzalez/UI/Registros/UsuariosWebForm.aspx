<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="UsuariosWebForm.aspx.cs" Inherits="WebSistemaGonzalez.UI.Registros.UsuariosWebForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        </style>
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
    </head>
    <body>

        <div class="container">
            <h2 class="auto-style1">Registro Usuarios</h2>
            
            <div class="text-center">
                <div>
                    <label for="id Usuario">Id Usuario</label>
                </div>
            </div>
            <%-- Fecha --%>
            <div class="text-center">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="idUsuarioTextbox" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Button ID="BuscarButton" runat="server" Text="Buscar" type="Button4" class="btn btn-Button4" Width="88px" OnClick="BuscarButton_Click"/>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="֎" ValidationGroup="buscar" ControlToValidate="idUsuarioTextbox" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <%-- Fecha --%>
            <div class="text-center">
                <div>
                    <label for="Nombres Usuario">Nombres Usuario</label>
                </div>
            </div>
            <div class="text-center">
                <asp:TextBox ID="NombreUsuarioTextBox" runat="server" Width="190px" Height="33px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="֎" ValidationGroup="buscar" ControlToValidate="NombreUsuarioTextBox" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <%-- Fecha --%>
            <div class="text-center">
                <div>
                    <label for="Nombres">Nombres</label>
                </div>
            </div>
            <div class="text-center">
                <asp:TextBox ID="NombresTextBox" runat="server" Width="190px" Height="33px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="֎" ValidationGroup="buscar" ControlToValidate="NombreUsuarioTextBox" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <%-- Fecha --%>
            <div class="text-center">
                <div>
                    <label for="Contraseña">Contraseña</label>
                </div>
            </div>
            <div class="text-center">
                <asp:TextBox ID="ContraseñaTextBox" runat="server" Width="190px" Height="33px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="֎" ValidationGroup="buscar" ControlToValidate="ContraseñaTextBox" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <%-- Fecha --%>
            <div class="text-center">
                <div>
                    <label for="Fecha">Fecha</label>
                </div>
            </div>
            <div class="text-center">
                <asp:TextBox ID="FechaTextBox" runat="server" Width="190px" Height="33px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="֎" ValidationGroup="buscar" ControlToValidate="FechaTextBox" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <br />

            <!--botones del formulario-->

            <div class="text-center">

                
                <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" type="Button1" class="btn btn-Button1" OnClick="NuevoButton_Click" Width="88px" /> 
                <asp:Button ID="GuardarButton" runat="server" Text="Guardar" type="Button2" class="btn btn-Button2" Width="88px" OnClick="GuardarButton_Click" />
                <asp:Button ID="EliminarButton" runat="server" Text="Eliminar'" type="Button3" class="btn btn-Button3" Width="88px" OnClick="EliminarButton_Click" />

                
    </body>
    </html>
</asp:Content>
