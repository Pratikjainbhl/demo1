using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    string conn = (@"workstation id=PratikNews.mssql.somee.com;packet size=4096;user id=pratikjain_SQLLogin_1;pwd=s6yawkn2jg;data source=PratikNews.mssql.somee.com;persist security info=False;initial catalog=PratikNews");
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            bindlistview();
        }

    }
    private void bindlistview()
    {
        using (SqlConnection con = new SqlConnection(conn))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "select top 2 * from newslist ";
                cmd.Connection = con;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    ListView1.DataSource = dt;
                    ListView1.DataBind();

                }
            }
        }
    }
}

