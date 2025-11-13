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
    public partial class facilitiesForm : Form
    {
        public facilitiesForm()
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

        private void backbtn_Click(object sender, EventArgs e)
        {
            HomeForm f1 = new HomeForm();
            f1.Closed += (s, args) => this.Close();
            f1.Show();
            this.Hide();
        }
    }
}
