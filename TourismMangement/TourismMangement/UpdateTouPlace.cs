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
    public partial class UpdateTouPlace : Form
    {
        //mohie's con
        SqlConnection con = new SqlConnection("Data Source=LELOUCH;Initial Catalog=\"IS Project\";Integrated Security=True");

        //mai's con
      // SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=IS Project;Integrated Security=True");



        public UpdateTouPlace()
        {
            InitializeComponent();
            LoadTourplaceNames();
        }
        private void LoadTourplaceNames()
        {
            con.Open();
            string comstr = "  select * from TourPlace";
            SqlCommand cmd = new SqlCommand(comstr, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                ComboName.Items.Add(rdr["Name"].ToString());
            }
            con.Close();
            rdr.Close();

        }

        private void UpdateLocation()
        {
            con.Open();
            string str = @"update TourPlace
                         set Location='" + textBoxlocation.Text + @"'
                         where Name= '" + ComboName.Text + "'";

            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully updated The Location of " + ComboName.Text + ".", "Done!");

        }
        private void UpdateTicketPrice()
        {
            con.Open();
            string str = @"update TourPlace
                         set TicketPrice='" + textBoxticketprice.Text + @"'
                         where Name= '" + ComboName.Text + "'";

            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The Ticket Price of " + ComboName.Text + " is successfully updated.", "Done!");
            
        }

        private void update_Click(object sender, EventArgs e)
        {
            //if both are empty
            if (string.IsNullOrWhiteSpace(textBoxlocation.Text) && string.IsNullOrEmpty(textBoxticketprice.Text))
            {
                MessageBox.Show("Please Fill The Location TextBox & the Ticket Price TextBox.", "Missing Data!");
                return;
            }
            //if both are filled
            else if (!string.IsNullOrWhiteSpace(textBoxlocation.Text) && !string.IsNullOrEmpty(textBoxticketprice.Text))
            {
                CheckTicketPriceAndUpdateIt();
                UpdateLocation();
                return;
            }
            //if one text box is filled
            else if (!string.IsNullOrWhiteSpace(textBoxlocation.Text) || !string.IsNullOrEmpty(textBoxticketprice.Text))
            {

                if (!string.IsNullOrEmpty(textBoxticketprice.Text))
                {
                    CheckTicketPriceAndUpdateIt();
                    return;
                }
                else
                {
                    UpdateLocation();
                    return;
                }
            }
          
        }
       
        private void CheckTicketPriceAndUpdateIt()
        {
            bool IsCorrect = true;
            for (int i = 0; i < textBoxticketprice.Text.Length; i++)
            {
                if (!char.IsNumber(textBoxticketprice.Text[i]))
                {
                    MessageBox.Show("Please Enter Numbers Only in Ticket Price Text Box.", "Invalid Input");
                    IsCorrect = false;
                    return;
                }
            }
            if (IsCorrect)
                UpdateTicketPrice();

        }
    }
}
