<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?<br />
            <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" style="height: 26px" />
            <asp:Button ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click" />
            <p>       </p>
            <br />
        </div>
    </form>
</body>
</html>
