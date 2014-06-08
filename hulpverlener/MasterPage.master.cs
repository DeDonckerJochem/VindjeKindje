using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

using System.Net.Mail;

public partial class MasterPage : System.Web.UI.MasterPage
{
    public string Latitude;
    public string longtitude;
    OuderDAL Ouder = new OuderDAL();
    public string email;

    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"];
        if (id != null)
        {
            //Response.Write("id is ");
            Session["id"] = id;


            email = Ouder.getOuderEmailAdress(Convert.ToInt32(id)); 
        } 

    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();
        //FormsAuthentication.RedirectToLoginPage();
        //Session.Abandon();
        //Session.Clear();
        Response.Redirect("~/Default.aspx");
    }

    protected void btnLocate_Click(object sender, EventArgs e)
    {
       
        Latitude = latdata.Value;
        longtitude = londata.Value;

       
        try
        {
            string server = "wds.imsnet.be";
            string from = "noreply@domain.com";
            MailMessage message = new MailMessage();
            message.From = new MailAddress("noreply@domain.com");
            message.To.Add(email);
            //message.To.Add("test2@test.com"); // Used for multiple destinations
            message.Subject = "test";
            message.Body = ("Hallo,\r\n\r\nJou kindje is op de volgende plek terug gevonden:\n http://maps.google.com/?q=" + latdata + "," +  londata);
            SmtpClient client = new SmtpClient(server);
            client.UseDefaultCredentials = true;
            client.Send(message);
        }
        catch (Exception ex)
        {
            //Catch if any exception occurs
            Response.Write(ex.Message);
        }
       

    }
   
    
    
}
