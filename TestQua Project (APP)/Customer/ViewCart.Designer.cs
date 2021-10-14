
namespace TestQua_Project__APP_.Customer
{
   partial class ViewCart
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
         this.datagridViewCart = new System.Windows.Forms.DataGridView();
         ((System.ComponentModel.ISupportInitialize)(this.datagridViewCart)).BeginInit();
         this.SuspendLayout();
         // 
         // datagridViewCart
         // 
         this.datagridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.datagridViewCart.Location = new System.Drawing.Point(93, 64);
         this.datagridViewCart.Name = "datagridViewCart";
         this.datagridViewCart.Size = new System.Drawing.Size(562, 282);
         this.datagridViewCart.TabIndex = 0;
         // 
         // ViewCart
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.datagridViewCart);
         this.Name = "ViewCart";
         this.Text = "ViewCart";
         this.Load += new System.EventHandler(this.ViewCart_Load);
         ((System.ComponentModel.ISupportInitialize)(this.datagridViewCart)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataGridView datagridViewCart;
   }
}