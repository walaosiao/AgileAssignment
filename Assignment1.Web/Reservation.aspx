<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reservation.aspx.cs" Inherits="BusReservation.Reservation" MasterPageFile="~/Site2.Master" MaintainScrollPositionOnPostback="true" %>


<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server" >
    
    <style type="text/css">
        .form {}
        .auto-style1 {
           
            position: fixed;
        }
        .auto-style4 {
            height: 24px;
        }
        .auto-style5 {
            height: 25px;
        }
        .auto-style8 {
            width: 844px;
            height: 562px;
        }
        .auto-style9 {
            height: 27px;
        }
        </style>
    <div>
    <!-- Main Table start -->
        <table>
                <tr>
                    <td class="auto-style8">
                        <!-- Left Table Start-->
                        <table border="0" style="width: 95%; margin-top:20px">
                            <tbody>
                                <tr>
                                    <!--Center Side Start -->
                                    <td align="center" >
                                        <div class="smallbox" style="margin: 0px">
                                           <asp:Panel ID="pnl3" runat="server" style="top:510px; position:absolute; left: 40px; height: 240px;">
                                            <table style="margin-left: 30px; width: 300px; height: 95px;" cellspacing="0" cellpadding="0"
                                                align="center" border="0">
                                               

                                                 <tbody>
                                                    <tr>
                                                        <td class="formtext" width="37%" height="27">
                                                            From:
                                                        </td>
                                                        <td width="63%" align="left" height="27">
                                                            <asp:DropDownList CssClass="form" ID="fromdrop" runat="server" Height="30px" Width="150px" AutoPostBack="True"  AppendDataBoundItems="true" OnSelectedIndexChanged="fromdrop_SelectedIndexChanged" DataSourceID="SqlDataSource1" DataTextField="originLocation" DataValueField="originLocation">
                                                                <asp:ListItem Value="-1">
                                                                           --Select--
                                                                        </asp:ListItem>
                                                               
                                                            </asp:DropDownList>
                                                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BusTicketingConnectionString %>" SelectCommand="SELECT DISTINCT [originLocation] FROM [Schedule]"></asp:SqlDataSource>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style9" width="37%">
                                                            To:
                                                        </td>
                                                        <td width="63%" align="left" class="auto-style9">
                                                                <ContentTemplate>
                                                                    <div id="txtHint">
                                                                        <asp:DropDownList CssClass="form" ID="Destination" runat="server" Height="30px" Width="150px" AutoPostBack="True" AppendDataBoundItems="true" Enabled="False" OnSelectedIndexChanged="Destination_SelectedIndexChanged">
                               
                                                                            <asp:ListItem Value="-1">
                                                                           --Select--
                                                                        </asp:ListItem>
                                   
                                                                        </asp:DropDownList>
                                                                    </div>
                                                                </ContentTemplate>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="formtext" width="37%" height="27">
                                                            Depart on :
                                                        </td>
                                                        <td width="63%" align="left" height="27">
                                                           
                                                                <ContentTemplate>
                                                                    <asp:DropDownList ID="departon" runat="server" Height="30px" Width="150px" AppendDataBoundItems="true" AutoPostBack="True" Enabled="False" OnSelectedIndexChanged="departon_SelectedIndexChanged">
                                                                         
                                                                            <asp:ListItem Value="-1">
                                                                           --Select--
                                                                        </asp:ListItem>
                                                                            
                                                                         
                                                                    </asp:DropDownList>
                                                                </ContentTemplate>
                                                            
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style4" width="37%">
                                                            Time :
                                                        </td>
                                                        <td width="63%" align="left" class="auto-style4">
                                                           
                                                                <ContentTemplate>
                                                                    <asp:DropDownList ID="DepartureTime" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DepartureTime_SelectedIndexChanged" AppendDataBoundItems="true" Height="30px" Width="150px" Enabled="False"  >
                                                                        <asp:ListItem Value="-1">
                                                                           --Select--
                                                                        </asp:ListItem>
                                                                           
                                                                            
                                                                    </asp:DropDownList>
                                                                </ContentTemplate>
                                                           
                                                        </td>
                                                    <tr>
                                                            <td class="formtext" height="27%" width="37%">Seat Number : </td>
                                                            <td align="left" height="27" width="63%">
                                                                <asp:TextBox ID="txtseatnumber" runat="server" Height="25px" ReadOnly="true" Width="150px"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style3" width="37%">Seat Quantity : </td>
                                                        <td align="left" width="63%" class="auto-style3">
                                                            <asp:TextBox ID="txtseatqty" runat="server" Enabled="False" Height="25px" ReadOnly="true" Width="150px">0</asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="formtext" height="27%" width="37%">Total Bus Fare : </td>
                                                        <td align="left" height="37" width="63%">RM
                                                            <asp:Label ID="lbltotalfare" runat="server" Width="50px">0</asp:Label>
                                                        </td>
                                                    </tr>
                                                </tbody>
                                                <tr>
                                                    <td> </td>
                                                    <td>
                        <asp:ImageButton ID="ibnext" ImageUrl="~/Images/temp88165204up.png" runat="server" OnClick="ibnext_Click" Width="150" />
                                                    </td>
                                                </tr>
                                            </table>
                                               </asp:Panel>
                                        </div>
                                    </td>
                                    </div>
            </asp:Content>
                                    
                                   
                                    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
                                        <td class="auto-style7">
                                        
                                        <asp:Panel ID="pnl1" runat="server">
                                            <asp:Table ID="seattable" runat="server" border="0">
                                                <asp:TableRow>
                                                    <asp:TableCell ID="TableCell1" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s1" ToolTip="Window Side" ImageUrl="~/Images/available_seat_img.gif"
                                                             runat="server" OnClick="s1_Click" />1</asp:TableCell>
                                                    <asp:TableCell ID="TableCell2" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s6"  ImageUrl="~/Images/available_seat_img.gif"
                                                          runat="server" OnClick="s6_Click" />6</asp:TableCell>
                                                    <asp:TableCell ID="TableCell3" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s7"  ToolTip="Window Side" ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s7_Click" />7</asp:TableCell>
                                                    <asp:TableCell ID="TableCell4" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s12"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s12_Click" />12</asp:TableCell>
                                                    <asp:TableCell ID="TableCell5" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s13"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s13_Click" />13</asp:TableCell>
                                                    <asp:TableCell ID="TableCell6" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s18"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s18_Click" />18</asp:TableCell>
                                                    <asp:TableCell ID="TableCell7" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s19"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s19_Click" />19</asp:TableCell>
                                                    <asp:TableCell ID="TableCell8" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s24"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s24_Click" />24</asp:TableCell>
                                                    <asp:TableCell ID="TableCell9" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s25"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s25_Click" />25</asp:TableCell>
                                                    <asp:TableCell ID="TableCell10" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s31"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s31_Click" />31</asp:TableCell>
                                                </asp:TableRow>
                                                <asp:TableRow>
                                                    <asp:TableCell ID="TableCell11" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s2" ImageUrl="~/Images/available_seat_img.gif" 
                                                            runat="server" OnClick="s2_Click" />2</asp:TableCell>
                                                    <asp:TableCell ID="TableCell12" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s5"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s5_Click" />5</asp:TableCell>
                                                    <asp:TableCell ID="TableCell13" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s8"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s8_Click" />8</asp:TableCell>
                                                    <asp:TableCell ID="TableCell14" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s11"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s11_Click" />11</asp:TableCell>
                                                    <asp:TableCell ID="TableCell15" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s14"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s14_Click" />14</asp:TableCell>
                                                    <asp:TableCell ID="TableCell16" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s17"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s17_Click" />17</asp:TableCell>
                                                    <asp:TableCell ID="TableCell17" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s20"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s20_Click" />20</asp:TableCell>
                                                    <asp:TableCell ID="TableCell18" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s23"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s23_Click" />23</asp:TableCell>
                                                    <asp:TableCell ID="TableCell19" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s26"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s26_Click" />26</asp:TableCell>
                                                    <asp:TableCell ID="TableCell20" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s30"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s30_Click" />30</asp:TableCell>
                                                </asp:TableRow>
                                                <asp:TableRow>
                                                    <asp:TableCell ID="TableCell21" runat="server">&nbsp; </asp:TableCell>
                                                    <asp:TableCell ID="TableCell22" runat="server">&nbsp; </asp:TableCell>
                                                    <asp:TableCell ID="TableCell23" runat="server">&nbsp; </asp:TableCell>
                                                    <asp:TableCell ID="TableCell24" runat="server">&nbsp; </asp:TableCell>
                                                    <asp:TableCell ID="TableCell25" runat="server">&nbsp; </asp:TableCell>
                                                    <asp:TableCell ID="TableCell26" runat="server">&nbsp; </asp:TableCell>
                                                    <asp:TableCell ID="TableCell27" runat="server">&nbsp; </asp:TableCell>
                                                    <asp:TableCell ID="TableCell28" runat="server">&nbsp; </asp:TableCell>
                                                    <asp:TableCell ID="TableCell29" runat="server">&nbsp; </asp:TableCell>
                                                    <asp:TableCell ID="TableCell30" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s29"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s29_Click" />29</asp:TableCell>
                                                </asp:TableRow>
                                                <asp:TableRow>
                                                    <asp:TableCell ID="TableCell31" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s3"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s3_Click" />3</asp:TableCell>
                                                    <asp:TableCell ID="TableCell32" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s4"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s4_Click" />4</asp:TableCell>
                                                    <asp:TableCell ID="TableCell33" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s9"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s9_Click" />9</asp:TableCell>
                                                    <asp:TableCell ID="TableCell34" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s10"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s10_Click" />10</asp:TableCell>
                                                    <asp:TableCell ID="TableCell35" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s15"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s15_Click" />15</asp:TableCell>
                                                    <asp:TableCell ID="TableCell36" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s16"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s16_Click" />16</asp:TableCell>
                                                    <asp:TableCell ID="TableCell37" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s21"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s21_Click" />21</asp:TableCell>
                                                    <asp:TableCell ID="TableCell38" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s22"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s22_Click" />22</asp:TableCell>
                                                    <asp:TableCell ID="TableCell39" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s27"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s27_Click" />27</asp:TableCell>
                                                    <asp:TableCell ID="TableCell40" runat="server" class="seatCell" valign="middle">
                                                        <asp:ImageButton ID="s28"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s28_Click" />28</asp:TableCell>
                                                </asp:TableRow>
                                            </asp:Table>
                                            
                                            <br />
                                            <br />
                                           
                                            <br />
                                            <br />
                                        </asp:Panel>
                                        
                                        <asp:Panel ID="pnl2" runat="server" Visible="False" Height="1400px">
                                            <div id="blueBox">
                                                <div id="blueBoxtitle">
                                                    <h4>
                                                        CUSTOMER INFORMATION
                                                    </h4>
                                                </div>
                                                <div style="float: right; width: 296px; height: 0px;">
                                                    <table cellspacing="0" cellpadding="0" border="0" style="width: 539px">
                                                        <tbody>
                                                            <tr>
                                                                <td height="25">
                                                                    Reservation Number
                                                                </td>
                                                                <td>
                                                                    :
                                                                </td>
                                                                <td>
                                                                    <asp:TextBox ID="txtNumber" runat="server" Height="20px"></asp:TextBox>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td height="25">
                                                                    Name
                                                                </td>
                                                                <td>
                                                                    :
                                                                </td>
                                                                <td>
                                                                    <asp:TextBox ID="txtName" runat="server" OnTextChanged="txtname_TextChanged" Height="20px" />
                                                                    <asp:RequiredFieldValidator ID="rfvname" runat="server" ErrorMessage="*" ControlToValidate="txtname" />
                                                                    <%--<asp:RangeValidator ID="range" Text ="Invalid Name" Type="String"   ControlToValidate="txtname" runat="server" /> --%>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td class="auto-style5">
                                                                    Phone Number
                                                                </td>
                                                                <td class="auto-style5">
                                                                    :
                                                                </td>
                                                                <td class="auto-style5">
                                                                    <asp:TextBox ID="txtPhone" runat="server" Height="20px" />
                                                                    <asp:RequiredFieldValidator ID="rfvph" ControlToValidate="txtphone" ErrorMessage="*"
                                                                        runat="server" />
                                                                </td>
                                                                </tr>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        IC</td>
                                                                    <td>
                                                                        :</td>
                                                                    <td>
                                                                        <asp:TextBox ID="txtIc" runat="server" Height="20px"></asp:TextBox>
                                                                    </td>
                                                                    </tr>
                                                                <tr>
                                                                    <td>
                                                                        Seat Number</td>
                                                                    <td>:</td>
                                                                    <td>
                                                                        <asp:TextBox ID="txtseat" runat="server" Height="20px" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
                                                                    </td>
                                                                </tr>
                                                                    <tr>
                                                                        <td align="left" height="25">Total Seat&nbsp; </td>
                                                                        <td align="left">: </td>
                                                                        <td align="left">
                                                                            <asp:TextBox ID="txtTotalSeat" runat="server" OnTextChanged="TextBox2_TextChanged" Height="20px"></asp:TextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td align="left" height="25">Rent Per Seat </td>
                                                                        <td align="left" width="5%">: </td>
                                                                        <td align="left" width="49%">RM<asp:Label ID="lblPerSeat" runat="server" Text="Label"></asp:Label>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td align="left" height="25">Bus Number </td>
                                                                        <td align="left" width="5%">: </td>
                                                                        <td align="left" width="49%">
                                                                            <asp:TextBox ID="txtBus" runat="server" Height="20px"></asp:TextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="auto-style5">Total Rent </td>
                                                                        <td class="auto-style5" width="5%">: </td>
                                                                        <td class="auto-style5">
                                                                            RM<asp:Label ID="txtTotalRent" runat="server" Text="Label"></asp:Label>
                                                                        </td>
                                                                    </tr>
                                                               <tr><td>
                                                                   <asp:ImageButton ID="Button1" runat="server" ImageUrl="~/Images/payment.png" OnClientClick="window.open('Assignment1TestPage.aspx','','left=100,top=50,width=1100,height=580,scrollbars=1')" OnClick="Button1_Click" />
                                                                   </td>
                                                                   <td>
                                                                       <asp:ImageButton ID="btnSave" runat="server" ImageUrl="~/Images/reservation.png" OnClientClick="window.open('print.aspx','','left=100,top=50,width=1100,height=580,scrollbars=1')" OnClick="btnSave_Click1" />
                                                                   </td>
                                                               </tr>
                                                        </tbody>
                                                    </table>
                                                </div>
                                        </asp:Panel>
                                    </td>
                                    <!--Right Side End -->
                                </tr>
                            </tbody>
                        </table>
                        <!-- end of Center-->
                    </td>
                </tr>
                <tr>
                    <td align="center" class="auto-style6">
                        <asp:Label ID="lblerror" runat="server" Font-Bold="True" Font-Size="Medium" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="auto-style2">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <br />
                    </td>
                </tr>
            </table>
            <!-- Main Table End -->
    </div>
     </asp:Content>