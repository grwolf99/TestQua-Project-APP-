using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestQua_Project__APP_
{
   public class Function
   {
      public static string gen = ""; //variable to hold SQL statements
      public static SqlConnection con;
      public static SqlCommand command;
      public static SqlDataReader reader;

      public static void fill(string q, DataGridView dgv)
      {
         try
         {
            Connection.DB();
         }
         catch (Exception e)
         {
            MessageBox.Show(e.Message);
         }
      }
   }
}