using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml;
using System.Data;


namespace BusReservation
{
    public partial class Reservation : System.Web.UI.Page
    {
        private int seatCount;
       // private String seatNumber;
     


        protected void Page_Load(object sender, EventArgs e)
        {
            DepartureTime.Items.Insert(0, new ListItem("<Select Time>", "0"));
            if (DepartureTime.SelectedIndex == 1)
            {
                pnl1.Visible = false;
                s1.ImageUrl = "~/Images/available_seat_img.gif";
                s2.ImageUrl = "~/Images/available_seat_img.gif";
                s3.ImageUrl = "~/Images/available_seat_img.gif";
                s4.ImageUrl = "~/Images/available_seat_img.gif";
                s5.ImageUrl = "~/Images/available_seat_img.gif";
                s6.ImageUrl = "~/Images/available_seat_img.gif";
                s7.ImageUrl = "~/Images/available_seat_img.gif";
                s8.ImageUrl = "~/Images/available_seat_img.gif";
                s9.ImageUrl = "~/Images/available_seat_img.gif";
                s10.ImageUrl = "~/Images/available_seat_img.gif";
                s11.ImageUrl = "~/Images/available_seat_img.gif";
                s12.ImageUrl = "~/Images/available_seat_img.gif";
                s13.ImageUrl = "~/Images/available_seat_img.gif";
                s14.ImageUrl = "~/Images/available_seat_img.gif";
                s15.ImageUrl = "~/Images/available_seat_img.gif";
                s16.ImageUrl = "~/Images/available_seat_img.gif";
                s17.ImageUrl = "~/Images/available_seat_img.gif";
                s18.ImageUrl = "~/Images/available_seat_img.gif";
                s19.ImageUrl = "~/Images/available_seat_img.gif";
                s20.ImageUrl = "~/Images/available_seat_img.gif";
                s21.ImageUrl = "~/Images/available_seat_img.gif";
                s22.ImageUrl = "~/Images/available_seat_img.gif";
                s23.ImageUrl = "~/Images/available_seat_img.gif";
                s24.ImageUrl = "~/Images/available_seat_img.gif";
                s25.ImageUrl = "~/Images/available_seat_img.gif";
                s26.ImageUrl = "~/Images/available_seat_img.gif";
                s27.ImageUrl = "~/Images/available_seat_img.gif";
                s28.ImageUrl = "~/Images/available_seat_img.gif";
                s29.ImageUrl = "~/Images/available_seat_img.gif";
                s30.ImageUrl = "~/Images/available_seat_img.gif";
                s31.ImageUrl = "~/Images/available_seat_img.gif";

            }
            else
            {
                pnl1.Visible = true;
            }

            //seatNumber = (string)(Session["SeatNumber"]);

            //ibnext.Visible = false;



            //Pass Value to Receipt

            }


        private String generateID()
        {
            string strSelect;
            SqlCommand cmdSelect;
            SqlDataReader dtr;

            SqlConnection conCust;
            string connStr = ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString;
            conCust = new SqlConnection(connStr);

            strSelect = "Select ReservationID From dbo.Reservation";

            cmdSelect = new SqlCommand(strSelect, conCust);
           
            conCust.Open();
            dtr = cmdSelect.ExecuteReader();

            string lastValue = "";
            while (dtr.Read())
                lastValue = dtr["ReservationID"].ToString();



            if (lastValue == "")
            {
                return "R1000";
            }
            else
            {
                double genID = double.Parse(lastValue.Replace("R", ""));
                genID = genID + 1;
                return ("R" + genID.ToString());
            }


        }

        protected void DepartureTime_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (DepartureTime.SelectedIndex == 0)
            {
                pnl1.Visible = false;
                
                //ContentPlaceHolder = false;
                txtseatnumber.Text = "";
                txtseatqty.Text = "0";
            }
            else
            {
                pnl1.Visible = true;
                ibnext.Visible = true;
                

                if (splitSeat().Equals(""))
                {
                    pnl1.Visible = true;

                }
                else
                {

                    string dbSeatNumber = splitSeat().Remove(0, 1);
                    string[] split = dbSeatNumber.Split(',');

                    foreach (string item in split)
                    {
                        //Console.WriteLine(item);
                        if (item == "S1")
                        {
                            s1.ImageUrl = "~/Images/booked_seat_img.gif";
                            s1.Enabled = false;
                        }
                        else if (item == "S2")
                        {
                            s2.ImageUrl = "~/Images/booked_seat_img.gif";
                            s2.Enabled = false;
                        }
                        else if (item == "S3")
                        {
                            s3.ImageUrl = "~/Images/booked_seat_img.gif";
                            s3.Enabled = false;
                        }
                        else if (item == "S4")
                        {
                            s4.ImageUrl = "~/Images/booked_seat_img.gif";
                            s4.Enabled = false;
                        }
                        else if (item == "S5")
                        {
                            s5.ImageUrl = "~/Images/booked_seat_img.gif";
                            s5.Enabled = false;
                        }
                        else if (item == "S6")
                        {
                            s6.ImageUrl = "~/Images/booked_seat_img.gif";
                            s6.Enabled = false;
                        }
                        else if (item == "S7")
                        {
                            s7.ImageUrl = "~/Images/booked_seat_img.gif";
                            s7.Enabled = false;
                        }
                        else if (item == "S8")
                        {
                            s8.ImageUrl = "~/Images/booked_seat_img.gif";
                            s8.Enabled = false;
                        }
                        else if (item == "S9")
                        {
                            s9.ImageUrl = "~/Images/booked_seat_img.gif";
                            s9.Enabled = false;
                        }
                        else if (item == "S10")
                        {
                            s10.ImageUrl = "~/Images/booked_seat_img.gif";
                            s10.Enabled = false;
                        }
                        else if (item == "S11")
                        {
                            s11.ImageUrl = "~/Images/booked_seat_img.gif";
                            s11.Enabled = false;
                        }
                        else if (item == "S12")
                        {
                            s12.ImageUrl = "~/Images/booked_seat_img.gif";
                            s12.Enabled = false;
                        }
                        else if (item == "S13")
                        {
                            s13.ImageUrl = "~/Images/booked_seat_img.gif";
                            s13.Enabled = false;
                        }
                        else if (item == "S14")
                        {
                            s14.ImageUrl = "~/Images/booked_seat_img.gif";
                            s14.Enabled = false;
                        }
                        else if (item == "S15")
                        {
                            s15.ImageUrl = "~/Images/booked_seat_img.gif";
                            s15.Enabled = false;
                        }
                        else if (item == "S16")
                        {
                            s16.ImageUrl = "~/Images/booked_seat_img.gif";
                            s16.Enabled = false;
                        }
                        else if (item == "S17")
                        {
                            s17.ImageUrl = "~/Images/booked_seat_img.gif";
                            s17.Enabled = false;
                        }
                        else if (item == "S18")
                        {
                            s18.ImageUrl = "~/Images/booked_seat_img.gif";
                            s18.Enabled = false;
                        }
                        else if (item == "S19")
                        {
                            s19.ImageUrl = "~/Images/booked_seat_img.gif";
                            s19.Enabled = false;
                        }
                        else if (item == "S20")
                        {
                            s20.ImageUrl = "~/Images/booked_seat_img.gif";
                            s20.Enabled = false;
                        }
                        else if (item == "S21")
                        {
                            s21.ImageUrl = "~/Images/booked_seat_img.gif";
                            s21.Enabled = false;
                        }
                        else if (item == "S22")
                        {
                            s22.ImageUrl = "~/Images/booked_seat_img.gif";
                            s22.Enabled = false;
                        }
                        else if (item == "S23")
                        {
                            s23.ImageUrl = "~/Images/booked_seat_img.gif";
                            s23.Enabled = false;
                        }
                        else if (item == "S24")
                        {
                            s24.ImageUrl = "~/Images/booked_seat_img.gif";
                            s24.Enabled = false;
                        }
                        else if (item == "S25")
                        {
                            s25.ImageUrl = "~/Images/booked_seat_img.gif";
                            s25.Enabled = false;
                        }
                        else if (item == "S26")
                        {
                            s26.ImageUrl = "~/Images/booked_seat_img.gif";
                            s26.Enabled = false;
                        }
                        else if (item == "S27")
                        {
                            s27.ImageUrl = "~/Images/booked_seat_img.gif";
                            s27.Enabled = false;
                        }
                        else if (item == "S28")
                        {
                            s28.ImageUrl = "~/Images/booked_seat_img.gif";
                            s28.Enabled = false;
                        }
                        else if (item == "S29")
                        {
                            s29.ImageUrl = "~/Images/booked_seat_img.gif";
                            s29.Enabled = false;
                        }
                        else if (item == "S30")
                        {
                            s30.ImageUrl = "~/Images/booked_seat_img.gif";
                            s30.Enabled = false;
                        }
                        else if (item == "S31")
                        {
                            s31.ImageUrl = "~/Images/booked_seat_img.gif";
                            s31.Enabled = false;
                        }

                       
                    }
                }
            }
        }
        

        protected void s1_Click(object sender, ImageClickEventArgs e)
        {    
            if (s1.ImageUrl == "~/Images/available_seat_img.gif"){
               
               
                s1.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text =  txtseatnumber.Text + "S1,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }else{
            s1.ImageUrl = "~/Images/available_seat_img.gif";
            txtseatnumber.Text = txtseatnumber.Text.Replace("S1,", "");
            minusfare();
            minusseatqty();
            }
        }

        protected void s2_Click(object sender, ImageClickEventArgs e)
        {

            if (s2.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s2.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S2,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);

                addseatqty();

                addfare();

            }
            else
            {
                s2.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S2,", "");
                minusseatqty();
                minusfare();
            }
           
            
        }

        protected void s3_Click(object sender, ImageClickEventArgs e)
        {
            if (s3.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s3.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S3,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s3.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S3,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s4_Click(object sender, ImageClickEventArgs e)
        {
            if (s4.ImageUrl == "~/Images/available_seat_img.gif")
            {

               
                s4.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S4,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s4.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S4,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s5_Click(object sender, ImageClickEventArgs e)
        {
            if (s5.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s5.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S5,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s5.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S5,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s6_Click(object sender, ImageClickEventArgs e)
        {
            if (s6.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s6.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S6,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s6.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S6,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s7_Click(object sender, ImageClickEventArgs e)
        {
            if (s7.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s7.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S7,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s7.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S7,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s8_Click(object sender, ImageClickEventArgs e)
        {
            if (s8.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s8.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S8,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s8.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S8,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s9_Click(object sender, ImageClickEventArgs e)
        {
            if (s9.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s9.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S9,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s9.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S9,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s10_Click(object sender, ImageClickEventArgs e)
        {
            if (s10.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s10.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S10,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s10.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S10,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s11_Click(object sender, ImageClickEventArgs e)
        {
            if (s11.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s11.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S11,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s11.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S11,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s12_Click(object sender, ImageClickEventArgs e)
        {
            if (s12.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s12.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S12,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s12.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S12,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s13_Click(object sender, ImageClickEventArgs e)
        {
            if (s13.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s13.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S13,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s13.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S13,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s14_Click(object sender, ImageClickEventArgs e)
        {
            if (s14.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s14.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S14,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s14.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S14,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s15_Click(object sender, ImageClickEventArgs e)
        {
            if (s15.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s15.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S15,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s15.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S15,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s16_Click(object sender, ImageClickEventArgs e)
        {
            if (s16.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s16.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S16,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s16.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S16,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s17_Click(object sender, ImageClickEventArgs e)
        {
            if (s17.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s17.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S17,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s17.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S17,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s18_Click(object sender, ImageClickEventArgs e)
        {
            if (s18.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s18.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S18,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s18.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S18,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s19_Click(object sender, ImageClickEventArgs e)
        {
            if (s19.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s19.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S19,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s19.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S19,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s20_Click(object sender, ImageClickEventArgs e)
        {
            if (s20.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s20.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S20,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s20.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S20,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s21_Click(object sender, ImageClickEventArgs e)
        {
            if (s21.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s21.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S21,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s21.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S21,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s22_Click(object sender, ImageClickEventArgs e)
        {
            if (s22.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s22.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S22,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s22.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S22,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s23_Click(object sender, ImageClickEventArgs e)
        {
            if (s23.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s23.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S23,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s23.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S23,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s24_Click(object sender, ImageClickEventArgs e)
        {
            if (s24.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s24.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S24,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s24.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S24,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s25_Click(object sender, ImageClickEventArgs e)
        {
            if (s25.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s25.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S25,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s25.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S25,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s26_Click(object sender, ImageClickEventArgs e)
        {
            if (s26.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s26.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S26,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s26.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S26,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s27_Click(object sender, ImageClickEventArgs e)
        {
            if (s27.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s27.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S27,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s27.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S27,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s28_Click(object sender, ImageClickEventArgs e)
        {
            if (s28.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s28.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S28,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s28.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S28,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s29_Click(object sender, ImageClickEventArgs e)
        {
            if (s29.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s29.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S29,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s29.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S29,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s30_Click(object sender, ImageClickEventArgs e)
        {
            if (s30.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s30.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S30,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s30.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S30,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s31_Click(object sender, ImageClickEventArgs e)
        {
            if (s31.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s31.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S31,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s31.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S31,", "");
                minusfare();
                minusseatqty();
            }
        }


        private void addfare() {
            if (txtseatqty.Text == "0")
            {
                lbltotalfare.Text = "35.00";
            }
            else
            {
                double tmp1 = double.Parse(txtseatqty.Text);
                
               double tmp2 = tmp1 * 35.00;
                lbltotalfare.Text = tmp2.ToString("n2");
            }
        }

        private void minusfare() {
            double tmp1 = double.Parse(lbltotalfare.Text);
            tmp1 = tmp1 - 35.00;
            lbltotalfare.Text = tmp1.ToString("n2");
        }

        private void addseatqty() {
            if (txtseatqty.Text == "0")
            {
                txtseatqty.Text = "1";
            }
            else
            {
                int tmp = int.Parse(txtseatqty.Text);
                tmp = tmp + 1;
                txtseatqty.Text = tmp.ToString();
            }
        }


        private void minusseatqty() {
            int tmp = int.Parse(txtseatqty.Text);
            tmp = tmp - 1;
            txtseatqty.Text = tmp.ToString();
        }

        protected void ibnext_Click(object sender, ImageClickEventArgs e)
        {
            seattable.Visible = false;
            pnl2.Visible = true;
            ibnext.Visible = false;
            txtTotalSeat.Text = txtseatqty.Text;
            txtTotalRent.Text  = lbltotalfare.Text;
            lblPerSeat.Text = "35";
            txtBus.Text = "PDW1234";
            txtseat.Text = txtseatnumber.Text.Remove(txtseatnumber.Text.Length - 1);
            txtTotalRent.Text=lbltotalfare.Text;
            txtNumber.Text = generateID();

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void txtname_TextChanged(object sender, EventArgs e)
        {

        }

       

        protected void Destination_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Destination.SelectedIndex == 0)
            {

                departon.Enabled = false;
            }
            else
            {
                departon.Enabled = true;
            }
            string connStr = ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString;


            departon.Items.Clear();

            DataTable ddate = new DataTable();

            using (SqlConnection con = new SqlConnection(connStr))
            {

                try
                {

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT departureDate FROM dbo.Schedule WHERE destinationLocation='" + Destination.SelectedValue + "'", con);


                    adapter.Fill(ddate);

                    departon.DataSource = ddate;
                    departon.DataTextField = "departureDate";
                    departon.DataValueField = "departureDate";
                    departon.DataBind();
                }
                catch (Exception ex)
                {
                    // Handle the error
                }

            }

            // Add the initial item - you can add this even if the options from the
            // db were not successfully loaded
            departon.Items.Insert(0, new ListItem("<Select Date>", "0"));
        }

        protected void departon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (departon.SelectedIndex == 0)
            {

                DepartureTime.Enabled = false;
            }
            else
            {
                DepartureTime.Enabled = true;
            }
            string connStr = ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString;


            DepartureTime.Items.Clear();


            DataTable dtime = new DataTable();

            using (SqlConnection con = new SqlConnection(connStr))
            {

                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT departTime FROM dbo.Schedule WHERE departureDate='" + departon.SelectedValue + "'", con);


                    adapter.Fill(dtime);

                    DepartureTime.DataSource = dtime;
                    DepartureTime.DataTextField = "departTime";
                    DepartureTime.DataValueField = "departTime";
                    DepartureTime.DataBind();
                }
                catch (Exception ex)
                {
                    // Handle the error
                }
            }
        }
        

        protected void fromdrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fromdrop.SelectedIndex == 0)
            {
                Destination.Enabled = false;
            }
            else
            {
                Destination.Enabled = true;
            }
             string connStr = ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString;
         
           Destination.Items.Clear();
           

            DataTable dest = new DataTable();

            using (SqlConnection con = new SqlConnection(connStr))
            {

                try
                {
                    
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT destinationLocation FROM dbo.Schedule WHERE originLocation='"+fromdrop.SelectedValue+"'", con);
                   
                   
                    adapter.Fill(dest);

                    Destination.DataSource = dest;
                    Destination.DataTextField = "destinationLocation";
                     Destination.DataValueField = "destinationLocation";
                    Destination.DataBind();
                }
                catch (Exception ex)
                {
                    // Handle the error
                }

            }

            // Add the initial item - you can add this even if the options from the
            // db were not successfully loaded
             Destination.Items.Insert(0, new ListItem("<Select Destination>", "0"));
        }

      
        
        

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private String splitSeat() {
            string strSelect;
            SqlCommand cmdSelect;
            SqlDataReader dtr;

            SqlConnection conCust;
            string connStr = ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString;
            conCust = new SqlConnection(connStr);

            strSelect = "Select ReservationSeatNumber From dbo.Reservation WHERE ReservationFrom=@From AND ReservationTo=@To AND ReservationDate=@Date AND ReservationTime=@Time";

            cmdSelect = new SqlCommand(strSelect, conCust);
            cmdSelect.Parameters.AddWithValue("@Date", departon.SelectedValue);
            cmdSelect.Parameters.AddWithValue("@Time", DepartureTime.SelectedValue);
            cmdSelect.Parameters.AddWithValue("@From", fromdrop.SelectedValue);
            cmdSelect.Parameters.AddWithValue("@To", Destination.SelectedValue);
            conCust.Open();
            dtr = cmdSelect.ExecuteReader();

            string dbSeatNumber = "";
            while (dtr.Read()) {

                dbSeatNumber = dbSeatNumber + ","+dtr["ReservationSeatNumber"].ToString();
            }


            return dbSeatNumber;

        }


        private void generateXML()
        {
            
            XmlTextWriter xWriter = new XmlTextWriter(Server.MapPath("Reservation.xml"), Encoding.UTF8);
            xWriter.WriteStartDocument();

            xWriter.WriteStartElement("TicketReservation");
            xWriter.WriteWhitespace("\n");
            xWriter.WriteElementString("ReservationID", txtNumber.Text);
            xWriter.WriteWhitespace("\n");
            xWriter.WriteElementString("Date", departon.SelectedValue);
            xWriter.WriteWhitespace("\n");
            xWriter.WriteElementString("Time", DepartureTime.SelectedValue);
            xWriter.WriteWhitespace("\n");
            xWriter.WriteElementString("From", fromdrop.SelectedValue);
            xWriter.WriteWhitespace("\n");
            xWriter.WriteElementString("To", Destination.SelectedValue);
            xWriter.WriteWhitespace("\n");
            xWriter.WriteElementString("SeatNumber", txtseat.Text);
            xWriter.WriteWhitespace("\n");
            xWriter.WriteElementString("TotalSeat", txtTotalSeat.Text);
            xWriter.WriteWhitespace("\n");
            xWriter.WriteElementString("TotalFare", txtTotalRent.Text);
            xWriter.WriteWhitespace("\n");
            xWriter.WriteElementString("BusNumber", txtBus.Text);
            xWriter.WriteWhitespace("\n");
            xWriter.WriteElementString("Name", txtName.Text);
            xWriter.WriteWhitespace("\n");
            xWriter.WriteElementString("Phone", txtPhone.Text);
            xWriter.WriteWhitespace("\n");
            xWriter.WriteElementString("IC", txtIc.Text);
            xWriter.WriteWhitespace("\n");
            xWriter.WriteEndDocument();
            xWriter.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strInsert;
            SqlCommand cmdInsert;

            SqlConnection conCust;
            string connStr = ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString;
            conCust = new SqlConnection(connStr);


            strInsert = "Insert Into Reservation (ReservationID, ReservationDate, ReservationTime, ReservationFrom, ReservationTo, ReservationSeatNumber,ReservationTotalSeat, ReservationTotalFare, ReservationBusNumber, ReservationName, ReservationPhoneNo, ReservationIC) Values (@ID, @Date, @Time, @From, @To, @SeatNumber, @TotalSeats, @TotalFare, @BusNo, @Name, @PhoneNo, @IC)";

            cmdInsert = new SqlCommand(strInsert, conCust);

            cmdInsert.Parameters.AddWithValue("@ID", txtNumber.Text);
            cmdInsert.Parameters.AddWithValue("@Date", departon.SelectedValue);
            cmdInsert.Parameters.AddWithValue("@Time", DepartureTime.SelectedValue);
            cmdInsert.Parameters.AddWithValue("@From", fromdrop.SelectedValue);
            cmdInsert.Parameters.AddWithValue("@To", Destination.SelectedValue);
            cmdInsert.Parameters.AddWithValue("@SeatNumber", txtseat.Text);
            cmdInsert.Parameters.AddWithValue("@TotalSeats", txtTotalSeat.Text);
            cmdInsert.Parameters.AddWithValue("@TotalFare", txtTotalRent.Text);
            cmdInsert.Parameters.AddWithValue("@BusNo", txtBus.Text);
            cmdInsert.Parameters.AddWithValue("@Name", txtName.Text);
            cmdInsert.Parameters.AddWithValue("@PhoneNo", txtPhone.Text);
            cmdInsert.Parameters.AddWithValue("@IC", txtIc.Text);

            conCust.Open();
            cmdInsert.ExecuteNonQuery();

            conCust.Close();

            Session["ReservationID"] = txtNumber.Text.ToString();
            Session["Departon"] = departon.Text.ToString();
            Session["Time"] = DepartureTime.Text.ToString();
            Session["From"] = fromdrop.Text.ToString();
            Session["To"] = Destination.Text.ToString();
            Session["Seat"] = txtseat.Text.ToString();
            Session["TotalSeat"] = txtTotalSeat.Text.ToString();
            Session["TotalRent"] = txtTotalRent.Text.ToString();
            Session["BusNumber"] = txtBus.Text.ToString();
            Session["Name"] = txtName.Text.ToString();
            Session["PhoneNumber"] = txtPhone.Text.ToString();
            Session["IC"] = txtIc.Text.ToString();
        }

        protected void btnSave_Click1(object sender, ImageClickEventArgs e)
        {
            ibnext.Visible = false;

            string strInsert;
            SqlCommand cmdInsert;

            SqlConnection conCust;
            string connStr = ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString;
            conCust = new SqlConnection(connStr);


            strInsert = "Insert Into Reservation (ReservationID, ReservationDate, ReservationTime, ReservationFrom, ReservationTo, ReservationSeatNumber,ReservationTotalSeat, ReservationTotalFare, ReservationBusNumber, ReservationName, ReservationPhoneNo, ReservationIC) Values (@ID, @Date, @Time, @From, @To, @SeatNumber, @TotalSeats, @TotalFare, @BusNo, @Name, @PhoneNo, @IC)";

            cmdInsert = new SqlCommand(strInsert, conCust);

            cmdInsert.Parameters.AddWithValue("@ID", txtNumber.Text);
            cmdInsert.Parameters.AddWithValue("@Date", departon.SelectedValue);
            cmdInsert.Parameters.AddWithValue("@Time", DepartureTime.SelectedValue);
            cmdInsert.Parameters.AddWithValue("@From", fromdrop.SelectedValue);
            cmdInsert.Parameters.AddWithValue("@To", Destination.SelectedValue);
            cmdInsert.Parameters.AddWithValue("@SeatNumber", txtseat.Text);
            cmdInsert.Parameters.AddWithValue("@TotalSeats", txtTotalSeat.Text);
            cmdInsert.Parameters.AddWithValue("@TotalFare", txtTotalRent.Text);
            cmdInsert.Parameters.AddWithValue("@BusNo", txtBus.Text);
            cmdInsert.Parameters.AddWithValue("@Name", txtName.Text);
            cmdInsert.Parameters.AddWithValue("@PhoneNo", txtPhone.Text);
            cmdInsert.Parameters.AddWithValue("@IC", txtIc.Text);

            conCust.Open();
            cmdInsert.ExecuteNonQuery();

            //Type cstype = this.GetType();

            // Get a ClientScriptManager reference from the Page class.
            ClientScriptManager cs = Page.ClientScript;

            // Check to see if the startup script is already registered.
            //if (!cs.IsStartupScriptRegistered(cstype, "PopupScript"))
            //{
            //    String cstext = "alert('Bus seat(s) suscessfully reserved.');";
            //    cs.RegisterStartupScript(cstype, "PopupScript", cstext, true);
            //}
            conCust.Close();

            generateXML();

            //Response.Redirect("print.aspx");
        }

        

    }
}