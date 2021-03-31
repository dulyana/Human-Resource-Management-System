namespace SADProject2
{
    partial class MainMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Logout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Account = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Annouce = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Uname = new System.Windows.Forms.Label();
            this.btn_Task = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Info = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Home = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.taskUserControl = new SADProject2.taskUserControl();
            this.homeUserControl = new SADProject2.homeUserControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.btn_Account);
            this.panel1.Controls.Add(this.btn_Annouce);
            this.panel1.Controls.Add(this.lbl_Email);
            this.panel1.Controls.Add(this.lbl_Uname);
            this.panel1.Controls.Add(this.btn_Task);
            this.panel1.Controls.Add(this.btn_Info);
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 520);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 181);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 48);
            this.SidePanel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SADProject2.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(65, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Logout.BorderRadius = 0;
            this.btn_Logout.ButtonText = "Logout";
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Logout.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Logout.Iconimage = global::SADProject2.Properties.Resources.logout;
            this.btn_Logout.Iconimage_right = null;
            this.btn_Logout.Iconimage_right_Selected = null;
            this.btn_Logout.Iconimage_Selected = null;
            this.btn_Logout.IconMarginLeft = 0;
            this.btn_Logout.IconMarginRight = 0;
            this.btn_Logout.IconRightVisible = true;
            this.btn_Logout.IconRightZoom = 0D;
            this.btn_Logout.IconVisible = true;
            this.btn_Logout.IconZoom = 50D;
            this.btn_Logout.IsTab = false;
            this.btn_Logout.Location = new System.Drawing.Point(12, 421);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Logout.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_Logout.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.btn_Logout.selected = false;
            this.btn_Logout.Size = new System.Drawing.Size(189, 48);
            this.btn_Logout.TabIndex = 9;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Logout.Textcolor = System.Drawing.Color.White;
            this.btn_Logout.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Account
            // 
            this.btn_Account.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Account.BackColor = System.Drawing.Color.Transparent;
            this.btn_Account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Account.BorderRadius = 0;
            this.btn_Account.ButtonText = "Account Settings";
            this.btn_Account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Account.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Account.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Account.Iconimage = global::SADProject2.Properties.Resources.settings;
            this.btn_Account.Iconimage_right = null;
            this.btn_Account.Iconimage_right_Selected = null;
            this.btn_Account.Iconimage_Selected = null;
            this.btn_Account.IconMarginLeft = 0;
            this.btn_Account.IconMarginRight = 0;
            this.btn_Account.IconRightVisible = true;
            this.btn_Account.IconRightZoom = 0D;
            this.btn_Account.IconVisible = true;
            this.btn_Account.IconZoom = 50D;
            this.btn_Account.IsTab = false;
            this.btn_Account.Location = new System.Drawing.Point(12, 373);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Account.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_Account.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.btn_Account.selected = false;
            this.btn_Account.Size = new System.Drawing.Size(189, 48);
            this.btn_Account.TabIndex = 8;
            this.btn_Account.Text = "Account Settings";
            this.btn_Account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Account.Textcolor = System.Drawing.Color.White;
            this.btn_Account.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Account.Click += new System.EventHandler(this.btn_Account_Click);
            // 
            // btn_Annouce
            // 
            this.btn_Annouce.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Annouce.BackColor = System.Drawing.Color.Transparent;
            this.btn_Annouce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Annouce.BorderRadius = 0;
            this.btn_Annouce.ButtonText = "Announcements";
            this.btn_Annouce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Annouce.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Annouce.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Annouce.Iconimage = global::SADProject2.Properties.Resources.announcements;
            this.btn_Annouce.Iconimage_right = null;
            this.btn_Annouce.Iconimage_right_Selected = null;
            this.btn_Annouce.Iconimage_Selected = null;
            this.btn_Annouce.IconMarginLeft = 0;
            this.btn_Annouce.IconMarginRight = 0;
            this.btn_Annouce.IconRightVisible = true;
            this.btn_Annouce.IconRightZoom = 0D;
            this.btn_Annouce.IconVisible = true;
            this.btn_Annouce.IconZoom = 50D;
            this.btn_Annouce.IsTab = false;
            this.btn_Annouce.Location = new System.Drawing.Point(12, 277);
            this.btn_Annouce.Name = "btn_Annouce";
            this.btn_Annouce.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Annouce.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_Annouce.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.btn_Annouce.selected = false;
            this.btn_Annouce.Size = new System.Drawing.Size(189, 48);
            this.btn_Annouce.TabIndex = 7;
            this.btn_Annouce.Text = "Announcements";
            this.btn_Annouce.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Annouce.Textcolor = System.Drawing.Color.White;
            this.btn_Annouce.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Annouce.Click += new System.EventHandler(this.btn_Annouce_Click);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Email.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.Color.White;
            this.lbl_Email.Location = new System.Drawing.Point(28, 148);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(139, 20);
            this.lbl_Email.TabIndex = 4;
            this.lbl_Email.Text = "johnDoe@gmail.com";
            // 
            // lbl_Uname
            // 
            this.lbl_Uname.AutoSize = true;
            this.lbl_Uname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Uname.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Uname.ForeColor = System.Drawing.Color.White;
            this.lbl_Uname.Location = new System.Drawing.Point(97, 118);
            this.lbl_Uname.Name = "lbl_Uname";
            this.lbl_Uname.Size = new System.Drawing.Size(0, 30);
            this.lbl_Uname.TabIndex = 0;
            // 
            // btn_Task
            // 
            this.btn_Task.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Task.BackColor = System.Drawing.Color.Transparent;
            this.btn_Task.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Task.BorderRadius = 0;
            this.btn_Task.ButtonText = "Tasks";
            this.btn_Task.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Task.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Task.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Task.Iconimage = global::SADProject2.Properties.Resources.tasks;
            this.btn_Task.Iconimage_right = null;
            this.btn_Task.Iconimage_right_Selected = null;
            this.btn_Task.Iconimage_Selected = null;
            this.btn_Task.IconMarginLeft = 0;
            this.btn_Task.IconMarginRight = 0;
            this.btn_Task.IconRightVisible = true;
            this.btn_Task.IconRightZoom = 0D;
            this.btn_Task.IconVisible = true;
            this.btn_Task.IconZoom = 50D;
            this.btn_Task.IsTab = false;
            this.btn_Task.Location = new System.Drawing.Point(12, 229);
            this.btn_Task.Name = "btn_Task";
            this.btn_Task.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Task.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_Task.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.btn_Task.selected = false;
            this.btn_Task.Size = new System.Drawing.Size(189, 48);
            this.btn_Task.TabIndex = 6;
            this.btn_Task.Text = "Tasks";
            this.btn_Task.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Task.Textcolor = System.Drawing.Color.White;
            this.btn_Task.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Task.Click += new System.EventHandler(this.btn_Task_Click);
            // 
            // btn_Info
            // 
            this.btn_Info.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Info.BackColor = System.Drawing.Color.Transparent;
            this.btn_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Info.BorderRadius = 0;
            this.btn_Info.ButtonText = "Information";
            this.btn_Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Info.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Info.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Info.Iconimage = global::SADProject2.Properties.Resources.info;
            this.btn_Info.Iconimage_right = null;
            this.btn_Info.Iconimage_right_Selected = null;
            this.btn_Info.Iconimage_Selected = null;
            this.btn_Info.IconMarginLeft = 0;
            this.btn_Info.IconMarginRight = 0;
            this.btn_Info.IconRightVisible = true;
            this.btn_Info.IconRightZoom = 0D;
            this.btn_Info.IconVisible = true;
            this.btn_Info.IconZoom = 50D;
            this.btn_Info.IsTab = false;
            this.btn_Info.Location = new System.Drawing.Point(12, 325);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Info.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_Info.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.btn_Info.selected = false;
            this.btn_Info.Size = new System.Drawing.Size(189, 48);
            this.btn_Info.TabIndex = 5;
            this.btn_Info.Text = "Information";
            this.btn_Info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Info.Textcolor = System.Drawing.Color.White;
            this.btn_Info.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Home.BackColor = System.Drawing.Color.Transparent;
            this.btn_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Home.BorderRadius = 0;
            this.btn_Home.ButtonText = "Home";
            this.btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Home.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Home.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Home.Iconimage = global::SADProject2.Properties.Resources.home;
            this.btn_Home.Iconimage_right = null;
            this.btn_Home.Iconimage_right_Selected = null;
            this.btn_Home.Iconimage_Selected = null;
            this.btn_Home.IconMarginLeft = 0;
            this.btn_Home.IconMarginRight = 0;
            this.btn_Home.IconRightVisible = true;
            this.btn_Home.IconRightZoom = 0D;
            this.btn_Home.IconVisible = true;
            this.btn_Home.IconZoom = 50D;
            this.btn_Home.IsTab = false;
            this.btn_Home.Location = new System.Drawing.Point(12, 181);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Home.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_Home.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.btn_Home.selected = false;
            this.btn_Home.Size = new System.Drawing.Size(189, 48);
            this.btn_Home.TabIndex = 4;
            this.btn_Home.Text = "Home";
            this.btn_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Textcolor = System.Drawing.Color.White;
            this.btn_Home.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(201, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 13);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Human Resources Management System";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(220, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(115, 50);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SADProject2.Properties.Resources.National_Savings_Bank_logo;
            this.pictureBox2.Location = new System.Drawing.Point(8, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = global::SADProject2.Properties.Resources.notifications;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(774, 16);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(20, 21);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 6;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::SADProject2.Properties.Resources.help;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(800, 16);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(20, 21);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 5;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.Image = global::SADProject2.Properties.Resources.Close;
            this.btn_Close.ImageActive = null;
            this.btn_Close.Location = new System.Drawing.Point(826, 16);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(20, 21);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Close.TabIndex = 4;
            this.btn_Close.TabStop = false;
            this.btn_Close.Zoom = 10;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // taskUserControl1
            // 
            this.taskUserControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.taskUserControl.Location = new System.Drawing.Point(201, 93);
            this.taskUserControl.Name = "taskUserControl1";
            this.taskUserControl.Size = new System.Drawing.Size(649, 427);
            this.taskUserControl.TabIndex = 8;
            // 
            // homeUserControl1
            // 
            this.homeUserControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.homeUserControl.Location = new System.Drawing.Point(201, 93);
            this.homeUserControl.Name = "homeUserControl1";
            this.homeUserControl.Size = new System.Drawing.Size(649, 427);
            this.homeUserControl.TabIndex = 7;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(850, 520);
            this.Controls.Add(this.homeUserControl);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.taskUserControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Uname;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Annouce;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Task;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Info;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Home;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Logout;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Account;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton btn_Close;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private homeUserControl homeUserControl;
        private taskUserControl taskUserControl;
    }
}