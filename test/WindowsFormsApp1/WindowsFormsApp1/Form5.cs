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
    public partial class Form5 : Form
    {
        SqlCommand cmd;
        SqlDataAdapter adapt;

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

        public Form5()
        {
            this.MouseDown += new MouseEventHandler(move_window);
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
            textBox6.Text = String.Empty;
            textBox7.Text = String.Empty;
            textBox8.Text = String.Empty;
            textBox9.Text = String.Empty;
            textBox10.Text = String.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBConnection dBConnection = new DBConnection();
            SqlConnection con = dBConnection.OpenDBConnection();
            
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Enter Employee Id To Update");
                }
                else
                {
                    SqlCommand cmdupdate = new SqlCommand("UPDATE Employee SET Employee_name='" + textBox2.Text + "', Other_names='" + textBox3.Text + "' ,Address='" + textBox4.Text + "' ,Contact_no='" + textBox5.Text + "' , Email = '" + textBox6.Text + "', Designation = '" + textBox7.Text + "', Department = '" + textBox8.Text + "', Salary = '" + textBox9.Text + "',  Department_location = '" + textBox10.Text + "' WHERE Employee_no = '" + textBox1.Text + "'", con);
                    con.Open();
                    cmdupdate.CommandType = CommandType.Text;
                    cmdupdate.ExecuteNonQuery();
                    MessageBox.Show("Data Updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox9.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox9.Text = textBox9.Text.Remove(textBox9.Text.Length - 1);
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {
        }
    }
}
