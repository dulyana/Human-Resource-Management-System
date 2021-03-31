namespace SADProject2
{
    partial class taskUserControl
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
            this.components = new System.ComponentModel.Container();
            this.txt_Task = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.customImageButton1 = new MyImageButton.CustomImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Task
            // 
            this.txt_Task.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Task.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_Task.ForeColor = System.Drawing.Color.Black;
            this.txt_Task.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Task.HintText = "Add Task Here";
            this.txt_Task.isPassword = false;
            this.txt_Task.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.txt_Task.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Task.LineMouseHoverColor = System.Drawing.Color.Khaki;
            this.txt_Task.LineThickness = 3;
            this.txt_Task.Location = new System.Drawing.Point(33, 366);
            this.txt_Task.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Task.Name = "txt_Task";
            this.txt_Task.Size = new System.Drawing.Size(541, 33);
            this.txt_Task.TabIndex = 1;
            this.txt_Task.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(33, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 304);
            this.panel1.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // customImageButton1
            // 
            this.customImageButton1.Image = global::SADProject2.Properties.Resources.AddNormal;
            this.customImageButton1.ImageHover = global::SADProject2.Properties.Resources.AddHover;
            this.customImageButton1.ImageNormal = global::SADProject2.Properties.Resources.AddNormal;
            this.customImageButton1.Location = new System.Drawing.Point(581, 354);
            this.customImageButton1.Name = "customImageButton1";
            this.customImageButton1.Size = new System.Drawing.Size(54, 55);
            this.customImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customImageButton1.TabIndex = 0;
            this.customImageButton1.TabStop = false;
            this.customImageButton1.Click += new System.EventHandler(this.customImageButton1_Click);
            // 
            // taskUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Task);
            this.Controls.Add(this.customImageButton1);
            this.Name = "taskUserControl1";
            this.Size = new System.Drawing.Size(649, 427);
            ((System.ComponentModel.ISupportInitialize)(this.customImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyImageButton.CustomImageButton customImageButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Task;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
