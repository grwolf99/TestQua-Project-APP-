
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
         this.btnLogin = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.txtUsername = new System.Windows.Forms.TextBox();
         this.txtPassword = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.linklblRegister = new System.Windows.Forms.LinkLabel();
         this.SuspendLayout();
         // 
         // btnLogin
         // 
         this.btnLogin.Location = new System.Drawing.Point(410, 274);
         this.btnLogin.Name = "btnLogin";
         this.btnLogin.Size = new System.Drawing.Size(75, 23);
         this.btnLogin.TabIndex = 0;
         this.btnLogin.Text = "Login";
         this.btnLogin.UseVisualStyleBackColor = true;
         this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(324, 140);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(55, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "Username";
         // 
         // txtUsername
         // 
         this.txtUsername.Location = new System.Drawing.Point(399, 140);
         this.txtUsername.Name = "txtUsername";
         this.txtUsername.Size = new System.Drawing.Size(100, 20);
         this.txtUsername.TabIndex = 2;
         // 
         // txtPassword
         // 
         this.txtPassword.Location = new System.Drawing.Point(399, 192);
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.Size = new System.Drawing.Size(100, 20);
         this.txtPassword.TabIndex = 3;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(324, 199);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(53, 13);
         this.label2.TabIndex = 4;
         this.label2.Text = "Password";
         // 
         // linklblRegister
         // 
         this.linklblRegister.AutoSize = true;
         this.linklblRegister.Location = new System.Drawing.Point(345, 320);
         this.linklblRegister.Name = "linklblRegister";
         this.linklblRegister.Size = new System.Drawing.Size(195, 13);
         this.linklblRegister.TabIndex = 5;
         this.linklblRegister.TabStop = true;
         this.linklblRegister.Text = "Need an account? Click here to register";
         this.linklblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblRegister_LinkClicked);
         // 
         // Login
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.linklblRegister);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txtPassword);
         this.Controls.Add(this.txtUsername);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.btnLogin);
         this.Name = "Login";
         this.Text = "Login";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnLogin;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtUsername;
      private System.Windows.Forms.TextBox txtPassword;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.LinkLabel linklblRegister;
   }
}