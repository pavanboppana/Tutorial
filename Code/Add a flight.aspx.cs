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
 
public partial class Add_a_flight : System.Web.UI.Page
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
        cmd.CommandText = "insert into schedule(flightid,Flightname,Fromstation,Tostation,dateandtimings,Firstclass,Bussinessclass,economicclass) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" +TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "')";

        int i = cmd.ExecuteNonQuery();
        cmd.CommandText = "insert into Fares(flightid,Flightname,Fromstation,Tostation,dateandtimings,firstclass,Bussinessclass,economicclass) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','"+TextBox5.Text+"','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "')";

         int j = cmd.ExecuteNonQuery();

         if (i >= 0 && j > 0)
         {
             Label.Visible = true;
             Label.Text = "sucessfully Added";
              }
         else
         {
             Label.Visible = true;
             Label.Text = "Error";
         }
}
}
