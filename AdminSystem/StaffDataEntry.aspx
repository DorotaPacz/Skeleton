<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="StaffForm" runat="server">
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 438px; top: 121px; position: absolute" Text="Find" />
    Welcome, this is Staff Management Website.
        <p style="margin-bottom: 0px">
            <asp:CheckBox ID="chkIsAdmin" runat="server" style="z-index: 1; left: 148px; top: 319px; position: absolute" Text="Is Admin " />
            <asp:TextBox ID="txtStaffSalary" runat="server" height="22px" style="z-index: 1; left: 258px; top: 273px; position: absolute" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtStaffStartDate" runat="server" height="22px" style="z-index: 1; left: 302px; top: 214px; position: absolute" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtStaffName" runat="server" style="z-index: 1; left: 245px; top: 169px; position: absolute; height: 22px" width="128px"></asp:TextBox>
            <asp:Label ID="lblSalary" runat="server" height="19px" style="z-index: 1; left: 155px; top: 279px; position: absolute" Text="Staff Salary" width="136px"></asp:Label>
            <asp:Label ID="lblDateStart" runat="server" style="z-index: 1; left: 148px; top: 223px; position: absolute" Text="Staff Registration Date"></asp:Label>
            <asp:Label ID="lblName" runat="server" height="19px" style="z-index: 1; left: 151px; top: 179px; position: absolute" Text="Staff Name" width="136px"></asp:Label>
        <asp:TextBox ID="txtStaffIdNo" runat="server" style="z-index: 1; left: 247px; top: 118px; position: absolute; height: 22px; width: 128px"></asp:TextBox>
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
