﻿using DogShowTrackerCL;
using System;
using System.Windows.Forms;

/*
    Alex Richard
    Dog Show Tracker
    2020-06-04
*/

namespace DogShowTracker
{
    public partial class frmAddColour : DogShowForm
    {
        public frmAddColour()
        {
            InitializeComponent();
        }

        private bool colourAdded = false;

        /// <summary>
        /// Insert the colour into the database
        /// </summary>
        private void InsertNewColour()
        {
            string colourName = DatabaseHelper.SanitizeUserInput(txtColour.Text);
            //TODO: Prevent Adding Duplicates
            string sql = $@"
                        INSERT INTO Colours
                            (Colour)
                            VALUES
                            ('{colourName}');";
            DatabaseHelper.SendData(sql);
        }

        /// <summary>
        /// Validate all user provided data
        /// </summary>
        /// <returns></returns>
        private bool ValidateFields()
        {
            errorProvider.Clear();
            bool isValid = true;
            if (txtColour.Text == "")
            {
                errorProvider.SetError(txtColour, "Colour Name cannot be blank");
                isValid = false;
            }
            return isValid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(ValidateFields())
                {
                    InsertNewColour();
                    colourAdded = true;
                    Close();
                }
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }

        }

        private void frmAddColour_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (colourAdded) MessageBox.Show("Colour Added");
        }
    }
}
