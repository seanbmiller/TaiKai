<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Login Page</h1>
        <br />
        <asp:Login ID="login" runat="server">
        </asp:Login>
    
    </div>
        <asp:ValidationSummary ID="ValidationSummary" runat="server" />
    </form>
</body>
</html>
