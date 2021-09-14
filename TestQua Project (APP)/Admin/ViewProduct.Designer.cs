
namespace TestQua_Project__APP_.Admin
{
   partial class ViewProduct
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
         this.datagridViewProduct = new System.Windows.Forms.DataGridView();
         ((System.ComponentModel.ISupportInitialize)(this.datagridViewProduct)).BeginInit();
         this.SuspendLayout();
         // 
         // datagridViewProduct
         // 
         this.datagridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.datagridViewProduct.Location = new System.Drawing.Point(145, 102);
         this.datagridViewProduct.Name = "datagridViewProduct";
         this.datagridViewProduct.Size = new System.Drawing.Size(523, 268);
         this.datagridViewProduct.TabIndex = 0;
         // 
         // ViewProduct
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.datagridViewProduct);
         this.Name = "ViewProduct";
         this.Text = "ViewProduct";
         this.Load += new System.EventHandler(this.ViewProduct_Load);
         ((System.ComponentModel.ISupportInitialize)(this.datagridViewProduct)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataGridView datagridViewProduct;
   }
}