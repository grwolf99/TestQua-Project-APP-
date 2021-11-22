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

      public AddFromSupply()
      {
         InitializeComponent();
      }

      private void AddFromSupply_Load(object sender, EventArgs e)
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
               lblQuantity.Text = Function.reader["quantity"].ToString();
               //setMax = Convert.ToInt32(Function.reader["quantity"]);
               //ProductQuantity = Convert.ToInt32(Function.reader["quantity"]);
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

      private void getFields()
      { 
         
      }

      private void btnAddtoCart_Click(object sender, EventArgs e)
      {
         try
         {
            byte[] img = null;
            FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);

            Connection.DB();
            Function.gen = "INSERT INTO ProductInformation(ProductName, ProductDescrip, ProductPrice, ProductImage, Quantity, TImeStored) VALUES('" + lblName.Text + "', '" + lblDescription.Text + "', '" + lblPrice.Text + "', @img, '" + lblQuantity.Text + "', '" + DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt") + "' )";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.Parameters.Add(new SqlParameter("@img", img));
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Success.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
   }
}
