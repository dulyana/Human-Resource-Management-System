using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SADProject2
{
    public partial class MainMenu : Form
    {
        public MainMenu(string Uname)
        {
            InitializeComponent();
            lbl_Uname.Text = Uname;
            SidePanel.Height = btn_Home.Height;
            SidePanel.Top = btn_Home.Top;
            homeUserControl.BringToFront();
        }

        private void btn_Task_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Task.Height;
            SidePanel.Top = btn_Task.Top;
            taskUserControl.BringToFront();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Home.Height;
            SidePanel.Top = btn_Home.Top;
            homeUserControl.BringToFront();
        }

        private void btn_Annouce_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Annouce.Height;
            SidePanel.Top = btn_Annouce.Top;
            
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Info.Height;
            SidePanel.Top = btn_Info.Top;
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Account.Height;
            SidePanel.Top = btn_Account.Top;
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Logout.Height;
            SidePanel.Top = btn_Logout.Top;
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want to Log Out?", "LogOut", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                this.Hide();
                login.Show();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
