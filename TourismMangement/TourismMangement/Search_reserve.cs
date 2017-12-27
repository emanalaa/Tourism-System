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
    public partial class Search_reserve : Form
    {//add_tickket_price_and_time_of_leaving
        SqlConnection con = new SqlConnection("Data Source=LELOUCH;Initial Catalog=\"IS Project\";Integrated Security=True");
        public Search_reserve()
        {
            InitializeComponent();
            fillTourPlaceComboBox();
        }

        public void fillTourPlaceComboBox()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Select Name from TourPlace;", con);
            cmd.CommandType = CommandType.Text;

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string TourPlaceName = (string)reader["Name"];
                SearchTourPlaceComboBox.Items.Add(TourPlaceName);
            }

            reader.Close();
            con.Close();
        }

        private void ReserveButton_Click(object sender, EventArgs e)
        {
            con.Open();
            string ReserveTourPlace = @"insert into User_TourPlace(UserID,TourPlaceID) values (@UserID,@TourplaceID);";
            string ReserveTransport = @"insert into User_Transportation(UserID,TransportationID) values (@UserID,@TransID);";

            SqlCommand cmd = new SqlCommand(ReserveTourPlace,con);
            SqlCommand cmd1 = new SqlCommand(ReserveTransport,con);

            SqlParameter UserID = new SqlParameter("@UserID",findID());
            SqlParameter TourID = new SqlParameter("@TourPlaceID",TourPlaceID());
            SqlParameter TransID = new SqlParameter("@TransID",TransportationID());
            SqlParameter userID = new SqlParameter("@UserID",findID());

            cmd.Parameters.Add(UserID);
            cmd.Parameters.Add(TourID);

            cmd1.Parameters.Add(TransID);
            cmd1.Parameters.Add(userID);


            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();


            con.Close();

            MessageBox.Show("Congratualtions, you have reserved a visit to "+SearchTourPlaceComboBox.Text+". Have fun.");
        }
        private int TourPlaceID()
        {
            SqlCommand command = new SqlCommand("Select ID from TourPlace where Name ='"+SearchTourPlaceComboBox.Text+"';", con);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            int TourID = (int)reader["ID"];

            reader.Close();
            return TourID;
        }
        private int TransportationID()
        {
            SqlCommand command = new SqlCommand("Select ID from Transportation where Type ='" + TransportationComboBoxSearch.Text + "';", con);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            int Transportationid = (int)reader["ID"];

            reader.Close();
            return Transportationid ;
        }

        private void SearchTourPlaceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TransportationComboBoxSearch.Items.Clear();

            con.Open();
            SqlCommand cmd = new SqlCommand("Select Type from Transportation where Destination = '" + SearchTourPlaceComboBox.Text + "';", con);
            cmd.CommandType = CommandType.Text;

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string trans = (string)reader["Type"];
                TransportationComboBoxSearch.Items.Add(trans);
            }
            reader.Close();
            con.Close();
        }

        private int findID()
        {
            SqlCommand command = new SqlCommand("select ID from Users where Username='"+Login.currentUsername+"'",con);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int ID = (int)reader["ID"];
            reader.Close();
            return ID; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserHome userhome = new UserHome();
            userhome.Show();
            this.Hide();
        }
    }
}
