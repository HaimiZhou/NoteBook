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
    public partial class FormMyCounter : Form
    {
        public FormMyCounter()
        {
            InitializeComponent();
        }
        public FormMain fm = FormCommon.fm;
        private void FormMyCounter_Load(object sender, EventArgs e)
        {
            panelcountertop.BackColor = ColorTranslator.FromHtml("#398dee");
            labelname.Text = fm.toolStripMenuuser.Text;
            string sqldefault = "select * from tbl_person_info where username='" + fm.toolStripMenuuser.Text + "'";
                SqlDataReader personInfo = MyMeans.getcom(sqldefault);
                if (personInfo.Read())
                {
                    string dbphone = personInfo["phone"].ToString();
                    textphone.Text = dbphone;
                }

            string registerSql = "select * from tbl_user where username='" + fm.toolStripMenuuser.Text + "'";
            SqlDataReader registertime = MyMeans.getcom(registerSql);
            if (registertime.Read())
            {
                DateTime time = DateTime.Parse(registertime["logintime"].ToString());
                texttime.Text = "亲爱的" + fm.toolStripMenuuser.Text + "，您在" + time + "注册了灵盘笔记。";
            }
            
        }

        private void pictureBoxclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
       
    }
}
