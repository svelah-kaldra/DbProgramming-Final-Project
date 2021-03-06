﻿namespace DogShowTracker
{
    partial class frmDogs
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpSex = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.grpDogInfo = new System.Windows.Forms.GroupBox();
            this.btnViewBreed = new System.Windows.Forms.Button();
            this.btnViewOwner = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.dtpChampionshipDate = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.dtpDateBanned = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chkChampion = new System.Windows.Forms.CheckBox();
            this.chkBanned = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.chkRetired = new System.Windows.Forms.CheckBox();
            this.cmbOwner = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbBreed = new System.Windows.Forms.ComboBox();
            this.dtpDateOfRetirement = new System.Windows.Forms.DateTimePicker();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchOwner = new System.Windows.Forms.TextBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.cmbSearchBreed = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudMaxHeight = new System.Windows.Forms.NumericUpDown();
            this.nudMinHeight = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudMaxWeight = new System.Windows.Forms.NumericUpDown();
            this.nudMinWeight = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoSexEither = new System.Windows.Forms.RadioButton();
            this.rdoSearchFemale = new System.Windows.Forms.RadioButton();
            this.rdoSearchMale = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgCompetitions = new System.Windows.Forms.DataGridView();
            this.grpDogs = new System.Windows.Forms.GroupBox();
            this.lstDogs = new System.Windows.Forms.ListBox();
            this.btnNewDog = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteDog = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpSex.SuspendLayout();
            this.grpDogInfo.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinHeight)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinWeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompetitions)).BeginInit();
            this.grpDogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Weight:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Height:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date of Birth:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Breed:";
            // 
            // grpSex
            // 
            this.grpSex.Controls.Add(this.rdoFemale);
            this.grpSex.Controls.Add(this.rdoMale);
            this.grpSex.Enabled = false;
            this.grpSex.Location = new System.Drawing.Point(115, 102);
            this.grpSex.Name = "grpSex";
            this.grpSex.Size = new System.Drawing.Size(132, 50);
            this.grpSex.TabIndex = 9;
            this.grpSex.TabStop = false;
            this.grpSex.Text = "Sex";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(67, 19);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(59, 17);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(6, 19);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(48, 17);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(115, 31);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(132, 20);
            this.txtID.TabIndex = 10;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(115, 168);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ReadOnly = true;
            this.txtWeight.Size = new System.Drawing.Size(132, 20);
            this.txtWeight.TabIndex = 11;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(115, 214);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.ReadOnly = true;
            this.txtHeight.Size = new System.Drawing.Size(132, 20);
            this.txtHeight.TabIndex = 12;
            // 
            // grpDogInfo
            // 
            this.grpDogInfo.Controls.Add(this.btnViewBreed);
            this.grpDogInfo.Controls.Add(this.btnViewOwner);
            this.grpDogInfo.Controls.Add(this.label21);
            this.grpDogInfo.Controls.Add(this.dtpChampionshipDate);
            this.grpDogInfo.Controls.Add(this.label20);
            this.grpDogInfo.Controls.Add(this.dtpDateBanned);
            this.grpDogInfo.Controls.Add(this.txtName);
            this.grpDogInfo.Controls.Add(this.chkChampion);
            this.grpDogInfo.Controls.Add(this.chkBanned);
            this.grpDogInfo.Controls.Add(this.label17);
            this.grpDogInfo.Controls.Add(this.chkRetired);
            this.grpDogInfo.Controls.Add(this.cmbOwner);
            this.grpDogInfo.Controls.Add(this.label9);
            this.grpDogInfo.Controls.Add(this.cmbBreed);
            this.grpDogInfo.Controls.Add(this.dtpDateOfRetirement);
            this.grpDogInfo.Controls.Add(this.dtpDateOfBirth);
            this.grpDogInfo.Controls.Add(this.label1);
            this.grpDogInfo.Controls.Add(this.label2);
            this.grpDogInfo.Controls.Add(this.label4);
            this.grpDogInfo.Controls.Add(this.txtHeight);
            this.grpDogInfo.Controls.Add(this.label5);
            this.grpDogInfo.Controls.Add(this.txtWeight);
            this.grpDogInfo.Controls.Add(this.label6);
            this.grpDogInfo.Controls.Add(this.txtID);
            this.grpDogInfo.Controls.Add(this.grpSex);
            this.grpDogInfo.Controls.Add(this.label8);
            this.grpDogInfo.Location = new System.Drawing.Point(12, 52);
            this.grpDogInfo.Name = "grpDogInfo";
            this.grpDogInfo.Size = new System.Drawing.Size(275, 674);
            this.grpDogInfo.TabIndex = 16;
            this.grpDogInfo.TabStop = false;
            this.grpDogInfo.Text = "Dog Information";
            // 
            // btnViewBreed
            // 
            this.btnViewBreed.Location = new System.Drawing.Point(114, 410);
            this.btnViewBreed.Name = "btnViewBreed";
            this.btnViewBreed.Size = new System.Drawing.Size(133, 23);
            this.btnViewBreed.TabIndex = 33;
            this.btnViewBreed.Text = "View Breed Info";
            this.btnViewBreed.UseVisualStyleBackColor = true;
            this.btnViewBreed.Click += new System.EventHandler(this.btnViewBreed_Click);
            // 
            // btnViewOwner
            // 
            this.btnViewOwner.Location = new System.Drawing.Point(113, 491);
            this.btnViewOwner.Name = "btnViewOwner";
            this.btnViewOwner.Size = new System.Drawing.Size(133, 23);
            this.btnViewOwner.TabIndex = 32;
            this.btnViewOwner.Text = "View Owner Info";
            this.btnViewOwner.UseVisualStyleBackColor = true;
            this.btnViewOwner.Click += new System.EventHandler(this.btnViewOwner_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 567);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 13);
            this.label21.TabIndex = 31;
            this.label21.Text = "Championship Date:";
            // 
            // dtpChampionshipDate
            // 
            this.dtpChampionshipDate.Checked = false;
            this.dtpChampionshipDate.CustomFormat = " ";
            this.dtpChampionshipDate.Enabled = false;
            this.dtpChampionshipDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChampionshipDate.Location = new System.Drawing.Point(115, 561);
            this.dtpChampionshipDate.Name = "dtpChampionshipDate";
            this.dtpChampionshipDate.Size = new System.Drawing.Size(132, 20);
            this.dtpChampionshipDate.TabIndex = 30;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(36, 645);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 13);
            this.label20.TabIndex = 29;
            this.label20.Text = "Date Banned:";
            // 
            // dtpDateBanned
            // 
            this.dtpDateBanned.Checked = false;
            this.dtpDateBanned.CustomFormat = " ";
            this.dtpDateBanned.Enabled = false;
            this.dtpDateBanned.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateBanned.Location = new System.Drawing.Point(115, 639);
            this.dtpDateBanned.Name = "dtpDateBanned";
            this.dtpDateBanned.Size = new System.Drawing.Size(132, 20);
            this.dtpDateBanned.TabIndex = 28;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(115, 63);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(132, 20);
            this.txtName.TabIndex = 27;
            // 
            // chkChampion
            // 
            this.chkChampion.AutoSize = true;
            this.chkChampion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkChampion.Enabled = false;
            this.chkChampion.Location = new System.Drawing.Point(54, 538);
            this.chkChampion.Name = "chkChampion";
            this.chkChampion.Size = new System.Drawing.Size(76, 17);
            this.chkChampion.TabIndex = 26;
            this.chkChampion.Text = "Champion:";
            this.chkChampion.UseVisualStyleBackColor = true;
            // 
            // chkBanned
            // 
            this.chkBanned.AutoSize = true;
            this.chkBanned.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBanned.Enabled = false;
            this.chkBanned.Location = new System.Drawing.Point(64, 616);
            this.chkBanned.Name = "chkBanned";
            this.chkBanned.Size = new System.Drawing.Size(66, 17);
            this.chkBanned.TabIndex = 25;
            this.chkBanned.Text = "Banned:";
            this.chkBanned.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 338);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "Retirement Date:";
            // 
            // chkRetired
            // 
            this.chkRetired.AutoSize = true;
            this.chkRetired.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkRetired.Enabled = false;
            this.chkRetired.Location = new System.Drawing.Point(67, 309);
            this.chkRetired.Name = "chkRetired";
            this.chkRetired.Size = new System.Drawing.Size(63, 17);
            this.chkRetired.TabIndex = 21;
            this.chkRetired.Text = "Retired:";
            this.chkRetired.UseVisualStyleBackColor = true;
            // 
            // cmbOwner
            // 
            this.cmbOwner.Enabled = false;
            this.cmbOwner.FormattingEnabled = true;
            this.cmbOwner.Location = new System.Drawing.Point(114, 463);
            this.cmbOwner.Name = "cmbOwner";
            this.cmbOwner.Size = new System.Drawing.Size(132, 21);
            this.cmbOwner.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Current Owner:";
            // 
            // cmbBreed
            // 
            this.cmbBreed.Enabled = false;
            this.cmbBreed.FormattingEnabled = true;
            this.cmbBreed.Location = new System.Drawing.Point(114, 383);
            this.cmbBreed.Name = "cmbBreed";
            this.cmbBreed.Size = new System.Drawing.Size(132, 21);
            this.cmbBreed.TabIndex = 18;
            // 
            // dtpDateOfRetirement
            // 
            this.dtpDateOfRetirement.Checked = false;
            this.dtpDateOfRetirement.CustomFormat = " ";
            this.dtpDateOfRetirement.Enabled = false;
            this.dtpDateOfRetirement.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfRetirement.Location = new System.Drawing.Point(115, 332);
            this.dtpDateOfRetirement.Name = "dtpDateOfRetirement";
            this.dtpDateOfRetirement.Size = new System.Drawing.Size(132, 20);
            this.dtpDateOfRetirement.TabIndex = 17;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Enabled = false;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(115, 260);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(132, 20);
            this.dtpDateOfBirth.TabIndex = 16;
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnReset);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.txtSearchOwner);
            this.grpSearch.Controls.Add(this.txtSearchName);
            this.grpSearch.Controls.Add(this.cmbSearchBreed);
            this.grpSearch.Controls.Add(this.groupBox3);
            this.grpSearch.Controls.Add(this.groupBox2);
            this.grpSearch.Controls.Add(this.groupBox1);
            this.grpSearch.Controls.Add(this.label14);
            this.grpSearch.Controls.Add(this.label13);
            this.grpSearch.Controls.Add(this.label12);
            this.grpSearch.Controls.Add(this.label10);
            this.grpSearch.Location = new System.Drawing.Point(306, 52);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(431, 252);
            this.grpSearch.TabIndex = 17;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Filter Dogs";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(160, 214);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 35;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(26, 214);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.Text = "Filter";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchOwner
            // 
            this.txtSearchOwner.Location = new System.Drawing.Point(70, 166);
            this.txtSearchOwner.Name = "txtSearchOwner";
            this.txtSearchOwner.Size = new System.Drawing.Size(165, 20);
            this.txtSearchOwner.TabIndex = 32;
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(70, 31);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(165, 20);
            this.txtSearchName.TabIndex = 33;
            // 
            // cmbSearchBreed
            // 
            this.cmbSearchBreed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchBreed.DropDownWidth = 170;
            this.cmbSearchBreed.FormattingEnabled = true;
            this.cmbSearchBreed.Location = new System.Drawing.Point(70, 60);
            this.cmbSearchBreed.Name = "cmbSearchBreed";
            this.cmbSearchBreed.Size = new System.Drawing.Size(165, 21);
            this.cmbSearchBreed.TabIndex = 31;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudMaxHeight);
            this.groupBox3.Controls.Add(this.nudMinHeight);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(251, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(162, 100);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Height (cm)";
            // 
            // nudMaxHeight
            // 
            this.nudMaxHeight.DecimalPlaces = 1;
            this.nudMaxHeight.Location = new System.Drawing.Point(52, 55);
            this.nudMaxHeight.Name = "nudMaxHeight";
            this.nudMaxHeight.Size = new System.Drawing.Size(85, 20);
            this.nudMaxHeight.TabIndex = 31;
            // 
            // nudMinHeight
            // 
            this.nudMinHeight.DecimalPlaces = 1;
            this.nudMinHeight.Location = new System.Drawing.Point(52, 27);
            this.nudMinHeight.Name = "nudMinHeight";
            this.nudMinHeight.Size = new System.Drawing.Size(85, 20);
            this.nudMinHeight.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Min:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Max:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudMaxWeight);
            this.groupBox2.Controls.Add(this.nudMinWeight);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(251, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 100);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weight (Kgs)";
            // 
            // nudMaxWeight
            // 
            this.nudMaxWeight.DecimalPlaces = 1;
            this.nudMaxWeight.Location = new System.Drawing.Point(52, 55);
            this.nudMaxWeight.Name = "nudMaxWeight";
            this.nudMaxWeight.Size = new System.Drawing.Size(85, 20);
            this.nudMaxWeight.TabIndex = 31;
            // 
            // nudMinWeight
            // 
            this.nudMinWeight.DecimalPlaces = 1;
            this.nudMinWeight.Location = new System.Drawing.Point(52, 27);
            this.nudMinWeight.Name = "nudMinWeight";
            this.nudMinWeight.Size = new System.Drawing.Size(85, 20);
            this.nudMinWeight.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Min:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Max:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoSexEither);
            this.groupBox1.Controls.Add(this.rdoSearchFemale);
            this.groupBox1.Controls.Add(this.rdoSearchMale);
            this.groupBox1.Location = new System.Drawing.Point(70, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 72);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sex";
            // 
            // rdoSexEither
            // 
            this.rdoSexEither.AutoSize = true;
            this.rdoSexEither.Checked = true;
            this.rdoSexEither.Location = new System.Drawing.Point(51, 47);
            this.rdoSexEither.Name = "rdoSexEither";
            this.rdoSexEither.Size = new System.Drawing.Size(52, 17);
            this.rdoSexEither.TabIndex = 2;
            this.rdoSexEither.TabStop = true;
            this.rdoSexEither.Text = "Either";
            this.rdoSexEither.UseVisualStyleBackColor = true;
            // 
            // rdoSearchFemale
            // 
            this.rdoSearchFemale.AutoSize = true;
            this.rdoSearchFemale.Location = new System.Drawing.Point(90, 19);
            this.rdoSearchFemale.Name = "rdoSearchFemale";
            this.rdoSearchFemale.Size = new System.Drawing.Size(59, 17);
            this.rdoSearchFemale.TabIndex = 1;
            this.rdoSearchFemale.Text = "Female";
            this.rdoSearchFemale.UseVisualStyleBackColor = true;
            // 
            // rdoSearchMale
            // 
            this.rdoSearchMale.AutoSize = true;
            this.rdoSearchMale.Location = new System.Drawing.Point(19, 19);
            this.rdoSearchMale.Name = "rdoSearchMale";
            this.rdoSearchMale.Size = new System.Drawing.Size(48, 17);
            this.rdoSearchMale.TabIndex = 0;
            this.rdoSearchMale.Text = "Male";
            this.rdoSearchMale.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Owner:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Breed:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, -59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Name:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgCompetitions);
            this.groupBox4.Location = new System.Drawing.Point(306, 524);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(431, 202);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Competitions";
            // 
            // dgCompetitions
            // 
            this.dgCompetitions.AllowUserToAddRows = false;
            this.dgCompetitions.AllowUserToDeleteRows = false;
            this.dgCompetitions.AllowUserToResizeColumns = false;
            this.dgCompetitions.AllowUserToResizeRows = false;
            this.dgCompetitions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgCompetitions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgCompetitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompetitions.Location = new System.Drawing.Point(6, 19);
            this.dgCompetitions.MultiSelect = false;
            this.dgCompetitions.Name = "dgCompetitions";
            this.dgCompetitions.ReadOnly = true;
            this.dgCompetitions.Size = new System.Drawing.Size(419, 177);
            this.dgCompetitions.TabIndex = 20;
            this.dgCompetitions.DoubleClick += new System.EventHandler(this.dgCompetitions_DoubleClick);
            // 
            // grpDogs
            // 
            this.grpDogs.Controls.Add(this.lstDogs);
            this.grpDogs.Location = new System.Drawing.Point(308, 310);
            this.grpDogs.Name = "grpDogs";
            this.grpDogs.Size = new System.Drawing.Size(429, 202);
            this.grpDogs.TabIndex = 19;
            this.grpDogs.TabStop = false;
            this.grpDogs.Text = "Dogs";
            // 
            // lstDogs
            // 
            this.lstDogs.FormattingEnabled = true;
            this.lstDogs.Location = new System.Drawing.Point(6, 19);
            this.lstDogs.Name = "lstDogs";
            this.lstDogs.Size = new System.Drawing.Size(417, 173);
            this.lstDogs.TabIndex = 0;
            this.lstDogs.SelectedIndexChanged += new System.EventHandler(this.lstDogs_SelectedIndexChanged);
            // 
            // btnNewDog
            // 
            this.btnNewDog.Location = new System.Drawing.Point(12, 12);
            this.btnNewDog.Name = "btnNewDog";
            this.btnNewDog.Size = new System.Drawing.Size(75, 23);
            this.btnNewDog.TabIndex = 27;
            this.btnNewDog.Text = "New Dog";
            this.btnNewDog.UseVisualStyleBackColor = true;
            this.btnNewDog.Click += new System.EventHandler(this.btnNewDog_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(93, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update Dog";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteDog
            // 
            this.btnDeleteDog.Location = new System.Drawing.Point(174, 12);
            this.btnDeleteDog.Name = "btnDeleteDog";
            this.btnDeleteDog.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDog.TabIndex = 29;
            this.btnDeleteDog.Text = "Delete Dog";
            this.btnDeleteDog.UseVisualStyleBackColor = true;
            this.btnDeleteDog.Click += new System.EventHandler(this.btnDeleteDog_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmDogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(756, 746);
            this.Controls.Add(this.btnDeleteDog);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNewDog);
            this.Controls.Add(this.grpDogs);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpDogInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDogs";
            this.Text = "Dogs";
            this.Load += new System.EventHandler(this.frmDogs_Load);
            this.grpSex.ResumeLayout(false);
            this.grpSex.PerformLayout();
            this.grpDogInfo.ResumeLayout(false);
            this.grpDogInfo.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinHeight)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinWeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCompetitions)).EndInit();
            this.grpDogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpSex;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.GroupBox grpDogInfo;
        private System.Windows.Forms.DateTimePicker dtpDateOfRetirement;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.ComboBox cmbBreed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.TextBox txtSearchOwner;
        private System.Windows.Forms.ComboBox cmbSearchBreed;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudMaxHeight;
        private System.Windows.Forms.NumericUpDown nudMinHeight;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudMaxWeight;
        private System.Windows.Forms.NumericUpDown nudMinWeight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoSexEither;
        private System.Windows.Forms.RadioButton rdoSearchFemale;
        private System.Windows.Forms.RadioButton rdoSearchMale;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkChampion;
        private System.Windows.Forms.CheckBox chkBanned;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chkRetired;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox grpDogs;
        private System.Windows.Forms.ListBox lstDogs;
        private System.Windows.Forms.Button btnNewDog;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dtpDateBanned;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtpChampionshipDate;
        private System.Windows.Forms.ComboBox cmbOwner;
        private System.Windows.Forms.DataGridView dgCompetitions;
        private System.Windows.Forms.Button btnViewOwner;
        private System.Windows.Forms.Button btnViewBreed;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteDog;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

