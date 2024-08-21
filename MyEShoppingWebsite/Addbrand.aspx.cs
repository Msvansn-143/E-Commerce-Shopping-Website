using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class Addbrand : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            BindBrandRepeater();
        }
    }

    private void BindBrandRepeater()
    {
        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyEShoppingDB"].ConnectionString))
        {
            using (SqlCommand cmd = new SqlCommand("select * from tblBrands", con)) 
            {
                using (SqlDataAdapter sda=new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    rptrBrands.DataSource = dt;
                    rptrBrands.DataBind();
                }
                
            }
        }
    }

    protected void btnAddBrand_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyEShoppingDB"].ConnectionString))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into tblBrands(Name) Values('" + txtBrandname.Text  + "')", con);
            cmd.ExecuteNonQuery();
            Response.Write("<script> alert('Brand Added Successfully'); </script>");
            txtBrandname.Text = string.Empty;
           
            con.Close();
            // lblMsg.Text = "Registration Successfully done";
            //lblMsg.ForeColor = Color.Green;
            txtBrandname.Focus();

        }
    }
}