<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModifyScheduleStatus.aspx.cs" Inherits="WebAssignment.ModifyScheduleStatus" MasterPageFile="~/Site2.Master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server" >
    <div>
    
        <asp:Label ID="Label1" runat="server" style="font-weight: 700; text-decoration: underline" Text="Update Schedule"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Schedule ID : "></asp:Label>
        
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Depart To : "></asp:Label>
        <asp:TextBox ID="txtDestination" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Bus ID : "></asp:Label>
        <asp:TextBox ID="txtbusID" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Depart Date : "></asp:Label>
        <asp:TextBox ID="txtDate" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Schedule Status : "></asp:Label>
        <asp:DropDownList ID="ddlstatus" runat="server" Width="106px">
            <asp:ListItem>On Going</asp:ListItem>
            <asp:ListItem>Departed</asp:ListItem>
            <asp:ListItem>Arived</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Button ID="txtUpdate" runat="server" Text="Update" OnClick="txtUpdate_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="txtRetrieve" runat="server" OnClick="txtRetrieve_Click" Text="Retrieve" />
&nbsp;&nbsp;&nbsp;
    
        <asp:Button ID="txtDelete" runat="server" OnClick="txtDelete_Click" Text="Delete" />
    
    </div>
   </asp:Content>
