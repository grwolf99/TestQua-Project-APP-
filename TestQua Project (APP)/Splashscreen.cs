using System;
using System.Windows.Forms;

namespace TestQua_Project__APP_
{
   public partial class Splashscreen : Form
   {
      public Splashscreen()
      {
         InitializeComponent();
      }

      private void label1_Click(object sender, EventArgs e)
      {

      }

      private void button1_Click(object sender, EventArgs e)
      {
         var homepage = new Homepage();
         homepage.Show();
         Hide();
      }
   }
}