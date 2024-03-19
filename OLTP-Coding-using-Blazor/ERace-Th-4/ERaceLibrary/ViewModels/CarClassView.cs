// ***********************************************************************
// Assembly         : ERaceLibrary
// Author           : jamesthompson
// Created          : 03-16-2024
//
// Last Modified By : jamesthompson
// Last Modified On : 03-16-2024
// ***********************************************************************
// <copyright file="CarClassView.cs" company="ERaceLibrary">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace ERaceLibrary.ViewModels
{
    /// <summary>
    /// Class CarClassView.
    /// </summary>
    public class CarClassView
    {
        /// <summary>
        /// Gets or sets the car class identifier.
        /// </summary>
        /// <value>The car class identifier.</value>
        public int CarClassID { get; set; }
        /// <summary>
        /// Gets or sets the name of the car class.
        /// </summary>
        /// <value>The name of the car class.</value>
        public string? CarClassName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [remove from view flag].
        /// </summary>
        /// <value><c>true</c> if [remove from view flag]; otherwise, <c>false</c>.</value>
        public bool RemoveFromViewFlag { get; set; }
    }
}
