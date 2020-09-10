<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="HelloWebform.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Calculator<br />
        <br />
        <br />
        <asp:Label ID="ResultMessage" runat="server" Text="Message"></asp:Label>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Numer1"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" CausesValidation="True" TextMode="Number"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Number2"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" CausesValidation="True" TextMode="Number"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="AddButton" runat="server" OnClick="AddButton_Click" Text="Add" />
        </p>

    </form>
</body>
</html>
