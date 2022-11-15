using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student std1 = new Student();
            std1.Visible = true;
            this.Close();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher t1 = new Teacher();
            t1.Visible = true;
            this.Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin ad1 = new Admin();
            ad1.Visible = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin ad1 = new Admin();
            ad1.Visible = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin ad1 = new Admin();
            ad1.Visible = true;
            this.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Visible = true;
            this.Close();
        }
    }
}
