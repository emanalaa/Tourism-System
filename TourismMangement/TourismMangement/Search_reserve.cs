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
    {
        SqlConnection con = new SqlConnection("Data Source=LELOUCH;Initial Catalog=\"IS Project\";Integrated Security=True");
        public Search_reserve()
        {
            InitializeComponent();
        }

        private void SearchTourPlaceComboBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void TransportationComboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Type from Transportation where  Destination =" + SearchTourPlaceComboBox.Text, con);
            cmd.CommandType = CommandType.Text;

            SqlDataReader reader = cmd.ExecuteReader();
           
            while(reader.Read())
            {
                string trans = (string)reader["Type"];
                TransportationComboBoxSearch.Items.Add(trans);
            }
            reader.Close();
            con.Close();
        }

        private void ReserveButton_Click(object sender, EventArgs e)
        {
            con.Open();
            string ReserveTourPlace = @"insert into User_TourPlace(UserID,TourPlaceID) values (@userID,@TourplaceID);";
            string ReserveTransport = @"insert into User_Transportation(UserID,TransportationID) values (@userID,@TransID);";

            SqlCommand cmd = new SqlCommand(ReserveTourPlace,con);
            SqlCommand cmd1 = new SqlCommand(ReserveTransport,con);

            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();

            SqlParameter userID = new SqlParameter("@UserID",Login.currentUsername);
            SqlParameter TourID = new SqlParameter("@TourPlaceID",TourPlaceID());
            SqlParameter TranID = new SqlParameter("@TransportationID",TransportationID());

            cmd.Parameters.Add(userID);
            cmd.Parameters.Add(TourID);
            cmd.Parameters.Add(TranID);


            con.Close();

            MessageBox.Show("Congratualtions, you have reserved a visit to "+SearchTourPlaceComboBox.Text+". Have fun.");
        }
        private int TourPlaceID()
        {
            con.Open();
            
            SqlCommand command = new SqlCommand("Select ID from TourPlace where Name ='"+SearchTourPlaceComboBox.Text+"';", con);
            SqlDataReader reader = command.ExecuteReader();

            int TourID = (int)reader["ID"];

            reader.Close();
            con.Close();
            return TourID;
        }
        private int TransportationID()
        {
            con.Open();

            SqlCommand command = new SqlCommand("Select ID from Transportation where Name ='" + TransportationComboBoxSearch.Text + "';", con);
            SqlDataReader reader = command.ExecuteReader();

            int Transportationid = (int)reader["ID"];

            reader.Close();
            con.Close();
            return Transportationid ;
        }
    }
}
