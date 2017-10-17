using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shitbot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.gaiaonline.com/forum/chatterbox/f.23/");
            System.Threading.Thread.Sleep(1000);
            webBrowser2.Navigate("http://www.gaiaonline.com/forum/chatterbox/f.23/");
            System.Threading.Thread.Sleep(1000);
            webBrowser3.Navigate("http://www.gaiaonline.com/forum/chatterbox/f.23/");
            System.Threading.Thread.Sleep(1000);
            webBrowser4.Navigate("http://www.gaiaonline.com/forum/chatterbox/f.23/");
            System.Threading.Thread.Sleep(1000);
            webBrowser5.Navigate("http://www.gaiaonline.com/forum/chatterbox/f.23/");
            System.Threading.Thread.Sleep(1000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void setIntervalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(toolStripComboBox1.Text);
            timer1.Interval = time;
        }
    }
}
