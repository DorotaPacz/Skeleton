<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SuppliersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblSupplierID" runat="server" Text="SupplierId" width="184px"></asp:Label>
        <asp:TextBox ID="txtSupplierId" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblSupplierName" runat="server" Text="SupplierName" width="184px"></asp:Label>
        <asp:TextBox ID="txtSupplierName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblSupplierContactNo" runat="server" Text="SupplierContactNo"></asp:Label>
        <asp:TextBox ID="txtSupplierContactNo" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblSupplierEmail" runat="server" Text="SupplierEmail" width="184px"></asp:Label>
        <asp:TextBox ID="txtSupplierEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblSupplierAddress" runat="server" Text="SupplierAddress" width="184px"></asp:Label>
        <asp:TextBox ID="txtSupplierAddress" runat="server"></asp:TextBox>
        <br />
        <asp:CheckBox ID="chkSupplierAvailable" runat="server" Text="SupplierAvailable" width="184px" />
        <br />
        <asp:Label ID="iblError" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
