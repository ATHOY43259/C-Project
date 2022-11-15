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
    public partial class Login : Form
    {
        public static string id;
        /* private DataAccess da3 = new DataAccess();
         private DataSet Ds3 { get; set; }
         private string sqlQurey3 { get; set; }
         DataTable dt = new DataTable();*/

        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            /*this.sqlQurey3 = @"select * from admin where id='" + this.txtUserID.Text + "' and password='" + this.txtPassword.Text + "';";

            Ds3 = this.da3.ExecuteQuery(sqlQurey3);


            try
            {

                if (cmbUser.Text == "Admin")
                {
                    this.sqlQurey3 = @"select * from admin where id='" + this.txtUserID.Text + "' and password='" + this.txtPassword.Text + "';";

                    Ds3 = this.da3.ExecuteQuery(sqlQurey3);

                    if (Ds3.Tables[0].Rows.Count == 1)
                    {

                        MessageBox.Show("Successful Login");
                        Home fm1 = new Home();
                        fm1.Visible = true;

                    }
                }

                else if (cmbUser.Text == "Student")
                {


                    this.sqlQurey3 = @"select * from studentinfo where id='" + this.txtUserID.Text + "' and password ='" + this.txtPassword.Text + "';";

                    Ds3 = this.da3.ExecuteQuery(sqlQurey3);

                    if (Ds3.Tables[0].Rows.Count == 1)
                    {

                        MessageBox.Show("Successful Login");
                        ShowStudentInfo ssi1 = new ShowStudentInfo(this);
                        ssi1.Visible = true;


                    }

                }

                else if (cmbUser.Text == "Teacher")
                {


                    this.sqlQurey3 = @"select * from teacher where teacher_id='" + this.txtUserID.Text + "' and teacher_password ='" + this.txtPassword.Text + "';";

                    Ds3 = this.da3.ExecuteQuery(sqlQurey3);

                    if (Ds3.Tables[0].Rows.Count == 1)
                    {

                        MessageBox.Show("Successful Login");
                        ShowTeacherInfo t1 = new ShowTeacherInfo(this);
                        t1.Visible = true;

                    }

                }

                else
                {
                    MessageBox.Show("Wrong user");
                }


            }
            catch (Exception exc)
            {
                MessageBox.Show("Error" + exc.Message.ToString());

            }*/

            if (txtUserID.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Enter user id or password", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                try
                {
                    if (Connection.sqlCon.State == ConnectionState.Closed)
                        Connection.OpenConection();

                    String queryUsers = "SELECT COUNT(*) FROM Student WHERE Id=@Id AND password=@password";
                    String queryTeachers = "SELECT COUNT(*) FROM Teacher WHERE Id=@Id AND password=@password";
                    String queryAdmin = "SELECT COUNT(*) FROM Admin WHERE Id=@Id AND password=@password";

                    SqlCommand sqlCmdUsers = new SqlCommand(queryUsers, Connection.sqlCon);
                    sqlCmdUsers.CommandType = CommandType.Text;
                    sqlCmdUsers.Parameters.AddWithValue("@Id", txtUserID.Text);
                    sqlCmdUsers.Parameters.AddWithValue("@password", txtPassword.Text);
                    int Users = Convert.ToInt32(sqlCmdUsers.ExecuteScalar());

                    SqlCommand sqlCmdTeachers = new SqlCommand(queryTeachers, Connection.sqlCon);
                    sqlCmdTeachers.CommandType = CommandType.Text;
                    sqlCmdTeachers.Parameters.AddWithValue("@Id", txtUserID.Text.ToString());
                    sqlCmdTeachers.Parameters.AddWithValue("@password", txtPassword.Text);
                    int Teachers = Convert.ToInt32(sqlCmdTeachers.ExecuteScalar());

                    SqlCommand sqlCmdAdmin = new SqlCommand(queryAdmin, Connection.sqlCon);
                    sqlCmdAdmin.CommandType = CommandType.Text;
                    sqlCmdAdmin.Parameters.AddWithValue("@Id", txtUserID.Text);
                    sqlCmdAdmin.Parameters.AddWithValue("@password", txtPassword.Text);
                    int Admin = Convert.ToInt32(sqlCmdAdmin.ExecuteScalar());

                    try
                    {
                        if (Users == 1)
                        {
                            id = txtUserID.Text;
                            this.Hide();
                            ShowStudentInfo studentInfo = new ShowStudentInfo();
                            studentInfo.ShowDialog();

                        }

                        else if (Teachers == 1)
                        {
                            id = txtUserID.Text;
                            this.Hide();
                            ShowTeacherInfo teacherInfo = new ShowTeacherInfo();
                            teacherInfo.ShowDialog();
                        }

                        else if (Admin == 1)
                        {
                            id = txtUserID.Text;
                            this.Hide();
                            Home home = new Home();
                            home.ShowDialog();
                        }

                        else
                        {
                            MessageBox.Show("User id or password Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Enter user id or password", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    Connection.CloseConnection();
                }
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.txtUserID.Text = "";
            this.txtPassword.Text = "";
        }

        private void btnLoginExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
