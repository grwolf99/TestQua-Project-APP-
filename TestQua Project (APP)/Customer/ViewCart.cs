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
   public partial class ViewCart : Form
   {
      public ViewCart()
      {
         InitializeComponent();
      }

      private void ViewCart_Load(object sender, EventArgs e)
      {
         viewCart();   
      }

      private void viewCart()
      {
         Connection.DB();
         Function.gen = "SELECT * from CartDb INNER JOIN ProductInformation ON CartDB.productid = ProductInformation.productid  WHERE userid = '"+ Login.userid +"' ";
         Function.fill(Function.gen, datagridViewCart);
      }
   }
}
