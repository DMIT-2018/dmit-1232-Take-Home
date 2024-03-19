// ***********************************************************************
// Assembly         : ERaceLibrary
// Author           : jamesthompson
// Created          : 03-16-2024
//
// Last Modified By : jamesthompson
// Last Modified On : 03-16-2024
// ***********************************************************************
// <copyright file="Certification.cs" company="ERaceLibrary">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace ERaceLibrary.ViewModels
{
    /// <summary>
    /// Class Certification.
    /// </summary>
    public class CertificationView
    {
        /// <summary>
        /// Gets or sets the certification level.
        /// </summary>
        /// <value>The certification level.</value>
        public string? CertificationLevel { get; set; }
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