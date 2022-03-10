<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStudentDiscountPercentage" runat="server" Text="Student Discount Percentage"></asp:Label>
            <asp:TextBox ID="txtStudentDiscountPercentage" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name"></asp:Label>
            <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerDOB" runat="server" Text="Customer DOB"></asp:Label>
        <asp:TextBox ID="txtCustomerDOB" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server" OnTextChanged="txtCustomerID_TextChanged"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkIsStudnet" runat="server" Text="Studnet" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Height="26px" Text="Cancel" />
    </form>
</body>
</html>
