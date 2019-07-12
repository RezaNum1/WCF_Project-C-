using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ServerWCF
{
    public class Koneksi
    {
        public SqlConnection getConnection()
        {

            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-QQKAF15;Initial Catalog=WCF;Persist Security Info=True;User ID=sa;Password=123456789");
            //return sqlcon;

            SqlConnection sqlcon = new SqlConnection("Data Source = DESKTOP-QQKAF15;" +
            "Initial Catalog = RapotWCF;" +
            "User Id = sa;" +
            "Password = 123456789");
            return sqlcon;
        }
    }
}