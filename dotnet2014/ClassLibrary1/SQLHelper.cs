using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DbUlity
{
    public  abstract class SQLHelper
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["userdbConnStr"].ToString();
        /// <summary>
        ///     执行不带参数的Insert delete update
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></return>
        public static int ExecuteNonQuery(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd =conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    return cmd.ExecuteNonQuery();
                    
                }
            }
        }
        /// <summary>
        ///     执行带参数的Insert delete update
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql,params SqlParameter[] paras)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(paras);
                    return cmd.ExecuteNonQuery();

                }
            }
        }


        public static DataTable ExecuteDataTable(string sql, params SqlParameter[] paras)
        {
            using (SqlConnection conn=new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd=conn.CreateCommand())
                {

                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(paras);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                     adapter.Fill(dt); 
                    
                    
                    return dt;
                    
                }
                
                
                
            }
        }
    }

}
