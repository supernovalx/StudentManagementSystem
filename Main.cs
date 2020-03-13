using StudentManagementSystem.Object;

using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class Main : Form
    {
        private DataManager dm;
        private bool isStudent = false;
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dm = DataManager.GetInstance();
            UpdateList();
        }

        private void UpdateList()
        {
            lstLecturer.Items.Clear();
            lstStudent.Items.Clear();

            foreach (Lecturer l in dm.AllLecturer())
            {
                ListViewItem i = new ListViewItem(l.ID);
                i.SubItems.Add(l.Name);
                i.SubItems.Add(l.DoB.ToString());
                i.SubItems.Add(l.Address);
                i.SubItems.Add(l.Email);
                i.SubItems.Add(l.Dept);

                lstLecturer.Items.Add(i);
            }

            foreach (Student l in dm.AllStudent())
            {
                ListViewItem i = new ListViewItem(l.ID);
                i.SubItems.Add(l.Name);
                i.SubItems.Add(l.DoB.ToString());
                i.SubItems.Add(l.Address);
                i.SubItems.Add(l.Email);
                i.SubItems.Add(l.Batch);

                lstStudent.Items.Add(i);
            }
        }

        private void SetDetailData(Person p)
        {
            bool isStudent = p is Student;
            tbID.Text = p.ID;
            tbName.Text = p.Name;
            tbAddress.Text = p.Address;
            tbEmail.Text = p.Email;
            tbBatchDept.Text = isStudent ? (p as Student).Batch : (p as Lecturer).Dept;
            dtDob.Value = p.DoB;

            if (isStudent)
            {
                if (p.ID.Contains("GT"))
                    rbGTStudent.Checked = true;
                else
                    rbGCStudent.Checked = true;
            }
            else
                rbLecturer.Checked = true;

            UpdateButtonText(isStudent);
        }

        private void UpdateButtonText(bool isStudent)
        {
            string entity = isStudent ? "student" : "lecturer";
            btnAdd.Text = "Add new " + entity;
            btnUpdate.Text = "Update " + entity;
            btnDelete.Text = "Delete " + entity;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text == "randomdata")
            {
                tbSearch.Text = "";
                GenerateRandomData();
            }
            if (tbSearch.Text == "opendb")
            {
                tbSearch.Text = "";
                OpenDbDirectory();
            }
        }

        private void OpenDbDirectory()
        {
            Process.Start("explorer.exe", Directory.GetCurrentDirectory());
        }

        private void GenerateRandomData()
        {
            for (int i = 0; i < 100; i++)
            {
                Lecturer l = new Lecturer("11111111", "dawdaw", DateTime.Now, "awdoawmd", "dawdw", "gfregbe");
                dm.Add(l);
            }

            for (int i = 0; i < 100; i++)
            {
                Student l = new Student("GT111111", "dawdaw", DateTime.Now, "awdoawmd", "dawdw", "gfregbe");
                dm.Add(l);
            }
        }

        private void lstLecturer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstLecturer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstLecturer.SelectedItems.Count == 0) return;

            ListViewItem i = lstLecturer.SelectedItems[0];
            Lecturer l = dm.FindLecturerByID(lstLecturer.SelectedItems[0].SubItems[0].Text);
            if (l == null) return;
            SetDetailData(l);

            tabControl.SelectTab(2);
        }


        private bool ValidateInput()
        {
            bool isNameValid = !string.IsNullOrWhiteSpace(tbName.Text);
            bool isAddressValid = !string.IsNullOrWhiteSpace(tbAddress.Text);
            bool isEmailValid = !string.IsNullOrWhiteSpace(tbEmail.Text);
            bool isBatchDeptValid = !string.IsNullOrWhiteSpace(tbBatchDept.Text);

            SetTextBoxColor(tbName, isNameValid);
            SetTextBoxColor(tbAddress, isAddressValid);
            SetTextBoxColor(tbEmail, isEmailValid);
            SetTextBoxColor(tbBatchDept, isBatchDeptValid);

            return isNameValid && isAddressValid && isEmailValid && isBatchDeptValid;
        }

        private void SetTextBoxColor(TextBox tb, bool valid)
        {
            tb.BackColor = valid ? Color.LightGreen : Color.LightPink;
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void rbGTStudent_CheckedChanged(object sender, EventArgs e)
        {
            isStudent = true;
            UpdateButtonText(isStudent);
            tbID.Text = dm.GetNextStudentId("GT");
        }

        private void tbLecturer_CheckedChanged(object sender, EventArgs e)
        {
            isStudent = false;
            UpdateButtonText(isStudent);
            tbID.Text = dm.GetNextLecturerId();
        }

        private void tbGCStudent_CheckedChanged(object sender, EventArgs e)
        {
            isStudent = true;
            UpdateButtonText(isStudent);
            tbID.Text = dm.GetNextStudentId("GC");

        }

        private void btnAdd_Update_Click(object sender, EventArgs e)
        {
            bool isAdd = (sender as Button).Name == "btnAdd";
            if (ValidateInput())
            {
                if (isStudent)
                {
                    Student s = new Student(tbID.Text, tbName.Text, dtDob.Value, tbAddress.Text, tbEmail.Text, tbBatchDept.Text);
                    if (isAdd)
                        dm.Add(s);
                    else
                        dm.Update(tbID.Text, s);
                }
                else
                {
                    Lecturer s = new Lecturer(tbID.Text, tbName.Text, dtDob.Value, tbAddress.Text, tbEmail.Text, tbBatchDept.Text);
                    if (isAdd)
                        dm.Add(s);
                    else
                        dm.Update(tbID.Text, s);
                }

                UpdateStatusBar($"{(isAdd ? "New" : "")} {(isStudent ? "student" : "lecturer")} {(isAdd ? "added" : "updated")}!", Color.Green);
                UpdateList();


                if (isStudent)
                {
                    tabControl.SelectTab(1);
                    lstStudent.Items[lstStudent.Items.Count - 1].Selected = true;
                    lstStudent.Items[lstStudent.Items.Count - 1].Focused = true;
                    lstStudent.Items[lstStudent.Items.Count - 1].EnsureVisible();
                }
                else
                {
                    tabControl.SelectTab(0);
                    lstLecturer.Items[lstLecturer.Items.Count - 1].Selected = true;
                    lstLecturer.Items[lstLecturer.Items.Count - 1].Focused = true;
                    lstLecturer.Items[lstLecturer.Items.Count - 1].EnsureVisible();
                }

            }
            else
            {
                UpdateStatusBar("Wrong format, please check your input!", Color.Red);
            }
        }

        private void UpdateStatusBar(string message, Color c)
        {
            lbStatus.Text = message;
            lbStatus.ForeColor = c;

            lbStudentNum.Text = "Number of students in database: " + dm.AllStudent().Count;
            lbLecturerNum.Text = "Number of lecturers in database: " + dm.AllLecturer().Count;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void lstStudent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstStudent.SelectedItems.Count == 0) return;

            ListViewItem i = lstStudent.SelectedItems[0];
            Student l = dm.FindStudentByID(lstStudent.SelectedItems[0].SubItems[0].Text);
            if (l == null) return;
            SetDetailData(l);

            tabControl.SelectTab(2);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
