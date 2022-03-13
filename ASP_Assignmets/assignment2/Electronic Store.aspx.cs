using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Assignment2
{
    public partial class Electronic_Store : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] str = new string[] { "Select ", "laptop", "mobile_phone", "camera", "television", "ipad" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/images/" + str + ".jfif";
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.SelectedIndex.ToString();
            if (DropDownList1.Text == "camera")
            {
                TextBox1.Text = "60000";
            }
            else if (DropDownList1.Text == "laptop")
            {
                TextBox1.Text = "47000";
            }
            else if (DropDownList1.Text == "ipad")
            {
                TextBox1.Text = "27000";
            }
            else if (DropDownList1.Text == "television")
            {
                TextBox1.Text = "15000";
            }
          
            else
            {
                TextBox1.Text = "10000";
            }
        }
    }
}