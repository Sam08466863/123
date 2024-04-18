using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N11313201
{
    public partial class Form_MindExam : Form
    {
        public Form_MindExam()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tmp = textBox_input.Text;
            int c = Int32.Parse(tmp);
            //華氏 = (攝氏) * (9/5) + 32
            double result = c * 1.8 + 32;
            label_result.Text = result.ToString();



        }
    }
}













