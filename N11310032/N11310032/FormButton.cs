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
    public partial class FormButton : Form
    {
        public FormButton()
        {
            InitializeComponent();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            String count = label4.Text;
            int sum = Int32.Parse(count) - 1;
            label4.Text = sum.ToString();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            String count = label4.Text;
            int sum = Int32.Parse(count) + 1;
            label4.Text = sum.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int height = button1.Height;
            int width = button1.Width;
            button1.Size = new Size(width + 10, height + 10);
        }

        private void btnbutton_Click(object sender, EventArgs e)
        {
            if (btnbutton.Text == "我已經按過了")
                btnbutton.Text = "請按我一下";
            else if (btnbutton.Text == "請按我一下")
                btnbutton.Text = "我已經按過了";
        }
    }
}
