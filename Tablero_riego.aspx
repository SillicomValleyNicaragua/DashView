<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Tablero_riego.aspx.vb" Inherits="Tablero_riego" %>

<%@ Register Assembly="DevExpress.Dashboard.v17.2.Web, Version=17.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> Tablero cosecha</title>
     <meta http-equiv="refresh" content="50" />
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <dx:ASPxDashboard ID="ASPxDashboard1" runat="server" ColorScheme="light.compact" DashboardStorageFolder="~/APP_DATA/DASHBOARDS" InitialDashboardId="dashboard6" WorkingMode="Viewer"></dx:ASPxDashboard>
        </div>
    </form>
</body>
</html>
