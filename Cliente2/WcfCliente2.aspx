﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WcfCliente2.aspx.cs" Inherits="Cliente2.WcfCliente2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
            <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" />
            <br />
        </div>
    </form>
</body>
</html>
