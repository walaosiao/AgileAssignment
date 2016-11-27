<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBus.aspx.cs" Inherits="WebAssignment.AddBus" MasterPageFile="~/Site2.Master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server" >
        <asp:Label ID="Label1" runat="server" style="font-weight: 700; text-decoration: underline" Text="Add Bus"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Bus ID : "></asp:Label>
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Bus Plate Number : "></asp:Label>
        <asp:TextBox ID="txtPlatenum" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Bus Model : "></asp:Label>
        <asp:TextBox ID="txtModel" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Bus Driver : "></asp:Label>
        <asp:DropDownList ID="ddlbusdriver" runat="server" DataSourceID="BusDataSource1" DataTextField="driverID" DataValueField="driverID">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnReset" runat="server" Text="Reset" />
        <br />
        <br />
        <asp:SqlDataSource ID="BusDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BusTicketingConnectionString %>" SelectCommand="SELECT * FROM [Driver]"></asp:SqlDataSource>
        <br />
        <br />
        <br />
    </asp:Content>