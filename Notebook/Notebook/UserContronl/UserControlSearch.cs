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
    public partial class UserControlSearch : UserControl
    {
        public UserControlSearch()
        {
            InitializeComponent();
        }

        UCList uclist;
        int h;
        public FormMain fm = FormCommon.fm;
        public void AddControl()
        {
            SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Database=notebook;Server=.");
            conn.Open();
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "select count(*) from tbl_note where title like '%" + fm.textBoxsearch.Text.Trim() + "%'";
            comm.Connection = conn;
            int count = (int)comm.ExecuteScalar();
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    uclist = new UCList();
                    uclist.Location = new Point(0, h);
                    uclist.addInfosearch(i);
                    this.Controls.Add(uclist);
                    h = h + uclist.Height;
                }
            }
        }
    }
}
