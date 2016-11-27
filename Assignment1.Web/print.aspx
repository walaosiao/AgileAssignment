<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="print.aspx.cs" Inherits="BusReservation.print" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 113px;
        }

    </style>

    <script type="text/javascript">
    function printDiv() {
     var printContents = document.getElementById("printableArea").innerHTML;
     var originalContents = document.body.innerHTML;

     document.body.innerHTML = printContents;

     window.print();

     document.body.innerHTML = originalContents;
}

    </script>
</head>
<body>
    <form id="form1" runat="server">
   <div id="printableArea">
    
        <table border="0" cellpadding="2" cellspacing="0" style="border:2px solid gray;padding:5px">
            <tr>
                <td align="Center" colspan="3" style="border-bottom: 2px solid gray; padding-bottom:5px ">
                    <asp:Image ID="Image1" runat="server" Height="60px" ImageUrl="~/Images/logobar.jpg" Width="278px" />
                </td>
                <td align="left" colspan="3" style="color: Blue; border-bottom: 2px solid gray; padding-bottom: 5px">Comfort4u Bus Service<br />
                    Phone :- 03-8888888<br />
                </td>
            </tr>
            <tr>
                <td>Ticket Number </td>
                <td class="arial18">: </td>
                <td class="redText">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
                <td>Date</td>
                <td class="arial18">: </td>
                <td class="auto-style1">
                    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Name </td>
                <td class="arial18">: </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
                <td>Depart</td>
                <td class="arial18">: </td>
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
                <td>Destination </td>
                <td class="arial18">: </td>
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
                <td>Journey Time </td>
                <td class="arial18">: </td>
                <td class="auto-style1">
                    <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Seat Numbers </td>
                <td class="arial18">: </td>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                </td>
                <td>No.of Passengers </td>
                <td class="arial18">: </td>
                <td class="auto-style1">
                    <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Total Rent </td>
                <td class="arial18">: </td>
                <td class="redText">
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                </td>
                <td>Bus Number</td>
                <td>:</td>
                <td>
                    <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
                </td>
                
            </tr>
        </table>
  
    </div>
          <br />
        <br />
      
        <asp:Button ID="Button1" runat="server" OnClientClick="printDiv();" Text="Print" Width="66px" />
      
    </form>
     
</body>
</html>
