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
    public partial class FormTimer : Form
    {
        int secound;
        public FormTimer()
        {
            InitializeComponent();
            this.secound= 0;
        }

        private void FormTimer_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = String.Format("{0}秒", this.secound);
            this.secound++;
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
            this.secound = 0;
            label1.Text = String.Format("{0}秒", this.secound);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
