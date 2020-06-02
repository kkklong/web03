using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web02
{
    public partial class ViewSQL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            veiw();
        }
        private void veiw()
        {//副程式名稱為:veiw()
            string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["UserConnectionString2"].ConnectionString;//從config找到資料庫位置[]內放的是Web.config的connectionStrings的name。

            SqlConnection connection = new SqlConnection(s_data);//建立與資料庫建立起連接的通道
            SqlCommand command = new SqlCommand(@"SELECT   id,Name,Passwd,initDate FROM [UserData]", connection);//要對SQL Server下什麼SQL指令。
            connection.Open();
            SqlDataReader goDataReader = command.ExecuteReader();//new一個DataReader接取ExecuteReader所執行SQL語法回傳的資料。
            GridView1.DataSource = goDataReader;//告訴GridView1的資料來源是從goDataReader
            GridView1.DataBind();//將資料來源與GridView1做繫結    
            connection.Close();
        }
    }
}