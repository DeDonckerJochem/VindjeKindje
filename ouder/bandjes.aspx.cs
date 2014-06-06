using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ouder_bandjes : System.Web.UI.Page
{
    OuderDAL Ouder = new OuderDAL();
    public int id;
    protected void Page_Load(object sender, EventArgs e)
    {
       // string idkind = (string)Session["id"];
        //Label1.Text = idkind;
        if (!IsPostBack)
        {
            string naam = User.Identity.Name;

            //Label1.Text = Convert.ToString(Ouder.getaantalkinderen(naam));
            this.id = Ouder.getaantalkinderen(naam);
            DataBind();
        }
        else
        {
        }
    }
}