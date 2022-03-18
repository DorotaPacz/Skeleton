<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 267px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStockItemNo" runat="server" Text="Stock Item Number"></asp:Label>
        <asp:TextBox ID="txtStockNo" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblStockItemDescription" runat="server" Text="Stock Item Description" width="121px"></asp:Label>
            <asp:TextBox ID="txtStockItemDesc" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblDateAdded" runat="server" Text="Date Added" width="121px"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblPrice" runat="server" Text="Price" width="121px"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblQuantityInStock" runat="server" Text="Quantity In Stock" width="121px"></asp:Label>
        <asp:TextBox ID="txtQuantityInStock" runat="server"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkAvailable" runat="server" Text="Available" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
