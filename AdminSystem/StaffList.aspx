<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin-left: 72px">
    <form id="form1" runat="server">
        <asp:Button ID="btnDelete" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 497px; top: 442px; position: absolute; height: 26px" Text="Delete" />
        <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 206px; top: 71px; position: absolute; height: 314px; width: 339px"></asp:ListBox>
        <div style="height: 55px; margin-left: 150px">
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; top: 426px; position: absolute; width: 101px; height: 37px; right: 491px" Text="Edit" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 191px; top: 526px; position: absolute"></asp:Label>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 191px; top: 425px; position: absolute; height: 37px; width: 101px; right: 628px;" Text="Add" />
        </div>
    </form>
</body>
</html>
