using System;
using System.Windows.Forms;

namespace TestQua_Project__APP_
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new Splashscreen());
      }
   }
}
