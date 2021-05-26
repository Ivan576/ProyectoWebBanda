<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLoginDiseño.aspx.cs" Inherits="ProyectoWebBanda.CapaUsuarios.Admin.AdminLogin_Diseño" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="../CSS/util.css">
	<link rel="stylesheet" type="text/css" href="../CSS/main.css">
</head>
<body>
    <form id="form1" runat="server">
    	<div class="limiter">
		<div class="container-login100">
			<div class="wrap-login100">
					<span class="login100-form-title p-b-26">
						Bienvenido
					
					
					
								
					
					
					
					</span>

					<div class="wrap-input100 validate-input" data-validate = "Valid email is: a@b.c">
						<%--<input class="input100" type="text" name="email">--%>
						<span class="focus-input100" data-placeholder="Email"></span>
						<asp:TextBox ID="txtUser" runat="server" ></asp:TextBox>
					</div>

					<div class="wrap-input100 validate-input" data-validate="Enter password">
						<span class="btn-show-pass">
							<i class="zmdi zmdi-eye"></i>
						</span>
<%--						<input class="input100" type="password" name="pass">--%>
						<asp:TextBox ID="txtPassword" runat="server"  TextMode="Password"  ></asp:TextBox>
						<span class="focus-input100" data-placeholder="Password" ></span>
					</div>

					<span class="login100-form-title p-b-48">
									<asp:Button ID="btnLogin" runat="server" Text="Login" BackColor="#9966FF" Font-Bold="True" Font-Italic="True" Font-Size="Medium" ForeColor="White" Height="32px" OnClick="btnLogin_Click" Width="119px" />
								</span>
					<div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							</div>
					</div>
					
			</div>
		</div>
	</div>
	

	<div id="dropDownSelect1"></div>
        <div>
        </div>
    </form>
</body>
</html>
