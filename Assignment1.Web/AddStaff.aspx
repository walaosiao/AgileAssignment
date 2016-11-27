<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStaff.aspx.cs" Inherits="CRUD.Customer.Staff.AddStaff" MasterPageFile="~/Site2.Master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server" >
    <style type="text/css">

        .auto-style2 {
            width: 124px;
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style1 {
            width: 124px;
        }
        </style>

    <div>
    
    <div>
    
        Add Staff :<br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="StaffID" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="StaffID" HeaderText="StaffID" ReadOnly="True" SortExpression="StaffID" />
                <asp:BoundField DataField="StaffName" HeaderText="StaffName" SortExpression="StaffName" />
                <asp:BoundField DataField="StaffIC" HeaderText="StaffIC" SortExpression="StaffIC" />
                <asp:BoundField DataField="StaffAddress" HeaderText="StaffAddress" SortExpression="StaffAddress" />
                <asp:BoundField DataField="StaffPosition" HeaderText="StaffPosition" SortExpression="StaffPosition" />
                <asp:BoundField DataField="StaffSalary" HeaderText="StaffSalary" SortExpression="StaffSalary" />
                <asp:BoundField DataField="StaffContact" HeaderText="StaffContact" SortExpression="StaffContact" />
                <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
                <asp:BoundField DataField="StaffStatus" HeaderText="StaffStatus" SortExpression="StaffStatus" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BusTicketingConnectionString %>" SelectCommand="SELECT * FROM [staff]"></asp:SqlDataSource>
    
        <br />
        <asp:Label ID="lblID" runat="server" Visible="False"></asp:Label>
    
    </div>
    <p>
        Please enter the following information :</p>
    <p>
        <table style="width:100%;">
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
                <td class="auto-style1">Staff Position</td>
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
                <td class="auto-style2">Staff Contact:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtCont" runat="server"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td>
                    Password :&nbsp;</td>
                <td>

                    <asp:TextBox ID="txtPass1" runat="server"></asp:TextBox>

                </td>

            </tr>
            <tr>
                <td>
                    Confirm Password :</td>
                <td>

                    <asp:TextBox ID="txtCpass" runat="server"></asp:TextBox>

                </td>
                       <tr>
                <td class="auto-style4">

                    Staff Status :</td>
                <td class="auto-style4">

                    <asp:DropDownList ID="ddl" runat="server" OnSelectedIndexChanged="ddl_SelectedIndexChanged">
                        <asp:ListItem>Active</asp:ListItem>
                        <asp:ListItem>Resign</asp:ListItem>
                        <asp:ListItem>Retired</asp:ListItem>
                    </asp:DropDownList>

                </td>
            </tr>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
                </td>
                <td>
                    <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" />
                </td>
                
            </tr>
        </table>
    </p>
        <asp:Label ID="lblmsg" runat="server"></asp:Label>
    
    </div>
   </asp:Content>