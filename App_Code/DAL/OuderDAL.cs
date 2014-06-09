using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;

/// <summary>
/// Summary description for OuderDAL
/// </summary>
public class OuderDAL
{
    DAL.VindjekindjeDataContext dc = new DAL.VindjekindjeDataContext();

      

    public bool GetCompleteOuder(out DAL.TOUD  user, string p)
    {
        user = new DAL.TOUD();

        try
        {
            dc.TOUDs.SingleOrDefault(t => t.Voornaam == p);
            user = (from TOUD in dc.TOUDs where TOUD.Voornaam.Equals(p) select TOUD).Single();
            return true;
        }
        catch
        {
            return false;
        }
    }


    public List<DAL.TOUD> selectAll()
    {
        var result = (from p in dc.TOUDs select p).ToList(); 
        
        return result;
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

    public void updateOuder(int id, DAL.TOUD O)
    {
        var recordToUpdate = (from C in dc.TOUDs where id == C.Ouderid select C).Single(); 
        
        recordToUpdate.Naam = O.Naam;
        recordToUpdate.Voornaam = O.Voornaam;
        recordToUpdate.TelefoonNr = O.TelefoonNr;
        recordToUpdate.MutualiteitsNr = O.MutualiteitsNr;
        recordToUpdate.GebDate = O.GebDate;
        recordToUpdate.Bloedgroep = O.Bloedgroep;
        recordToUpdate.Adres = O.Adres;
        dc.SubmitChanges();	

       
    }
    public int getaantalkinderen(string naamOuder)
    {
        var hulprecord = (from a in dc.TOUDs where naamOuder == a.Voornaam select a).Single(); 

        return (from c in dc.TOUD_KINs where hulprecord.Ouderid == c.fkOuderId select c).Count();
    }

    /*public bool GetCompleteKind(out DAL.TKIN kind, int ouderid)
    {
       
        kind = new DAL.TKIN();
        //var hulprecord = (from a in dc.TOUDs where ouderid == a.Ouderid select a).Single(); 

        try
        {
            dc.TKINs.SingleOrDefault(t => t.KindId == ouderid);
            kind = (from TKIN in dc.TKINs where TKIN.KindId.Equals(ouderid) select TKIN).Single();
            return true;
        }
        catch
        {
            return false;
        }
    }*/

    public List<DAL.TKIN> GetAlleKinderen(int ouderid)
    {
        var query = (from kindjes in dc.TKINs join x in dc.TOUD_KINs on kindjes.KindId equals x.fkKindId where x.fkOuderId == ouderid  select kindjes).ToList();
        return query;

    }

    public string getOuderEmailAdress(int kindid)
    {
        
        var result = (from a in dc.TOUD_KINs join b in dc.TOUDs on a.fkOuderId equals b.Ouderid where a.fkKindId == kindid select b.Email).Single();
        return result;
    }
}