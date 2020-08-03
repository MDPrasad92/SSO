<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApp1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
		<h1>Login to the Service Provider</h1>
		<p>
            <asp:LinkButton ID="ssoLinkButton" runat="server" OnClick="ssoLinkButton_Click" ToolTip="Initiates SAML single sign-on to the identity provider.">SSO to the Identity Provider</asp:LinkButton>
		</p>
    </div>
    </form>
</body>
</html>
