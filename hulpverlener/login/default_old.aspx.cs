using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login_default : System.Web.UI.Page
{
    //Datamodel.DatamodelEntities _dataModel = new Datamodel.DatamodelEntities();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        Login1.Focus();
    }
    protected void LoginButton_Click(object sender, EventArgs e)
    {
        //var result = _dataModel.aspnet_Users.FirstOrDefault(i =>i.UserName.Equals(Login1.UserName) && i.
    }
}