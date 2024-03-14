using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N11310032
{
    public partial class FormMain : Form
    {
        public FormMain()
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
          
        }

        

        private void label5_Click(object sender, EventArgs e)
        {

        }





        private void button1_Click_2(object sender, EventArgs e)
        {

            if (button1.Text == "開啟視窗")
            {
                button1.Text = "視窗已開啟";

                Form form = new FormButton();
                form.Show();

            }
            else
            {

            }

            
        }
    }
}
