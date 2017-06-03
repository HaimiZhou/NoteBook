namespace Notebook.UserContronl
{
    partial class UCList3
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.textBoxlist = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.彻底删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxtitle = new System.Windows.Forms.TextBox();
            this.textBoxcontent = new System.Windows.Forms.TextBox();
            this.textBoxtime = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxlist
            // 
            this.textBoxlist.BackColor = System.Drawing.Color.White;
            this.textBoxlist.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxlist.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxlist.Location = new System.Drawing.Point(0, 0);
            this.textBoxlist.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxlist.Multiline = true;
            this.textBoxlist.Name = "textBoxlist";
            this.textBoxlist.ReadOnly = true;
            this.textBoxlist.Size = new System.Drawing.Size(320, 125);
            this.textBoxlist.TabIndex = 1;
            this.textBoxlist.DoubleClick += new System.EventHandler(this.textBoxlist_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.彻底删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // 彻底删除ToolStripMenuItem
            // 
            this.彻底删除ToolStripMenuItem.Name = "彻底删除ToolStripMenuItem";
            this.彻底删除ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.彻底删除ToolStripMenuItem.Text = "彻底删除";
            this.彻底删除ToolStripMenuItem.Click += new System.EventHandler(this.彻底删除ToolStripMenuItem_Click);
            // 
            // textBoxtitle
            // 
            this.textBoxtitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxtitle.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxtitle.Location = new System.Drawing.Point(48, 18);
            this.textBoxtitle.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxtitle.Name = "textBoxtitle";
            this.textBoxtitle.Size = new System.Drawing.Size(247, 18);
            this.textBoxtitle.TabIndex = 3;
            // 
            // textBoxcontent
            // 
            this.textBoxcontent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxcontent.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxcontent.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxcontent.Location = new System.Drawing.Point(23, 41);
            this.textBoxcontent.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxcontent.Multiline = true;
            this.textBoxcontent.Name = "textBoxcontent";
            this.textBoxcontent.Size = new System.Drawing.Size(275, 42);
            this.textBoxcontent.TabIndex = 4;
            // 
            // textBoxtime
            // 
            this.textBoxtime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxtime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxtime.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxtime.Location = new System.Drawing.Point(22, 90);
            this.textBoxtime.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxtime.Multiline = true;
            this.textBoxtime.Name = "textBoxtime";
            this.textBoxtime.Size = new System.Drawing.Size(200, 24);
            this.textBoxtime.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Notebook.Properties.Resources.noteicon_03;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(22, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(22, 5, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // UCList3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxtime);
            this.Controls.Add(this.textBoxcontent);
            this.Controls.Add(this.textBoxtitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxlist);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCList3";
            this.Size = new System.Drawing.Size(320, 125);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxlist;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox textBoxtitle;
        public System.Windows.Forms.TextBox textBoxcontent;
        public System.Windows.Forms.TextBox textBoxtime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 彻底删除ToolStripMenuItem;
    }
}
