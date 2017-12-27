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
            con.Open();
            SqlCommand add_user = new SqlCommand("adduser", con);
            add_user.CommandType = CommandType.StoredProcedure;
            add_user.Parameters.Add(new SqlParameter("@username", AddusertextBoxUsername.Text));
            add_user.Parameters.Add(new SqlParameter("@password", Adduserpasswordtextbox.Text));
            add_user.Parameters.Add(new SqlParameter("@mail", AdduserEmailtextbox.Text));
            add_user.Parameters.Add(new SqlParameter("@phone", AddUserPhoneTextbox.Text));
            add_user.Parameters.Add(new SqlParameter("@wayofpayment", comboBox1.Text));
            if (AddUserPhoneTextbox.Text.Count() < 11 || AddUserPhoneTextbox.Text.Count() >= 12)
            {
                MessageBox.Show("The phone number is incorrect please try again");
            }
            
           else 
            {
                add_user.ExecuteNonQuery();
                MessageBox.Show("The User is added");
            }
            con.Close();

        }

        private void AddUserPhoneTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            this.Hide();
        }
    }
}
