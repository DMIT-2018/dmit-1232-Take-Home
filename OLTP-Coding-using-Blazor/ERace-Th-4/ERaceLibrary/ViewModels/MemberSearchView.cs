// ***********************************************************************
// Assembly         : ERaceLibrary
// Author           : jamesthompson
// Created          : 03-16-2024
//
// Last Modified By : jamesthompson
// Last Modified On : 03-16-2024
// ***********************************************************************
// <copyright file="MemberSearchView.cs" company="ERaceLibrary">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using ERaceLibrary.Entities;

namespace ERaceLibrary.ViewModels
{
    /// <summary>
    /// Class MemberSearchView.
    /// </summary>
    public class MemberSearchView
    {
        /// <summary>
        /// Gets or sets the member identifier.
        /// </summary>
        /// <value>The member identifier.</value>
        public int MemberID { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        public string? LastName { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        public string? FirstName { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>The phone.</value>
        public string? Phone { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>The city.</value>
        public string? City { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        /// <value>The email address.</value>
        public string? EmailAddress { get; set; }
        /// <summary>
        /// Gets or sets the certification.
        /// </summary>
        /// <value>The certification.</value>
        public string? Certification { get; set; }
        /// <summary>
        /// Gets or sets the vehicle count.
        /// </summary>
        /// <value>The vehicle count.</value>
        public int VehicleCount { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [remove from view flag].
        /// </summary>
        /// <value><c>true</c> if [remove from view flag]; otherwise, <c>false</c>.</value>
        public bool RemoveFromViewFlag { get; set; }
    }
}