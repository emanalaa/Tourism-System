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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.ButtonUpdateTouplace = new System.Windows.Forms.Button();
            this.ButtonUpdateTrans = new System.Windows.Forms.Button();
            this.ButtonUpdateUser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonUpdateTouplace
            // 
            this.ButtonUpdateTouplace.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonUpdateTouplace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonUpdateTouplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdateTouplace.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdateTouplace.ForeColor = System.Drawing.Color.Black;
            this.ButtonUpdateTouplace.Location = new System.Drawing.Point(174, 322);
            this.ButtonUpdateTouplace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonUpdateTouplace.Name = "ButtonUpdateTouplace";
            this.ButtonUpdateTouplace.Size = new System.Drawing.Size(312, 62);
            this.ButtonUpdateTouplace.TabIndex = 16;
            this.ButtonUpdateTouplace.Text = "Update TourPlace";
            this.ButtonUpdateTouplace.UseVisualStyleBackColor = false;
            this.ButtonUpdateTouplace.Click += new System.EventHandler(this.ButtonUpdateTouplace_Click);
            // 
            // ButtonUpdateTrans
            // 
            this.ButtonUpdateTrans.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonUpdateTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonUpdateTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdateTrans.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdateTrans.ForeColor = System.Drawing.Color.Black;
            this.ButtonUpdateTrans.Location = new System.Drawing.Point(174, 223);
            this.ButtonUpdateTrans.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonUpdateTrans.Name = "ButtonUpdateTrans";
            this.ButtonUpdateTrans.Size = new System.Drawing.Size(312, 67);
            this.ButtonUpdateTrans.TabIndex = 15;
            this.ButtonUpdateTrans.Text = "Update Transportation";
            this.ButtonUpdateTrans.UseVisualStyleBackColor = false;
            this.ButtonUpdateTrans.Click += new System.EventHandler(this.ButtonUpdateTrans_Click);
            // 
            // ButtonUpdateUser
            // 
            this.ButtonUpdateUser.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonUpdateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdateUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdateUser.ForeColor = System.Drawing.Color.Black;
            this.ButtonUpdateUser.Location = new System.Drawing.Point(174, 127);
            this.ButtonUpdateUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonUpdateUser.Name = "ButtonUpdateUser";
            this.ButtonUpdateUser.Size = new System.Drawing.Size(312, 68);
            this.ButtonUpdateUser.TabIndex = 14;
            this.ButtonUpdateUser.Text = "Update User";
            this.ButtonUpdateUser.UseVisualStyleBackColor = false;
            this.ButtonUpdateUser.Click += new System.EventHandler(this.ButtonUpdateUser_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(14, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 51);
            this.button1.TabIndex = 47;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonUpdateTouplace);
            this.Controls.Add(this.ButtonUpdateTrans);
            this.Controls.Add(this.ButtonUpdateUser);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonUpdateTouplace;
        private System.Windows.Forms.Button ButtonUpdateTrans;
        private System.Windows.Forms.Button ButtonUpdateUser;
        private System.Windows.Forms.Button button1;
    }
}