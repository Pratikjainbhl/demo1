using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage2 : System.Web.UI.MasterPage
{
    string conn = (@"Server=PRATIK\SQLEXPRESS;Database=newsportal;Trusted_Connection=True;");
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
                cmd.CommandText = "select top 5 * from category";
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
