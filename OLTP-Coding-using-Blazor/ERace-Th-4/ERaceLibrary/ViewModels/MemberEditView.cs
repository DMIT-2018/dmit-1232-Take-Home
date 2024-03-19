// ***********************************************************************
// Assembly         : ERaceLibrary
// Author           : jamesthompson
// Created          : 03-16-2024
//
// Last Modified By : jamesthompson
// Last Modified On : 03-16-2024
// ***********************************************************************
// <copyright file="MemberEditView.cs" company="ERaceLibrary">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace ERaceLibrary.ViewModels
{

    /// <summary>
    /// Class MemberEditView.
    /// </summary>
    public class MemberEditView
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
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        public string? Address { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>The city.</value>
        public string? City { get; set; }

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        /// <value>The postal code.</value>
        public string? PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        /// <value>The email address.</value>
        public string? EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the birth date.
        /// </summary>
        /// <value>The birth date.</value>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Gets or sets the certification level.
        /// </summary>
        /// <value>The certification level.</value>
        public string? CertificationLevel { get; set; }
        /// <summary>
        /// Gets or sets the cars.
        /// </summary>
        /// <value>The cars.</value>
        public List<CarView> Cars { get; set; } = new();
        /// <summary>
        /// Gets or sets a value indicating whether [remove from view flag].
        /// </summary>
        /// <value><c>true</c> if [remove from view flag]; otherwise, <c>false</c>.</value>
        public bool RemoveFromViewFlag { get; set; }
    }
}