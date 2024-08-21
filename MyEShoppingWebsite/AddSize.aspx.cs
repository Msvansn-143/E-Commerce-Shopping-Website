using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class AddSize : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindBrand();
            BindMainCategory();
            BindGender();
            BindRepeaterSize();
        }
    }

    private void BindRepeaterSize()
    {

        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyEShoppingDB"].ConnectionString))
        {
            using (SqlCommand cmd = new SqlCommand("select A.*,B.*,C.*,D.*,E.* from tblSizes A Inner join tblCategory B on B.CatID=A.CategoryID inner join tblBrands C on C.BrandID=A.BrandID inner join tblSubCategory D on D.SubCatID=A.SubCategoryID inner join tblGender E on E.GenderID=A.GenderId", con))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    rptrSize.DataSource = dt;
                    rptrSize.DataBind();
                }

            }
        }
    }

    private void BindMainCategory()
    {
        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyEShoppingDB"].ConnectionString))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  tblCategory", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                ddlCategory.DataSource = dt;
                ddlCategory.DataTextField = "CatName";
                ddlCategory.DataValueField = "CatID";
                ddlCategory.DataBind();
                ddlCategory.Items.Insert(0, new ListItem("-select-", "0"));
            }


        }
    }


    private void BindBrand()
    {
        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyEShoppingDB"].ConnectionString))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  tblBrands", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                ddlBrand.DataSource = dt;
            
                ddlBrand.DataTextField = "Name";
               
                ddlBrand.DataValueField = "BrandID";
                ddlBrand.DataBind();
                ddlBrand.Items.Insert(0, new ListItem("-select-", "0"));
            }


        }
    }

    private void BindGender()
    {
        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyEShoppingDB"].ConnectionString))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  tblGender with(nolock)", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                ddlGender.DataSource = dt;

                ddlGender.DataTextField = "GenderName";

                ddlGender.DataValueField = "GenderID";
                ddlGender.DataBind();
                ddlGender.Items.Insert(0, new ListItem("-select-", "0"));
            }


        }
    }
    protected void btnAddSize_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyEShoppingDB"].ConnectionString))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into tblSizes(SizeName,BrandID,CategoryID,SubCategoryID,GenderID) Values('" + txtSize.Text + "','" + ddlBrand.SelectedItem.Value + "','" + ddlCategory.SelectedItem.Value + "','" + ddlSubCategory.SelectedItem.Value + "','" + ddlGender.SelectedItem.Value + "')", con);
            cmd.ExecuteNonQuery();
            Response.Write("<script> alert('Size Added Successfully'); </script>");
            txtSize.Text = string.Empty;


            con.Close();
            ddlBrand.ClearSelection();
            ddlBrand.Items.FindByValue("0").Selected = true;


            ddlCategory.ClearSelection();
            ddlCategory.Items.FindByValue("0").Selected = true;


            ddlSubCategory.ClearSelection();
            ddlSubCategory.Items.FindByValue("0").Selected = true;


            ddlGender.ClearSelection();
            ddlGender.Items.FindByValue("0").Selected = true;



            // lblMsg.Text = "Registration Successfully done";
            //lblMsg.ForeColor = Color.Green;
            //txtSubCategoryname.Focus();

        }
        BindRepeaterSize();
    }




    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        int MainCategoryID = Convert.ToInt32(ddlCategory.SelectedItem.Value);
        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyEShoppingDB"].ConnectionString))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  tblSubCategory where MainCatID = '" + ddlCategory.SelectedItem.Value +"' ", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                ddlSubCategory.DataSource = dt;

                ddlSubCategory.DataTextField = "SubCatName";

                ddlSubCategory.DataValueField = "SubCatID";
                ddlSubCategory.DataBind();
                ddlSubCategory.Items.Insert(0, new ListItem("-select-", "0"));
            }


        }
    }
}