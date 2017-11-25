<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="ProductosWebForm.aspx.cs" Inherits="WebSistemaGonzalez.UI.Registros.ProductosWebForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!DOCTYPE html>
    <html>
    <head>
        <title>Registro Producto</title>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

        <%--toastr--%>
       

    </head>
    <body>

        <div class="container">
            <div class="text-center">
                <h2 class="auto-style1">Registro Producto</h2>

                <%-- Fecha --%>
                <div class="text-center">
                    <div>
                        <label for="Id Producto">Id Producto</label>
                    </div>
                </div>
                <div class="text-center">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="IdProductoTextBox" runat="server" Width="190px" Height="33px"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="BuscarButton" runat="server" OnClick="BuscarButton_Click" Text="Buscar" class="btn btn-Button4" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="**" ValidationGroup="buscar" ControlToValidate="IdProductoTextBox" Font-Bold="True" ForeColor="Black"></asp:RequiredFieldValidator>
                </div>
                <%-- Fecha --%>
                <div class="text-center">
                    <div>
                        <label for="Descripcion">Descripcion</label>
                    </div>
                </div>
                <div class="text-center">
                    <asp:TextBox ID="DescripcionTextBox" runat="server" Width="190px" Height="33px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="**" ValidationGroup="buscar" ControlToValidate="DescripcionTextBox" Font-Bold="True" ForeColor="Black"></asp:RequiredFieldValidator>
                </div>
                <%-- Fecha --%>
                <div class="text-center">
                    <div>
                        <label for="Cantidad">Cantidad</label>
                    </div>
                </div>
                <div class="text-center">
                    <asp:TextBox ID="CantidadTextBox" runat="server" Width="190px" Height="33px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="**" ValidationGroup="buscar" ControlToValidate="CantidadTextBox" Font-Bold="True" ForeColor="Black"></asp:RequiredFieldValidator>
                </div>
                <%-- Fecha --%>
                <div class="text-center">
                    <div>
                        <label for="Precio">Precio</label>
                    </div>
                </div>
                <div class="text-center">
                    <asp:TextBox ID="PrecioTextBox" runat="server" Width="190px" Height="33px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="**" ValidationGroup="buscar" ControlToValidate="PrecioTextBox" Font-Bold="True" ForeColor="Black"></asp:RequiredFieldValidator>
                </div>
                <%-- Fecha --%>
                <div class="text-center">
                    <div>
                        <label for="Fecha">Fecha</label>
                    </div>
                </div>
                <div class="text-center">
                    <asp:TextBox ID="FechaTextBox" runat="server" Width="190px" Height="33px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="**" ValidationGroup="buscar" ControlToValidate="FechaTextBox" Font-Bold="True" ForeColor="Black"></asp:RequiredFieldValidator>
                    <br />
                    <br />
                </div>


                <!--botones del formulario-->

                <div class="text-center">


                    <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" class="btn btn-Button4" OnClick="NuevoButton_Click" />
                    <asp:Button ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click" class="btn btn-Button4" />
                    <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" class="btn btn-Button4" OnClick="EliminarButton_Click" />


                    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</asp:Content>
