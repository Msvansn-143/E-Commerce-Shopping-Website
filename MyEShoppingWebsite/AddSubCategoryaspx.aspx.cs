using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class AddSubCategoryaspx : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            BindMainCat();
            BindSubCategoryRepeater();
        }
    }

    private void BindSubCategoryRepeater()
    {
        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyEShoppingDB"].ConnectionString))
        {
            using (SqlCommand cmd = new SqlCommand("select A.*,B.* from tblSubCategory A Inner join  tblCategory B On B.CatID = A.MainCatID", con))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    rptrSubCategories.DataSource = dt;
                    rptrSubCategories.DataBind();
                }

            }
        }
    }

    protected void btnSubAddCategory_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyEShoppingDB"].ConnectionString))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into tblSubCategory(SubCatName,MainCatID) Values('" + txtSubCategoryname.Text + "','" + ddlMainCatID.SelectedItem.Value + "')", con);
            cmd.ExecuteNonQuery();
            Response.Write("<script> alert('SubCategory Added Successfully'); </script>");
            txtSubCategoryname.Text = string.Empty;


            con.Close();
            ddlMainCatID.ClearSelection();
            ddlMainCatID.Items.FindByValue("0").Selected = true;
            // lblMsg.Text = "Registration Successfully done";
            //lblMsg.ForeColor = Color.Green;
            //txtSubCategoryname.Focus();

        }
        BindSubCategoryRepeater();
    }

    private void BindMainCat()
    {
        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyEShoppingDB"].ConnectionString))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  tblCategory", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count !=0)
            {
                ddlMainCatID.DataSource = dt;
                ddlMainCatID.DataTextField = "CatName";
                ddlMainCatID.DataValueField = "CatID";
                ddlMainCatID.DataBind();
                ddlMainCatID.Items.Insert(0, new ListItem("-select-", "0"));
            }
           

        }
    }
}