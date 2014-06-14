using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

public partial class hulpverlener_kindprofiel : System.Web.UI.Page
{
    KindDAL Kind = new KindDAL();

    public int ProfielFotoId;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            DAL.TKIN kind;

            Guid kindid = new Guid();
            kindid = (Guid)Session["KindId"];

           // KindIdlbl.Value = (string)(Session["KindId"]); ;

            if (Kind.GetCompleteKind(out kind, kindid))
            {
                ProfielFotoId = Convert.ToInt32(kind.ProfielFotoId);
                bindGrid();
                //Kind.get_profile_pic(Convert.ToInt32(kind.ProfielFotoId), kind.Voornaam);

                /*vullen van de velden met de gegevens voor het kind*/
                NaamTxt.Text = kind.Naam;

                VoornaamTxt.Text = kind.Voornaam;


                DateTime datum = kind.GebDate.Value;
                string formatted = datum.ToString("dd/M/yyyy");

                GebDatTxt.Text = formatted;

                BloedgroepTxt.Text = (Kind.getbloedgroep(Convert.ToInt32(kind.FkBloedGroepId)));
                AdresTxt.Text = kind.Adres;

                /*het onediteerbaar maken van de velden voor deze gebruiker*/
                NaamTxt.ReadOnly = true;
                NaamTxt.BackColor = System.Drawing.SystemColors.GrayText;
                VoornaamTxt.ReadOnly = true;
                VoornaamTxt.BackColor = System.Drawing.SystemColors.GrayText;

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


            }
        }
    }



    protected void EditBtn_Click(object sender, ImageClickEventArgs e)
    {
        NaamTxt.ReadOnly = false;
        NaamTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
        VoornaamTxt.ReadOnly = false;
        VoornaamTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;


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

        DAL.TKIN kind;
        DAL.TKIN Kindtoupdate = new DAL.TKIN();
        Guid kindid = new Guid();
        kindid = (Guid)Session["KindId"];
        if (Kind.GetCompleteKind(out kind, kindid))
        {
            Kindtoupdate.Naam = NaamTxt.Text;
            Kindtoupdate.Voornaam = VoornaamTxt.Text;

            Kindtoupdate.GebDate = DateTime.Parse(GebDatTxt.Text);
            Kindtoupdate.FkBloedGroepId = kind.FkBloedGroepId;
            Kind.updatebloedgroep(Convert.ToInt32(kind.FkBloedGroepId), Convert.ToString(BloedgroepTxt.Text));
            Kindtoupdate.Adres = AdresTxt.Text;

            Kind.updateKind(kindid, Kindtoupdate);

            // Response.AppendHeader("Refresh", "0;URL=Kindprofiel.aspx");
        }
        /*het onediteerbaar maken van de velden voor deze gebruiker*/
        NaamTxt.ReadOnly = true;
        NaamTxt.BackColor = System.Drawing.SystemColors.GrayText;
        VoornaamTxt.ReadOnly = true;
        VoornaamTxt.BackColor = System.Drawing.SystemColors.GrayText;

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
                Guid kindid = new Guid();
                kindid = (Guid)Session["KindId"];
                string updateSql = "UPDATE TKIN " + "SET ProfielFoto = @Image " + "WHERE KindId = @KindId";
                SqlCommand command = new SqlCommand(updateSql, connection);
                command.Parameters.Add("@KindId",
                SqlDbType.UniqueIdentifier).Value = kindid;
                command.Parameters.Add("@Image",
                SqlDbType.Binary).Value = bytes;
                connection.Open();
                command.ExecuteNonQuery();
                bindGrid();
                
                Response.AppendHeader("Refresh", "0;URL=kindprofiel.aspx/?id=" + kindid);
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