using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace N11310032
{
    public partial class FormCheckBox : Form
    {
      
        public FormCheckBox()
        {
            InitializeComponent();
            if (!File.Exists("OrderData.csv"))
                File.WriteAllText("OrderData.csv", "時間,主食,飲品\n", Encoding.UTF8);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String main = "",drinking="";
            foreach (Control c in panel1.Controls) 
            {
                if (c is CheckBox)
                {
                    CheckBox chk = (CheckBox)c;
                    if (chk.Checked)
                    {
                        main +=chk.Text+",";

                    }
                }
            }
            foreach (Control c in panel2.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox chk = (CheckBox)c;
                    if (chk.Checked)
                    {
                        drinking +=chk.Text+",";  
                    }
                }
            }
            main=main.Remove(main.Length-1, 1);
            drinking=drinking.Remove(drinking.Length-1, 1);
            DateTime currentDateTime=DateTime.Now;
            string formattedDateTime = currentDateTime.ToString("yyyy/MM/dd HH:mm");
            File.AppendAllText("OrderData.csv", formattedDateTime+","+main+","+drinking+"\n", Encoding.UTF8);
            MessageBox.Show("主餐:"+main+"\n飲料:"+drinking);
        }
    }
}
