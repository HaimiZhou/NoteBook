using System.Drawing;
using System.Windows.Forms;
using System;
using Notebook.DateClass;
using System.Data.SqlClient;
using Notebook.InfoAddForm;

namespace Notebook.UserContronl
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        int h = 0;
        bool flag = false;
        UCList uclist;
        public FormMain fm = FormCommon.fm;

        //点击保存后的移除新建笔记的按钮和lebel的方法
        public void removeControl() {           
            this.Controls.Remove(button1);
            this.Controls.Remove(label1);
        }
     
        //点击保存后的增加用户控件的方法
        public void AddControl()
        { 
            uclist = new UCList();
            uclist.Location = new Point(0, h);
            uclist.addInfo();

            //点击用户控件上的删除按钮移除整个用户控件
            uclist.OnOperatorClick += new UCList.OperatorEventHandler(uc_OnOperatorClick);
             
            //对当前新增的用户控件设置位置
            if (flag == true)
            {
                          
                h = h - j*uclist.Height;
                uclist.Location = new Point(0,h);                             
                this.Controls.Add(uclist);               
                h = h + uclist.Height;
                flag = false;             
            }
            else
            {
                this.Controls.Add(uclist);
                h = h + uclist.Height;
            }                     
        }
        int j = 0;
         private void uc_OnOperatorClick(object sender) 
        {   
            UCList uclist = sender as UCList; 
            int oldIndex = fm.uc1.Controls.IndexOf(uclist);//获取操作项的索引值   
             //移除操作项         
            fm.uc1.Controls.Remove(uclist);                  
            //对点击了删除按钮的用户控件
            //让该用户控件后面的location都减一个h  
            
            for (int i = oldIndex; i < fm.uc1.Controls.Count; i++)
                {
                    if (fm.uc1.Controls[i] != null)
                    {
                        fm.uc1.Controls[i].Location = new Point(0, fm.uc1.Controls[i].Location.Y - uclist.Height);
                    }
                }
                flag = true;
                j++;
            }

        //修改所属文件夹
         public void alterinfo() {
             if (fm.uc1.uclist.textBoxtitle.Text.Trim() == fm.textBoxTitle.Text.Trim())
             {
                 fm.uc1.uclist.textBoxcontent.Text = fm.textBoxContent.Text;
                 string sqldefault = "select * from tbl_note where title='" + fm.textBoxTitle.Text.Trim() + "'";
                 SqlDataReader userdefault = MyMeans.getcom(sqldefault);
                 if (userdefault.Read())
                 {
                     string dbfoldername = userdefault["foldername"].ToString();
                     fm.uc1.uclist.textBoxfolder.Text = dbfoldername;
                 }
             }
         }
    }


}
