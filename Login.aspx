<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HomeSync.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Login Page</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        .login-container {
            background-color: #fff;
            padding: 30px;
            border-radius: 5px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            text-align: center;
        }

        .login-title {
            font-size: 34px;
            font-weight: bold;
            margin-bottom: 20px;
        }

        .input-group {
            margin-bottom: 15px;
            text-align: left;
        }

        .input-group label {
            font-size: 20px;
            font-weight: bold;
            display: block;
            margin-bottom: 5px;
        }

        .input-group input[type="text"],
        .input-group input[type="password"] {
            width: 100%;
            padding: 10px;
            font-size: 16px;
            border-radius: 3px;
            border: 1px solid #ccc;
            box-sizing: border-box;
        }

        .btn-login,
        .btn-signup {
            padding: 10px 20px;
            font-size: 18px;
            font-weight: bold;
            border: none;
            border-radius: 3px;
            cursor: pointer;
            transition: background-color 0.3s;
            margin-top: 10px;
        }

        .btn-login {
            background-color: #3498db;
            color: #fff;
            margin-right: 10px;
        }

        .btn-signup {
            background-color: #2ecc71;
            color: #fff;
        }

        .btn-login:hover,
        .btn-signup:hover {
            background-color: #2980b9;
            color: #fff;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div class="login-container">
            <h1 class="login-title">Log in</h1>

            <div class="input-group">
                <label for="username">Username</label>
                <asp:TextBox ID="username" runat="server" CssClass="input-text" />
            </div>

            <div class="input-group">
                <label for="password">Password</label>
                <asp:TextBox ID="password" TextMode="Password" runat="server" CssClass="input-text" />
            </div>

            <asp:Button ID="login1" runat="server" CssClass="btn-login" Text="Log in" OnClick="login" />
            <asp:Button ID="signup1" runat="server" CssClass="btn-signup" Text="Sign Up" OnClick="signup1_Click" />
        </div>
    </form>
</body>

</html>
