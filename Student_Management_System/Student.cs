using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class Student : Form
    {

        public Student()
        {
            InitializeComponent();
            AutoGenarateID();
            txtInputID.Enabled = false;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            tcStudent.Visible = true;
            tcStudent.SelectedIndex = 0;
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            tcStudent.Visible = true;
            tcStudent.SelectedIndex = 1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            /*this.sqlQurey = @"select* from studentinfo where id = '" + this.txtID.Text + "';";
            Ds1 = this.Da.ExecuteQuery(sqlQurey);
            this.dgvStudentsInfo.AutoGenerateColumns = false;
            this.dgvStudentsInfo.DataSource = Ds1.Tables[0];*/
        }

        private void btnAllInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmitStudentInfo_Click(object sender, EventArgs e)
        {

            if (txtInputID.Text == ""
                || txtStudentName.Text == ""
                || txtGuardian.Text == ""
                || txtNumber.Text == ""
                || txtEmail.Text == ""
                || txtAddress.Text == ""
                || txtAge.Text == ""
                || cmboxSelectClassID.Text == ""
                || txtFees.Text == ""
                || dtpJoin.Text == ""
                || dtpEnd.Text == ""
                || txtPassword.Text == "")
            {
                MessageBox.Show("Must Fill up the information", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (!new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$").IsMatch(txtPassword.Text))
                {
                    txtPassword.Focus();
                    MessageBox.Show("Password will be match to be at least 8 characters, no more than 15 characters, and must include at least one upper case letter, one lower case letter, one numeric digit and one spacial character.", "Password policy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        Connection.OpenConection();

                        String queryUsersAdd = "INSERT INTO Student VALUES(@Id, @Name, @GauardianName, " +
                            "@Number, @Email, @Address, @Age, @Class, @Fees, @JoinDate, @DeafLine, " +
                            " @Password)";

                        SqlCommand sqlcmdAdd = new SqlCommand(queryUsersAdd, Connection.sqlCon);

                        sqlcmdAdd.CommandType = CommandType.Text;

                        sqlcmdAdd.Parameters.AddWithValue("@Id", txtInputID.Text.Trim());
                        sqlcmdAdd.Parameters.AddWithValue("@Name", txtStudentName.Text.Trim());
                        sqlcmdAdd.Parameters.AddWithValue("@GauardianName", txtGuardian.Text.Trim());
                        sqlcmdAdd.Parameters.AddWithValue("@Number", txtNumber.Text.Trim());
                        sqlcmdAdd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        sqlcmdAdd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                        sqlcmdAdd.Parameters.AddWithValue("@Age", txtAge.Text.Trim());
                        sqlcmdAdd.Parameters.AddWithValue("@Class", cmboxSelectClassID.Text.Trim());
                        sqlcmdAdd.Parameters.AddWithValue("@Fees", txtFees.Text.Trim());
                        sqlcmdAdd.Parameters.AddWithValue("@JoinDate", dtpJoin.Value.ToString().Trim());
                        sqlcmdAdd.Parameters.AddWithValue("@DeafLine", dtpEnd.Value.ToString().Trim());
                        sqlcmdAdd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());


                        int a = sqlcmdAdd.ExecuteNonQuery();

                        Connection.CloseConnection();

                        if (a > 0)
                        {
                            MessageBox.Show("Successful");
                            AutoGenarateID();
                            txtStudentName.Text = "";
                            txtGuardian.Text = "";
                            txtNumber.Text = "";
                            txtEmail.Text = "";
                            txtAddress.Text = "";
                            txtAge.Text = "";
                            cmboxSelectClassID.Text = "";
                            txtFees.Text = "";
                            dtpJoin.Text = "";
                            dtpEnd.Text = "";
                            txtPassword.Text = "";
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




        }

        private void AutoGenarateID()
        {

            SqlDataAdapter sqladptr = new SqlDataAdapter("SELECT Id FROM Student",Connection.sqlCon);

            DataTable dt = new DataTable();
            sqladptr.Fill(dt);

            if (dt.Rows.Count < 1)
            {
                txtInputID.Text = "1001";
                txtInputID.ForeColor = Color.Black;
            }
            else
            {
                SqlCommand sqladptr1 = new SqlCommand("SELECT MAX(Id) FROM Student", Connection.sqlCon);
                Connection.OpenConection();
                int a = Convert.ToInt32(sqladptr1.ExecuteScalar());
                Connection.CloseConnection();
                a = a + 1;
                txtInputID.Text = a.ToString();
            }

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Visible = true;
            this.Close();
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNumber_Leave(object sender, EventArgs e)
        {
            if (txtNumber.Text != "")
            {
                if (new Regex(@"^(?:\+?88|0088)?01[15-9]\d{8}$").IsMatch(txtNumber.Text))
                {

                }
                else
                {
                    txtNumber.Focus();
                    MessageBox.Show("Mobile number is not valide", "All information is required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text != "")
            {
                if (Regex.IsMatch(txtEmail.Text, pattern) == false)
                {
                    txtEmail.Focus();
                    MessageBox.Show("Email Address is not valide", "All information is required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtAge_Leave(object sender, EventArgs e)
        {
            if (txtAge.Text != "")
            {
                if (new Regex(@"^(?=.*?[0-9])\d{1,2}$").IsMatch(txtAge.Text))
                {
                    if (int.Parse(txtAge.Text.ToString()) < 5 || int.Parse(txtAge.Text.ToString()) >12)
                    {
                        txtAge.Focus();
                        MessageBox.Show("Age is not valid.it is from 5 to 12.", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    txtAge.Focus();
                    MessageBox.Show("Age is not valid", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtFees_Leave(object sender, EventArgs e)
        {

            if (txtFees.Text != "") 
            {
                if (new Regex(@"^(?=.*?[0-9])\d{1,9}$").IsMatch(txtFees.Text))
                {

                }
                else
                {
                    txtFees.Focus();
                    MessageBox.Show("Fees is not valid", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tcStudent_Click(object sender, EventArgs e)
        {
            Connection.OpenConection();

            SqlDataAdapter sqldpt = new SqlDataAdapter("SELECT * FROM Student", Connection.sqlCon);

            DataTable dt = new DataTable();
            sqldpt.Fill(dt);
            dgvStudentsInfo.DataSource = dt;
            Connection.CloseConnection();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            Connection.OpenConection();

            SqlDataAdapter sqldpt = new SqlDataAdapter("SELECT * FROM Student WHERE (Id LIKE '" + txtID.Text + "%' )", Connection.sqlCon);

            DataTable dt = new DataTable();
            sqldpt.Fill(dt);
            dgvStudentsInfo.DataSource = dt;
            Connection.CloseConnection();
        }
    }
}
