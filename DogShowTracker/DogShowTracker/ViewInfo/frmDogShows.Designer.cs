﻿namespace DogShowTracker
{
    partial class frmDogShows
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
            this.cmbDogShows = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.grpDogShows = new System.Windows.Forms.GroupBox();
            this.lstDogs = new System.Windows.Forms.ListBox();
            this.btnNewShow = new System.Windows.Forms.Button();
            this.btnAssignDogs = new System.Windows.Forms.Button();
            this.txtNumDogs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpDogShows.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDogShows
            // 
            this.cmbDogShows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDogShows.FormattingEnabled = true;
            this.cmbDogShows.Location = new System.Drawing.Point(6, 19);
            this.cmbDogShows.Name = "cmbDogShows";
            this.cmbDogShows.Size = new System.Drawing.Size(312, 21);
            this.cmbDogShows.TabIndex = 0;
            this.cmbDogShows.SelectedIndexChanged += new System.EventHandler(this.cmbDogShows_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtStartDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start Date";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Enabled = false;
            this.dtStartDate.Location = new System.Drawing.Point(6, 19);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(145, 20);
            this.dtStartDate.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtEndDate);
            this.groupBox2.Location = new System.Drawing.Point(179, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 55);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "End Date";
            // 
            // dtEndDate
            // 
            this.dtEndDate.Enabled = false;
            this.dtEndDate.Location = new System.Drawing.Point(6, 19);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(145, 20);
            this.dtEndDate.TabIndex = 1;
            // 
            // grpDogShows
            // 
            this.grpDogShows.Controls.Add(this.cmbDogShows);
            this.grpDogShows.Location = new System.Drawing.Point(12, 41);
            this.grpDogShows.Name = "grpDogShows";
            this.grpDogShows.Size = new System.Drawing.Size(332, 53);
            this.grpDogShows.TabIndex = 5;
            this.grpDogShows.TabStop = false;
            this.grpDogShows.Text = "Dog Shows";
            // 
            // lstDogs
            // 
            this.lstDogs.FormattingEnabled = true;
            this.lstDogs.Location = new System.Drawing.Point(12, 161);
            this.lstDogs.Name = "lstDogs";
            this.lstDogs.Size = new System.Drawing.Size(332, 212);
            this.lstDogs.TabIndex = 6;
            this.lstDogs.DoubleClick += new System.EventHandler(this.lstDogs_DoubleClick);
            // 
            // btnNewShow
            // 
            this.btnNewShow.Location = new System.Drawing.Point(12, 12);
            this.btnNewShow.Name = "btnNewShow";
            this.btnNewShow.Size = new System.Drawing.Size(96, 23);
            this.btnNewShow.TabIndex = 31;
            this.btnNewShow.Text = "New Dog Show";
            this.btnNewShow.UseVisualStyleBackColor = true;
            this.btnNewShow.Click += new System.EventHandler(this.btnNewShow_Click);
            // 
            // btnAssignDogs
            // 
            this.btnAssignDogs.Location = new System.Drawing.Point(114, 12);
            this.btnAssignDogs.Name = "btnAssignDogs";
            this.btnAssignDogs.Size = new System.Drawing.Size(81, 23);
            this.btnAssignDogs.TabIndex = 32;
            this.btnAssignDogs.Text = "Update Dogs";
            this.btnAssignDogs.UseVisualStyleBackColor = true;
            this.btnAssignDogs.Click += new System.EventHandler(this.btnAssignDogs_Click);
            // 
            // txtNumDogs
            // 
            this.txtNumDogs.Location = new System.Drawing.Point(312, 14);
            this.txtNumDogs.Name = "txtNumDogs";
            this.txtNumDogs.ReadOnly = true;
            this.txtNumDogs.Size = new System.Drawing.Size(32, 20);
            this.txtNumDogs.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Number of Dogs:";
            // 
            // frmDogShows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(359, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumDogs);
            this.Controls.Add(this.btnAssignDogs);
            this.Controls.Add(this.btnNewShow);
            this.Controls.Add(this.lstDogs);
            this.Controls.Add(this.grpDogShows);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDogShows";
            this.Text = "Dog Shows";
            this.Load += new System.EventHandler(this.frmDogShows_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.grpDogShows.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDogShows;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.GroupBox grpDogShows;
        private System.Windows.Forms.ListBox lstDogs;
        private System.Windows.Forms.Button btnNewShow;
        private System.Windows.Forms.Button btnAssignDogs;
        private System.Windows.Forms.TextBox txtNumDogs;
        private System.Windows.Forms.Label label1;
    }
}