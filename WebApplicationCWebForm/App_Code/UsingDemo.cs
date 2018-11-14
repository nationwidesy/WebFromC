using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace WebApplicationCWebForm.App_Code
{
    public class UsingDemo
    {

        public void usingStatementBolckDemo()
        {
            string SQLconnString = "Data Source=SOPHYHP;Initial Catalog=sophyDB1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string LocalConnString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebApplication1Context-480162ab-40d7-4308-8fa6-9b18bbe17dfc;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string connString = "";

            string str = string.Empty;

            using (SqlConnection conn = new SqlConnection(LocalConnString  ))
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Select * fomr Movies";

                conn.Open();

                using(SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                        str = string.Format($"\r\n {dr.GetString(0)} {dr.GetString(1)}" );
                }
            }
            
        }
        public void SecondUsingDemo()
        {
            string str = string.Empty;
            string LocalConnString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebApplication1Context-480162ab-40d7-4308-8fa6-9b18bbe17dfc;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
 
            using(SqlConnection cn = new SqlConnection(LocalConnString ))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("select * from movies"))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader ())
                    {
                        while (reader.Read())
                        {
                            str += string.Format($" {reader.GetInt32(0)}, {reader.GetString(1)} ");
                        }
                    }
                }
            }
        }
    }
}