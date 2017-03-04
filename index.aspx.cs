using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class registration_Form_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
  
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string str = @"Data Source=.;Initial Catalog=Form1;Integrated Security=True";
        SqlConnection con = new SqlConnection(str);
        con.Open();
        String str1 = "INSERT INTO users (Email,Passwrd,P_Address,Gender,Country) VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + RadioButtonList1.SelectedValue + "','" + DropDownList1.SelectedItem.Text + "')";
        SqlCommand cmd = new SqlCommand(str1, con);
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Write("<script language=javasript>alert('data inserted')</script>");
    }
}
