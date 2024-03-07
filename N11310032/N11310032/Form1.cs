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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void chec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnbutton_Click(object sender, EventArgs e)
        {
            label5.Text="按鈕已經按過了";
            if (btnbutton.Text=="我已經按過了")
                btnbutton.Text="請按我一下";
            else if(btnbutton.Text=="請按我一下")
                btnbutton.Text="我已經按過了";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            String count = label4.Text;
            int sum=Int32.Parse(count)+1;
            label4.Text= sum.ToString();
        }
    }
}
