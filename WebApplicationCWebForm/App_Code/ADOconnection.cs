using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//add following lines
using System.Data;
using System.Data.SqlClient;

namespace WebApplicationCWebForm.App_Code
{
    public class ADOconnection
    {
        public ADOconnection ()
        {

        }

        void OpenDBconnection (out string result)
        {
            try
            {
                result = string.Empty;
                string constr = SQLconnectionString();
                SqlConnection con = new SqlConnection(constr);
                string sqlQuery = "SELECT * FROM address";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);     
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                SqlDataReader dr = cmd.ExecuteReader();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet("table_name_in_DataSet");
                //cmd.ExecuteNonQuery(); don't not any output
                //cmd.ExecuteReader(); return a typed IDataReader
                //cmd.ExecuteScalar(); return a single value
                //cmd.ExecuteXmlReader(); return an XmlReader object
                tx.Commit();
                da.Fill(ds); //DataAdapter fill/public data source data to DataSet table
                ds.Tables["address"].Rows[0]["state"] = "TX"; //update state to TX
                da.Update(ds, "address"); //DataSet changed, DataAdapter.Update method will update data source (DB)
                da.Dispose();
                cmd.Dispose();
                dr.Close();
                con.Close();
            }
            catch (SqlException ex)
            {
               result = "Error occure at " + DateTime.Now + ", Message: " + ex.Message;
            }

            

        }

        void openSQLconnectionWithQuery(out string result, string queryStr)
        {
            try
            {
                result = string.Empty;
                string conStr = SQLconnectionString();
                SqlConnection con = new SqlConnection();
                SqlCommand cmd = new SqlCommand(queryStr, con);
                cmd.Parameters.Add("@Name", SqlDbType.VarChar);
                cmd.Parameters["@Name"].Value = "Sophy";
                con.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            } catch (SqlException ex)
            {
                result = "Error occure at " + DateTime.Now + ", Message: " + ex.Message;
            }
        }

        void openStoreProcedureConnection(out string result, string SPname, string parameter )
        {
            try
            {
                result = string.Empty;
                String conStr = SQLconnectionString();
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(SPname, con);
                cmd.CommandType =  CommandType.StoredProcedure;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar );
                cmd.Parameters["@Name"].Value = "sophy";
                //use AddWithVaue
                //convert string into XML
                cmd.Parameters.AddWithValue("@Name", "sophy");
                con.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            catch (SqlException ex)
            {
                result = "Error occure at " + DateTime.Now + ", Message: " + ex.Message;
            }
 
        }

        string SQLconnectionString()
        {
            string conStr = @"Data Source=SOPHYHP; ";
            conStr += "Initial Catalog=sophyDB1; ";
            conStr += @"User ID=sa; ";
            conStr += "Password=sophy; ";
            return conStr;
        }

    }
}