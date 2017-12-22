﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TourismMangement
{
    public partial class EditProfile : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LELOUCH;Initial Catalog=\"IS Project\";Integrated Security=True");

        public EditProfile()
        {
            InitializeComponent();
            while (string.IsNullOrWhiteSpace(textBoxCurrentPassword.Text))
                UpdateButton.Enabled = false;

           // textBoxUsername.Text = currentUsername;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (!checkPassword())
            {
                MessageBox.Show("Password is incorrect.");
                return;
            }

            else
            {
                if (!string.IsNullOrWhiteSpace(textBoxConfirmPassword.Text))
                {
                    if (textBoxNewPassword.Text == textBoxConfirmPassword.Text)
                        UpdateUserPassword();

                    else
                        MessageBox.Show("New Password and Confirm Password fields don't match. ");
                }

                if (!string.IsNullOrWhiteSpace(textBoxPhone.Text))
                    UpdateUserPhone();

                if (!string.IsNullOrWhiteSpace(textBoxEmail.Text))
                    UpdateUserMail();

                if (comboBoxWayOfPayment.Text != "Select")
                    UpdateUserPayment();

            }
        }

        private bool checkPassword()
        {
            con.Open();

            string Query = @"SELECT Password
                            FROM Users
                            WHERE Username = " + textBoxUsername;
            MessageBox.Show(Query);
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            string Password = (string)rdr["Password"];

            rdr.Close();
            con.Close();

            if (Password == textBoxCurrentPassword.Text)
                return true;
            else
                return false;
                                  
        }

        private void UpdateUserPassword()
        { 
            con.Open();

            string Query = @"UPDATE INTO Users 
                             SET (Password = " + textBoxNewPassword + @")
                             WHERE Username = " + textBoxUsername;
            MessageBox.Show(Query);          
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void UpdateUserMail()
        {
            con.Open();

            string Query = @"UPDATE INTO Users
                             SET (Mail = " + textBoxEmail + @")
                             WHERE Username = " + textBoxUsername;
            MessageBox.Show(Query);
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void UpdateUserPhone()
        {
            con.Open();

            string Query = @"UPDATE INTO Users
                             SET (Phone = " + textBoxPhone + @")
                             WHERE Username = " + textBoxUsername;
            MessageBox.Show(Query);
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void UpdateUserPayment()
        {
            con.Open();

            string Query = @"UPDATE Users
                             SET(WayofPayment = " + comboBoxWayOfPayment.Text + @")
                             WHERE Username = " + textBoxUsername;
            MessageBox.Show(Query);
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }


    }
}