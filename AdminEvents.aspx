<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Events.aspx.cs" Inherits="HomeSync.Events" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
   <head runat="server">
      <title></title>
   </head>
   <body>
      <form id="form1" runat="server">
         <div>
            <h1>ADMIN Page</h1>
            <h2>Create An Event </h2>
            <strong style="font-size: 22px;">  event id :</strong>
            <asp:TextBox ID="one" runat="server" ></asp:TextBox>
            <br />
            <strong style="font-size: 22px;">  user id :</strong>
            <asp:TextBox ID="two" runat="server" ></asp:TextBox>
            <br />
            <strong style="font-size: 22px;">  name :</strong>
            <asp:TextBox ID="three" runat="server" ></asp:TextBox>
            <br />
            <strong style="font-size: 22px;">description</strong>
            <asp:TextBox ID="four" runat="server" ></asp:TextBox>
            <br />
            <strong style="font-size: 22px;"> location  :</strong>
            <asp:TextBox ID="five" runat="server" ></asp:TextBox>
            <br />
            <strong style="font-size: 22px;">reminder date :</strong>
            <asp:TextBox ID="six" runat="server" ></asp:TextBox>
            <br />
            <strong style="font-size: 22px;"> other user id :</strong>
            <asp:TextBox ID="seven" runat="server" ></asp:TextBox>
            <br />
            <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="ADMINButton1" />
            <br />
            <h2>Assign User To Event</h2>
            <strong style="font-size: 22px;"> enter user id :</strong>
            <asp:TextBox ID="assign1" runat="server" ></asp:TextBox>
            <br />
            <strong style="font-size: 22px;"> enter event id :</strong>
            <asp:TextBox ID="assign2" runat="server" ></asp:TextBox>
            <br />
            <asp:Button ID="AssignButton" runat="server" Text="Assign User" OnClick="ADMINButton2" />
            <br />
            <h2>Unassign User</h2>
            <strong style="font-size: 22px;"> enter event id :</strong>
            <asp:TextBox ID="Un1" runat="server" ></asp:TextBox>
            <br />
            <strong style="font-size: 22px;"> enter user id :</strong>
            <asp:TextBox ID="Un2" runat="server" ></asp:TextBox>
            <br />
            <asp:Button ID="UnassignButton" runat="server" Text="Unassign User" OnClick="ADMINButton3" />
            <br />
            <h2>Viewwwww Event</h2>
            <strong style="font-size: 22px;"> enter user id :</strong>
            <asp:TextBox ID="View1" runat="server" ></asp:TextBox>
            <br />
            <strong style="font-size: 22px;"> enter event id :</strong>
            <asp:TextBox ID="View2" runat="server" ></asp:TextBox>
            <br />
            <asp:Button ID="ViewButton" runat="server" Text="View" OnClick="ADMINButton4" />
            <asp:GridView ID="ViewTable" runat="server"></asp:GridView>
            <br />
            <h2>Remove Event</h2>


            <strong style="font-size: 22px;">Enter event id:</strong>
            <asp:TextBox ID="R1" runat="server"></asp:TextBox>
            <br />
            <strong style="font-size: 22px;">Enter user id:</strong>
            <asp:TextBox ID="R2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="DELETE" OnClick="ADMINButton5" />


         </div>
      </form>
   </body>
</html>