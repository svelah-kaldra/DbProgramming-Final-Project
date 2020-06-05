﻿using DogShowTrackerCL;
using System;
using System.Data;
using System.Windows.Forms;

/*
    Alex Richard
    Dog Show Tracker
    2020-06-04
*/

namespace DogShowTracker
{
    public partial class frmDogShows : DogShowForm
    {
        public frmDogShows()
        {
            InitializeComponent();
        }

        #region Helper Methods
        /// <summary>
        /// Load all form info
        /// </summary>
        public override void Reload()
        {
            UIMethods.FillListControl(cmbDogShows, "Name", "DogShowID", LoadFormData.DogShowNames());
        }

        /// <summary>
        /// Fill the number of dogs textbox with the number of dogs competed in the current dog show
        /// </summary>
        private void GetNumDogs()
        {
            int id = Convert.ToInt32(cmbDogShows.SelectedValue);
            string sql = $"SELECT NumDogs FROM DogShows WHERE DogShowID = {id};";
            txtNumDogs.Text = DatabaseHelper.ExecuteScaler(sql).ToString();
        }

        /// <summary>
        /// Fill the dogs list with the dogs that competed in the selected dog show
        /// </summary>
        private void GetDogs()
        {
            int id = Convert.ToInt32(cmbDogShows.SelectedValue);
            UIMethods.FillListControl(lstDogs, "Dog", "DogID", LoadFormData.DogShowDogs(id));
        }

        /// <summary>
        /// Get the start and end dates to the dog show
        /// </summary>
        private void GetDates()
        {
            int id = Convert.ToInt32(cmbDogShows.SelectedValue);
            string sql = $"SELECT StartDate, EndDate FROM DogShows WHERE DogShowID = {id};";
            DataRow row = DatabaseHelper.GetDataRow(sql);
            DateTime startDate = Convert.ToDateTime(row["StartDate"]);
            DateTime endDate = Convert.ToDateTime(row["EndDate"]);
            dtpStartDate.Value = startDate;
            dtpEndDate.Value = endDate;
        }

        /// <summary>
        /// Open the info on the dog that  is currently selected in the dogs list
        /// </summary>
        private void OpenDogInfo()
        {
            try
            {
                Form form = UIMethods.OpenForm(MdiParent, new frmDogs());
                foreach (Control ctrl in form.Controls)
                {
                    if (ctrl.Name == "grpDogs")
                    {
                        ((ListBox)ctrl.Controls[0]).SelectedValue = lstDogs.SelectedValue;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
        #endregion

        private void frmDogShows_Load(object sender, EventArgs e)
        {
            try
            {
                Reload();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }

        }

        private void cmbDogShows_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetDogs();
                GetNumDogs();
                GetDates();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void lstDogs_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenDogInfo();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnNewShow_Click(object sender, EventArgs e)
        {
            try
            {
                UIMethods.OpenForm(MdiParent, new frmAddDogShow());
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnAssignDogs_Click(object sender, EventArgs e)
        {
            try
            {
                UIMethods.OpenForm(MdiParent, new frmChangeDogShowDogs());
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}