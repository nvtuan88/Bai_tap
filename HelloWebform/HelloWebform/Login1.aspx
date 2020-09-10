<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login1.aspx.cs" Inherits="HelloWebform.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            User name<asp:TextBox ID="TextBox1" runat="server" style="margin-left: 23px" Width="223px"></asp:TextBox>
        </p>
        PassWord<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 24px" Width="219px"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
        </p>
    </form>
</body>
</html>
