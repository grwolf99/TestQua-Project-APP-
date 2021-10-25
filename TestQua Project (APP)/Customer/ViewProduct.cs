using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Customer
{
   public partial class ViewProduct : Form
   {
      private int productid = CustomerProduct.productid;
      private int userid = Login.userid;
      private int quantity = 0;
      private int setMax = 0;
      private int setMin = 0;
      private int newQuantity = 0;
      private int previousQuantity = 0;
      private int ProductQuantity = 0;
      private int setQuantity = 0;
      public ViewProduct()
      {
         InitializeComponent();
      }

      private void ViewProduct_Load(object sender, EventArgs e)
      {
         getProductInformation();
         setNumericUpandDown();
      }

      private void btnClose_Click(object sender, EventArgs e)
      {
         var customerproduct = new CustomerProduct();
         customerproduct.Show();
         Close();
      }

      private void setNumericUpandDown()
      {
         numericUpandDown_Quantity.Minimum = setMin;
         numericUpandDown_Quantity.Maximum = setMax;
      }

      private void getProductInformation()
      {
         try
         {
            Connection.DB();
            Function.gen = "SELECT * FROM ProductInformation WHERE ProductId = '" + productid + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
               Function.reader.Read();
               lblName.Text = Function.reader["productname"].ToString();
               lblDescription.Text = Function.reader["productdescrip"].ToString();
               lblPrice.Text = Function.reader["productprice"].ToString();
               lblQuantity.Text = Function.reader["quantity"].ToString();
               setMax = Convert.ToInt32(Function.reader["quantity"]);
               ProductQuantity = Convert.ToInt32(Function.reader["quantity"]);
               byte[] img = (byte[])(Function.reader[4]);

               if (img == null)
               {
                  pictureboxProductPic.Image = null;
               }
               else
               {
                  MemoryStream ms = new MemoryStream(img);
                  pictureboxProductPic.Image = Image.FromStream(ms);
               }
            }

            pictureboxProductPic.BackgroundImageLayout = ImageLayout.Stretch;
            Connection.con.Close();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnAddtoCart_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.DB();
            Function.gen = "SELECT * FROM CartDb WHERE productid = '" + productid + "' AND userid = '" + userid + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows) //UPDATE
            {
               Function.reader.Read();
               quantity = Convert.ToInt32(Function.reader["quantity"]);
               previousQuantity = quantity;
               newQuantity = quantity + Convert.ToInt32(numericUpandDown_Quantity.Value);

               Connection.con.Close();
               Connection.DB();
               Function.gen = "UPDATE CartDb SET Quantity = '" + newQuantity + "' WHERE productid = '" + productid + "' AND userid = '" + userid + "' ";
               Function.command = new SqlCommand(Function.gen, Connection.con);
               Function.command.ExecuteNonQuery();
               MessageBox.Show("Cart Updated");
            }
            else
            {
               Connection.con.Close();
               Connection.DB();
               Function.gen = "INSERT INTO CartDb(userid, productid, quantity, checker) VALUES('"+ userid +"', '"+ productid + "', '"+ numericUpandDown_Quantity.Value +"', '"+ 1 +"' )";
               Function.command = new SqlCommand(Function.gen, Connection.con);
               Function.command.ExecuteNonQuery();
               MessageBox.Show("Added to Cart");
            }
            
            Connection.con.Close();
            Connection.DB();
            setQuantity = ProductQuantity - (newQuantity - previousQuantity);
            Function.gen = "UPDATE ProductInformation SET Quantity = '" + setQuantity + "' WHERE productid = '" + productid + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            Connection.con.Close();

            lblQuantity.Text = setQuantity.ToString();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
   }
}
