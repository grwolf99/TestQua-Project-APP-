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

namespace TestQua_Project__APP_.Admin
{
   public partial class AddFromSupply : Form
   {
      private string imageLocation = "";
      private int Quantity = 0;
      private int SupplyQuantity;

      public AddFromSupply()
      {
         InitializeComponent();
      }

      private void AddFromSupply_Load(object sender, EventArgs e)
      {
         getFields();
      }

      private void getFields()
      {
         try
         {
            Connection.DB();
            Function.gen = "SELECT * FROM WarehouseDb WHERE ProductId = '" + AdminProduct.productid + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
               Function.reader.Read();
               lblName.Text = Function.reader["productname"].ToString();
               lblDescription.Text = Function.reader["productdescrip"].ToString();
               lblPrice.Text = Function.reader["productprice"].ToString();
               SupplyQuantity = Convert.ToInt32(Function.reader["quantity"]);
               lblQuantity.Text = Function.reader["quantity"].ToString();
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
            Quantity = Convert.ToInt32(numericQuantity.Value);

            if(Quantity > 0 && Quantity < SupplyQuantity + 1)
            {
               byte[] img = null;
               FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
               BinaryReader br = new BinaryReader(fs);
               img = br.ReadBytes((int)fs.Length);

               Connection.DB();
               Function.gen = "INSERT INTO Products(ProductName, ProductDescrip, ProductPrice, ProductImage, Quantity, TImeStored) VALUES('" + lblName.Text + "', '" + lblDescription.Text + "', '" + lblPrice.Text + "', @img, '" + Quantity + "', '" + DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt") + "' )";
               Function.command = new SqlCommand(Function.gen, Connection.con);
               Function.command.Parameters.Add(new SqlParameter("@img", img));
               Function.command.ExecuteNonQuery();
               MessageBox.Show("Success.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
               Connection.con.Close();

               //I need a new GUI for add/minus of quantity for all forms
               Connection.DB();
               Function.gen = "UPDATE WarehouseDbb SET  quantity = '" + (SupplyQuantity - (SupplyQuantity - Quantity)) + "' WHERE productid = '" + AdminProduct.productid + "' ";
               Function.command = new SqlCommand(Function.gen, Connection.con);
               Function.command.ExecuteNonQuery();
               MessageBox.Show("Update success.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
               Connection.con.Close();
            }
            else
            {
               numericQuantity.ResetText();
               MessageBox.Show("Quantity out of range, please redo");
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnClose_Click(object sender, EventArgs e)
      {
         var adminproduct = new AdminProduct();
         adminproduct.Show();
         adminproduct.tabcontrolAdminProducts.SelectedIndex = 2;
         Close();
      }

      private void numericQuantity_ValueChanged(object sender, EventArgs e)
      {

      }
   }
}
