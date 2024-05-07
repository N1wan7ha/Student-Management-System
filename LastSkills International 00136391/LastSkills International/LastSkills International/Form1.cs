using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastSkills_International
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var UserName = textBoxUserName.Text;
            var Password = textBoxPassword.Text;

            if (UserName == "admin" && Password == "Skills@123")
            {
                MessageBox.Show("You have Successfully Logged in as an admin !!");

                //Go to next page - mainmenu
                Form2 obj = new Form2();
                obj.Show();

                //Hide Login
                this.Hide();
            }

            else
            {
                MessageBox.Show("Ivaild Login credentials, please check username and password and try again", "Invaild login details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUserName.Clear();
                textBoxPassword.Clear();

                //to focus username




            }

            }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBoxUserName.Clear();
            textBoxPassword.Clear();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to cancel login and exit the application", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 

                Application.Exit();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
