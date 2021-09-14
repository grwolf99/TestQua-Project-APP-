using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.IO;
using System.Data.SqlClient;

namespace TestQua_Project__APP_.Admin
{
   public partial class AddProduct : Form
   {
      string imageLocation = "";

      public AddProduct()
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
               pictureBox.ImageLocation = imageLocation;
            }
         }
         
         catch(Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
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
            Function.gen = "INSERT INTO ProductInformation(ProductName, ProductDescrip, ProductPrice, ProductImage)VALUES('"+ txtbProductName.Text +"', '"+ txtbProductDescription.Text + "', '" + txtbProductPrice.Text +"', @img)";

            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.Parameters.Add(new SqlParameter("@img", img));
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Registration success.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
   }
}
