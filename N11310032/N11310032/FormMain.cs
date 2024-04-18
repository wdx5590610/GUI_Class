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

            if (button1.Text == "按鈕")
            {
                button1.Text = "視窗已開啟";

                Form FormButton = new FormButton();
                FormButton.Show();

            }
            else
            {
                
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "輸入框")
            {
                button2.Text = "視窗已開啟";

                Form form = new FormTextBox();
                form.Show();
      
            }
            else
            {
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Form1 = new Form1();
            Form1.Show();
        }
    }
}
