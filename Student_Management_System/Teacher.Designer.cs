
namespace Student_Management_System
{
    partial class Teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher));
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tcTeacherInsert = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlStudentInfo = new System.Windows.Forms.Panel();
            this.dtpJoinTeacher = new System.Windows.Forms.DateTimePicker();
            this.txtInputTeacherID = new System.Windows.Forms.TextBox();
            this.btnSubmitTeacherInfo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasswordTeacher = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTeacherSalary = new System.Windows.Forms.TextBox();
            this.txtTeacherNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTeacherAge = new System.Windows.Forms.TextBox();
            this.txtTeacherEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTeacherAddress = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvTeacherInfo = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtInsertIDSearch = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.tcTeacherInsert.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlStudentInfo.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherInfo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(414, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(458, 37);
            this.label9.TabIndex = 33;
            this.label9.Text = "Teacher\'s Personal Information";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tcTeacherInsert);
            this.panel2.Location = new System.Drawing.Point(12, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1343, 516);
            this.panel2.TabIndex = 35;
            // 
            // tcTeacherInsert
            // 
            this.tcTeacherInsert.Controls.Add(this.tabPage1);
            this.tcTeacherInsert.Controls.Add(this.tabPage2);
            this.tcTeacherInsert.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tcTeacherInsert.Location = new System.Drawing.Point(18, 1);
            this.tcTeacherInsert.Name = "tcTeacherInsert";
            this.tcTeacherInsert.SelectedIndex = 0;
            this.tcTeacherInsert.Size = new System.Drawing.Size(1301, 497);
            this.tcTeacherInsert.TabIndex = 36;
            this.tcTeacherInsert.Click += new System.EventHandler(this.tcTeacherInsert_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Controls.Add(this.pnlStudentInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1293, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insert";
            // 
            // pnlStudentInfo
            // 
            this.pnlStudentInfo.Controls.Add(this.dtpJoinTeacher);
            this.pnlStudentInfo.Controls.Add(this.txtInputTeacherID);
            this.pnlStudentInfo.Controls.Add(this.btnSubmitTeacherInfo);
            this.pnlStudentInfo.Controls.Add(this.label2);
            this.pnlStudentInfo.Controls.Add(this.txtPasswordTeacher);
            this.pnlStudentInfo.Controls.Add(this.label3);
            this.pnlStudentInfo.Controls.Add(this.label10);
            this.pnlStudentInfo.Controls.Add(this.txtTeacherName);
            this.pnlStudentInfo.Controls.Add(this.label4);
            this.pnlStudentInfo.Controls.Add(this.label5);
            this.pnlStudentInfo.Controls.Add(this.txtTeacherSalary);
            this.pnlStudentInfo.Controls.Add(this.txtTeacherNumber);
            this.pnlStudentInfo.Controls.Add(this.label1);
            this.pnlStudentInfo.Controls.Add(this.label6);
            this.pnlStudentInfo.Controls.Add(this.txtTeacherAge);
            this.pnlStudentInfo.Controls.Add(this.txtTeacherEmail);
            this.pnlStudentInfo.Controls.Add(this.label8);
            this.pnlStudentInfo.Controls.Add(this.label7);
            this.pnlStudentInfo.Controls.Add(this.txtTeacherAddress);
            this.pnlStudentInfo.Location = new System.Drawing.Point(15, 6);
            this.pnlStudentInfo.Name = "pnlStudentInfo";
            this.pnlStudentInfo.Size = new System.Drawing.Size(1272, 420);
            this.pnlStudentInfo.TabIndex = 0;
            // 
            // dtpJoinTeacher
            // 
            this.dtpJoinTeacher.Location = new System.Drawing.Point(921, 200);
            this.dtpJoinTeacher.Name = "dtpJoinTeacher";
            this.dtpJoinTeacher.Size = new System.Drawing.Size(276, 32);
            this.dtpJoinTeacher.TabIndex = 91;
            // 
            // txtInputTeacherID
            // 
            this.txtInputTeacherID.Location = new System.Drawing.Point(304, 64);
            this.txtInputTeacherID.Name = "txtInputTeacherID";
            this.txtInputTeacherID.Size = new System.Drawing.Size(276, 32);
            this.txtInputTeacherID.TabIndex = 74;
            // 
            // btnSubmitTeacherInfo
            // 
            this.btnSubmitTeacherInfo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSubmitTeacherInfo.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmitTeacherInfo.Location = new System.Drawing.Point(557, 313);
            this.btnSubmitTeacherInfo.Name = "btnSubmitTeacherInfo";
            this.btnSubmitTeacherInfo.Size = new System.Drawing.Size(151, 67);
            this.btnSubmitTeacherInfo.TabIndex = 90;
            this.btnSubmitTeacherInfo.Text = "Submit";
            this.btnSubmitTeacherInfo.UseVisualStyleBackColor = false;
            this.btnSubmitTeacherInfo.Click += new System.EventHandler(this.btnSubmitTeacherInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(76, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 30);
            this.label2.TabIndex = 73;
            this.label2.Text = "ID";
            // 
            // txtPasswordTeacher
            // 
            this.txtPasswordTeacher.Location = new System.Drawing.Point(921, 255);
            this.txtPasswordTeacher.Name = "txtPasswordTeacher";
            this.txtPasswordTeacher.Size = new System.Drawing.Size(276, 32);
            this.txtPasswordTeacher.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(76, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 30);
            this.label3.TabIndex = 75;
            this.label3.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(693, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 30);
            this.label10.TabIndex = 88;
            this.label10.Text = "Password";
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(304, 104);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(276, 32);
            this.txtTeacherName.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(693, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 30);
            this.label4.TabIndex = 87;
            this.label4.Text = "Join Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(693, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 30);
            this.label5.TabIndex = 77;
            this.label5.Text = "Number";
            // 
            // txtTeacherSalary
            // 
            this.txtTeacherSalary.Location = new System.Drawing.Point(921, 151);
            this.txtTeacherSalary.Name = "txtTeacherSalary";
            this.txtTeacherSalary.Size = new System.Drawing.Size(276, 32);
            this.txtTeacherSalary.TabIndex = 86;
            this.txtTeacherSalary.Leave += new System.EventHandler(this.txtTeacherSalary_Leave);
            // 
            // txtTeacherNumber
            // 
            this.txtTeacherNumber.Location = new System.Drawing.Point(921, 64);
            this.txtTeacherNumber.Name = "txtTeacherNumber";
            this.txtTeacherNumber.Size = new System.Drawing.Size(276, 32);
            this.txtTeacherNumber.TabIndex = 78;
            this.txtTeacherNumber.TextChanged += new System.EventHandler(this.txtTeacherNumber_TextChanged);
            this.txtTeacherNumber.Leave += new System.EventHandler(this.txtTeacherNumber_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(693, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 30);
            this.label1.TabIndex = 85;
            this.label1.Text = "Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(76, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 30);
            this.label6.TabIndex = 79;
            this.label6.Text = "Email";
            // 
            // txtTeacherAge
            // 
            this.txtTeacherAge.Location = new System.Drawing.Point(921, 107);
            this.txtTeacherAge.Name = "txtTeacherAge";
            this.txtTeacherAge.Size = new System.Drawing.Size(276, 32);
            this.txtTeacherAge.TabIndex = 84;
            this.txtTeacherAge.Leave += new System.EventHandler(this.txtTeacherAge_Leave);
            // 
            // txtTeacherEmail
            // 
            this.txtTeacherEmail.Location = new System.Drawing.Point(304, 154);
            this.txtTeacherEmail.Name = "txtTeacherEmail";
            this.txtTeacherEmail.Size = new System.Drawing.Size(276, 32);
            this.txtTeacherEmail.TabIndex = 80;
            this.txtTeacherEmail.Leave += new System.EventHandler(this.txtTeacherEmail_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(693, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 30);
            this.label8.TabIndex = 83;
            this.label8.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(76, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 30);
            this.label7.TabIndex = 81;
            this.label7.Text = "Address";
            // 
            // txtTeacherAddress
            // 
            this.txtTeacherAddress.Location = new System.Drawing.Point(304, 197);
            this.txtTeacherAddress.Multiline = true;
            this.txtTeacherAddress.Name = "txtTeacherAddress";
            this.txtTeacherAddress.Size = new System.Drawing.Size(276, 85);
            this.txtTeacherAddress.TabIndex = 82;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MediumPurple;
            this.tabPage2.Controls.Add(this.dgvTeacherInfo);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1293, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search";
            // 
            // dgvTeacherInfo
            // 
            this.dgvTeacherInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherInfo.Location = new System.Drawing.Point(239, 131);
            this.dgvTeacherInfo.Name = "dgvTeacherInfo";
            this.dgvTeacherInfo.RowHeadersWidth = 51;
            this.dgvTeacherInfo.RowTemplate.Height = 29;
            this.dgvTeacherInfo.Size = new System.Drawing.Size(800, 293);
            this.dgvTeacherInfo.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtInsertIDSearch);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Location = new System.Drawing.Point(239, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 106);
            this.panel3.TabIndex = 0;
            // 
            // txtInsertIDSearch
            // 
            this.txtInsertIDSearch.Location = new System.Drawing.Point(232, 36);
            this.txtInsertIDSearch.Name = "txtInsertIDSearch";
            this.txtInsertIDSearch.Size = new System.Drawing.Size(276, 32);
            this.txtInsertIDSearch.TabIndex = 19;
            this.txtInsertIDSearch.TextChanged += new System.EventHandler(this.txtInsertIDSearch_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(19, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(207, 30);
            this.label17.TabIndex = 18;
            this.label17.Text = "Enter Teacher ID";
            // 
            // backBtn
            // 
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(30, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(46, 40);
            this.backBtn.TabIndex = 36;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1397, 691);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher";
            this.panel2.ResumeLayout(false);
            this.tcTeacherInsert.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlStudentInfo.ResumeLayout(false);
            this.pnlStudentInfo.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherInfo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tcTeacherInsert;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlStudentInfo;
        private System.Windows.Forms.DateTimePicker dtpJoinTeacher;
        private System.Windows.Forms.TextBox txtInputTeacherID;
        private System.Windows.Forms.Button btnSubmitTeacherInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPasswordTeacher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTeacherSalary;
        private System.Windows.Forms.TextBox txtTeacherNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTeacherAge;
        private System.Windows.Forms.TextBox txtTeacherEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTeacherAddress;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvTeacherInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtInsertIDSearch;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button backBtn;
    }
}