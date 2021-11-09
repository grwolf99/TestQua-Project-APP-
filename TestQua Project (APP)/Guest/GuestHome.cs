using System;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Guest
{
   public partial class GuestHome : Form
   {
      public GuestHome()
      {
         InitializeComponent();
      }

      private void GuestHome_Load(object sender, EventArgs e)
      {
         btnHome.FlatStyle = FlatStyle.Standard;
      }

      private void btnLogout_Click(object sender, EventArgs e)
      {
         var home = new Homepage();
         home.Show();
         Close();
      }

      private void btnProducts_Click(object sender, EventArgs e)
      {
         var prod = new GuestViewProduct();
         prod.Show();
         Close();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         var reg = new Register();
         reg.Show();
         Close();
      }
   }
}
