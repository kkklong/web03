using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web02
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //資料庫連結字串
            string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["UserConnectionString2"].ConnectionString;
            SqlConnection conn = new SqlConnection(s_data);
            conn.Open(); //開啟資料庫

            //SQL指令:利用玩家輸入的帳號去資料庫搜尋會員密碼,以進行比對

            SqlCommand cmd = new SqlCommand("Select Name from [UserData] where Name='"+account.Text+"'And passwd='"+ passwd.Text + "'", conn);
            //cmd.Parameters.Add("@ParamID", SqlDbType.NVarChar).Value = account.Text;
            //cmd.Parameters.Add("@PD", SqlDbType.NVarChar).Value = passwd.Text;
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows) //如果有抓到資料
            {
                if (dr.Read())
                {
                   // if (dr["Name"].Equals(account.Text))
                        Label3.Text = "比對正確，登入成功";
                   // else
                        //Label1.Text = "比對錯誤";
                }

            }
            else
                Label3.Text = "資料錯誤";

            dr.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }
}