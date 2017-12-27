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
    public partial class AddTourPlace : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LELOUCH;Initial Catalog=\"IS Project\";Integrated Security=True");
        public AddTourPlace()
        {
            InitializeComponent();
        }

        private void InsertTourPlace()
        {
            if(!string.IsNullOrWhiteSpace(textBoxname.Text) && !string.IsNullOrWhiteSpace(textBoxlocation.Text) && !string.IsNullOrWhiteSpace(textBoxlocation.Text))
            {
                con.Open();
                string insertname = @"insert into TourPlace(Name,Location,TicketPrice) values (@name,@location,@ticket);";
                SqlCommand cmd = new SqlCommand(insertname,con);

                SqlParameter name = new SqlParameter("@name",textBoxname.Text);
                SqlParameter location = new SqlParameter("@location",textBoxlocation.Text);
                SqlParameter ticket = new SqlParameter("@ticket",textBoxticketprice.Text);

                cmd.Parameters.Add(name);
                cmd.Parameters.Add(location);
                cmd.Parameters.Add(ticket);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Tourplace added successfully.");
            }
            else
            {
                MessageBox.Show("Please make sure you filled all slots.");
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            InsertTourPlace();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
            this.Hide();
        }
    }
}
