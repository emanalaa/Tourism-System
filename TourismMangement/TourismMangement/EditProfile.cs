using System;
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
        //connection_awad
        //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=\"IS Project\";Integrated Security=True");

        public EditProfile()
        {
            InitializeComponent();
            textBoxUsername.Text = Login.currentUsername;
        }

        private void textBoxCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            UpdateButton.Enabled = !string.IsNullOrWhiteSpace(textBoxCurrentPassword.Text);
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

            MessageBox.Show("Your information has been updated successfully.", "Updated");
        }

        private bool checkPassword()
        {
            con.Open();

            string Query = @"SELECT Password
                            FROM Users
                            WHERE Username = '" + textBoxUsername.Text + "'";
            
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

            string Query = @"UPDATE Users 
                             SET Password = '" + textBoxNewPassword.Text + @"'
                             WHERE Username = '" + textBoxUsername.Text + "'";
                     
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void UpdateUserMail()
        {
            con.Open();

            string Query = @"UPDATE Users
                             SET Mail = '" + textBoxEmail.Text + @"'
                             WHERE Username = '" + textBoxUsername.Text + "'";
            
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void UpdateUserPhone()
        {
            con.Open();

            string Query = @"UPDATE Users
                             SET Phone = '" + textBoxPhone.Text + @"'
                             WHERE Username = '" + textBoxUsername.Text + "'";
            
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void UpdateUserPayment()
        {
            con.Open();

            string Query = @"UPDATE Users
                             SET WayofPayment = '" + comboBoxWayOfPayment.Text + @"'
                             WHERE Username = '" + textBoxUsername.Text + "'";
            
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            UserHome UH = new UserHome();
            UH.Show();
            this.Hide();
        }
    }
}
