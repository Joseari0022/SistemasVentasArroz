﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="FacturasWebForm.aspx.aspx.cs" Inherits="WebSistemaGonzalez.UI.Registros.FacturasWebForm2aspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }

        .auto-style2 {
            margin-left: 40;
        }

        .auto-style3 {
            margin-left: 0;
        }

        .auto-style4 {
            text-align: center;
            height: 81px;
        }
        .auto-style5 {
            height: 50px;
        }
        
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2 class="auto-style1">Factura</h2>
        <%-- agregar --%>
        <div class="text-center">
            <div>
                <label for="Id Factura">Id Factura</label>
            </div>
        </div>
        <div class="text-center">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="IdFacturaTextBox" runat="server" Width="190px" Height="33px"></asp:TextBox>
            <asp:Button ID="BuscarButton" runat="server" OnClick="BuscarButton_Click" class="btn btn-Button4" Text="Buscar" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="**" ValidationGroup="buscar" ControlToValidate="IdFacturaTextBox" Font-Bold="True" ForeColor="Black"></asp:RequiredFieldValidator>
        </div>
        <%-- agregar --%>
        <div class="text-center">
            <div>
                <label for="Nombres Cliente">Nombres Cliente</label>
            </div>
            <asp:DropDownList ID="ClienteDropDownList" runat="server" Height="25px" Width="158px">
            </asp:DropDownList>
        </div>
        <%-- agregar --%>
        <div class="text-center">
            <div>
                <label for="Fecha">Forma de pago</label>
            </div>
        </div>
        <div class="text-center">
            <asp:DropDownList ID="TipoPagoDropDownList" runat="server" CssClass="auto-style3" Width="158px">
                <asp:ListItem Value="Credito"></asp:ListItem>
                <asp:ListItem Value="Contado"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <%-- agregar --%>
        <div class="text-center">
            <div>
                <label for="Fecha">Fecha</label>
            </div>
        </div>
        <div class="text-center">
            <asp:TextBox ID="FechaTextBox" runat="server" Width="190px" Height="33px"></asp:TextBox>
        </div>
        <%-- agregar --%>
        <div class="text-left">
            <div>
                <label for="Id">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Descripcion&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Precio&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Cantidad</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </div>
        </div>
        <div class="text-center">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="IdProductoTextBox" runat="server" Width="62px" Height="33px" CssClass="auto-style2" OnTextChanged="TextBox1_TextChanged" AutoPostBack="True"></asp:TextBox>
            <asp:TextBox ID="DescripcionTextBox" runat="server" Width="164px" Height="33px"></asp:TextBox>
            <asp:TextBox ID="PrecioTextBox" runat="server" Width="145px" Height="33px"></asp:TextBox>
            <asp:TextBox ID="CantidadTextBox" runat="server" Width="101px" Height="33px"></asp:TextBox>
            &nbsp;
            <asp:Button ID="AgregarButton" runat="server" Text="Agregar" OnClick="AgregarButton_Click" class="btn btn-Button4" />
&nbsp;<div class="auto-style5">
                <label for="Fecha">Importe<asp:TextBox ID="SubTotalTextBox" runat="server"></asp:TextBox>
                </label>
            &nbsp;&nbsp;
                <label for="Fecha">
                 <br />
                 Total<asp:TextBox ID="TotalTextBox" runat="server"></asp:TextBox>
                </label>
          
            &nbsp;</div>


            <div class="auto-style4">
                <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" class="btn btn-Button4" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="GuardarButton" runat="server" OnClick="GuardarButton_Click" class="btn btn-Button4" Text="Guardar" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" class="btn btn-Button4" />
        </div>
    </div>
    </div>
</asp:Content>
