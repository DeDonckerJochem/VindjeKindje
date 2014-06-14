<%@ WebHandler Language="C#" Class="THULHandler" %>

using System;
using System.Web;

public class THULHandler : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {

        
            System.Data.SqlClient.SqlDataReader rdr = null;
            System.Data.SqlClient.SqlConnection conn = null;
            System.Data.SqlClient.SqlCommand selcmd = null;
            try
            {
                conn = new System.Data.SqlClient.SqlConnection
              (System.Configuration.ConfigurationManager.ConnectionStrings
              ["ArmbandConnectionString"].ConnectionString);
                selcmd = new System.Data.SqlClient.SqlCommand
              ("select ProfielFoto from THUL where ProfielFotoId=" +
              context.Request.QueryString["ProfielFotoId"], conn);
                conn.Open();
                rdr = selcmd.ExecuteReader();
                while (rdr.Read())
                {
                    context.Response.ContentType = "image/jpg";
                    context.Response.BinaryWrite((byte[])rdr["ProfielFoto"]);
                }
                if (rdr != null)
                    rdr.Close();
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }

        
    }
    public bool IsReusable {
        get {
            return false;
        }
    }

}