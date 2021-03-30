using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SADProject
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are You Sure You Want to Log Out?");
            Form1 frm1 = new Form1();
            this.Close();
            frm1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Personnel profile = new Personnel();
            this.Hide();
            profile.Show();

        }
    }
}
