using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class Form1 : Form
    {
        internal StudentsEntities db = new StudentsEntities();
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
            lblForm1UserPrompt.Text = "Welcome to StudentApp.";
        }

        // set DataSources
        private void BindData()
        {
            bsStudents.DataSource = db.students.ToList();
            dgvStudents.DataSource = bsStudents;
           // dgvStudents.Columns[0].ReadOnly = true;
        }

        // set student entities equal to students in BindingSource
        private void UpdateEntities()
        {
            db.students.RemoveRange(db.students);
            db.SaveChanges();

            foreach (student studentElement in bsStudents)
            {
                db.students.Add(studentElement);
            }
        }

        // Displaying student info(name & credits) in lables, & refreshes DataGridView
        private void DisplayStudent()
        {
            if (bsStudents.Current != null)
            {
                lblName.Text = ((student)bsStudents.Current).FullName;
                lblCurrent.Text = ((student)bsStudents.Current).CurrentCredits.ToString();
                lblTotal.Text = ((student)bsStudents.Current).TotalCredits.ToString();
                
                //dgvStudents.Refresh();
            }
        }

        // update display when differnt student is selected 
        private void bsStudents_CurrentChanged(object sender, EventArgs e)
        {
            DisplayStudent();
        }

        // add 1 credit to selected student's current credits
        private void btnAdd1_Click(object sender, EventArgs e)
        {
            ((student)bsStudents.Current).CurrentCredits += 1;
            DisplayStudent();
            dgvStudents.Refresh();
            lblForm1UserPrompt.Text = "1 credit has been added to the current credits of " + ((student)bsStudents.Current).FullName;
        }

        // add 3 credits to selected student's current credits
        private void btnAdd3_Click(object sender, EventArgs e)
        {
            ((student)bsStudents.Current).CurrentCredits += 3;
            DisplayStudent();
            dgvStudents.Refresh();
            lblForm1UserPrompt.Text = "3 credits has been added to the current credits of " + ((student)bsStudents.Current).FullName;
        }

        // place current credits into total credits of selected student
        private void btnAddCurrentToTotal_Click(object sender, EventArgs e)
        {
            ((student)bsStudents.Current).AddCurrentToTotal();
            DisplayStudent();
            lblForm1UserPrompt.Text = ((student)bsStudents.Current).FullName + "'s" + " current credits were added to their total credits.";
        }

        // change current credits of selected student to user input
        private void btnUpdateCurrentCredits_Click(object sender, EventArgs e)
        {
            string currentCredits = txtUpdateCurrentCredits.Text;
            int currentCreditsNumeric = 0;

            // validate user input
            if (int.TryParse(currentCredits, out currentCreditsNumeric))
            {
                ((student)bsStudents.Current).CurrentCredits = currentCreditsNumeric;
                DisplayStudent();
                dgvStudents.Refresh();
                lblForm1UserPrompt.Text = ((student)bsStudents.Current).FullName + "'s" + " current crdits have been set to " + currentCredits;
                txtUpdateCurrentCredits.Clear();
            }
            else
            {
                lblForm1UserPrompt.Text = "Please enter numeric data for current credits.";
                txtUpdateCurrentCredits.Clear();
            } 
        }

        // change total credits of selected student to user input
        private void btnUpdateTotalCredits_Click(object sender, EventArgs e)
        {
            string totalCredits = txtUpdateTotalCredits.Text;
            int totalCreditsNumeric = 0;

            // validate user input
            if (int.TryParse(totalCredits, out totalCreditsNumeric))
            {
                ((student)bsStudents.Current).TotalCredits = totalCreditsNumeric;
                DisplayStudent();
                dgvStudents.Refresh();
                lblForm1UserPrompt.Text = ((student)bsStudents.Current).FullName + "'s" + " total crdits have been set to " + totalCredits;
                txtUpdateTotalCredits.Clear();
            }
            else
            {
                lblForm1UserPrompt.Text = "Please enter numeric data for total credits.";
                txtUpdateCurrentCredits.Clear();
            }
        }

        // add 1 credit to all student's current credits
        private void btnAdd1All_Click(object sender, EventArgs e)
        {
            foreach (student s in bsStudents)
            {
                s.CurrentCredits += 1;
            }
            DisplayStudent();
            dgvStudents.Refresh();
            lblForm1UserPrompt.Text = "1 credit has been added to the current credits of all students";
        }

        // add 3 credits to all student's current credits
        private void btnAdd3All_Click(object sender, EventArgs e)
        {
            foreach (student s in bsStudents)
            {
                s.CurrentCredits += 3;
            }
            DisplayStudent();
            dgvStudents.Refresh();
            lblForm1UserPrompt.Text = "3 credits have been added to the current credits of all students";
        }

        // place current credits into total credits of all students
        private void btnAddCurrentToTotalAll_Click(object sender, EventArgs e)
        {
            foreach (student s in bsStudents)
            {
                s.AddCurrentToTotal();
            }
            DisplayStudent();
            dgvStudents.Refresh();
            lblForm1UserPrompt.Text = "The current credits of all students have been added to their total credits.";
        }

        // set current credits to 0 for all students
        private void btnSetCurrent0All_Click(object sender, EventArgs e)
        {
            foreach (student s in bsStudents)
            {
                s.CurrentCredits = 0;
            }
            DisplayStudent();
            dgvStudents.Refresh();
            lblForm1UserPrompt.Text = "The current credits of all students have been set to 0.";
        }

        // set total credits to 0 for all students
        private void btnSetTotal0All_Click(object sender, EventArgs e)
        {
            foreach (student s in bsStudents)
            {
                s.TotalCredits = 0;
            }
            DisplayStudent();
            lblForm1UserPrompt.Text = "The total credits of all students have been set to 0.";
        }

        // navigate to first element
        private void btnFirst_Click(object sender, EventArgs e)
        {
            bsStudents.MoveFirst();
        }

        // navigate to preceding element
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bsStudents.MovePrevious();
        }

        // navigate to succeeding element
        private void btnNext_Click(object sender, EventArgs e)
        {
            bsStudents.MoveNext();
        }

        // navigate to last element
        private void btnLast_Click(object sender, EventArgs e)
        {
            bsStudents.MoveLast();
        }

        private void btnSearchByFirst_Click(object sender, EventArgs e)
        {
            List<student> students = new List<student>();

            foreach (student s in bsStudents)
            {
                if (s.StudentFirstName.ToLower().StartsWith(txtSearchFirstName.Text.ToLower()))
                {
                    students.Add(s);
                }
            }

            if (students.Any())
            {
                bsStudents.Position = bsStudents.IndexOf(students.First());
                lstSearchFirstName.DisplayMember = "FullName";
                lstSearchFirstName.DataSource = students;
                DisplayStudent();
            }
            else
            {
                MessageBox.Show("Not found");
            }
        }

        private void lstSearchFirstName_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<student> students = new List<student>();

            foreach (student s in bsStudents)
            {
                if (s.FullName == lstSearchFirstName.Text)
                {
                    students.Add(s);
                }
            }

            if (students.Any())
            {
                bsStudents.Position = bsStudents.IndexOf(students.First());
            }
            else
            {
                MessageBox.Show("Not found");
            }
        }

        // searches BindingSource for names that start with user input
        private void btnSearchByLast_Click(object sender, EventArgs e)
        {
            List<student> students = new List<student>();

            foreach (student s in bsStudents)
            {
                if (s.StudentLastName.ToLower().StartsWith(txtSearchLastName.Text.ToLower()))
                {
                    students.Add(s);
                }
            }

            if (students.Any())
            {
                bsStudents.Position = bsStudents.IndexOf(students.First());
                lstSearchLastName.DisplayMember = "FullName";
                lstSearchLastName.DataSource = students;
                DisplayStudent();
            }
            else
            {
                MessageBox.Show("Not found");
            }
        }

        // navigate to name selected in ListBox
        private void lstSearchLastName_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<student> students = new List<student>();

            foreach (student s in bsStudents)
            {
                if (s.FullName == lstSearchLastName.Text)
                {
                    students.Add(s);
                }
            }

            if (students.Any())
            {
                bsStudents.Position = bsStudents.IndexOf(students.First());
            }
            else
            {
                MessageBox.Show("Not found");
            }
        }

        // create new student & add student to BindingSource
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //int nextStudentID = bsStudents.Count + 1;
            //int nextStudentID = int.Parse(dgvStudents[0, bsStudents.Count - 1].Value.ToString()) + 1;
            //var lastStudentInserted = db.students.OrderByDescending(student => student.Id).First();

            int nextStudentID;
            try
            {
                nextStudentID = int.Parse(dgvStudents[0, bsStudents.Count - 1].Value.ToString()) + 1;
            }
            catch (Exception ex)
            {
                nextStudentID = 1;
            }

            //int nextStudentID = lastStudentInserted.Id + 1;

            form2 = new Form2(nextStudentID);
            form2.ShowDialog();
            
            if (form2.newStudent != null)
            {
                //db.students.Add(form2.newStudent);
                
                bsStudents.AddNew();
                form2.newStudent = null;


            }
        }

        private void bsStudents_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = form2.newStudent;
        }

        // remove student from binding source
        private void btnRemove_Click(object sender, EventArgs e)
        {
            string fullName = ((student)bsStudents.Current).FullName;
            
            bsStudents. RemoveCurrent();
            //UpdateEntities();

            lblForm1UserPrompt.Text = fullName + " has been removed.";
        }

        // save BindingSource to DB
        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            UpdateEntities();
            db.SaveChanges();
            lblForm1UserPrompt.Text = "All changes have been saved.";
        }

        // exit app
        private void btnExitForm1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
