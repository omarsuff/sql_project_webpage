<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Communication.aspx.cs" Inherits="HomeSync.Communication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Communication</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }

        form {
            max-width: 600px;
            margin: 20px auto;
            background-color: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        h2 {
            text-align: center;
            color: #333;
        }

        .input-group {
            margin-bottom: 15px;
        }

        .input-group strong {
            display: block;
            margin-bottom: 5px;
        }

        .input-group input,
        .input-group textarea {
            width: 100%;
            padding: 8px;
            box-sizing: border-box;
        }

        .btn-container {
            text-align: center;
        }

        .btn-container button {
            padding: 10px 20px;
            font-size: 16px;
            background-color: #4caf50;
            color: #fff;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

        .output-container {
            margin-top: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Communication</h2>
        <div class="input-group">
            <strong>Enter Sender ID:</strong>
            <asp:TextBox ID="SenderID1" runat="server"></asp:TextBox>
        </div>

        <div class="input-group">
            <strong>Enter Receiver ID:</strong>
            <asp:TextBox ID="ReceiverID1" runat="server"></asp:TextBox>
        </div>

        <div class="input-group">
            <strong>Enter Title:</strong>
            <asp:TextBox ID="Title" runat="server"></asp:TextBox>
        </div>

        <div class="input-group">
            <strong>Enter Content:</strong>
            <asp:TextBox ID="Content" runat="server" TextMode="MultiLine" Rows="6"></asp:TextBox>
        </div>

        <div class="input-group">
            <strong>Enter Time Sent:</strong>
            <asp:TextBox ID="TimeSent" runat="server"></asp:TextBox>
        </div>

        <div class="input-group">
            <strong>Enter Time Received:</strong>
            <asp:TextBox ID="TimeReceived" runat="server"></asp:TextBox>
        </div>

        <div class="btn-container">
            <asp:Button ID="SendMessageButton" runat="server" Text="Send Message" OnClick="SendMessageButton_Click" />
        </div>

     
        <div class="input-group">
            <strong>Enter Sender ID to Show Messages:</strong>
            <asp:TextBox ID="SenderID2" runat="server"></asp:TextBox>
        </div>

          <div class="input-group">
            <strong>Enter Receiver ID to Show Messages:</strong>
            <asp:TextBox ID="ReceiverID2" runat="server"></asp:TextBox>
        </div>

        <div class="btn-container">
            <asp:Button ID="hello" runat="server" Text="Show User Messages" OnClick="ShowUserMessages" />
        </div>

        <div class="output-container">
            <asp:Literal ID="MessagesOutput" runat="server"></asp:Literal>
        </div>
       
        <asp:GridView ID="MessagesGridView" runat="server"  >
               
            </asp:GridView>


        
        <div class="btn-container">
            <asp:Button ID="Button2" runat="server" Text="Delete Message" OnClick="Delete" Visible="false" />
        </div>

    </form>
</body>
</html>
