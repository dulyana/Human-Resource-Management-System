namespace SADProject2
{
    partial class TaskItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chk = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lbl_Task = new System.Windows.Forms.Label();
            this.btn_Del = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Del)).BeginInit();
            this.SuspendLayout();
            // 
            // chk
            // 
            this.chk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.chk.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chk.Checked = true;
            this.chk.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.chk.ForeColor = System.Drawing.Color.White;
            this.chk.Location = new System.Drawing.Point(15, 19);
            this.chk.Name = "chk";
            this.chk.Size = new System.Drawing.Size(20, 20);
            this.chk.TabIndex = 0;
            this.chk.OnChange += new System.EventHandler(this.chk_OnChange);
            // 
            // lbl_Task
            // 
            this.lbl_Task.AutoSize = true;
            this.lbl_Task.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Task.Location = new System.Drawing.Point(50, 18);
            this.lbl_Task.Name = "lbl_Task";
            this.lbl_Task.Size = new System.Drawing.Size(0, 21);
            this.lbl_Task.TabIndex = 1;
            this.lbl_Task.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.BackColor = System.Drawing.Color.Transparent;
            this.btn_Del.Image = global::SADProject2.Properties.Resources.delete;
            this.btn_Del.ImageActive = null;
            this.btn_Del.Location = new System.Drawing.Point(534, 11);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(28, 38);
            this.btn_Del.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Del.TabIndex = 2;
            this.btn_Del.TabStop = false;
            this.btn_Del.Zoom = 10;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // TaskItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.lbl_Task);
            this.Controls.Add(this.chk);
            this.Name = "TaskItem";
            this.Size = new System.Drawing.Size(570, 60);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Del)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCheckbox chk;
        private System.Windows.Forms.Label lbl_Task;
        private Bunifu.Framework.UI.BunifuImageButton btn_Del;
    }
}
