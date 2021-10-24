using System;
using System.Collections;
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
   public partial class CustomerOrder : Form
   {
      public static ArrayList ProductIDs = new ArrayList();
      public static ArrayList QuantityBought = new ArrayList();
      public static double TotalPrice = 0;

      public CustomerOrder()
      {
         InitializeComponent();
      }

      private void btnLogout_Click(object sender, EventArgs e)
      {
         var home = new Homepage();
         home.Show();
         Close();
      }

      private void btnProducts_Click(object sender, EventArgs e)
      {
         var cproduct = new CustomerProduct();
         cproduct.Show();
         Close();
      }

      private void btnAccounts_Click(object sender, EventArgs e)
      {
         var caccount = new CustomerProfile();
         caccount.Show();
         Close();
      }

      private void btnHome_Click(object sender, EventArgs e)
      {
         var chome = new CustomerHome();
         chome.Show();
         Close();
      }

      private void CustomerOrder_Load(object sender, EventArgs e)
      {
         viewOrders();
      }

      private void viewOrders()
      {
         Connection.DB();
         Function.gen = "SELECT * FROM OrdersDB WHERE userid = '"+ Login.userid +"' ";
         Function.fill(Function.gen, dataGridView1);
      }

      private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
      {
         TotalPrice = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["TotalPrice"].Value);   

         string strProductId = dataGridView1.Rows[e.RowIndex].Cells["ProductId"].Value.ToString();
         string[] newProductId = strProductId.Split(',');

         string strQuantity = dataGridView1.Rows[e.RowIndex].Cells["QuantityBought"].Value.ToString();
         string[] newStrQuantity = strQuantity.Split(',');

         for(int i = 0; i < newProductId.Length; i++)
         {
            ProductIDs.Add(newProductId[i]);
            QuantityBought.Add(newStrQuantity[i]);
            lblTesting.Text = ProductIDs.Count.ToString();
         }

         var vieworder = new ViewOrders();
         vieworder.Show();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         var vieworder = new ViewOrders();
         vieworder.Show();
      }
   }
}
