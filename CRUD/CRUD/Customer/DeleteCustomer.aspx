<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteCustomer.aspx.cs" Inherits="CRUD.Customer.DeleteCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Delete Customer :<br />
        <br />
        Customer ID:&nbsp;
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" />
        <br />
        <asp:Label ID="lblmsg" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
