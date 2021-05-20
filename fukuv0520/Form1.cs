using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuv0520
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "押された";
            if (button1.Left == 0)
                button1.Left = 512;
            else
                button1.Left = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Top == 0)
                button2.Top = 360;
            button2.Top = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(button3.Top==0)
                button3.Visible = false;
            button3.Top = 0;
        }
    }
}
