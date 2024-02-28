using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class blogview : System.Web.UI.Page
{
    string conn = (@"workstation id=PratikNews.mssql.somee.com;packet size=4096;user id=pratikjain_SQLLogin_1;pwd=s6yawkn2jg;data source=PratikNews.mssql.somee.com;persist security info=False;initial catalog=PratikNews");

    protected void Page_Load(object sender, EventArgs e)
    {
        
        {

        }

        if (!IsPostBack)
        {

            calling();
        }
    }
    private void calling()
    {
        string id = Request.QueryString["id"];

        {
            if (!this.IsPostBack)
            {

                using (SqlConnection con = new SqlConnection(@"workstation id=PratikNews.mssql.somee.com;packet size=4096;user id=pratikjain_SQLLogin_1;pwd=s6yawkn2jg;data source=PratikNews.mssql.somee.com;persist security info=False;initial catalog=PratikNews"))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT id,heading, titletag, keywords, descr, img FROM newslist WHERE id ='" + id + "' "))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            lblheading.Text = sdr["heading"].ToString();
                            lbltitle.Text = sdr["titletag"].ToString();
                            lblkeywords.Text = sdr["keywords"].ToString();
                            lbldescription.Text = sdr["descr"].ToString();
                            Image1.ImageUrl = "~/admin/images/newsimage/" + sdr["img"].ToString();
                            lblimg.Text = sdr["img"].ToString();

                        }
                        con.Close();
                    }
                }
            }
        }
    }



}