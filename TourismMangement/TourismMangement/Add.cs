using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourismMangement
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            AddUser adduser = new AddUser();
            adduser.Show();
            this.Hide();
        }

        private void ButtonAddTrans_Click(object sender, EventArgs e)
        {
            AddTransportation tranadd = new AddTransportation();
            tranadd.Show();
            this.Hide();
        }

        private void ButtonAddTourplace_Click(object sender, EventArgs e)
        { 
            AddTourPlace ATP = new AddTourPlace();
            ATP.Show();
            this.Hide();
        }
    }
}
