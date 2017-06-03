using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Notebook.DateClass
{
    class MyMeans
    {
        #region 全局变量
        //public static string Login_ID = "";
        //public static string Login_Name = "";
        public static SqlConnection My_con;
        public static SqlCommand My_com;
        public static SqlCommand SQLcom;
        //sql连接字符串
        public static string M_str_sqlcon = "Integrated Security=SSPI;Database=notebook;Server=.";
        #endregion

        //与数据库连接方法
        public static SqlConnection getcon() {
            My_con = new SqlConnection(M_str_sqlcon);
            My_con.Open();
            return My_con;
        }
        //关闭数据库连接方法
        public static void con_close() {
            if (My_con.State == ConnectionState.Open) {
                My_con.Close();
                My_con.Dispose();
            }
        }
        //读取数据库信息
        public static SqlDataReader getcom(string SQLstr) {
            getcon();
            //创建SqlCommand对象，用于执行SQL语句
            My_com = My_con.CreateCommand();
            //获取指定的sql语句
            My_com.CommandText = SQLstr;
            //执行sql语句，生成一个SqlDataReader对象
            SqlDataReader My_read = My_com.ExecuteReader();
            return My_read;
        }
        //通过SqlCommand对象执行数据库中的添加、修改、删除
        public static void getsqlcom(string SQLstr) {
            getcon();
            SqlCommand SQLcom = new SqlCommand(SQLstr, My_con);
            SQLcom.ExecuteNonQuery();
            SQLcom.Dispose();
            con_close();
        }
    }
}
