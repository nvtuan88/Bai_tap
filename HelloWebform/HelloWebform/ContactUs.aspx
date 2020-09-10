<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="HelloWebform.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Select1 {
            width: 135px;
            margin-left: 0px;
        }
        #TextArea1 {
            margin-left: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <asp:Label ID="IblMessage" runat="server" ForeColor="#FF0066" Text="IblMessage"></asp:Label>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Category"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" style="margin-left: 39px">
                <asp:ListItem Selected="True" Text="--Select---" Value="--Select--"></asp:ListItem>
                <asp:ListItem Text="News" Value="News"></asp:ListItem>
                <asp:ListItem Text="Report" Value="Report"></asp:ListItem>
                <asp:ListItem Text="System" Value="System"></asp:ListItem>
                <asp:ListItem Text="Reminder" Value="Reminder"></asp:ListItem>

            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Description"></asp:Label>
            <textarea id="TextArea1" cols="20" name="S1" rows="2"></textarea><br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"/>
        </div>

    </form>
</body>
</html>
