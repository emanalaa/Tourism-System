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
    public partial class AddUser : Form
    {
       // SqlConnection con = new SqlConnection("Data Source=LELOUCH;Initial Catalog=\"IS Project\";Integrated Security=True");
        //connection_awad
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=\"IS Project\";Integrated Security=True");
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            if (adduserconfirmpasswordtextBox.Text.Count() != 0 && Adduserpasswordtextbox.Text.Count() != 0 && AddusertextBoxUsername.Text.Count() != 0 && AddUserPhoneTextbox.Text.Count() != 0 && AdduserEmailtextbox.Text.Count() != 0 && comboBox1.Text.Count() != 0)
            {
                con.Open();
                SqlCommand add_user = new SqlCommand("adduser", con);
                add_user.CommandType = CommandType.StoredProcedure;
                add_user.Parameters.Add(new SqlParameter("@username", AddusertextBoxUsername.Text));
                add_user.Parameters.Add(new SqlParameter("@password", Adduserpasswordtextbox.Text));
                add_user.Parameters.Add(new SqlParameter("@mail", AdduserEmailtextbox.Text));
                add_user.Parameters.Add(new SqlParameter("@phone", AddUserPhoneTextbox.Text));
                add_user.Parameters.Add(new SqlParameter("@wayofpayment", comboBox1.Text));
                SqlCommand check_user = new SqlCommand("select username from Users", con);
                SqlDataReader rdr = check_user.ExecuteReader();
                while (rdr.Read())
                {
                    if (AddusertextBoxUsername.Text == (string)rdr["username"])
                    {
                        MessageBox.Show("This username is already taken please enetr another username");
                        con.Close();
                        return;
                    }
                }
                if (AddUserPhoneTextbox.Text.Count() != 11)
                {
                    MessageBox.Show("The phone number is incorrect please try again");

                }
                else if (Adduserpasswordtextbox.Text.Count() < 7)
                {
                    MessageBox.Show("The password is very weak");
                }
                else if (adduserconfirmpasswordtextBox.Text != Adduserpasswordtextbox.Text)
                {
                    MessageBox.Show("The confirm password is incorrect");
                }
                else
                {
                    add_user.ExecuteNonQuery();
                    MessageBox.Show("The User is added");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please make sure you filled all slots.");
            }

        }

        private void AddUserPhoneTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
