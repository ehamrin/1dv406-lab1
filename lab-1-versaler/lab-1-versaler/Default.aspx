<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="lab_1_versaler.Default" EnableViewState="false" %>

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
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Message area cannot be empty" ControlToValidate="Message" Text="" Display="None" EnableTheming="True" SetFocusOnError="True" />
            <asp:Label ID="Result" runat="server" Text="" Visible="False"/>
            <asp:ValidationSummary ID="ValidationSummary1" CssClass="validation-error" runat="server" />
            <asp:Button ID="Send" runat="server" Text="" OnClick="Send_Click" />
            
        </div>
    </form>
</body>
</html>
