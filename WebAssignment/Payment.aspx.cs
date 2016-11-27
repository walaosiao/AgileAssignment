using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAssignment
{
    public partial class Payment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button1.BackColor = System.Drawing.Color.Red;
            Button2.BackColor = System.Drawing.Color.Silver;
            Panel1.Visible = true;
            Panel2.Visible = false;
            RadioButtonList2.ClearSelection();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Button1.BackColor = System.Drawing.Color.Silver;
            Button2.BackColor = System.Drawing.Color.Red;
            Panel1.Visible = false;
            Panel2.Visible = true;
            RadioButtonList1.ClearSelection();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "") {
                Response.Write("<script>alert('Please insert Name.');</script>");
                TextBox1.Focus();
            }
            else if(TextBox2.Text == ""){
                Response.Write("<script>alert('Please insert Contact Number');</script>");
                TextBox2.Focus();
            }

            else if (TextBox3.Text == "")
            {
                Response.Write("<script>alert('Please insert E-mail');</script>");
                TextBox3.Focus();
            }
            else if (TextBox4.Text == "")
            {
                Response.Write("<script>alert('Please insert Confirm E-mail');</script>");
                TextBox4.Focus();
            }
            else if (TextBox3.Text != TextBox4.Text)
            {
                Response.Write("<script>alert('Email is not same with Confirm Email. Please insert again.');</script>");
                TextBox4.Focus();
            }
            else
            {
                Response.Write("<script>alert('Payment is complete.');</script>");
            }

            
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
           

        }
    }
}