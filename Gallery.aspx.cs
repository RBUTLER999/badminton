using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.OleDb;
using System.Collections.Generic;


    public partial class Gallery : System.Web.UI.Page
    {
        
    //static DataTable dtGrid;
    //static Dictionary<string, string> htTeams;

    //protected void Page_Load(object sender, EventArgs e)
    //{
    //    if (!IsPostBack)
    //    {
    //        Import_To_Grid();
    //    }

    //    GridView1.DataSource = dtGrid;
    //    GridView1.DataBind();

    //}

    //private void Import_To_Grid()
    //{

    //    string conStr = ConnectionString;

    //    OleDbConnection connExcel = new OleDbConnection(conStr);

    //    OleDbCommand cmdExcel = new OleDbCommand();

    //    OleDbDataAdapter oda = new OleDbDataAdapter();

    //    cmdExcel.Connection = connExcel;

    //    connExcel.Open();

    //    cmdExcel.CommandText = "SELECT * From [FixList]";

    //    oda.SelectCommand = cmdExcel;

    //    dtGrid = new DataTable();
    //    oda.Fill(dtGrid);

    //    cmdExcel.CommandText = "SELECT * From [TeamNames]";

    //    DataTable dtTeams = new DataTable();

    //    oda.Fill(dtTeams);

    //    htTeams = new Dictionary<string, string>();

    //    foreach (DataRow drTeam in dtTeams.Rows)
    //    {
    //        htTeams.Add(drTeam[0].ToString(), drTeam[0].ToString());
    //    }

    //    connExcel.Close();

    //    //Bind Data to GridView & team combo


    //    GridView1.Caption = "FixtureList";

    //    cboTeams.DataSource = dtTeams;
    //    cboTeams.DataTextField = "Teams";
    //    cboTeams.DataValueField = "Teams";
    //    cboTeams.DataBind();

    //}

    //string ConnectionString
    //{
    //    get
    //    {
    //        return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("App_Data") + "\\fixtureList.xls;Extended Properties=Excel 8.0;";
    //    }
    //}

    //protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    //{
    //    if (e.Row.RowType == DataControlRowType.DataRow)
    //    {
    //        for (int i = 0; i <= 2; i++)
    //        {
    //            if (e.Row.Cells[i + 1].Text.ToUpper() == cboTeams.Text)
    //            {
    //                e.Row.Cells[i + 1].Style["background-color"] = "#66bbcc";
    //            }
    //        }
    //    }
    //}

}
