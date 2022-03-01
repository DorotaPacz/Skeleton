<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox1" runat="server" style="z-index: 1; left: 219px; top: 86px; position: absolute; height: 240px; width: 203px"></asp:ListBox>
            <asp:Label ID="lblStaff" runat="server" style="z-index: 1; left: 225px; top: 60px; position: absolute" Text="Staff List"></asp:Label>
        </div>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 206px; top: 364px; position: absolute" Text="Edit" />
        <asp:Button ID="btnMain" runat="server" OnClick="btnMain_Click" style="z-index: 1; left: 321px; top: 364px; position: absolute" Text="Main Page" />
    </form>
</body>
</html>
