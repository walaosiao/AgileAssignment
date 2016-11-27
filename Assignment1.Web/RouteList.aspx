<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RouteList.aspx.cs" Inherits="Assignment1.Web.RouteList" MasterPageFile="~/Site2.Master" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

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
    
        Route List:<br />
        <br />
    
    </div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div id="printableArea">
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
<br />          </div>
<br />
                    <asp:Button ID="btnPrint" runat="server" Text="Print" OnClientClick="printDiv();" />
<br />
                
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            </ContentTemplate>
        </asp:UpdatePanel>
    </asp:Content>