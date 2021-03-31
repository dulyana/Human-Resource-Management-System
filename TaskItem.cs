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
    public partial class TaskItem : UserControl
    {
        public TaskItem(string Text, bool Checked)
        {
            InitializeComponent();

            lbl_Task.Text = Text;
            chk.Checked = Checked;
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chk_OnChange(object sender, EventArgs e)
        {
            if (chk.Checked)
            {
                lbl_Task.Font = new Font(lbl_Task.Font.Name, lbl_Task.Font.SizeInPoints, FontStyle.Strikeout);
            }
            else
            {
                lbl_Task.Font = new Font(lbl_Task.Font.Name, lbl_Task.Font.SizeInPoints, FontStyle.Regular);
            }

            if (onChange != null)
            {
                onChange.Invoke(this, new EventArgs());
            }
        }

        private void TaskItem_Load(object sender, EventArgs e)
        {
            if (chk.Checked)
            {
                lbl_Task.Font = new Font(lbl_Task.Font.Name, lbl_Task.Font.SizeInPoints, FontStyle.Strikeout);
            }
            else
            {
                lbl_Task.Font = new Font(lbl_Task.Font.Name, lbl_Task.Font.SizeInPoints, FontStyle.Regular);
            }

            
        }

        //events
        public EventHandler onChange = null;
        public EventHandler onDelete = null;

        private void btn_Del_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Tomato;
            
            if (onDelete != null)
            {
                onDelete.Invoke(this, new EventArgs());
            }
            lbl_Task.Text = "Deleted";
        }
    }
}
