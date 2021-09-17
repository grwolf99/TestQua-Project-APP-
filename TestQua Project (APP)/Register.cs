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
   public partial class Register : Form
   {
      public Register()
      {
         InitializeComponent();
      }

      private void btnLogin_Click(object sender, EventArgs e)
      {
         var login = new Login();
         login.Show();
         Hide();
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         Connection.DB();
         Function.gen = "INSERT INTO testinguser(firstname, lastname, age, contact, dateregistered)VALUES('"+ txtbFname.Text + "', '" + txtbLname.Text + "', '" + txtbAge.Text + "', '" + txtContact.Text + "', '"+ DateTime.Now.ToString(/) +"')";
         Function.command = new SqlCommand(Function.gen, Connection.con);
         Function.command.ExecuteNonQuery();
         MessageBox.Show("SUCCCCCEESS");

      }
   }
}
