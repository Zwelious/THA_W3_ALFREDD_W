using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W3_Alfredd_W
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            submit_btn.Enabled = false;
        }

        private void true_check_CheckedChanged(object sender, EventArgs e)
        {
            if (true_check.Checked == true)
            {
                submit_btn.Enabled = true;
            }
            else
            {
                submit_btn.Enabled = false;
            }
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            if(name_text.Text == "" || artist_text.Text == " ")
            {
                MessageBox.Show("Enter correct input", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form2.form2.label.Text = "Hi, my name is" + name_text.Text + " and my favorite artist is " + artist_text.Text;
            }
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void name_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void artist_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
