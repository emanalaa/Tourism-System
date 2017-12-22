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
            string EnterPassWord = textBoxPassword.Text;
            string ConPassWord = textBoxConfirmPassword.Text;

            //mai con
            //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=IS Project;Integrated Security=True");

            //mohie con
            SqlConnection con = new SqlConnection("Data Source = LELOUCH; Initial Catalog =\"IS Project\";Integrated Security=True");

            con.Open();

            string Insetstr = @"insert into Users (Username ,Mail,Phone,WayofPayment,password)
                                values (@UserName,@Email,@Phone,@WayOfPayment,@Password)";


            SqlCommand cmd = new SqlCommand(Insetstr, con);

            while (EnterPassWord != ConPassWord && EnterPassWord.Length!=0)
            {
                MessageBox.Show("Inavlid Input", "Please Re-Enter the Correct Password");

            }
            SqlParameter UserName = new SqlParameter("@UserName", textBoxUsername.Text);
            cmd.Parameters.Add(UserName);

            SqlParameter PassWord = new SqlParameter("@Password", textBoxPassword.Text);
            cmd.Parameters.Add(PassWord);

            SqlParameter Email = new SqlParameter("@Email", textBoxEmail.Text);
            cmd.Parameters.Add(Email);

            SqlParameter Phone = new SqlParameter("@Phone", textBoxPhone.Text);
            cmd.Parameters.Add(Phone);

            SqlParameter WayOfPayment = new SqlParameter("@WayOfPayment", domainUpDownWayOfPayment.Text);
            cmd.Parameters.Add(WayOfPayment);


            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Welcome ! ");
            //the user should go to UserHome form
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            Insert();
        }
    }
}
