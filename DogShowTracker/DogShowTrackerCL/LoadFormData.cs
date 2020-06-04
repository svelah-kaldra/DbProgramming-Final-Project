﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogShowTrackerCL
{
    public class LoadFormData
    {
        /// <summary>
        /// Load the BreedIDs and Breeds
        /// </summary>
        /// <returns>BreedID, Breed</returns>
        public static DataTable BreedNames()
        {
            string sql = "SELECT BreedID, Breed FROM Breeds ORDER BY Breed;";
            return DatabaseHelper.GetDataTable(sql);
        }

        /// <summary>
        /// Load the ClassIDs and Classes
        /// </summary>
        /// <returns>ClassID, Class</returns>
        public static DataTable ClassNames()
        {
            string sql = "SELECT ClassID, Class FROM Classes ORDER BY Class;";
            return DatabaseHelper.GetDataTable(sql);
        }

        /// <summary>
        /// Load the ColourIDs and Colours
        /// </summary>
        /// <returns>ColourID, Colour</returns>
        public static DataTable ColourNames()
        {
            string sql = "SELECT ColourID, Colour FROM Colours ORDER BY Colour;";
            return DatabaseHelper.GetDataTable(sql);
        }

        /// <summary>
        /// Load the DogIDs and Dogs
        /// </summary>
        /// <returns>DogID, Dog</returns>
        public static DataTable DogNames()
        {
            string sql = "SELECT [DogID], [Name] FROM Dogs ORDER BY [Name];";
            return DatabaseHelper.GetDataTable(sql);
        }

        /// <summary>
        /// Load the OwnerIDs and Owner Names cobined into one field
        /// </summary>
        /// <returns>OwnerID, OwnerName</returns>
        public static DataTable OwnerNamesCombined()
        {
            string sql = "SELECT [OwnerID], FirstName + ' ' + COALESCE(MiddleName + ' ', '') + LastName AS OwnerName FROM Owners;";
            return DatabaseHelper.GetDataTable(sql);
        }

        /// <summary>
        /// Load the DogShowIDs and Dog Show Names with the Start date as a prefix 
        /// </summary>
        /// <returns>DogShowID, Name</returns>
        public static DataTable DogShowNames()
        {
            string sql = "SELECT DogShowID, CAST(StartDate AS VARCHAR) + ' '+ CHAR(151) +' ' + [Name] AS [Name] FROM DogShows ORDER BY [Name];";
            return DatabaseHelper.GetDataTable(sql);
        }
    }
}
