using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N11310032
{
    public partial class FormGame : Form
    {
        Random r = new Random();
        int a;
        public FormGame()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b= Int32.Parse(textBox1.Text);
            try
            {
                if (a == b)
                {
                    MessageBox.Show("猜對!");
                }
                else if (b > a)
                {
                    MessageBox.Show("小一點");
                }
                else if (b < a)
                {
                    MessageBox.Show("大一點");
                }
                else
                {
                    MessageBox.Show("請輸入數字");
                }
            }
            catch 
            {

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            a = r.Next(100);
            MessageBox.Show("所有變數已初始化");
        }
    }
}
