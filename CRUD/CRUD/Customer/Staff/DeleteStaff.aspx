<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteStaff.aspx.cs" Inherits="CRUD.Customer.Staff.Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
    <div>
    
        Delete Staff :<br />
        <br />
        Staff ID:&nbsp;
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" style="height: 26px" />
        <br />
        <asp:Label ID="lblmsg" runat="server"></asp:Label>
    
    </div>
    </form>

</body>
</html>
