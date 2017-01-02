<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddSchedule.aspx.cs" Inherits="WebAssignment.AddSchedule" MasterPageFile="~/Site2.Master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server" >
    <div>
    
        <asp:Label ID="Label1" runat="server" style="font-weight: 700; text-decoration: underline" Text="Add Schedule"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Schedule ID : "></asp:Label>
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="From : "></asp:Label>
        <asp:DropDownList ID="ddlFrom" runat="server">
            <asp:ListItem>Penang</asp:ListItem>
            <asp:ListItem>Johor</asp:ListItem>
            <asp:ListItem>Kuala Lumpur</asp:ListItem>
            <asp:ListItem>Sabah</asp:ListItem>
            <asp:ListItem>Perak</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Destination : "></asp:Label>
        <asp:DropDownList ID="ddlDestination" runat="server">
            <asp:ListItem>Penang</asp:ListItem>
            <asp:ListItem>Pahang</asp:ListItem>
            <asp:ListItem>Kuala Lumpur</asp:ListItem>
            <asp:ListItem>Johor</asp:ListItem>
            <asp:ListItem>Sabah</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Departure Date : "></asp:Label>
        <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
        <asp:Calendar ID="DepartDateCalender" runat="server" OnSelectionChanged="DepartDateCalender_SelectionChanged">
        </asp:Calendar>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Depart Time : "></asp:Label>
        <asp:DropDownList ID="ddlTime" runat="server">
            <asp:ListItem>09:00 AM</asp:ListItem>
            <asp:ListItem>10:00 AM</asp:ListItem>
            <asp:ListItem>11:00 AM</asp:ListItem>
            <asp:ListItem>12:00 PM</asp:ListItem>
            <asp:ListItem>13:00 PM</asp:ListItem>
            <asp:ListItem>14:00 PM</asp:ListItem>
            <asp:ListItem>15:00 PM</asp:ListItem>
            <asp:ListItem>16:00 PM</asp:ListItem>
            <asp:ListItem>17:00 PM</asp:ListItem>
            <asp:ListItem>18:00 PM</asp:ListItem>
            <asp:ListItem>19:00 PM</asp:ListItem>
            <asp:ListItem>20:00 PM</asp:ListItem>
            <asp:ListItem>21:00 PM</asp:ListItem>
            <asp:ListItem>22:00 PM</asp:ListItem>
            <asp:ListItem>23:00 PM</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Bus ID : "></asp:Label>
        &nbsp;<asp:DropDownList ID="ddlBusID" runat="server" DataSourceID="BusDataSource" DataTextField="busID" DataValueField="busID" OnSelectedIndexChanged="ddlBusID_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:SqlDataSource ID="BusDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:BusTicketingConnectionString2 %>" SelectCommand="SELECT * FROM [Bus]"></asp:SqlDataSource>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Driver ID : "></asp:Label>
        <asp:DropDownList ID="ddlDriverID" runat="server" DataSourceID="DriverDataSource1" DataTextField="driverID" DataValueField="driverID">
        </asp:DropDownList>
        <asp:SqlDataSource ID="DriverDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BusTicketingConnectionString2 %>" SelectCommand="SELECT * FROM [Driver]"></asp:SqlDataSource>
        <br />
        <asp:Button ID="txtSubmit" runat="server" OnClick="txtSubmit_Click" Text="Submit" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="txtReset" runat="server" Text="Reset" />
        <br />
        <br />
    
    </div>
 </asp:Content>