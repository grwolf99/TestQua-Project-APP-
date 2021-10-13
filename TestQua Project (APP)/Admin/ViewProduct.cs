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
      private Label price;
      private Label name;
      private Label description;
      private Label quantity;
      private Button button;
      double totalprice = 0;

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
         Function.gen = "SELECT * FROM ProductInformation";
         Function.command = new SqlCommand(Function.gen, Connection.con);
         Function.reader = Function.command.ExecuteReader();

         while (Function.reader.Read())
         {
            long len = Function.reader.GetBytes(4, 0, null, 0, 0);
            byte[] array = new byte[Convert.ToInt32(len + 1)];
            Function.reader.GetBytes(4, 0, array, 0, Convert.ToInt32(len));
            pic = new PictureBox();
            pic.Width = 300;
            pic.Height = 300;
            pic.BackgroundImageLayout = ImageLayout.Stretch;
            pic.Tag = Function.reader["productid"].ToString();

            price = new Label();
            name = new Label();
            description = new Label();

            name.Text = Function.reader["productname"].ToString();
            name.BackColor = Color.FromArgb(46, 134, 222);
            name.TextAlign = ContentAlignment.MiddleCenter;
            name.Dock = DockStyle.Top;
            name.Tag = Function.reader["productname"].ToString();

            price.Text = Function.reader["productprice"].ToString();
            price.BackColor = Color.FromArgb(46, 134, 222);
            price.Dock = DockStyle.Bottom;
            price.Tag = Function.reader["productprice"].ToString();

            MemoryStream ms = new MemoryStream(array);
            Bitmap bitmap = new Bitmap(ms);
            pic.BackgroundImage = bitmap;
            pic.Controls.Add(name);
            pic.Controls.Add(price);
            flowLayoutPanel1.Controls.Add(pic);

            pic.Click += new EventHandler(OnClick);
            //pic.Click += (sender, e) => OnClick(this, e, pic.Tag.ToString());
            //name.Click += (sender, e) => OnClick(this, e, pic.Tag.ToString());
            //price.Click += (sender, e) => OnClick(this, e, pic.Tag.ToString());
         }

         /*for (int i = 1; i < 15; i++)
         {
            button = new Button();
            button.Width = 274;
            button.Height = 50;
            button.Text = "Table " + i;
            button.BackgroundImageLayout = ImageLayout.Stretch;
         }*/

         flowLayoutPanel1.AutoScroll = true;
         Connection.con.Close();
      }

      public void OnClick(object sender, EventArgs e)
      {
         int productid =  Convert.ToInt32(((PictureBox)sender).Tag);
         //string productid =  ((PictureBox)sender).Tag.ToString();
         //MessageBox.Show(productid.ToString());
         
         Connection.DB();
         Function.gen = "SELECT * FROM ProductInformation WHERE productid = '"+ productid +"' ";
         Function.command = new SqlCommand(Function.gen, Connection.con);
         Function.reader = Function.command.ExecuteReader();

         if (Function.reader.HasRows)
         {
            //1400
            //MessageBox.Show("IM HERE");
            Function.reader.Read();
            datagridViewcart.Rows.Add(datagridViewcart.Rows.Count - 1 + 1, Function.reader["productid"].ToString(), Function.reader["productname"].ToString(), double.Parse(Function.reader["productprice"].ToString()).ToString("#, ##0.00"));
            totalprice += double.Parse(Function.reader["productprice"].ToString());
            lblTotalPrice.Text = totalprice.ToString("#, ##0.00");
         }

      }

      private void btnProduct_Click(object sender, EventArgs e)
      {
         var product = new AddProduct();
         product.Show();
      }
   }
}

/* 
 * youtube.com/watch?v=BAxmXu9FJos&t=557s
 * 
 * flowlayout event
 * youtube.com/watch?v=zjsK_4JHinE&t=263s
 * 
 * Search flowlayout
 * youtube.com/watch?v=WenNmob2oCo
 * 
 * 
 * 
 */
