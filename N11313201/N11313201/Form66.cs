using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N11313201
{
    public partial class Form66 : Form

    {
        int second;
        public Form66()
        {
            InitializeComponent();
            this.second = 0;
        }

        private void Form66_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            second = 0;
            label1.Text=$"0秒";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = String.Format("{0}秒",this.second);
            this.second++;
        }
    }
}
