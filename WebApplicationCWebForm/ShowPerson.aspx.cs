using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationCWebForm
{
    public partial class ShowPerson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DemonstrateDataView();
        }

        private void DemonstrateDataView()
        {
            //create table
            DataTable mTable = new DataTable("table1");
            //add one column
            DataColumn colItem = new DataColumn("item", Type.GetType("System.String"));
            mTable.Columns.Add(colItem);
            //add five rows
            DataRow newRow;
            for (int i=0; i< 5; i++)
            {
                newRow = mTable.NewRow();
                newRow["item"] = "Item-" + i;
                mTable.Rows.Add(newRow);
            }
            mTable.AcceptChanges();

            //create second table
            DataTable mTable2 = new DataTable("table2");
            //add two column
            DataColumn colItem2 = new DataColumn("description", Type.GetType("System.String"));
            DataColumn colItem1 = new DataColumn("item_name", Type.GetType("System.String"));
            mTable2.Columns.Add(colItem1);
            mTable2.Columns.Add(colItem2);
            //add five rows
            DataRow newRow2;
            for (int i = 0; i < 5; i++)
            {
                newRow2 = mTable2.NewRow();
                newRow2["item_name"] = "item-" + i;
                mTable2.Rows.Add(newRow2);
            }
            
            for (int i = 0; i < 5; i++)
            {
                newRow2 = mTable2.NewRow();
                newRow2["description"] = "description-" + i;
                mTable2.Rows.Add(newRow2);
            }
            mTable2.AcceptChanges();

            //change value
            mTable.Rows[0]["item"] = "cat";
            mTable.Rows[1]["item"] = "dog";
            //create 2 DataView object with the same table
            DataView firstView = new DataView(mTable);
            DataView secondView = new DataView(mTable);
            //print current table values
            this.ShoeResult.Text = PrintTableOrView(mTable, "Current Value in Table");
            //set first DataView to show only modified
            firstView.RowStateFilter = DataViewRowState.ModifiedOriginal;
            //print firstView
            this.ShoeResult.Text += PrintTableOrView(firstView, "First DataView: ModifiedOriginal");
            //add new row to secondView
            DataRowView rowView;
            rowView = secondView.AddNew();
            rowView["item"] = "fish";
            //set second Dataview to show modified version or (|) added
            secondView.RowStateFilter = DataViewRowState.ModifiedCurrent | DataViewRowState.Added;
            //print secondView
            this.ShoeResult.Text += PrintTableOrView(secondView, "Second DataView: ModifiedCurrent | Added");
            DataSet ds = new DataSet("myDsTables");
            ds.Tables.Add(mTable);
            ds.Tables.Add(mTable2);
            this.ShowSecondResult.Text = ds.GetXml();
          }

        private string PrintTableOrView(DataView view, string label)
        {
            string outPut = "\r\n" + label;
            for (int i=0;i< view.Count; i++)
            {
                outPut += "\r\n view - " + view[i]["item"];
            }
            return outPut;
        }
        private string PrintTableOrView(DataTable  table, string label)
        {
            string outPut = "\r\n" + label;
            for (int i = 0; i < table.Rows.Count ; i++)
            {
                outPut += "\r\n  table - " + table.Rows[i]["item"];
            }
            return outPut;
        }
    }
}