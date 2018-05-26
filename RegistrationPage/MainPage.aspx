<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainPage.aspx.cs" Inherits="MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="grid" runat="server">
            </asp:GridView>
            <asp:Label ID="Label1" runat="server" Text="Type"></asp:Label>
            <asp:TextBox ID="txtType" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Calories burned"></asp:Label>
            <asp:TextBox ID="txtCalories" runat="server"></asp:TextBox>
            <asp:Button ID="btnRefresh" runat="server" OnClick="btnRefresh_Click" Text="Refresh" />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Duration"></asp:Label>
            <asp:TextBox ID="txtDuration" runat="server"></asp:TextBox>
            <asp:Button ID="btnCreate" runat="server" OnClick="btnCreate_Click" Text="Create" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
