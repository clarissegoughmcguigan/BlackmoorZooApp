using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackmoor_Zoo_App
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        public Point mouseLocation;

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minibtn_Click(object sender, EventArgs e)
        {
           this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void toAnimalbtn_Click(object sender, EventArgs e)
        {
            animalsForm f3 = new animalsForm();
            f3.Closed += (s, args) => this.Close();
            f3.Show();
            this.Hide();

        }

        private void toFacilitiesbtn_Click(object sender, EventArgs e)
        {
            facilitiesForm f5 = new facilitiesForm();
            f5.Closed += (s, args) => this.Close();
            f5.Show();
            this.Hide();
        }

        private void toBookbtn_Click(object sender, EventArgs e)
        {
            bookForm f6 = new bookForm();
            f6.Closed += (s, args) => this.Close();
            f6.Show();
            this.Hide();
        }

        private void toAccountbtn_Click(object sender, EventArgs e)
        {
            LoginForm f2 = new LoginForm();
            f2.Closed += (s, args) => this.Close();
            f2.Show();
            this.Hide();
        }
    }
}
