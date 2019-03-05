using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // I expect you to add this inport by yourself

namespace Connect_DB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection();

            

            //SqlConnection cmd ;

           // private void RefreshData()
            {
                 SqlConnection conn = new SqlConnection(); // the following provides information to 
                // connect to the Week7A database
                conn.ConnectionString = "Server=(local); Database=Week7A; User = ****; Password = ********";

                // we will need a command object to execute a query
                //conn.ConnectionString = conString;
                SqlCommand cmd = conn.CreateCommand();

                try
                {

                    string query = "select * from FlightInfo; ";

                    cmd.CommandText = query;

                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    // There is data inside the reader object
                    // we need to convert the data to an object that the data
                    // grid view can understand

                    DataTable dt = new DataTable();

                    dt.Load(reader);
                    dataGridView1.DataSource = dt;

                    cmbSelect.DisplayMember = "FlightNum";
                    cmbSelect.ValueMember = "ID";
                    cmbSelect.DataSource = dt;


                    reader.Close();



                }
                catch (Exception ex)
                {

                    string msg = ex.Message.ToString();
                    string caption = "Error";

                    MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    cmd.Dispose(); // cleans up memory
                    conn.Close(); // close the connection
                    //RefreshData(); 

                }

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
