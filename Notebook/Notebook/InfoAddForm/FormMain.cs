using System;
using System.Drawing;
using System.Windows.Forms;
using Notebook.DateClass;
using Notebook.UserContronl;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Text;
using System.Collections;

namespace Notebook.InfoAddForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain fm = FormCommon.fm;

        public UserControl1 uc1;

        public UserControl3 uc3;

        public UserControlSearch ucs;
        //主窗体加载
        private void FormMain_Load(object sender, EventArgs e)
        {
            panelTop.BackColor = ColorTranslator.FromHtml("#398dee");
            panelNewFile.BackColor = ColorTranslator.FromHtml("#398dee");

            uc1 = new UserControl1();
            uc3 = new UserControl3();
           

            //默认UC1控件显示
            uc1.Show();
            textBoxgroup.Controls.Clear();
            textBoxgroup.Controls.Add(uc1);

            //委托点击按钮新建笔记
            this.uc1.button1.Click += userControl11_button1_Click;
          
            string str = "delete from tbl_note";
            string str1 = "delete from tbl_rabbish";
            MyMeans.getsqlcom(str);
            MyMeans.getsqlcom(str1);

            //显示所有的文件夹
            String SQLstr = "select * from tbl_folder";
            SqlConnection My_con;
            string M_str_sqlcon = "Integrated Security=SSPI;Database=notebook;Server=.";
            My_con = new SqlConnection(M_str_sqlcon);
            My_con.Open();
            SqlCommand cmd = new SqlCommand(SQLstr, My_con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_folder");
            //获取表中有多少条记录，循环显示文件夹
            SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Database=notebook;Server=.");
            conn.Open();
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "select count(*) from tbl_folder";
            comm.Connection = conn;
            int count = (int)comm.ExecuteScalar();
            for (int i = 0; i < count; i++)
            {
                string foldername = ds.Tables["tbl_folder"].Rows[i]["foldername"].ToString();
                newnode = new TreeNode(foldername, 0, 0);
                treeViewFolder.Nodes.Add(newnode);
            }
        }

        private void buttonmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPersonInfo fpi = new FormPersonInfo();
            fpi.Show();
        }

        private void 账户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMyCounter fmc = new FormMyCounter();
            fmc.Show();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltePw fap = new FormAltePw();
            fap.Show();
        }

        private void 注销当前用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTitlePro fe = new FormTitlePro();
            fe.Show();
        }

        private void panelNewFile_click(object sender, EventArgs e)
        {
            panelNewFile.BackColor = ColorTranslator.FromHtml("#398dee");
            panelRabbish.BackColor = ColorTranslator.FromHtml("#f5f5f5");
            panelMyFolder.BackColor = ColorTranslator.FromHtml("#f5f5f5");
            labelnew.ForeColor = ColorTranslator.FromHtml("#fff");
            labelmyfolder.ForeColor = ColorTranslator.FromHtml("#393939");
            labelrabbish.ForeColor = ColorTranslator.FromHtml("#393939");
            uc1.Show();
            textBoxgroup.Controls.Clear();
            textBoxgroup.Controls.Add(uc1);
        }

        private void panelMyFolder_click(object sender, EventArgs e)
        {
            panelMyFolder.BackColor = ColorTranslator.FromHtml("#398dee");
            panelRabbish.BackColor = ColorTranslator.FromHtml("#f5f5f5");
            panelNewFile.BackColor = ColorTranslator.FromHtml("#f5f5f5");
            labelmyfolder.ForeColor = ColorTranslator.FromHtml("#fff");
            labelnew.ForeColor = ColorTranslator.FromHtml("#393939");
            labelrabbish.ForeColor = ColorTranslator.FromHtml("#393939");
        }

        private void panelRabbish_click(object sender, EventArgs e)
        {
            panelRabbish.BackColor = ColorTranslator.FromHtml("#398dee");
            panelMyFolder.BackColor = ColorTranslator.FromHtml("#f5f5f5");
            panelNewFile.BackColor = ColorTranslator.FromHtml("#f5f5f5");
            labelmyfolder.ForeColor = ColorTranslator.FromHtml("#393939");
            labelnew.ForeColor = ColorTranslator.FromHtml("#393939");
            labelrabbish.ForeColor = ColorTranslator.FromHtml("#fff");
            uc3.Show();
            textBoxgroup.Controls.Clear();
            textBoxgroup.Controls.Add(uc3);
        }

        int i = 0;
        private void 新建笔记ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBoxTitle.Text = "无标题笔记";
            }
            if (i > 0)
            {
                textBoxTitle.Text = "无标题笔记(" + i + ")";
            }
            i++;

            textBoxContent.Focus();
            textBoxContent.Text = "";
        }

        private void textBoxTitle_Click_1(object sender, EventArgs e)
        {
            textBoxTitle.Text = "";
        }

        //点击保存
        private void buttonOk_Click(object sender, EventArgs e)
        {       
            FormSave fs = new FormSave();
            fs.Show();
        }

        private void userControl11_button1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBoxTitle.Text = "无标题笔记";
            }
            if (i > 0)
            {
                textBoxTitle.Text = "无标题笔记(" + i + ")";
            }
            i++;
            textBoxContent.Focus();
            textBoxContent.Text = "";
        }

        //设置字体大小
        private void button1_Click(object sender, EventArgs e)
        {
            string fontName;
            float fontSize;
            FontStyle myfontstyle;
            DialogResult fontdialogresult;
            fontdialogresult = fontDialog1.ShowDialog();
            if (fontdialogresult == DialogResult.OK)
            {
                fontName = fontDialog1.Font.Name;
                fontSize = fontDialog1.Font.Size;
                myfontstyle = fontDialog1.Font.Style;
                textBoxContent.Font = new Font(fontName, fontSize, myfontstyle);
            }
        }
        //字体加粗
        private void button2_Click(object sender, EventArgs e)
        {
            textBoxContent.Font = new Font("宋体", 18, FontStyle.Bold);
        }

        //字体颜色
        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxContent.ForeColor = colorDialog1.Color;
            }
        }
        //打开文件
        private void 上传文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "文本文档(*.txt)|*.txt|所有文件|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.Default);
                textBoxContent.Text = sr.ReadToEnd();
                sr.Close();
            }
            string filename = openFileDialog1.FileName;
            textBoxTitle.Text = Path.GetFileName(openFileDialog1.FileName);

        }
        //新建文件夹
        TreeNode newnode;
        private void 新建文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (i == 0)
            {
                newnode = new TreeNode("新建文件夹", 0, 0);

                treeViewFolder.Nodes.Add(newnode);
            }
            if (i > 0)
            {
                newnode = new TreeNode("新建文件夹(" + i + ")", 0, 0);

                treeViewFolder.Nodes.Add(newnode);

            }
            i++;

        }
        //bug:好像必须改名字才能存到数据库，且不能重名
        private void treeViewFolder_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            string time = DateTime.Now.ToString();
            MyMeans.getsqlcom("insert into tbl_folder(foldername,buildtime) values('" + e.Label + "','" + time + "')");
        }

        private void 删除文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqlDelete = "delete from tbl_folder where foldername='" + treeViewFolder.SelectedNode.Text + "'";
            treeViewFolder.SelectedNode.Remove();
            MyMeans.getsqlcom(sqlDelete);
        }

        string folderpath;
        private void 上传文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowNewFolderButton = true;
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderpath = folderBrowserDialog1.SelectedPath;
                string folderName = new System.IO.DirectoryInfo(folderpath).Name;
                if (folderName != "")
                {
                    newnode = new TreeNode(folderName, 0, 0);
                    treeViewFolder.Nodes.Add(newnode);
                    string time = DateTime.Now.ToString();
                    MyMeans.getsqlcom("insert into tbl_folder(foldername,buildtime) values('" + folderName + "','" + time + "')");

                    //获取该文件夹下面的所有文件名
                    System.IO.DirectoryInfo dir = new DirectoryInfo(folderpath);
                    if (dir.Exists)
                    {
                        FileInfo[] fiList = dir.GetFiles();
                        foreach (var item in fiList)
                        {
                            var FileName = item.Name;
                            string content = "";
                            using (StreamReader sr = item.OpenText())
                            {
                              content+= sr.ReadToEnd();                   
                            }
                            string filetime = DateTime.Now.ToString();
                            MyMeans.getsqlcom("insert into tbl_note(title,content,time,foldername) values('" + FileName + "','" + content + "','" + filetime + "','" + folderName + "')");
                           
                            newnode = new TreeNode(FileName, 1, 1);

                            SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Database=notebook;Server=.");
                            conn.Open();
                            SqlCommand comm = new SqlCommand();
                            comm.CommandText = "select count(*) from tbl_folder";
                            comm.Connection = conn;
                            int count = (int)comm.ExecuteScalar();

                            treeViewFolder.Nodes[count - 1].Nodes.Add(newnode);
                        }
                    }

                }

            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics,
                               panel6.ClientRectangle,
                               ColorTranslator.FromHtml("#f1f1f1"),
                               1,
                               ButtonBorderStyle.Solid,
                               ColorTranslator.FromHtml("#f1f1f1"),
                               1,
                               ButtonBorderStyle.Solid,
                               ColorTranslator.FromHtml("#f1f1f1"),
                               1,
                               ButtonBorderStyle.Solid,
                               ColorTranslator.FromHtml("#f1f1f1"),
                               1,
                               ButtonBorderStyle.Solid);
        }

        private void 重命名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeViewFolder.SelectedNode.BeginEdit();
        }

        private void 查看内容ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string title = treeViewFolder.SelectedNode.Text;
            string sqldefault = "select * from tbl_note where title='" + title + "'";
            SqlDataReader userdefault = MyMeans.getcom(sqldefault);
            if (userdefault.Read())
            {
                string content = userdefault["content"].ToString();
                this.textBoxTitle.Text = title;
                this.textBoxContent.Text = content;

            }

        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            ucs = new UserControlSearch();
            ucs.Show();
            textBoxgroup.Controls.Clear();
            textBoxgroup.Controls.Add(ucs);
            ucs.AddControl();
            this.textBoxsearch.Text= "";
        }

        
    }
}
