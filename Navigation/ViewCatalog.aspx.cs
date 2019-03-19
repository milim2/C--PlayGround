using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Week10NavigationTech
{
    public partial class ViewCatalog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // homework : thread 표시해서 오기 모든스레드==> 마스터페이지 for web services

        }

        // once a link is followed, we have no previous knowledge and 
        // previous page ---> www(Http stateless)

        //there are techiques we can use to pass information

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            // ResponseRedirect

            // we will redirect to the new page
            // directly from the code rather than 
            // using a particular tag
            // this will allow us to pass info using a query string

            // the query string is a just a list of variables and their values
            // that we can append to the url


            string strQuery = ddl.SelectedItem.Text;
            string strQuery2 = TextBox1.Text;

            Response.Redirect("ViewCart.aspx?Product="+ strQuery + "&StuffinTextBox=" + strQuery2); // redirect: passing values in url




            
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            // using server transfer
            // 
            HttpContext CurrContext = HttpContext.Current;
            CurrContext.Items.Add("Item", ddl.SelectedItem.ToString());
            CurrContext.Items.Add("Stuff", TextBox1.Text);
            Server.Transfer("ViewCart.aspx");


        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            // server execute -- same page
            HttpContext CurrContext = HttpContext.Current;
            CurrContext.Items.Add("Item", ddl.SelectedItem.ToString());
            CurrContext.Items.Add("Stuff", TextBox1.Text);
            Server.Execute("ViewCart.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            // 가장 중요
            // server transfer with session variables 

            Session["TB"] = TextBox1.Text;
            Session["DDL"] = ddl.SelectedItem.Text;
            Server.Execute("ViewCart.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Application["TB"] = TextBox1.Text;
            Application["DDL"] = ddl.SelectedItem.Text;
            Server.Transfer("ViewCart.aspx");
        }
    }
}