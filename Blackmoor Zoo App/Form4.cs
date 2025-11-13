using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackmoor_Zoo_App
{
    public partial class Registration : Form
    {
        public Registration()
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
            WindowState = FormWindowState.Minimized;
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
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
            LoginForm f2 = new LoginForm();
            f2.Closed += (s, args) => this.Close();
            f2.Show();
            this.Hide();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            string Name = nameTxt.Text;
            string Email = emailTxt.Text;
            string Username = userTxt.Text;
            string Password = passTxt.Text;

            if (!File.Exists("login.txt")) // If file does not exists
            {
                File.Create("login.txt").Close(); // Create file
                using (StreamWriter sw = File.AppendText("login.txt"))
                {
                    sw.Write("Name: " + Name);
                    sw.WriteLine("");
                    sw.Write("Email: " + Email);
                    sw.WriteLine("");
                    sw.Write("Username: " + Username);
                    sw.WriteLine("");
                    sw.Write("Password: " + Password);
                    sw.WriteLine("");
                    if (checkBoxConsent.Checked)
                    {
                        sw.Write("Yes");
                    }
                    else
                    {
                        sw.Write("No");
                    }
                    sw.WriteLine("");
                    sw.WriteLine("----------");
                    sw.WriteLine("");
                    sw.Close();
                    MessageBox.Show("Account Created");
                }
            }
            else // If file already exists
            {
                // File.WriteAllText("FILENAME.txt", String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText("login.txt"))
                {
                    sw.Write("Name: " + Name);
                    sw.WriteLine("");
                    sw.Write("Email: " + Email);
                    sw.WriteLine("");
                    sw.Write("Username: " + Username);
                    sw.WriteLine("");
                    sw.Write("Password: " + Password);
                    sw.WriteLine("");
                    if (checkBoxConsent.Checked)
                    {
                        sw.Write("Yes");
                    }
                    else
                    {
                        sw.Write("No");
                    }
                    sw.WriteLine("");
                    sw.WriteLine("----------");
                    sw.WriteLine("");
                    sw.Close();
                    MessageBox.Show("Account Created");
                }
            }
        }

        private void checkBoxConsent_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
