<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="maintenance.Edit" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 202px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Maintain Route:<br />
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
         </asp:ToolkitScriptManager>
        <br />
        <br />
    
    </div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
<br />
                RouteID:&nbsp;
                <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCheck" runat="server" OnClick="btnCheck_Click" style="width: 55px" Text="Check" />
<br />
                <br />
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style1">Route Depart :</td>
                        <td>
                            <asp:TextBox ID="txtDepart" runat="server" Enabled="False"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Route Destination :</td>
                        <td>
                            <asp:TextBox ID="txtDest" runat="server" Enabled="False"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Bus Fare :</td>
                        <td>
                            <asp:TextBox ID="txtFare" runat="server" OnTextChanged="txtFare_TextChanged"></asp:TextBox>
                            <asp:FilteredTextBoxExtender ID="txtFare_FilteredTextBoxExtender" runat="server" Enabled="True" TargetControlID="txtFare" FilterType="Numbers">
                            </asp:FilteredTextBoxExtender>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" style="width: 37px" />           
                            <asp:ConfirmButtonExtender ID="btnEdit_ConfirmButtonExtender" runat="server" ConfirmText="Are you sure EDIT the route details ?" TargetControlID="btnEdit">
                            </asp:ConfirmButtonExtender>
                        </td>
                        <td>
                            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
                            <asp:ConfirmButtonExtender ID="btnDelete_ConfirmButtonExtender" runat="server" ConfirmText="Are you sure DELETE this route details?" TargetControlID="btnDelete">
                            </asp:ConfirmButtonExtender>
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                <asp:Label ID="lblmsg" runat="server" Text="Label"></asp:Label>
                <br />
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
