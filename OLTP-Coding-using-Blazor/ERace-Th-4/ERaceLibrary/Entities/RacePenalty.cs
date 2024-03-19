﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ERaceLibrary.Entities;

internal partial class RacePenalty
{
    [Key]
    public int PenaltyID { get; set; }

    [Required]
    [StringLength(50)]
    public string Description { get; set; }

    public bool RemoveFromViewFlag { get; set; }

    [InverseProperty("Penalty")]
    public virtual ICollection<RaceDetail> RaceDetails { get; set; } = new List<RaceDetail>();
}