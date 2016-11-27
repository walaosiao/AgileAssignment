<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SalesPages.aspx.cs" Inherits="Assignment1.Web.SalesPages" MasterPageFile="~/Site2.Master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server" >
   

    <div>
    
    </div> 
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BusTicketingConnectionString %>" SelectCommand="SELECT [destinationLocation] FROM [Schedule]"></asp:SqlDataSource>
                    
                   
              
                     <table style="width:59%;">
                         <tr>
                             <td class="auto-style2">
        
                   
                    <asp:RadioButton ID="RadioButton1" runat="server" Text="One Way Trip" GroupName="Categories" />
            
                    
                             </td>
                             <td>&nbsp;</td>
                         </tr>
                         <tr>
                             <td class="auto-style2">
            
                    
                                 <asp:Label ID="Label6" runat="server" Text="Origin"></asp:Label>
                    
                   
                             </td>
                             <td class="auto-style3">
                    
                   
                                 <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="OriginLocation" DataValueField="OriginLocation" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged">
                                 </asp:DropDownList>
                                 <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BusTicketingConnectionString %>" SelectCommand="SELECT [originLocation] FROM [Schedule]"></asp:SqlDataSource>
                   
                    
                   
                             </td>
                         </tr>
                         <tr>
                             <td class="auto-style2">
            
                    
                   <asp:Label ID="Label2" runat="server" Text="Destination : "></asp:Label>
                    
                   
                             </td>
                             <td>
                    
                   
        <asp:DropDownList  id="id2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="id2_SelectedIndexChanged"  >
                    </asp:DropDownList>
                   
                    
                   
                             </td>
                         </tr>
                         <tr>
                             <td class="auto-style2">
                    
                   
              
                     <asp:Label ID="Label5" runat="server" Text="Depart Date : "></asp:Label>
                                       
                             </td>
                             <td>
                                       
                     <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" >
                     </asp:DropDownList>
                             </td>
                         </tr>
                         <tr>
                             <td class="auto-style2">
                    
                    
                     <asp:Label ID="Label4" runat="server" Text="Depart Time :"></asp:Label>
                     
                             </td>
                             <td>
                     
                     <asp:DropDownList ID="DropDownList3" runat="server">
                     </asp:DropDownList>
                             </td>
                         </tr>
                         <tr>
                             <td class="auto-style2">
              
                    <asp:Label ID="Label3" runat="server" Text="No. of Passenger"></asp:Label>
&nbsp;: </td>
                             <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="47px"  >
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>

                             </td>
                         </tr>
                         <tr>
                             <td class="auto-style2">&nbsp;</td>
                             <td>&nbsp;</td>
                         </tr>
        </table>

                    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Cancel" OnClick="Button2_Click"  />
                
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClientClick="window.open('Assignment1TestPage.aspx','','left=100,top=50,width=1100,height=580,scrollbars=1');return false;" Text="Sales Summary" />
&nbsp;&nbsp;&nbsp;
                        
  
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
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style2 {
            width: 1441px;
        }
    </style>
</asp:Content>
