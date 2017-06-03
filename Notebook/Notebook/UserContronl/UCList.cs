using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Notebook.DateClass;
using Notebook.InfoAddForm;

namespace Notebook.UserContronl
{
    public partial class UCList : UserControl
    {
        
        public UCList()
        {          
            InitializeComponent();       
        }
        public FormMain fm = FormCommon.fm;

        //一点保存所要增加的用户控件显示的信息
        public void addInfo() {
            String SQLstr = "select * from tbl_note where title='" + fm.textBoxTitle.Text.Trim()+"'";
            SqlDataReader note = MyMeans.getcom(SQLstr);
            if (note.Read())
            {
                string dbtitle = note["title"].ToString();
                string dbcontent = note["content"].ToString();
                string dbtime = note["time"].ToString();
                string dbfolder = note["foldername"].ToString();
                this.textBoxtitle.Text =dbtitle;
                this.textBoxcontent.Text = dbcontent;
                this.textBoxtime.Text = dbtime;
                this.textBoxfolder.Text = dbfolder;

            }
            
        }
        //搜索出的信息
        public void addInfosearch(int i)
        {
            string stext=fm.textBoxsearch.Text;
            String SQLstr = "select * from tbl_note where title like '%" + fm.textBoxsearch.Text.Trim() + "%'";
            SqlConnection My_con;
            string M_str_sqlcon = "Integrated Security=SSPI;Database=notebook;Server=.";
            My_con = new SqlConnection(M_str_sqlcon);
            My_con.Open();
            SqlCommand cmd = new SqlCommand(SQLstr, My_con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_note");

            this.textBoxtitle.Text = ds.Tables["tbl_note"].Rows[i]["title"].ToString();
            this.textBoxcontent.Text = ds.Tables["tbl_note"].Rows[i]["content"].ToString();
            this.textBoxtime.Text = ds.Tables["tbl_note"].Rows[i]["time"].ToString();
            this.textBoxfolder.Text = ds.Tables["tbl_note"].Rows[i]["foldername"].ToString();
        }
      
       //声明事件委托   
       public delegate void OperatorEventHandler(object sender);
       //定义事件   
       public event OperatorEventHandler OnOperatorClick; 

       
       public void buttondelete_Click_1(object sender, EventArgs e)
       {              
               // 从note表中移除笔记
               string sqlDelete = "delete from tbl_note where time='" + this.textBoxtime.Text.Trim() + "'";
               MyMeans.getsqlcom(sqlDelete);

               OnOperatorClick(this);

               //将该数据插入到让rabbish表中
               MyMeans.getsqlcom("insert into tbl_rabbish(rtitle,rcontent,rtime) values('" + this.textBoxtitle.Text + "','" + this.textBoxcontent.Text + "','" + this.textBoxtime.Text + "')");
               //一点删除让回收站加载删除的控件
               fm.uc3.AddControl(); 
       }


      //一点用户控件打开笔记显示在右边
      private void textBoxlist_DoubleClick(object sender, EventArgs e)
      {
           fm.textBoxTitle.Text= this.textBoxtitle.Text;
           fm.textBoxContent.Text  = this.textBoxcontent.Text;
       }
      //修改笔记
      private void pictureBox2_Click(object sender, EventArgs e)
      {
          fm.textBoxTitle.Text = this.textBoxtitle.Text;
          fm.textBoxContent.Text = this.textBoxcontent.Text;
      }

    

    }
}
