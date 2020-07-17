<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina.aspx.cs" Inherits="Cliente.Pagina" %>

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
            <asp:Button ID="Button1" runat="server" Height="43px" OnClick="btnConsultar_Click" Text="Consultar" Width="81px" />
            <br />
        </div>
    </form>
</body>
</html>
