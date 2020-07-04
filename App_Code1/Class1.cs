using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class2
{
    public SqlConnection connet()
    {

        string s = @"Data Source=Venkat;Initial Catalog=OnlineCrimeRpt;User id=sa;Password=sas;trusted_connection=yes";
        SqlConnection con = new SqlConnection(s);
        return con;

    }
}
