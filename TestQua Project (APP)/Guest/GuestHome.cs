using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

      }

      private void btnLogout_Click(object sender, EventArgs e)
      {
         var home = new Homepage();
         home.Show();
         Close();
      }
   }
}
