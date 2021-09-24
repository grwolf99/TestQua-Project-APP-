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

namespace TestQua_Project__APP_
{
   public partial class Login : Form
   {
      public static int userid = 0;
      public static int roleid = 0;
      public static string firstname = "";
      public static string lastname = "";

      public Login()
      {
         InitializeComponent();
      }

      private void btnLogin_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.DB();
            Function.gen = "SELECT * FROM UserInformation WHERE Username = '"+ txtUsername.Text +"' AND Password = '"+ txtPassword.Text +"' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if(Function.reader.HasRows){
               Function.reader.Read();
               roleid = Convert.ToInt32(Function.reader["RoleId"]);

               if (roleid == 1){    //Admin
               
               }
               else if(roleid == 2){  //Customer
                  txtUsername.Text = Function.reader["Username"].ToString();
                  txtPassword.Text = Function.reader["Password"].ToString();

                  firstname = Function.reader["Firstname"].ToString();
                  lastname = Function.reader["Lastname"].ToString();
                  userid = Convert.ToInt32(Function.reader["UserId"]);
                  roleid = Convert.ToInt32(Function.reader["RoleId"]);
                  var homepage = new Homepage();
                  homepage.Show();
                  Hide();
               }
               else if(roleid == 3){ //Supplier
               
               }
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void linklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         var register = new Register();
         register.Show();
         Hide();
      }
   }
}
