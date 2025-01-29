﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profileuser.aspx.cs" Inherits="_27_1_2025.profileuser" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit User Profile</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- Search Section -->
            <asp:TextBox ID="searchTxt" runat="server" placeholder="Enter email to search"></asp:TextBox>
            <asp:Button ID="searchBtn" runat="server" Text="Search" OnClick="searchBtn_Click" />
            <br /><br />

            <!-- User Details Section -->
            <asp:Label Text="Name:" runat="server" />
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
            <br />

            <asp:Label Text="Email:" runat="server" />
            <asp:TextBox ID="Email" runat="server"></asp:TextBox>
            <br />

            <asp:Label Text="Password:" runat="server" />
            <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
            <br />

            <asp:Label Text="Confirm Password:" runat="server" />
            <asp:TextBox ID="confirmPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />

            <asp:Label Text="Phone Number:" runat="server" />
            <asp:TextBox ID="phoneNumber" runat="server"></asp:TextBox>
            <br />

            <asp:Label Text="Gender:" runat="server" />
            <asp:DropDownList ID="gender" runat="server">
                <asp:ListItem Value="male">Male</asp:ListItem>
                <asp:ListItem Value="female">Female</asp:ListItem>
            </asp:DropDownList>
            <br /><br />

            <!-- Edit Button -->
            <asp:Button ID="editBtn" runat="server" Text="Save Changes" OnClick="editBtn_Click" />
        </div>
    </form>
</body>
</html>