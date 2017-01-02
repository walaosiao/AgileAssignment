<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search Customer.aspx.cs" Inherits="CRUD.Customer.EditBus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 134px;
        }
        .auto-style2 {
            width: 134px;
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Search For Customer Record<br />
        <br />
        Customer ID:<asp:TextBox ID="txtID" runat="server"></asp:TextBox>
    
    </div>
    <p>
        Result :</p>
    <table style="width:100%;">
        <tr>
            <td class="auto-style1">Customer Name :</td>
            <td>
                <asp:TextBox ID="txtName" runat="server" Enabled="False"></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td class="auto-style1">Customer IC :</td>
            <td>
                <asp:TextBox ID="txtIC" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Customer Address :</td>
            <td>
                <asp:TextBox ID="txtAdd" runat="server" Enabled="False"></asp:TextBox>
            </td>           
        </tr>
         <tr>
            <td class="auto-style2">Customer Email :</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtEmail" runat="server" Enabled="False"></asp:TextBox>
             </td>           
        </tr>
        <tr>
            <td class="auto-style1">Customer Contact :</td>
            <td>
                <asp:TextBox ID="txtCont" runat="server" Enabled="False"></asp:TextBox>
            </td>           
        </tr>
        <tr>
            <td class="auto-style1">Customer Status :</td>
            <td>
                <asp:TextBox ID="txtStatus" runat="server" Enabled="False" OnTextChanged="txtStatus_TextChanged" Visible="False"></asp:TextBox>
            </td>           
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
            </td>
            <td>
                <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="Reset" />
            </td>           
        </tr>
    </table>
        <asp:Label ID="lblmsg" runat="server"></asp:Label>
    </form>
    </body>
</html>
