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
            this.ButtonSignUp = new System.Windows.Forms.Button();
            this.ButtonSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonSignUp
            // 
            this.ButtonSignUp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonSignUp.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSignUp.Location = new System.Drawing.Point(219, 324);
            this.ButtonSignUp.Name = "ButtonSignUp";
            this.ButtonSignUp.Size = new System.Drawing.Size(124, 45);
            this.ButtonSignUp.TabIndex = 4;
            this.ButtonSignUp.Text = "SIGN UP";
            this.ButtonSignUp.UseVisualStyleBackColor = false;
            this.ButtonSignUp.Click += new System.EventHandler(this.ButtonSignUp_Click);
            // 
            // ButtonSignIn
            // 
            this.ButtonSignIn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonSignIn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSignIn.Location = new System.Drawing.Point(219, 210);
            this.ButtonSignIn.Name = "ButtonSignIn";
            this.ButtonSignIn.Size = new System.Drawing.Size(124, 45);
            this.ButtonSignIn.TabIndex = 3;
            this.ButtonSignIn.Text = "SIGN IN";
            this.ButtonSignIn.UseVisualStyleBackColor = false;
            this.ButtonSignIn.Click += new System.EventHandler(this.ButtonSignIn_Click);
            // 
            // Login_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.ButtonSignUp);
            this.Controls.Add(this.ButtonSignIn);
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