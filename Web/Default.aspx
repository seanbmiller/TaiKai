<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TaiKai</title>
</head>
<body>
    <form id="form" runat="server">
        <div>
            <h1>TaiKai</h1>
        </div>
        
        <div>
            <asp:LoginView ID="LoginView" runat="server" >
                <AnonymousTemplate>
                    You are not logged in. Click the Login link to sign in.&nbsp; 
                </AnonymousTemplate>  
                <LoggedInTemplate>
                    You are logged in. Welcome,
                    <asp:LoginName ID="LoginName1" runat="server" />
                    &nbsp; 
                </LoggedInTemplate>
            </asp:LoginView>
         </div>
        <br />
        <asp:LoginStatus ID="LoginStatus1" runat="server" />
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/MemberPages/Members.aspx">Members-only page</asp:HyperLink>
    </form>
</body>
</html>
