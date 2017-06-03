using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Notebook.InfoAddForm;

namespace Notebook.UserContronl
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }
       
        int h = 0;
        UCList3 uclist3;
        bool flag = false;
        public FormMain fm = FormCommon.fm;
       
        //一点uclist中的删除让回收站加载控件的方法
        public void AddControl()
        {
            uclist3 = new UCList3();
            uclist3.Location = new Point(0, h);
            uclist3.addInfo();
            //点击用户控件上的删除按钮移除整个用户控件
            uclist3.OnOperatorClick1 += new UCList3.OperatorEventHandler(uc_OnOperatorClick1);

            //对当前新增的用户控件设置位置
            if (flag == true)
            {
                h = h - j*uclist3.Height;
                uclist3.Location = new Point(0, h);
                this.Controls.Add(uclist3);
                h = h + uclist3.Height;
                flag = false;
            }
            else
            {
                this.Controls.Add(uclist3);
                h = h + uclist3.Height;
            }         
            
        }
        int j = 0;
        private void uc_OnOperatorClick1(object sender)
        {
            UCList3 uclist3 = sender as UCList3;
            int oldIndex = fm.uc3.Controls.IndexOf(uclist3);//获取操作项的索引值              
            //移除操作项   
            fm.uc3.Controls.Remove(uclist3);
            RemoveNodes(fm.treeViewFolder.Nodes);
            //对点击了删除按钮的用户控件
            //让该用户控件后面的location都减一个h              
            for (int i = oldIndex; i < fm.uc3.Controls.Count; i++)
            {
                if (fm.uc3.Controls[i] != null)
                {
                    fm.uc3.Controls[i].Location = new Point(0, fm.uc3.Controls[i].Location.Y - uclist3.Height);
                }
            }
            flag = true;
            j++;
        }

        public void RemoveNodes(TreeNodeCollection tnodes)
        {
            foreach (TreeNode node in tnodes)
            {
                if (node.Text.Trim() == this.uclist3.textBoxtitle.Text.Trim())
                {
                    node.Nodes.Remove(node);
                }
                RemoveNodes(node.Nodes);
            }

        }
    }
}
