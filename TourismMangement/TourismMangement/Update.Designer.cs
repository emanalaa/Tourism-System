namespace TourismMangement
{
    partial class Update
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
            this.ButtonUpdateTouplace = new System.Windows.Forms.Button();
            this.ButtonUpdateTrans = new System.Windows.Forms.Button();
            this.ButtonUpdateUser = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonUpdateTouplace
            // 
            this.ButtonUpdateTouplace.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonUpdateTouplace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonUpdateTouplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdateTouplace.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdateTouplace.ForeColor = System.Drawing.Color.White;
            this.ButtonUpdateTouplace.Location = new System.Drawing.Point(156, 307);
            this.ButtonUpdateTouplace.Name = "ButtonUpdateTouplace";
            this.ButtonUpdateTouplace.Size = new System.Drawing.Size(271, 53);
            this.ButtonUpdateTouplace.TabIndex = 16;
            this.ButtonUpdateTouplace.Text = "Update Tourplace";
            this.ButtonUpdateTouplace.UseVisualStyleBackColor = false;
            this.ButtonUpdateTouplace.Click += new System.EventHandler(this.ButtonUpdateTouplace_Click);
            // 
            // ButtonUpdateTrans
            // 
            this.ButtonUpdateTrans.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonUpdateTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonUpdateTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdateTrans.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdateTrans.ForeColor = System.Drawing.Color.White;
            this.ButtonUpdateTrans.Location = new System.Drawing.Point(156, 194);
            this.ButtonUpdateTrans.Name = "ButtonUpdateTrans";
            this.ButtonUpdateTrans.Size = new System.Drawing.Size(271, 60);
            this.ButtonUpdateTrans.TabIndex = 15;
            this.ButtonUpdateTrans.Text = "Update Transportation";
            this.ButtonUpdateTrans.UseVisualStyleBackColor = false;
            this.ButtonUpdateTrans.Click += new System.EventHandler(this.ButtonUpdateTrans_Click);
            // 
            // ButtonUpdateUser
            // 
            this.ButtonUpdateUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonUpdateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdateUser.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdateUser.ForeColor = System.Drawing.Color.White;
            this.ButtonUpdateUser.Location = new System.Drawing.Point(156, 87);
            this.ButtonUpdateUser.Name = "ButtonUpdateUser";
            this.ButtonUpdateUser.Size = new System.Drawing.Size(271, 60);
            this.ButtonUpdateUser.TabIndex = 14;
            this.ButtonUpdateUser.Text = "Update User";
            this.ButtonUpdateUser.UseVisualStyleBackColor = false;
            this.ButtonUpdateUser.Click += new System.EventHandler(this.ButtonUpdateUser_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(464, 409);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(99, 40);
            this.BackButton.TabIndex = 17;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ButtonUpdateTouplace);
            this.Controls.Add(this.ButtonUpdateTrans);
            this.Controls.Add(this.ButtonUpdateUser);
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonUpdateTouplace;
        private System.Windows.Forms.Button ButtonUpdateTrans;
        private System.Windows.Forms.Button ButtonUpdateUser;
        private System.Windows.Forms.Button BackButton;
    }
}