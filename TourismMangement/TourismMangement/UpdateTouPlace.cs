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
       // SqlConnection con = new SqlConnection("Data Source=LELOUCH;Initial Catalog=\"IS Project\";Integrated Security=True");

        //mai's con
       SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=IS Project;Integrated Security=True");



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
          //  MessageBox.Show("successfully updated The Location of " + ComboName.Text + ".", "Done!");

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
          //  MessageBox.Show("The Ticket Price of " + ComboName.Text + " is successfully updated.", "Done!");
            
        }

        private void update_Click(object sender, EventArgs e)
        {//we have to check also the name combo box first
            if (!string.IsNullOrWhiteSpace(ComboName.Text))
            {
                //if both are empty
                if (string.IsNullOrWhiteSpace(textBoxlocation.Text) && string.IsNullOrEmpty(textBoxticketprice.Text))
                {
                    MessageBox.Show("Please Fill The Location TextBox & the Ticket Price TextBox.", "Missing Data!");
                    return;
                }
                //if one text box is filled or both are filled
                else 
                {
                    bool updated = false;

                    if (!string.IsNullOrEmpty(textBoxticketprice.Text))
                    {
                        CheckTicketPriceAndUpdateIt();
                        updated = true;
                    }

                    if (!string.IsNullOrEmpty(textBoxlocation.Text))
                    {
                        UpdateLocation();
                        updated = true;
                    }

                    if (updated)
                        MessageBox.Show("successfully updated The Data of " + ComboName.Text + ".", "Done!");

                    return; 
                }
            }
            else
            {
                MessageBox.Show("Please Select The Name Of TourPlace.","Missing Data!");
            }
          
        }
       
        private bool CheckTicketPriceAndUpdateIt()
        {
            bool IsCorrect = true;
            for (int i = 0; i < textBoxticketprice.Text.Length; i++)
            {
                if (!char.IsNumber(textBoxticketprice.Text[i]) && textBoxticketprice.Text[i]!='.')
                {
                    MessageBox.Show("Please Enter Numbers Only in Ticket Price Text Box.", "Invalid Input");
                    IsCorrect = false;
                    return IsCorrect;
                }
            }
            if (IsCorrect)
                UpdateTicketPrice();
            return IsCorrect;

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Update U = new Update();
            U.Show();
            this.Hide();
        }
    }
}
