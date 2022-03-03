<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    Welcome, this is Staff Management Website.
    <form id="form1" runat="server">
        <p style="margin-bottom: 0px">
            <asp:CheckBox ID="chkIsAdmin" runat="server" style="z-index: 1; left: 146px; top: 297px; position: absolute" Text="Is Admin (Tick = Yes, Empty = No)" />
            <asp:TextBox ID="txtSalary" runat="server" height="22px" style="z-index: 1; left: 345px; top: 253px; position: absolute" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtStartDate" runat="server" height="22px" style="z-index: 1; left: 345px; top: 213px; position: absolute" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 345px; top: 169px; position: absolute; height: 22px" width="128px"></asp:TextBox>
            <asp:Label ID="lblSalary" runat="server" height="19px" style="z-index: 1; left: 149px; top: 243px; position: absolute" Text="Staff Salary" width="136px"></asp:Label>
            <asp:Label ID="lblDateStart" runat="server" style="z-index: 1; left: 149px; top: 203px; position: absolute" Text="Staff Registration Date"></asp:Label>
            <asp:Label ID="lblName" runat="server" height="19px" style="z-index: 1; left: 149px; top: 170px; position: absolute" Text="Staff Name" width="136px"></asp:Label>
        <asp:TextBox ID="txtIdNo" runat="server" style="z-index: 1; left: 345px; top: 125px; position: absolute; height: 22px; width: 128px"></asp:TextBox>
        </p>
        <div>
        </div>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 148px; top: 347px; position: absolute"></asp:Label>
        <asp:Label ID="lblIdNo" runat="server" style="z-index: 1; left: 149px; top: 124px; position: absolute" Text="Staff Id No" height="19px" width="136px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 138px; top: 397px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 300px; top: 397px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
