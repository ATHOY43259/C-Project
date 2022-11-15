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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
            txtInputTeacherID.Enabled = false;
            AutoGenarateID();
        }

        private void AutoGenarateID()
        {

            SqlDataAdapter sqladptr = new SqlDataAdapter("SELECT Id FROM Teacher", Connection.sqlCon);

            DataTable dt = new DataTable();
            sqladptr.Fill(dt);

            if (dt.Rows.Count < 1)
            {
                txtInputTeacherID.Text = "50001";
                txtInputTeacherID.ForeColor = Color.Black;
            }
            else
            {
                SqlCommand sqladptr1 = new SqlCommand("SELECT MAX(Id) FROM Teacher", Connection.sqlCon);
                Connection.OpenConection();
                int a = Convert.ToInt32(sqladptr1.ExecuteScalar());
                Connection.CloseConnection();
                a = a + 1;
                txtInputTeacherID.Text = a.ToString();
            }

        }

        private void btnSubmitTeacherInfo_Click(object sender, EventArgs e)
        {
            if (txtInputTeacherID.Text == ""
                || txtTeacherName.Text == ""
                || txtTeacherEmail.Text == ""
                || txtTeacherAddress.Text == ""
                || txtTeacherNumber.Text == ""
                || txtTeacherAge.Text == ""
                || txtTeacherSalary.Text == ""
                || dtpJoinTeacher.Text == ""
                || txtPasswordTeacher.Text == "")               
            {
                MessageBox.Show("Must Fill up the information", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$").IsMatch(txtPasswordTeacher.Text))
                {
                    txtPasswordTeacher.Focus();
                    MessageBox.Show("Password will be match to be at least 8 characters, no more than 15 characters, and must include at least one upper case letter, one lower case letter, one numeric digit and one spacial character.", "Password policy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        Connection.OpenConection();

                        String queryUsersAdd = "INSERT INTO teacher VALUES(@Id, @Name," +
                            "@Number, @Email, @Address, @Age, @Salary,@JoinDate," +
                            " @Password)";

                        SqlCommand sqlcmdAdd = new SqlCommand(queryUsersAdd, Connection.sqlCon);

                        sqlcmdAdd.CommandType = CommandType.Text;

                        sqlcmdAdd.Parameters.AddWithValue("@Id", txtInputTeacherID.Text.Trim());
                        sqlcmdAdd.Parameters.AddWithValue("@Name", txtTeacherName.Text.Trim());
                        sqlcmdAdd.Parameters.AddWithValue("@Number", txtTeacherNumber.Text.Trim());
                        sqlcmdAdd.Parameters.AddWithValue("@Email", txtTeacherEmail.Text.Trim());
                        sqlcmdAdd.Parameters.AddWithValue("@Address", txtTeacherAddress.Text.Trim());
                        sqlcmdAdd.Parameters.AddWithValue("@Age", txtTeacherAge.Text.Trim());
                        sqlcmdAdd.Parameters.AddWithValue("@Salary", txtTeacherSalary.Text.Trim());
                        sqlcmdAdd.Parameters.AddWithValue("@JoinDate", dtpJoinTeacher.Value.ToString().Trim());
                        sqlcmdAdd.Parameters.AddWithValue("@Password", txtPasswordTeacher.Text.Trim());


                        int a = sqlcmdAdd.ExecuteNonQuery();

                        Connection.CloseConnection();

                        if (a > 0)
                        {
                            MessageBox.Show("Successful");
                            AutoGenarateID();
                            txtTeacherName.Text = "";
                            txtTeacherEmail.Text = "";
                            txtTeacherAddress.Text = "";
                            txtTeacherNumber.Text = "";
                            txtTeacherAge.Text = "";
                            txtTeacherSalary.Text = "";
                            dtpJoinTeacher.Text = "";
                            txtPasswordTeacher.Text = "";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.tcTeacherInsert.SelectedIndex = 0;
            this.tcTeacherInsert.Visible = true;
        }

        private void btnAllInfo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTeacherSearch_Click(object sender, EventArgs e)
        {
            /*this.SqlQurey = @"select* from teacher where teacher_id = '" + this.txtInsertIDSearch.Text + "';";
            Ds = this.Da.ExecuteQuery(SqlQurey);
            this.dgvTeacherInfo.AutoGenerateColumns = false;
            this.dgvTeacherInfo.DataSource = Ds.Tables[0];*/
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Visible = true;
            this.Close();
        }

        private void txtTeacherNumber_TextChanged(object sender, EventArgs e)
        {

        }

        string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

        private void txtTeacherEmail_Leave(object sender, EventArgs e)
        {
            if (txtTeacherEmail.Text != "")
            {
                if (Regex.IsMatch(txtTeacherEmail.Text, pattern) == false)
                {
                    txtTeacherEmail.Focus();
                    MessageBox.Show("Email Address is not valide", "All information is required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtTeacherNumber_Leave(object sender, EventArgs e)
        {
            if (txtTeacherNumber.Text != "")
            {
                if (new Regex(@"^(?:\+?88|0088)?01[15-9]\d{8}$").IsMatch(txtTeacherNumber.Text))
                {

                }
                else
                {
                    txtTeacherNumber.Focus();
                    MessageBox.Show("Mobile number is not valide", "All information is required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtTeacherAge_Leave(object sender, EventArgs e)
        {

            if (txtTeacherAge.Text != "")
            {
                if (new Regex(@"^(?=.*?[0-9])\d{1,2}$").IsMatch(txtTeacherAge.Text))
                {
                    if (int.Parse(txtTeacherAge.Text.ToString()) < 20 || int.Parse(txtTeacherAge.Text.ToString()) > 40)
                    {
                        txtTeacherAge.Focus();
                        MessageBox.Show("Age is not valid.it is from 20 to 40.", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    txtTeacherAge.Focus();
                    MessageBox.Show("Age is not valid", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtTeacherSalary_Leave(object sender, EventArgs e)
        {
            if (txtTeacherSalary.Text != "")
            {
                if (new Regex(@"^(?=.*?[0-9])\d{1,9}$").IsMatch(txtTeacherSalary.Text))
                {

                }
                else
                {
                    txtTeacherSalary.Focus();
                    MessageBox.Show("Fees is not valid", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tcTeacherInsert_Click(object sender, EventArgs e)
        {
            Connection.OpenConection();

            SqlDataAdapter sqldpt1 = new SqlDataAdapter("SELECT * FROM Teacher", Connection.sqlCon);

            DataTable dt1 = new DataTable();
            sqldpt1.Fill(dt1);
            dgvTeacherInfo.DataSource = dt1;
            Connection.CloseConnection();
        }

        private void txtInsertIDSearch_TextChanged(object sender, EventArgs e)
        {
            Connection.OpenConection();

            SqlDataAdapter sqldpt = new SqlDataAdapter("SELECT * FROM Teacher WHERE (Id LIKE '" + txtInsertIDSearch.Text + "%' )", Connection.sqlCon);

            DataTable dt = new DataTable();
            sqldpt.Fill(dt);
            dgvTeacherInfo.DataSource = dt;
            Connection.CloseConnection();
        }
    }
}
