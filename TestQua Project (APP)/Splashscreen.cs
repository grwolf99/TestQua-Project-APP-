using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestQua_Project__APP_
{
    public partial class Splashscreen : Form
    {
        public Splashscreen()
        {
            InitializeComponent();
        }

      private void timer1_Tick(object sender, EventArgs e)
      {
         timer1.Enabled = true;
         progressBar1.Increment(5);
         
         if (progressBar1.Value == 100)
         {
            timer1.Enabled = false;
            var homepage = new Homepage();
            homepage.Show();
            Hide();
         }
      }
   }
}
