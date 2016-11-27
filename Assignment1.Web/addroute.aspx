<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addroute.aspx.cs" Inherits="Assignment1.Web.addroute" MasterPageFile="~/Site2.Master" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server" >
    <style type="text/css">
        .auto-style1 {
            width: 169px;
        }
        .auto-style2 {
            width: 169px;
            height: 28px;
        }
        .auto-style3 {
            height: 28px;
        }
        .validatorcallouthighlight {
            background-color:lemonchiffon;

        }
       
    </style>

    
    
    <div id="dvGrid" style="padding:10px;width:498px; height: 325px;">

        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
    
    <asp:UpdatePanel ID="Up" runat="server">
        <ContentTemplate>
            
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="RouteID" DataSourceID="SqlDataSource1" AllowPaging="True" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="RouteID" HeaderText="RouteID" InsertVisible="False" ReadOnly="True" SortExpression="RouteID" />
                        <asp:BoundField DataField="RouteDepart" HeaderText="RouteDepart" SortExpression="RouteDepart" />
                        <asp:BoundField DataField="RouteDestination" HeaderText="RouteDestination" SortExpression="RouteDestination" />
                        <asp:BoundField DataField="BusFare" HeaderText="BusFare" SortExpression="BusFare" />
                    </Columns>
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
        </ContentTemplate>
        </asp:UpdatePanel>
  

         </div>
                <br />
        <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="Up">
        <ProgressTemplate>
            &nbsp;
        </ProgressTemplate>
        </asp:UpdateProgress>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BusTicketingConnectionString %>" DeleteCommand="DELETE FROM [route] WHERE [RouteID] = @RouteID" InsertCommand="INSERT INTO [route] ([RouteDepart], [RouteDestination], [BusFare]) VALUES (@RouteDepart, @RouteDestination, @BusFare)" SelectCommand="SELECT * FROM [route]" UpdateCommand="UPDATE [route] SET [RouteDepart] = @RouteDepart, [RouteDestination] = @RouteDestination, [BusFare] = @BusFare WHERE [RouteID] = @RouteID" OnSelecting="SqlDataSource1_Selecting">
                    <DeleteParameters>
                        <asp:Parameter Name="RouteID" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="RouteDepart" Type="String" />
                        <asp:Parameter Name="RouteDestination" Type="String" />
                        <asp:Parameter Name="BusFare" Type="String" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="RouteDepart" Type="String" />
                        <asp:Parameter Name="RouteDestination" Type="String" />
                        <asp:Parameter Name="BusFare" Type="String" />
                        <asp:Parameter Name="RouteID" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>
                <br />
        <asp:Label ID="Label2" runat="server" Visible="False"></asp:Label>
                <br />
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style1">Route Depart :</td>
                        <td>
                            <asp:TextBox ID="txtDepart" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtDepart"  Display="None" ErrorMessage="Required Depart is missing" ValidationGroup="1" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:ValidatorCalloutExtender ID="ValidatorCalloutExtender1" TargetControlID="RequiredFieldValidator1" HighlightCssClass="validatorcallouthighlight" runat="server"></asp:ValidatorCalloutExtender>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Route Destination :</td>
                        <td>
                            <asp:TextBox ID="txtDest" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtDest"  Display="None" ErrorMessage="Required Destination is missing" ForeColor="Red" SetFocusOnError="True" ValidationGroup="1"></asp:RequiredFieldValidator>
                            <asp:ValidatorCalloutExtender ID="ValidatorCalloutExtender2" TargetControlID="RequiredFieldValidator2" HighlightCssClass="validatorcallouthighlight" runat="server"></asp:ValidatorCalloutExtender>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Bus Fare :</td>
                        <td>
                            <asp:TextBox ID="txtFare" runat="server"></asp:TextBox>
                            <asp:FilteredTextBoxExtender ID="txtFare_FilteredTextBoxExtender" runat="server" TargetControlID="txtFare" FilterType="Numbers">
                            </asp:FilteredTextBoxExtender>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtFare" Display="None" ErrorMessage="Required Bus Fare is missing" ForeColor="Red" ValidationGroup="1"></asp:RequiredFieldValidator>
                            <asp:ValidatorCalloutExtender ID="ValidatorCalloutExtender3" TargetControlID="RequiredFieldValidator3" HighlightCssClass="validatorcallouthighlight" runat="server"></asp:ValidatorCalloutExtender>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Add" ValidationGroup="1" style="width: 37px" />
                            
                            <asp:ConfirmButtonExtender ID="btnSubmit_ConfirmButtonExtender" runat="server" ConfirmText="Are you sure to Add?" Enabled="True" TargetControlID="btnSubmit">
                            </asp:ConfirmButtonExtender>
                            
                        </td>
                        <td class="auto-style3">
                            <asp:Button ID="btnReset" runat="server" Text="Reset" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


                            



                        </td>
                    </tr>
                </table>     
                <asp:Label ID="Label1" runat="server"></asp:Label>
            
                <br />
                <br />
    
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            
      </asp:Content>
   