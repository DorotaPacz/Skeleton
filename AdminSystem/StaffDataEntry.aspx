<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    Welcome, this is Staff Management Website.
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="ListBox1" runat="server" style="z-index: 1; left: 253px; top: 80px; position: absolute; height: 169px; width: 399px"></asp:ListBox>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 256px; top: 295px; position: absolute; width: 247px; height: 23px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 261px; top: 342px; position: absolute"></asp:Label>
        <asp:Label ID="lblNames" runat="server" style="z-index: 1; left: 257px; top: 265px; position: absolute" Text="Please enter ID:"></asp:Label>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 558px; top: 298px; position: absolute; width: 94px; height: 31px; right: 833px;" Text="OK" OnClick="btnDisplay_Click" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 683px; top: 298px; position: absolute; width: 99px; height: 32px;" Text="Add" OnClick="btnDisplayAll_Click" />
    </form>
</body>
</html>
