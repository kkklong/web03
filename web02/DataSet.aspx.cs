﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web02
{
    public partial class DataSet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["UserConnectionString2"].ConnectionString;

            SqlConnection connection = new SqlConnection(s_data);

            SqlCommand Command = new SqlCommand($"SELECT   id,Name,Passwd,initDate FROM [UserData]", connection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(Command);//從Command取得資料存入dataAdapter

            DataSet dataset = new DataSet();//創一個dataset的記憶體資料集

            dataAdapter.Fill(dataset);//將dataAdapter資料存入dataset

            foreach (DataRow datarow in dataset.Tables["選擇的資料表名稱"].Rows)
            {
                //每個資料列的內容
            }


            //新增一筆資料
            DataRow newRow = dataset.Tables["資料表名稱"].NewRow();
            newRow["id"] = 999;
            newRow["header"] = 111;
            dataset.Tables["資料表名稱"].Rows.Add(newRow);

            //移除一筆資料
            dataset.Tables["資料表名稱"].Rows.Remove(dataset.Tables["資料表名稱"].Rows[1]);

            //修改一筆資料

            DataRow[] rows = dataset.Tables["資料表名稱"].Select("id=1");
            if (rows.Length > 0)
            {
                rows[0]["id"] = 2;
            }



            GridView1.DataSource = dataset; //告訴GridView1的DataSource資料來源是dataset
            GridView1.DataBind(); //資料繫結
            */
        }

    }
}