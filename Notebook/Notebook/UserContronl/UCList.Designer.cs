namespace Notebook.UserContronl
{
    partial class UCList
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxlist = new System.Windows.Forms.TextBox();
            this.textBoxtitle = new System.Windows.Forms.TextBox();
            this.textBoxcontent = new System.Windows.Forms.TextBox();
            this.textBoxtime = new System.Windows.Forms.TextBox();
            this.textBoxfolder = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttondelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxlist
            // 
            this.textBoxlist.BackColor = System.Drawing.Color.White;
            this.textBoxlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxlist.Enabled = false;
            this.textBoxlist.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxlist.Location = new System.Drawing.Point(0, 0);
            this.textBoxlist.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxlist.Multiline = true;
            this.textBoxlist.Name = "textBoxlist";
            this.textBoxlist.ReadOnly = true;
            this.textBoxlist.Size = new System.Drawing.Size(320, 125);
            this.textBoxlist.TabIndex = 0;
            this.textBoxlist.DoubleClick += new System.EventHandler(this.textBoxlist_DoubleClick);
            // 
            // textBoxtitle
            // 
            this.textBoxtitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxtitle.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxtitle.Location = new System.Drawing.Point(50, 18);
            this.textBoxtitle.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxtitle.Name = "textBoxtitle";
            this.textBoxtitle.Size = new System.Drawing.Size(143, 18);
            this.textBoxtitle.TabIndex = 2;
            // 
            // textBoxcontent
            // 
            this.textBoxcontent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxcontent.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxcontent.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxcontent.Location = new System.Drawing.Point(22, 46);
            this.textBoxcontent.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxcontent.Multiline = true;
            this.textBoxcontent.Name = "textBoxcontent";
            this.textBoxcontent.Size = new System.Drawing.Size(275, 42);
            this.textBoxcontent.TabIndex = 3;
            // 
            // textBoxtime
            // 
            this.textBoxtime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxtime.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxtime.ForeColor = System.Drawing.Color.Silver;
            this.textBoxtime.Location = new System.Drawing.Point(22, 94);
            this.textBoxtime.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxtime.Multiline = true;
            this.textBoxtime.Name = "textBoxtime";
            this.textBoxtime.Size = new System.Drawing.Size(95, 18);
            this.textBoxtime.TabIndex = 4;
            // 
            // textBoxfolder
            // 
            this.textBoxfolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxfolder.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxfolder.ForeColor = System.Drawing.Color.Silver;
            this.textBoxfolder.Location = new System.Drawing.Point(141, 94);
            this.textBoxfolder.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxfolder.Multiline = true;
            this.textBoxfolder.Name = "textBoxfolder";
            this.textBoxfolder.Size = new System.Drawing.Size(90, 18);
            this.textBoxfolder.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Notebook.Properties.Resources.main_folder1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(116, 94);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 18);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Notebook.Properties.Resources.write;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(270, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 20);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.BackgroundImage = global::Notebook.Properties.Resources.main_rabbish;
            this.buttondelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttondelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondelete.FlatAppearance.BorderSize = 0;
            this.buttondelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondelete.Location = new System.Drawing.Point(270, 90);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(27, 24);
            this.buttondelete.TabIndex = 5;
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Notebook.Properties.Resources.noteicon_03;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(22, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(22, 5, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // UCList
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxfolder);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.textBoxtime);
            this.Controls.Add(this.textBoxcontent);
            this.Controls.Add(this.textBoxtitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxlist);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCList";
            this.Size = new System.Drawing.Size(320, 125);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox textBoxcontent;
        public System.Windows.Forms.Button buttondelete;
        public System.Windows.Forms.TextBox textBoxtitle;
        public System.Windows.Forms.TextBox textBoxtime;
        public System.Windows.Forms.TextBox textBoxlist;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.TextBox textBoxfolder;

    }
}
