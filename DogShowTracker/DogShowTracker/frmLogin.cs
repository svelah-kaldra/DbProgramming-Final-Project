﻿using DogShowTrackerCL;
using System;
using System.Windows.Forms;

/*
    Alex Richard
    Dog Show Tracker
    2020-06-07
*/

namespace DogShowTracker
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load the login info on start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogin_Load(object sender, EventArgs e)
        {
            Text = Application.ProductName + " - Login";
            txtUsr.Text = Environment.UserName;
        }

        /// <summary>
        /// Check if user login is valid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txtUsr.Text;
                string pass = txtPass.Text;
                if (pass == DatabaseHelper.ExecuteScaler($"SELECT Pass FROM UserLogin WHERE Username = '{user}'").ToString())
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}
