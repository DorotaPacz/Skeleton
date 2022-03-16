<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblOrderID" runat="server" Text="Order ID"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click" Text="Find" />
        <br />
        <br />

        <asp:Label ID="lblTotalPrice" runat="server" Text="Total Price" width="57px"></asp:Label>
        <asp:TextBox ID="txtTotalPrice" runat="server"></asp:TextBox>
        <br />
        <br />

        <asp:CheckBox ID="chkFulfilled" runat="server" Text="is fulfilled?" />
        <br />
        <br />

        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>

    </form>
</body>
</html>
