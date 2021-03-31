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
    public partial class Form1 : Form
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



        public Form1()
        {
            this.MouseDown += new MouseEventHandler(move_window);
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(); 
            f.Show();
        

            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //this.employeeTableAdapter.Fill(this.diskeDataSet.Employee);
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

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();

            this.Hide();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();

            this.Hide();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();

            this.Hide();
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
