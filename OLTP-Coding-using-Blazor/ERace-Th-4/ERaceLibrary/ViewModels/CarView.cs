// ***********************************************************************
// Assembly         : ERaceLibrary
// Author           : jamesthompson
// Created          : 03-16-2024
//
// Last Modified By : jamesthompson
// Last Modified On : 03-16-2024
// ***********************************************************************
// <copyright file="Car.cs" company="ERaceLibrary">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
/// <summary>
/// The ViewModels namespace.
/// </summary>
namespace ERaceLibrary.ViewModels
{
    /// <summary>
    /// Class Car.
    /// </summary>
    public class CarView
    {
        /// <summary>
        /// Gets or sets the car identifier.
        /// </summary>
        /// <value>The car identifier.</value>
        public int CarID { get; set; }
        /// <summary>
        /// Gets or sets the member identifier.
        /// </summary>
        /// <value>The member identifier.</value>
        public int MemberID { get; set; }
        /// <summary>
        /// Gets or sets the temporary car identifier.
        /// </summary>
        /// <value>The temporary car identifier.</value>
        public int TemporaryCarID { get; set; }
        /// <summary>
        /// Gets or sets the serial number.
        /// </summary>
        /// <value>The serial number.</value>
        public string? SerialNumber { get; set; }
        /// <summary>
        /// Gets or sets the ownership.
        /// </summary>
        /// <value>The ownership.</value>
        public string? Ownership { get; set; }
        /// <summary>
        /// Gets or sets the car class identifier.
        /// </summary>
        /// <value>The car class identifier.</value>
        public int CarClassID { get; set; }
        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        public string? State { get; set; }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public string? Description { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [remove from view flag].
        /// </summary>
        /// <value><c>true</c> if [remove from view flag]; otherwise, <c>false</c>.</value>
        public bool RemoveFromViewFlag { get; set; }
    }
}
