namespace TourismMangement
{
    partial class AdminHome
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
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttondisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(230, 76);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(116, 46);
            this.buttonadd.TabIndex = 0;
            this.buttonadd.Text = "Add";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttonupdate
            // 
            this.buttonupdate.Location = new System.Drawing.Point(230, 169);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(116, 46);
            this.buttonupdate.TabIndex = 1;
            this.buttonupdate.Text = "Update";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(230, 264);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(116, 46);
            this.buttondelete.TabIndex = 2;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttondisplay
            // 
            this.buttondisplay.Location = new System.Drawing.Point(230, 355);
            this.buttondisplay.Name = "buttondisplay";
            this.buttondisplay.Size = new System.Drawing.Size(116, 46);
            this.buttondisplay.TabIndex = 3;
            this.buttondisplay.Text = "Display";
            this.buttondisplay.UseVisualStyleBackColor = true;
            this.buttondisplay.Click += new System.EventHandler(this.buttondisplay_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.buttondisplay);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.buttonadd);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttondisplay;
    }
}