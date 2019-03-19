using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Week10NavigationTech
{
    public partial class ViewCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Respons.Redirect
            // Label1.Text = Request.QueryString["Product"];
            // Label2.Text = Request.QueryString["StuffinTextBox"];

            // Server Transfer
            //HttpContext CurrContext = HttpContext.Current;
            //Label1.Text = CurrContext.Items["Item"].ToString();
            //Label2.Text = CurrContext.Items["Stuff"].ToString();

            //Server Transfer Session
            //Label1.Text = (string)(Session["TB"]);
            //Label2.Text = (string)(Session["DDL"]);

            //server transfer with application
            Label2.Text = (string)(Application["TB"]);
            Label1.Text = (string)(Application["DDL"]);
        }
    }
}