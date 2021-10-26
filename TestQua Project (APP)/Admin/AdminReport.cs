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

namespace TestQua_Project__APP_.Admin
{
   public partial class AdminReport : Form
   {
      public AdminReport()
      {
         InitializeComponent();
      }

      private void AdminReport_Load(object sender, EventArgs e)
      {
         btnReports.FlatStyle = FlatStyle.Standard;
         viewOrdersDb();
         setTotalSales();
      }

      private void setTotalSales()
      {
         try
         {
            Connection.DB();
            Function.gen = "SELECT SUM(TotalPrice) as TOTAL FROM OrdersDb ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
               Function.reader.Read();
               lblTotalSales.Text = Function.reader["TOTAL"].ToString() + ".00";
            }
         }

         catch (Exception ex)
         {
            Connection.con.Close();
            lblTotalSales.Text = "0";
         }
      }

      private void viewOrdersDb()
      {
         Connection.DB();
         Function.gen = "SELECT * FROM OrdersDB";
         Function.fill(Function.gen, dataGridView1);
      }

      private void btnHome_Click(object sender, EventArgs e)
      {
         var home = new AdminHome();
         home.Show();
         Close();
      }

      private void btnAccounts_Click(object sender, EventArgs e)
      {
         var account = new AdminAccounts();
         account.Show();
         Close();
      }

      private void btnProducts_Click(object sender, EventArgs e)
      {
         var product = new AdminProduct();
         product.Show();
         Close();
      }

      private void btnLogout_Click(object sender, EventArgs e)
      {
         var logout = new Homepage();
         logout.Show();
         Close();
      }
   }
}
