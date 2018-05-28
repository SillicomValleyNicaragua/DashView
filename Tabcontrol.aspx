<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Tabcontrol.aspx.vb" Inherits="Tabcontrol" %>

<%@ Register Assembly="DevExpress.Web.Bootstrap.v17.2, Version=17.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>

<%@ Register assembly="DevExpress.Web.v17.2, Version=17.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title >Reportes</title>
<link rel="stylesheet" href="assets/css/DAsh.css" />
    <link rel="stylesheet" href="assets/css/centrar.css" />
    <meta name="viewport" content="width=device-width,user-scalable=no,initial-scale=1.0,maximun-scale=1.0,minimum-scale=1.0" />
</head>
<body runat="server">
<header   runat="server"  id="barra">
        <div>
<a href="#" class="bt-menu"><span class="icon-list2" style="color:antiquewhite"></span>Reportes </a>
</div>
       
    
    </header>
    <form id="signup_form" runat="server" method="post">
         <nav  id="contenedor_superior" runat="server">
            <dx:ASPxMenu ID="ASPxMenu1" runat="server" EnableTheming="True" Theme="MaterialCompact">
                <Items>
                    <dx:MenuItem DropDownMode="True" Text="Combustible">
                        <Items>
                            <dx:MenuItem  Text="Base de combustible." NavigateUrl="~/Reportes/Base_combustible.aspx" Target="contenedor">
                                <Image IconID="businessobjects_boreport2_32x32">
                                </Image>
                            </dx:MenuItem>
                        </Items>
                    </dx:MenuItem>
                    <dx:MenuItem DropDownMode="True" Text="Operacion">
                        <Items>
                            <dx:MenuItem Text="Caudal(Resumen Dia)" NavigateUrl="~/Caudal.aspx" Target="contenedor">
                            </dx:MenuItem>
                            <dx:MenuItem Text="Operacion de cosecha(Tipo de maquina.)" NavigateUrl="~/Operation_zafra.aspx" Target="contenedor">
                            </dx:MenuItem>
                        </Items>
                    </dx:MenuItem>
                    <dx:MenuItem DropDownMode="True" Text="Graficos">
                        <Items>
                            <dx:MenuItem Text="Seguimiento de Combustible" NavigateUrl="~/Fuel_follow.aspx" Target="contenedor">
                                <Image IconID="chart_chartshowcaptions_32x32">
                                </Image>
                            </dx:MenuItem>
                        </Items>
                    </dx:MenuItem>
                </Items>
            </dx:ASPxMenu>  
        </nav>
          <div id="contenedor_inferior"  runat="server">  
            <iframe  width="1300" height="1000"   src="principal.aspx"  name="contenedor" >
            </iframe>
        </div>
    </form>
    <script src="assets/js/DAsh.js"></script>
</body>
</html>
