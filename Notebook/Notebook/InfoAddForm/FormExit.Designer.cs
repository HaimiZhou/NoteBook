namespace Notebook.InfoAddForm
{
    partial class FormTitlePro
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
            this.panelExitTop = new System.Windows.Forms.Panel();
            this.pictureBoxclose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonfinish = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelExitTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelExitTop
            // 
            this.panelExitTop.Controls.Add(this.pictureBoxclose);
            this.panelExitTop.Controls.Add(this.label2);
            this.panelExitTop.Location = new System.Drawing.Point(0, 1);
            this.panelExitTop.Name = "panelExitTop";
            this.panelExitTop.Size = new System.Drawing.Size(400, 30);
            this.panelExitTop.TabIndex = 0;
            // 
            // pictureBoxclose
            // 
            this.pictureBoxclose.BackgroundImage = global::Notebook.Properties.Resources.person_info_close;
            this.pictureBoxclose.Location = new System.Drawing.Point(367, 0);
            this.pictureBoxclose.Name = "pictureBoxclose";
            this.pictureBoxclose.Size = new System.Drawing.Size(33, 30);
            this.pictureBoxclose.TabIndex = 3;
            this.pictureBoxclose.TabStop = false;
            this.pictureBoxclose.Click += new System.EventHandler(this.pictureBoxclose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "灵盘笔记";
            // 
            // buttonfinish
            // 
            this.buttonfinish.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonfinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonfinish.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonfinish.ForeColor = System.Drawing.Color.White;
            this.buttonfinish.Location = new System.Drawing.Point(262, 84);
            this.buttonfinish.Name = "buttonfinish";
            this.buttonfinish.Size = new System.Drawing.Size(50, 27);
            this.buttonfinish.TabIndex = 8;
            this.buttonfinish.Text = "确定";
            this.buttonfinish.UseVisualStyleBackColor = false;
            this.buttonfinish.Click += new System.EventHandler(this.buttonfinish_Click);
            // 
            // buttoncancel
            // 
            this.buttoncancel.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttoncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttoncancel.Location = new System.Drawing.Point(328, 84);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(50, 25);
            this.buttoncancel.TabIndex = 9;
            this.buttoncancel.Text = "取消";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "您确定要注销当前用户吗？";
            // 
            // FormExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(400, 136);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.buttonfinish);
            this.Controls.Add(this.panelExitTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormExit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormExit";
            this.Load += new System.EventHandler(this.FormExit_Load);
            this.panelExitTop.ResumeLayout(false);
            this.panelExitTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelExitTop;
        private System.Windows.Forms.Button buttonfinish;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxclose;
    }
}