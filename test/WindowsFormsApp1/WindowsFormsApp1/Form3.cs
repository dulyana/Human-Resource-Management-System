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
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        private void move_window(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public Form3()
        {
            this.MouseDown += new MouseEventHandler(move_window);
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diskeDataSet1.Employee' table. You can move, or remove it, as needed.
            // this.employeeTableAdapter.Fill(this.diskeDataSet1.Employee);  // Removed as per usage of the SQL DB

            //Connection to the database is defined as a class
            DBConnection con = new DBConnection();
            

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Employee_no, Employee_name, Other_names, Address, Contact_no, Email, Designation, Department, Salary, Department_location FROM [dbo].[Employee]", con.OpenDBConnection());
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dataGridView1.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection DBconn = new DBConnection();
                SqlConnection conn = DBconn.OpenDBConnection(); 
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Employee where Employee_no like '%" + textBox1.Text + "%'", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Visible = true;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }

        }

        private void employeeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
