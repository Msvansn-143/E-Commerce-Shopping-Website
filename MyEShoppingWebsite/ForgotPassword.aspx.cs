using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Net;

public partial class ForgotPassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnResetPass_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyEShoppingDB"].ConnectionString))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from tblUsers where Email=@Email", con);
            cmd.Parameters.AddWithValue("@Email", txtEmailID.Text);
            
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                string myGUID = Guid.NewGuid().ToString();
                int Uid = Convert.ToInt32(dt.Rows[0][0]);
                SqlCommand cmd1 = new SqlCommand("Insert into ForgotPass(Id,Uid,RequestDateTime) Values('" + myGUID + "', '" + Uid + "',GETDATE())", con);
                cmd1.ExecuteNonQuery();

                //send Reset link via mail

                string ToEmailID = dt.Rows[0][3].ToString() ;
                string Username = dt.Rows[0][1].ToString();
                string EmailBody = "Hi ,"+Username + ",<br/><br/>Click the link below to reset password<br/><br/>http://localhost:50167/RecoverPassword.aspx?id="+myGUID;

                MailMessage PassRecMail = new MailMessage("andesampat@gmail.com",ToEmailID);

                PassRecMail.Body = EmailBody;
                PassRecMail.IsBodyHtml = true;
                PassRecMail.Subject = "Reset Password";

                using(SmtpClient client = new SmtpClient())
                {
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("andesampat@gmail.com", "Andesampath@1");
                    client.Host = "smtp.gmail.com";
                    client.Port = 587;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;

                    client.Send(PassRecMail);
                }


                //SmtpClient SMTP = new SmtpClient("smtp.gmail.com", 587);
                //SMTP.Credentials = new NetworkCredential()
                //{
                //    UserName = "andesampathkumar@gmail.com ",
                //    Password = "Andesampath@1"
                //};
                //SMTP.EnableSsl = true;
                //SMTP.Send(PassRecMail);

                 //--------------
                
                lblResetPassMSg.Text = "Reset Link send..! Check Your Email for Reset Password ";
                lblResetPassMSg.ForeColor = System.Drawing.Color.Green;
                txtEmailID.Text = string.Empty;
            }
            else
            {
                lblResetPassMSg.Text = "OOPS!  This Email Does not Exist...Please Try Again";
                lblResetPassMSg.ForeColor = System.Drawing.Color.Red;
                txtEmailID.Text = string.Empty;
                txtEmailID.Focus();
            }

           
        }
    }
}