﻿using DogShowTrackerCL;
using System;
using System.Data;
using System.Windows.Forms;

/*
    Alex Richard
    Dog Show Tracker
    2020-06-07
*/

namespace DogShowTracker
{
    public partial class frmChangeDogShowDogs : DogShowForm
    {
        public frmChangeDogShowDogs()
        {
            InitializeComponent();
        }

        int dogShowID, currentDogID, assignDogID, disqualified;
        string rank;

        #region Helper Methods
        /// <summary>
        /// Load all of the form data
        /// </summary>
        public override void Reload()
        {
            UIMethods.FillListControl(cmbDogs, "Name", "DogID", LoadFormData.DogNames(), true);
            UIMethods.FillListControl(cmbDogShow, "Name", "DogShowID", LoadFormData.DogShowNames());
        }

        /// <summary>
        /// Get all user provided data
        /// </summary>
        private void GetUserData()
        {
            assignDogID = cmbDogs.SelectedValue != DBNull.Value ? Convert.ToInt32(cmbDogs.SelectedValue) : 0;
            currentDogID = Convert.ToInt32(lstDogs.SelectedValue);
            dogShowID = Convert.ToInt32(cmbDogShow.SelectedValue);
            rank = chkDisqualified.Checked ? "NULL" : Convert.ToInt32(nudRank.Value).ToString();
            disqualified = chkDisqualified.Checked ? 1 : 0;
        }

        /// <summary>
        /// Get the total number of dogs in a dog show
        /// </summary>
        /// <returns></returns>
        private int GetDogShowDogsCount()
        {
            int id = Convert.ToInt32(cmbDogShow.SelectedValue);
            string sql = $@"SELECT COUNT(DogID) FROM DogShows
	                            LEFT JOIN DogShowDetails
		                            ON DogShows.DogShowID = DogShowDetails.DogShowID
	                            WHERE DogShows.DogShowID = {id};";
            return Convert.ToInt32(DatabaseHelper.ExecuteScaler(sql));
        }

        /// <summary>
        /// Get the max number of dogs in a dog show
        /// </summary>
        /// <returns></returns>
        private int GetMaxDogShowDogs()
        {
            int id = Convert.ToInt32(cmbDogShow.SelectedValue);
            string sql = $@"SELECT NumDogs FROM DogShows WHERE DogShows.DogShowID = {id};";
            return Convert.ToInt32(DatabaseHelper.ExecuteScaler(sql));
        }

        /// <summary>
        /// Show the count and max number of dogs in a dog show
        /// </summary>
        private void LoadDogShowDogsCount()
        {
            txtNumDogs.Text = GetDogShowDogsCount().ToString() + "/" + GetMaxDogShowDogs().ToString();
        }

        /// <summary>
        /// Fill the dogs list with the dogs that competed in the selected dog show
        /// </summary>
        private void LoadDogShowDetails()
        {
            GetUserData();
            cmbDogs.SelectedIndex = 0;
            UIMethods.FillListControl(lstDogs, "Dog", "DogID", LoadFormData.DogShowDogs(dogShowID));
            LoadDogShowDogsCount();
        }

        /// <summary>
        /// Insert the dog show
        /// </summary>
        private void InsertDogShowDog()
        {
            string sql = $@"INSERT INTO DogShowDetails
	                            (DogID, DogShowID, [Rank], Disqualified)
	                            VALUES
	                            ({assignDogID}, {dogShowID}, {rank}, {disqualified});";
            int rowsAffected = DatabaseHelper.SendData(sql);
            UIMethods.DisplayStatusMessage(((frmMDIParent)MdiParent).GetStatusLabel(), $"{rowsAffected} row(s) affected");
            ((frmMDIParent)MdiParent).ReloadAllChildForms();
        }

        /// <summary>
        /// Remove the dog show from the database
        /// </summary>
        private void RemoveDogShowDog()
        {
            string sql = $@"DELETE DogShowDetails
            	            WHERE DogID = {currentDogID} AND DogShowID = {dogShowID};";
            int rowsAffected = DatabaseHelper.SendData(sql);
            UIMethods.DisplayStatusMessage(((frmMDIParent)MdiParent).GetStatusLabel(), $"{rowsAffected} row(s) affected");
            ((frmMDIParent)MdiParent).ReloadAllChildForms();
        }

        /// <summary>
        /// Validate teh insertion data
        /// </summary>
        /// <returns></returns>
        private bool ValidateInsert()
        {
            bool isValid = true;
            GetUserData();

            string errorMsg = "";

            errorProvider.Clear();
            if (DatabaseHelper.ValueExists("CAST(DogID AS VARCHAR) + ',' + CAST(DogShowID AS VARCHAR)", $"'{assignDogID},{dogShowID}'", "DogShowDetails"))
            {
                isValid = false;
                errorProvider.SetError(cmbDogs, "Dog is already in dog show");
            }
            if (GetDogShowDogsCount() == GetMaxDogShowDogs())
            {
                isValid = false;
                errorProvider.SetError(txtNumDogs, "Dog show already has max number of dogs.");
            }
            if (disqualified == 0 && Convert.ToInt32(rank) <= 0)
            {
                isValid = false;
                errorProvider.SetError(nudRank, "Rank must be higher than 0 if not disqualified");
            }
            if (disqualified == 0 && Convert.ToInt32(rank) > GetMaxDogShowDogs())
            {
                isValid = false;
                errorProvider.SetError(nudRank, "Rank cannot be higher than the max number of dogs");
            }
            if (disqualified == 0 && DatabaseHelper.ValueExists("CAST(Rank AS VARCHAR) + CAST(DogShowID AS VARCHAR)", $"'{rank.ToString() + dogShowID.ToString()}'", "DogShowDetails"))
            {
                isValid = false;
                errorProvider.SetError(nudRank, "A dog already has that rank");
            }

            if (errorMsg.Length > 0) MessageBox.Show(errorMsg.Trim(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return isValid;
        }

        /// <summary>
        /// Validate the deletion data
        /// </summary>
        /// <returns></returns>
        private bool ValidateDeletion()
        {
            GetUserData();
            errorProvider.Clear();

            string sqlDogName = $"SELECT [Name] FROM Dogs WHERE DogID = {currentDogID}";
            string dogName = DatabaseHelper.ExecuteScaler(sqlDogName).ToString();

            string dogShowName = cmbDogShow.Text.Split('\u2014')[1];
            DateTime dogShowDate = DateTime.Parse(cmbDogShow.Text.Split('\u2014')[0]);


            return lstDogs.SelectedIndex != -1
                    && UIMethods.ConfirmationPrompt($"Are you sure you want to remove {dogName} from the " +
                                                    $"{dogShowDate.ToString("yyyy MMMM d")}{dogShowName} dog show?");
        }

        /// <summary>
        /// Update the dog show
        /// </summary>
        private void UpdateDogShowDog()
        {
            string sql = $@"
                            UPDATE DogShowDetails
	                            SET Rank = {rank},
	                            Disqualified = {disqualified}
	                            WHERE DogID = {assignDogID} AND DogShowID = {dogShowID};";
            DatabaseHelper.SendData(sql);
            ((frmMDIParent)MdiParent).ReloadAllChildForms();
        }

        /// <summary>
        /// Verify the update info
        /// </summary>
        /// <returns></returns>
        private bool VerifyUpdate()
        {
            GetUserData();

            bool isValid = true;
            if (!DatabaseHelper.ValueExists("CAST(DogID AS VARCHAR) + ',' + CAST(DogShowID AS VARCHAR)", $"'{assignDogID},{dogShowID}'", "DogShowDetails"))
            {
                isValid = false;
                MessageBox.Show("Dog cannot be modified as dog is not in the selected dog show", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (disqualified == 0 && Convert.ToInt32(rank) <= 0)
            {
                isValid = false;
                errorProvider.SetError(nudRank, "Rank must be higher than 0 if not disqualified");
            }
            if (disqualified == 0 && Convert.ToInt32(rank) > GetMaxDogShowDogs())
            {
                isValid = false;
                errorProvider.SetError(nudRank, "Rank cannot be higher than the max number of dogs");
            }
            if (
                DatabaseHelper.ValueExists("CAST(DogShowID AS VARCHAR) + ',' + CAST(Rank AS VARCHAR)", $"'{dogShowID},{rank}'", "DogShowDetails")
                && DatabaseHelper.ValueChanged("Rank", rank, "DogShowDetails", "CAST(DogID AS VARCHAR) + ',' + CAST(DogShowID AS VARCHAR)", $"'{assignDogID},{dogShowID}'")
                )
            {
                isValid = false;
                errorProvider.SetError(nudRank, "A dog already has that rank");
            }

            return isValid;
        }

        /// <summary>
        /// Load the info on the selected dog show
        /// </summary>
        private void LoadDogShowDogDetails()
        {
            GetUserData();
            string sql = $"SELECT [Rank], Disqualified FROM DogShowDetails WHERE DogID = {currentDogID}  AND DogShowID = {dogShowID};";
            DataRow row = DatabaseHelper.GetDataRow(sql);

            cmbDogs.SelectedValue = currentDogID;
            nudRank.Value = row["Rank"] != DBNull.Value ? Convert.ToDecimal(row["Rank"]) : 0;
            chkDisqualified.Checked = Convert.ToBoolean(row["Disqualified"]);
        }
        #endregion

        private void btnAddDog_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInsert())
                {
                    InsertDogShowDog();
                    LoadDogShowDetails();
                }
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnRemoveDogs_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateDeletion())
                {
                    RemoveDogShowDog();
                    LoadDogShowDetails();
                }
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnModifyDog_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifyUpdate())
                {
                    UpdateDogShowDog();
                    LoadDogShowDetails();
                }
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void lstDogs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadDogShowDogDetails();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void frmChangeDogShowDogs_Load(object sender, EventArgs e)
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

        private void cmbDogShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadDogShowDetails();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void chkDisqualified_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                nudRank.Enabled = !chkDisqualified.Checked;
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}
