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
        int a; int min=0; int max=100;
        public FormGame()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                int b = Int32.Parse(textBox1.Text);
               
                if (a == b)
                {
                    MessageBox.Show("猜對!");
                }
                else if (b > a & b <max)
                {
                    MessageBox.Show("小一點");
                    this.max = b;
                   
                }
                else if (b < a & b>min)
                {
                    MessageBox.Show("大一點");
                    this.min = b;
                    
                }
                else if (b >= max)
                {
                    MessageBox.Show("請輸入小於"+max+"的數字");
                   
                }
                else if (b <= min)
                {
                    MessageBox.Show("請輸入小於" + min + "的數字");

                }
                label2.Text = string.Format("請輸入{0}~{1}之間的數字", min, max);
            }
            catch (Exception e1)
            {
                MessageBox.Show("請輸入數字");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            min = 0;max = 100;
            textBox1.Text = null;
            label1.Text = "已隨機產生0~100數字，請在下方作答";
            label2.Text = string.Format("請輸入{0}~{1}之間的數字",min,max);
            a = r.Next(100);
            MessageBox.Show("所有變數已初始化");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
