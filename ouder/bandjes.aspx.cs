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

public partial class ouder_bandjes : System.Web.UI.Page
{
    OuderDAL Ouder = new OuderDAL();
    public int id;
    public int Kindid;
    public DAL.TKIN[] kindjes;
    
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!IsPostBack)
        {
            string naam = User.Identity.Name;

            
            this.id = Ouder.getaantalkinderen(naam);

            DataBind();

            DAL.TOUD user;
              
            if (Ouder.GetCompleteOuder(out user, naam))
            {
                kindjes = Ouder.GetAlleKinderen(user.Ouderid).ToArray();

                RepKinderen.DataSource = Ouder.GetAlleKinderen(user.Ouderid);
                RepKinderen.DataBind();
                

            }
            else
            {
                

            }

           
        }
        else
        {
        }
    }
    /*
    protected void innerFunction(object sender, RepeaterItemEventArgs e)
    {
        TextBox myLabel = (TextBox)e.Item.FindControl("KindId");
        FileUpload FileUpload1 = (FileUpload)e.Item.FindControl("FileUpload1");
        Button mytextbox = (Button)e.Item.FindControl("btnSubmit");
    }*/
    /*protected void btnSubmit_Click(object sender, EventArgs e)
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
                string updateSql = "UPDATE TKIN " + "SET ProfielFoto = @Image " + "WHERE KindId = @KindId";
                SqlCommand command = new SqlCommand(updateSql, connection);
                command.Parameters.Add("@KindId",
                SqlDbType.VarChar, 50).Value = KindId.Text;
                command.Parameters.Add("@Image",
                SqlDbType.Binary).Value = bytes; 
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        catch (Exception)
        {     //error     
        }
    }*/
    /*
    protected void bindGrid()
    {
         DataSet ds = new DataSet();
         using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString))
         {
             connection.Open();
             string cmdstr = "Select KindId from TKIN";
             SqlCommand cmd = new SqlCommand(cmdstr, connection);
             SqlDataAdapter adp = new SqlDataAdapter(cmd);
             adp.Fill(ds);
             gvDetails.DataSource = ds;
             gvDetails.DataBind();
         } 
    }*/
}