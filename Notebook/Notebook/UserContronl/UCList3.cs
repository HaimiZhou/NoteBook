using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Notebook.InfoAddForm;
using System.Data.SqlClient;
using Notebook.DateClass;

namespace Notebook.UserContronl
{
    public partial class UCList3 : UserControl
    {
        public UCList3()
        {
            InitializeComponent();
        }
        public FormMain fm = FormCommon.fm;
       //一点uclist中的删除就在uclist3中增加带有以下信息的控件
        public void addInfo()
        {
            String SQLstr = "select * from tbl_rabbish order by rtime desc";
            SqlDataReader note = MyMeans.getcom(SQLstr);
            if (note.Read())
            {
                string dbtitle = note["rtitle"].ToString();
                string dbcontent = note["rcontent"].ToString();
                string dbtime = note["rtime"].ToString();
                this.textBoxtitle.Text = dbtitle;
                this.textBoxcontent.Text = dbcontent;
                this.textBoxtime.Text = dbtime;
            }

        }
       
        
        //声明事件委托   
        public delegate void OperatorEventHandler(object sender);
        //定义事件   
        public event OperatorEventHandler OnOperatorClick1;

        //右击彻底删除回收站信息
        private void 彻底删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnOperatorClick1(this);
            string sqlDelete = "delete from tbl_rabbish where rtime='" + this.textBoxtime.Text.Trim() + "'";
            MyMeans.getsqlcom(sqlDelete);
        }

        //双击显示回收站的笔记信息
        private void textBoxlist_DoubleClick(object sender, EventArgs e)
        {
            fm.textBoxTitle.Text = this.textBoxtitle.Text;
            fm.textBoxContent.Text = this.textBoxcontent.Text;
        }
        
      
    }
}
