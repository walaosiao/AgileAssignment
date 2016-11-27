<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bussite.aspx.cs" Inherits="WebAssignment.Bussite" MasterPageFile="~/Site2.Master" %>


<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server" >
   

    <div>
    
        <br />
        <br />
        <br />
        <table align="center" style="width:500px;">
            <tr>
                <td class="auto-style4"><strong>Bus</strong></td>
                <td class="auto-style3"><strong>Schedule</strong></td>
            </tr>
            <tr>
                <td class="auto-style4">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/BusForm/AddBus.aspx">Add Bus</asp:HyperLink>
                </td>
                <td class="auto-style3">
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Schedule/AddSchedule.aspx">Add Schedule</asp:HyperLink>
                </td>
                <td class="menu">
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Schedule/Tracking.aspx">Track Bus Departure / Arival Time</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/BusForm/AddDriver.aspx">Add Bus Driver</asp:HyperLink>
                </td>
                <td class="auto-style3">
        <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Schedule/ModifyScheduleStatus.aspx">Print Report</asp:HyperLink>
                </td>
                <td class="menu">
        <asp:Button ID="Button1" runat="server" Text="Back" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="Report.aspx">Print Report</asp:HyperLink>
                </td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="menu">
                    &nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
    
    </div>
   </asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style3 {
            width: 166px;
            text-align: center;
        }
        .auto-style4 {
            width: 170px;
            text-align: center;
        }
    </style>
</asp:Content>
