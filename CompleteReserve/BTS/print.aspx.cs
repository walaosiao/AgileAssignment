using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
namespace BusReservation
{
    public partial class print : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader(Server.MapPath("Reservation.xml"));
            XmlNodeType type;

            while (reader.Read())
            {

                type = reader.NodeType;

                if (type == XmlNodeType.Element)
                {

                    if (reader.Name == "ReservationID")
                    {
                        reader.Read();
                        Label1.Text = reader.Value;
                    
                    }

                    if (reader.Name == "Date")
                    {
                        reader.Read();
                        Label7.Text = reader.Value;

                    }

                    if (reader.Name == "Time")
                    {
                        reader.Read();
                        Label10.Text = reader.Value;

                    }

                    if (reader.Name == "From")
                    {
                        reader.Read();
                        Label8.Text = reader.Value;

                    }

                    if (reader.Name == "To")
                    {
                        reader.Read();
                        Label9.Text = reader.Value;

                    }

                    if (reader.Name == "SeatNumber")
                    {
                        reader.Read();
                        Label5.Text = reader.Value;

                    }

                    if (reader.Name == "TotalSeat")
                    {
                        reader.Read();
                        Label11.Text = reader.Value;

                    }

                    if (reader.Name == "TotalFare")
                    {
                        reader.Read();
                        Label6.Text = reader.Value;

                    }

                    if (reader.Name == "BusNumber")
                    {
                        reader.Read();
                        Label12.Text = reader.Value;

                    }

                    if (reader.Name == "Name")
                    {
                        reader.Read();
                        Label2.Text = reader.Value;

                    }

                    if (reader.Name == "Phone")
                    {
                        reader.Read();
                        Label4.Text = reader.Value;

                    }

                    if (reader.Name == "IC")
                    {
                        reader.Read();
                        Label3.Text = reader.Value;

                    }

                    
                }
            
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}