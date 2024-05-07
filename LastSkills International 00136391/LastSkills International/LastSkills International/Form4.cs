using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastSkills_International
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=MYFRIEND23\\SQLEXPRESS;Initial Catalog=SkillsInternationalDB;Integrated Security=True");

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Go to next page - mainmenu
            Form2 obj = new Form2();
            obj.Show();

            //Hide Edit Student
            this.Hide();

        }


        private void pictureBoxeditreset_Click(object sender, EventArgs e)
        {
            textBox1rn.Clear(); 
            comboBox1.Text = string.Empty;
            textBoxeditFirstName.Clear();
            textBoxeditLastName.Clear();
            dateTimePicker1edit.Text = string.Empty;
            comboBox2.Text = string.Empty;
            textBoxAddressedit.Clear();
            textBoxeditmobilephone.Clear();
            textBoxedithomephone.Clear();
            textBoxeditEmail.Clear();
            textBoxeditparentname.Clear();
            textBoxeditcontactnumber.Clear();
            textBoxeditNic.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)

            
        {
            SqlConnection con = new SqlConnection("Data Source=MYFRIEND23\\SQLEXPRESS;Initial Catalog=SkillsInternationalDB;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("edit registration set Registration No = @RegistrationNo,Programme = @Programme,first name = @first name ,last name = @last name ,date of birth = @date of birth,gender = @gender ,address = @address,mobile phone = @mobile phone,home phone = @home phone,email = @email,parent name = @parent name ,NIC = @NIC ,contact number = @contact number", con);



            cmd.Parameters.AddWithValue("@registration no", int.Parse(textBox1rn.Text));
            cmd.Parameters.AddWithValue("@Programme", comboBox1.Text);
            cmd.Parameters.AddWithValue("@First Name", textBoxeditFirstName.Text);
            cmd.Parameters.AddWithValue("@Last Name", textBoxeditLastName.Text);
            cmd.Parameters.AddWithValue("@Date of Birth", dateTimePicker1edit.Text);
            cmd.Parameters.AddWithValue("@Gender", comboBox2.Text);
            cmd.Parameters.AddWithValue("@Address", textBoxAddressedit.Text);
            cmd.Parameters.AddWithValue("@Mobile Phone",textBoxeditmobilephone.Text);
            cmd.Parameters.AddWithValue("@Home Phone", textBoxedithomephone.Text);
            cmd.Parameters.AddWithValue("@Email", textBoxeditEmail.Text);
            cmd.Parameters.AddWithValue("@Parent Name", textBoxeditparentname.Text);
            cmd.Parameters.AddWithValue("@NIC", textBoxeditNic.Text);
            cmd.Parameters.AddWithValue("@Contact Number", textBoxeditcontactnumber.Text);
            cmd.ExecuteNonQueryAsync();

            con.Close();
            MessageBox.Show("Successfully Updated");



        }
    }
}
