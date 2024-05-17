<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Device.aspx.cs" Inherits="HomeSync.Device" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <style>
   
        .buttonSpacing {
            margin-right: 100px;
        }
    </style>
</head>
<body style="height:100vh;">
    

          
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="Deviceid" runat="server" DataTextField="device_id"></asp:TextBox><br />
            <strong style="font-size: 22px;">Charge:</strong>
            <span id="lbldevice" runat="server" style="font-size: 18px;"></span><br />

            <strong style="font-size: 22px;">Status:</strong>
            <span id="lblStatus" runat="server" style="font-size: 18px;"></span><br />
    
            <strong style="font-size: 22px;">Type:</strong>
            <span id="lblType" runat="server" style="font-size: 18px;"></span><br />

           <strong style="font-size: 22px;">Room:</strong>
           <span id="lblRoom" runat="server" style="font-size: 18px;"></span><br />
              
               <br class="Apple-interchange-newline"><br class="Apple-interchange-newline"><br class="Apple-interchange-newline">
                <asp:Label ID="insretlbl" runat="server" Text="Insert New Device :" Visible="false"></asp:Label> 
            <br class="Apple-interchange-newline">

  <asp:Label ID="devicelbl" runat="server" Text="Device ID :" Visible="false"></asp:Label>               
            <asp:TextBox ID="DeviceID2" runat="server"  CssClass="buttonSpacing" Visible="false"></asp:TextBox>
    
            <asp:Button ID="Button1" runat="server" Text="Devices dead battery" CssClass="buttonSpacing" Visible="false" OnClick="Dead" /><asp:Button ID="Button2" Visible="false" runat="server" Text="Set Recharged" CssClass="buttonSpacing" OnClick="Recharged" /><asp:Button ID="Button3" runat="server" Text="2 dead batteries" Visible="false" Onclick="Dead2"/>
   <br />
            <asp:Label ID="Statuslbl" runat="server" Text="Status :" Visible="false"></asp:Label>
            <asp:TextBox ID="Status2" runat="server" Visible="false"></asp:TextBox>
            <br />
           <asp:GridView ID="GV" runat="server" style="margin-left: 400px;">
</asp:GridView>

                       <asp:GridView ID="GV2" runat="server" style="margin-left: 800px;">
</asp:GridView>

           <asp:Label ID="BatteryLabel" runat="server" Text="Battery :" Visible="false"></asp:Label>
            <asp:TextBox ID="Battery2" runat="server" Visible="false" ></asp:TextBox><br />
            <asp:Label ID="locationlbl" runat="server" Text="Location :" Visible="false"></asp:Label>
            <asp:TextBox ID="Location2" runat="server" Visible="false"></asp:TextBox><br />
            <asp:Label ID="typelbl" runat="server" Text="Type :" Visible="false"></asp:Label>
            <asp:TextBox ID="Type2" runat="server" Visible="false"></asp:TextBox><br />


            <asp:Button ID="addButton" runat="server" Text="Add Device" OnClick ="Insert" Visible="false" />
        </div>
    </form>
    
</body>
            
</html>
