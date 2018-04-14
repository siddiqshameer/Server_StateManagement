using System;

public partial class ApplicationStateSource : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Application["Name"] = txtName.Text;
        Application["Age"] = txtAge.Text;
        Response.Redirect("AppplicationStateDest.aspx");
    }
}