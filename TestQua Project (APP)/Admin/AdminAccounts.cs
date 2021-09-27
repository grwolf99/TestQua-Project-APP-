using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Admin
{
   public partial class AdminAccounts : Form
   {
      public AdminAccounts()
      {
         InitializeComponent();
      }

      private void dataviewAccounts() 
      {
         Connection.DB();
         Function.gen = "SELECT * FROM UserInformation";
         Function.fill(Function.gen, viewAccounts);
      }

      private void btnAccounts_Click(object sender, EventArgs e)
      {
         tabcontrolAccounts.Show();
         btnAccounts.FlatStyle = FlatStyle.Standard;
      }

      private void btnLogout_Click(object sender, EventArgs e)
      {
         var homepage = new Homepage();
         homepage.Show();
         Hide();
      }

      private void AdminAccounts_Load(object sender, EventArgs e)
      {
         btnAccounts.FlatStyle = FlatStyle.Standard;
         dataviewAccounts();
      }

      private void btnProducts_Click(object sender, EventArgs e)
      {
         
      }
   }
}
