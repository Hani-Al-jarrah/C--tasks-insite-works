<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebApp_27_1_2025.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h2>Registration</h2>

        <asp:Label ID="LabelEmail" runat="server" Text="Email:"></asp:Label>
        <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox><br />

        <asp:Label ID="LabelName" runat="server" Text="Name:"></asp:Label>
        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox><br />

        <asp:Label ID="LabelPassword" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password"></asp:TextBox><br />

        <asp:Button ID="ButtonRegister" runat="server" Text="Register" OnClick="ButtonRegister_Click" /><br />
        <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label><br />

        <!-- Link to Login Page -->
        <asp:HyperLink ID="HyperLinkLogin" runat="server" NavigateUrl="Login.aspx">
            Already have an account? Login here
        </asp:HyperLink>
        </div>
    </form>
</body>
</html>
