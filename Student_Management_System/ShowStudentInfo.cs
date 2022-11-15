using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class ShowStudentInfo : Form
    {


        public ShowStudentInfo()
        {
            InitializeComponent();
        }

        private void btnStudentInfo_Click(object sender, EventArgs e)
        {
            this.tcStudentInfo.Visible = true;
            this.tcStudentInfo.SelectedIndex = 0;
        }


        private void btnShow_Click(object sender, EventArgs e)
        {

        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            this.tcStudentInfo.Visible = true;
            this.tcStudentInfo.SelectedIndex = 1;
        }

        private void dgvShowInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShowMarks_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Visible = true;
            this.Close();
        }

        private void ShowStudentInfo_Load(object sender, EventArgs e)
        {
            Connection.OpenConection();

            SqlCommand sqlCmdUsers = new SqlCommand("SELECT * FROM Student WHERE Id=@Id", Connection.sqlCon);

            sqlCmdUsers.Parameters.AddWithValue("@Id", Login.id);

            SqlDataReader users;

            users = sqlCmdUsers.ExecuteReader();

            while (users.Read())
            {
                labelId.Text = users["Id"].ToString().Trim();
                labelName.Text = users["Name"].ToString().Trim();
                labelNumber.Text = users["Number"].ToString().Trim();
                labelEmail.Text = users["Email"].ToString().Trim();
                labelAddress.Text = users["Address"].ToString().Trim();
                labelAge.Text = users["Age"].ToString().Trim();
                labelClass.Text = users["Class"].ToString().Trim();
                labelJoindate.Text = users["JoinDate"].ToString().Trim();
            }

            Connection.CloseConnection();

            Connection.OpenConection();

            SqlDataAdapter sqldpt1 = new SqlDataAdapter("SELECT SubjectId, Marks FROM Marks Where Id='"+Login.id+"'", Connection.sqlCon);

            DataTable dt1 = new DataTable();
            sqldpt1.Fill(dt1);
            dgvStudentMarks.DataSource = dt1;
            Connection.CloseConnection();

        }

        private void ShowStudentInfo_LocationChanged(object sender, EventArgs e)
        {

        }
    }
}
