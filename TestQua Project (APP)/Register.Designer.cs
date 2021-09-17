
namespace TestQua_Project__APP_
{
   partial class Register
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
         this.btnLogin = new System.Windows.Forms.Button();
         this.btnSave = new System.Windows.Forms.Button();
         this.txtbFname = new System.Windows.Forms.TextBox();
         this.txtbLname = new System.Windows.Forms.TextBox();
         this.txtbAge = new System.Windows.Forms.TextBox();
         this.txtContact = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // btnLogin
         // 
         this.btnLogin.Location = new System.Drawing.Point(481, 319);
         this.btnLogin.Name = "btnLogin";
         this.btnLogin.Size = new System.Drawing.Size(75, 23);
         this.btnLogin.TabIndex = 0;
         this.btnLogin.Text = "Login";
         this.btnLogin.UseVisualStyleBackColor = true;
         this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
         // 
         // btnSave
         // 
         this.btnSave.Location = new System.Drawing.Point(579, 319);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(75, 23);
         this.btnSave.TabIndex = 1;
         this.btnSave.Text = "Save";
         this.btnSave.UseVisualStyleBackColor = true;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // txtbFname
         // 
         this.txtbFname.Location = new System.Drawing.Point(233, 74);
         this.txtbFname.Name = "txtbFname";
         this.txtbFname.Size = new System.Drawing.Size(100, 20);
         this.txtbFname.TabIndex = 2;
         // 
         // txtbLname
         // 
         this.txtbLname.Location = new System.Drawing.Point(233, 100);
         this.txtbLname.Name = "txtbLname";
         this.txtbLname.Size = new System.Drawing.Size(100, 20);
         this.txtbLname.TabIndex = 3;
         // 
         // txtbAge
         // 
         this.txtbAge.Location = new System.Drawing.Point(233, 126);
         this.txtbAge.Name = "txtbAge";
         this.txtbAge.Size = new System.Drawing.Size(100, 20);
         this.txtbAge.TabIndex = 4;
         // 
         // txtContact
         // 
         this.txtContact.Location = new System.Drawing.Point(233, 152);
         this.txtContact.Name = "txtContact";
         this.txtContact.Size = new System.Drawing.Size(100, 20);
         this.txtContact.TabIndex = 5;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(166, 80);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(55, 13);
         this.label1.TabIndex = 6;
         this.label1.Text = "First name";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(166, 107);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(56, 13);
         this.label2.TabIndex = 7;
         this.label2.Text = "Last name";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(166, 133);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(26, 13);
         this.label3.TabIndex = 8;
         this.label3.Text = "Age";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(171, 159);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(59, 13);
         this.label4.TabIndex = 9;
         this.label4.Text = "Contact no";
         // 
         // Register
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtContact);
         this.Controls.Add(this.txtbAge);
         this.Controls.Add(this.txtbLname);
         this.Controls.Add(this.txtbFname);
         this.Controls.Add(this.btnSave);
         this.Controls.Add(this.btnLogin);
         this.Name = "Register";
         this.Text = "Register";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnLogin;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.TextBox txtbFname;
      private System.Windows.Forms.TextBox txtbLname;
      private System.Windows.Forms.TextBox txtbAge;
      private System.Windows.Forms.TextBox txtContact;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
   }
}