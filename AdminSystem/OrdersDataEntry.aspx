<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p> ************* ORDER FORM *************** </p>
        <asp:Label ID="lblOrderID" runat="server" Text="Order ID"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click" Text="Find Order" />
        <br />
        <br />

        <asp:Label ID="Date" runat="server" Text="Date" width="57px"></asp:Label>
        <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
        <br />
        <br />

        <asp:Label ID="lblTotalPrice" runat="server" Text="Total Price" width="57px"></asp:Label>
        <asp:TextBox ID="txtTotalPrice" runat="server"></asp:TextBox>
        <br />
        <br />

        <asp:CheckBox ID="chkFulfilled" runat="server" Text="is fulfilled?" />
        <br />
        <br />

        <p>
            <asp:Button ID="btnOK1" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel1" runat="server" Text="Cancel" />
        </p>
        <br />
        <br />

        <p> *********** ORDERLINE FORM ************* </p>
        <asp:Label ID="lblStockItemNo" runat="server" Text="StockItemNo"></asp:Label>
        <asp:TextBox ID="txtStockItemNo" runat="server"></asp:TextBox>
                <asp:Button ID="btnFindOrderLine" runat="server" OnClick="Button2_Click" Text="Find Orderline" />

        <br />
        <br />

        <asp:Label ID="lblOrderIdagain" runat="server" Text="OrderID" width="83px"></asp:Label>
        <asp:TextBox ID="txtOrderIDagain" runat="server"></asp:TextBox>
        <br />
        <br />

        <asp:Label ID="lblQuantity" runat="server" Text="Quantity" width="83px"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
        <br />
        <br />

         <p>
            <asp:Button ID="btnOK2" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel2" runat="server" Text="Cancel" />
        </p>

        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
    </form>

   

</body>
</html>
