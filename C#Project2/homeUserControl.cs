using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using payroll;

namespace SADProject2
{
    public partial class homeUserControl : UserControl
    {
        public homeUserControl()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            frmPayroll payrollModule = new frmPayroll();
            this.Hide();
            payrollModule.Show();
        }

        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            Personel personnel = new Personel();
            this.Hide();
            personnel.Show();
        }
    }
}
