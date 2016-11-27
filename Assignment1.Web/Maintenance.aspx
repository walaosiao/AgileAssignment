<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Maintenance.aspx.cs" Inherits="Assignment1.Web.Maintenance" MasterPageFile="~/Site2.Master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server" >     
        <table align="center" style="width:500px;">
            <tr>
                <td class="auto-style2">        
                   
                    <strong>Route</strong></td>
                <td class="auto-style2">        
                    <strong>Customer</strong></td>
                <td class="auto-style3">
                    <strong>Staff</strong></td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                
                <td class="auto-style2">        
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/addroute.aspx">Add Route</asp:HyperLink>
                </td>
                <td class="auto-style3">
    <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/AddCustomer.aspx">Add Customer</asp:HyperLink>
                </td>
                <td>
    <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/AddStaff.aspx">Add Staff</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Edit.aspx">Edit Route</asp:HyperLink>
                </td>
                <td class="auto-style3">
        <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/EditCustomer.aspx">Edit Customer</asp:HyperLink>
                </td>
                <td>
        <asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl="~/EditStaff.aspx">Edit Staff</asp:HyperLink>
   
                </td>
            </tr>
            <%--<tr>--%>
                <td class="auto-style2">
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/RouteList.aspx">Route List</asp:HyperLink>
                </td>
                <td class="auto-style3">
        <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/DeleteCustomer.aspx">Delete Customer</asp:HyperLink>
                </td>
                <td>
        <asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/DeleteStaff.aspx">Delete Staff</asp:HyperLink>
                </td>
            </tr>
        </table>
   
     </asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style2 {
            width: 191px;
        }
        .auto-style3 {
            width: 210px;
        }
    </style>
</asp:Content>
