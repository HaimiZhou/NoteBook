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
    public partial class FormTitlePro : Form
    {
        public FormTitlePro()
        {
            InitializeComponent();
        }
        public FormMain fm = FormCommon.fm;

        private void FormExit_Load(object sender, EventArgs e)
        {
            panelExitTop.BackColor = ColorTranslator.FromHtml("#398dee");
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBoxclose_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
        
        
        private void buttonfinish_Click(object sender, EventArgs e)
        {
            string sqlDelete = "delete from tbl_user where username='" + fm.toolStripMenuuser.Text.Trim() + "'";
            MyMeans.getsqlcom(sqlDelete);
            Application.Exit();
        }
    }
}
