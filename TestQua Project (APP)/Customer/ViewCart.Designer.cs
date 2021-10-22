
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
         this.btnBack = new System.Windows.Forms.Button();
         this.btnCheckout = new System.Windows.Forms.Button();
         this.btnDelete = new System.Windows.Forms.Button();
         this.button1 = new System.Windows.Forms.Button();
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
         // btnBack
         // 
         this.btnBack.Location = new System.Drawing.Point(46, 33);
         this.btnBack.Name = "btnBack";
         this.btnBack.Size = new System.Drawing.Size(75, 23);
         this.btnBack.TabIndex = 1;
         this.btnBack.Text = "Back";
         this.btnBack.UseVisualStyleBackColor = true;
         this.btnBack.Click += new System.EventHandler(this.button1_Click);
         // 
         // btnCheckout
         // 
         this.btnCheckout.Location = new System.Drawing.Point(284, 590);
         this.btnCheckout.Name = "btnCheckout";
         this.btnCheckout.Size = new System.Drawing.Size(75, 23);
         this.btnCheckout.TabIndex = 2;
         this.btnCheckout.Text = "Checkout";
         this.btnCheckout.UseVisualStyleBackColor = true;
         this.btnCheckout.Click += new System.EventHandler(this.button2_Click);
         // 
         // btnDelete
         // 
         this.btnDelete.Location = new System.Drawing.Point(684, 429);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Size = new System.Drawing.Size(75, 23);
         this.btnDelete.TabIndex = 3;
         this.btnDelete.Text = "Delete";
         this.btnDelete.UseVisualStyleBackColor = true;
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(579, 428);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 4;
         this.button1.Text = "button1";
         this.button1.UseVisualStyleBackColor = true;
         // 
         // ViewCart
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(7)))), ((int)(((byte)(48)))));
         this.ClientSize = new System.Drawing.Size(1087, 664);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.btnDelete);
         this.Controls.Add(this.btnCheckout);
         this.Controls.Add(this.btnBack);
         this.Controls.Add(this.datagridViewCart);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "ViewCart";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "ViewCart";
         this.Load += new System.EventHandler(this.ViewCart_Load);
         ((System.ComponentModel.ISupportInitialize)(this.datagridViewCart)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataGridView datagridViewCart;
      private System.Windows.Forms.Button btnBack;
      private System.Windows.Forms.Button btnCheckout;
      private System.Windows.Forms.Button btnDelete;
      private System.Windows.Forms.Button button1;
   }
}