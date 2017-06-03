using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Notebook.DateClass;

namespace Notebook.InfoAddForm
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }
       //点击注册
        private void buttonRegister_Click_1(object sender, EventArgs e)
        {
            if (textRusername.Text != null & textRpassword.Text != null & textRpassword.Text==textRcomfirm.Text)
            {
                string time=DateTime.Now.ToString();
                MyMeans.getsqlcom("insert into tbl_user(username,password,logintime) values('"+textRusername.Text.Trim()+"','"+textRpassword.Text.Trim()+"','"+time+"')");
                this.Hide();
                FormLogin formLogin = new FormLogin();
                formLogin.ShowDialog();
            }
            else
            {
                textError.Text="请输入完整注册信息！";
            }
        }
        //点击返回登录
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void button_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        internal static int WM_NCHITTEST = 0x84; //移动鼠标，按住或释放鼠标时发生的系统消息
        internal static int WM_NCACTIVATE = 0x86;//窗体的激活状态发生改变的消息

        internal static IntPtr HTCLIENT = (IntPtr)0x1;//工作区
        internal static IntPtr HTSYSMENU = (IntPtr)3;//系统菜单
        internal static IntPtr HTCAPTION = (IntPtr)0x2; //标题栏

        internal static IntPtr HTLEFT = (IntPtr)10;//向左
        internal static IntPtr HTRIGHT = (IntPtr)11;//向右
        internal static IntPtr HTTOP = (IntPtr)12;//向上
        internal static IntPtr HTTOPLEFT = (IntPtr)13;//向左上
        internal static IntPtr HTTOPRIGHT = (IntPtr)14;//向右上
        internal static IntPtr HTBOTTOM = (IntPtr)15;//向下
        internal static IntPtr HTBOTTOMLEFT = (IntPtr)16;//向左下
        internal static IntPtr HTBOTTOMRIGHT = (IntPtr)17;//向右下

        private int m_BorderWidth = 4;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);
                if (DesignMode)
                {
                    return;
                }
                if (m.Result == HTCLIENT)
                {
                    m.HWnd = this.Handle;

                    System.Drawing.Rectangle rect = this.RectangleToScreen(this.ClientRectangle);
                    Point C_Pos = Cursor.Position;
                    if ((C_Pos.X <= rect.Left + m_BorderWidth) && (C_Pos.Y <= rect.Top + m_BorderWidth))
                        m.Result = HTTOPLEFT;//左上
                    else if ((C_Pos.X >= rect.Left + rect.Width - m_BorderWidth) && (C_Pos.Y <= rect.Top + m_BorderWidth))
                        m.Result = HTTOPRIGHT;//右上
                    else if ((C_Pos.X <= rect.Left + m_BorderWidth) && (C_Pos.Y >= rect.Top + rect.Height - m_BorderWidth))
                        m.Result = HTBOTTOMLEFT;//左下
                    else if ((C_Pos.X >= rect.Left + rect.Width - m_BorderWidth) && (C_Pos.Y >= rect.Top + rect.Height - m_BorderWidth))
                        m.Result = HTBOTTOMRIGHT;//右下
                    else if ((C_Pos.X <= rect.Left + m_BorderWidth - 1))
                        m.Result = HTLEFT;//左
                    else if ((C_Pos.X >= rect.Left + rect.Width - m_BorderWidth))
                        m.Result = HTRIGHT;//右
                    else if ((C_Pos.Y <= rect.Top + m_BorderWidth - 1))
                        m.Result = HTTOP;//上
                    else if ((C_Pos.Y >= rect.Top + rect.Height - m_BorderWidth))
                        m.Result = HTBOTTOM;//下
                    else
                    {
                        m.Result = HTCAPTION;//模拟标题栏,移动或双击可以最大或最小化窗体
                    }
                }
                return;
            }
            base.WndProc(ref m);
        }
    }
}
