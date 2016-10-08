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

public partial class UserManage : System.Web.UI.Page
{
   // private string strConn = ConfigurationManager
    protected UserBLL userBLL = new UserBLL();

    protected void Page_Load(object sender, EventArgs e)
    {
        //using (SqlConnection conn= new SqlConnection(strConn))
        //{
        //    string strSql="Select * From T_User";
        //     SqlCommand cmd = new SqlCommand(strSql, conn);
        //SqlDataAdapter da = new SqlDataAdapter(strConn);
        //    DataSet ds=new DataSet();
        //    da.Fill(ds);




        // DataTable dt=ds.Table[0];
        // gvUsers.DataSource = dt;
        //gvUsers.DataBind();
        //}
        UserBLL userBLL = new UserBLL();
        gvUsers.DataSource = userBLL.GetUser();
        gvUsers.DataBind();
        HttpCookie theCookie;
        if (Request.Cookies["xxWebsite"] != null)
        {
            //读取客户端通过Request对象发送到服务器的Cookie值
            theCookie = Request.Cookies["xxWebsite"];
            int nCount = int.Parse(theCookie.Values["VisitCount"].ToString())+1 ;
            //将修改的值传递到客户端的Cookie中
            Request.Cookies["xxWebsite"].Expires = DateTime.Now.AddMonths(12);
            Request.Cookies["xxWebsite"].Values["VisitCount"] = nCount.ToString();
            Response.Cookies.Add(theCookie);
            txtlb1.Text = "欢迎您第" + nCount.ToString() + "次访问本页面";
        }
        else
        {
            theCookie = new HttpCookie("xxWebsite");
            theCookie.Values["VisitCount"] = "1";
            theCookie.Expires = DateTime.Now.AddMonths(12);
            Response.Cookies.Add(theCookie);
            txtlb1.Text = "欢迎您第1次访问本页面";
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void gvUsers_RowEditing(object sender, GridViewEditEventArgs e)
    {
        this.gvUsers.EditIndex = e.NewEditIndex;
        gvUsers.DataSource = userBLL.GetUser();
        gvUsers.DataBind();


    }
    protected void gvUsers_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        
        int selectId = (int)gvUsers.DataKeys[e.RowIndex].Value;
        int result = userBLL.DeleteUser(selectId);
        if (result == 1)
            Response.Write("删除成功");
        else
            Response.Write("删除失败");

    }
    protected void gvUsers_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvUsers.EditIndex = -1;
        gvUsers.DataSource = userBLL.GetUser();
        gvUsers.DataBind();
       
    }
    protected void gvUsers_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        User user = new User();
        user.Id = (int)gvUsers.DataKeys[e.RowIndex].Value;
        TextBox txtUserName1 = gvUsers.Rows[e.RowIndex].Cells[4].Controls[0] as TextBox;
       // TextBox txtUserName2 = gvUsers.Rows[e.RowIndex].Cells[4].Controls[1] as TextBox;
        //TextBox txtUserName3= gvUsers.Rows[e.RowIndex].Cells[4].Controls[2] as TextBox;
        user.UserName = ((TextBox)gvUsers.Rows[e.RowIndex].Cells[3].Controls[0]).Text.ToString().Trim();
        user.Password = ((TextBox)gvUsers.Rows[e.RowIndex].Cells[4].Controls[0]).Text.ToString().Trim();
        user.NickName = ((TextBox)gvUsers.Rows[e.RowIndex].Cells[5].Controls[0]).Text.ToString().Trim();
        user.Email = ((TextBox)gvUsers.Rows[e.RowIndex].Cells[6].Controls[0]).Text.ToString().Trim();
        user.QQ = ((TextBox)gvUsers.Rows[e.RowIndex].Cells[7].Controls[0]).Text.ToString().Trim();
        user.CellPhone = ((TextBox)gvUsers.Rows[e.RowIndex].Cells[8].Controls[0]).Text.ToString().Trim();
        user.ErrorTimes = int.Parse(((TextBox)gvUsers.Rows[e.RowIndex].Cells[9].Controls[0]).Text.ToString().Trim());
        userBLL.UpdateUser(user);
        gvUsers.EditIndex = -1;
        gvUsers.DataSource = userBLL.GetUser();
        gvUsers.DataBind();
       
    }
    protected void gvUsers_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate)
            {
                LinkButton linkbtn = e.Row.Cells[1].Controls[0] as LinkButton;
                linkbtn.Attributes.Add("onclick","javascript:return confirm('你确定要删除\""+e.Row.Cells[3].Text+"\"吗')");

            }
            e.Row.Attributes.Add("onmouseover","old=this.style.backgroundColor; this.style.backgroundColor='#F5DEB3';");
            e.Row.Attributes.Add("onmouseout","this.style.backgroundColor=old;");

        }

    }
}