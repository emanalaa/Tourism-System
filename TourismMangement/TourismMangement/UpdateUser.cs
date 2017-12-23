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
    public partial class UpdateUser : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LELOUCH;Initial Catalog=\"IS Project\";Integrated Security=True");

        public UpdateUser()
        {
            InitializeComponent();
        }

        private void UpdateUsername()
        {
            con.Open();
            string newUsername = @"UPDATE Users
                             SET Username = '" + textBox1.Text + @"'
                             WHERE Username = '" + UpdateusertextBoxUsername.Text + "'";
            SqlCommand cmd = new SqlCommand(newUsername, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void PasswordUpdate()
        {
            con.Open();

            string updatePassword = @"UPDATE Users 
                             SET Password = '" + Updateuserpasswordtextbox.Text + @"'
                             WHERE Username = '" + UpdateusertextBoxUsername.Text + "'";

            SqlCommand cmd = new SqlCommand(updatePassword, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void MailUpdate()
        {
            con.Open();

            string Query = @"UPDATE Users
                             SET Mail = '" + UpdateuserEmailtextbox.Text + @"'
                             WHERE Username = '" + UpdateusertextBoxUsername.Text + "'";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void WayofpaymentUpdate()
        {
            con.Open();

            string Query = @"UPDATE Users
                             SET WayofPayment = '" + comboBoxWayOfPayment.Text + @"'
                             WHERE Username = '" + UpdateusertextBoxUsername.Text + "'";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void PhoneUpdate()
        {
            con.Open();

            string Query = @"UPDATE Users
                             SET Phone = '" + UpdateUserPhoneTextbox.Text + @"'
                             WHERE Username = '" + UpdateusertextBoxUsername.Text + "'";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void UpdateUserButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(UpdateUserPhoneTextbox.Text))
                PhoneUpdate();

            if (!string.IsNullOrWhiteSpace(UpdateuserEmailtextbox.Text))
                MailUpdate();

            if (comboBoxWayOfPayment.Text != "Select")
                WayofpaymentUpdate();

            if (!string.IsNullOrWhiteSpace(UpdateUserPhoneTextbox.Text))
                PhoneUpdate();

            if (!string.IsNullOrWhiteSpace(Updateuserpasswordtextbox.Text))
                PasswordUpdate();

            if (!string.IsNullOrWhiteSpace(textBox1.Text))
                UpdateUsername();

            MessageBox.Show("Data for user " + UpdateusertextBoxUsername.Text + " updated successfully.");
        }
    }
}
