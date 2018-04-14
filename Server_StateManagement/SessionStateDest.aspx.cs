using System;

public partial class SessionStateDest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["Name"] != null && Session["Course"] != null) 
            {
                lblName.Text = Session["Name"].ToString();
                lblCourse.Text = Session["Course"].ToString();
            }
        }
    }
}