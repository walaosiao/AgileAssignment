<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddDriver.aspx.cs" Inherits="WebAssignment.AddDriver" MasterPageFile="~/Site2.Master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server" >
    <div>
    
        <asp:Label ID="Label1" runat="server" style="font-weight: 700; text-decoration: underline" Text="Add Bus Driver"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Bus Driver ID :"></asp:Label>
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Bus Driver Name :"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="Age :"></asp:Label>
        <asp:TextBox ID="txtAge" runat="server" Width="86px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Gender :"></asp:Label>
        <asp:RadioButtonList ID="rbGender" runat="server">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Race :"></asp:Label>
        <asp:DropDownList ID="ddlRace" runat="server">
            <asp:ListItem>Chinese</asp:ListItem>
            <asp:ListItem>Malay</asp:ListItem>
            <asp:ListItem>Indians</asp:ListItem>
            <asp:ListItem>Bangladesh</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Licence Number :"></asp:Label>
        <asp:TextBox ID="txtLicence" runat="server"></asp:TextBox>
        <br />
        <br />
        Address :
        <asp:TextBox ID="txtAddress" runat="server" Height="24px" Width="254px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 29px" Text="Submit" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Reset" OnClick="Button2_Click" />
        <br />
        <br />
        <asp:Label ID="lblAdd" runat="server"></asp:Label>
    
    </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BusTicketingConnectionString %>" SelectCommand="SELECT * FROM [Driver]"></asp:SqlDataSource>
 
    </asp:Content>