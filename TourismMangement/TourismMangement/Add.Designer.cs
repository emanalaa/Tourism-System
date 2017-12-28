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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.ButtonAddTourplace = new System.Windows.Forms.Button();
            this.ButtonAddUser = new System.Windows.Forms.Button();
            this.ButtonAddTrans = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonAddTourplace
            // 
            this.ButtonAddTourplace.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonAddTourplace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonAddTourplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddTourplace.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddTourplace.ForeColor = System.Drawing.Color.Black;
            this.ButtonAddTourplace.Location = new System.Drawing.Point(190, 322);
            this.ButtonAddTourplace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonAddTourplace.Name = "ButtonAddTourplace";
            this.ButtonAddTourplace.Size = new System.Drawing.Size(298, 74);
            this.ButtonAddTourplace.TabIndex = 15;
            this.ButtonAddTourplace.Text = "Add TourPlace";
            this.ButtonAddTourplace.UseVisualStyleBackColor = false;
            this.ButtonAddTourplace.Click += new System.EventHandler(this.ButtonAddTourplace_Click);
            // 
            // ButtonAddUser
            // 
            this.ButtonAddUser.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddUser.ForeColor = System.Drawing.Color.Black;
            this.ButtonAddUser.Location = new System.Drawing.Point(190, 129);
            this.ButtonAddUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonAddUser.Name = "ButtonAddUser";
            this.ButtonAddUser.Size = new System.Drawing.Size(298, 76);
            this.ButtonAddUser.TabIndex = 14;
            this.ButtonAddUser.Text = "Add User";
            this.ButtonAddUser.UseVisualStyleBackColor = false;
            this.ButtonAddUser.Click += new System.EventHandler(this.ButtonAddUser_Click);
            // 
            // ButtonAddTrans
            // 
            this.ButtonAddTrans.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonAddTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonAddTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddTrans.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddTrans.ForeColor = System.Drawing.Color.Black;
            this.ButtonAddTrans.Location = new System.Drawing.Point(190, 228);
            this.ButtonAddTrans.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonAddTrans.Name = "ButtonAddTrans";
            this.ButtonAddTrans.Size = new System.Drawing.Size(298, 71);
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
            this.button1.Location = new System.Drawing.Point(14, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 42);
            this.button1.TabIndex = 16;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonAddTourplace);
            this.Controls.Add(this.ButtonAddUser);
            this.Controls.Add(this.ButtonAddTrans);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Add";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddTourplace;
        private System.Windows.Forms.Button ButtonAddUser;
        private System.Windows.Forms.Button ButtonAddTrans;
        private System.Windows.Forms.Button button1;
    }
}