<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Events.aspx.cs" Inherits="HomeSync.Events" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
   <head runat="server">
      <title></title><style>
        .demoFont {
            font-family: "Courier New", Courier, monospace;
            font-size: 25px;
            letter-spacing: -0.4px;
            word-spacing: 2px;
            color: #000000;
            font-weight: 700;
            text-decoration: underline solid rgb(68, 68, 68);
            font-style: normal;
            font-variant: normal;
            text-transform: none;
        }
    </style>
   </head>
   <body>
      <form id="form1" runat="server">
         <div>
<h1 class="demoFont">EVENTS PAGE</h1>
            <h2 class="demoFont">Create an event</h2>
           <strong style="font-size: 22px;">Event ID:</strong>
<asp:TextBox ID="one" runat="server"></asp:TextBox>
<br />
<strong style="font-size: 22px;">User ID:</strong>
<asp:TextBox ID="two" runat="server"></asp:TextBox>
<br />
<strong style="font-size: 22px;">Name:</strong>
<asp:TextBox ID="three" runat="server"></asp:TextBox>
<br />
<strong style="font-size: 22px;">Description:</strong>
<asp:TextBox ID="four" runat="server"></asp:TextBox>
<br />
<strong style="font-size: 22px;">Location:</strong>
<asp:TextBox ID="five" runat="server"></asp:TextBox>
<br />
<strong style="font-size: 22px;">Reminder Date:</strong>
<asp:TextBox ID="six" runat="server"></asp:TextBox>
<br />
<strong style="font-size: 22px;">Other User ID:</strong>
<asp:TextBox ID="seven" runat="server"></asp:TextBox>
<br />

            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button" />
            <br />
            
            <h2 class="demoFont">Assign User To Event</h2>
            <strong style="font-size: 22px;"> enter user id :</strong>
            <asp:TextBox ID="assign1" runat="server" ></asp:TextBox>
            <br />
            <strong style="font-size: 22px;"> enter event id :</strong>
            <asp:TextBox ID="assign2" runat="server" ></asp:TextBox>
            <br />
            <asp:Button ID="AssignButton" runat="server" Text="Assign User" OnClick="Button2" />
            <br />
           <h2 class="demoFont">Uninvite User</h2>
            <strong style="font-size: 22px;"> enter event id :</strong>
            <asp:TextBox ID="Un1" runat="server" ></asp:TextBox>
            <br />
            <strong style="font-size: 22px;"> enter user id :</strong>
            <asp:TextBox ID="Un2" runat="server" ></asp:TextBox>
            <br />
            <asp:Button ID="UnassignButton" runat="server" Text="Unassign User" OnClick="Button3" />
            <br />
            <h2>View Event</h2>
            <strong style="font-size: 22px;"> enter user id :</strong>
            <asp:TextBox ID="View1" runat="server" ></asp:TextBox>
            <br />
            <strong style="font-size: 22px;"> enter event id :</strong>
            <asp:TextBox ID="View2" runat="server" ></asp:TextBox>
            <br />
            <asp:Button ID="ViewButton" runat="server" Text="View" OnClick="Button4" />
            <asp:GridView ID="ViewTable" runat="server"></asp:GridView>
         </div>
      </form>
   </body>
</html>