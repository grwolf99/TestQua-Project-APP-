using System;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace TestQua_Project__APP_.Customer
{
   public partial class CustomerCheckout : Form
   {
      private ArrayList ProductIDs = new ArrayList();
      private ArrayList QuantityBought = new ArrayList();

      public CustomerCheckout()
      {
         InitializeComponent();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         var cart = new ViewCart();
         cart.Show();
         Close();
      }

      private void CustomerCheckout_Load(object sender, EventArgs e)
      {
         setUserInformation();
         setPayments();
         setViewCart();
      }

      private void setUserInformation()
      {
         lblFullName.Text = Login.firstname + " " + Login.lastname;
         lblContactnumber.Text = Login.contactnumber;
         lblAddress.Text = Login.address;
      }

      private void setPayments()
      {
         lblTotalpayment.Text = (ViewCart.TotalPrice + 80).ToString() + ".00";
         lblSubtotal.Text = ViewCart.TotalPrice.ToString() + ".00";
         lblDeliveryfee.Text = "80.00";
      }

      private void setViewCart()
      {
         Connection.DB();
         Function.gen = "SELECT cartdb.userid, cartdb.productid, productinformation.productname AS NAME, cartdb.quantity AS QUANTITY, (productinformation.productprice * cartdb.quantity) AS TOTAL from CartDb INNER JOIN ProductInformation ON CartDB.productid = ProductInformation.productid  WHERE userid = '" + Login.userid + "' ";
         Function.fill(Function.gen, dataGridView);
         dataGridView.Columns["userid"].Visible = false;
         dataGridView.Columns["productid"].Visible = false;
      }

      private void btnPlaceOrder_Click(object sender, EventArgs e)
      {
         try
         {
            setProductIDs();
            string productID = "";
            string quantity = "";

            for (int i = 0; i < ProductIDs.Count; i++)
            {
               if (i == ProductIDs.Count - 1)
               {
                  productID += ProductIDs[i].ToString();
                  quantity += QuantityBought[i].ToString();

                  Connection.DB();
                  Function.gen = "INSERT INTO OrdersDb(Userid, ProductId, QuantityBought, TotalPrice, TimeofTransaction) VALUES('" + Login.userid + "', '" + productID + "', '" + quantity + "', '" + (ViewCart.TotalPrice + 80) + "', '" + DateTime.Now.ToString() + "')";
                  Function.command = new SqlCommand(Function.gen, Connection.con);
                  Function.command.ExecuteNonQuery();
                  Connection.con.Close();
               }

               productID += ProductIDs[i].ToString() + ",";
               quantity += QuantityBought[i].ToString() + ",";
            }

            clearCart();
            MessageBox.Show("Thank you for your order!");
            var cart = new ViewCart();
            cart.Show();
            Close();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void clearCart()
      {
         try
         {
            Connection.DB();
            Function.gen = "DELETE FROM CartDB WHERE userid = '" + Login.userid + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            Connection.con.Close();

         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void setProductIDs()
      {
         try
         {
            Connection.DB();
            Function.gen = "SELECT * FROM CartDB WHERE userid = '" + Login.userid + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            while (Function.reader.HasRows && Function.reader.HasRows)
            {
               Function.reader.Read();
               ProductIDs.Add(Convert.ToInt32(Function.reader["ProductId"]));
               QuantityBought.Add(Convert.ToInt32(Function.reader["Quantity"]));
            }
         }

         catch (Exception ex)
         {
            //NONE
         }
      }
   }
}