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

            con.Open();
            
            if (comboBoxDelete.Text == "User")
            {
                comboBoxSelectDelete.Items.Clear();

                cmd = new SqlCommand("SELECT Username FROM Users", con);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                    comboBoxSelectDelete.Items.Add(rdr["Username"]);

                rdr.Close();
            }

            else if (comboBoxDelete.Text == "Tour Place")
            {
                comboBoxSelectDelete.Items.Clear();

                cmd = new SqlCommand("SELECT Name FROM TourPlace", con);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                    comboBoxSelectDelete.Items.Add(rdr["Name"]);

                rdr.Close();
            }

            else if (comboBoxDelete.Text == "Transportation")
            {
                comboBoxSelectDelete.Items.Clear();

                cmd = new SqlCommand("SELECT ID FROM Transportation", con);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                    comboBoxSelectDelete.Items.Add(rdr["ID"]);

                rdr.Close();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxDelete.Text == "User")
                cmd = new SqlCommand("DELETE FROM Users WHERE Username = '" + comboBoxSelectDelete.Text + "'", con);

            else if (comboBoxDelete.Text == "Tour Place")
                cmd = new SqlCommand("DELETE FROM TourPlace WHERE Name = '" + comboBoxSelectDelete.Text + "'", con);

            else if (comboBoxDelete.Text == "Transportation")
                cmd = new SqlCommand("DELETE FROM Transportation WHERE ID = '" + comboBoxSelectDelete.Text + "'", con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Successful deletion.");

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHome admin_home = new AdminHome();
            admin_home.Show();
            this.Hide();
        }
    }
}
