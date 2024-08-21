using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

public partial class AddProduct : System.Web.UI.Page
{
    public static String CS = ConfigurationManager.ConnectionStrings["MyEShoppingDB"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
       if (!IsPostBack)
        {
            //when page runs for first time this code will Execute
            BindBrand();
            BindCategory();
            BindGender();
            txtQuantity.Text = "0";
            ddlSubCategory.Enabled = false;
            ddlGender.Enabled = false;
        }
    }

    private void BindGender()
    {
        using (SqlConnection con = new SqlConnection(CS))
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

    private void BindCategory()
    {
        using (SqlConnection con = new SqlConnection(CS))
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
        using (SqlConnection con = new SqlConnection(CS))
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

    protected void btnAdd_Click(object sender, EventArgs e)
    {

        using (SqlConnection con = new SqlConnection(CS))
        {
            SqlCommand cmd = new SqlCommand("sp_InsertProduct", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PName", txtProductName.Text);
            cmd.Parameters.AddWithValue("@PPrice", txtPrice.Text);
            cmd.Parameters.AddWithValue("@PSelPrice", txtSellPrice.Text);
            cmd.Parameters.AddWithValue("@PBrandID", ddlBrand.SelectedItem.Value);
            cmd.Parameters.AddWithValue("@PCategoryID", ddlCategory.SelectedItem.Value);
            cmd.Parameters.AddWithValue("@PSubCatID", ddlSubCategory.SelectedItem.Value);
            cmd.Parameters.AddWithValue("@PGender", ddlGender.SelectedItem.Value);
            cmd.Parameters.AddWithValue("@PDescription", txtDescription.Text);
            cmd.Parameters.AddWithValue("@PProductDetails", txtPDetail.Text);
            cmd.Parameters.AddWithValue("@PMaterialCare", txtMatCare.Text);
            if (chFD.Checked == true)
            {
                cmd.Parameters.AddWithValue("@FreeDelivery", 1.ToString());
            }
            else
            {
                cmd.Parameters.AddWithValue("@FreeDelivery", 0.ToString());
            }


            if (ch30Ret.Checked == true)
            {
                cmd.Parameters.AddWithValue("@30DayRet", 1.ToString());
            }
            else
            {
                cmd.Parameters.AddWithValue("@30DayRet", 0.ToString());
            }

            if (cbCOD.Checked == true)
            {
                cmd.Parameters.AddWithValue("@COD", 1.ToString());
            }
            else
            {
                cmd.Parameters.AddWithValue("@COD", 0.ToString());
            }
            con.Open();
            Int64 PID = Convert.ToInt64(cmd.ExecuteScalar());

            //  Insert size quantity
            if (txtQuantity.Text != string.Empty)
            {

                for (int i = 0; i < CblSize.Items.Count; i++)
                {
                    if (CblSize.Items[i].Selected == true)
                    {
                        Int64 sizeID = Convert.ToInt64(CblSize.Items[i].Value);
                        int Quantity = Convert.ToInt32(txtQuantity.Text);
                        //  int Quantity = Convert.ToInt32(ddlQuantity.SelectedValue.ToString());

                        SqlCommand cmd2 = new SqlCommand("Insert into tblProductSizeQuantity values('" + PID + "', '" + sizeID + "', '" + Quantity + "')", con);
                        cmd2.ExecuteNonQuery();

                    }
                }

            }
         

        //Insert and Upload images
        if(FuImg01.HasFile)
            {
                string SavePath = Server.MapPath("~Images/ProductImages") + PID ;
                if(!Directory.Exists(SavePath))
                {
                    Directory.CreateDirectory(SavePath);
                }
                string Extension = Path.GetExtension(FuImg01.PostedFile.FileName);
                FuImg01.SaveAs(SavePath + "\\" + txtProductName.Text.ToString().Trim() + "01" +Extension);

                SqlCommand cmd3 = new SqlCommand("Insert into tblProductImages values('" + PID + "', '" + txtProductName.Text.ToString().Trim() + "01"+"', '" + Extension + "')", con);
                cmd3.ExecuteNonQuery();

            }
            //2nd File Upload
            if (FuImg02.HasFile)
            {
                string SavePath = Server.MapPath("~Images/ProductImages") + PID;
                if (!Directory.Exists(SavePath))
                {
                    Directory.CreateDirectory(SavePath);
                }
                string Extension = Path.GetExtension(FuImg02.PostedFile.FileName);
                FuImg02.SaveAs(SavePath + "\\" + txtProductName.Text.ToString().Trim() + "02" + Extension);

                SqlCommand cmd4 = new SqlCommand("Insert into tblProductImages values('" + PID + "', '" + txtProductName.Text.ToString().Trim() + "02" + "', '" + Extension + "')", con);
                cmd4.ExecuteNonQuery();

            }
            //3rd File upload
            if (FuImg03.HasFile)
            {
                string SavePath = Server.MapPath("~Images/ProductImages") + PID;
                if (!Directory.Exists(SavePath))
                {
                    Directory.CreateDirectory(SavePath);
                }
                string Extension = Path.GetExtension(FuImg03.PostedFile.FileName);
                FuImg03.SaveAs(SavePath + "\\" + txtProductName.Text.ToString().Trim() + "03" + Extension);

                SqlCommand cmd5 = new SqlCommand("Insert into tblProductImages values('" + PID + "', '" + txtProductName.Text.ToString().Trim() + "03" + "', '" + Extension + "')", con);
                cmd5.ExecuteNonQuery();

            }
            //4th file upload
            if (FuImg04.HasFile)
            {
                string SavePath = Server.MapPath("~Images/ProductImages") + PID;
                if (!Directory.Exists(SavePath))
                {
                    Directory.CreateDirectory(SavePath);
                }
                string Extension = Path.GetExtension(FuImg04.PostedFile.FileName);
                FuImg04.SaveAs(SavePath + "\\" + txtProductName.Text.ToString().Trim() + "04" + Extension);

                SqlCommand cmd6 = new SqlCommand("Insert into tblProductImages values('" + PID + "', '" + txtProductName.Text.ToString().Trim() + "04" + "', '" + Extension + "')", con);
                cmd6.ExecuteNonQuery();

            }

            if (FuImg05.HasFile)
            {
                string SavePath = Server.MapPath("~Images/ProductImages") + PID;
                if (!Directory.Exists(SavePath))
                {
                    Directory.CreateDirectory(SavePath);
                }
                string Extension = Path.GetExtension(FuImg05.PostedFile.FileName);
                FuImg05.SaveAs(SavePath + "\\" + txtProductName.Text.ToString().Trim() + "05" + Extension);

                SqlCommand cmd7 = new SqlCommand("Insert into tblProductImages values('" + PID + "', '" + txtProductName.Text.ToString().Trim() + "05" + "', '" + Extension + "')", con);
                cmd7.ExecuteNonQuery();

            }

           
          
            Response.Write("<script> alert('Product Added Successfully'); </script>");
            clr();

        }
    }

    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlSubCategory.Enabled = true;
       // ddlGender.Enabled = true;
        int MainCategoryID = Convert.ToInt32(ddlCategory.SelectedItem.Value);
        using (SqlConnection con = new SqlConnection(CS))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  tblSubCategory where MainCatID = '" + ddlCategory.SelectedItem.Value + "' ", con);
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

    protected void ddlGender_SelectedIndexChanged(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection(CS))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  tblSizes where BrandID = '" + ddlBrand.SelectedItem.Value + "' and CategoryID='" + ddlCategory.SelectedItem.Value + "' and SubCategoryID = '" + ddlSubCategory.SelectedItem.Value + "' and GenderID = '" + ddlGender.SelectedItem.Value  + "'   ", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                CblSize.DataSource = dt;

                CblSize.DataTextField = "SizeName";

                CblSize.DataValueField = "SizeID";
                CblSize.DataBind();
                //ddlSubCategory.Items.Insert(0, new ListItem("-select-", "0"));
            }


        }
    }

    protected void ddlSubCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlSubCategory.SelectedIndex != 0)
        {
            ddlGender.Enabled = true;
        }
        else
        {
            ddlGender.Enabled = false;
        }
    }

    private void clr()
    {
        txtDescription.Text = string.Empty;
        txtMatCare.Text = string.Empty;
        txtPDetail.Text = string.Empty;
        txtPrice.Text = string.Empty;
        txtProductName.Text = string.Empty;
        txtQuantity.Text = string.Empty;
        txtSellPrice.Text = string.Empty;
        ddlBrand.Items.Clear();
        ddlGender.Items.Clear();
        ddlSubCategory.Items.Clear();
        ddlCategory.Items.Clear();
        

    }
}