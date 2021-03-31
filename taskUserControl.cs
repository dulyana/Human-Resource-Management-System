using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SADProject2
{
    public partial class taskUserControl : UserControl
    {
        public taskUserControl()
        {
            InitializeComponent();
          
        }

        int poss = 10;

        public void addItem(string Text, bool Checked)
        {
            TaskItem item = new TaskItem(Text, Checked);
            panel1.Controls.Add(item);
            item.onChange += Item_onChange;
            item.onDelete += Item_onDelete;
            item.Top = poss;
            poss = (item.Top + item.Height + 10);
        }

        private void Item_onDelete(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void Item_onChange(object sender, EventArgs e)
        {
            MessageBox.Show("Testing");
        }

        private void customImageButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Task.Text))
            {
                MessageBox.Show("Give the task a name");
                return;
            }
            addItem(txt_Task.Text, false);
            txt_Task.Text = String.Empty;
        }
    }
}
