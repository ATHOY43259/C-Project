
namespace Student_Management_System
{
    partial class Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.label1 = new System.Windows.Forms.Label();
            this.tcStudent = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlEducation = new System.Windows.Forms.Panel();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpJoin = new System.Windows.Forms.DateTimePicker();
            this.cmboxSelectClassID = new System.Windows.Forms.ComboBox();
            this.btnSubmitStudentInfo = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlStudentInfo = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGuardian = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInputID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvStudentsInfo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.tcStudent.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlEducation.SuspendLayout();
            this.pnlStudentInfo.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(534, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = " Student Information";
            // 
            // tcStudent
            // 
            this.tcStudent.Controls.Add(this.tabPage1);
            this.tcStudent.Controls.Add(this.tabPage2);
            this.tcStudent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tcStudent.Location = new System.Drawing.Point(26, 180);
            this.tcStudent.Name = "tcStudent";
            this.tcStudent.SelectedIndex = 0;
            this.tcStudent.Size = new System.Drawing.Size(1306, 600);
            this.tcStudent.TabIndex = 45;
            this.tcStudent.Click += new System.EventHandler(this.tcStudent_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage1.Controls.Add(this.pnlEducation);
            this.tabPage1.Controls.Add(this.pnlStudentInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1298, 562);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Student";
            // 
            // pnlEducation
            // 
            this.pnlEducation.Controls.Add(this.dtpEnd);
            this.pnlEducation.Controls.Add(this.dtpJoin);
            this.pnlEducation.Controls.Add(this.cmboxSelectClassID);
            this.pnlEducation.Controls.Add(this.btnSubmitStudentInfo);
            this.pnlEducation.Controls.Add(this.txtPassword);
            this.pnlEducation.Controls.Add(this.label11);
            this.pnlEducation.Controls.Add(this.label12);
            this.pnlEducation.Controls.Add(this.label13);
            this.pnlEducation.Controls.Add(this.txtFees);
            this.pnlEducation.Controls.Add(this.label14);
            this.pnlEducation.Controls.Add(this.label15);
            this.pnlEducation.Controls.Add(this.label10);
            this.pnlEducation.Location = new System.Drawing.Point(638, 20);
            this.pnlEducation.Name = "pnlEducation";
            this.pnlEducation.Size = new System.Drawing.Size(632, 495);
            this.pnlEducation.TabIndex = 1;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(285, 278);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(276, 32);
            this.dtpEnd.TabIndex = 49;
            // 
            // dtpJoin
            // 
            this.dtpJoin.Location = new System.Drawing.Point(285, 223);
            this.dtpJoin.Name = "dtpJoin";
            this.dtpJoin.Size = new System.Drawing.Size(276, 32);
            this.dtpJoin.TabIndex = 48;
            // 
            // cmboxSelectClassID
            // 
            this.cmboxSelectClassID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxSelectClassID.FormattingEnabled = true;
            this.cmboxSelectClassID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmboxSelectClassID.Location = new System.Drawing.Point(285, 110);
            this.cmboxSelectClassID.Name = "cmboxSelectClassID";
            this.cmboxSelectClassID.Size = new System.Drawing.Size(276, 33);
            this.cmboxSelectClassID.TabIndex = 47;
            // 
            // btnSubmitStudentInfo
            // 
            this.btnSubmitStudentInfo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSubmitStudentInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmitStudentInfo.ForeColor = System.Drawing.Color.White;
            this.btnSubmitStudentInfo.Location = new System.Drawing.Point(457, 411);
            this.btnSubmitStudentInfo.Name = "btnSubmitStudentInfo";
            this.btnSubmitStudentInfo.Size = new System.Drawing.Size(97, 67);
            this.btnSubmitStudentInfo.TabIndex = 46;
            this.btnSubmitStudentInfo.Text = "Submit";
            this.btnSubmitStudentInfo.UseVisualStyleBackColor = false;
            this.btnSubmitStudentInfo.Click += new System.EventHandler(this.btnSubmitStudentInfo_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(285, 331);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(276, 32);
            this.txtPassword.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(57, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 30);
            this.label11.TabIndex = 42;
            this.label11.Text = "Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(57, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 30);
            this.label12.TabIndex = 40;
            this.label12.Text = "Deadline";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(57, 220);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 30);
            this.label13.TabIndex = 38;
            this.label13.Text = "Join Date";
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(285, 167);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(276, 32);
            this.txtFees.TabIndex = 37;
            this.txtFees.Leave += new System.EventHandler(this.txtFees_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(57, 167);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 30);
            this.label14.TabIndex = 36;
            this.label14.Text = "Fees";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(57, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 30);
            this.label15.TabIndex = 34;
            this.label15.Text = "Class";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(202, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(255, 34);
            this.label10.TabIndex = 33;
            this.label10.Text = "Education Details";
            // 
            // pnlStudentInfo
            // 
            this.pnlStudentInfo.Controls.Add(this.label9);
            this.pnlStudentInfo.Controls.Add(this.txtAge);
            this.pnlStudentInfo.Controls.Add(this.label8);
            this.pnlStudentInfo.Controls.Add(this.txtAddress);
            this.pnlStudentInfo.Controls.Add(this.label7);
            this.pnlStudentInfo.Controls.Add(this.txtEmail);
            this.pnlStudentInfo.Controls.Add(this.label6);
            this.pnlStudentInfo.Controls.Add(this.txtNumber);
            this.pnlStudentInfo.Controls.Add(this.label5);
            this.pnlStudentInfo.Controls.Add(this.txtGuardian);
            this.pnlStudentInfo.Controls.Add(this.label4);
            this.pnlStudentInfo.Controls.Add(this.txtStudentName);
            this.pnlStudentInfo.Controls.Add(this.label3);
            this.pnlStudentInfo.Controls.Add(this.txtInputID);
            this.pnlStudentInfo.Controls.Add(this.label2);
            this.pnlStudentInfo.Location = new System.Drawing.Point(22, 20);
            this.pnlStudentInfo.Name = "pnlStudentInfo";
            this.pnlStudentInfo.Size = new System.Drawing.Size(585, 495);
            this.pnlStudentInfo.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(79, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(422, 34);
            this.label9.TabIndex = 32;
            this.label9.Text = "Student\'s Personal Information";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(247, 367);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(276, 32);
            this.txtAge.TabIndex = 31;
            this.txtAge.Leave += new System.EventHandler(this.txtAge_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(19, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 30);
            this.label8.TabIndex = 30;
            this.label8.Text = "Age";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(247, 282);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(276, 68);
            this.txtAddress.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(19, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 30);
            this.label7.TabIndex = 28;
            this.label7.Text = "Address";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(247, 239);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(276, 32);
            this.txtEmail.TabIndex = 27;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(19, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 30);
            this.label6.TabIndex = 26;
            this.label6.Text = "Email";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(247, 199);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(276, 32);
            this.txtNumber.TabIndex = 25;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            this.txtNumber.Leave += new System.EventHandler(this.txtNumber_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 30);
            this.label5.TabIndex = 24;
            this.label5.Text = "Number";
            // 
            // txtGuardian
            // 
            this.txtGuardian.Location = new System.Drawing.Point(247, 157);
            this.txtGuardian.Name = "txtGuardian";
            this.txtGuardian.Size = new System.Drawing.Size(276, 32);
            this.txtGuardian.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 30);
            this.label4.TabIndex = 22;
            this.label4.Text = "Gauardian Name";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(247, 112);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(276, 32);
            this.txtStudentName.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 30);
            this.label3.TabIndex = 20;
            this.label3.Text = "Name";
            // 
            // txtInputID
            // 
            this.txtInputID.Location = new System.Drawing.Point(247, 72);
            this.txtInputID.Name = "txtInputID";
            this.txtInputID.Size = new System.Drawing.Size(276, 32);
            this.txtInputID.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage2.Controls.Add(this.dgvStudentsInfo);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1298, 562);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search Student";
            // 
            // dgvStudentsInfo
            // 
            this.dgvStudentsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentsInfo.Location = new System.Drawing.Point(47, 216);
            this.dgvStudentsInfo.Name = "dgvStudentsInfo";
            this.dgvStudentsInfo.RowHeadersWidth = 51;
            this.dgvStudentsInfo.RowTemplate.Height = 29;
            this.dgvStudentsInfo.Size = new System.Drawing.Size(1209, 309);
            this.dgvStudentsInfo.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Location = new System.Drawing.Point(254, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 125);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(188, 51);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(276, 32);
            this.txtID.TabIndex = 17;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(28, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 30);
            this.label17.TabIndex = 16;
            this.label17.Text = "Student ID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(504, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(278, 40);
            this.label16.TabIndex = 2;
            this.label16.Text = " Search Student";
            // 
            // backBtn
            // 
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(26, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(46, 40);
            this.backBtn.TabIndex = 46;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1355, 826);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.tcStudent);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.tcStudent.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlEducation.ResumeLayout(false);
            this.pnlEducation.PerformLayout();
            this.pnlStudentInfo.ResumeLayout(false);
            this.pnlStudentInfo.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcStudent;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlEducation;
        private System.Windows.Forms.Panel pnlStudentInfo;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGuardian;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInputID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmitStudentInfo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpJoin;
        private System.Windows.Forms.ComboBox cmboxSelectClassID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvStudentsInfo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button backBtn;
    }
}