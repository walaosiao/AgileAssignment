<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditStaff.aspx.cs" Inherits="CRUD.Customer.Staff.EditStaff" MasterPageFile="~/Site2.Master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server" >
    
    <style type="text/css">

        .auto-style1 {
            width: 124px;
        }
        .auto-style2 {
            width: 124px;
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
        }
        </style>

    <div>
    
        Edit Staff Details:<br />
        <br />
        Please enter the Staff ID:<br />
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        <asp:Button ID="btncCheck" runat="server" OnClick="btncCheck_Click" Text="Check" style="height: 26px" />
        <br />
        <br />
        Please enter the following information:<table style="width:100%;">
            <tr>
                <td class="auto-style2">Staff Name :</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style2">Staff IC :</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtIC" runat="server"></asp:TextBox>
                </td>
               
            </tr>
            <tr>
                <td class="auto-style1">Staff Address:</td>
                <td>
                    <asp:TextBox ID="txtAdd" runat="server"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style1">Staff Position:</td>
                <td>
                    <asp:TextBox ID="txtPost" runat="server"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style1">Staff Salary:</td>
                <td>
                    <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
                </td>
              </tr>  
     
            
            <tr>
                <td class="auto-style1">Staff Contact:</td>
                <td>
                    <asp:TextBox ID="txtCont" runat="server"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td>
                    Password :</td>
                <td>

                    <asp:TextBox ID="txtCpass" runat="server"></asp:TextBox>

                </td>
                </tr>
                  <tr>
                <td class="auto-style4">

                    Staff Status :</td>
                <td class="auto-style4">

                    <asp:DropDownList ID="ddl" runat="server">
                        <asp:ListItem>Active</asp:ListItem>
                        <asp:ListItem>Resign</asp:ListItem>
                        <asp:ListItem>Retired</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="lblstatus" runat="server"></asp:Label>

                </td>
            </tr>


            <tr>
                <td class="auto-style1">
                    <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
                </td>
                <td>
                    <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" style="height: 26px" />
                </td>
                
            </tr>
        </table>
        <asp:Label ID="lblmsg" runat="server"></asp:Label>
        <br />
        </div>
   </asp:Content>