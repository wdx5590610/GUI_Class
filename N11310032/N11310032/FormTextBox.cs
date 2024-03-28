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
    public partial class FormTextBox : Form
    {
        public FormTextBox()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text=textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("123");
        }
    }
}
