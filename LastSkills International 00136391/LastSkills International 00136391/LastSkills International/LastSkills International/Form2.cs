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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            //Go to next page - login
            Form1 obj = new Form1();
            obj.Show();

            //Hide MainMenu
            this.Hide();

        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            //Go to next page - Add Student
            Form3 obj = new Form3();
            obj.Show();

            this.Hide();

        }

        private void buttonEditStudent_Click(object sender, EventArgs e)
        {
            //Go to next page - Edit Student
            Form4 obj = new Form4();
            obj.Show();

            this.Hide();

        }

        private void buttonRemoveStudent_Click(object sender, EventArgs e)
        {
            //Go to next page - Remove Student
            Form5 obj = new Form5();
            obj.Show();

            this.Hide();

        }

        private void buttonViewStudents_Click(object sender, EventArgs e)
        {
            //Go to next page - View All Students
            Form6 obj = new Form6();
            obj.Show();

            this.Hide();

        }

        private void linkLabelRulesandRegulations_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Go to next page - Rules and Regulations
            Form7 obj = new Form7();
            obj.Show();

            this.Hide();

        }
    }
}
