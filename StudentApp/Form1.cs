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
            }
        }

        // update display when differnt student is selected 
        private void bsStudents_CurrentChanged(object sender, EventArgs e)
        {
            DisplayStudent();
        }

        /*
         * selected student controles 
         */
        private void btnAdd1_Click(object sender, EventArgs e)
        {
            ((student)bsStudents.Current).CurrentCredits += 1;
            DisplayStudent();
            dgvStudents.Refresh();
            lblForm1UserPrompt.Text = "1 credit has been added to the current credits of " + ((student)bsStudents.Current).FullName;
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            ((student)bsStudents.Current).CurrentCredits += 3;
            DisplayStudent();
            dgvStudents.Refresh();
            lblForm1UserPrompt.Text = "3 credits has been added to the current credits of " + ((student)bsStudents.Current).FullName;
        }

        private void btnAddCurrentToTotal_Click(object sender, EventArgs e)
        {
            ((student)bsStudents.Current).AddCurrentToTotal();
            DisplayStudent();
            dgvStudents.Refresh();
            lblForm1UserPrompt.Text = ((student)bsStudents.Current).FullName + "'s" + " current credits were added to their total credits.";
        }

        private void btnUpdateCurrentCredits_Click(object sender, EventArgs e)
        {
            string currentCredits = txtUpdateCurrentCredits.Text;
            int currentCreditsNumeric = 0;

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

        private void btnUpdateTotalCredits_Click(object sender, EventArgs e)
        {
            string totalCredits = txtUpdateTotalCredits.Text;
            int totalCreditsNumeric = 0;

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

        /*
        * all students controles 
        */
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

        private void btnSetTotal0All_Click(object sender, EventArgs e)
        {
            foreach (student s in bsStudents)
            {
                s.TotalCredits = 0;
            }
            DisplayStudent();
            dgvStudents.Refresh();
            lblForm1UserPrompt.Text = "The total credits of all students have been set to 0.";
        }

        /*
        * navigation controles 
        */
        private void btnFirst_Click(object sender, EventArgs e)
        {
            bsStudents.MoveFirst();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bsStudents.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bsStudents.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bsStudents.MoveLast();
        }

        /*
        * search by name controles 
        */
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

        /*
        * add & remove controles 
        */
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            int nextStudentID;
            try
            {
                nextStudentID = int.Parse(dgvStudents[0, bsStudents.Count - 1].Value.ToString()) + 1;
            }
            catch (Exception ex)
            {
                nextStudentID = 1;
            }

            form2 = new Form2(nextStudentID);
            form2.ShowDialog();
            
            if (form2.newStudent != null)
            {
                bsStudents.AddNew();
                form2.newStudent = null;
            }
        }

        private void bsStudents_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = form2.newStudent;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string fullName = ((student)bsStudents.Current).FullName;
            bsStudents. RemoveCurrent();
            lblForm1UserPrompt.Text = fullName + " has been removed.";
        }

        /*
        * save & exit controles 
        */
        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            UpdateEntities();
            db.SaveChanges();
            lblForm1UserPrompt.Text = "All changes have been saved.";
        }

        private void btnExitForm1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
