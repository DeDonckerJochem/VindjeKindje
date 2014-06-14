﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Security;
using System.Data.Linq;
using System.Configuration;
using System.IO;



public partial class ouder_profiel : System.Web.UI.Page
{
    OuderDAL Ouder = new OuderDAL();
   // DAL.VindjekindjeDataContext dc = new DAL.VindjekindjeDataContext();
    //deze variabele helpt me te onthouden over welke ouder het gaat

    public int ProfielFotoId;
    //public int HulpId;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            
            //deze variabele helpt me te onthouden over welke ouder het gaat
          
            //Initial setup when page loads
            string naam = User.Identity.Name;
           
            DAL.TOUD user;

            if (Ouder.GetCompleteOuder(out user, naam))
            {
                OuderId.Value = Convert.ToString(user.Ouderid); 
                ProfielFotoId = Convert.ToInt32(user.ProfielFotoId);
                
               bindGrid();
                /*vullen van de velden met de gegevens voor de ingelogde gebruiker*/
                NaamTxt.Text = user.Naam;
              
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
                //NaamTxt.Text = null;
               // HulpId = Convert.ToInt32(user.Ouderid); 
            }
            //HulpId = Convert.ToInt32(user.Ouderid); 
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

               // Response.AppendHeader("Refresh", "0;URL=profiel.aspx");
            }
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


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            Byte[] bytes = null;
            if (FileUpload1.HasFile)
            {
                string filename = FileUpload1.PostedFile.FileName;
                string filePath = Path.GetFileName(filename);

                Stream fs = FileUpload1.PostedFile.InputStream;
                BinaryReader br = new BinaryReader(fs);
                bytes = br.ReadBytes((Int32)fs.Length);
            }
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString))
            {
                string updateSql = "UPDATE TOUD " + "SET ProfielFoto = @Image " + "WHERE OuderId = @OuderId";
                SqlCommand command = new SqlCommand(updateSql, connection);
                command.Parameters.Add("@OuderId",
                SqlDbType.Int).Value = OuderId.Value;
                command.Parameters.Add("@Image",
                SqlDbType.Binary).Value = bytes;
                connection.Open();
                command.ExecuteNonQuery();
                bindGrid();
                Response.AppendHeader("Refresh", "0;URL=profiel.aspx");
            }
        }
        catch (Exception)
        {     //error     
        }
    }

    protected void bindGrid()
    {
        DataSet ds = new DataSet();
        using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString))
        {
            connection.Open();


            string cmdstr = "Select ProfielFotoId from TKIN WHERE ProfielFotoId =" + ProfielFotoId;
            SqlCommand cmd = new SqlCommand(cmdstr, connection);


            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            gvDetails.DataSource = ds;
            gvDetails.DataBind();
        }

    }

}