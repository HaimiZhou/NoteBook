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
    public partial class FormSave : Form
    {
        public FormSave()
        {
            InitializeComponent();
        }
        public FormMain fm = FormCommon.fm;


        //窗体加载时就显示已经新建好的文件夹
        private void FormSave_Load(object sender, EventArgs e)
        {   
            panelSaveTop.BackColor = ColorTranslator.FromHtml("#398dee");
            try
            {
                String SQLstr = "select foldername from tbl_folder";
                SqlConnection My_con;
                string M_str_sqlcon = "Integrated Security=SSPI;Database=notebook;Server=.";
                My_con = new SqlConnection(M_str_sqlcon);
                My_con.Open();
                SqlCommand cmd = new SqlCommand(SQLstr, My_con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dt.TableName = "tbl_folder";
                da.Fill(dt);
                comboBoxfolder.DataSource = dt;
                comboBoxfolder.DisplayMember = "foldername";
                comboBoxfolder.ValueMember = "foldername";

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        //点击close关闭窗体
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //点击确定把该笔记信息存入数据库并在选中文件夹下创建新的节点
        private void button1_Click(object sender, EventArgs e)
        {
            string sqltitle = "select count(*) from tbl_note where title='" + fm.textBoxTitle.Text + "'";
            MyMeans.My_con = new SqlConnection(MyMeans.M_str_sqlcon);
            SqlCommand cmd=new SqlCommand(sqltitle,MyMeans.My_con);
            MyMeans.My_con.Open();
            int num =Convert.ToInt32(cmd.ExecuteScalar());
            string time = DateTime.Now.ToString();
           
            //如果标题为空
            if (fm.textBoxTitle.Text == "")
            {
                fm.textBoxTitle.Text = "请输入标题！";     
                this.Hide();
              //不允许插入重复数据  
            }else if(num>0){
                sqltitle = "update  tbl_note set content='" + fm.textBoxContent.Text + "',foldername='"+comboBoxfolder.SelectedValue.ToString()+"' where title='" + fm.textBoxTitle.Text + "'";
                this.Hide();
                cmd.CommandText = sqltitle;
                cmd.ExecuteNonQuery();
                MyMeans.My_con.Close();
                fm.uc1.alterinfo();
                RemoveNodes(fm.treeViewFolder.Nodes);
                ShowNodes(fm.treeViewFolder.Nodes);
                //FormTitleCopy ftc = new FormTitleCopy();
                //ftc.Show();
            }         
            else
            {   
                 sqltitle="insert into tbl_note(title,content,time,foldername) values('" + fm.textBoxTitle.Text + "','" + fm.textBoxContent.Text + "','" + time + "','" + comboBoxfolder.SelectedValue.ToString() + "')";
                 cmd.CommandText = sqltitle;
                 cmd.ExecuteNonQuery();
                 MyMeans.My_con.Close();
                 ShowNodes(fm.treeViewFolder.Nodes);
                 this.Hide();
                 fm.uc1.removeControl();
                 //增加控件
                 fm.uc1.AddControl();
            }
           
        }

        public void ShowNodes(TreeNodeCollection tnodes)
        {    
            //获取fm的标题内容
            string filename=fm.textBoxTitle.Text;
            //获取被选中的下拉列表项的文本
            string combofolder = comboBoxfolder.SelectedValue.ToString();
            //插入节点
            foreach(TreeNode node in tnodes){
                if (node.Text == combofolder)
                {
                    node.Nodes.Add(filename);
                }
                ShowNodes(node.Nodes);
            }
        }
        public void RemoveNodes(TreeNodeCollection tnodes)
        {
            foreach (TreeNode node in tnodes)
            {
                if (node.Text.Trim()== fm.textBoxTitle.Text.Trim())
                {
                    node.Nodes.Remove(node);
                }
                RemoveNodes(node.Nodes);
            }
 
        }
       
    }
}
