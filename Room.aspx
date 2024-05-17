<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Room.aspx.cs" Inherits="HomeSync.Room" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="display:flex;flex-direction:row;justify-content:center;">
            User Room:
            <asp:Label ID="roomid" runat="server" Text=" "></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <p>
            Book Room</p>
        <p>
            Room ID:
            <asp:TextBox ID="room_id" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Book" />
        </p>
        <p>
            Set Room Status:</p>
        <p>
            Room ID:<asp:TextBox ID="statusroomid" runat="server"></asp:TextBox>
        </p>
        <p>
            Status: <asp:TextBox ID="statusstatus" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Set" />
        </p>
        <p>
            Create Room Schedule:</p>
        <p>
            Room ID: <asp:TextBox ID="scheduleroomid" runat="server" OnTextChanged="statusstatus0_TextChanged"></asp:TextBox>
        </p>
        <p>
            Start Date: YYYY/MM/DD <asp:TextBox ID="scheduledate" runat="server"></asp:TextBox>
        </p>
        <p>
            End Date: YYYY/MM/DD <asp:TextBox ID="scheduleenddate" runat="server"></asp:TextBox>
        </p>
        <p>
            Action: <asp:TextBox ID="scheduleaction" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Create Schedule" />
        </p>
        <p>
            <asp:Button ID="Button4" runat="server" Text="View Empty Rooms" OnClick="Button4_Click" />
        </p>
        <p>
            <asp:GridView ID="emptyrooms" runat="server">
            </asp:GridView>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
