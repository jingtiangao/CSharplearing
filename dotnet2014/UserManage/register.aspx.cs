using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using UserManager.BLL;
using UserManager.Models;

public partial class register : System.Web.UI.Page
{
    private string strConn = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\userdb.mdf;Integrated Security=True;User Instance=True";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
          

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtPassword.Text != txtPasswordAgain.Text)
        {
            Response.Write("密码输入不一致");
            txtPassword.Focus();
            return;
        }
        User user = new User();
        UserBLL userBLL = new UserBLL();
        user = userBLL.GetUserByName(txtUserName.Text);
        if (user != null)
        {
            Response.Write("该用户已存在，请重新输入用户名");
            return;
        }
        User userNew = new User();
        userNew.UserName = txtUserName.Text;
        userNew.Password = txtPassword.Text;
        userNew.NickName = txtnickname.Text;
        userNew.Email = txtemail.Text;
        userNew.QQ = txtQQ.Text;
        userNew.CellPhone = txtPhone.Text;
        userNew.ErrorTimes = 0;
        int result = userBLL.AddUser(userNew);
                if (result == 1)
                {
                    Response.Write("注册成功");
                }
                else
                {
                    Response.Write("注册失败");

                }
        //using (SqlConnection conn = new SqlConnection(strConn))
        //{
        //    //判断表中是否已存在该用户，如果存在，提示用户“该用户已存在”并返回
        //    // string strSql = "Select 1 From T_User Where UserName='" + this.txtUserName.Text + "'and Password='" + this.txtPassWord.Text + "'";//sql注入：'or'1'='1这样不安全

        //    string strSql = "Insert Into T_User(UserName,Password)Values(@UserName,@Password)";
           
        //    //SqlCommand cmd = new SqlCommand(strSql, conn);//对conn对应的数据库做strSql指定SQL操作
        //    //cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
        //    //cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
        //    //conn.Open();
        //    //int result=cmd.ExecuteNonQuery();//返回受影响的行数
        //    //if (result == 1)
        //    //{
        //    //    Response.Write("注册成功");
        //    //}
        //    //else
        //    //{
        //    //    Response.Write("注册失败");

        //    //}
        //    int result = SQLHelper.ExecuteNonQuery(strSql,
        //        new SqlParameter("@UserName", txtUserName.Text), new SqlParameter("@Password", txtPassword.Text));
            
        //}

    }
    protected void checkbutton_Click(object sender, EventArgs e)
    {
        User user = new User();
        UserBLL userBLL = new UserBLL();
        user = userBLL.GetUserByName(txtUserName.Text);
        if (user != null)
        {
            Response.Write("该用户已存在，请重新输入用户名");
            return;
        }
        else
        {
            Response.Write("该用户可以使用");
        }

    }
}