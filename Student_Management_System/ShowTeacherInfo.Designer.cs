
namespace Student_Management_System
{
    partial class ShowTeacherInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowTeacherInfo));
            this.tcTeacherMarks = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMarkSubmit = new System.Windows.Forms.Button();
            this.cmbSubjectSelect = new System.Windows.Forms.ComboBox();
            this.txtAddMarks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnterIDStudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarkID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelId = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelJoindate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.txtStudentSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tcTeacherMarks.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcTeacherMarks
            // 
            this.tcTeacherMarks.Controls.Add(this.tabPage1);
            this.tcTeacherMarks.Controls.Add(this.tabPage2);
            this.tcTeacherMarks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tcTeacherMarks.Location = new System.Drawing.Point(12, 12);
            this.tcTeacherMarks.Name = "tcTeacherMarks";
            this.tcTeacherMarks.SelectedIndex = 0;
            this.tcTeacherMarks.Size = new System.Drawing.Size(1344, 567);
            this.tcTeacherMarks.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.ForestGreen;
            this.tabPage1.Controls.Add(this.txtStudentSearch);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1336, 531);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Marks";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(709, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(621, 399);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMarkSubmit);
            this.panel2.Controls.Add(this.cmbSubjectSelect);
            this.panel2.Controls.Add(this.txtAddMarks);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtEnterIDStudent);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtMarkID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(49, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 399);
            this.panel2.TabIndex = 0;
            // 
            // btnMarkSubmit
            // 
            this.btnMarkSubmit.BackColor = System.Drawing.Color.LightGreen;
            this.btnMarkSubmit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMarkSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnMarkSubmit.Location = new System.Drawing.Point(294, 299);
            this.btnMarkSubmit.Name = "btnMarkSubmit";
            this.btnMarkSubmit.Size = new System.Drawing.Size(141, 78);
            this.btnMarkSubmit.TabIndex = 45;
            this.btnMarkSubmit.Text = "Submit";
            this.btnMarkSubmit.UseVisualStyleBackColor = false;
            this.btnMarkSubmit.Click += new System.EventHandler(this.btnMarkSubmit_Click);
            // 
            // cmbSubjectSelect
            // 
            this.cmbSubjectSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubjectSelect.FormattingEnabled = true;
            this.cmbSubjectSelect.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "108",
            "115",
            "120",
            "201",
            "201",
            "207"});
            this.cmbSubjectSelect.Location = new System.Drawing.Point(241, 178);
            this.cmbSubjectSelect.Name = "cmbSubjectSelect";
            this.cmbSubjectSelect.Size = new System.Drawing.Size(276, 31);
            this.cmbSubjectSelect.TabIndex = 24;
            // 
            // txtAddMarks
            // 
            this.txtAddMarks.Location = new System.Drawing.Point(241, 247);
            this.txtAddMarks.Name = "txtAddMarks";
            this.txtAddMarks.Size = new System.Drawing.Size(276, 30);
            this.txtAddMarks.TabIndex = 23;
            this.txtAddMarks.TextChanged += new System.EventHandler(this.txtAddMarks_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 30);
            this.label4.TabIndex = 22;
            this.label4.Text = "Add Marks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 30);
            this.label3.TabIndex = 20;
            this.label3.Text = "Enter Subject ID";
            // 
            // txtEnterIDStudent
            // 
            this.txtEnterIDStudent.Location = new System.Drawing.Point(241, 110);
            this.txtEnterIDStudent.Name = "txtEnterIDStudent";
            this.txtEnterIDStudent.Size = new System.Drawing.Size(276, 30);
            this.txtEnterIDStudent.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Enter Student ID";
            // 
            // txtMarkID
            // 
            this.txtMarkID.Location = new System.Drawing.Point(241, 42);
            this.txtMarkID.Name = "txtMarkID";
            this.txtMarkID.Size = new System.Drawing.Size(276, 30);
            this.txtMarkID.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mark ID";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.tabPage2.Controls.Add(this.labelId);
            this.tabPage2.Controls.Add(this.labelName);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.labelJoindate);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.labelNumber);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.labelSalary);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.labelAge);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.labelEmail);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.labelAddress);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1336, 531);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Information";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelId.Location = new System.Drawing.Point(219, 53);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(37, 30);
            this.labelId.TabIndex = 96;
            this.labelId.Text = "ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(219, 96);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(87, 30);
            this.labelName.TabIndex = 97;
            this.labelName.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(43, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 30);
            this.label5.TabIndex = 96;
            this.label5.Text = "ID";
            // 
            // labelJoindate
            // 
            this.labelJoindate.AutoSize = true;
            this.labelJoindate.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJoindate.Location = new System.Drawing.Point(215, 362);
            this.labelJoindate.Name = "labelJoindate";
            this.labelJoindate.Size = new System.Drawing.Size(127, 30);
            this.labelJoindate.TabIndex = 103;
            this.labelJoindate.Text = "Join Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(43, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 30);
            this.label6.TabIndex = 97;
            this.label6.Text = "Name";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNumber.Location = new System.Drawing.Point(215, 229);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(109, 30);
            this.labelNumber.TabIndex = 98;
            this.labelNumber.Text = "Number";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(39, 362);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 30);
            this.label16.TabIndex = 103;
            this.label16.Text = "Join Date";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSalary.Location = new System.Drawing.Point(215, 316);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(83, 30);
            this.labelSalary.TabIndex = 102;
            this.labelSalary.Text = "Salary";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(39, 229);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 30);
            this.label15.TabIndex = 98;
            this.label15.Text = "Number";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAge.Location = new System.Drawing.Point(215, 269);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(62, 30);
            this.labelAge.TabIndex = 101;
            this.labelAge.Text = "Age";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(39, 316);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 30);
            this.label14.TabIndex = 102;
            this.label14.Text = "Salary";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(219, 146);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(78, 30);
            this.labelEmail.TabIndex = 99;
            this.labelEmail.Text = "Email";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(39, 269);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 30);
            this.label13.TabIndex = 101;
            this.label13.Text = "Age";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAddress.Location = new System.Drawing.Point(219, 186);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(105, 30);
            this.labelAddress.TabIndex = 100;
            this.labelAddress.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(43, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 30);
            this.label10.TabIndex = 99;
            this.label10.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(43, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 30);
            this.label12.TabIndex = 100;
            this.label12.Text = "Address";
            // 
            // backBtn
            // 
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(1306, -2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(46, 40);
            this.backBtn.TabIndex = 38;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // txtStudentSearch
            // 
            this.txtStudentSearch.Location = new System.Drawing.Point(1047, 76);
            this.txtStudentSearch.Name = "txtStudentSearch";
            this.txtStudentSearch.Size = new System.Drawing.Size(276, 30);
            this.txtStudentSearch.TabIndex = 24;
            this.txtStudentSearch.TextChanged += new System.EventHandler(this.txtStudentSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(841, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 30);
            this.label7.TabIndex = 23;
            this.label7.Text = "Enter Student ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ShowTeacherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1368, 637);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.tcTeacherMarks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowTeacherInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowTeacherInfo";
            this.Load += new System.EventHandler(this.ShowTeacherInfo_Load);
            this.tcTeacherMarks.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tcTeacherMarks;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbSubjectSelect;
        private System.Windows.Forms.TextBox txtAddMarks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnterIDStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarkID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMarkSubmit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelJoindate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStudentSearch;
        private System.Windows.Forms.Label label7;
    }
}