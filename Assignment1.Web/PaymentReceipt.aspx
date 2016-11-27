<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaymentReceipt.aspx.cs" Inherits="Assignment1.Web.PaymentReceipt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 113px;
        }

        .auto-style2 {
            height: 20px;
        }
        .auto-style3 {
            width: 113px;
            height: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table border="0" cellpadding="2" cellspacing="0" style="border:2px solid gray;padding:5px">
            <tr>
                <td align="Center" colspan="3" style="border-bottom: 2px solid gray; padding-bottom:5px ">
                    <asp:Image ID="Image1" runat="server" Height="60px" ImageUrl="~/Images/logobar.jpg" Width="278px" />
                </td>
                <td align="left" colspan="3" style="color: Blue; border-bottom: 2px solid gray; padding-bottom: 5px">Comfort4u Bus Service<br />
                    Phone :- 03-8888888<br />
                    Bus Number:<asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
                    <br />
                    Date:<asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Time:<asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Ticket Number </td>
                <td class="auto-style2">: </td>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
                <td class="auto-style2">Depart</td>
                <td class="auto-style2">:</td>
                <td class="auto-style3">
                    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Name </td>
                <td class="arial18">: </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
                <td>Destination</td>
                <td class="arial18">:</td>
                <td class="auto-style1">
                    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>IC</td>
                <td class="arial18 ">: </td>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </td>
                <td>No.of Passengers</td>
                <td class="arial18">:</td>
                <td class="auto-style1">
                    <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Phone Number</td>
                <td class="arial18">: </td>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td class="arial18">&nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>Seat Numbers </td>
                <td class="arial18">: </td>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td class="arial18">&nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>Total Rent </td>
                <td class="arial18">: </td>
                <td class="redText">
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
                
            </tr>
        </table>
  
    </div>
    </form>
</body>
</html>
