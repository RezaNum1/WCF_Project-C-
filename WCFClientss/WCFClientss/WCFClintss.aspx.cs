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
using System.Xml.Linq;
using System.Data.SqlClient;

namespace WCFClientss
{
    public partial class WCFClintss : System.Web.UI.Page
    {

        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("VLogin.aspx");
            }
            else
                con.ConnectionString = "Data Source=DESKTOP-QQKAF15;Initial Catalog=RapotWCF;User ID=sa;Password=123456789";
            con.Open();
            showdata();
        }

        public void showdata()
        {
            cmd.CommandText = "select*from nilai where username='" + Session["user"] + "'";
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(ds);
            Label1.Text = ds.Tables[0].Rows[0]["username"].ToString();


            SqlCommand sdm = new SqlCommand();
            sdm.CommandText = "select*from nilai where username='" + Session["user"] + "'";
            sdm.Connection = con;
            SqlDataReader dr = sdm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Label2.Text = dr.GetInt32(0).ToString();
                    Label3.Text = dr.GetString(1);
                    Label4.Text = dr.GetString(2);
                    Label5.Text = dr.GetString(3);
                    Label6.Text = dr.GetString(4);
                    Label7.Text = dr.GetInt32(5).ToString();
                    Label8.Text = dr.GetInt32(6).ToString();
                    Label9.Text = dr.GetInt32(7).ToString();
                    Label10.Text = dr.GetInt32(8).ToString();
                    Label11.Text = dr.GetString(9);

                    /* byte[] imgd = (byte[])dr["images"];
                     string image = Convert.ToBase64String(imgd, 0, imgd.Length);
                     Image1.ImageUrl = "data:image/jpg;base64," + image;*/
                }

            }


            /* SqlCommand sdm = new SqlCommand();
             sdm.CommandText = "select images from nilai where username='" + Session["user"] + "'";
             sdm.Connection = con;
             SqlDataReader dr = sdm.ExecuteReader();
             if(dr.HasRows)
             {
                 while(dr.Read())
                 {
                     byte[] imgd = (byte[])dr["images"];
                     string image = Convert.ToBase64String(imgd, 0, imgd.Length);
                     Image1.ImageUrl = "data:image/jpg;base64," + image;
                 }

             }*/

        }


        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Response.Redirect("VLogin.aspx");
        }
    }
}
