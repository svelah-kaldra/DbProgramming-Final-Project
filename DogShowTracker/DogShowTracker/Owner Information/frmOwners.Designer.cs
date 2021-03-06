﻿namespace DogShowTracker
{
    partial class frmOwners
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtDateOfRetirement = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.chkRetired = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgOwnership = new System.Windows.Forms.DataGridView();
            this.btnNewOwner = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSelectOwner = new System.Windows.Forms.ComboBox();
            this.btnChangeOwnership = new System.Windows.Forms.Button();
            this.btnDeleteOwner = new System.Windows.Forms.Button();
            this.btnChangeOwner = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOwnership)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtDateOfRetirement);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chkRetired);
            this.groupBox1.Location = new System.Drawing.Point(7, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 80);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Retirement Info";
            // 
            // dtDateOfRetirement
            // 
            this.dtDateOfRetirement.CustomFormat = " ";
            this.dtDateOfRetirement.Enabled = false;
            this.dtDateOfRetirement.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateOfRetirement.Location = new System.Drawing.Point(110, 19);
            this.dtDateOfRetirement.Name = "dtDateOfRetirement";
            this.dtDateOfRetirement.Size = new System.Drawing.Size(131, 20);
            this.dtDateOfRetirement.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date of Retirement:";
            // 
            // chkRetired
            // 
            this.chkRetired.AutoSize = true;
            this.chkRetired.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkRetired.Enabled = false;
            this.chkRetired.Location = new System.Drawing.Point(58, 45);
            this.chkRetired.Name = "chkRetired";
            this.chkRetired.Size = new System.Drawing.Size(63, 17);
            this.chkRetired.TabIndex = 0;
            this.chkRetired.Text = "Retired:";
            this.chkRetired.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Date of Birth:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Enabled = false;
            this.dtpDOB.Location = new System.Drawing.Point(117, 97);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(131, 20);
            this.dtpDOB.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Middle Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "First Name:";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(117, 71);
            this.txtLName.Name = "txtLName";
            this.txtLName.ReadOnly = true;
            this.txtLName.Size = new System.Drawing.Size(131, 20);
            this.txtLName.TabIndex = 13;
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(117, 45);
            this.txtMName.Name = "txtMName";
            this.txtMName.ReadOnly = true;
            this.txtMName.Size = new System.Drawing.Size(131, 20);
            this.txtMName.TabIndex = 12;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(117, 19);
            this.txtFName.Name = "txtFName";
            this.txtFName.ReadOnly = true;
            this.txtFName.Size = new System.Drawing.Size(131, 20);
            this.txtFName.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Controls.Add(this.btnPrev);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.txtFName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMName);
            this.groupBox2.Controls.Add(this.dtpDOB);
            this.groupBox2.Controls.Add(this.txtLName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 250);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Owner Info";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(187, 209);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 35);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(7, 209);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 35);
            this.btnPrev.TabIndex = 20;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgOwnership);
            this.groupBox3.Location = new System.Drawing.Point(314, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(419, 250);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ownership";
            // 
            // dgOwnership
            // 
            this.dgOwnership.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgOwnership.AllowUserToAddRows = false;
            this.dgOwnership.AllowUserToDeleteRows = false;
            this.dgOwnership.AllowUserToResizeColumns = false;
            this.dgOwnership.AllowUserToResizeRows = false;
            this.dgOwnership.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgOwnership.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgOwnership.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOwnership.Location = new System.Drawing.Point(6, 19);
            this.dgOwnership.Name = "dgOwnership";
            this.dgOwnership.ReadOnly = true;
            this.dgOwnership.Size = new System.Drawing.Size(407, 225);
            this.dgOwnership.TabIndex = 0;
            this.dgOwnership.DoubleClick += new System.EventHandler(this.dgOwnership_DoubleClick);
            // 
            // btnNewOwner
            // 
            this.btnNewOwner.Location = new System.Drawing.Point(12, 12);
            this.btnNewOwner.Name = "btnNewOwner";
            this.btnNewOwner.Size = new System.Drawing.Size(75, 23);
            this.btnNewOwner.TabIndex = 29;
            this.btnNewOwner.Text = "New Owner";
            this.btnNewOwner.UseVisualStyleBackColor = true;
            this.btnNewOwner.Click += new System.EventHandler(this.btnNewOwner_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Select Owner:";
            // 
            // cmbSelectOwner
            // 
            this.cmbSelectOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectOwner.FormattingEnabled = true;
            this.cmbSelectOwner.Location = new System.Drawing.Point(391, 14);
            this.cmbSelectOwner.Name = "cmbSelectOwner";
            this.cmbSelectOwner.Size = new System.Drawing.Size(230, 21);
            this.cmbSelectOwner.TabIndex = 34;
            this.cmbSelectOwner.SelectedIndexChanged += new System.EventHandler(this.cmbSelectOwner_SelectedIndexChanged);
            // 
            // btnChangeOwnership
            // 
            this.btnChangeOwnership.Location = new System.Drawing.Point(627, 12);
            this.btnChangeOwnership.Name = "btnChangeOwnership";
            this.btnChangeOwnership.Size = new System.Drawing.Size(106, 24);
            this.btnChangeOwnership.TabIndex = 35;
            this.btnChangeOwnership.Text = "Change Ownership";
            this.btnChangeOwnership.UseVisualStyleBackColor = true;
            this.btnChangeOwnership.Click += new System.EventHandler(this.btnChangeOwnership_Click);
            // 
            // btnDeleteOwner
            // 
            this.btnDeleteOwner.Location = new System.Drawing.Point(205, 12);
            this.btnDeleteOwner.Name = "btnDeleteOwner";
            this.btnDeleteOwner.Size = new System.Drawing.Size(88, 23);
            this.btnDeleteOwner.TabIndex = 36;
            this.btnDeleteOwner.Text = "Delete Owner";
            this.btnDeleteOwner.UseVisualStyleBackColor = true;
            this.btnDeleteOwner.Click += new System.EventHandler(this.btnDeleteOwner_Click);
            // 
            // btnChangeOwner
            // 
            this.btnChangeOwner.Location = new System.Drawing.Point(109, 12);
            this.btnChangeOwner.Name = "btnChangeOwner";
            this.btnChangeOwner.Size = new System.Drawing.Size(75, 23);
            this.btnChangeOwner.TabIndex = 37;
            this.btnChangeOwner.Text = "Change Owner";
            this.btnChangeOwner.UseVisualStyleBackColor = true;
            this.btnChangeOwner.Click += new System.EventHandler(this.btnChangeOwner_Click);
            // 
            // frmOwners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(745, 304);
            this.Controls.Add(this.btnChangeOwner);
            this.Controls.Add(this.btnDeleteOwner);
            this.Controls.Add(this.btnChangeOwnership);
            this.Controls.Add(this.cmbSelectOwner);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnNewOwner);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmOwners";
            this.Text = "Owners";
            this.Load += new System.EventHandler(this.frmOwners_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOwnership)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtDateOfRetirement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkRetired;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnNewOwner;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.DataGridView dgOwnership;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSelectOwner;
        private System.Windows.Forms.Button btnChangeOwnership;
        private System.Windows.Forms.Button btnDeleteOwner;
        private System.Windows.Forms.Button btnChangeOwner;
    }
}