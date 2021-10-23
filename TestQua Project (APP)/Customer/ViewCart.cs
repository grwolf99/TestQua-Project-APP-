using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Customer
{
   public partial class ViewCart : Form
   {
      private double price = 0;
      private double totalprice = 0;
      private int productid  = 0;
      private int setMax = 0;
      public ViewCart()
      {
         InitializeComponent();
      }

      private void ViewCart_Load(object sender, EventArgs e)
      {
         viewCart();
         setTotalPrice();
      }

      private void setNumericUpandDown()
      {
         numericUpDown_Quantity.Minimum = 1;
         numericUpDown_Quantity.Maximum = setMax;
      }

      private void viewCart()
      {
         Connection.DB();
         Function.gen = "SELECT * from CartDb INNER JOIN ProductInformation ON CartDB.productid = ProductInformation.productid  WHERE userid = '"+ Login.userid +"' ";
         Function.fill(Function.gen, datagridViewCart);
      }

      private void button1_Click(object sender, EventArgs e)
      {
         var customerproduct = new CustomerProduct();
         customerproduct.Show();
         Close();
      }

      private void button2_Click(object sender, EventArgs e)
      {
         var customercheckout = new CustomerCheckout();
         customercheckout.Show();
         Close();
      }

      private void datagridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {
         txtName.Text = datagridViewCart.Rows[e.RowIndex].Cells["productname"].Value.ToString();
         price =  Convert.ToDouble(datagridViewCart.Rows[e.RowIndex].Cells["productprice"].Value);
         double quantity =  Convert.ToDouble(datagridViewCart.Rows[e.RowIndex].Cells["quantity"].Value);
         txtTotalPrice.Text = (quantity * price).ToString();
         productid = Convert.ToInt32(datagridViewCart.Rows[e.RowIndex].Cells["productid"].Value);
         numericUpDown_Quantity.Value = Convert.ToDecimal(quantity);
         setMax = Convert.ToInt32(datagridViewCart.Rows[e.RowIndex].Cells["quantity1"].Value);
         byte[] img = (byte[])(datagridViewCart.Rows[e.RowIndex].Cells["productimage"].Value);
         setNumericUpandDown();

         if (img == null)
         {
            pictureBox.Image = null;
         }
         else
         {
            MemoryStream ms = new MemoryStream(img);
            pictureBox.Image = Image.FromStream(ms);
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
         }
      }

      private void numericUpDown_Quantity_ValueChanged(object sender, EventArgs e)
      {
         txtTotalPrice.Text = (Convert.ToDouble(numericUpDown_Quantity.Value) * price).ToString();
      }

      private void clearFields()
      {
         pictureBox.Dispose();
         txtName.Clear();
         txtTotalPrice.Clear();
         numericUpDown_Quantity.Value = 0;
      }

      private void btnDelete_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.DB();
            var gen = MessageBox.Show("Remove to cart?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (gen == DialogResult.Yes)
            {
               Function.gen = "DELETE FROM CartDB WHERE UserId = '" + productid + "' ";
               Function.command = new SqlCommand(Function.gen, Connection.con);
               Function.command.ExecuteNonQuery();
               Connection.con.Close();
               clearFields();
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void setTotalPrice() 
      {
         try
         {
            Connection.DB();
            Function.gen = "SELECT * FROM CartDB WHERE userid = '"+ Login.userid +"' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
               Function.reader.Read();
               totalprice += Convert.ToDouble(Function.reader["productprice"]) * Convert.ToDouble(Function.reader["quantity"]);
               lblTotal.Text = "P" + totalprice.ToString();
            }
         }

         catch (Exception ex)
         {
            Connection.con.Close();
            MessageBox.Show(ex.Message);
         }
      }
   }
}
