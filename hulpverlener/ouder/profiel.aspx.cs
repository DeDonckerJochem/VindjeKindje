using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Security;
using System.Data.Linq;



public partial class ouder_profiel : System.Web.UI.Page
{
    OuderDAL Ouder = new OuderDAL();
   // DAL.VindjekindjeDataContext dc = new DAL.VindjekindjeDataContext();
    //deze variabele helpt me te onthouden over welke ouder het gaat
    int ouderId = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //deze variabele helpt me te onthouden over welke ouder het gaat
            int ouderId = 0;
            //Initial setup when page loads
            string naam = User.Identity.Name;
           
            DAL.TOUD user;

            if (Ouder.GetCompleteOuder(out user, naam))
            {

                /*vullen van de velden met de gegevens voor de ingelogde gebruiker*/
                NaamTxt.Text = user.Naam;
                ouderId = user.Ouderid;
                VoornaamTxt.Text = user.Voornaam;
                TelTxt.Text = user.TelefoonNr;
                MutTxt.Text = user.MutualiteitsNr.ToString();

                DateTime datum = user.GebDate.Value;
                string formatted = datum.ToString("dd/M/yyyy");

                GebDatTxt.Text = formatted;

                BloedgroepTxt.Text = (Ouder.getbloedgroep(Convert.ToInt32(user.Bloedgroep)));
                AdresTxt.Text = user.Adres;

                /*het onediteerbaar maken van de velden voor deze gebruiker*/
                NaamTxt.ReadOnly = true;
                NaamTxt.BackColor = System.Drawing.SystemColors.GrayText;
                VoornaamTxt.ReadOnly = true;
                VoornaamTxt.BackColor = System.Drawing.SystemColors.GrayText;
                TelTxt.ReadOnly = true;
                TelTxt.BackColor = System.Drawing.SystemColors.GrayText;
                MutTxt.ReadOnly = true;
                MutTxt.BackColor = System.Drawing.SystemColors.GrayText;
                GebDatTxt.ReadOnly = true;
                GebDatTxt.BackColor = System.Drawing.SystemColors.GrayText;
                BloedgroepTxt.ReadOnly = true;
                BloedgroepTxt.BackColor = System.Drawing.SystemColors.GrayText;
                GebDatTxt.ReadOnly = true;
                GebDatTxt.BackColor = System.Drawing.SystemColors.GrayText;
                AdresTxt.ReadOnly = true;
                AdresTxt.BackColor = System.Drawing.SystemColors.GrayText;

            }
            else
            {
                NaamTxt.Text = null;

            }

        }
       
        
    }


    //public event EditBtn Click
    protected void EditBtn_Click(object sender, ImageClickEventArgs e)
    {
        NaamTxt.ReadOnly = false;
        NaamTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
       //VoornaamTxt.ReadOnly = false;
        //VoornaamTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
        
        TelTxt.ReadOnly = false;
        TelTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
        MutTxt.ReadOnly = false;
        MutTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
        GebDatTxt.ReadOnly = false;
        GebDatTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
        BloedgroepTxt.ReadOnly = false;
        BloedgroepTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
        GebDatTxt.ReadOnly = false;
        GebDatTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
        AdresTxt.ReadOnly = false;
        AdresTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
        
    }
    protected void SaveBtn_Click(object sender, ImageClickEventArgs e)
    {

            string naam = User.Identity.Name;
           
            DAL.TOUD user;
            DAL.TOUD usertoupdate = new DAL.TOUD();

            if (Ouder.GetCompleteOuder(out user, naam))
            {
                usertoupdate.Naam = NaamTxt.Text;
                usertoupdate.Voornaam = VoornaamTxt.Text;
                usertoupdate.TelefoonNr = TelTxt.Text;
                usertoupdate.MutualiteitsNr = int.Parse(MutTxt.Text);
                usertoupdate.GebDate = DateTime.Parse(GebDatTxt.Text);
                usertoupdate.Bloedgroep = user.Bloedgroep;
                Ouder.updatebloedgroep(Convert.ToInt32(user.Bloedgroep), Convert.ToString(BloedgroepTxt.Text));
                usertoupdate.Adres = AdresTxt.Text;

                Ouder.updateOuder(user.Ouderid, usertoupdate);

                Response.AppendHeader("Refresh", "0;URL=profiel.aspx");
            }
           

    }

}