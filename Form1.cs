using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS101
{
    public partial class Form1 : Form
    {
        private EventsFeed feed;
        private FileStream fs;
        public Form1()
        {
            InitializeComponent();
            feed = new EventsFeed();
            fs= new FileStream("cs.txt", FileMode.Append, FileAccess.Write);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Event ev=new Event(0,dateTimePicker1.Value,textBox2.Text,textBox3.Text);
            if (feed.addEvent(ev))
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(ev.ToString());
                sw.Close();
                label1.Text = "Added";
            }
            else
            {
                label1.Text = "Something Wrong";
            }
            
        }
    }
}
