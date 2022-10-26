using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows
{
    public partial class Form2 : Form
    {

        // Is password_wrong
        bool isPasswordRight = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(&quot;登入&quot;);
            String password ="1234";
            if (String.Equals(password, textBox1.Text))
            {
                isPasswordRight = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("密碼錯誤");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 關閉form2
            // this.Close();
            // 關閉整個application
            System.Environment.Exit(0);
        }

        private void close_form_action(object sender, FormClosingEventArgs e)
        {
            if (this.isPasswordRight)
            {
            }
            else
            {
                e.Cancel = true;
            }
        }
    }

}
