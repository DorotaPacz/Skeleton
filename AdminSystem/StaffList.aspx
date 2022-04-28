<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin-left: 72px">
    <form id="ListView" runat="server" style="font-family: Arial, Helvetica, sans-serif; font-size: large; font-weight: normal; color: #0000FF; background-color: #0000FF">
        <asp:Button ID="btnDelete" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 300px; top: 406px; position: absolute; height: 40px; width: 86px;" Text="Delete" BackColor="LightBlue" />
        <div style="height: 55px; margin-left: 150px; font-size: medium;">
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 2; top: 405px; position: absolute; width: 86px; height: 40px; right: 506px" Text="Edit" BackColor="LightBlue" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 191px; top: 557px; position: absolute"></asp:Label>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 210px; top: 406px; position: absolute; height: 40px; width: 86px; right: 884px;" Text="Add" BackColor="LightBlue" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; top: 509px; position: absolute; width: 86px; height: 40px; left: 377px" Text="Clear" BackColor="LightBlue" />
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 276px; top: 508px; position: absolute; width: 86px; height: 40px" Text="Apply" BackColor="LightBlue" />
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 206px; top: 71px; position: absolute; height: 314px; width: 339px" BackColor="SkyBlue"></asp:ListBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 195px; top: 467px; position: absolute" Text="Enter staff name"></asp:Label>
        <asp:TextBox ID="txtStaffName" runat="server" BorderColor="Black" style="z-index: 1; top: 466px; position: absolute; height: 28px; width: 211px; left: 368px" BackColor="SkyBlue"></asp:TextBox>
    </form>
</body>
</html>
