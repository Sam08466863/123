using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace N11313201
{
    public partial class Form4Gamecs : Form
    { 
        int min = 0, max = 100;
        int answer;

        public Form4Gamecs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            this.answer = r.Next(100);
            label3.Text = "已隨機產生0~100的數字，請在下方作答";
            label4.Text = string.Format("請輸入{0}~{1}之間的數值",min,max);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            try
            {
                int input = Int32.Parse(textBox6.Text);
                if (input==this.answer)//答對了
                {
                    MessageBox.Show("恭喜答對");
                }
                else if (input<this.answer)
                {
                    this.min=input;
                }
                else if (input>this.answer)
                {
                    this.max=input;
                }

                label4.Text = string.Format("請輸入{0}~{1}之間的數值", min, max);

            }

            catch (Exception el)
            {
                MessageBox.Show("輸入錯誤,請輸入數字");

            }
        }

    }
}














