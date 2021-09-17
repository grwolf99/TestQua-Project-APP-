
namespace TestQua_Project__APP_
{
   partial class Login
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.datagridTestingUser = new System.Windows.Forms.DataGridView();
         ((System.ComponentModel.ISupportInitialize)(this.datagridTestingUser)).BeginInit();
         this.SuspendLayout();
         // 
         // datagridTestingUser
         // 
         this.datagridTestingUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.datagridTestingUser.Location = new System.Drawing.Point(133, 93);
         this.datagridTestingUser.Name = "datagridTestingUser";
         this.datagridTestingUser.Size = new System.Drawing.Size(495, 270);
         this.datagridTestingUser.TabIndex = 0;
         // 
         // Login
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.datagridTestingUser);
         this.Name = "Login";
         this.Text = "Login";
         this.Load += new System.EventHandler(this.Login_Load);
         ((System.ComponentModel.ISupportInitialize)(this.datagridTestingUser)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataGridView datagridTestingUser;
   }
}