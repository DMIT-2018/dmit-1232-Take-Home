﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ERaceLibrary.Entities;

[Index("CertificationLevel", Name = "IDX_Races_CertificationLevel")]
internal partial class Race
{
    [Key]
    public int RaceID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RaceDate { get; set; }

    public int NumberOfCars { get; set; }

    public int Laps { get; set; }

    [Required]
    [StringLength(1)]
    [Unicode(false)]
    public string Run { get; set; }

    [StringLength(1048)]
    [Unicode(false)]
    public string Comment { get; set; }

    [Required]
    [StringLength(1)]
    [Unicode(false)]
    public string CertificationLevel { get; set; }

    public bool RemoveFromViewFlag { get; set; }

    [ForeignKey("CertificationLevel")]
    [InverseProperty("Races")]
    public virtual Certification CertificationLevelNavigation { get; set; }

    [InverseProperty("Race")]
    public virtual ICollection<RaceDetail> RaceDetails { get; set; } = new List<RaceDetail>();
}