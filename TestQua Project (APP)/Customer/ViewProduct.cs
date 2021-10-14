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
      public ViewProduct()
      {
         InitializeComponent();
      }

      private void ViewProduct_Load(object sender, EventArgs e)
      {
         getProductInformation();
      }

      private void btnClose_Click(object sender, EventArgs e)
      {
         Close();
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
         Connection.DB();
         Function.gen = "SELECT * FROM CartDb WHERE productid = '" + productid + "' AND userid ";
         Function.command = new SqlCommand(Function.gen, Connection.con);
         Function.reader = Function.command.ExecuteReader();
      }
   }
}
