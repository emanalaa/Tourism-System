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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonAddTourplace
            // 
            this.ButtonAddTourplace.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ButtonAddTourplace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonAddTourplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddTourplace.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddTourplace.ForeColor = System.Drawing.Color.White;
            this.ButtonAddTourplace.Location = new System.Drawing.Point(114, 342);
            this.ButtonAddTourplace.Name = "ButtonAddTourplace";
            this.ButtonAddTourplace.Size = new System.Drawing.Size(358, 60);
            this.ButtonAddTourplace.TabIndex = 15;
            this.ButtonAddTourplace.Text = "Add TourPlace";
            this.ButtonAddTourplace.UseVisualStyleBackColor = false;
            this.ButtonAddTourplace.Click += new System.EventHandler(this.ButtonAddTourplace_Click);
            // 
            // ButtonAddUser
            // 
            this.ButtonAddUser.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ButtonAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddUser.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddUser.ForeColor = System.Drawing.Color.White;
            this.ButtonAddUser.Location = new System.Drawing.Point(114, 135);
            this.ButtonAddUser.Name = "ButtonAddUser";
            this.ButtonAddUser.Size = new System.Drawing.Size(358, 60);
            this.ButtonAddUser.TabIndex = 14;
            this.ButtonAddUser.Text = "Add User";
            this.ButtonAddUser.UseVisualStyleBackColor = false;
            this.ButtonAddUser.Click += new System.EventHandler(this.ButtonAddUser_Click);
            // 
            // ButtonAddTrans
            // 
            this.ButtonAddTrans.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ButtonAddTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonAddTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddTrans.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddTrans.ForeColor = System.Drawing.Color.White;
            this.ButtonAddTrans.Location = new System.Drawing.Point(114, 240);
            this.ButtonAddTrans.Name = "ButtonAddTrans";
            this.ButtonAddTrans.Size = new System.Drawing.Size(358, 60);
            this.ButtonAddTrans.TabIndex = 13;
            this.ButtonAddTrans.Text = "Add Transportation";
            this.ButtonAddTrans.UseVisualStyleBackColor = false;
            this.ButtonAddTrans.Click += new System.EventHandler(this.ButtonAddTrans_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 27);
            this.button1.TabIndex = 16;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonAddTourplace);
            this.Controls.Add(this.ButtonAddUser);
            this.Controls.Add(this.ButtonAddTrans);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddTourplace;
        private System.Windows.Forms.Button ButtonAddUser;
        private System.Windows.Forms.Button ButtonAddTrans;
        private System.Windows.Forms.Button button1;
    }
}