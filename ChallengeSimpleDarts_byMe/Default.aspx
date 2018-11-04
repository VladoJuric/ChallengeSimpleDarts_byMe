<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleDarts_byMe.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            background-color: #CC3300;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
            <span class="auto-style1"><strong><span class="auto-style3">Wellcome to Cricket Darts !!!</span></strong></span><br />
            <br />
            <asp:Button ID="game301Button" runat="server" OnClick="game301Button_Click" Text="301" />
&nbsp;<asp:Button ID="game501Button" runat="server" OnClick="game501Button_Click" Text="501" />
&nbsp;<asp:Button ID="game701Button" runat="server" OnClick="game701Button_Click" Text="701" />
&nbsp;<asp:Button ID="game1001Button" runat="server" OnClick="game1001Button_Click" Text="1001" />
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Play !" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
