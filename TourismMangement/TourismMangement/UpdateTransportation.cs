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
using System.Globalization;

namespace TourismMangement
{
    public partial class UpdateTransportation : Form
    {

        //mai's con
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=IS Project;Integrated Security=True");

        public UpdateTransportation()
        {
            InitializeComponent();
            LoadTransIDs();
            LoadHrMin();
        }
        private void LoadHrMin()
        {
            //hours
            for(int i = 0; i <= 24; i++)
            {
                comboDepartureHour.Items.Add(i.ToString());
                comboArrivalHours.Items.Add(i.ToString());
            }
            //mins
            for(int i = 0; i <60; i++)
            {
                comboDepartureMinutes.Items.Add(i.ToString());
                comboArrivalMinutes.Items.Add(i.ToString());
            }
        }

        private void LoadTransIDs()
        {
            con.Open();
            string str = "select * from Transportation";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                comboBoxIDOfTrans.Items.Add(rdr["ID"].ToString());
            }
            con.Close();
            rdr.Close();
        }
        private void UpdateType()
        {
                con.Open();
                string str = @"update Transportation
                         set Type='" + textBoxType.Text + @"'
                         where ID= '" + comboBoxIDOfTrans.Text + "'";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
               // MessageBox.Show("successfully updated The Type of Transportation ID no.: " + comboBoxIDOfTrans.Text + ".", "Done!");
            
        }
        private void UpdateOrigin()
        {
            con.Open();
            string str = @"update Transportation
                         set Origin='" + TextBoxOrigin.Text + @"'
                         where ID= '" + comboBoxIDOfTrans.Text + "'";

            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
           // MessageBox.Show("successfully updated The Origin of Transportation ID no.: " + comboBoxIDOfTrans.Text + ".", "Done!");

        }
        private void UpdateDestination()
        {
            con.Open();
            string str = @"update Transportation
                         set Destination='" + TextBoxDestination.Text + @"'
                         where ID= '" + comboBoxIDOfTrans.Text + "'";

            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
          //  MessageBox.Show("successfully updated The Destination of Transportation ID no.: " + comboBoxIDOfTrans.Text + ".", "Done!");

        }
        private void UpdateDepartureTime()
        {
            string timeHr = comboDepartureHour.Text;
            string timeMin = comboDepartureMinutes.Text;
            string Time = timeHr +":"+timeMin;
            TimeSpan DepTime = TimeSpan.Parse(Time);
            con.Open();
            string str = @"update Transportation
                         set DepartureTime='" + DepTime.ToString() + @"'
                         where ID= '" + comboBoxIDOfTrans.Text + "'";

            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
           // MessageBox.Show("successfully updated The Departure Time of Transportation ID no.: " + comboBoxIDOfTrans.Text + ".", "Done!");

        }
        private void UpdateArivalTime()
        {
            string timeHr = comboArrivalHours.Text;
            string timeMin = comboArrivalMinutes.Text;
            string Time = timeHr+":"+ timeMin;
            TimeSpan ArivalTime = TimeSpan.Parse(Time);
            con.Open();
            string str = @"update Transportation
                         set ArrivalTime='" + ArivalTime.ToString() + @"'
                         where ID= '" + comboBoxIDOfTrans.Text + "'";

            SqlCommand cmd = new SqlCommand(str, con);
                       
            cmd.ExecuteNonQuery();
            con.Close();
            //MessageBox.Show("successfully updated The Arival Time of Transportation ID no.: " + comboBoxIDOfTrans.Text + ".", "Done!");

        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            //the id box must be filled else all the data will be removed 
            if (string.IsNullOrWhiteSpace(comboBoxIDOfTrans.Text) )
            {
                MessageBox.Show("Please Fill The ID ComboBox.", "Missing Data!");
                return;
            }
            else
            {
                //if all boxs are empty
                if (string.IsNullOrWhiteSpace(textBoxType.Text)&&string.IsNullOrWhiteSpace(TextBoxOrigin.Text)&&string.IsNullOrWhiteSpace(TextBoxDestination.Text)&&string.IsNullOrWhiteSpace(comboDepartureHour.Text)&&string.IsNullOrWhiteSpace(comboDepartureMinutes.Text)&&string.IsNullOrWhiteSpace(comboArrivalHours.Text) &&string.IsNullOrWhiteSpace(comboArrivalMinutes.Text))
                {
                    MessageBox.Show("Please Fill the desired date to be updated.", "Missing Data!");
                    return;
                }
                
                else
                {
                    //if all are filled or less
                    if (!string.IsNullOrWhiteSpace(textBoxType.Text))
                        UpdateType();
                    if (!string.IsNullOrWhiteSpace(TextBoxOrigin.Text))
                        UpdateOrigin();
                    if (!string.IsNullOrWhiteSpace(TextBoxDestination.Text))
                        UpdateDestination();
                    if (!string.IsNullOrWhiteSpace(comboDepartureHour.Text)&& !string.IsNullOrWhiteSpace(comboDepartureMinutes.Text))
                        UpdateDepartureTime();
                    if (!string.IsNullOrWhiteSpace(comboArrivalHours.Text) && !string.IsNullOrWhiteSpace(comboArrivalMinutes.Text))
                        UpdateArivalTime();
                   // MessageBox.Show("successfully updated", "Done!");
                    MessageBox.Show("successfully updated The Data of Transportation ID no.: " + comboBoxIDOfTrans.Text + ".", "Done!");

                    return;

                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Update u = new Update();
            u.Show();
            this.Hide();
        }
    }
}
