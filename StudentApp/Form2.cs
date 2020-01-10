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
    public partial class Form2 : Form
    {
        internal student newStudent;

        public Form2(int nextStudentID)
        {
            InitializeComponent();
            NextStudentID = nextStudentID; 
        }

        public int NextStudentID { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblForm2UserPrompt.Text = "Please enter a first name, last name, current and total credits.";
        }

        //accept & validate user input. pass arguments to student constructor
        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFirst.Text;
            string lastName = txtLast.Text;
            string currentCredits = txtCurrentCredits.Text;
            int currentCreditsNumeric = 0;
            string totalCredits = txtTotalCredits.Text;
            int totalCreditsNumeric = 0;

            //validate user input
            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && int.TryParse(currentCredits, out currentCreditsNumeric) && int.TryParse(totalCredits, out totalCreditsNumeric))
            {
                string firstNameCaseCorrect = char.ToUpper(firstName[0]) + firstName.Substring(1);
                string lastNameCaseCorrect = char.ToUpper(lastName[0]) + lastName.Substring(1);

                newStudent = new student(NextStudentID, firstNameCaseCorrect, lastNameCaseCorrect, currentCreditsNumeric, totalCreditsNumeric);

                lblForm2UserPrompt.Text = "Student has been saved.";
            }
            else
            {
                //if user did not entered first or last name
                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
                {
                    lblForm2UserPrompt.Text = "Please enter a first and last name.";
                }
                //if user did not entered a number for current credit
                else if (!int.TryParse(currentCredits, out currentCreditsNumeric))
                {
                    lblForm2UserPrompt.Text = "Please enter numeric data for current credits.";
                    txtCurrentCredits.Clear();
                }
                //if user did not entered a number for total credit
                else
                {
                    lblForm2UserPrompt.Text = "Please enter numeric data for total credits.";
                    txtTotalCredits.Clear();
                }
            }
        }
        // Exit form2
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
