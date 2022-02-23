<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    Welcome, this is Staff Management Website
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 448px; top: 383px; position: absolute; height: 35px; width: 70px" Text="Delete" />
        <asp:ListBox ID="ListBox1" runat="server" style="z-index: 1; left: 253px; top: 80px; position: absolute; height: 169px; width: 399px"></asp:ListBox>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 256px; top: 295px; position: absolute; width: 247px; height: 23px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 261px; top: 342px; position: absolute"></asp:Label>
        <asp:Label ID="lblNames" runat="server" style="z-index: 1; left: 257px; top: 265px; position: absolute" Text="Please enter name:"></asp:Label>
        <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 557px; top: 345px; position: absolute; width: 94px" Text="Button" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 260px; top: 381px; position: absolute; height: 37px; width: 71px" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 357px; top: 382px; position: absolute; height: 34px; width: 71px" Text="Edit" />
        <asp:Button ID="btnDisplay" runat="server" style="z-index: 1; left: 553px; top: 300px; position: absolute; width: 99px" Text="Display All" />
    </form>
</body>
</html>
