<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="ConsultaFacturasWebForm.aspx.cs" Inherits="WebSistemaGonzalez.UI.Consultas.ConsultaFacturasWebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="text-center">
            <h2 class="auto-style1"> <span class="auto-style2">Consulta Factura</span></h2>
            <%-- Filtro --%>
            <dl>
                <dd>
                    <h5 id="ImprimirButton" aria-busy="False"><span class="auto-style1">Filtrar</span>&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList" runat="server">
                        <asp:ListItem Value="Id"></asp:ListItem>
                        <asp:ListItem Value="Descripcion"></asp:ListItem>
                        <asp:ListItem Value="Cantidad"></asp:ListItem>
                        <asp:ListItem Value="Precio"></asp:ListItem>
                        <asp:ListItem Value="Fecha"></asp:ListItem>
                        </asp:DropDownList>
                        <asp:TextBox ID="FlitrarTextbox" runat="server" Width="289px" Height="33px"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;<asp:Button ID="FiltrarButton" runat="server" Text="Buscar" class="btn btn-Button4" OnClick="FiltrarButton_Click" />
                    </h5>
                    <dd>
                    <h5><span class="auto-style1">Desde</span>
                        <asp:TextBox ID="DesdeTextBox" runat="server" Width="167px" Height="33px"></asp:TextBox>
                        &nbsp;&nbsp;<span class="auto-style1">Hasta&nbsp;</span><asp:TextBox ID="HastaTextBox" runat="server" CssClass="auto-style1" Width="167px" Height="33px"></asp:TextBox>
                    &nbsp;<asp:Button ID="ImprimirButton0" runat="server" class="btn btn-Button4" OnClick="ImprimirButton_Click" Text="Imprimir" />
                    </h5>
            
                </dd>
            </dl>
            <asp:GridView ID="ConsultaFacturaGridView" CssClass="auto-style3" runat="server" ForeColor="#333333" Width="758px" ShowFooter="True" Height="115px" HorizontalAlign="Center">
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
