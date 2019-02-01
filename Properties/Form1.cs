using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer("Ian", "Mora", 20);
            cust.Address = "444 Karr St, Oakville";

            //CustFullname.Text = cust.GetFullname();
            CustFullname.Text = cust.Fullname;

            //CustLastname.Text = cust.Lastname;
            // CustAge.Text = cust.GetAge().ToString();
            CustAge.Text = cust.Age.ToString();
            CustAddress.Text = cust.Address;
            CustDescription.Text = cust.Description;

            //bool test = cust.getIsQualified();
            bool test = cust.IsQualified;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CustFullname_Click(object sender, EventArgs e)
        {

        }
    }
}
