namespace StudentManagementSystem
{
    partial class Main
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbStudentNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbLecturerNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpLecturerList = new System.Windows.Forms.TabPage();
            this.lstLecturer = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpStudentList = new System.Windows.Forms.TabPage();
            this.lstStudent = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpDetailView = new System.Windows.Forms.TabPage();
            this.rbGCStudent = new System.Windows.Forms.RadioButton();
            this.rbLecturer = new System.Windows.Forms.RadioButton();
            this.rbGTStudent = new System.Windows.Forms.RadioButton();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtDob = new System.Windows.Forms.DateTimePicker();
            this.tbBatchDept = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpLecturerList.SuspendLayout();
            this.tpStudentList.SuspendLayout();
            this.tpDetailView.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatus,
            this.lbStudentNum,
            this.lbLecturerNum});
            this.statusStrip.Location = new System.Drawing.Point(0, 803);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1556, 37);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lbStatus
            // 
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(496, 32);
            this.lbStatus.Text = "Welcome to student management system!";
            // 
            // lbStudentNum
            // 
            this.lbStudentNum.Name = "lbStudentNum";
            this.lbStudentNum.Size = new System.Drawing.Size(22, 32);
            this.lbStudentNum.Text = " ";
            // 
            // lbLecturerNum
            // 
            this.lbLecturerNum.Name = "lbLecturerNum";
            this.lbLecturerNum.Size = new System.Drawing.Size(22, 32);
            this.lbLecturerNum.Text = " ";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tpLecturerList);
            this.tabControl.Controls.Add(this.tpStudentList);
            this.tabControl.Controls.Add(this.tpDetailView);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 54);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1523, 746);
            this.tabControl.TabIndex = 3;
            // 
            // tpLecturerList
            // 
            this.tpLecturerList.Controls.Add(this.lstLecturer);
            this.tpLecturerList.Location = new System.Drawing.Point(4, 34);
            this.tpLecturerList.Name = "tpLecturerList";
            this.tpLecturerList.Padding = new System.Windows.Forms.Padding(3);
            this.tpLecturerList.Size = new System.Drawing.Size(1515, 708);
            this.tpLecturerList.TabIndex = 2;
            this.tpLecturerList.Text = "Lecturer list";
            this.tpLecturerList.UseVisualStyleBackColor = true;
            // 
            // lstLecturer
            // 
            this.lstLecturer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader4,
            this.columnHeader5});
            this.lstLecturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLecturer.FullRowSelect = true;
            this.lstLecturer.GridLines = true;
            this.lstLecturer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstLecturer.HideSelection = false;
            this.lstLecturer.Location = new System.Drawing.Point(3, 3);
            this.lstLecturer.Name = "lstLecturer";
            this.lstLecturer.Size = new System.Drawing.Size(1509, 702);
            this.lstLecturer.TabIndex = 1;
            this.lstLecturer.UseCompatibleStateImageBehavior = false;
            this.lstLecturer.View = System.Windows.Forms.View.Details;
            this.lstLecturer.SelectedIndexChanged += new System.EventHandler(this.lstLecturer_SelectedIndexChanged);
            this.lstLecturer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstLecturer_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date of birth";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Address";
            this.columnHeader6.Width = 300;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            this.columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Department";
            this.columnHeader5.Width = 250;
            // 
            // tpStudentList
            // 
            this.tpStudentList.Controls.Add(this.lstStudent);
            this.tpStudentList.Location = new System.Drawing.Point(4, 34);
            this.tpStudentList.Name = "tpStudentList";
            this.tpStudentList.Padding = new System.Windows.Forms.Padding(3);
            this.tpStudentList.Size = new System.Drawing.Size(1515, 708);
            this.tpStudentList.TabIndex = 0;
            this.tpStudentList.Text = "Student List";
            this.tpStudentList.UseVisualStyleBackColor = true;
            // 
            // lstStudent
            // 
            this.lstStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lstStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStudent.FullRowSelect = true;
            this.lstStudent.GridLines = true;
            this.lstStudent.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstStudent.HideSelection = false;
            this.lstStudent.Location = new System.Drawing.Point(3, 3);
            this.lstStudent.Name = "lstStudent";
            this.lstStudent.Size = new System.Drawing.Size(1509, 702);
            this.lstStudent.TabIndex = 2;
            this.lstStudent.UseCompatibleStateImageBehavior = false;
            this.lstStudent.View = System.Windows.Forms.View.Details;
            this.lstStudent.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstStudent_MouseDoubleClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Name";
            this.columnHeader8.Width = 300;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Date of birth";
            this.columnHeader9.Width = 250;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Address";
            this.columnHeader10.Width = 300;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Email";
            this.columnHeader11.Width = 250;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Batch";
            this.columnHeader12.Width = 250;
            // 
            // tpDetailView
            // 
            this.tpDetailView.Controls.Add(this.rbGCStudent);
            this.tpDetailView.Controls.Add(this.rbLecturer);
            this.tpDetailView.Controls.Add(this.rbGTStudent);
            this.tpDetailView.Controls.Add(this.btnDelete);
            this.tpDetailView.Controls.Add(this.btnUpdate);
            this.tpDetailView.Controls.Add(this.btnAdd);
            this.tpDetailView.Controls.Add(this.dtDob);
            this.tpDetailView.Controls.Add(this.tbBatchDept);
            this.tpDetailView.Controls.Add(this.tbEmail);
            this.tpDetailView.Controls.Add(this.tbAddress);
            this.tpDetailView.Controls.Add(this.tbName);
            this.tpDetailView.Controls.Add(this.tbID);
            this.tpDetailView.Controls.Add(this.label7);
            this.tpDetailView.Controls.Add(this.label6);
            this.tpDetailView.Controls.Add(this.label5);
            this.tpDetailView.Controls.Add(this.label4);
            this.tpDetailView.Controls.Add(this.label3);
            this.tpDetailView.Controls.Add(this.label2);
            this.tpDetailView.Location = new System.Drawing.Point(4, 34);
            this.tpDetailView.Name = "tpDetailView";
            this.tpDetailView.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetailView.Size = new System.Drawing.Size(1515, 708);
            this.tpDetailView.TabIndex = 1;
            this.tpDetailView.Text = "Detail";
            this.tpDetailView.UseVisualStyleBackColor = true;
            // 
            // rbGCStudent
            // 
            this.rbGCStudent.AutoSize = true;
            this.rbGCStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGCStudent.Location = new System.Drawing.Point(385, 31);
            this.rbGCStudent.Name = "rbGCStudent";
            this.rbGCStudent.Size = new System.Drawing.Size(141, 29);
            this.rbGCStudent.TabIndex = 17;
            this.rbGCStudent.TabStop = true;
            this.rbGCStudent.Text = "GC Student";
            this.rbGCStudent.UseVisualStyleBackColor = true;
            this.rbGCStudent.CheckedChanged += new System.EventHandler(this.tbGCStudent_CheckedChanged);
            // 
            // rbLecturer
            // 
            this.rbLecturer.AutoSize = true;
            this.rbLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLecturer.Location = new System.Drawing.Point(552, 31);
            this.rbLecturer.Name = "rbLecturer";
            this.rbLecturer.Size = new System.Drawing.Size(109, 29);
            this.rbLecturer.TabIndex = 16;
            this.rbLecturer.TabStop = true;
            this.rbLecturer.Text = "Lecturer";
            this.rbLecturer.UseVisualStyleBackColor = true;
            this.rbLecturer.CheckedChanged += new System.EventHandler(this.tbLecturer_CheckedChanged);
            // 
            // rbGTStudent
            // 
            this.rbGTStudent.AutoSize = true;
            this.rbGTStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGTStudent.Location = new System.Drawing.Point(229, 31);
            this.rbGTStudent.Name = "rbGTStudent";
            this.rbGTStudent.Size = new System.Drawing.Size(139, 29);
            this.rbGTStudent.TabIndex = 15;
            this.rbGTStudent.TabStop = true;
            this.rbGTStudent.Text = "GT Student";
            this.rbGTStudent.UseVisualStyleBackColor = true;
            this.rbGTStudent.CheckedChanged += new System.EventHandler(this.rbGTStudent_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(660, 333);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(240, 63);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(412, 333);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(219, 63);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnAdd_Update_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(123, 333);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(253, 63);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add new";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Update_Click);
            // 
            // dtDob
            // 
            this.dtDob.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDob.Location = new System.Drawing.Point(229, 144);
            this.dtDob.Name = "dtDob";
            this.dtDob.Size = new System.Drawing.Size(200, 31);
            this.dtDob.TabIndex = 11;
            // 
            // tbBatchDept
            // 
            this.tbBatchDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBatchDept.Location = new System.Drawing.Point(229, 262);
            this.tbBatchDept.Name = "tbBatchDept";
            this.tbBatchDept.Size = new System.Drawing.Size(631, 31);
            this.tbBatchDept.TabIndex = 10;
            this.tbBatchDept.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(229, 224);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(631, 31);
            this.tbEmail.TabIndex = 9;
            this.tbEmail.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(229, 185);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(631, 31);
            this.tbAddress.TabIndex = 8;
            this.tbAddress.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(229, 106);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(631, 31);
            this.tbName.TabIndex = 7;
            this.tbName.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(229, 71);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(631, 31);
            this.tbID.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Batch/Department:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(146, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date of birth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(120, 8);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(1408, 31);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 840);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tpLecturerList.ResumeLayout(false);
            this.tpStudentList.ResumeLayout(false);
            this.tpDetailView.ResumeLayout(false);
            this.tpDetailView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpStudentList;
        private System.Windows.Forms.TabPage tpDetailView;
        private System.Windows.Forms.TabPage tpLecturerList;
        private System.Windows.Forms.ListView lstLecturer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lstStudent;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtDob;
        private System.Windows.Forms.TextBox tbBatchDept;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbLecturer;
        private System.Windows.Forms.RadioButton rbGTStudent;
        private System.Windows.Forms.RadioButton rbGCStudent;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
        private System.Windows.Forms.ToolStripStatusLabel lbStudentNum;
        private System.Windows.Forms.ToolStripStatusLabel lbLecturerNum;
    }
}

