namespace TourismMangement
{
    partial class Login_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Register));
            this.ButtonSignUp = new System.Windows.Forms.Button();
            this.ButtonSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonSignUp
            // 
            this.ButtonSignUp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonSignUp.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSignUp.Location = new System.Drawing.Point(255, 227);
            this.ButtonSignUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonSignUp.Name = "ButtonSignUp";
            this.ButtonSignUp.Size = new System.Drawing.Size(145, 55);
            this.ButtonSignUp.TabIndex = 4;
            this.ButtonSignUp.Text = "SIGN UP";
            this.ButtonSignUp.UseVisualStyleBackColor = false;
            this.ButtonSignUp.Click += new System.EventHandler(this.ButtonSignUp_Click);
            // 
            // ButtonSignIn
            // 
            this.ButtonSignIn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonSignIn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSignIn.Location = new System.Drawing.Point(255, 351);
            this.ButtonSignIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonSignIn.Name = "ButtonSignIn";
            this.ButtonSignIn.Size = new System.Drawing.Size(145, 55);
            this.ButtonSignIn.TabIndex = 3;
            this.ButtonSignIn.Text = "SIGN IN";
            this.ButtonSignIn.UseVisualStyleBackColor = false;
            this.ButtonSignIn.Click += new System.EventHandler(this.ButtonSignIn_Click);
            // 
            // Login_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 567);
            this.Controls.Add(this.ButtonSignUp);
            this.Controls.Add(this.ButtonSignIn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Register";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonSignUp;
        private System.Windows.Forms.Button ButtonSignIn;
    }
}