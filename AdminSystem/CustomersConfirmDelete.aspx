<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDeleteConfirmation" runat="server" Text="Are you sure you want to delete this recored?"></asp:Label>
        <p>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="height: 26px" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" Text="No" />
        </p>
    </form>
</body>
</html>
