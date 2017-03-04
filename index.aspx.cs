using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class preview_dotnet_templates_registration_Form_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Dosomething(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=RAMAKRISHNA;AttachDbFilename=|DataDirectory|\Form1.sql;Integrated Security=True;User Instance=True;");
        con.Open();
        String str = "INSERT INTO users (Email,Passwrd,P_Address,Gender,Country) VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + RadioButtonList1 + "','" + DropDownList1 + "')";
        SqlCommand cmd = new SqlCommand(str, con);
        int OBJ = Convert.ToInt32(cmd.ExecuteNonQuery());
        if (OBJ > 0)
           {
                   Label9.Text = "Data is successfully inserted in database";
           }
          else
                {
                    Label9.Text = "Data is not inserted in database";
                }
        
        con.Close();
        
       }
        
  }

        