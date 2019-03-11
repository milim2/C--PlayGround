using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconnected
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'week7BDataSet.FlightInfo' table. You can move, or remove it, as needed.
            this.flightInfoTableAdapter.Fill(this.week7BDataSet.FlightInfo);
            cmbAirlineType.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((tbAirline.Text == "") || (tbFlightNum.Text == "") || (tbDest.Text == ""))
            {
                MessageBox.Show("No empty textboxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // the purpose of DataSet1 is to manager our data (manage all the rows, columns etc.)
                // But we need another object to transfer data to/from the dataset! -> TableAdapters
                DataSet1 ds1 = new DataSet1();
                DataSet1TableAdapters.FlightInfoTableAdapter taFlight = new DataSet1TableAdapters.FlightInfoTableAdapter();

                // We need to add a new row, we need to instantiate a row object
                DataSet1.FlightInfoRow fRow = ds1.FlightInfo.NewFlightInfoRow();

                //Now let's populate the row!!!
                fRow.Alirline = tbAirline.Text;
                fRow.FlightNum = tbFlightNum.Text;
                fRow.Destination = tbDest.Text;
                fRow.AliplaneType = cmbAirlineType.SelectedItem.ToString();
                // By this point we have populated a row!!

                ds1.FlightInfo.Rows.Add(fRow);

                // Now lets add to the real database !!

                taFlight.Update(ds1.FlightInfo);

                // We will call the database to give us the latest copy of a database
                taFlight.Fill(ds1.FlightInfo);
                cmbFlight.DataSource = ds1.FlightInfo;

            }
        }

    }
}
