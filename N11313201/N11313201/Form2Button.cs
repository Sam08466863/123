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
    public partial class Form2Button : Form
    {
        public Form2Button()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            if (btnClick.Text == "請按我一下")
                btnClick.Text = "我已經被按過了";

            else if ( btnClick.Text == "我已經被按過了")
                btnClick.Text = "請按我一下";
        }
    }
}
