﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProduct));
            this.btnClose = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpandDown_Quantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureboxProductPic = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpandDown_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxProductPic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Plum;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 47);
            this.btnClose.TabIndex = 44;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnAddtoCart.BackColor = System.Drawing.Color.Plum;
            this.btnAddtoCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddtoCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddtoCart.Location = new System.Drawing.Point(423, 474);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(170, 31);
            this.btnAddtoCart.TabIndex = 61;
            this.btnAddtoCart.Text = "Add to cart";
            this.btnAddtoCart.UseVisualStyleBackColor = false;
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.numericUpandDown_Quantity);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblQuantity);
            this.panel2.Controls.Add(this.lblDescription);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Location = new System.Drawing.Point(334, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 397);
            this.panel2.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(24, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 31);
            this.label4.TabIndex = 69;
            this.label4.Text = "Quantiy:";
            // 
            // numericUpandDown_Quantity
            // 
            this.numericUpandDown_Quantity.Location = new System.Drawing.Point(100, 342);
            this.numericUpandDown_Quantity.Name = "numericUpandDown_Quantity";
            this.numericUpandDown_Quantity.Size = new System.Drawing.Size(120, 20);
            this.numericUpandDown_Quantity.TabIndex = 65;
            this.numericUpandDown_Quantity.ValueChanged += new System.EventHandler(this.numericUpandDown_Quantity_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(21, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 31);
            this.label3.TabIndex = 68;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(24, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 31);
            this.label2.TabIndex = 67;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 31);
            this.label1.TabIndex = 66;
            this.label1.Text = "Product Name:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblQuantity.ForeColor = System.Drawing.Color.Indigo;
            this.lblQuantity.Location = new System.Drawing.Point(146, 293);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(100, 29);
            this.lblQuantity.TabIndex = 65;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblDescription.ForeColor = System.Drawing.Color.Indigo;
            this.lblDescription.Location = new System.Drawing.Point(25, 158);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(135, 29);
            this.lblDescription.TabIndex = 63;
            this.lblDescription.Text = "Description";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblPrice.ForeColor = System.Drawing.Color.Indigo;
            this.lblPrice.Location = new System.Drawing.Point(146, 251);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(69, 29);
            this.lblPrice.TabIndex = 64;
            this.lblPrice.Text = "Price";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblName.ForeColor = System.Drawing.Color.Indigo;
            this.lblName.Location = new System.Drawing.Point(26, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 29);
            this.lblName.TabIndex = 63;
            this.lblName.Text = "Name";
            // 
            // pictureboxProductPic
            // 
            this.pictureboxProductPic.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxProductPic.Image")));
            this.pictureboxProductPic.Location = new System.Drawing.Point(23, 105);
            this.pictureboxProductPic.Name = "pictureboxProductPic";
            this.pictureboxProductPic.Size = new System.Drawing.Size(264, 269);
            this.pictureboxProductPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxProductPic.TabIndex = 86;
            this.pictureboxProductPic.TabStop = false;
            // 
            // ViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(203)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(986, 538);
            this.Controls.Add(this.pictureboxProductPic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAddtoCart);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewProduct";
            this.Load += new System.EventHandler(this.ViewProduct_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpandDown_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxProductPic)).EndInit();
            this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.Button btnClose;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button btnAddtoCart;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Label lblQuantity;
      private System.Windows.Forms.Label lblDescription;
      private System.Windows.Forms.Label lblPrice;
      private System.Windows.Forms.Label lblName;
      private System.Windows.Forms.NumericUpDown numericUpandDown_Quantity;
        private System.Windows.Forms.PictureBox pictureboxProductPic;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
   }
}