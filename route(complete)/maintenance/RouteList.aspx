<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RouteList.aspx.cs" Inherits="maintenance.RouteList" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Route List:<br />
        <br />
    
    </div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                Search Route Name :
                <asp:TextBox ID="txtRouteName" runat="server" style="margin-top: 0px" AutoPostBack="true" OnTextChanged="GetRouteDetails"></asp:TextBox>
                <cc1:AutoCompleteExtender ID="txtDepart_AutoCompleteExtender" runat="server" BehaviorID="AutoCompleteEx" CompletionInterval="50" CompletionSetCount="10" EnableCaching="false" MinimumPrefixLength="2" ServiceMethod="SearchRoute" TargetControlID="txtRouteName" UseContextKey="True">
                </cc1:AutoCompleteExtender>
                <br />
<br />
                <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
                    <AlternatingRowStyle BackColor="White" />
                    <FooterStyle BackColor="#CCCC99" />
                    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                    <RowStyle BackColor="#F7F7DE" />
                    <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FBFBF2" />
                    <SortedAscendingHeaderStyle BackColor="#848384" />
                    <SortedDescendingCellStyle BackColor="#EAEAD3" />
                    <SortedDescendingHeaderStyle BackColor="#575357" />
                </asp:GridView>
<br />
<br />
<br />
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
