using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace CSharpASP_MVC.Repositories
{
    public class ProductRepository
    {
        public DataSet getProducts()
        {
            //server อยู่ไหน
            string connectionString = WebConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

            //ติดต่อ sql
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            
            //สร้าง Object ไว้เก็บกลุ่มข้อมูล
            DataSet dataSet = new DataSet();
            
            //ดึงข้อมมูลจาก
            string command = "SELECT * FROM [products]";

            //สร้าง sqlCommand เรียกข้อมูลออกมา
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

            //สร้าง Adapter ไว้แปลงข้อมูลให้เข้ากัน
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            //นำข้อมูลไปไว้ใน dataSet
            sqlDataAdapter.Fill(dataSet);

            //ส่งข้อมูลกลับ
            return dataSet;
        }
    }
}