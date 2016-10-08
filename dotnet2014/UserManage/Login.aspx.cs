using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using  UserManager.BLL;
using UserManager.Models;

public partial class Login : System.Web.UI.Page
{
    private string strConn = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\userdb.mdf;Integrated Security=True;User Instance=True";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //Connection
        //1.定义连接字符串
        //string strConn = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\userdb.mdf;Integrated Security=True;User Instance=True";//让字符串保持原意，不要转义 windos身份验证，不用写密码

        //2.创建连接对象
        //using (SqlConnection conn = new SqlConnection(strConn))
        //{

        //  // string strSql = "Select 1 From T_User Where UserName='" + this.txtUserName.Text + "'and Password='" + this.txtPassWord.Text + "'";//sql注入：'or'1'='1这样不安全
        //    string strSql = "Select Password From T_User Where UserName=@UserName";
            
        //    SqlCommand cmd = new SqlCommand(strSql, conn);//对conn对应的数据库做strSql指定SQL操作
        //    cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
        //    conn.Open();
        //    SqlDataReader reader = cmd.ExecuteReader();//
        //                    if (reader.HasRows)
        //                    {
        //                        reader.Read();
        //                        string dbPassword=reader["Password"]as string;
        //                                    if (dbPassword == txtPassWord.Text)
        //                                        Response.Write("登录成功");
        //                                    else
        //                                        Response.Write("密码错误");
        //                    }
        //                    else
        //                    {
        //                        Response.Write("用户名不存在");
        //                    }
        //}

        //3.打开连接

        //对数据库的操作 增删改查

        //4.关闭连接
        UserBLL userBLL = new UserBLL();
        User user = new User();
        user = userBLL.GetUserByName(txtUserName.Text);
        if (user == null)
        {
            Response.Write("不存在该用户");
            return;
        }
        if (user.Password == txtPassWord.Text)
        {
            Response.Write("登陆成功");
        }
        else
        {
            Response.Write("密码错误");
        }

    }
    protected void btnreader_Click(object sender, EventArgs e)
    {

        //Connection
        //1.定义连接字符串
       // string strConn = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\userdb.mdf;Integrated Security=True;User Instance=True";//让字符串保持原意，不要转义 windos身份验证，不用写密码

        //2.创建连接对象
        using (SqlConnection conn = new SqlConnection(strConn))
        {

            string strSql = "Select * From T_User";
            SqlCommand cmd = new SqlCommand(strSql, conn);//对conn对应的数据库做strSql指定SQL操作
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();//

            if (reader.HasRows)
            {
                while (reader.Read())//如果读到下一行就返回true，reader本身就保存了我们读到的数据
                {
                    Response.Write(reader["UserName"] + " " + reader["Password"] + "</br> ");

                }
            }
            else
            {
                Response.Write("表中无记录");
            }
        }
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}