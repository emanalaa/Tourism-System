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
    public partial class Login_Register : Form
    {
        public Login_Register()
        {
            InitializeComponent();


            //this.BackgroundImage = Properties.Resources.LoginBackGround__1_;
            //Timer tim = new Timer();
            //tim.Interval = 2500;
            //tim.Tick += new EventHandler(changeimage);
            //tim.Start();
        }

        //private void changeimage(object sender, EventArgs e)
        //{

        //    List<Bitmap> b1 = new List<Bitmap>();
        //    b1.Add(Properties.Resources.LoginBackGround__2_);
        //    b1.Add(Properties.Resources.LoginBackGround__3_);
        //    b1.Add(Properties.Resources.LoginBackGround__4_);
        //    b1.Add(Properties.Resources.LoginBackGround__5_);
        //    b1.Add(Properties.Resources.LoginBackGround__6_);
        //    b1.Add(Properties.Resources.LoginBackGround__7_);
        //    b1.Add(Properties.Resources.Background8);

        //    int index = DateTime.Now.Second % b1.Count;
        //    this.BackgroundImage = b1[index];
        //}

        private void ButtonSignIn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
