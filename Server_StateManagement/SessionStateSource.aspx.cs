using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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