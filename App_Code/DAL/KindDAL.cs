using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Drawing; 
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
/// <summary>
/// Summary description for KindDAL
/// </summary>
public class KindDAL
{
    DAL.VindjekindjeDataContext dc = new DAL.VindjekindjeDataContext();
	
		public bool GetCompleteKind(out DAL.TKIN  kind, Guid KindId)
    {
        kind = new DAL.TKIN();

        try
        {
            dc.TKINs.SingleOrDefault(t => t.KindId == KindId);
            kind = (from TKIN in dc.TKINs where TKIN.KindId.Equals(KindId) select TKIN).Single();
            return true;
        }
        catch
        {
            return false;
        }
    }

        public void updateKind(Guid Kindid, DAL.TKIN O)
        {
            var recordToUpdate = (from C in dc.TKINs where Kindid == C.KindId select C).Single();

            recordToUpdate.Naam = O.Naam;
            recordToUpdate.Voornaam = O.Voornaam;
           // recordToUpdate.TelefoonNr = O.TelefoonNr;
            //recordToUpdate.MutualiteitsNr = O.MutualiteitsNr;
            recordToUpdate.GebDate = O.GebDate;
            recordToUpdate.FkBloedGroepId = O.FkBloedGroepId;
            recordToUpdate.Adres = O.Adres;
            dc.SubmitChanges();


        }

        public string getbloedgroep(int bloedgroepid)
        {
            return (from TBLO in dc.TBLOs where TBLO.BloedGroepId == bloedgroepid select TBLO.Omschrijving).Single();
        }
        public void updatebloedgroep(int bloedgroepid, string Blomschrijving)
        {
            var recordToUpdate = (from C in dc.TBLOs where bloedgroepid == C.BloedGroepId select C).Single();
            recordToUpdate.Omschrijving = Blomschrijving;
            dc.SubmitChanges();
        }

     /*   public void get_profile_pic(Int32 ProfielFotoId, string Voornaam)
        {
            using (SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString))
            {
                sqlconnection.Open();

                string selectQuery = string.Format(@"select ProfielFoto from TKIN where ProfielFotoId={0}"
                                    , ProfielFotoId);

                // Read Image Value from Sql Table 
                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlconnection);
                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.Read())
                {
                    byte[] imgData = (byte[])reader[0];
                    using (MemoryStream ms = new MemoryStream(imgData))
                    {
                        System.Drawing.Image image = Image.FromStream(ms);
                        image.Save(@"C:\inetpub\wwwroot\images\" + Voornaam + "Photo.jpg");
                    }
                }
            }
        }*/

    
}