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
    public int Kindid;
    public DAL.TKIN[] kindjes;
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

            DAL.TOUD user;

            if (Ouder.GetCompleteOuder(out user, naam))
            {
                kindjes = Ouder.GetAlleKinderen(user.Ouderid).ToArray();
                //alert("1ste waarde: " +  kindjes.ElementAt(0));
                //Kindid = Convert.ToInt32(kindjes.ElementAt(0));
                //Label1.Text = Convert.ToString(kindjes[2]);

            }
            else
            {
                

            }

           

        }
        else
        {
        }
    }
}