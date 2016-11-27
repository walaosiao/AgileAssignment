<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchStaff.aspx.cs" Inherits="CRUD.Customer.Staff.Search" MasterPageFile="~/Site2.Master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server" >
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

    <div>
    
        Search Staff<br />
        <br />
        Staff ID:<asp:TextBox ID="txtID" runat="server"></asp:TextBox>
    
    </div>
    <p>
        Result :</p>
    <table style="width:100%;">
        <tr>
            <td class="auto-style1">Staff Name :</td>
            <td>
                <asp:TextBox ID="txtName" runat="server" Enabled="False"></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td class="auto-style1">Staff IC :</td>
            <td>
                <asp:TextBox ID="txtIC" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Staff Address :</td>
            <td>
                <asp:TextBox ID="txtAdd" runat="server" Enabled="False"></asp:TextBox>
            </td>           
        </tr>
         <tr>
            <td class="auto-style2">Staff Position :</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtPost" runat="server" Enabled="False"></asp:TextBox>
             </td>           
        </tr>
        <tr>
            <td class="auto-style1">Staff Salary:</td>
            <td>
                <asp:TextBox ID="txtSalary" runat="server" Enabled="False"></asp:TextBox>
            </td>           
        </tr>
        <tr>
            <td class="auto-style1">Staff Contact :</td>
            <td>
                <asp:TextBox ID="txtCont" runat="server" Enabled="False"></asp:TextBox>
            </td>           
        </tr>
        <tr>
            <td>Password :</td>
            <td>
                <asp:TextBox ID="txtCpass" runat="server" Enabled="False"></asp:TextBox>
            </td>
       </tr>   
             <tr>
            <td>Staff Status</td>
            <td>
                <asp:TextBox ID="txtStatus" runat="server" Enabled="False" OnTextChanged="txtStatus_TextChanged"></asp:TextBox>
                 </td>
       </tr> 
        <tr>
            <td class="auto-style1">
                <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
            </td>
            <td>
                <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click1" Text="Reset" />
            </td>           
        </tr>
    </table>
        <asp:Label ID="lblmsg" runat="server"></asp:Label>
  </asp:Content>