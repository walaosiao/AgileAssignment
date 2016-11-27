<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteCustomer.aspx.cs" Inherits="CRUD.Customer.DeleteCustomer" MasterPageFile="~/Site2.Master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server" >
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
   </asp:Content>
