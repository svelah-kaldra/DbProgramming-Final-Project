﻿using DogShowTrackerCL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    Alex Richard
    Dog Show Tracker
    2020-06-05
*/

namespace DogShowTracker
{
    public partial class frmUpdateDog : DogShowForm
    {
        public frmUpdateDog()
        {
            InitializeComponent();
        }

        string name, dob, dateRetired, dateBanned, dateChampionship;
        int id, sex, retired, banned, champion, breedId;
        decimal weight, height;

        public override void Reload()
        {
            UIMethods.FillListControl(cmbDogToUpdate, "Name", "DogID", LoadFormData.DogNames());
            UIMethods.FillListControl(cmbBreed, "Breed", "BreedID", LoadFormData.BreedNames());
        }

        /// <summary>
        /// Get the information on the selected dog
        /// </summary>
        private void GetDogDetails()
        {
            int id = Convert.ToInt32(cmbDogToUpdate.SelectedValue);
            string sql = $"SELECT * FROM Dogs WHERE DogID = {id};";
            DataRow row = DatabaseHelper.GetDataRow(sql);

            string name = row["Name"].ToString();
            bool isMale = Convert.ToBoolean(row["Sex"]);
            decimal weight = Convert.ToDecimal(row["Weight"]);
            decimal height = Convert.ToDecimal(row["Height"]);
            DateTime dob = Convert.ToDateTime(row["DOB"]);


            UIMethods.PickDateTimePicker(dtpDateOfRetirement, row["DateOfRetirement"]);
            bool retired = Convert.ToBoolean(row["Retired"]);

            bool champion = Convert.ToBoolean(row["Champion"]);
            UIMethods.PickDateTimePicker(dtpChampionshipDate, row["DateOfChampionship"]);

            bool banned = Convert.ToBoolean(row["PermanentlyDisqualified"]);
            UIMethods.PickDateTimePicker(dtpDateBanned, row["DateOfDisqualification"]);

            int breedID = Convert.ToInt32(row["Breed"]);

            txtName.Text = name.ToString();
            rdoMale.Checked = isMale;
            rdoFemale.Checked = !isMale;
            nudWeight.Value = weight;
            nudHeight.Value = height;
            dtpDateOfBirth.Value = dob;
            chkRetired.Checked = retired;
            chkChampion.Checked = champion;
            chkBanned.Checked = banned;
            cmbBreed.SelectedValue = breedID;
        }

        private void GetValues()
        {
            id = Convert.ToInt32(cmbDogToUpdate.SelectedValue);

            name = DatabaseHelper.SanitizeUserInput(txtName.Text);
            sex = Convert.ToInt32(rdoMale.Checked);
            weight = Math.Round(nudWeight.Value, 1);
            height = Math.Round(nudHeight.Value, 1);
            dob = dtpDateOfBirth.Value.ToString("yyyy-MM-dd");

            retired = Convert.ToInt32(chkRetired.Checked);
            dateRetired = chkRetired.Checked ? $"'{dtpDateOfRetirement.Value.ToString("yyyy-MM-dd")}'" : "NULL";

            banned = Convert.ToInt32(chkBanned.Checked);
            dateBanned = chkBanned.Checked ? $"'{dtpDateBanned.Value.ToString("yyyy-MM-dd")}'" : "NULL";

            champion = Convert.ToInt32(chkChampion.Checked);
            dateChampionship = chkChampion.Checked ? $"'{dtpChampionshipDate.Value.ToString("yyyy-MM-dd")}'" : "NULL";

            breedId = Convert.ToInt32(cmbBreed.SelectedValue);
        }

        private void UpdateDog()
        {
            GetValues();
            if (ValidateFields())
            {
                string sql = $@"
                                UPDATE Dogs WHERE DogID = {id} SET 
                                    [Name] = '{name}', Sex = {sex}, [Weight] = {weight}, Height = {height}, 
                                    DOB = '{dob}', DateOfRetirement = {dateRetired}, Retired = {retired}, DateOfChampionship = {dateChampionship}, Champion = {champion},
                                    DateOfDisqualification = {dateBanned}, PermanentlyDisqualified = {banned}, Breed = {breedId};
                                ";
                int rowsAffected = DatabaseHelper.SendData(sql);
                UIMethods.DisplayStatusMessage(((MDIParent)MdiParent).GetStatusLabel(), $"{rowsAffected} row(s) affected");
            }

        }

        /// <summary>
        /// Validate user provided info
        /// </summary>
        /// <returns></returns>
        private bool ValidateFields()
        {
            bool isValid = true;
            errorProvider.Clear();
            if (string.IsNullOrEmpty(name) || !name.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                isValid = false;
                errorProvider.SetError(txtName, "Name must not be empty and can only contain letters and spaces");
            }
            if (weight < 1)
            {
                isValid = false;
                errorProvider.SetError(nudWeight, "Weight must be at least 1kg");
            }
            if (height < 5)
            {
                isValid = false;
                errorProvider.SetError(nudHeight, "Height must be at least 5cm");
            }
            if (dtpDateOfBirth.Value.Date > DateTime.Now)
            {
                isValid = false;
                errorProvider.SetError(dtpDateOfBirth, "Date of birth can't be in the future");
            }
            if (chkRetired.Checked && dtpDateOfRetirement.Value.Date < dtpDateOfBirth.Value)
            {
                isValid = false;
                errorProvider.SetError(dtpDateOfRetirement, "Date of Retirement cannot be before Date of Birth");
            }
            if (chkBanned.Checked && dtpDateBanned.Value.Date < dtpDateOfBirth.Value)
            {
                isValid = false;
                errorProvider.SetError(dtpDateBanned, "Date Banned cannot be before Date of Birth");
            }
            if (chkBanned.Checked && chkRetired.Checked)
            {
                isValid = false;
                errorProvider.SetError(chkBanned, "Cannot ban a retired dog");
                errorProvider.SetError(chkRetired, "A banned dog cannot retired");
            }
            if (chkChampion.Checked)
            {
                string errorMsg = "";
                if (dtpChampionshipDate.Value.Date < dtpDateOfBirth.Value.Date)
                    errorMsg += "Date of championship cannot be before date of birth\r\n";
                if (dtpChampionshipDate.Value.Date > dtpDateBanned.Value.Date && chkBanned.Checked)
                    errorMsg += "Date of championship cannot be after date banned\r\n";
                if (dtpChampionshipDate.Value.Date > dtpDateOfRetirement.Value.Date && chkRetired.Checked)
                    errorMsg += "Date of championship cannot be after date retired";

                if (errorMsg.Length != 0)
                {
                    isValid = false;
                    errorProvider.SetError(dtpChampionshipDate, errorMsg);
                }

            }
            if (breedId == 0)
            {
                isValid = false;
                errorProvider.SetError(cmbBreed, "Dog breed must be selected");
            }
            if (DatabaseHelper.ValueExists("Name", $"'{name}'", "Dogs"))
            {
                if (isValid && DialogResult.Yes == MessageBox.Show("A dog with that name already exists, are you sure you wish to add this dog?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// Set the enabled property of the datetimepickers to the equivelent checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnableDateTimePickers(object sender, EventArgs e)
        {
            try
            {
                dtpChampionshipDate.Enabled = chkChampion.Checked;
                dtpDateBanned.Enabled = chkBanned.Checked;
                dtpDateOfRetirement.Enabled = chkRetired.Checked;
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateDog();
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

        private void frmUpdateDog_Load(object sender, EventArgs e)
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

        private void cmbDogToUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetDogDetails();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}
