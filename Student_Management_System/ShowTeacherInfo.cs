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
    public partial class ShowTeacherInfo : Form
    {
        public ShowTeacherInfo()
        {
            InitializeComponent();
            AutoGenarateID();
        }

        private void AutoGenarateID()
        {

            SqlDataAdapter sqladptr = new SqlDataAdapter("SELECT SI FROM Marks", Connection.sqlCon);

            DataTable dt = new DataTable();
            sqladptr.Fill(dt);

            if (dt.Rows.Count < 1)
            {
                txtMarkID.Text = "1";
                txtMarkID.ForeColor = Color.Black;
            }
            else
            {
                SqlCommand sqladptr1 = new SqlCommand("SELECT MAX(SI) FROM Marks", Connection.sqlCon);
                Connection.OpenConection();
                int a = Convert.ToInt32(sqladptr1.ExecuteScalar());
                Connection.CloseConnection();
                a = a + 1;
                txtMarkID.Text = a.ToString();
            }

        }

        public static string Id;
        public static string SId = "";
        private void btnMarkSubmit_Click(object sender, EventArgs e)
        {
            Id = txtEnterIDStudent.Text;

            Connection.OpenConection();

            SqlCommand sqlCmdUsers = new SqlCommand("SELECT Name FROM Student WHERE Id=@Id", Connection.sqlCon);


            sqlCmdUsers.Parameters.AddWithValue("@Id", Id);
            SqlDataReader users;
            users = sqlCmdUsers.ExecuteReader();

            while (users.Read())
            {
                SId = users["Name"].ToString();
            }
            Connection.CloseConnection();

            if (txtMarkID.Text == ""
                || txtEnterIDStudent.Text == ""
                || cmbSubjectSelect.Text == ""
                || txtAddMarks.Text == "")
            {
                MessageBox.Show("Must Fill up the information", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (SId == "")
            {
                MessageBox.Show("Student not Found");
            }

            else
            {
                try
                {
                    Connection.OpenConection();

                    String queryUsersAdd = "INSERT INTO Marks VALUES(@SI, @Id, @SubjectId, @Marks)";

                    SqlCommand sqlcmdAdd = new SqlCommand(queryUsersAdd, Connection.sqlCon);

                    sqlcmdAdd.CommandType = CommandType.Text;

                    sqlcmdAdd.Parameters.AddWithValue("@SI", txtMarkID.Text.Trim());
                    sqlcmdAdd.Parameters.AddWithValue("@Id", txtEnterIDStudent.Text.Trim());
                    sqlcmdAdd.Parameters.AddWithValue("@SubjectId", cmbSubjectSelect.Text.Trim());
                    sqlcmdAdd.Parameters.AddWithValue("@Marks", txtAddMarks.Text.Trim());


                    int a = sqlcmdAdd.ExecuteNonQuery();

                    Connection.CloseConnection();

                    if (a > 0)
                    {
                        MessageBox.Show("Successful");
                        AutoGenarateID();
                        txtEnterIDStudent.Text = "";
                        cmbSubjectSelect.Text = "";
                        txtAddMarks.Text = "";

                        Connection.OpenConection();

                        SqlDataAdapter sqldpt1 = new SqlDataAdapter("SELECT * FROM Marks", Connection.sqlCon);

                        DataTable dt1 = new DataTable();
                        sqldpt1.Fill(dt1);
                        dataGridView1.DataSource = dt1;
                        Connection.CloseConnection();
                    }
                    else
                    {
                        MessageBox.Show("Not Successful");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something Wrong");
                }
            }

        }


        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.tcTeacherMarks.Visible = true;
            this.tcTeacherMarks.SelectedIndex = 1;
        }

        private void btnAddMarks_Click(object sender, EventArgs e)
        {
            this.tcTeacherMarks.Visible = true;
            this.tcTeacherMarks.SelectedIndex = 0;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Visible = true;
            this.Close();
        }

        private void ShowTeacherInfo_Load(object sender, EventArgs e)
        {
            Connection.OpenConection();

            SqlCommand sqlCmdUsers = new SqlCommand("SELECT * FROM Teacher WHERE Id=@Id", Connection.sqlCon);

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
                labelSalary.Text = users["Salary"].ToString().Trim();
                labelJoindate.Text = users["JoinDate"].ToString().Trim();
            }

            Connection.CloseConnection();


            Connection.OpenConection();

            SqlDataAdapter sqldpt1 = new SqlDataAdapter("SELECT * FROM Marks", Connection.sqlCon);

            DataTable dt1 = new DataTable();
            sqldpt1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            Connection.CloseConnection();
        }

        private void txtAddMarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentSearch_TextChanged(object sender, EventArgs e)
        {
            Connection.OpenConection();

            SqlDataAdapter sqldpt = new SqlDataAdapter("SELECT * FROM Marks WHERE (Id LIKE '" + txtStudentSearch.Text + "%' )", Connection.sqlCon);

            DataTable dt = new DataTable();
            sqldpt.Fill(dt);
            dataGridView1.DataSource = dt;
            Connection.CloseConnection();
        }
    }
}
