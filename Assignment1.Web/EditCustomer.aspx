<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditCustomer.aspx.cs" Inherits="CRUD.Customer.EditCustomer" MasterPageFile="~/Site2.Master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server" >
    <style type="text/css">
        .auto-style1 {
            width: 121px;
        }
        .auto-style2 {
            width: 121px;
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
        }
    </style>
    <div>
    
        Edit Customer Details:<br />
        <br />
        Please enter the Customer ID:<br />
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        <asp:Button ID="btncCheck" runat="server" OnClick="btncCheck_Click" Text="Check" style="height: 26px" />
        <br />
        <br />
        Please enter the following information :</div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Customer Name :</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style2">Customer IC :</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtIC" runat="server"></asp:TextBox>
                </td>
               
            </tr>
            <tr>
                <td class="auto-style1">Customer Address:</td>
                <td>
                    <asp:TextBox ID="txtAdd" runat="server"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style1">Customer Email:</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style1">Customer Contact:</td>
                <td>
                    <asp:TextBox ID="txtCont" runat="server"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style1">Customer Status</td>
                <td>
                    <asp:DropDownList ID="ddl" runat="server" OnSelectedIndexChanged="ddl_SelectedIndexChanged">
                        <asp:ListItem>Active</asp:ListItem>
                        <asp:ListItem>Inactive</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="lblstatus" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
                </td>
                <td>
                    <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" />
                </td>
                
            </tr>
        </table>
        <asp:Label ID="lblmsg" runat="server"></asp:Label>
    </asp:Content>