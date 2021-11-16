using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Guest
{
   public partial class GuestSelectProduct : Form
   {
      private int productid = GuestViewProduct.productid;
      public GuestSelectProduct()
      {
         InitializeComponent();
      }

      private void btnClose_Click(object sender, EventArgs e)
      {
         var guestprod = new GuestViewProduct();
         guestprod.Show();
         Close();
      }

      private void getProducts()
      {
         try
         {
            Connection.DB();
            Function.gen = "SELECT * FROM Products WHERE ProductId = '" + productid + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
               Function.reader.Read();
               lblName.Text = Function.reader["productname"].ToString();
               lblDescription.Text = Function.reader["productdescrip"].ToString();
               lblPrice.Text = Function.reader["productprice"].ToString();
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

      private void GuestSelectProduct_Load(object sender, EventArgs e)
      {
         getProducts();
      }
   }
}
