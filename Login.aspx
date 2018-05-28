<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Login" %>

<%@ Register Assembly="DevExpress.Web.Bootstrap.v17.2, Version=17.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>

<%@ Register assembly="DevExpress.Web.v17.2, Version=17.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html>
<html lang="en">
<head>
	<title>Login V3</title>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
    <link  type="text/css" rel="stylesheet" href="assets/css/Login.css" />
    <link type="text/css" rel="stylesheet" href="assets/css/DAsh.css" />
</head>
<body style="background-image:url(images/aerial.png)">
    <div class="wrapper">
        <img src="images/ingenio_monte_rosa-ld8app.png" width="250" height="100" class="logo"  />
  <h1 id="titulo">Dash View Login</h1>
  <form id="signup_form" class="centro" runat="server" >
      <div id="Formulario" class="contenedor"> 

    <asp:TextBox ID="TextBox1" runat="server" Width="215px" tooltip="Ingresa el usuario"></asp:TextBox>
    <div>
      <p class="name-help">Usuario</p>
    </div>
      <asp:TextBox ID="TextBox2"  runat="server" TextMode="Password" Width="212px" CssClass="user" ToolTip="Ingresa tu contraseña."></asp:TextBox>
    &nbsp;<div>
      <p class="email-help">Contraseña.</p>
    </div>
    <dx:BootstrapButton ID="BootstrapButton1" runat="server" AutoPostBack="false" Text="Ingresar"></dx:BootstrapButton>
      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DASH_DESIGNER.My.MySettings.sisacsa %>" SelectCommand="consulta" SelectCommandType="StoredProcedure">
          <SelectParameters>
              <asp:ControlParameter ControlID="TextBox1" Name="usu" PropertyName="Text" Type="String" />
              <asp:ControlParameter ControlID="TextBox2" Name="pas" PropertyName="Text" Type="String" />
          </SelectParameters>
      </asp:SqlDataSource>
          </div>
  </form>

</div>
      
</body>
</html>