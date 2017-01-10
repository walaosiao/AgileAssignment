﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCustomer.aspx.cs" Inherits="CRUD.Customer.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="CusID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="CusID" HeaderText="CusID" ReadOnly="True" SortExpression="CusID" />
                <asp:BoundField DataField="CusName" HeaderText="CusName" SortExpression="CusName" />
                <asp:BoundField DataField="CusIC" HeaderText="CusIC" SortExpression="CusIC" />
                <asp:BoundField DataField="CusAddress" HeaderText="CusAddress" SortExpression="CusAddress" />
                <asp:BoundField DataField="CusEmail" HeaderText="CusEmail" SortExpression="CusEmail" />
                <asp:BoundField DataField="CusContact" HeaderText="CusContact" SortExpression="CusContact" />
                <asp:BoundField DataField="CusStatus" HeaderText="CusStatus" SortExpression="CusStatus" />
            </Columns>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:busConn %>" SelectCommand="SELECT * FROM [Customer]"></asp:SqlDataSource>
    
        <br />
        <asp:Label ID="lblID" runat="server" Visible="False"></asp:Label>
    
    </div>
    //prompt user input
    <p>
        Customer is required to enter your personal details :</p>
    <p>
        <table style="width:100%;">
            <tr>
                <td class="auto-style2">Customer Name :</td>
                <td class="auto-style3">
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
                <td class="auto-style1">Customer Account Status</td>
                <td>
                    <asp:DropDownList ID="ddl" runat="server">
                        <asp:ListItem>Active</asp:ListItem>
                        <asp:ListItem>Inactive</asp:ListItem>
                    </asp:DropDownList>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
                </td>
                <td>
                    <asp:Button ID="btnReset" runat="server" Text="Reset" />
                </td>
                
            </tr>
        </table>
    </p>
        <asp:Label ID="lblmsg" runat="server"></asp:Label>
    </form>
    </body>
</html>
