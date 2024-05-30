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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form2Button();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new Form2();

            form.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Form_MindExam();
            form.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new Form4Gamecs();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new Form77();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form = new Form66();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form form = new FormMenu();
            form.Show(); 
        }
    }
}


