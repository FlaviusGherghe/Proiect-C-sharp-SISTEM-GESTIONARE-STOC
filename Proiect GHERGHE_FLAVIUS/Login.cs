using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_GHERGHE_FLAVIUS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UserTb.Text == "Admin" && ParolaTb.Text == "Admin")
            {
                Stocuri Obj = new Stocuri();
                Obj.Show();
                this.Hide();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}