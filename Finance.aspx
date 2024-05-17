<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Finance.aspx.cs" Inherits="HomeSync.Finance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Finance Management</title>
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

        .input-group input {
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

        .error-message {
            color: red;
            margin-top: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Finance Management</h2>
        <div class="input-group">
            <strong>Enter Receiver Id:</strong>
            <asp:TextBox ID="ReciverID" runat="server"></asp:TextBox>
        </div>

        <div class="input-group">
            <strong>Enter Type:</strong>
            <asp:TextBox ID="Type" runat="server"></asp:TextBox>
        </div>

        <div class="input-group">
            <strong>Enter Amount:</strong>
            <asp:TextBox ID="Amount" runat="server"></asp:TextBox>
        </div>

        <div class="input-group">
            <strong>Enter Status:</strong>
            <asp:TextBox ID="Status" runat="server"></asp:TextBox>
        </div>

        <div class="input-group">
            <strong>Enter Date:</strong>
            <asp:TextBox ID="Date" runat="server"></asp:TextBox>
        </div>

        <div class="btn-container">
            <asp:Button ID="InsertButton" runat="server" Text="Insert Data" OnClick="InsertButton_Click" />
        </div>

        <hr />

        <div class="input-group">
            <strong>Enter Sender Id:</strong>
            <asp:TextBox ID="SenderID" runat="server"></asp:TextBox>
        </div>

        <div class="input-group">
            <strong>Enter Receiver Id:</strong>
            <asp:TextBox ID="ReceiverID1" runat="server"></asp:TextBox>
        </div>

        <div class="input-group">
            <strong>Enter Amount:</strong>
            <asp:TextBox ID="Amount2" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </div>

        <div class="input-group">
            <strong>Enter Status:</strong>
            <asp:TextBox ID="Status2" runat="server"></asp:TextBox>
        </div>

        <div class="input-group">
            <strong>Enter Deadline Date:</strong>
            <asp:TextBox ID="DeadlineDate" runat="server"></asp:TextBox>
        </div>

        <div class="btn-container">
            <asp:Button ID="PlanPaymentButton" runat="server" Text="Plan Payment" OnClick="PlanPaymentButton_Click" />
        </div>

        <div class="error-message" runat="server" id="ErrorMessageLabel"></div>
    </form>
</body>
</html>
