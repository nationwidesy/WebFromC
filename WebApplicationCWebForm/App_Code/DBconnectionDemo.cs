using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//add following lines
using System.Data;
using System.Data.SqlClient;

namespace WebApplicationCWebForm.App_Code
{
    public class DBconnectionDemo
    {
        static string _str;

        public DBconnectionDemo()
        {
        }

        public static string messageDBconnectionDemo ()
        {
            return _str;
        }
        static string SQLconStr()
        {
            string conStr = @"Data Source=SOPHYHP; ";
                conStr += "Initial Catalog=sophyDB1; ";
                conStr += @"User ID=sa; ";
                conStr += "Password=sophy; ";
            return conStr;
        }
        public static string LocalLconStr()
        {
            string conStr = @"Data Source=(localdb)\ProjectsV13; ";
                conStr += "Initial Catalog=sophyTest1_1; ";
                conStr += @"User ID=; ";
                conStr += "Password=; ";
            return conStr;
        }
        static string MSSQLLocalLconStr()
        {
            string conStr = @"Data Source=(localdb)\MSSQLLocalDB; ";
            conStr += "Initial Catalog=WebApplication1Context-480162ab-40d7-4308-8fa6-9b18bbe17dfc; ";
            conStr += @"User ID=; ";
            conStr += "Password=; ";
            return conStr;
        }

        public static void connectionBuildingDemo()
        {
            try
            {
                string connectionString = LocalLconStr();
                _str += "connectting to " + connectionString;

                SqlConnection cn = new SqlConnection(connectionString);
                cn.Open();

                cn.Close();

            }
            catch (Exception ex)
            {
                _str += ex.Message;
            }
           
        }



        /*
         * Data Source=SOPHYHP;
         * Integrated Security=True;
         * Connect Timeout=30;
         * Encrypt=False;
         * TrustServerCertificate=False;
         * ApplicationIntent=ReadWrite;
         * MultiSubnetFailover=False
         * 
         * C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA
         * 
         * Data Source=SOPHYHP;
         * Initial Catalog=sophyDB1;
         * Integrated Security=True;
         * Connect Timeout=30;
         * Encrypt=False;
         * TrustServerCertificate=False;
         * ApplicationIntent=ReadWrite;
         * MultiSubnetFailover=False
         * 
         * Data Source=(localdb)\MSSQLLocalDB;
         * Initial Catalog=master;
         * Integrated Security=True;
         * Connect Timeout=30;
         * Encrypt=False;
         * TrustServerCertificate=False;
         * ApplicationIntent=ReadWrite;
         * MultiSubnetFailover=False
         * 
         * C:\Users\Sophy_2\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB
         * 
         * Data Source=(localdb)\MSSQLLocalDB;
         * Initial Catalog=WebApplication1Context-480162ab-40d7-4308-8fa6-9b18bbe17dfc;
         * Integrated Security=True;
         * Connect Timeout=30;
         * Encrypt=False;
         * TrustServerCertificate=False;
         * ApplicationIntent=ReadWrite;
         * MultiSubnetFailover=False
         * 
         * 
         * 
         * 
         * Data Source=(localdb)\ProjectsV13;
         * Initial Catalog=sophyTest1_1;
         * Integrated Security=True;
         * Connect Timeout=30;
         * Encrypt=False;
         * TrustServerCertificate=False;
         * ApplicationIntent=ReadWrite;
         * MultiSubnetFailover=False
         * * 
         */
    }
}