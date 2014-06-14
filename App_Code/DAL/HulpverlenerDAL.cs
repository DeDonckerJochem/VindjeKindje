using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Hulpverlener
/// </summary>
public class HulpverlenerDAL
{
    DAL.VindjekindjeDataContext dc = new DAL.VindjekindjeDataContext();

    public bool GetCompleteHulpverlener(out DAL.THUL Hulpv, string p)
    {
        Hulpv = new DAL.THUL();

        try
        {
            dc.THULs.SingleOrDefault(t => t.Voornaam == p);
            Hulpv = (from THUL in dc.THULs where THUL.Voornaam.Equals(p) select THUL).Single();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public void updateHulpverlener(int id, DAL.THUL O)
    {
        var recordToUpdate = (from C in dc.THULs where id == C.HulpverlenerId select C).Single();

        recordToUpdate.Naam = O.Naam;
        recordToUpdate.Voornaam = O.Voornaam;
        /*recordToUpdate.TelefoonNr = O.TelefoonNr;
        recordToUpdate.MutualiteitsNr = O.MutualiteitsNr;
        recordToUpdate.GebDate = O.GebDate;
        recordToUpdate.Bloedgroep = O.Bloedgroep;
        recordToUpdate.Adres = O.Adres;*/
        dc.SubmitChanges();


    }

}