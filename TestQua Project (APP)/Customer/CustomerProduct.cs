using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Customer
{
   public partial class CustomerProduct : Form
   {
      public CustomerProduct()
      {
         InitializeComponent();
      }

      private void btnHome_Click(object sender, EventArgs e)
      {
         var customerhome = new CustomerHome();
         customerhome.Show();
         Hide();
      }

      private void btnProfile_Click(object sender, EventArgs e)
      {
         var customerprofile = new CustomerProfile();
         customerprofile.Show();
         Close();
      }

      private void CustomerProduct_Load(object sender, EventArgs e)
      {
         btnProducts.FlatStyle = FlatStyle.Standard;
         viewDataProducts();
      }

      private void viewDataProducts()
      {
         Connection.DB();
         Function.gen = "SELECT * FROM ProductInformation";
         Function.fill(Function.gen, viewProduct);
      }

      private void viewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {
         var viewproduct = new CustomerProductView();
         viewproduct.Show();
      }

      private void btnProducts_Click(object sender, EventArgs e)
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
