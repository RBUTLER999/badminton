using System;
using System.Collections;
using System.Configuration;
using System.Data;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;


public partial class UploadFixtureList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     
    }
    protected void Button_click(object sender, EventArgs e)
    {
        try
        {
            string hashedPassword =
                  FormsAuthentication.HashPasswordForStoringInConfigFile(password.Text, "MD5");

            if (!(hashedPassword == ConfigurationManager.AppSettings["pwd"]))
            {
                lblInfo.Text = "Password does not match";
            }
            else
            {
                if (FileUpload1.HasFile)
                {
                    if (!FileUpload1.FileName.Equals("fixtureList.xls", StringComparison.CurrentCultureIgnoreCase))
                    {
                        lblInfo.Text = "Can only upload 'fixtureList.xls'";
                    }
                    else
                    {
                        FileUpload1.SaveAs(Server.MapPath("App_Data") +
                        "\\" + FileUpload1.FileName);

                        lblInfo.Text = "Successfully uploaded file";
                    }
                }
                else
                {
                    lblInfo.Text = "Please choose file";
                }
            }
        }
        catch (Exception ex)
        {
            // Handle your exception here
            
        }

    }

}
