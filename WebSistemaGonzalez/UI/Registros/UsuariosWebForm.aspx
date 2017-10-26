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
        <title>Bootstrap Example</title>
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
                    <label for="id cliente">Id Cliente</label>
                </div>
            </div>
            <%-- Id Usuario --%>
            <div class="text-center">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="idClienteTextbox" runat="server" Width="190px" Height="33px" OnTextChanged="idClienteTextbox_TextChanged"></asp:TextBox>
                <asp:Button ID="Button4" runat="server" Text="Button" type="Button4" class="btn btn-Button4"/>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="֎" ValidationGroup="buscar" ControlToValidate="idClienteTextbox" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <%-- Nombres Usuario --%>
            <div class="text-center">
                <div>
                    <label for="Nombres Usuario">Nombres Usuario</label>
                </div>
            </div>
            <div class="text-center">
                <asp:TextBox ID="NombreUsuarioTextBox" runat="server" Width="190px" Height="33px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="֎" ValidationGroup="buscar" ControlToValidate="NombreUsuarioTextBox" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <%-- Nombres --%>
            <div class="text-center">
                <div>
                    <label for="Nombres">Nombres</label>
                </div>
            </div>
            <div class="text-center">
                <asp:TextBox ID="TextBox1" runat="server" Width="190px" Height="33px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="֎" ValidationGroup="buscar" ControlToValidate="NombreUsuarioTextBox" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <%-- Contraseña --%>
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

                
                <asp:Button ID="Button1" runat="server" Text="Button1" type="Button1" class="btn btn-Button1" /> 
                <asp:Button ID="Button2" runat="server" Text="Button" type="Button2" class="btn btn-Button2" />
                <asp:Button ID="Button3" runat="server" Text="Button" type="Button3" class="btn btn-Button3" />

                
    </body>
    </html>
</asp:Content>
