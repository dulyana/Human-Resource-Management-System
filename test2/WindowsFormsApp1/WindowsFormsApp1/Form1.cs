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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            label9.Text = String.Empty;
            label10.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
            label11.Text = String.Empty;
            label12.Text = String.Empty;
            label13.Text = String.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This part is under construction");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Enter values to calculate");
            }

            else
            {
                Double a = Convert.ToDouble(label9.Text);
                Double b = Convert.ToDouble(textBox4.Text);
                Double c = Convert.ToDouble(textBox5.Text) / 100;
                Double d = (a + b)*c;
                Double f= d+ (Convert.ToDouble(label9.Text)+ Convert.ToDouble(textBox4.Text));
                label11.Text = f.ToString();
                
                label13.Text = "Rs";
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\test\WindowsFormsApp1\WindowsFormsApp1\Diske.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlCommand command =
                new SqlCommand("Select * from [Employee] where Employee_no=" + textBox1.Text + "", connection);
                connection.Open();

                SqlDataReader read = command.ExecuteReader();

                while (read.Read())
                {
                    label9.Text = (read["Salary"].ToString());
                    label10.Text = (read["Employee_name"].ToString());
                        label12.Text = "Rs";


                }
                read.Close();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
