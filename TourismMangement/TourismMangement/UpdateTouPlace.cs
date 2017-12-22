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
        //SqlConnection con = new SqlConnection("Data Source=LELOUCH;Initial Catalog=\"IS Project\";Integrated Security=True");

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
            SqlCommand cmd = new SqlCommand(comstr,con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                comboBoxName.Items.Add(rdr["Name"].ToString());
            }
            con.Close();
            rdr.Close();

        }

        //private void UpdateTourPlaceName()
        //{
        //    con.Open();

        //    string Query = @"UPDATE  TourPlace
        //                     SET (Name = '" + textBoxname.Text + "');

        //  //  MessageBox.Show(Query);
        //    SqlCommand cmd = new SqlCommand(Query, con);
        //    cmd.ExecuteNonQuery();

        //    con.Close();
        //}

    }
}
