namespace TourismMangement
{
    partial class Delete
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
            this.buttonDeleteTransportation = new System.Windows.Forms.Button();
            this.buttonDeleteTourPlace = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDeleteTransportation
            // 
            this.buttonDeleteTransportation.BackColor = System.Drawing.Color.Black;
            this.buttonDeleteTransportation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteTransportation.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteTransportation.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteTransportation.Location = new System.Drawing.Point(203, 249);
            this.buttonDeleteTransportation.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonDeleteTransportation.Name = "buttonDeleteTransportation";
            this.buttonDeleteTransportation.Size = new System.Drawing.Size(305, 59);
            this.buttonDeleteTransportation.TabIndex = 5;
            this.buttonDeleteTransportation.Text = "Delete Transportation";
            this.buttonDeleteTransportation.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteTourPlace
            // 
            this.buttonDeleteTourPlace.BackColor = System.Drawing.Color.Black;
            this.buttonDeleteTourPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteTourPlace.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteTourPlace.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteTourPlace.Location = new System.Drawing.Point(203, 345);
            this.buttonDeleteTourPlace.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonDeleteTourPlace.Name = "buttonDeleteTourPlace";
            this.buttonDeleteTourPlace.Size = new System.Drawing.Size(305, 59);
            this.buttonDeleteTourPlace.TabIndex = 4;
            this.buttonDeleteTourPlace.Text = "Delete Tour Place";
            this.buttonDeleteTourPlace.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.BackColor = System.Drawing.Color.Black;
            this.buttonDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteUser.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteUser.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteUser.Location = new System.Drawing.Point(203, 151);
            this.buttonDeleteUser.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(305, 59);
            this.buttonDeleteUser.TabIndex = 3;
            this.buttonDeleteUser.Text = "Delete User";
            this.buttonDeleteUser.UseVisualStyleBackColor = false;
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 567);
            this.Controls.Add(this.buttonDeleteTransportation);
            this.Controls.Add(this.buttonDeleteTourPlace);
            this.Controls.Add(this.buttonDeleteUser);
            this.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDeleteTransportation;
        private System.Windows.Forms.Button buttonDeleteTourPlace;
        private System.Windows.Forms.Button buttonDeleteUser;
    }
}