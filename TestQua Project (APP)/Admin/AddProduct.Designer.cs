
namespace TestQua_Project__APP_.Admin
{
   partial class AddProduct
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
         this.txtbProductName = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.pictureBox = new System.Windows.Forms.PictureBox();
         this.btnBrowse = new System.Windows.Forms.Button();
         this.btnSave = new System.Windows.Forms.Button();
         this.txtbProductDescription = new System.Windows.Forms.TextBox();
         this.txtbProductPrice = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.btnShow = new System.Windows.Forms.Button();
         this.txtbProductId = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
         this.SuspendLayout();
         // 
         // txtbProductName
         // 
         this.txtbProductName.Location = new System.Drawing.Point(228, 109);
         this.txtbProductName.Name = "txtbProductName";
         this.txtbProductName.Size = new System.Drawing.Size(100, 20);
         this.txtbProductName.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(143, 112);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(75, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "Product Name";
         // 
         // pictureBox
         // 
         this.pictureBox.Location = new System.Drawing.Point(482, 78);
         this.pictureBox.Name = "pictureBox";
         this.pictureBox.Size = new System.Drawing.Size(141, 120);
         this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox.TabIndex = 2;
         this.pictureBox.TabStop = false;
         // 
         // btnBrowse
         // 
         this.btnBrowse.Location = new System.Drawing.Point(596, 222);
         this.btnBrowse.Name = "btnBrowse";
         this.btnBrowse.Size = new System.Drawing.Size(75, 23);
         this.btnBrowse.TabIndex = 3;
         this.btnBrowse.Text = "browse";
         this.btnBrowse.UseVisualStyleBackColor = true;
         this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
         // 
         // btnSave
         // 
         this.btnSave.Location = new System.Drawing.Point(473, 222);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(75, 23);
         this.btnSave.TabIndex = 4;
         this.btnSave.Text = "Save";
         this.btnSave.UseVisualStyleBackColor = true;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // txtbProductDescription
         // 
         this.txtbProductDescription.Location = new System.Drawing.Point(228, 150);
         this.txtbProductDescription.Name = "txtbProductDescription";
         this.txtbProductDescription.Size = new System.Drawing.Size(100, 20);
         this.txtbProductDescription.TabIndex = 5;
         // 
         // txtbProductPrice
         // 
         this.txtbProductPrice.Location = new System.Drawing.Point(228, 190);
         this.txtbProductPrice.Name = "txtbProductPrice";
         this.txtbProductPrice.Size = new System.Drawing.Size(100, 20);
         this.txtbProductPrice.TabIndex = 6;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(122, 157);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(100, 13);
         this.label2.TabIndex = 8;
         this.label2.Text = "Product Description";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(143, 197);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(71, 13);
         this.label3.TabIndex = 9;
         this.label3.Text = "Product Price";
         // 
         // btnShow
         // 
         this.btnShow.Location = new System.Drawing.Point(529, 299);
         this.btnShow.Name = "btnShow";
         this.btnShow.Size = new System.Drawing.Size(75, 23);
         this.btnShow.TabIndex = 10;
         this.btnShow.Text = "Show";
         this.btnShow.UseVisualStyleBackColor = true;
         this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
         // 
         // txtbProductId
         // 
         this.txtbProductId.Location = new System.Drawing.Point(228, 35);
         this.txtbProductId.Name = "txtbProductId";
         this.txtbProductId.Size = new System.Drawing.Size(100, 20);
         this.txtbProductId.TabIndex = 11;
         // 
         // AddProduct
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.txtbProductId);
         this.Controls.Add(this.btnShow);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txtbProductPrice);
         this.Controls.Add(this.txtbProductDescription);
         this.Controls.Add(this.btnSave);
         this.Controls.Add(this.btnBrowse);
         this.Controls.Add(this.pictureBox);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtbProductName);
         this.Name = "AddProduct";
         this.Text = "AddProduct";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtbProductName;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.PictureBox pictureBox;
      private System.Windows.Forms.Button btnBrowse;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.TextBox txtbProductDescription;
      private System.Windows.Forms.TextBox txtbProductPrice;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button btnShow;
      private System.Windows.Forms.TextBox txtbProductId;
   }
}