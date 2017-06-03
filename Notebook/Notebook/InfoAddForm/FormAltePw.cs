using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Notebook.DateClass;

namespace Notebook.InfoAddForm
{
    public partial class FormAltePw : Form
    {
        public FormAltePw()
        {
            InitializeComponent();
        }
        public FormMain fm = FormCommon.fm;

        private void FormAltePw_Load(object sender, EventArgs e)
        {
            panelAlterTop.BackColor = ColorTranslator.FromHtml("#398dee");
        }

        private void pictureBoxclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       //bug:修改好密码后应该回到登录窗口
        private void buttonfinish_Click(object sender, EventArgs e)
        {
                string sqlAlter = "update tbl_user set password='" + textNewPw.Text.Trim()+"' where username='"+fm.toolStripMenuuser.Text.Trim()+"'";
                MyMeans.getsqlcom(sqlAlter);               
                this.Close();                
        }     
    }
}
