using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackmoor_Zoo_App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public Point mouseLocation;

        string filepath = "login.txt";
       
        ArrayList allUsernames = new ArrayList();

        Dictionary<String,String> usernameANDpassword = new Dictionary<String,String>();

        public void getUsers()
        {
            string[] lines = File.ReadAllLines(filepath);
            string[] values;
            string email = "";
            string password = "";

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(':');

                if (values[0].Trim().Equals("Email"))
                {
                    email = values[1];
                    allUsernames.Add(email);
                }
                else if (values[0].Trim().Equals("Password"))
                {
                    password = values[1];
                    
                }
                if (email != "" && password != "")
                {
                    usernameANDpassword.Add(email, password);
                    email = "";
                    password = "";
                }
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minibtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void signinForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signinForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void signinForm_MouseMove(object sender, MouseEventArgs e)
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

        private void registerbtn_Click(object sender, EventArgs e)
        {
            Registration f4 = new Registration();
            f4.Closed += (s, args) => this.Close();
            f4.Show();
            this.Hide();
        }

        private void signinbtn_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text;
            string password = passTxt.Text;
            bool userExist = false;

            if (email.Trim().Equals("") || password.Trim().Equals(""))
            {
                MessageBox.Show("You need to enter email and password");
            }
            else
            {
                foreach(var uname in usernameANDpassword)
                {
                    if (uname.Key.ToString().Trim().Equals(email))
                    {
                        if(uname.Value.Trim().Equals(password))
                        {
                            userExist = true;
                            break;
                        }
                    }
                }
                if(userExist)
                {
                    MessageBox.Show("yes");
                }
                else
                {
                    MessageBox.Show("No");
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            getUsers();
        }
    }
}
