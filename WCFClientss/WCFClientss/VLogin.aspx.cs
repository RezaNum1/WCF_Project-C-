using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web.Security;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;

namespace WCFClientss
{
    public partial class VLogin : System.Web.UI.Page
    {
        
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] != null)
            {
                Response.Redirect("WCFClintss.aspx");
            }
            else
            con.ConnectionString = "Data Source=DESKTOP-QQKAF15;Initial Catalog=RapotWCF;User ID=sa;Password=123456789";
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string user = TextBox1.Text.Trim();
            cmd.CommandText = "select*from nilai where username='" + TextBox1.Text + "' and passwords='" + TextBox2.Text + "'";
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(ds, "nilai");
            if(ds.Tables[0].Rows.Count > 0)
            {
                Session["user"] = user;
                Response.Redirect("WCFClintss.aspx");
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('Something gono wrong');", true);
            }
        }
    }
}