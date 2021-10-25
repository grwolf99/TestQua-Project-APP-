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

namespace TestQua_Project__APP_.Customer
{
   public partial class ViewOrders : Form
   {
      public ViewOrders()
      {
         InitializeComponent();
      }

      private void ViewOrders_Load(object sender, EventArgs e)
      {
         setOrderInfo();
      }

      private void setOrderInfo()
      {
         try
         {
            for (int i = 0; i < CustomerOrder.ProductIDs.Count; i++)
            {
               Connection.DB();
               Function.gen = "SELECT * FROM ProductInformation WHERE productid = '"+ CustomerOrder.ProductIDs[i] +"' ";
               Function.command = new SqlCommand(Function.gen, Connection.con);
               Function.reader = Function.command.ExecuteReader();

               if (Function.reader.HasRows)
               {
                  Function.reader.Read();
                  dataGridViewOrder.Rows.Add(dataGridViewOrder.Rows.Count - 1 + 1, Function.reader["ProductName"].ToString(), CustomerOrder.QuantityBought[i], (Convert.ToDouble(Function.reader["productprice"]) * Convert.ToDouble(CustomerOrder.QuantityBought[i])).ToString() + ".00");
               }
            }

            dataGridViewOrder.Rows.Add(" ", "Delivery Fee", "", "80.00");
            dataGridViewOrder.Rows.Add(" ", " ", " ", CustomerOrder.TotalPrice.ToString() + ".00");
            dataGridViewOrder.AllowUserToAddRows = false;
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void button1_Click(object sender, EventArgs e)
      {
         Close();
      }
   }
}