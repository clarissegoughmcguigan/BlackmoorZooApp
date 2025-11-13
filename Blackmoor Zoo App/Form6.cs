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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Blackmoor_Zoo_App
{
    public partial class bookForm : Form
    {
        public bookForm()
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

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            string Persons = textBoxPeople.Text;
            string total = textBoxTotal.Text;
            string date = dateTimePickerBooker.Text;

            if (!File.Exists("booking.txt")) // If file does not exists
            {
                File.Create("booking.txt").Close(); // Create file
                using (StreamWriter sw = File.AppendText("booking.txt"))
                {
                    sw.Write("Persons: " + Persons);
                    sw.WriteLine("");
                    sw.Write("Total: " + total);
                    sw.WriteLine("");
                    sw.Write("date: " + date);
                    sw.WriteLine("");
                    sw.WriteLine("----------");
                    sw.Close();
                    MessageBox.Show("Booking successful");
                }
            }
            else // If file already exists
            {
                // File.WriteAllText("FILENAME.txt", String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText("booking.txt"))
                {
                    sw.Write("Persons: " + Persons);
                    sw.WriteLine("");
                    sw.Write("Total: " + total);
                    sw.WriteLine("");
                    sw.Write("date: " + date);
                    sw.WriteLine("");
                    sw.WriteLine("----------");
                    sw.Close();
                    MessageBox.Show("Booking successful");
                }
            }
        }

        private void bookForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPeople_TextChanged(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(textBoxPeople.Text) * 10;
            textBoxTotal.Text = ("£" + amount).ToString();
        }
    }
}

