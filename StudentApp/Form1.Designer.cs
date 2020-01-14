using System;

namespace StudentApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnAdd3All = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.btnAddCurrentToTotal = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchByLast = new System.Windows.Forms.Button();
            this.lstSearchLastName = new System.Windows.Forms.ListBox();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.btnAddCurrentToTotalAll = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd1All = new System.Windows.Forms.Button();
            this.btnUpdateCurrentCredits = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUpdateCurrentCredits = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSetTotal0All = new System.Windows.Forms.Button();
            this.btnSetCurrent0All = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtUpdateTotalCredits = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdateTotalCredits = new System.Windows.Forms.Button();
            this.lblForm1UserPrompt = new System.Windows.Forms.Label();
            this.btnSaveToDB = new System.Windows.Forms.Button();
            this.btnExitForm1 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSearchByFirst = new System.Windows.Forms.Button();
            this.lstSearchFirstName = new System.Windows.Forms.ListBox();
            this.txtSearchFirstName = new System.Windows.Forms.TextBox();
            this.bsStudents = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd3All
            // 
            this.btnAdd3All.Location = new System.Drawing.Point(190, 39);
            this.btnAdd3All.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd3All.Name = "btnAdd3All";
            this.btnAdd3All.Size = new System.Drawing.Size(179, 23);
            this.btnAdd3All.TabIndex = 15;
            this.btnAdd3All.Text = "Add 3 Current Credits To All";
            this.btnAdd3All.UseVisualStyleBackColor = true;
            this.btnAdd3All.Click += new System.EventHandler(this.btnAdd3All_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(9, 37);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowTemplate.Height = 28;
            this.dgvStudents.Size = new System.Drawing.Size(643, 244);
            this.dgvStudents.TabIndex = 14;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(126, 126);
            this.btnLast.Margin = new System.Windows.Forms.Padding(2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(32, 23);
            this.btnLast.TabIndex = 12;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(90, 126);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(32, 23);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(54, 126);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(32, 23);
            this.btnPrevious.TabIndex = 10;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(18, 126);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(32, 23);
            this.btnFirst.TabIndex = 9;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnAdd1
            // 
            this.btnAdd1.Location = new System.Drawing.Point(196, 38);
            this.btnAdd1.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(118, 24);
            this.btnAdd1.TabIndex = 8;
            this.btnAdd1.Text = "Add 1 Current Credit";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // btnAddCurrentToTotal
            // 
            this.btnAddCurrentToTotal.Location = new System.Drawing.Point(440, 38);
            this.btnAddCurrentToTotal.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCurrentToTotal.Name = "btnAddCurrentToTotal";
            this.btnAddCurrentToTotal.Size = new System.Drawing.Size(188, 24);
            this.btnAddCurrentToTotal.TabIndex = 7;
            this.btnAddCurrentToTotal.Text = "Place Current Credits In Total Credits";
            this.btnAddCurrentToTotal.UseVisualStyleBackColor = true;
            this.btnAddCurrentToTotal.Click += new System.EventHandler(this.btnAddCurrentToTotal_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStudents, "TotalCredits", true));
            this.lblTotal.Location = new System.Drawing.Point(100, 88);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(92, 27);
            this.lblTotal.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Credits";
            // 
            // lblCurrent
            // 
            this.lblCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStudents, "CurrentCredits", true));
            this.lblCurrent.Location = new System.Drawing.Point(100, 64);
            this.lblCurrent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(92, 27);
            this.lblCurrent.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current Credits";
            // 
            // btnAdd3
            // 
            this.btnAdd3.Location = new System.Drawing.Point(318, 38);
            this.btnAdd3.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd3.Name = "btnAdd3";
            this.btnAdd3.Size = new System.Drawing.Size(118, 24);
            this.btnAdd3.TabIndex = 2;
            this.btnAdd3.Text = "Add 3 Current Credits";
            this.btnAdd3.UseVisualStyleBackColor = true;
            this.btnAdd3.Click += new System.EventHandler(this.btnAdd3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStudents, "FullName", true));
            this.lblName.Location = new System.Drawing.Point(100, 38);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 27);
            this.lblName.TabIndex = 0;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnSearchByLast);
            this.GroupBox1.Controls.Add(this.lstSearchLastName);
            this.GroupBox1.Controls.Add(this.txtSearchLastName);
            this.GroupBox1.Location = new System.Drawing.Point(863, 37);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Size = new System.Drawing.Size(181, 183);
            this.GroupBox1.TabIndex = 47;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Search for Student By Last Name";
            // 
            // btnSearchByLast
            // 
            this.btnSearchByLast.Location = new System.Drawing.Point(12, 42);
            this.btnSearchByLast.Name = "btnSearchByLast";
            this.btnSearchByLast.Size = new System.Drawing.Size(154, 23);
            this.btnSearchByLast.TabIndex = 25;
            this.btnSearchByLast.Text = "Search By Last";
            this.btnSearchByLast.UseVisualStyleBackColor = true;
            this.btnSearchByLast.Click += new System.EventHandler(this.btnSearchByLast_Click);
            // 
            // lstSearchLastName
            // 
            this.lstSearchLastName.FormattingEnabled = true;
            this.lstSearchLastName.Location = new System.Drawing.Point(10, 75);
            this.lstSearchLastName.Margin = new System.Windows.Forms.Padding(2);
            this.lstSearchLastName.Name = "lstSearchLastName";
            this.lstSearchLastName.Size = new System.Drawing.Size(156, 95);
            this.lstSearchLastName.TabIndex = 23;
            this.lstSearchLastName.SelectedIndexChanged += new System.EventHandler(this.lstSearchLastName_SelectedIndexChanged);
            // 
            // txtSearchLastName
            // 
            this.txtSearchLastName.Location = new System.Drawing.Point(10, 17);
            this.txtSearchLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchLastName.Name = "txtSearchLastName";
            this.txtSearchLastName.Size = new System.Drawing.Size(156, 20);
            this.txtSearchLastName.TabIndex = 22;
            // 
            // btnAddCurrentToTotalAll
            // 
            this.btnAddCurrentToTotalAll.Location = new System.Drawing.Point(13, 65);
            this.btnAddCurrentToTotalAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCurrentToTotalAll.Name = "btnAddCurrentToTotalAll";
            this.btnAddCurrentToTotalAll.Size = new System.Drawing.Size(356, 22);
            this.btnAddCurrentToTotalAll.TabIndex = 51;
            this.btnAddCurrentToTotalAll.Text = "Place Current Credits In Total Credits For All";
            this.btnAddCurrentToTotalAll.UseVisualStyleBackColor = true;
            this.btnAddCurrentToTotalAll.Click += new System.EventHandler(this.btnAddCurrentToTotalAll_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.ForeColor = System.Drawing.Color.Black;
            this.btnAddStudent.Location = new System.Drawing.Point(33, 18);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(148, 24);
            this.btnAddStudent.TabIndex = 54;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(205, 18);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(148, 24);
            this.btnRemove.TabIndex = 55;
            this.btnRemove.Text = "Remove Student";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd1All
            // 
            this.btnAdd1All.Location = new System.Drawing.Point(13, 39);
            this.btnAdd1All.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd1All.Name = "btnAdd1All";
            this.btnAdd1All.Size = new System.Drawing.Size(173, 23);
            this.btnAdd1All.TabIndex = 56;
            this.btnAdd1All.Text = "Add 1 Current Credit To All";
            this.btnAdd1All.UseVisualStyleBackColor = true;
            this.btnAdd1All.Click += new System.EventHandler(this.btnAdd1All_Click);
            // 
            // btnUpdateCurrentCredits
            // 
            this.btnUpdateCurrentCredits.Location = new System.Drawing.Point(440, 65);
            this.btnUpdateCurrentCredits.Name = "btnUpdateCurrentCredits";
            this.btnUpdateCurrentCredits.Size = new System.Drawing.Size(188, 23);
            this.btnUpdateCurrentCredits.TabIndex = 57;
            this.btnUpdateCurrentCredits.Text = "Update Current Credits";
            this.btnUpdateCurrentCredits.UseVisualStyleBackColor = true;
            this.btnUpdateCurrentCredits.Click += new System.EventHandler(this.btnUpdateCurrentCredits_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Input Current Credits:";
            // 
            // txtUpdateCurrentCredits
            // 
            this.txtUpdateCurrentCredits.Location = new System.Drawing.Point(318, 67);
            this.txtUpdateCurrentCredits.Name = "txtUpdateCurrentCredits";
            this.txtUpdateCurrentCredits.Size = new System.Drawing.Size(118, 20);
            this.txtUpdateCurrentCredits.TabIndex = 59;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddStudent);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Location = new System.Drawing.Point(658, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 55);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add or Remove Student";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.btnAdd1All);
            this.groupBox3.Controls.Add(this.btnAdd3All);
            this.groupBox3.Controls.Add(this.btnAddCurrentToTotalAll);
            this.groupBox3.Location = new System.Drawing.Point(658, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 157);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Credits For All Students";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSetTotal0All);
            this.groupBox5.Controls.Add(this.btnSetCurrent0All);
            this.groupBox5.Location = new System.Drawing.Point(8, 99);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(370, 50);
            this.groupBox5.TabIndex = 57;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Caution";
            // 
            // btnSetTotal0All
            // 
            this.btnSetTotal0All.Location = new System.Drawing.Point(182, 18);
            this.btnSetTotal0All.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetTotal0All.Name = "btnSetTotal0All";
            this.btnSetTotal0All.Size = new System.Drawing.Size(179, 24);
            this.btnSetTotal0All.TabIndex = 58;
            this.btnSetTotal0All.Text = "Set Total Credits To 0 For All";
            this.btnSetTotal0All.UseVisualStyleBackColor = true;
            this.btnSetTotal0All.Click += new System.EventHandler(this.btnSetTotal0All_Click);
            // 
            // btnSetCurrent0All
            // 
            this.btnSetCurrent0All.Location = new System.Drawing.Point(5, 18);
            this.btnSetCurrent0All.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetCurrent0All.Name = "btnSetCurrent0All";
            this.btnSetCurrent0All.Size = new System.Drawing.Size(173, 24);
            this.btnSetCurrent0All.TabIndex = 57;
            this.btnSetCurrent0All.Text = "Set Current Credits To 0 For All";
            this.btnSetCurrent0All.UseVisualStyleBackColor = true;
            this.btnSetCurrent0All.Click += new System.EventHandler(this.btnSetCurrent0All_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtUpdateTotalCredits);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btnUpdateTotalCredits);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.lblName);
            this.groupBox4.Controls.Add(this.btnAdd3);
            this.groupBox4.Controls.Add(this.txtUpdateCurrentCredits);
            this.groupBox4.Controls.Add(this.lblCurrent);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnUpdateCurrentCredits);
            this.groupBox4.Controls.Add(this.lblTotal);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnAddCurrentToTotal);
            this.groupBox4.Controls.Add(this.btnAdd1);
            this.groupBox4.Controls.Add(this.btnLast);
            this.groupBox4.Controls.Add(this.btnFirst);
            this.groupBox4.Controls.Add(this.btnNext);
            this.groupBox4.Controls.Add(this.btnPrevious);
            this.groupBox4.Location = new System.Drawing.Point(8, 286);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(644, 157);
            this.groupBox4.TabIndex = 62;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update Credits For Selected Student";
            // 
            // txtUpdateTotalCredits
            // 
            this.txtUpdateTotalCredits.Location = new System.Drawing.Point(318, 96);
            this.txtUpdateTotalCredits.Name = "txtUpdateTotalCredits";
            this.txtUpdateTotalCredits.Size = new System.Drawing.Size(118, 20);
            this.txtUpdateTotalCredits.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Input Total Credits:";
            // 
            // btnUpdateTotalCredits
            // 
            this.btnUpdateTotalCredits.Location = new System.Drawing.Point(440, 94);
            this.btnUpdateTotalCredits.Name = "btnUpdateTotalCredits";
            this.btnUpdateTotalCredits.Size = new System.Drawing.Size(188, 23);
            this.btnUpdateTotalCredits.TabIndex = 60;
            this.btnUpdateTotalCredits.Text = "Update Total Credits";
            this.btnUpdateTotalCredits.UseVisualStyleBackColor = true;
            this.btnUpdateTotalCredits.Click += new System.EventHandler(this.btnUpdateTotalCredits_Click);
            // 
            // lblForm1UserPrompt
            // 
            this.lblForm1UserPrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblForm1UserPrompt.Location = new System.Drawing.Point(180, 446);
            this.lblForm1UserPrompt.Name = "lblForm1UserPrompt";
            this.lblForm1UserPrompt.Size = new System.Drawing.Size(864, 53);
            this.lblForm1UserPrompt.TabIndex = 63;
            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.Location = new System.Drawing.Point(9, 449);
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.Size = new System.Drawing.Size(165, 23);
            this.btnSaveToDB.TabIndex = 63;
            this.btnSaveToDB.Text = "Save Changes To Database";
            this.btnSaveToDB.UseVisualStyleBackColor = true;
            this.btnSaveToDB.Click += new System.EventHandler(this.btnSaveToDB_Click);
            // 
            // btnExitForm1
            // 
            this.btnExitForm1.Location = new System.Drawing.Point(9, 476);
            this.btnExitForm1.Name = "btnExitForm1";
            this.btnExitForm1.Size = new System.Drawing.Size(165, 23);
            this.btnExitForm1.TabIndex = 64;
            this.btnExitForm1.Text = "Exit";
            this.btnExitForm1.UseVisualStyleBackColor = true;
            this.btnExitForm1.Click += new System.EventHandler(this.btnExitForm1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnSearchByFirst);
            this.groupBox6.Controls.Add(this.lstSearchFirstName);
            this.groupBox6.Controls.Add(this.txtSearchFirstName);
            this.groupBox6.Location = new System.Drawing.Point(658, 37);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(181, 183);
            this.groupBox6.TabIndex = 65;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Search for Student By First Name";
            // 
            // btnSearchByFirst
            // 
            this.btnSearchByFirst.Location = new System.Drawing.Point(10, 42);
            this.btnSearchByFirst.Name = "btnSearchByFirst";
            this.btnSearchByFirst.Size = new System.Drawing.Size(156, 23);
            this.btnSearchByFirst.TabIndex = 24;
            this.btnSearchByFirst.Text = "Search By First";
            this.btnSearchByFirst.UseVisualStyleBackColor = true;
            this.btnSearchByFirst.Click += new System.EventHandler(this.btnSearchByFirst_Click);
            // 
            // lstSearchFirstName
            // 
            this.lstSearchFirstName.FormattingEnabled = true;
            this.lstSearchFirstName.Location = new System.Drawing.Point(10, 75);
            this.lstSearchFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.lstSearchFirstName.Name = "lstSearchFirstName";
            this.lstSearchFirstName.Size = new System.Drawing.Size(156, 95);
            this.lstSearchFirstName.TabIndex = 23;
            this.lstSearchFirstName.SelectedIndexChanged += new System.EventHandler(this.lstSearchFirstName_SelectedIndexChanged);
            // 
            // txtSearchFirstName
            // 
            this.txtSearchFirstName.Location = new System.Drawing.Point(10, 17);
            this.txtSearchFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchFirstName.Name = "txtSearchFirstName";
            this.txtSearchFirstName.Size = new System.Drawing.Size(156, 20);
            this.txtSearchFirstName.TabIndex = 22;
            // 
            // bsStudents
            // 
            this.bsStudents.DataSource = typeof(StudentApp.student);
            this.bsStudents.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.bsStudents_AddingNew);
            this.bsStudents.CurrentItemChanged += new System.EventHandler(this.bsStudents_CurrentChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 505);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.lblForm1UserPrompt);
            this.Controls.Add(this.btnExitForm1);
            this.Controls.Add(this.btnSaveToDB);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.dgvStudents);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Student App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudents)).EndInit();
            this.ResumeLayout(false);

        }

       

        #endregion
        private System.Windows.Forms.Button btnAdd3All;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.BindingSource bsStudents;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Button btnAddCurrentToTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ListBox lstSearchLastName;
        internal System.Windows.Forms.TextBox txtSearchLastName;
        internal System.Windows.Forms.Button btnAddCurrentToTotalAll;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdateCurrentCredits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUpdateCurrentCredits;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblForm1UserPrompt;
        private System.Windows.Forms.TextBox txtUpdateTotalCredits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateTotalCredits;
        private System.Windows.Forms.Button btnAdd1All;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSetTotal0All;
        private System.Windows.Forms.Button btnSetCurrent0All;
        private System.Windows.Forms.Button btnSaveToDB;
        private System.Windows.Forms.Button btnExitForm1;
        internal System.Windows.Forms.GroupBox groupBox6;
        internal System.Windows.Forms.ListBox lstSearchFirstName;
        internal System.Windows.Forms.TextBox txtSearchFirstName;
        private System.Windows.Forms.Button btnSearchByLast;
        private System.Windows.Forms.Button btnSearchByFirst;
    }
}

