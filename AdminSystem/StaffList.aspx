<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin-left: 72px">
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 191px; top: 425px; position: absolute; height: 37px; width: 101px" Text="Add" />
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 192px; top: 86px; position: absolute; height: 314px; width: 339px"></asp:ListBox>
    </form>
</body>
</html>
