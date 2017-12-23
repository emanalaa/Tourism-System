namespace TourismMangement
{
    partial class Add
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
            this.ButtonAddTourplace = new System.Windows.Forms.Button();
            this.ButtonAddUser = new System.Windows.Forms.Button();
            this.ButtonAddTrans = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonAddTourplace
            // 
            this.ButtonAddTourplace.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonAddTourplace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonAddTourplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddTourplace.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddTourplace.ForeColor = System.Drawing.Color.White;
            this.ButtonAddTourplace.Location = new System.Drawing.Point(181, 299);
            this.ButtonAddTourplace.Name = "ButtonAddTourplace";
            this.ButtonAddTourplace.Size = new System.Drawing.Size(233, 60);
            this.ButtonAddTourplace.TabIndex = 15;
            this.ButtonAddTourplace.Text = "Add Tourplace";
            this.ButtonAddTourplace.UseVisualStyleBackColor = false;
            this.ButtonAddTourplace.Click += new System.EventHandler(this.ButtonAddTourplace_Click);
            // 
            // ButtonAddUser
            // 
            this.ButtonAddUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddUser.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddUser.ForeColor = System.Drawing.Color.White;
            this.ButtonAddUser.Location = new System.Drawing.Point(181, 92);
            this.ButtonAddUser.Name = "ButtonAddUser";
            this.ButtonAddUser.Size = new System.Drawing.Size(233, 53);
            this.ButtonAddUser.TabIndex = 14;
            this.ButtonAddUser.Text = "Add User";
            this.ButtonAddUser.UseVisualStyleBackColor = false;
            this.ButtonAddUser.Click += new System.EventHandler(this.ButtonAddUser_Click);
            // 
            // ButtonAddTrans
            // 
            this.ButtonAddTrans.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonAddTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonAddTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddTrans.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddTrans.ForeColor = System.Drawing.Color.White;
            this.ButtonAddTrans.Location = new System.Drawing.Point(181, 197);
            this.ButtonAddTrans.Name = "ButtonAddTrans";
            this.ButtonAddTrans.Size = new System.Drawing.Size(233, 55);
            this.ButtonAddTrans.TabIndex = 13;
            this.ButtonAddTrans.Text = "Add Transportation";
            this.ButtonAddTrans.UseVisualStyleBackColor = false;
            this.ButtonAddTrans.Click += new System.EventHandler(this.ButtonAddTrans_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(461, 408);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(99, 40);
            this.BackButton.TabIndex = 18;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ButtonAddTourplace);
            this.Controls.Add(this.ButtonAddUser);
            this.Controls.Add(this.ButtonAddTrans);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddTourplace;
        private System.Windows.Forms.Button ButtonAddUser;
        private System.Windows.Forms.Button ButtonAddTrans;
        private System.Windows.Forms.Button BackButton;
    }
}