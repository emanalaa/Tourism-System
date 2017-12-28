namespace TourismMangement
{
    partial class UserHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHome));
            this.buttoneditprofile = new System.Windows.Forms.Button();
            this.buttonreserve = new System.Windows.Forms.Button();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttoneditprofile
            // 
            this.buttoneditprofile.Location = new System.Drawing.Point(297, 240);
            this.buttoneditprofile.Name = "buttoneditprofile";
            this.buttoneditprofile.Size = new System.Drawing.Size(140, 47);
            this.buttoneditprofile.TabIndex = 2;
            this.buttoneditprofile.Text = "Edit Profile";
            this.buttoneditprofile.UseVisualStyleBackColor = true;
            this.buttoneditprofile.Click += new System.EventHandler(this.buttoneditprofile_Click);
            // 
            // buttonreserve
            // 
            this.buttonreserve.Location = new System.Drawing.Point(297, 154);
            this.buttonreserve.Name = "buttonreserve";
            this.buttonreserve.Size = new System.Drawing.Size(140, 47);
            this.buttonreserve.TabIndex = 3;
            this.buttonreserve.Text = "Reserve";
            this.buttonreserve.UseVisualStyleBackColor = true;
            this.buttonreserve.Click += new System.EventHandler(this.buttonreserve_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.Location = new System.Drawing.Point(297, 326);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(140, 47);
            this.logoutbutton.TabIndex = 4;
            this.logoutbutton.Text = "Log out";
            this.logoutbutton.UseVisualStyleBackColor = true;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 567);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.buttonreserve);
            this.Controls.Add(this.buttoneditprofile);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UserHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttoneditprofile;
        private System.Windows.Forms.Button buttonreserve;
        private System.Windows.Forms.Button logoutbutton;
    }
}