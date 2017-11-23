<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="FacturasWebForm.aspx.aspx.cs" Inherits="WebSistemaGonzalez.UI.Registros.FacturasWebForm2aspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }

        .auto-style2 {
            margin-left: 40;
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
        </div>
        <div class="text-center">
            <asp:TextBox ID="NombreClienteTextBox" runat="server" Width="190px" Height="33px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="**" ValidationGroup="buscar" ControlToValidate="NombreClienteTextBox" Font-Bold="True" ForeColor="Black"></asp:RequiredFieldValidator>
        </div>
        <%-- agregar --%>
        <div class="text-center">
            <div>
                <label for="Fecha">Fecha</label>
            </div>
        </div>
        <div class="text-center">
            <asp:TextBox ID="FechaTextBox" runat="server" Width="190px" Height="33px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="**" ValidationGroup="buscar" ControlToValidate="NombreClienteTextBox" Font-Bold="True" ForeColor="Black"></asp:RequiredFieldValidator>
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
&nbsp;<asp:GridView ID="FacturaGridView"  CssClass="text-center" runat="server" CellPadding="0" ClientIDMode="Static" ForeColor="#333333" Width="400px" ShowFooter="True" Height="100px" HorizontalAlign="Center" PageIndex="2" PageSize="2" GridLines="Vertical" OnRowDeleting="FacturaGridView_SelectedIndexChanged" >
                <AlternatingRowStyle BackColor="White" Font-Bold="False" />
                <EditRowStyle BackColor="#2461BF" HorizontalAlign="Center" VerticalAlign="Middle" />
                <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Bottom" />
                <FooterStyle BackColor="#C0C0C0" Font-Bold="True" ForeColor="White" BorderColor="white" BorderWidth="2px" HorizontalAlign="Justify" VerticalAlign="Top" />
                <HeaderStyle BackColor="#C0C0C0" Font-Bold="True" ForeColor="White" BorderStyle="Outset" Font-Italic="True" Font-Size="12pt" HorizontalAlign="Center" VerticalAlign="Middle" />
                <PagerStyle BackColor="#F8F8FF" ForeColor="White" HorizontalAlign="Center" BorderColor="Black" BorderWidth="2px" />
                <RowStyle BackColor="#EFF3FB" BorderColor="Black" BorderStyle="None" BorderWidth="2px" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" BorderStyle="Solid" BorderWidth="3px" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" BorderStyle="Solid" BorderWidth="3px" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>


            <div class="text-center">
                <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" class="btn btn-Button4" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="GuardarButton" runat="server" OnClick="GuardarButton_Click" class="btn btn-Button4" Text="Guardar" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" class="btn btn-Button4" />
        </div>

            <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</asp:Content>
