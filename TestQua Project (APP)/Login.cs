using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestQua_Project__APP_
{
   public partial class Login : Form
   {
      public Login()
      {
         InitializeComponent();
      }

      private void Login_Load(object sender, EventArgs e)
      {
         viewTestingUser();
      }

      private void viewTestingUser()
      {
         Connection.DB();
         Function.gen = "SELECT userid AS USERID FROM testinguser INNER JOIN userid ";
         Function.fill(Function.gen, datagridTestingUser); 
      }
   }
}
