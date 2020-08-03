<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SingleSignOn.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server"  defaultbutton="btnLogin" defaultfocus="txtPassword" style="display:flex;justify-content:center;padding:10px;">

    <br /><br />
        <div style="width:400px;border:1px solid #CCC;padding:20px;border-radius:4px;margin-top:100px;">
            <p></p>
            <div style="font-size:16px;font-weight:bold;color: #808080;">
                Login
            </div><p></p>
    <asp:TextBox runat="server" CssClass="form-control" ID="txtUserName" placeholder="User Name"></asp:TextBox><br />
     <asp:TextBox runat="server" CssClass="form-control" ID="txtPassword" TextMode="Password" placeholder="Password"></asp:TextBox><br />
    <asp:LinkButton runat="server" CssClass="btn btn-primary" ID="btnLogin" OnClick="btnLogin_Click">Login</asp:LinkButton>
    <p>
			<asp:Label ID="errorMessageLabel" runat="server" ForeColor="Red"></asp:Label>
		</p>
        </div>
    </form>
</body>
</html>
