using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1.Web
{
    public partial class PaymentReceipt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["ReservationID"].ToString();
            Label11.Text=Session["Departon"].ToString();
            Label13.Text=Session["Time"].ToString();
            Label7.Text=Session["From"].ToString();
            Label8.Text=Session["To"].ToString();
            Label5.Text = Session["Seat"].ToString();
            Label9.Text=Session["TotalSeat"].ToString();
            Label6.Text= Session["TotalRent"].ToString();
            Label10.Text=Session["BusNumber"].ToString();
            Label2.Text = Session["Name"].ToString();
            Label4.Text = Session["PhoneNumber"].ToString();
            Label3.Text=Session["IC"].ToString();
        }
    }
}