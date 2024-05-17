<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="HomeSync.Profile" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Profile</title>
 <style>
.profile-buttons-container {
            display: flex;
            justify-content: center;
            margin-top: 30px;
           text-align : center;
        }
  
       
        h1 {
            font-size: 46px;
            text-align: center;
        }
</style>

</head>
<body>
    <form id="form2" runat="server">
        <div >
            
    <h1>Welcome to Your Profile <strong font-size ="36" id="lblName" runat="server"></strong></h1>


                <strong style="font-size: 32px;">Email:</strong> <span id="lblEmail" runat="server" font-size ="18"></span><br />
                <strong style="font-size: 32px;">Age:</strong> <span id="lblAge" runat="server" font-size ="18"></span><br />
                <strong style="font-size: 32px;">Birth Date:</strong> <span id="lblBirthDate" runat="server" font-size ="18"></span><br />
                <strong style="font-size: 32px;">Type:</strong> <span id="lblType" runat="server" font-size ="18"></span><br />
             <strong style="font-size: 32px;">Room:</strong> <span id="lblroom" runat="server" font-size ="18"></span><br />
                <strong style="font-size: 32px;">Preference:<br />
            </strong>&nbsp;<span id="lblPreference" runat="server" font-size ="18"></span><br 
                    <br /><br />
                    <asp:TextBox ID="admin_id" runat="server"></asp:TextBox>
        <asp:Button ID="getadminguests" runat="server" Text="Click" OnClick="adminguests" />
        <br />
        Number of guests for admin:&nbsp;<asp:GridView ID="guestnumber" runat="server">
        </asp:GridView>
           
            </div>
           <div class="profile-buttons-container">
            <div class="profile-buttons">
                <asp:Button ID="Button6" runat="server" Text="Device" Font-Bold ="true" Font-Size ="32" BackColor ="#808080" OnClick="Navigate" /><br class="Apple-interchange-newline">
                <asp:Button ID="Button7" runat="server" Text="Room" Font-Bold ="true" Font-Size ="32" BackColor ="#808080" OnClick="gotoroom"/>
                <asp:Button ID="Button8" runat="server" Text="Tasks" Font-Bold  ="true" Font-Size ="32" BackColor ="#808080" OnClick="Button8_Click" />
                <asp:Button ID="Button9" runat="server" Text="Events" Font-Bold  ="true" Font-Size ="32" BackColor ="#808080" OnClick="Button9_Click" />
                <asp:Button ID="Button10" runat="server" Text="Communication" Font-Bold ="true" Font-Size ="32" BackColor ="#808080" OnClick="Button10_Click"/>
                <asp:Button ID="Button11" runat="server" Text="Finance" Font-Bold ="true" Font-Size ="32" BackColor ="#808080" OnClick="Button11_Click"/>
            </div>
        </div>
    </form>
</body>
</html>

