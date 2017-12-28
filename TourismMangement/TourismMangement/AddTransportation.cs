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
    public partial class AddTransportation : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=LELOUCH;Initial Catalog=\"IS Project\";Integrated Security=True");
        //connection_awad
         SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=\"IS Project\";Integrated Security=True");
        public AddTransportation()
        {
            InitializeComponent();
            for (int i=0; i<23; i++)
            {
                comboBoxArrivalHours.Items.Add(i);
                comboBoxDepartureHour.Items.Add(i);
            }
            for (int i =0; i<59; i++)
            {
                comboBoxArrivalMinutes.Items.Add(i);
                comboBoxDepartureMinutes.Items.Add(i);
            }
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand add_transp = new SqlCommand("addtransportation", con);
            add_transp.CommandType = CommandType.StoredProcedure;
            add_transp.Parameters.Add(new SqlParameter("@type", textBoxType.Text));
            add_transp.Parameters.Add(new SqlParameter("@origin", comboBoxOrigin.Text));
            add_transp.Parameters.Add(new SqlParameter("@destination", comboBoxDestination.Text));

            string dep_time = Convert.ToString(comboBoxDepartureHour.Text) + ":" + Convert.ToString(comboBoxDepartureMinutes.Text);
            TimeSpan departuretime = TimeSpan.Parse(dep_time);
            string arr_time = Convert.ToString(comboBoxArrivalHours.Text) + ":" + Convert.ToString(comboBoxArrivalMinutes.Text);
            TimeSpan arrivaltime = TimeSpan.Parse(arr_time);

            add_transp.Parameters.Add(new SqlParameter("@arrivaltime", arrivaltime));
            add_transp.Parameters.Add(new SqlParameter("@departuretime", departuretime));

            add_transp.ExecuteNonQuery();
            MessageBox.Show("Transportaion is added");
            con.Close();

        }

        

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            this.Hide();
        }
    }
}
