
namespace TestQua_Project__APP_
{
    partial class Splashscreen
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
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splashscreen));
         this.button1 = new System.Windows.Forms.Button();
         this.timer1 = new System.Windows.Forms.Timer(this.components);
         this.progressBar1 = new System.Windows.Forms.ProgressBar();
         this.SuspendLayout();
         // 
         // button1
         // 
         this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
         this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
         this.button1.Location = new System.Drawing.Point(-31, -45);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(872, 754);
         this.button1.TabIndex = 0;
         this.button1.UseVisualStyleBackColor = true;
         // 
         // timer1
         // 
         this.timer1.Enabled = true;
         this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
         // 
         // progressBar1
         // 
         this.progressBar1.BackColor = System.Drawing.Color.White;
         this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(7)))), ((int)(((byte)(48)))));
         this.progressBar1.Location = new System.Drawing.Point(288, 584);
         this.progressBar1.Name = "progressBar1";
         this.progressBar1.Size = new System.Drawing.Size(245, 23);
         this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
         this.progressBar1.TabIndex = 0;
         // 
         // Splashscreen
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 660);
         this.Controls.Add(this.progressBar1);
         this.Controls.Add(this.button1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "Splashscreen";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Splashscreen";
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Timer timer1;
      private System.Windows.Forms.ProgressBar progressBar1;
   }
}