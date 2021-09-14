using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestQua_Project__APP_.Admin
{
   public partial class ViewProduct : Form
   {
      private PictureBox pic = new PictureBox();

      public ViewProduct()
      {
         InitializeComponent();
      }

      private void ViewProduct_Load(object sender, EventArgs e)
      {
         viewDataProduct();
         flowlayoutViewProdcut();
      }

      private void viewDataProduct()
      {
         Connection.DB();
         Function.gen = "SELECT * from ProductInformation";
         Function.fill(Function.gen, datagridViewProduct);
      }

      private void flowlayoutViewProdcut()
      {
         Connection.DB();
         Function.gen = "SELECT ProductImage FROM ProductInformation";
         Function.command = new SqlCommand(Function.gen, Connection.con);
         Function.reader = Function.command.ExecuteReader();

         while (Function.reader.Read())
         {
            long len = Function.reader.GetBytes(0, 0, null, 0, 0);
            byte[] array = new byte[Convert.ToInt32(len + 1)];
            Function.reader.GetBytes(0, 0, array, 0, Convert.ToInt32(len));
            pic = new PictureBox();
            pic.Width = 100;
            pic.Height = 100;
            pic.BackgroundImageLayout = ImageLayout.Stretch;

            MemoryStream ms = new MemoryStream(array);
            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(ms);
            pic.BackgroundImage = bitmap; 

            flowLayoutPanel1.Controls.Add(pic);
         }

         Connection.con.Close();
      }
   }
}

/* 
 * youtube.com/watch?v=BAxmXu9FJos&t=557s
 * 
 * flowlayout event
 * youtube.com/watch?v=2p3MYYOhVmg
 * 
 * Search flowlayout
 * youtube.com/watch?v=WenNmob2oCo
 * 
 * 
 * 
 */
