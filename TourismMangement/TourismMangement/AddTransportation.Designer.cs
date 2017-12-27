namespace TourismMangement
{
    partial class AddTransportation
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
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxArrivalMinutes = new System.Windows.Forms.ComboBox();
            this.comboBoxArrivalHours = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxDepartureMinutes = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartureHour = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxOrigin = new System.Windows.Forms.TextBox();
            this.comboBoxDestination = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(281, 107);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(253, 30);
            this.textBoxType.TabIndex = 44;
            this.textBoxType.TextChanged += new System.EventHandler(this.textBoxType_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(456, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 23);
            this.label7.TabIndex = 43;
            this.label7.Text = ":";
            // 
            // comboBoxArrivalMinutes
            // 
            this.comboBoxArrivalMinutes.FormattingEnabled = true;
            this.comboBoxArrivalMinutes.Location = new System.Drawing.Point(483, 223);
            this.comboBoxArrivalMinutes.Name = "comboBoxArrivalMinutes";
            this.comboBoxArrivalMinutes.Size = new System.Drawing.Size(51, 30);
            this.comboBoxArrivalMinutes.TabIndex = 42;
            // 
            // comboBoxArrivalHours
            // 
            this.comboBoxArrivalHours.FormattingEnabled = true;
            this.comboBoxArrivalHours.Location = new System.Drawing.Point(399, 223);
            this.comboBoxArrivalHours.Name = "comboBoxArrivalHours";
            this.comboBoxArrivalHours.Size = new System.Drawing.Size(51, 30);
            this.comboBoxArrivalHours.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(456, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 23);
            this.label6.TabIndex = 40;
            this.label6.Text = ":";
            // 
            // comboBoxDepartureMinutes
            // 
            this.comboBoxDepartureMinutes.FormattingEnabled = true;
            this.comboBoxDepartureMinutes.Location = new System.Drawing.Point(483, 161);
            this.comboBoxDepartureMinutes.Name = "comboBoxDepartureMinutes";
            this.comboBoxDepartureMinutes.Size = new System.Drawing.Size(51, 30);
            this.comboBoxDepartureMinutes.TabIndex = 39;
            // 
            // comboBoxDepartureHour
            // 
            this.comboBoxDepartureHour.FormattingEnabled = true;
            this.comboBoxDepartureHour.Location = new System.Drawing.Point(399, 161);
            this.comboBoxDepartureHour.Name = "comboBoxDepartureHour";
            this.comboBoxDepartureHour.Size = new System.Drawing.Size(51, 30);
            this.comboBoxDepartureHour.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(125, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "Departure Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(125, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 36;
            this.label4.Text = "Arrival Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(125, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 35;
            this.label3.Text = "Origin: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(125, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Destination:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(125, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Type:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(281, 426);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(147, 50);
            this.buttonAdd.TabIndex = 32;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxOrigin
            // 
            this.comboBoxOrigin.Location = new System.Drawing.Point(281, 273);
            this.comboBoxOrigin.Name = "comboBoxOrigin";
            this.comboBoxOrigin.Size = new System.Drawing.Size(253, 30);
            this.comboBoxOrigin.TabIndex = 47;
            // 
            // comboBoxDestination
            // 
            this.comboBoxDestination.Location = new System.Drawing.Point(281, 324);
            this.comboBoxDestination.Name = "comboBoxDestination";
            this.comboBoxDestination.Size = new System.Drawing.Size(253, 30);
            this.comboBoxDestination.TabIndex = 48;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(79, 27);
            this.BackButton.TabIndex = 49;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddTransportation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 567);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.comboBoxDestination);
            this.Controls.Add(this.comboBoxOrigin);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxArrivalMinutes);
            this.Controls.Add(this.comboBoxArrivalHours);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxDepartureMinutes);
            this.Controls.Add(this.comboBoxDepartureHour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AddTransportation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTransportation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxArrivalMinutes;
        private System.Windows.Forms.ComboBox comboBoxArrivalHours;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxDepartureMinutes;
        private System.Windows.Forms.ComboBox comboBoxDepartureHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox comboBoxOrigin;
        private System.Windows.Forms.TextBox comboBoxDestination;
        private System.Windows.Forms.Button BackButton;
    }
}