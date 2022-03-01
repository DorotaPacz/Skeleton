<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin-left: 72px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblAdmin" runat="server" style="z-index: 1; left: 69px; top: 269px; position: absolute" Text="Admin (Yes/ No)"></asp:Label>
        <asp:Label ID="lblSalary" runat="server" style="z-index: 1; left: 69px; top: 227px; position: absolute" Text="Salary"></asp:Label>
        <asp:Label ID="lblDate" runat="server" style="z-index: 1; left: 71px; top: 188px; position: absolute" Text="Date Started (Today)"></asp:Label>
        <asp:Label ID="lblId" runat="server" style="z-index: 1; left: 75px; top: 99px; position: absolute" Text="ID Number"></asp:Label>
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 73px; top: 142px; position: absolute" Text="Full Name"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 234px; top: 182px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 237px; top: 143px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 237px; top: 100px; position: absolute; height: 22px; width: 128px"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 233px; top: 224px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 231px; top: 263px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnDisplay" runat="server" style="z-index: 1; left: 333px; top: 334px; position: absolute; width: 100px; height: 31px; right: 1077px" Text="Display" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 456px; top: 333px; position: absolute; height: 31px; width: 100px; right: 954px" Text="Display All" OnClick="btnDisplayAll_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 77px; top: 336px; position: absolute; width: 100px; height: 31px" Text="Edit" />
        <asp:Button ID="Button4" runat="server" style="z-index: 1; left: 205px; top: 336px; position: absolute; width: 100px; height: 31px" Text="Delete" />
        <asp:Button ID="btnSave" runat="server" style="z-index: 1; left: 415px; top: 250px; position: absolute; width: 100px; height: 31px" Text="Save" />
    </form>
</body>
</html>
