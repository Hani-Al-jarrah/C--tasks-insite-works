<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApp_27_1_2025.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>


<%--            <asp:Label ID="Label1" runat="server" Text="Enter your name:"></asp:Label>

            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />

            <br />
            <asp:Button ID="Button2" runat="server" Text="Read" OnClick="Button2_Click" />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>--%>



            <%--<asp:Button ID="Create" runat="server" Text="Create" OnClick="Button1_Click" />--%>




            <%--   <asp:Label ID="Label1" runat="server" Text="Enter Your Name: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />--%>







     <%--       <asp:Label ID="Label1" runat="server" Text="Email:"></asp:Label>
            <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
            <br />


            <asp:Label ID="Label2" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
            <br />


            <asp:Label ID="Label3" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />


            <asp:Button ID="ButtonLogin" runat="server" Text="Login" OnClick="ButtonLogin_Click" />
            <br />
            <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>--%>

            
     <%--       <asp:Label ID="Label1" runat="server" Text="Email:"></asp:Label>
            <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
            <br />


            <asp:Label ID="Label2" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
            <br />


            <asp:Label ID="Label3" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />


            <asp:Button ID="ButtonLogin" runat="server" Text="Login" OnClick="ButtonLogin_Click" />
            <br />
            <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>--%>



              <h2>Login</h2>

        <asp:Label ID="LabelEmail" runat="server" Text="Email:"></asp:Label>
        <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox><br />

        <asp:Label ID="LabelName" runat="server" Text="Name:"></asp:Label>
        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox><br />

        <asp:Label ID="LabelPassword" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password"></asp:TextBox><br />

        <asp:Button ID="ButtonLogin" runat="server" Text="Login" OnClick="ButtonLogin_Click" /><br />
        <asp:Label ID="LabelMessage" runat="server" Text="" Visible="false"></asp:Label><br />

        <!-- Link to Registration Page -->
        <asp:HyperLink ID="HyperLinkRegister" runat="server" NavigateUrl="Registration.aspx">
            Don't have an account? Register here
        </asp:HyperLink>





        </div>
    </form>
</body>
</html>
