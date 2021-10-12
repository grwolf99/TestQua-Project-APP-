
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
         this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.btnProduct = new System.Windows.Forms.Button();
         this.datagridViewProduct = new System.Windows.Forms.DataGridView();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.datagridViewProduct)).BeginInit();
         this.SuspendLayout();
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
         // btnProduct
         // 
         this.btnProduct.Location = new System.Drawing.Point(35, 0);
         this.btnProduct.Name = "btnProduct";
         this.btnProduct.Size = new System.Drawing.Size(75, 23);
         this.btnProduct.TabIndex = 3;
         this.btnProduct.Text = "add product";
         this.btnProduct.UseVisualStyleBackColor = true;
         this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
         // 
         // datagridViewProduct
         // 
         this.datagridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.datagridViewProduct.Location = new System.Drawing.Point(26, 29);
         this.datagridViewProduct.Name = "datagridViewProduct";
         this.datagridViewProduct.Size = new System.Drawing.Size(340, 376);
         this.datagridViewProduct.TabIndex = 0;
         // 
         // ViewProduct
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.btnProduct);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.flowLayoutPanel1);
         this.Controls.Add(this.datagridViewProduct);
         this.Name = "ViewProduct";
         this.Text = "ViewProduct";
         this.Load += new System.EventHandler(this.ViewProduct_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.datagridViewProduct)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Button btnProduct;
      private System.Windows.Forms.DataGridView datagridViewProduct;
   }
}