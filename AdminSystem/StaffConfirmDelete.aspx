<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 87px; top: 81px; position: absolute" Text="Yes" />
            Are you sure you want to delete this record?<asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 155px; top: 82px; position: absolute" Text="No" />
        </div>
    </form>
</body>
</html>
