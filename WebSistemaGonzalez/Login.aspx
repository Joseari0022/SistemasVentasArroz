<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebSistemaGonzalez.Login" %>

<!doctype html>
<html lang="en-US">
<head>

	<meta charset="utf-8">

	<title>Sistema De Venta</title>
    <!---------------------------------------------Bootstrap-------------------------------------------------------->
    <link rel="stylesheet" href="Content/Login.css" />

	
		<script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script>
	

    <%--toastr--%>
        <script src="//code.jquery.com/jquery-3.1.1.min.js"></script>
        <script src="/Toastr/toastr.min.js"></script>
        <link href="/Toastr/toastr.min.css" rel="stylesheet" />
        <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/angularjs/1.0.7/angular.min.js"></script>


</head>

<body>

    <div id="login-form">

        <h1>Login</h1>

        <fieldset>

            <form id="form1" runat="server">

                &nbsp;<!-- JS because of IE support; better: placeholder="Email" --><asp:TextBox ID="NombreTextBox" runat="server" Height="30px" Width="183px" value="Email" onBlur="if(this.value=='')this.value='Email'" onFocus="if(this.value=='Email')this.value='' "></asp:TextBox>
                <br />
                &nbsp;<asp:TextBox ID="ContrasenaTextBox" runat="server" Height="30px" Width="183px" value="Password" onBlur="if(this.value=='')this.value='Password'" onFocus="if(this.value=='Password')this.value='' " TextMode="Password"></asp:TextBox>

                &nbsp;<footer class="clearfix">

                    <p id="contraseñaTexbox">
                        <asp:Button ID="ButtonLogin" runat="server" OnClick="ButtonLogin_Click" Text="Login"/>
                    </p>

                </footer>

            </form>

        </fieldset>

    </div> <!-- end login-form -->

</body>
</html>
