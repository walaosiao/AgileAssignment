<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="WebAssignment.Report" MasterPageFile="~/Site2.Master" %>





<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server" >
    
<script type="text/javascript">
    function printDiv() {

        var printContents = document.getElementById("printableArea").innerHTML;
        var originalContents2 = document.body.innerHTML;
        document.body.innerHTML = printContents;
        window.print();
        document.body.innerHTML = originalContents;

    }
    </script>
    <div>
    
        <asp:Label ID="Label1" runat="server" style="font-weight: 700; text-decoration: underline" Text="Report"></asp:Label>
        <br />
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem>Destination Report</asp:ListItem>
            <asp:ListItem>Bus Driver Schedule</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Panel ID="Panel1" runat="server" Visible="False" Width="366px">
            <asp:Label ID="Label2" runat="server" Text="Search By Destination : "></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="RouteDataSource" DataTextField="RouteDestination" DataValueField="RouteDestination">
            </asp:DropDownList>
            <asp:SqlDataSource ID="RouteDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:BusTicketingConnectionString %>" SelectCommand="SELECT * FROM [route]"></asp:SqlDataSource>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Visible="False" Width="364px">
            <asp:Label ID="Label5" runat="server" Text="Search By Bus Driver: "></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="DriverDataSource" DataTextField="driverID" DataValueField="driverID">
            </asp:DropDownList>
            <asp:SqlDataSource ID="DriverDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:BusTicketingConnectionString %>" SelectCommand="SELECT * FROM [Driver]"></asp:SqlDataSource>
        </asp:Panel>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Preview" />
        <br />
        <br />
        <div id="printableArea">
        <asp:Image ID="Image1" ImageUrl="Images/logobar.jpg" runat="server" Height="89px" Width="400px" Visible="False" />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Destination To : " Visible="False"></asp:Label>
            <asp:Label ID="Label3" runat="server"></asp:Label>
            <asp:Label ID="Label7" runat="server" Text="Driver by :" Visible="False"></asp:Label>
&nbsp;<asp:Label ID="Label6" runat="server" Visible="False"></asp:Label>
        <br />
        <br />
        
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        
    </div>
        <asp:Button ID="Button2" runat="server" OnClientClick="printDiv();" Text="Print" Visible="False" />
    </div>
   </asp:Content>