using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data.SqlClient;

namespace WCFClientss
{
    public partial class GantiPass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            NilaiServices1.NilaiClient objNilai = new NilaiServices1.NilaiClient();
            NilaiServices1.NilaiInfo obj = new NilaiServices1.NilaiInfo();

            obj.NIS = Convert.ToInt32(TextBox1.Text);
            obj.Username = TextBox2.Text;
            obj.Passwords = TextBox3.Text;

            objNilai.GantiPass(obj);

            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Response.Redirect("VLogin.aspx");
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}