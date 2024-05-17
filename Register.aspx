<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="HomeSync.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username<br />
            <asp:TextBox ID="username" runat="server"></asp:TextBox>
            <br />
            First Name<br />
            <asp:TextBox ID="fname" runat="server"></asp:TextBox>
            <br />
            Last Name<br />
            <asp:TextBox ID="lname" runat="server"></asp:TextBox>
            <br />
            Birth Date YYYY-MM-DD<br />
            <asp:TextBox ID="birth" runat="server"></asp:TextBox>
            <br />
            Email</div>
        <asp:TextBox ID="email" runat="server"></asp:TextBox>
        <br />
        Password<br />
        <asp:TextBox ID="password" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:DropDownList ID="type" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>guest</asp:ListItem>
            <asp:ListItem>admin</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="RegisterButton" runat="server" OnClick="register" Text="Register" />
    </form>
</body>
</html>
