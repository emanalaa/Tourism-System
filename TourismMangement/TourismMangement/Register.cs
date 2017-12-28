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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        public void Insert()
        {
            string user = textBoxUsername.Text;
            string EnterPassWord = textBoxPassword.Text;
            string ConPassWord = textBoxConfirmPassword.Text;

            if(textBoxPhone.Text.Count() < 11 || textBoxPhone.Text.Count() >= 12)
            {
                MessageBox.Show("Phone number must be 11 digits.");
                return;
            }

            //mai con
            //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=IS Project;Integrated Security=True");

            //mohie con
             SqlConnection con = new SqlConnection("Data Source = LELOUCH; Initial Catalog =\"IS Project\";Integrated Security=True");

            //connection_awad
            //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=\"IS Project\";Integrated Security=True");
            con.Open();

            string Insetstr = @"insert into Users (Username ,Mail,Phone,WayofPayment,password)
                                values (@UserName,@Email,@Phone,@WayOfPayment,@Password)";


            SqlCommand cmd = new SqlCommand(Insetstr, con);

            if (EnterPassWord != ConPassWord && EnterPassWord.Length!=0)
            {
                MessageBox.Show("Please Re-Enter the Correct Password." , "Inavlid Input");
                return;

            }
            SqlParameter UserName = new SqlParameter("@UserName", textBoxUsername.Text);
            cmd.Parameters.Add(UserName);

            SqlParameter PassWord = new SqlParameter("@Password", textBoxPassword.Text);
            cmd.Parameters.Add(PassWord);

            SqlParameter Email = new SqlParameter("@Email", textBoxEmail.Text);
            cmd.Parameters.Add(Email);

            SqlParameter Phone = new SqlParameter("@Phone", textBoxPhone.Text);
            cmd.Parameters.Add(Phone);

            SqlParameter WayOfPayment = new SqlParameter("@WayOfPayment", comboBoxWayOfPayment.Text);
            cmd.Parameters.Add(WayOfPayment);


            SqlCommand comand = new SqlCommand("select  Username from Users", con);
            SqlDataReader rdr = comand.ExecuteReader();

            while (rdr.Read())
            {
                if(user== rdr["Username"].ToString())
                {
                    MessageBox.Show("This Username Already taken.","Change Username!");
                    rdr.Close();
                    return;
                }
            }

            rdr.Close();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Welcome!","New User");

            //the user should go to UserHome form
            UserHome h = new UserHome();
            h.Show();
            this.Hide();

       
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            Login_Register logorreg = new Login_Register();
            logorreg.Show();
            this.Hide();
        }
    }
}
