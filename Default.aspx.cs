using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
              

        string id = Request.QueryString["id"];
        if (id != null)
        {
            //Response.Write("id is ");
            Session["id"] = id;
            

            //Label1.Text = id;
        } 
    }
}