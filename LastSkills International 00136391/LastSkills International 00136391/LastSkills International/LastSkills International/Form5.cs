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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection("Data Source=MYFRIEND23\\SQLEXPRESS;Initial Catalog=SkillsInternationalDB;Integrated Security=True");

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MYFRIEND23\\SQLEXPRESS;Initial Catalog=SkillsInternationalDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete registration where Registration No=@Registration No", con);
            cmd.Parameters.AddWithValue("@registration No", int.Parse(textBoxSearch.Text));
            cmd.ExecuteNonQueryAsync();

            con.Close();
            MessageBox.Show("Successfully Deleted");


        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MYFRIEND23\\SQLEXPRESS;Initial Catalog=SkillsInternationalDB;Integrated Security=True");

            try
            {
                con.Open();

                String View_query = "SELECT * FROM registration WHERE registration no = " + textBoxSearch.Text;

                SqlDataAdapter SDA = new SqlDataAdapter(View_query, con);

                //Fill Datagrid view with DB values
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridViewSearch.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                con.Close();
            }


        }

        private void buttonViewAll_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MYFRIEND23\\SQLEXPRESS;Initial Catalog=SkillsInternationalDB;Integrated Security=True");

            try
            {
                con.Open();

                String ViewAll_query = "SELECT * FROM registration";

                SqlDataAdapter SDA = new SqlDataAdapter(ViewAll_query, con);

                //Fill Datagrid view with DB values
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridViewSearch.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Go to next page - mainmenu
            Form2 obj = new Form2();
            obj.Show();

            //Hide Edit Student
            this.Hide();

        }
    }
}
