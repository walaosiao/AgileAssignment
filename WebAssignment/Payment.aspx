<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="WebAssignment.Payment"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            text-decoration: underline;
            font-weight: normal;
        }
    </style>
</head>
<body>
    <h2 class="auto-style2"><strong>Payment </strong> </h2>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Name : "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Contact Number : "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="E-mail :  "></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Confirm E-mail : "></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" />
        <asp:Label ID="Label5" runat="server" Text="Yes , i would like to receive offers and promotion."></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Credit/Debit Card" BackColor="Silver" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Online Banking" BackColor="Silver" />
&nbsp;<asp:Panel ID="Panel1" runat="server" Height="231px" Width="249px" Visible="False">
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>Maybank2u</asp:ListItem>
                <asp:ListItem>CIMB Clicks</asp:ListItem>
                <asp:ListItem>RHB Online</asp:ListItem>
                <asp:ListItem>AM Online</asp:ListItem>
                <asp:ListItem>Hong Leong Bank Online</asp:ListItem>
                <asp:ListItem>Paypal</asp:ListItem>
                <asp:ListItem>MEPS FPX</asp:ListItem>
            </asp:RadioButtonList>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Height="165px" Visible="False" Width="246px">
            <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                <asp:ListItem>Visa/Master Via Paypal</asp:ListItem>
                <asp:ListItem>Visa/Master</asp:ListItem>
            </asp:RadioButtonList>
        </asp:Panel>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Paynow" />
        <br />
        <br />
    
        </p>
    
    </div>
    </form>
</body>
</html>
