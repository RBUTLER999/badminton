using System;
using System.IO;
using System.Net;
using System.Web.UI.HtmlControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LoadLatestResults();

        //put the active id on current menu
        string page = string.Empty;
        if (Request.RawUrl.EndsWith(".aspx"))
        {
            page = Request.RawUrl.Substring(1).Replace(".aspx", string.Empty);
        }
        else
        {
            page = "Home";
        }
        page = page.Replace("badminton/", string.Empty);
        page = page.Substring(0, 1).ToUpper() + page.Substring(1);

        HtmlGenericControl activeMenu = null;

        activeMenu = (HtmlGenericControl)FindControl("mnu_" + page);

        if (activeMenu != null)
        {

            if (activeMenu.HasControls()) //remove anchor element
            {
                activeMenu.InnerHtml = @"<a id=""current"">" + page + "</a>";
            }
        }

    }

    private void LoadLatestResults()
    {
        using (WebClient client = new WebClient())
        {
            var originalString = client.DownloadString("https://dl.dropboxusercontent.com/u/29994741/TWBL/Results%20Ticker%20ANGEL%20CENTRE.htm");
            //originalString = originalString.Replace(@"<marquee bgcolor=""#cccccc"" loop=""-1"" scrollamount=""4"" width=""100%"">", string.Empty);
            originalString = originalString.Replace("<font size=5>", string.Empty);
            originalString = originalString.Replace("</font>", string.Empty);
            //originalString = originalString.Replace("</marquee>", string.Empty);
            //originalString = originalString.Replace("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;", "</p><p>");
            //originalString = originalString.Replace(",", "<br>");
            originalString = originalString.Replace("<B>ANGEL CENTRE LATEST RESULTS:</B>", "Latest Results&nbsp");
            
            latestResults.Text = originalString;//.Replace("&nbsp&nbsp&nbsp", "<p>");
        }
    }
}
