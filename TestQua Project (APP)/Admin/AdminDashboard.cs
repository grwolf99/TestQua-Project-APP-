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
   public partial class AdminDashboard : Form
   {
      public AdminDashboard()
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

      private void AdminDashboard_Load(object sender, EventArgs e)
      {
         dataviewAccounts();
         tabcontrolAccounts.Hide();
      }

      private void btnProducts_Click(object sender, EventArgs e)
      {
         
      }
   }
}
