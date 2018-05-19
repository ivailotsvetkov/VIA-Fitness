<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" Width="216px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPass" runat="server" Width="216px"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Confirm password"></asp:Label>
        <asp:TextBox ID="txtConfirmPass" runat="server" Width="216px"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" Width="216px"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" Width="216px"></asp:TextBox>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Success" Visible="False"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" />
        </p>
    </form>
</body>
</html>
