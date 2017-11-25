<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="ContactarWebForm.aspx.cs" Inherits="WebSistemaGonzalez.ContactarWebForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="/Content/Style.css" />
    <style type="text/css">
        .auto-style3 {
            font-size: large;
        }

        .auto-style4 {
            width: 544px;
            height: 549px;
            margin-left: 482px;
            margin-right: 0px;
            margin-top: 30px;
        }

        .auto-style5 {
            text-align: center;
        }

        .auto-style6 {
            font-size: xx-large;
            text-decoration: underline;
        }

        .auto-style7 {
            color: #000000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="caption">
        <pre class="auto-style5"><span class="auto-style6"><strong>Sistema de Venta Gonzalez</strong></span><strong> </strong></pre>
        <img class="auto-style4" src="Content/IMG/WhatsApp%20Image%202017-10-22%20at%201.51.33%20PM.jpeg" />
    </div>



    <!--icono de telefono con los telefonos----->
    <div class="text-center">
        <br />
        <span class=" glyphicon glyphicon-earphone Iconos">
            <h4 class="auto-style3">Tel:829-542-6488/Cel:849-450-4129</h4>
        </span>
        <br />
    </div>
    <!----------- icono de mail ---->
    <div class="text-center">
        <span class="glyphicon glyphicon-envelope Iconos">
            <h4><a href="mailto:joseari0022@gmail.com?&subject=&body=" class="auto-style7"><em>Email:joseari0022@gmail.com</em></a></h4>
        </span>
    </div>

</asp:Content>
