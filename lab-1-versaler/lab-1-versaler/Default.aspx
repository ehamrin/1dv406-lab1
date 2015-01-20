<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="lab_1_versaler.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Capital letters</title>
    <link href="~/Content/site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h1>Count capital letters?</h1>
        </header>
        <div id="wrapper">
            <asp:TextBox ID="Message" runat="server" TextMode="MultiLine" />
            <asp:Label ID="Result" runat="server" Text="" Visible="False"/>
            <asp:Button ID="Send" runat="server" Text="" OnClick="Send_Click" />
        </div>
    </form>
</body>
</html>
