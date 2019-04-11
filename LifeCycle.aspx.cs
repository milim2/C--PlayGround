using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageLifeCycle
{
    public partial class LifeCycle : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            // Text Box Control Dynamically
            TextBox txt = new TextBox();
            txt.ID = "mytext";
            txt.EnableTheming = true;
            txt.Text = "I am TextBox";
            //When you create below event handler press Tab 2 times from your keyboard
            txt.TextChanged += new EventHandler(txt_TextChanged);
            this.form1.Controls.Add(txt);
            txt.Text = "Change Text&press Submit";

            //Page.MasterPageFile = "~/MasterPage.master";

            //Checking whether value is strored From view state or not in preIntit Event
            int i = Convert.ToInt32(ViewState["p"]) + 1;
            ViewState["p"] = i.ToString();
            Label1.Text = " Hi..";
            Label1.Text = Label1.Text + " " + " I am PreInit Event " + ViewState["p"];

        // create button control dynamically
            Button submit_button = new Button();
            submit_button.ID = "btntxt";
            submit_button.Text = "Submit";
            //When you create below event handler press Tab 2 times from your keyboard
            submit_button.Click += new EventHandler(submit_button_Click);
            this.form1.Controls.Add(submit_button);
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            //Checking whether value is strored From view state or not in Intit Event
            int i = Convert.ToInt32(ViewState["a"]) + 1;
            ViewState["a"] = i.ToString();
            Label1.Text = Label1.Text + " " + "I am Init Event "+ViewState["a"];
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            //Checking whether value is strored From view state or not in InitComplete Event
            int i = Convert.ToInt32(ViewState["b"]) + 1;
            ViewState["b"] = i.ToString();
            Label1.Text = Label1.Text + " " + " I am InitComplete Event " + ViewState["b"];
        }

        protected override void OnPreLoad(EventArgs e)
        {
            //Page.EnableViewState = false;
            //Checking whether value is strored From view state or not in OnPreLoad Event
            int i = Convert.ToInt32(ViewState["c"]) + 1;
            ViewState["c"] = i.ToString();
            Label1.Text = Label1.Text + " " + " I am PreLoad Event " + ViewState["c"] + "\n";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Checking whether value is strored From view state or not in Load Event
            int i = Convert.ToInt32(ViewState["d"]) + 1;
            ViewState["d"] = i.ToString();
            Label1.Text = Label1.Text + " " + "I am Load Event " + ViewState["d"] + "\n";
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            //Checking whether value is strored From view state or not in LoadComplete Event
            int i = Convert.ToInt32(ViewState["e"]) + 1;
            ViewState["e"] = i.ToString();
            Label1.Text = Label1.Text + " " + "I am LoadComplete Event " + ViewState["e"];
        }

        protected override void OnPreRender(EventArgs e)
        {
            //Checking whether value is strored From view state or not in OnPrerender Event
            int i = Convert.ToInt32(ViewState["f"]) + 1;
            ViewState["f"] = i.ToString();
            Label1.Text = Label1.Text + " " + "I am PreRender Event " + ViewState["f"];
        }

        protected override void OnSaveStateComplete(EventArgs e)
        {
            //Checking whether value is strored From view state or not in OnSaveComplete Event
            int i = Convert.ToInt32(ViewState["g"]) + 1;
            ViewState["g"] = i.ToString();
            Label1.Text = Label1.Text + " " + "I am SaveStateComplete Event " + ViewState["g"];
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //Checking whether value is strored From view state or not in UnLoad Event
            int i = Convert.ToInt32(ViewState["h"]) + 1;
            ViewState["h"] = i.ToString();
            Label1.Text = Label1.Text + " " + "I am UnLoad Event" + ViewState["h"];
            // Response.Write("hello ji");//when you run this will show error 
        }
        protected void txt_TextChanged(object sender, EventArgs e)
        {
            //Checking whether value is strored From view state or not in tet_Change Event
            int i = Convert.ToInt32(ViewState["i"]) + 1;
            ViewState["i"] = i.ToString();
            Label1.Text = "I am Text change Event " + ViewState["i"];
        }
        protected void submit_button_Click(object sender, EventArgs e)
        {
            //Checking whether value is strored From view state or not in Submit_button Event
            int i = Convert.ToInt32(ViewState["j"]) + 1;
            ViewState["j"] = i.ToString();
            Label1.Text = Label1.Text + " " + " I am Submit_button Event " + ViewState["j"];
          }
    }
}