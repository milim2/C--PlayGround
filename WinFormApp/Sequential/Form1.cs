using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplicationSequentialFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("Some.txt"))
            {
                while(!reader.EndOfStream)
                {
                    richTextBox1.AppendText(reader.ReadLine());
                }
            }


        }

        private void WriteBtn_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("Some.txt"))
            {
                writer.WriteLine(richTextBox1.Text);
            }


        }
    }
}
