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
    public partial class Delete : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LELOUCH;Initial Catalog=\"IS Project\";Integrated Security=True");
        //connection_awad
        //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=\"IS Project\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader rdr;

        public Delete()
        {
            InitializeComponent();

        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSelectDelete.Visible = true;
            
            if (comboBoxDelete.Text == "User")
            {
                fillUserCombo();
            }

            else if (comboBoxDelete.Text == "Tour Place")
            {
                fillTourPlaceCombo();
            }

            else if (comboBoxDelete.Text == "Transportation")
            {
                fillTransCombo();
            }
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            con.Open();

            if (comboBoxDelete.Text == "User")
                cmd = new SqlCommand("DELETE FROM Users WHERE Username = '" + comboBoxSelectDelete.Text + "'", con);

            else if (comboBoxDelete.Text == "Tour Place")
                cmd = new SqlCommand("DELETE FROM TourPlace WHERE Name = '" + comboBoxSelectDelete.Text + "'", con);

            else if (comboBoxDelete.Text == "Transportation")
                cmd = new SqlCommand("DELETE FROM Transportation WHERE ID = '" + comboBoxSelectDelete.Text + "'", con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Successful deletion.");

            con.Close();

            if (comboBoxDelete.Text == "User")
                fillUserCombo();
            if (comboBoxDelete.Text == "Tour Place")
                fillTourPlaceCombo();
            if (comboBoxDelete.Text == "Transportation")
                fillTransCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHome admin_home = new AdminHome();
            admin_home.Show();
            this.Hide();
        }

        private void Delete_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void fillUserCombo()
        {
            comboBoxSelectDelete.Items.Clear();

            con.Open();
            cmd = new SqlCommand("SELECT Username FROM Users", con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
                comboBoxSelectDelete.Items.Add(rdr["Username"]);

            rdr.Close();
            con.Close();
        }

        private void fillTourPlaceCombo()
        {
            comboBoxSelectDelete.Items.Clear();

            con.Open();
            cmd = new SqlCommand("SELECT Name FROM TourPlace", con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
                comboBoxSelectDelete.Items.Add(rdr["Name"]);

            rdr.Close();
            con.Close();
        }

        private void fillTransCombo()
        {
            comboBoxSelectDelete.Items.Clear();

            con.Open();
            cmd = new SqlCommand("SELECT ID FROM Transportation", con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
                comboBoxSelectDelete.Items.Add(rdr["ID"]);

            rdr.Close();
            con.Close();
        }
    }
}
