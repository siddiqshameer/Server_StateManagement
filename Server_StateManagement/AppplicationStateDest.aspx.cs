using System;

public partial class AppplicationStateDest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lblName.Text = "" + Application["Name"];
            lblAge.Text = "" + Application["Age"];
        }
    }
}