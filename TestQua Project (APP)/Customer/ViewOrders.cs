﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Customer
{
   public partial class ViewOrders : Form
   {
      private string Status = CustomerOrder.Status;
      public ViewOrders()
      {
         InitializeComponent();
      }

      private void ViewOrders_Load(object sender, EventArgs e)
      {
         setOrderInfo();
         txtStatus.Text = CustomerOrder.Status;
         setButtonVisibility();
      }

      private void setButtonVisibility()
      {
         if (CustomerOrder.Status == "Shipped Out")
         {
            btnOrderReceived.Visible = true;
            btnReturn.Visible = true;
         }
         else 
         {
            btnOrderReceived.Visible = false;
            btnReturn.Visible = false;
         }
      }

      private void setOrderInfo()
      {
         try
         {
            for (int i = 0; i < CustomerOrder.ProductIDs.Count; i++)
            {
               Connection.DB();
               Function.gen = "SELECT * FROM ProductInformation WHERE productid = '" + CustomerOrder.ProductIDs[i] + "' ";
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
         var customerorder = new CustomerOrder();
         customerorder.Show();
         Close();
      }

      private void btnOrderReceived_Click(object sender, EventArgs e)
      {
         updateStatus("Order Received");
      }

      private void btnReturn_Click(object sender, EventArgs e)
      {
         updateStatus("Return");
      }

      private void updateStatus(string status)
      {
         try
         {
            var gen = MessageBox.Show("Are you sure you want to update the status of this order?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (gen == DialogResult.Yes)
            {
               Connection.DB();
               Function.gen = "UPDATE OrdersDb SET status = '" + status + "' WHERE OrderId = '" + CustomerOrder.OrderId + "' ";
               Function.command = new SqlCommand(Function.gen, Connection.con);
               Function.command.ExecuteNonQuery();
               MessageBox.Show("Update success.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
               Connection.con.Close();

               btnOrderReceived.Enabled = false;
               btnReturn.Enabled = false;
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
   }
}
