using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Supplier
{
   public partial class SupplierProfile : Form
   {
      public SupplierProfile()
      {
         InitializeComponent();
      }

      private void SupplierProfile_Load(object sender, EventArgs e)
      {
         btnProfile.FlatStyle = FlatStyle.Standard;
         txtUserid.Text = Login.userid.ToString();
         getFields();
         fieldUpdate(false);
      }

      private void fieldUpdate(bool status)
      {
         txtFirstname.Enabled = status;
         txtLastname.Enabled = status;
         txtAddress.Enabled = status;
         txtAge.Enabled = status;
         txtContacno.Enabled = status;
         txtEmail.Enabled = status;
         txtConfirmPassword.Enabled = status;
         txtPassword.Enabled = status;
         cmbGender.Enabled = status;
         btnBrowsePicture.Enabled = status;
         btnSave.Enabled = status;
      }

      private void getFields()
      {
         try
         {
            Connection.DB();
            Function.gen = "SELECT * FROM UserInformation WHERE UserId = '" + txtUserid.Text + "' ";
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

               /*if (Function.reader["Profilepicture"] == null)
               {
                  MessageBox.Show("WALAY SULOD");
                  byte[] img = (byte[])(Function.reader["ProfilePicture"]);
                  MemoryStream ms = new MemoryStream(img);
                  pbProfilePicture.Image = Image.FromStream(ms);
               }
               else
               {
                  MessageBox.Show("NAAY SULOD");
               }*/
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
         Close();
      }

      private void btnHome_Click(object sender, EventArgs e)
      {
         var supplierhome = new SupplierHome();
         supplierhome.Show();
         Close();
      }
   }
}
