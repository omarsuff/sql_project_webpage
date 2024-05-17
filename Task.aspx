<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Task.aspx.cs" Inherits="HomeSync.Task" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 588px;
        }
    </style>
</head>
<body style="height: 413px">
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button2" runat="server" Text="View My Task" OnClick="Button2_Click" />
            <asp:GridView ID="tasktable1" runat="server">
            </asp:GridView>
            <br />
            <br />
            <br />

            Enter Finished Task:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>



        <asp:Button ID="Button3" runat="server" Text="Finish Task" OnClick="Button3_Click" />
        <br />
        <br />
        <br />
        Creator ID:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="view task status" OnClick="Button4_Click" />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <br />
        Task ID:&nbsp; <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
                    <strong style="font-size: 22px;">reminder date :</strong>

            <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button6" runat="server" Text="Remind Me!" OnClick="Button6_Click" />
        <br />
        <br />
        <br />
        <br />
        <br />
        Task:&nbsp;&nbsp;
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
       
        <br />
        New Date:&nbsp;&nbsp;
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Update Deadline" />
    </form>
</body>
</html>
