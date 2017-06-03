using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Notebook.DateClass;
using System.Data.SqlClient;

namespace Notebook.InfoAddForm
{
    public partial class FormPersonInfo : Form
    {
        public FormPersonInfo()
        {
            InitializeComponent();
        }
        public FormMain fm = FormCommon.fm;

        private void FormPersonInfo_Load(object sender, EventArgs e)
        {   
            InfopanelTop.BackColor = ColorTranslator.FromHtml("#398dee");
            textBoxname.Text = fm.toolStripMenuuser.Text;

            string sqldefault = "select * from tbl_person_info where username='"+textBoxname.Text.Trim()+"'";
            SqlDataReader userdefault = MyMeans.getcom(sqldefault);
            if (userdefault.Read())
            {
                string dbrealname = userdefault["realname"].ToString();
                string dbphone = userdefault["phone"].ToString();
                string dbdeacription = userdefault["deacription"].ToString();
                string dbprovince = userdefault["province"].ToString();
                string dbcounty = userdefault["county"].ToString();
                textrealname.Text = dbrealname;
                textphone.Text = dbphone;
                textdeacription.Text = dbdeacription;
                textprovince.Text = dbprovince;
                textcounty.Text = dbcounty;
            }          
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            string sqltitle = "select count(*) from tbl_person_info where username='" + this.textBoxname.Text + "'";
            MyMeans.My_con = new SqlConnection(MyMeans.M_str_sqlcon);
            SqlCommand cmd = new SqlCommand(sqltitle, MyMeans.My_con);
            MyMeans.My_con.Open();
            int num = Convert.ToInt32(cmd.ExecuteScalar());

            if (num > 0)
            {
                sqltitle = "update  tbl_person_info set realname='" + this.textrealname.Text + "',phone='" + this.textphone.Text + "',deacription='" + this.textdeacription.Text + "',province='" + this.textprovince.Text + "',county='" + this.textcounty.Text + "'";
                MyMeans.getsqlcom(sqltitle);
            }
            else
            {
                string sqlinstert = "insert into tbl_person_info(username,realname,phone,deacription,province,county) values('" + textBoxname.Text + "','" + textrealname.Text + "','" + textphone.Text + "','" + textdeacription.Text + "','" + textprovince.Text + "','" + textcounty.Text + "')";
                MyMeans.getsqlcom(sqlinstert);
            }
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide(); 
        }

      
     
        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.Hide(); 
        }

      
    }
}
