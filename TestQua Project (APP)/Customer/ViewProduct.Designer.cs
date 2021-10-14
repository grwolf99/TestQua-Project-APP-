
namespace TestQua_Project__APP_.Customer
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
         this.btnClose = new System.Windows.Forms.Button();
         this.pictureboxProductPic = new System.Windows.Forms.PictureBox();
         this.button2 = new System.Windows.Forms.Button();
         this.btnAddtoCart = new System.Windows.Forms.Button();
         this.panel2 = new System.Windows.Forms.Panel();
         this.lblName = new System.Windows.Forms.Label();
         this.lblPrice = new System.Windows.Forms.Label();
         this.lblDescription = new System.Windows.Forms.Label();
         this.lblQuantity = new System.Windows.Forms.Label();
         this.numericUpandDown_Quantity = new System.Windows.Forms.NumericUpDown();
         ((System.ComponentModel.ISupportInitialize)(this.pictureboxProductPic)).BeginInit();
         this.panel2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpandDown_Quantity)).BeginInit();
         this.SuspendLayout();
         // 
         // btnClose
         // 
         this.btnClose.Location = new System.Drawing.Point(12, 12);
         this.btnClose.Name = "btnClose";
         this.btnClose.Size = new System.Drawing.Size(75, 23);
         this.btnClose.TabIndex = 44;
         this.btnClose.Text = "Close";
         this.btnClose.UseVisualStyleBackColor = true;
         this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
         // 
         // pictureboxProductPic
         // 
         this.pictureboxProductPic.Location = new System.Drawing.Point(12, 71);
         this.pictureboxProductPic.Name = "pictureboxProductPic";
         this.pictureboxProductPic.Size = new System.Drawing.Size(303, 334);
         this.pictureboxProductPic.TabIndex = 45;
         this.pictureboxProductPic.TabStop = false;
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(904, 590);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(75, 23);
         this.button2.TabIndex = 46;
         this.button2.Text = "Add to cart";
         this.button2.UseVisualStyleBackColor = true;
         // 
         // btnAddtoCart
         // 
         this.btnAddtoCart.Location = new System.Drawing.Point(365, 492);
         this.btnAddtoCart.Name = "btnAddtoCart";
         this.btnAddtoCart.Size = new System.Drawing.Size(89, 31);
         this.btnAddtoCart.TabIndex = 61;
         this.btnAddtoCart.Text = "Add to cart";
         this.btnAddtoCart.UseVisualStyleBackColor = true;
         this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
         // 
         // panel2
         // 
         this.panel2.Controls.Add(this.lblQuantity);
         this.panel2.Controls.Add(this.lblDescription);
         this.panel2.Controls.Add(this.lblPrice);
         this.panel2.Controls.Add(this.lblName);
         this.panel2.Location = new System.Drawing.Point(334, 71);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(344, 397);
         this.panel2.TabIndex = 62;
         // 
         // lblName
         // 
         this.lblName.AutoSize = true;
         this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblName.ForeColor = System.Drawing.Color.White;
         this.lblName.Location = new System.Drawing.Point(54, 67);
         this.lblName.Name = "lblName";
         this.lblName.Size = new System.Drawing.Size(92, 31);
         this.lblName.TabIndex = 63;
         this.lblName.Text = "NAME";
         // 
         // lblPrice
         // 
         this.lblPrice.AutoSize = true;
         this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblPrice.ForeColor = System.Drawing.Color.White;
         this.lblPrice.Location = new System.Drawing.Point(25, 209);
         this.lblPrice.Name = "lblPrice";
         this.lblPrice.Size = new System.Drawing.Size(76, 31);
         this.lblPrice.TabIndex = 64;
         this.lblPrice.Text = "Price";
         // 
         // lblDescription
         // 
         this.lblDescription.AutoSize = true;
         this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblDescription.ForeColor = System.Drawing.Color.White;
         this.lblDescription.Location = new System.Drawing.Point(25, 131);
         this.lblDescription.Name = "lblDescription";
         this.lblDescription.Size = new System.Drawing.Size(151, 31);
         this.lblDescription.TabIndex = 63;
         this.lblDescription.Text = "Description";
         // 
         // lblQuantity
         // 
         this.lblQuantity.AutoSize = true;
         this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblQuantity.ForeColor = System.Drawing.Color.White;
         this.lblQuantity.Location = new System.Drawing.Point(40, 303);
         this.lblQuantity.Name = "lblQuantity";
         this.lblQuantity.Size = new System.Drawing.Size(116, 31);
         this.lblQuantity.TabIndex = 65;
         this.lblQuantity.Text = "Quantity";
         // 
         // numericUpandDown_Quantity
         // 
         this.numericUpandDown_Quantity.Location = new System.Drawing.Point(195, 499);
         this.numericUpandDown_Quantity.Name = "numericUpandDown_Quantity";
         this.numericUpandDown_Quantity.Size = new System.Drawing.Size(120, 20);
         this.numericUpandDown_Quantity.TabIndex = 65;
         // 
         // ViewProduct
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(7)))), ((int)(((byte)(48)))));
         this.ClientSize = new System.Drawing.Size(689, 561);
         this.Controls.Add(this.numericUpandDown_Quantity);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.btnAddtoCart);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.pictureboxProductPic);
         this.Controls.Add(this.btnClose);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "ViewProduct";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "ViewProduct";
         this.Load += new System.EventHandler(this.ViewProduct_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pictureboxProductPic)).EndInit();
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpandDown_Quantity)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.Button btnClose;
      private System.Windows.Forms.PictureBox pictureboxProductPic;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button btnAddtoCart;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Label lblQuantity;
      private System.Windows.Forms.Label lblDescription;
      private System.Windows.Forms.Label lblPrice;
      private System.Windows.Forms.Label lblName;
      private System.Windows.Forms.NumericUpDown numericUpandDown_Quantity;
   }
}