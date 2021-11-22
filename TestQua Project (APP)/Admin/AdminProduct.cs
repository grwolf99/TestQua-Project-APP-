using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Admin
{
   public partial class AdminProduct : Form
   {
      string imageLocation = "";
      public static int productid;

      public AdminProduct()
      {
         InitializeComponent();
      }

      private void btnBrowse_Click(object sender, EventArgs e)
      {
         try
         {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|PNG Files (*.png)|*.png| All Files (*.*)|*.*";
            dlg.Title = "Select Product Picture";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
               imageLocation = dlg.FileName.ToString();
               pictureboxProductPic.ImageLocation = imageLocation;
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnUpdatePic_Click(object sender, EventArgs e)
      {
         try
         {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|PNG Files (*.png)|*.png| All Files (*.*)|*.*";
            dlg.Title = "Select Product Picture";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
               imageLocation = dlg.FileName.ToString();
               pictureboxProductPic.ImageLocation = imageLocation;
            }

            byte[] img = null;
            FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);

            Connection.DB();
            Function.gen = "UPDATE ProductInformation SET productimage = @img WHERE productid = '" + txtProductId.Text + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.Parameters.Add(new SqlParameter("@img", img));
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Update success.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();
            clearFields();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void AdminProduct_Load(object sender, EventArgs e)
      {
         ViewProducts();
         btnProducts.FlatStyle = FlatStyle.Standard;
         ViewWarehouse();
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         try
         {
            byte[] img = null;
            FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);

            Connection.DB();
            Function.gen = "INSERT INTO ProductInformation(ProductName, ProductDescrip, ProductPrice, ProductImage, Quantity, TImeStored) VALUES('" + txtProductName.Text + "', '" + txtProductDescription.Text + "', '" + txtPrice.Text + "', @img, '" + txtQuantity.Text + "', '" + DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt") + "' )";
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

      private void btnUpdate_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.DB();
            Function.gen = "UPDATE ProductInformation SET productname = '" + txtProductName.Text + "', productdescrip = '" + txtProductDescription.Text + "', productprice = '" + txtPrice.Text + "', quantity = '" + txtQuantity.Text + "' WHERE productid = '" + txtProductId.Text + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Update success.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();
            ViewProducts();
            clearFields();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnDelete_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.DB();
            var gen = MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (gen == DialogResult.Yes)
            {
               Function.gen = "DELETE FROM ProductInformation WHERE UserId = '" + txtProductId.Text + "' ";
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

      private void ViewProducts()
      {
         Connection.DB();
         Function.gen = "SELECT * from ProductInformation";
         Function.fill(Function.gen, datagridViewProduct);
      }

      private void ViewWarehouse()
      {
         Connection.DB();
         Function.gen = "SELECT * from Warehousedb";
         Function.fill(Function.gen, datagridViewWarehouse);
      }

      private void datagridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {
         txtProductId.Text = datagridViewProduct[0, e.RowIndex].Value.ToString();
         txtProductName.Text = datagridViewProduct[1, e.RowIndex].Value.ToString();
         txtProductDescription.Text = datagridViewProduct[2, e.RowIndex].Value.ToString();
         txtPrice.Text = datagridViewProduct[3, e.RowIndex].Value.ToString();
         txtQuantity.Text = datagridViewProduct[5, e.RowIndex].Value.ToString();
         byte[] img = (byte[])(datagridViewProduct[4, e.RowIndex].Value);

         if (img == null)
         {
            pictureboxProductPic.Image = null;
         }
         else
         {
            MemoryStream ms = new MemoryStream(img);
            pictureboxProductPic.Image = Image.FromStream(ms);
         }

         tabcontrolAdminProducts.SelectedIndex = 0;
      }

      private void btnHome_Click(object sender, EventArgs e)
      {
         var adminhome = new AdminHome();
         adminhome.Show();
         Close();
      }

      private void btnAccounts_Click(object sender, EventArgs e)
      {
         var adminaccounts = new AdminAccounts();
         adminaccounts.Show();
         Close();
      }

      private void btnReports_Click(object sender, EventArgs e)
      {
         var report = new AdminReport();
         report.Show();
         Close();
      }

      private void btnLogout_Click(object sender, EventArgs e)
      {
         var home = new Homepage();
         home.Show();
         Close();
      }

      private void clearFields()
      {
         txtProductId.Clear();
         txtProductName.Clear();
         txtProductDescription.Clear();
         txtPrice.Clear();
         txtQuantity.Clear();
         pictureboxProductPic.Dispose();
      }

      private void btnProducts_Click(object sender, EventArgs e)
      {
         var adminproduct = new AdminProduct();
         adminproduct.Show();
         Close();
      }

      private void txtSearchWarehouse_TextChanged(object sender, EventArgs e)
      {
         //to be added later
      }

      private void datagridViewWarehouse_CellClick(object sender, DataGridViewCellEventArgs e)
      {
         productid = Convert.ToInt32(datagridViewWarehouse.Rows[e.RowIndex].Cells["ProductId"].Value);
         var addsupply = new AddFromSupply();
         addsupply.Show();
         Close();
         //Pass those fields to AddFromSupply form then INSERT ProductInfo DB
      }
   }
}
