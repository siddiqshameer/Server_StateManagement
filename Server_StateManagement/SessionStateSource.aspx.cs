using System;

public partial class SessionStateSource : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Session["Name"] = txtName.Text.Trim();
        Session.Add("Course", txtCourse.Text.Trim());
        Response.Redirect("SessionStateDest.aspx");
    }
}