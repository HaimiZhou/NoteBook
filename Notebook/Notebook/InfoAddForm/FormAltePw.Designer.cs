namespace Notebook.InfoAddForm
{
    partial class FormAltePw
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
            this.panelAlterTop = new System.Windows.Forms.Panel();
            this.pictureBoxclose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.buttonfinish = new System.Windows.Forms.Button();
            this.textOldPw = new System.Windows.Forms.TextBox();
            this.textNewPw = new System.Windows.Forms.TextBox();
            this.textConPw = new System.Windows.Forms.TextBox();
            this.panelAlterTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAlterTop
            // 
            this.panelAlterTop.Controls.Add(this.pictureBoxclose);
            this.panelAlterTop.Controls.Add(this.label1);
            this.panelAlterTop.Location = new System.Drawing.Point(0, 0);
            this.panelAlterTop.Name = "panelAlterTop";
            this.panelAlterTop.Size = new System.Drawing.Size(371, 30);
            this.panelAlterTop.TabIndex = 0;
            // 
            // pictureBoxclose
            // 
            this.pictureBoxclose.BackgroundImage = global::Notebook.Properties.Resources.person_info_close;
            this.pictureBoxclose.Location = new System.Drawing.Point(338, 0);
            this.pictureBoxclose.Name = "pictureBoxclose";
            this.pictureBoxclose.Size = new System.Drawing.Size(33, 30);
            this.pictureBoxclose.TabIndex = 2;
            this.pictureBoxclose.TabStop = false;
            this.pictureBoxclose.Click += new System.EventHandler(this.pictureBoxclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "修改密码 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(51, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "旧密码 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(51, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "新密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(51, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "确认密码";
            // 
            // buttoncancel
            // 
            this.buttoncancel.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttoncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttoncancel.Location = new System.Drawing.Point(278, 191);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(50, 25);
            this.buttoncancel.TabIndex = 6;
            this.buttoncancel.Text = "取消";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // buttonfinish
            // 
            this.buttonfinish.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonfinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonfinish.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonfinish.ForeColor = System.Drawing.Color.White;
            this.buttonfinish.Location = new System.Drawing.Point(222, 190);
            this.buttonfinish.Name = "buttonfinish";
            this.buttonfinish.Size = new System.Drawing.Size(50, 27);
            this.buttonfinish.TabIndex = 7;
            this.buttonfinish.Text = "完成";
            this.buttonfinish.UseVisualStyleBackColor = false;
            this.buttonfinish.Click += new System.EventHandler(this.buttonfinish_Click);
            // 
            // textOldPw
            // 
            this.textOldPw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textOldPw.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textOldPw.Location = new System.Drawing.Point(137, 67);
            this.textOldPw.Name = "textOldPw";
            this.textOldPw.Size = new System.Drawing.Size(163, 25);
            this.textOldPw.TabIndex = 8;
            // 
            // textNewPw
            // 
            this.textNewPw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNewPw.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textNewPw.Location = new System.Drawing.Point(137, 103);
            this.textNewPw.Name = "textNewPw";
            this.textNewPw.Size = new System.Drawing.Size(163, 25);
            this.textNewPw.TabIndex = 9;
            // 
            // textConPw
            // 
            this.textConPw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textConPw.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textConPw.Location = new System.Drawing.Point(137, 140);
            this.textConPw.Name = "textConPw";
            this.textConPw.Size = new System.Drawing.Size(163, 25);
            this.textConPw.TabIndex = 10;
            // 
            // FormAltePw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(371, 238);
            this.Controls.Add(this.textConPw);
            this.Controls.Add(this.textNewPw);
            this.Controls.Add(this.textOldPw);
            this.Controls.Add(this.buttonfinish);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelAlterTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAltePw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAltePw";
            this.Load += new System.EventHandler(this.FormAltePw_Load);
            this.panelAlterTop.ResumeLayout(false);
            this.panelAlterTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAlterTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxclose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.Button buttonfinish;
        private System.Windows.Forms.TextBox textOldPw;
        private System.Windows.Forms.TextBox textNewPw;
        private System.Windows.Forms.TextBox textConPw;
    }
}