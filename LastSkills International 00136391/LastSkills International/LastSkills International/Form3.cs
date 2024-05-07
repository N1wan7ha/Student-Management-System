using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LastSkills_International
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=MYFRIEND23\\SQLEXPRESS;Initial Catalog=SkillsInternationalDB;Integrated Security=True");

        private void buttonadd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[registration]
           ([Registration No]
           ,[Programme]
           ,[First Name]
           ,[Last Name]
           ,[Date of Birth]
           ,[Gender]
           ,[Address]
           ,[Mobile Phone]
           ,[Home Phone]
           ,[Email]
           ,[Parent Name]
           ,[NIC]
           ,[Contact Number])
                   
    VALUES
                           ('" + comboBox1registrationno.SelectedItem.ToString() + "','" + comboBoxProg.SelectedItem.ToString() + "','" + textBoxFirstName.Text + "','" + textBoxLastName.Text + "','" + dateTimePicker1.Format + "','" + comboBox1.SelectedItem.ToString() + "','" + textBoxAddress.Text + "','" + textBoxmobilephone.Text + "','" + textBoxhomephone.Text + "', '" + textBoxEmail.Text + "','" + textBoxparentname.Text + "','" + textBoxNic.Text + "','" + textBoxcontactnumber.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQueryAsync();
            con.Close();

            MessageBox.Show("Registered Successfully"); 
            MessageBoxIcon icon = MessageBoxIcon.Information;
        }
        
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            comboBox1registrationno.Text = string.Empty;
            comboBoxProg.Text = string.Empty;   
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            dateTimePicker1.Text = string.Empty;
            comboBox1.Text = string.Empty;  
            textBoxAddress.Clear();
            textBoxhomephone.Clear();
            textBoxmobilephone.Clear();
            textBoxEmail.Clear();
            textBoxparentname.Clear();
            textBoxcontactnumber.Clear();
            textBoxNic.Clear();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Go to next page - mainmenu
            Form2 f2 = new Form2();
            f2.Show();

            this.Hide();

        }
    }
}

