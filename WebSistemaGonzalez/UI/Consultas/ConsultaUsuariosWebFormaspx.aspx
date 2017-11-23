<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="ConsultaUsuariosWebFormaspx.aspx.cs" Inherits="WebSistemaGonzalez.UI.Consultas.ConsultaUsuariosWebFormaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: medium;
        }
        .auto-style2 {
            font-size: xx-large;
        }
        .auto-style3 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container">
        <div class="text-center">
            <h2 class="auto-style1"> <span class="auto-style2">Consulta Usuarios</span></h2>
            <dl>
                <dd>
                    <h5><span class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Filtrar</span>&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="FiltroDropDownList" runat="server" class="btn btn-Button4" Width="147px" Height="16px" AutoPostBack="True">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Id</asp:ListItem>
                        <asp:ListItem>Nombre Usuario</asp:ListItem>
                        <asp:ListItem>Nombres</asp:ListItem>
                        <asp:ListItem>Todos</asp:ListItem>
                        </asp:DropDownList>
                        <asp:TextBox ID="FlitrarTextbox" runat="server" Width="289px" Height="33px"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;<asp:Button ID="BuscarButton" runat="server" Text="Buscar" class="btn btn-Button4" />
                        <asp:DropDownList ID="DropDownList1" runat="server" CausesValidation="true" Height="22px" Width="110px">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>Id</asp:ListItem>
                            <asp:ListItem>Nombre</asp:ListItem>
                            <asp:ListItem>Fecha</asp:ListItem>
                            <asp:ListItem>Todos</asp:ListItem>
                        </asp:DropDownList>
                    </h5>
                <dd>
                    <h5><span class="auto-style1">Desde</span>
                        <asp:TextBox ID="DesdeTextBox" runat="server" Width="167px" Height="33px"></asp:TextBox>
                        &nbsp;&nbsp;<span class="auto-style1">Hasta&nbsp;</span><asp:TextBox ID="HastaTextBox" runat="server" CssClass="auto-style1" Width="167px" Height="33px"></asp:TextBox>
                    </h5>
            </dl>
            <asp:GridView ID="ConsultaUsuarioGridView" CssClass="auto-style3" runat="server" ForeColor="#333333" Width="467px" ShowFooter="True" Height="162px" HorizontalAlign="Center">
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
            </div>
    </div>
</asp:Content>
