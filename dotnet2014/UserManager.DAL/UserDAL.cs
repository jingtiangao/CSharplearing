using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DbUlity;
using UserManager.Models;
using System.Data;

namespace UserManager.DAL
{
   public class UserDAL
    {
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns>返回受影响的行数</returns>
        public int AddUser(User user)
        {
            string strSql = "Insert Into T_User(UserName,Password,NickName,Email,QQ,CellPhone,ErrorTimes)Values(@UserName,@Password,@NickName,@Email,@QQ,@CellPhone,@ErrorTimes)";
            return SQLHelper.ExecuteNonQuery(strSql,
                new SqlParameter("@UserName", user.UserName),
                new SqlParameter("@Password", user.Password),
                new SqlParameter("@NickName", user.NickName),
                new SqlParameter("@Email", user.Email), 
                new SqlParameter("@QQ", user.QQ),
                new SqlParameter("@CellPhone", user.CellPhone),
                new SqlParameter("@ErrorTimes", user.ErrorTimes));
        }
        /// <summary>
        /// 删除编号为Id的记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns>返回受影响的行数</returns>
        public int DeleteUser(int id)
        {
            string strSql = "Delete T_User Where Id=@Id";

            return SQLHelper.ExecuteNonQuery(strSql,new SqlParameter("@Id",id));
        }
        /// <summary>
        /// 更新编号为User.id的记录
        /// </summary>
        /// <param name="user"></param>
        /// <returns>返回受影响的行数</returns>
        public int UpdateUser(User user)
        {
            string strSql = "Update T_User Set UserName=@UserName,Password=@Password,Nickname=@Nickname,Email=@Email,QQ=@QQ,CellPhone=@CellPhone,ErrorTimes=@ErrorTimes Where Id=@Id";
 
            return SQLHelper.ExecuteNonQuery(strSql,
                new SqlParameter("@Id",user.Id),
                new SqlParameter("@UserName",user.UserName),
                new SqlParameter("@Password",user.Password),
                new SqlParameter("@Nickname",user.NickName),
                new SqlParameter("@Email",user.Email),
                new SqlParameter("@QQ",user.QQ),
                new SqlParameter("@CellPhone",user.CellPhone),
                new SqlParameter("@ErrorTimes",user.ErrorTimes));

        }
        /// <summary>
        /// 查询所有用户记录
        /// </summary>
        /// <returns>返回所有用户的List</returns>
        public IList<User> GetUsers()
        {
            string strSql = "Select * From T_User";
            List<User> list=new List<User>();
            DataTable dt = SQLHelper.ExecuteDataTable(strSql);
            foreach (DataRow row in dt.Rows)
            {
                User user = new User();
                user.Id = (int)row["Id"];
                user.UserName = row["UserName"].ToString();
                user.Password = row["Password"].ToString();
                user.NickName = row["NickName"].ToString();
                user.Email = row["Email"].ToString();
                user.QQ = row["QQ"].ToString();
                user.CellPhone = row["CellPhone"].ToString();
                user.ErrorTimes = (int)row["ErrorTimes"];
                list.Add(user);



            }



            return list;
        }
        /// <summary>
        /// 查找表中编号为ID的记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns>返回表中编号为ID的对象</returns>
        public User GetUserById(int id)
        {
            string strSql = "Select * From T_User Where Id=@Id";
            DataTable dt = SQLHelper.ExecuteDataTable(strSql);
            User user = new User();
            if (dt.Rows.Count < 1)//表中无编号为ID的记录
            {
                return null;
            }
            DataRow row = dt.Rows[0];
            user.Id = (int)row["Id"];
            user.UserName = row["UserName"].ToString();
            user.Password = row["NickName"].ToString();
            user.Email = row["Email"].ToString();
            user.QQ = row["QQ"].ToString();
            user.CellPhone = row["CellPhone"].ToString();
            user.ErrorTimes = (int)row["ErrorTimes"];
            return user;


        }
        /// <summary>
        /// 查找表中用户名为username的记录，这里要求用户名唯一
        /// </summary>
        /// <param name="username"></param>
        /// <returns>返回表中用户名为username的对象</returns>
        public User GetUserByUserName(string username)
        {
            string strSql = "Select * From T_User Where UserName=@UserName";
            DataTable dt = SQLHelper.ExecuteDataTable(strSql, new SqlParameter("@UserName", username));
            User user = new User();
            if (dt.Rows.Count < 1)//表中没有用户名为username的记录
            {
                return null;
            }
            DataRow row = dt.Rows[0];
            user.Id = (int)row["Id"];
            user.UserName = row["UserName"].ToString();
            user.Password = row["Password"].ToString();
            user.Email = row["Email"].ToString();
            user.QQ = row["QQ"].ToString();
            user.CellPhone = row["CellPhone"].ToString();
            user.ErrorTimes = (int)row["ErrorTimes"];
            return user;
        }
    }
}
