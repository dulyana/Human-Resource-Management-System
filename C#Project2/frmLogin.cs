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
using SADProject2.Properties;

namespace SADProject2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            Init_Data();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\dimagi249\SADProject\SADProject\HRMS.mdf;Integrated Security=True");
                string query = "select * from Login where UserName = '" + txtUser.Text.Trim() + "' and Password = '" + txtPwd.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (string.IsNullOrEmpty(txtUser.Text) && string.IsNullOrEmpty(txtPwd.Text))
                {
                    MessageBox.Show("Please enter Username and Password to Log In!");
                }
                else if (string.IsNullOrEmpty(txtUser.Text))
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
                    Save_Data();
                    MainMenu Menu = new MainMenu(txtUser.Text);
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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void Init_Data()
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                if (Properties.Settings.Default.Remme == "yes")
                {
                    txtUser.Text = Properties.Settings.Default.UserName;
                    txtPwd.Text = Properties.Settings.Default.Password;
                    chk_Remme.Checked = true;
                }
                else
                {
                    txtUser.Text = Properties.Settings.Default.UserName;
                }
            }
        }

        private void Save_Data()
        {
            if (chk_Remme.Checked)
            {
                Properties.Settings.Default.UserName = txtUser.Text;
                Properties.Settings.Default.Password = txtPwd.Text;
                Properties.Settings.Default.Remme = "yes";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = txtUser.Text;
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remme = "no";
                Properties.Settings.Default.Save();
            }
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
