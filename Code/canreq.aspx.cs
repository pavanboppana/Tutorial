using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient; 

public partial class canreq : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    String constring = ConfigurationManager.ConnectionStrings["conn"].ConnectionString.ToString();
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(constring);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;
        con.Open();
        cmd.CommandText = "select category,flightid from Plist where  pid='" + TextBox1.Text + "' ";
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand=cmd;
        DataSet ds=new DataSet();
        da.Fill(ds,"emp");
        if (ds.Tables["emp"].Rows.Count > 0)
        {
            Session["category"] = ds.Tables["emp"].Rows[0]["category"].ToString();
            Session["flightid"] = ds.Tables["emp"].Rows[0]["flightid"].ToString();

            if (Session["category"].ToString() == "Firstclass")
            {
                cmd.CommandText = "update schedule set Firstclass=Firstclass+1 where flightid='" + Session["flightid"] + "'";
                int j = cmd.ExecuteNonQuery();
            }
            else if (Session["category"].ToString() == "Bussinessclass")
            {
                cmd.CommandText = "update schedule set Bussinessclass=Bussinessclass+1 where flightid='" + Session["flightid"] + "'";
                int j = cmd.ExecuteNonQuery();


            }
            else
            {
                cmd.CommandText = "update schedule set Economicclass=Economicclass+1 where   flightid='" + Session["flightid"] + "'";
                int j = cmd.ExecuteNonQuery();
            }
            cmd.CommandText = "delete Plist where pid='" + TextBox1.Text + "'";
            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                Label.Visible = true;
                Label.Text = "sucess";
            }

            else
            {
                Label.Visible = true;
                Label.Text = "error";

            }
        }
        else
        {
            Label.Visible = true;
            Label.Text = "Invalid ticket id";
        }

        con.Close();
    }
}