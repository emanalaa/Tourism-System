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
            this.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
        }
       
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
