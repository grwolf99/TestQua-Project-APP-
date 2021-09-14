
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
         this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         ((System.ComponentModel.ISupportInitialize)(this.datagridViewProduct)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // datagridViewProduct
         // 
         this.datagridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.datagridViewProduct.Location = new System.Drawing.Point(26, 29);
         this.datagridViewProduct.Name = "datagridViewProduct";
         this.datagridViewProduct.Size = new System.Drawing.Size(340, 376);
         this.datagridViewProduct.TabIndex = 0;
         // 
         // flowLayoutPanel1
         // 
         this.flowLayoutPanel1.Location = new System.Drawing.Point(398, 29);
         this.flowLayoutPanel1.Name = "flowLayoutPanel1";
         this.flowLayoutPanel1.Size = new System.Drawing.Size(380, 376);
         this.flowLayoutPanel1.TabIndex = 1;
         // 
         // pictureBox1
         // 
         this.pictureBox1.Location = new System.Drawing.Point(337, 411);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(65, 27);
         this.pictureBox1.TabIndex = 2;
         this.pictureBox1.TabStop = false;
         // 
         // ViewProduct
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.flowLayoutPanel1);
         this.Controls.Add(this.datagridViewProduct);
         this.Name = "ViewProduct";
         this.Text = "ViewProduct";
         this.Load += new System.EventHandler(this.ViewProduct_Load);
         ((System.ComponentModel.ISupportInitialize)(this.datagridViewProduct)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataGridView datagridViewProduct;
      private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
      private System.Windows.Forms.PictureBox pictureBox1;
   }
}