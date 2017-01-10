using System;
using System.IO;
using System.Web.UI.HtmlControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
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
}
