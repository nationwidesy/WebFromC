using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationCWebForm.App_Code;
using System.Data.SqlClient;
using System.Data;

namespace WebApplicationCWebForm
{
    public partial class DataTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string connectionString = DBconnectionDemo.LocalLconStr();
            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("Select * from Course");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

            //
            cn.Open();
            DataSet dataSet = new DataSet("myDataSetTableName");

            sqlDataAdapter.Fill(dataSet);
            cmd.Dispose();
            sqlDataAdapter.Dispose();
            cn.Close();

            this.GridView2.DataSource = dataSet;
            this.GridView2.DataBind();

            
            this.ShowResult.Text  = dataSet.GetXml();
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ObjectDataSource1_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static void connectionBuildingDemo()
        {
             
            
                 
                string connectionString = DBconnectionDemo.LocalLconStr();



            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("Select * from course where credits = 3");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;
            DataSet dataSet = new DataSet( );
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd );

            
            cn.Open();

            sqlDataAdapter.Fill(dataSet);
            cmd.Dispose();
            sqlDataAdapter.Dispose();
            cn.Close();

            


            
    


                

            
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void GridView2_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }
}