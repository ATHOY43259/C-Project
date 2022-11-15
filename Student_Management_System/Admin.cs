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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            AutoGenarateID();
            txtAdminID.Enabled = false;
        }

        private void btnAdminShow_Click(object sender, EventArgs e)
        {
        }

        private void AutoGenarateID()
        {

            SqlDataAdapter sqladptr = new SqlDataAdapter("SELECT Id FROM Admin", Connection.sqlCon);

            DataTable dt = new DataTable();
            sqladptr.Fill(dt);

            if (dt.Rows.Count < 1)
            {
                txtAdminID.Text = "1";
                txtAdminID.ForeColor = Color.Black;
            }
            else
            {
                SqlCommand sqladptr1 = new SqlCommand("SELECT MAX(Id) FROM Admin", Connection.sqlCon);
                Connection.OpenConection();
                int a = Convert.ToInt32(sqladptr1.ExecuteScalar());
                Connection.CloseConnection();
                a = a + 1;
                txtAdminID.Text = a.ToString();
            }

        }

        private void btnAdminOk_Click(object sender, EventArgs e)
        {
            if (txtAdminPass.Text == "" || txtAdminName.Text == "")
            {
                MessageBox.Show("Must Fill up the information", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$").IsMatch(txtAdminPass.Text))
                {
                    txtAdminPass.Focus();
                    MessageBox.Show("Password will be match to be at least 8 characters, no more than 15 characters, and must include at least one upper case letter, one lower case letter, one numeric digit and one spacial character.", "Password policy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        Connection.OpenConection();

                        String queryUsersAdd = "INSERT INTO Admin VALUES(@Id, @Name,@Password)";

                        SqlCommand sqlcmdAdd = new SqlCommand(queryUsersAdd, Connection.sqlCon);

                        sqlcmdAdd.CommandType = CommandType.Text;

                        sqlcmdAdd.Parameters.AddWithValue("@Id", txtAdminID.Text.Trim());
                        sqlcmdAdd.Parameters.AddWithValue("@Name", txtAdminName.Text.Trim());
                        sqlcmdAdd.Parameters.AddWithValue("@Password", txtAdminPass.Text.Trim());


                        int a = sqlcmdAdd.ExecuteNonQuery();

                        Connection.CloseConnection();

                        if (a > 0)
                        {
                            MessageBox.Show("Successful");
                            AutoGenarateID();
                            txtAdminName.Text = "";
                            txtAdminPass.Text = "";
                            SqlDataAdapter sqldpt2 = new SqlDataAdapter("SELECT * FROM Admin", Connection.sqlCon);

                            DataTable dt2 = new DataTable();
                            sqldpt2.Fill(dt2);
                            dgvAdminInfo.DataSource = dt2;
                            Connection.CloseConnection();

                            Connection.OpenConection();
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

        private void btnStudentUpdating_Click(object sender, EventArgs e)
        {
            tcAdministration.Visible = true;
            tcAdministration.SelectedIndex = 0;
        }

        private void btnTeacherUpdating_Click(object sender, EventArgs e)
        {
            tcAdministration.Visible = true;
            tcAdministration.SelectedIndex = 1;
        }

        private void btnAdminAdding_Click(object sender, EventArgs e)
        {
            tcAdministration.Visible = true;
            tcAdministration.SelectedIndex = 2;
            AutoGenarateID();
        }

        private void btnAdminSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Must Fill up the information", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Connection.OpenConection();

                    SqlCommand sqlcmdAdd = new SqlCommand("delete from Admin where Id='" + textBox1.Text + "'", Connection.sqlCon);

                    sqlcmdAdd.ExecuteNonQuery();

                    Connection.CloseConnection();

                    MessageBox.Show("Successful");

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    txtDeleteSearch.Text = "";

                    Connection.OpenConection();

                    SqlDataAdapter sqldpt1 = new SqlDataAdapter("SELECT * FROM Admin", Connection.sqlCon);

                    DataTable dt1 = new DataTable();
                    sqldpt1.Fill(dt1);
                    dgvDeleteUpdate.DataSource = dt1;
                    Connection.CloseConnection();

                }
                catch (Exception)
                {
                    MessageBox.Show("Fail");
                }
            }
        }


        private void dgvAdminInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tpAdmin_Click(object sender, EventArgs e)
        {
            AutoGenarateID();
        }

        private void dgvStudentUpdateDelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnStudentUpdateInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnStudentSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            if (txtActualStudentID.Text == "")
            {
                MessageBox.Show("Must Fill up the information", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Connection.OpenConection();

                    SqlCommand sqlcmdAdd = new SqlCommand("delete from Student where Id='" + txtActualStudentID.Text + "'", Connection.sqlCon);

                    sqlcmdAdd.ExecuteNonQuery();

                    Connection.CloseConnection();

                    MessageBox.Show("Successful");

                    txtUpdateStudentName.Text = "";
                    txtUpdateGaurdian.Text = "";
                    txtUpdateStudentAddress.Text = "";
                    txtUpdateStudentAge.Text = "";
                    txtUpdateStudentMail.Text = "";
                    txtUpdateStudentNumber.Text = "";
                    txtUpdateStudentPassword.Text = "";
                    txtActualStudentID.Text = "";
                    txtStudentSearch.Text = "";

                    Connection.OpenConection();

                    SqlDataAdapter sqldpt = new SqlDataAdapter("SELECT * FROM Student", Connection.sqlCon);
                    DataTable dt = new DataTable();
                    sqldpt.Fill(dt);
                    dgvStudentUpdateDelete.DataSource = dt;
                    Connection.CloseConnection();

                }
                catch (Exception)
                {
                    MessageBox.Show("Fail");
                }
            }
            
        }

        private void btnStudentUpdate_Click(object sender, EventArgs e)
        {
            if (txtActualStudentID.Text == ""
            || txtUpdateStudentName.Text == ""
            || txtUpdateStudentAge.Text == ""
            || txtUpdateGaurdian.Text == ""
            || txtUpdateStudentNumber.Text == ""
            || txtUpdateStudentMail.Text == ""
            || txtUpdateStudentAddress.Text == ""
            || txtUpdateStudentPassword.Text == "")
            {
                MessageBox.Show("Must Fill up the information", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$").IsMatch(txtUpdateStudentPassword.Text))
                {
                    txtUpdateStudentPassword.Focus();
                    MessageBox.Show("Password will be match to be at least 8 characters, no more than 15 characters, and must include at least one upper case letter, one lower case letter, one numeric digit and one spacial character.", "Password policy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        Connection.OpenConection();

                        SqlCommand sqlcmdAdd = new SqlCommand("update Student set Name = '" + txtUpdateStudentName.Text + "', Age = '" + txtUpdateStudentAge.Text + "', GauardianName = '" + txtUpdateGaurdian.Text + "', Number = '" + txtUpdateStudentNumber.Text + "', Email = '" + txtUpdateStudentMail.Text + "', Address = '" + txtUpdateStudentAddress.Text + "', Password = '" + txtUpdateStudentPassword.Text + "' where Id = '" + txtActualStudentID.Text + "'", Connection.sqlCon);

                        sqlcmdAdd.ExecuteNonQuery();

                        Connection.CloseConnection();

                        MessageBox.Show("Successful");

                        txtUpdateStudentName.Text = "";
                        txtUpdateGaurdian.Text = "";
                        txtUpdateStudentAddress.Text = "";
                        txtUpdateStudentAge.Text = "";
                        txtUpdateStudentMail.Text = "";
                        txtUpdateStudentNumber.Text = "";
                        txtUpdateStudentPassword.Text = "";
                        txtActualStudentID.Text = "";
                        txtStudentSearch.Text = "";

                        Connection.OpenConection();

                        SqlDataAdapter sqldpt = new SqlDataAdapter("SELECT * FROM Student", Connection.sqlCon);

                        DataTable dt = new DataTable();
                        sqldpt.Fill(dt);
                        dgvStudentUpdateDelete.DataSource = dt;
                        Connection.CloseConnection();

                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message);
                        MessageBox.Show("Fail");
                    }
                }
            }
        }

        private void btnAdminDelete_Click(object sender, EventArgs e)
        {
            tcAdministration.Visible = true;
            tcAdministration.SelectedIndex = 3;
        }

        private void btnTeacherUpdateAllInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnTeacherUpdateSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnTeacherDelete_Click(object sender, EventArgs e)
        {
            if (txtTeacherID.Text == "")
            {
                MessageBox.Show("Must Fill up the information", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Connection.OpenConection();

                    SqlCommand sqlcmdAdd = new SqlCommand("delete from Teacher where Id='" + txtTeacherID.Text + "'", Connection.sqlCon);

                    sqlcmdAdd.ExecuteNonQuery();

                    Connection.CloseConnection();

                    MessageBox.Show("Successful");

                    txtTeacherID.Text = "";
                    txtTeacherName.Text = "";
                    txtTeacherAge.Text = "";
                    txtTeacherSalary.Text = "";
                    txtTeacherNumber.Text = "";
                    txtTeacherEmail.Text = "";
                    txtTeacherAddress.Text = "";
                    txtTeacherPassword.Text = "";
                    txtTeacherSearchID.Text = "";

                    Connection.OpenConection();

                    SqlDataAdapter sqldpt1 = new SqlDataAdapter("SELECT * FROM Teacher", Connection.sqlCon);

                    DataTable dt1 = new DataTable();
                    sqldpt1.Fill(dt1);
                    dgvTeacherUpdate.DataSource = dt1;
                    Connection.CloseConnection();

                }
                catch (Exception)
                {
                    MessageBox.Show("Fail");
                }
            }
        }
        private bool InvalidToInsertTeacher()
        {
            if (String.IsNullOrEmpty(this.txtTeacherID.Text) || String.IsNullOrEmpty(this.txtTeacherName.Text) || String.IsNullOrEmpty(this.txtTeacherAge.Text) || String.IsNullOrEmpty(this.txtTeacherEmail.Text) || String.IsNullOrEmpty(this.txtTeacherNumber.Text) || String.IsNullOrEmpty(this.txtTeacherAddress.Text) || String.IsNullOrEmpty(this.txtTeacherSalary.Text) || String.IsNullOrEmpty(this.txtTeacherPassword.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnTeacherUpdate_Click(object sender, EventArgs e)
        {
            if (txtTeacherID.Text == ""
            || txtTeacherName.Text == ""
            || txtTeacherAge.Text == ""
            || txtTeacherSalary.Text == ""
            || txtTeacherNumber.Text == ""
            || txtTeacherEmail.Text == ""
            || txtTeacherAddress.Text == ""
            || txtTeacherPassword.Text == "")
            {
                MessageBox.Show("Must Fill up the information", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$").IsMatch(txtTeacherPassword.Text))
                {
                    txtTeacherPassword.Focus();
                    MessageBox.Show("Password will be match to be at least 8 characters, no more than 15 characters, and must include at least one upper case letter, one lower case letter, one numeric digit and one spacial character.", "Password policy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        Connection.OpenConection();

                        SqlCommand sqlcmdAdd = new SqlCommand("update Teacher set Name = '" + txtTeacherName.Text + "'," +
                            " Age = '" + txtTeacherAge.Text + "', Salary = '" + txtTeacherSalary.Text + "', Number = '"
                            + txtTeacherNumber.Text + "', Email = '" + txtTeacherEmail.Text + "', Address = '" 
                            + txtTeacherAddress.Text + "', Password = '" + txtTeacherPassword.Text + "' where Id = '" + 
                            this.txtTeacherID.Text + "'", Connection.sqlCon);

                        sqlcmdAdd.ExecuteNonQuery();

                        Connection.CloseConnection();

                        MessageBox.Show("Successful");

                        txtTeacherID.Text = "";
                        txtTeacherName.Text = "";
                        txtTeacherAge.Text = "";
                        txtTeacherSalary.Text = "";
                        txtTeacherNumber.Text = "";
                        txtTeacherEmail.Text = "";
                        txtTeacherAddress.Text = "";
                        txtTeacherPassword.Text = "";
                        txtTeacherSearchID.Text = "";

                        Connection.OpenConection();

                        SqlDataAdapter sqldpt1 = new SqlDataAdapter("SELECT * FROM Teacher", Connection.sqlCon);

                        DataTable dt1 = new DataTable();
                        sqldpt1.Fill(dt1);
                        dgvTeacherUpdate.DataSource = dt1;
                        Connection.CloseConnection();

                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message);
                        MessageBox.Show("Fail");
                    }
                }
            }
        }

        private void dgvTeacherUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Visible = true;
            this.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            Connection.OpenConection();

            SqlDataAdapter sqldpt = new SqlDataAdapter("SELECT * FROM Student", Connection.sqlCon);

            DataTable dt = new DataTable();
            sqldpt.Fill(dt);
            dgvStudentUpdateDelete.DataSource = dt;
            Connection.CloseConnection();

            Connection.OpenConection();

            SqlDataAdapter sqldpt1 = new SqlDataAdapter("SELECT * FROM Teacher", Connection.sqlCon);

            DataTable dt1 = new DataTable();
            sqldpt1.Fill(dt1);
            dgvTeacherUpdate.DataSource = dt1;
            Connection.CloseConnection();

            Connection.OpenConection();

            SqlDataAdapter sqldpt2 = new SqlDataAdapter("SELECT * FROM Admin", Connection.sqlCon);

            DataTable dt2 = new DataTable();
            sqldpt2.Fill(dt2);
            dgvAdminInfo.DataSource = dt2;
            Connection.CloseConnection();

            Connection.OpenConection();

            SqlDataAdapter sqldpt3 = new SqlDataAdapter("SELECT * FROM Admin", Connection.sqlCon);

            DataTable dt3 = new DataTable();
            sqldpt3.Fill(dt3);
            dgvDeleteUpdate.DataSource = dt3;
            Connection.CloseConnection();
        }

        private void tcAdministration_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            Connection.OpenConection();

            SqlDataAdapter sqldpt = new SqlDataAdapter("SELECT * FROM Student", Connection.sqlCon);

            DataTable dt = new DataTable();
            sqldpt.Fill(dt);
            dgvStudentUpdateDelete.DataSource = dt;
            Connection.CloseConnection();

            Connection.OpenConection();

            SqlDataAdapter sqldpt1 = new SqlDataAdapter("SELECT * FROM Teacher", Connection.sqlCon);

            DataTable dt1 = new DataTable();
            sqldpt1.Fill(dt1);
            dgvTeacherUpdate.DataSource = dt1;
            Connection.CloseConnection();

            Connection.OpenConection();

            SqlDataAdapter sqldpt2 = new SqlDataAdapter("SELECT * FROM Admin", Connection.sqlCon);

            DataTable dt2 = new DataTable();
            sqldpt2.Fill(dt2);
            dgvAdminInfo.DataSource = dt2;
            Connection.CloseConnection();

            Connection.OpenConection();

            SqlDataAdapter sqldpt3 = new SqlDataAdapter("SELECT * FROM Admin", Connection.sqlCon);

            DataTable dt3 = new DataTable();
            sqldpt3.Fill(dt3);
            dgvDeleteUpdate.DataSource = dt3;
            Connection.CloseConnection();
        }

        private void dgvStudentUpdateDelete_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvStudentUpdateDelete_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtActualStudentID.Enabled = false;
            this.txtActualStudentID.Text = this.dgvStudentUpdateDelete.CurrentRow.Cells[0].Value.ToString();
            this.txtUpdateStudentName.Text = this.dgvStudentUpdateDelete.CurrentRow.Cells[1].Value.ToString();
            this.txtUpdateStudentAge.Text = this.dgvStudentUpdateDelete.CurrentRow.Cells[6].Value.ToString();
            this.txtUpdateGaurdian.Text = this.dgvStudentUpdateDelete.CurrentRow.Cells[2].Value.ToString();
            this.txtUpdateStudentNumber.Text = this.dgvStudentUpdateDelete.CurrentRow.Cells[3].Value.ToString();
            this.txtUpdateStudentMail.Text = this.dgvStudentUpdateDelete.CurrentRow.Cells[4].Value.ToString();
            this.txtUpdateStudentAddress.Text = this.dgvStudentUpdateDelete.CurrentRow.Cells[5].Value.ToString();
            this.txtUpdateStudentPassword.Text = this.dgvStudentUpdateDelete.CurrentRow.Cells[11].Value.ToString();
        }

        private void dgvTeacherUpdate_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTeacherID.Enabled = false;
            this.txtTeacherID.Text = this.dgvTeacherUpdate.CurrentRow.Cells[0].Value.ToString();
            this.txtTeacherName.Text = this.dgvTeacherUpdate.CurrentRow.Cells[1].Value.ToString();
            this.txtTeacherEmail.Text = this.dgvTeacherUpdate.CurrentRow.Cells[3].Value.ToString();
            this.txtTeacherNumber.Text = this.dgvTeacherUpdate.CurrentRow.Cells[2].Value.ToString();
            this.txtTeacherAddress.Text = this.dgvTeacherUpdate.CurrentRow.Cells[4].Value.ToString();
            this.txtTeacherSalary.Text = this.dgvTeacherUpdate.CurrentRow.Cells[6].Value.ToString();
            this.txtTeacherAge.Text = this.dgvTeacherUpdate.CurrentRow.Cells[5].Value.ToString();
            this.txtTeacherPassword.Text = this.dgvTeacherUpdate.CurrentRow.Cells[8].Value.ToString();
        }

        private void dgvAdminInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = true;
            txtAdminID.Enabled = false;
            this.txtAdminID.Text = this.dgvAdminInfo.CurrentRow.Cells[0].Value.ToString();
            this.txtAdminName.Text = this.dgvAdminInfo.CurrentRow.Cells[1].Value.ToString();
            this.txtAdminPass.Text = this.dgvAdminInfo.CurrentRow.Cells[2].Value.ToString();
        }

        private void txtUpdateStudentNumber_Leave(object sender, EventArgs e)
        {
            if (txtUpdateStudentNumber.Text != "")
            {
                if (new Regex(@"^(?:\+?88|0088)?01[15-9]\d{8}$").IsMatch(txtUpdateStudentNumber.Text))
                {

                }
                else
                {
                    txtUpdateStudentNumber.Focus();
                    MessageBox.Show("Mobile number is not valide", "All information is required", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

        private void txtUpdateStudentMail_Leave(object sender, EventArgs e)
        {

            if (txtUpdateStudentMail.Text != "")
            {
                if (Regex.IsMatch(txtUpdateStudentMail.Text, pattern) == false)
                {
                    txtUpdateStudentMail.Focus();
                    MessageBox.Show("Email Address is not valide", "All information is required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

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

        private void txtUpdateStudentAge_Leave(object sender, EventArgs e)
        {
            if (txtUpdateStudentAge.Text != "")
            {
                if (new Regex(@"^(?=.*?[0-9])\d{1,2}$").IsMatch(txtUpdateStudentAge.Text))
                {
                    if (int.Parse(txtUpdateStudentAge.Text.ToString()) < 6 || int.Parse(txtUpdateStudentAge.Text.ToString()) > 12)
                    {
                        txtUpdateStudentAge.Focus();
                        MessageBox.Show("Age is not valid.it is from 6 to 12.", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    txtUpdateStudentAge.Focus();
                    MessageBox.Show("Age is not valid", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtStudentSearch_TextChanged(object sender, EventArgs e)
        {
            Connection.OpenConection();

            SqlDataAdapter sqldpt = new SqlDataAdapter("SELECT * FROM Student WHERE (Id LIKE '" + txtStudentSearch.Text + "%' )", Connection.sqlCon);

            DataTable dt = new DataTable();
            sqldpt.Fill(dt);
            dgvStudentUpdateDelete.DataSource = dt;
            Connection.CloseConnection();
        }

        private void txtTeacherSearchID_TextChanged(object sender, EventArgs e)
        {
            Connection.OpenConection();

            SqlDataAdapter sqldpt = new SqlDataAdapter("SELECT * FROM Teacher WHERE (Id LIKE '" + txtTeacherSearchID.Text + "%' )", Connection.sqlCon);

            DataTable dt = new DataTable();
            sqldpt.Fill(dt);
            dgvTeacherUpdate.DataSource = dt;
            Connection.CloseConnection();
        }

        private void txtAdminSearch_TextChanged(object sender, EventArgs e)
        {
            Connection.OpenConection();

            SqlDataAdapter sqldpt = new SqlDataAdapter("SELECT * FROM Admin WHERE (Id LIKE '" + txtAdminSearch.Text + "%' )", Connection.sqlCon);

            DataTable dt = new DataTable();
            sqldpt.Fill(dt);
            dgvAdminInfo.DataSource = dt;
            Connection.CloseConnection();
        }

        private void txtDeleteSearch_TextChanged(object sender, EventArgs e)
        {
            Connection.OpenConection();

            SqlDataAdapter sqldpt = new SqlDataAdapter("SELECT * FROM Admin WHERE (Id LIKE '" + txtDeleteSearch.Text + "%' )", Connection.sqlCon);

            DataTable dt = new DataTable();
            sqldpt.Fill(dt);
            dgvDeleteUpdate.DataSource = dt;
            Connection.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAdminID.Text == "" || txtAdminPass.Text == "" || txtAdminName.Text == "")
            {
                MessageBox.Show("Must Fill up the information", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$").IsMatch(txtAdminPass.Text))
                {
                    txtAdminPass.Focus();
                    MessageBox.Show("Password will be match to be at least 8 characters, no more than 15 characters, and must include at least one upper case letter, one lower case letter, one numeric digit and one spacial character.", "Password policy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        Connection.OpenConection();

                        SqlCommand sqlcmdAdd = new SqlCommand("update Admin set Name = '" + txtAdminName.Text + "'," +
                            " Password = '" + txtAdminPass.Text + "' where Id = '" +
                            txtAdminID.Text + "'", Connection.sqlCon);

                        sqlcmdAdd.ExecuteNonQuery();

                        Connection.CloseConnection();

                        MessageBox.Show("Successful");

                        txtAdminName.Text = "";
                        txtAdminPass.Text = "";
                        txtAdminID.Text = "";
                        AutoGenarateID();
                        button1.Enabled = false;

                        Connection.OpenConection();

                        SqlDataAdapter sqldpt1 = new SqlDataAdapter("SELECT * FROM Admin", Connection.sqlCon);

                        DataTable dt1 = new DataTable();
                        sqldpt1.Fill(dt1);
                        dgvAdminInfo.DataSource = dt1;
                        Connection.CloseConnection();

                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message);
                        MessageBox.Show("Fail");
                    }
                }
            }
        }

        private void dgvDeleteUpdate_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Enabled = false;
            this.textBox1.Text = this.dgvDeleteUpdate.CurrentRow.Cells[0].Value.ToString();
            this.textBox3.Text = this.dgvDeleteUpdate.CurrentRow.Cells[1].Value.ToString();
            this.textBox2.Text = this.dgvDeleteUpdate.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
