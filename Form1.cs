using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SADProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\dimagi249\SADProject\SADProject\HRMS.mdf;Integrated Security=True");
                string query = "select * from Login where UserName = '" + txtUname.Text.Trim() + "' and Password = '" + txtPwd.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (string.IsNullOrEmpty(txtUname.Text) && string.IsNullOrEmpty(txtPwd.Text))
                {
                    MessageBox.Show("Please enter Username and Password to Log In!");
                }
                else if (string.IsNullOrEmpty(txtUname.Text))
                {
                    MessageBox.Show("Please enter Username!");
                }

                else if (string.IsNullOrEmpty(txtPwd.Text))
                {
                    MessageBox.Show("Please enter Password!");
                }
                else if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    MainMenu Menu = new MainMenu();
                    this.Hide();
                    Menu.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\dimagi249\SADProject\SADProject\HRMS.mdf;Integrated Security=True");
                con.Open();
                MessageBox.Show("Conneted");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            

        }
    }
}
