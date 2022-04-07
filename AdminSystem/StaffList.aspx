<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin-left: 72px">
    <form id="form1" runat="server">
        <asp:Button ID="btnDelete" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 322px; top: 406px; position: absolute; height: 40px; width: 86px;" Text="Delete" />
        <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 206px; top: 71px; position: absolute; height: 314px; width: 339px"></asp:ListBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 195px; top: 467px; position: absolute" Text="Enter staff name"></asp:Label>
        <asp:TextBox ID="txtStaffName" runat="server" BorderColor="Black" style="z-index: 1; top: 460px; position: absolute; height: 28px; width: 211px; left: 304px"></asp:TextBox>
        <div style="height: 55px; margin-left: 150px">
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; top: 406px; position: absolute; width: 86px; height: 40px; right: 977px" Text="Edit" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 191px; top: 557px; position: absolute"></asp:Label>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 210px; top: 406px; position: absolute; height: 40px; width: 86px; " Text="Add" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; top: 508px; position: absolute; width: 86px; height: 40px; left: 415px" Text="Clear" />
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 276px; top: 508px; position: absolute; width: 86px; height: 40px" Text="Apply" />
        </div>
    </form>
</body>
</html>
