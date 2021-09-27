using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Customer
{
   public partial class CustomerDashboard : Form
   {
      public CustomerDashboard()
      {
         InitializeComponent();
      }

      private void btnUpdate_Click(object sender, EventArgs e)
      {
         fieldUpdate(true);
      }

      private void fieldUpdate(bool status)
      {
         txtFirstname.Enabled = status;
         txtLastname.Enabled = status;
         txtAddress.Enabled = status;
         txtAge.Enabled = status;
         txtContacno.Enabled = status;
         txtEmail.Enabled = status;
         txtUsername.Enabled = status;
         txtConfirmPassword.Enabled = status;
         txtPassword.Enabled = status;
         cmbGender.Enabled = status;
         btnBrowsePicture.Enabled = status;
         btnSave.Enabled = status;
      }

      private void CustomerDashboard_Load(object sender, EventArgs e)
      {
         getFields();
         fieldUpdate(false);
         txtUserid.Text = Login.userid.ToString();
      }

      private void getFields()
      {
         try
         {
            Connection.DB();
            Function.gen = "SELECT * FROM UserInformation WHERE UserId = '"+ txtUserid.Text +"' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
               Function.reader.Read();
               txtFirstname.Text = Function.reader["Firstname"].ToString();
               txtLastname.Text = Function.reader["Lastname"].ToString();
               txtAddress.Text = Function.reader["Address"].ToString();
               txtAge.Text = Function.reader["Age"].ToString();
               txtContacno.Text = Function.reader["Contactno"].ToString();
               txtEmail.Text = Function.reader["Email"].ToString();
               txtUsername.Text = Function.reader["Username"].ToString();
               txtPassword.Text = Function.reader["password"].ToString();
               txtConfirmPassword.Text = Function.reader["password"].ToString();
               cmbGender.Text = Function.reader["Gender"].ToString();
               /*byte[] img = (byte[])(Function.reader["ProfilePicture"]);

               if (img == null)
               {
                  pbProfilePicture.Image = null;
               }
               else
               {
                  MemoryStream ms = new MemoryStream(img);
                  pbProfilePicture.Image = Image.FromStream(ms);
               } */
            }

            Connection.con.Close();
            fieldUpdate(false);
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnLogout_Click(object sender, EventArgs e)
      {
         var homepage = new Homepage();
         homepage.Show();
         Hide();
      }
   }
}
