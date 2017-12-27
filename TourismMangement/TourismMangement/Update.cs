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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void ButtonUpdateUser_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.Show();
            this.Hide();
        }

        private void ButtonUpdateTrans_Click(object sender, EventArgs e)
        {
            UpdateTransportation trans = new UpdateTransportation();
            trans.Show();
            this.Hide();
        }

        private void ButtonUpdateTouplace_Click(object sender, EventArgs e)
        {
            UpdateTouPlace tou = new UpdateTouPlace();
            tou.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHome adminhome = new AdminHome();
            adminhome.Show();
            this.Hide();
        }
    }
}
