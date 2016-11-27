using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace WebAssignment
{
    public partial class Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ReportReference.Report1SoapClient client = new ReportReference.Report1SoapClient();
             if (RadioButtonList1.SelectedIndex == 0)
             {
                 Label3.Visible = true;
                 GridView1.DataSource = client.GetLatestCustomers(DropDownList1.SelectedItem.ToString());
                 GridView1.DataBind();
                 Label4.Visible = true;
                 Label3.Text = DropDownList1.SelectedItem.ToString();
                 Image1.Visible = true;
                 Button2.Visible = true;
                 Label6.Visible = false;
                 Label7.Visible = false;
             }
             else if (RadioButtonList1.SelectedIndex == 1)
             {

                 GridView1.DataSource = client.GetLatestDriver(DropDownList2.SelectedItem.ToString());
                 GridView1.DataBind();
                 Label4.Visible = false;
                 Label6.Visible = true;
                 Label6.Text = DropDownList2.SelectedItem.ToString();
                 Label7.Visible = true;
                 Label3.Visible = false;
                 Image1.Visible = true;
                 Button2.Visible = true;

             }
         
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedIndex == 0)
            {
                Panel1.Visible = true;
                Panel2.Visible = false;
            }
            else if (RadioButtonList1.SelectedIndex == 1)
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
            }
        }
    }
}