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
    public partial class Display : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=LELOUCH;Initial Catalog=\"IS Project\";Integrated Security=True");
        //connection_awad
         SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=\"IS Project\";Integrated Security=True");
        public Display()
        {
            InitializeComponent();
            comboBoxDisplay.Items.Add("Users");
            comboBoxDisplay.Items.Add("Transportaton");
            comboBoxDisplay.Items.Add("Tourplace");
        }

        private void Display_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDisplay.Text == "Users")
            {
                con.Open();
                SqlCommand show_users = new SqlCommand("select * from Users", con);
                SqlDataReader users_data = show_users.ExecuteReader();
                DataTable users = new DataTable();
                users.Columns.Add("Username");
                users.Columns.Add("Password");
                users.Columns.Add("Mail");
                users.Columns.Add("Phone");
                users.Columns.Add("WayofPayment");
                DataRow row;
                while (users_data.Read())
                {
                    row = users.NewRow();
                    row["Username"] = users_data["Username"];
                    row["Password"] = users_data["Password"];
                    row["Mail"] = users_data["Mail"];
                    row["Phone"] = users_data["Phone"];
                    row["WayofPayment"] = users_data["WayofPayment"];
                    users.Rows.Add(row);
                }
                users_data.Close();
                con.Close();
                dataGridViewDisplay.DataSource = users;
            }
            else if (comboBoxDisplay.Text == "Transportaton")
            {
                con.Open();
                SqlCommand show_transportaion = new SqlCommand("select * from Transportation",con);
                SqlDataReader transportaion_data = show_transportaion.ExecuteReader();
                DataTable transportations = new DataTable();
                transportations.Columns.Add("ID");
                transportations.Columns.Add("Type");
                transportations.Columns.Add("DepartureTime");
                transportations.Columns.Add("ArrivalTime");
                transportations.Columns.Add("Origin");
                transportations.Columns.Add("Destination");
                DataRow row;
                while (transportaion_data.Read())
                {
                    row = transportations.NewRow();
                    row["ID"] = transportaion_data["ID"];
                    row["Type"] = transportaion_data["Type"];
                    row["DepartureTime"] = transportaion_data["DepartureTime"];
                    row["ArrivalTime"] = transportaion_data["ArrivalTime"];
                    row["Origin"] = transportaion_data["Origin"];
                    row["Destination"] = transportaion_data["Destination"];
                    transportations.Rows.Add(row);
                }
                transportaion_data.Close();
                con.Close();
                dataGridViewDisplay.DataSource = transportations;
            }
            else if (comboBoxDisplay.Text == "Tourplace")
            {
                con.Open();
                SqlCommand show_tourplaces = new SqlCommand("select * from TourPlace", con);
                SqlDataReader tourplaces_data = show_tourplaces.ExecuteReader();
                DataTable tourplaces = new DataTable();
                tourplaces.Columns.Add("ID");
                tourplaces.Columns.Add("Name");
                tourplaces.Columns.Add("Location");
                tourplaces.Columns.Add("TicketPrice");
                DataRow row;
                while (tourplaces_data.Read())
                {
                    row = tourplaces.NewRow();
                    row["ID"] = tourplaces_data["ID"];
                    row["Name"] = tourplaces_data["Name"];
                    row["Location"] = tourplaces_data["Location"];
                    row["TicketPrice"] = tourplaces_data["TicketPrice"];
                    tourplaces.Rows.Add(row);
                }
                tourplaces_data.Close();
                con.Close();
                dataGridViewDisplay.DataSource = tourplaces;
            }
        }

        private void dataGridViewDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHome admin_home = new AdminHome();
            admin_home.Show();
            this.Hide();
        }
    }
}
