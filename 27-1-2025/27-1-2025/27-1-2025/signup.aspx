﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="_27_1_2025.signup" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign Up</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
        <section class="vh-100" style="background-color: #eee;">
            <div class="container h-100">
                <div class="row d-flex justify-content-center align-items-center h-100">
                    <div class="col-lg-12 col-xl-11">
                        <div class="card text-black" style="border-radius: 25px;">
                            <div class="card-body p-md-5">
                                <div class="row justify-content-center">
                                    <div class="col-md-10 col-lg-6 col-xl-5 order-2 order-lg-1">
                                        <p class="text-center h1 fw-bold mb-5 mx-1 mx-md-4 mt-4">Sign up</p>

                                        <!-- Name -->
                                        <div class="d-flex flex-row align-items-center mb-4">
                                            <i class="fas fa-user fa-lg me-3 fa-fw"></i>
                                            <div class="form-outline flex-fill mb-0">
                                                <asp:TextBox ID="name" runat="server" CssClass="form-control"></asp:TextBox>
                                                <label class="form-label">Your Name</label>
                                            </div>
                                        </div>

                                        <!-- Email -->
                                        <div class="d-flex flex-row align-items-center mb-4">
                                            <i class="fas fa-envelope fa-lg me-3 fa-fw"></i>
                                            <div class="form-outline flex-fill mb-0">
                                                <asp:TextBox ID="email" runat="server" CssClass="form-control"></asp:TextBox>
                                                <label class="form-label">Your Email</label>
                                            </div>
                                        </div>

                                        <!-- Password -->
                                        <div class="d-flex flex-row align-items-center mb-4">
                                            <i class="fas fa-lock fa-lg me-3 fa-fw"></i>
                                            <div class="form-outline flex-fill mb-0">
                                                <asp:TextBox ID="password" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                                <label class="form-label">Password</label>
                                            </div>
                                        </div>

                                        <!-- Confirm Password -->
                                        <div class="d-flex flex-row align-items-center mb-4">
                                            <i class="fas fa-key fa-lg me-3 fa-fw"></i>
                                            <div class="form-outline flex-fill mb-0">
                                                <asp:TextBox ID="ConfirmPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                                <label class="form-label">Confirm Password</label>
                                            </div>
                                        </div>

                                        <!-- Phone Number -->
                                        <div class="d-flex flex-row align-items-center mb-4">
                                            <i class="fas fa-phone fa-lg me-3 fa-fw"></i>
                                            <div class="form-outline flex-fill mb-0">
                                                <asp:TextBox ID="phone" runat="server" CssClass="form-control" TextMode="Phone"></asp:TextBox>
                                                <label class="form-label">Phone Number</label>
                                            </div>
                                        </div>
                                        
                                        <!-- Gender -->
                                        
                                        
                                        <div class="d-flex flex-row align-items-center mb-4">
                                            <i class="fas fa-lg me-3 fa-fw"></i>
                                            <div class="form-outline flex-fill mb-0">
                                                <asp:TextBox ID="gender" runat="server" CssClass="form-control"></asp:TextBox>
                                                <label class="form-label">Gender</label>
                                            </div>
                                        </div>

                                        <!-- Register Button -->
                                        <div class="d-flex justify-content-center mx-4 mb-3 mb-lg-4">
                                            <asp:Button ID="register" runat="server" Text="Register" CssClass="btn btn-primary" OnClick="register_Click" />
                                        </div>

                                        <!-- Message Label -->
                                        <asp:Label ID="lblmsg" runat="server" Visible="false" CssClass="text-danger"></asp:Label>
                                    </div>

                                    <!-- Right Side Image -->
                                    <div class="col-md-10 col-lg-6 col-xl-7 d-flex align-items-center order-1 order-lg-2">
                                        <img src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-registration/draw1.webp" class="img-fluid" alt="Sign Up">
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </form>
</body>
</html>
