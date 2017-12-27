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
    public partial class Login : Form
    {
        public static string AdminUsername = "admin";
        public static string AdminPassword = "admin";
        public static string currentUsername;

        SqlConnection con = new SqlConnection("Data Source=LELOUCH;Initial Catalog=\"IS Project\";Integrated Security=True");
        //connection_awad
        //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=\"IS Project\";Integrated Security=True");
        public Login()
        {
            InitializeComponent();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            //mai's con
            // SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=IS Project;Integrated Security=True");

            //mohie's con
           // SqlConnection con = new SqlConnection("Data Source=LELOUCH;Initial Catalog=\"IS Project\";Integrated Security=True");

            con.Open();
            if (AdminUsername==TextBoxUsername.Text || AdminPassword==TextBoxPassword.Text )
            {
                AdminHome admin_home = new AdminHome();
                admin_home.Show();
                this.Close();
                
            }

            else
            {
                bool alreadyuser = false;
                SqlCommand show_username_pass = new SqlCommand("select username , password from users", con);
                SqlDataReader username_password = show_username_pass.ExecuteReader();
                while (username_password.Read())
                {
                    if ((string)username_password["username"] == TextBoxUsername.Text && (string)username_password["password"] == TextBoxPassword.Text)
                    {
                        currentUsername = TextBoxUsername.Text;
                        UserHome user_home = new UserHome();
                        user_home.Show();
                        this.Close();
                        alreadyuser = true;
                    }
                    else if ((string)username_password["username"] == TextBoxUsername.Text && (string)username_password["password"] != TextBoxPassword.Text)
                    {
                        MessageBox.Show("The Username or Password is incorrect please try again or Register");
                        alreadyuser = true;
                       
                    }
                    
                }
                if (alreadyuser==false)
                {
                    MessageBox.Show("The Username or Password is incorrect please try again or Register");
                }
                username_password.Close();

            }

            con.Close();
        }
    }
}
