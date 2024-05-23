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
    public partial class FormCheckBox : Form
    {
        public FormCheckBox()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("按鈕已按下");
            }
            else 
            {
                MessageBox.Show("按鈕已取消");
            }

           
        }
    }
}
