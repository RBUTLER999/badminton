using System;
using System.EnterpriseServices;
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
        string latest = "latestResults";

        string cachedString = (string)Cache[latest];

        if (string.IsNullOrEmpty(cachedString))
        {
            using (WebClient client = new WebClient())
            {
                cachedString = client.DownloadString("https://www.dropbox.com/s/hlj1urkxivhikdq/Results Ticker ANGEL CENTRE.htm?dl=1");
            }

            Cache.Insert(latest, cachedString, null, DateTime.Now.Date.AddDays(1).AddMinutes(-1), TimeSpan.Zero);
        }

        latestResults.Text = cachedString;
    }
}
