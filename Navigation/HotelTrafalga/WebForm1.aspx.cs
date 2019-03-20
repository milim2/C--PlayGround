using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelTrafalga
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int amount = 0;
            if (cbPick.Checked == true)
            {
                amount += 20;
            }
            if (cbBuff.Checked == true)
            {
                amount += 15;
            }
            if (cbWifi.Checked == true)
            {
                amount += 10;
            }

            if(rbKing.Checked == true)
            {
                amount += 150;
            }
            if (rbQueen.Checked == true)
            {
                amount += 120;
            }

            if (rbStandard.Checked == true)
            {
                amount += 125;
            }
            if (rbDelux.Checked == true)
            {
                amount += 250;
            }
            if (rbHoneyMoon.Checked == true)
            {
                amount += 500;
            }
                                 

            TextBox1.Text = amount.ToString();
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label3.Text = "Purpose of visit " + ListBox1.Text;
        }

        protected void rbStandard_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}