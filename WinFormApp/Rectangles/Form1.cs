using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_Rectangles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(LengthtextBox.Text);
            int width = Convert.ToInt32(WidthtextBox.Text);

            Rectangle r = new Rectangle();
            r.setLength(length);
            r.setWidth(width);


            MessageBox.Show(" The Area is " + r.CalculateArea().ToString());
        }
    }
}
