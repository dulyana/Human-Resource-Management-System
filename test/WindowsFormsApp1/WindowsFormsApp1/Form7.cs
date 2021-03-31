using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
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

        int passLength = 0;
      
        public Form7()
        {
            this.MouseDown += new MouseEventHandler(move_window);
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form6 f = new Form6();
            f.Show();
        }

        static string Shuffle(string input)
        {
            var q = from c in input.ToCharArray()
                    orderby Guid.NewGuid()
                    select c;
            string s = string.Empty;
            foreach (var r in q)
                s += r;
            return s;
        }

        private void generatepass_Click(object sender, EventArgs e)
        {
            txb_password.Text = "";
            string text = "aAbBcCdDeEfFgGhHiIjJhHkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ01234567890123456789";
            text = Shuffle(text);   
            text = text.Remove(passLength);  
            txb_password.Text = text;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            passLength = trackBar1.Value + 1;  
            lbl_passlength.Text = passLength.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
