﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ERaceLibrary.Entities;

[Index("CarClassID", Name = "IDX_Cars_CarClassID")]
[Index("MemberID", Name = "IDX_Cars_MemberID")]
[Index("SerialNumber", Name = "UQ__Cars__048A000814F21EE9", IsUnique = true)]
internal partial class Car
{
    [Key]
    public int CarID { get; set; }

    [Required]
    [StringLength(15)]
    [Unicode(false)]
    public string SerialNumber { get; set; }

    [Required]
    [StringLength(6)]
    [Unicode(false)]
    public string Ownership { get; set; }

    public int CarClassID { get; set; }

    [Required]
    [StringLength(10)]
    [Unicode(false)]
    public string State { get; set; }

    [Required]
    [StringLength(255)]
    [Unicode(false)]
    public string Description { get; set; }

    public int MemberID { get; set; }

    public bool RemoveFromViewFlag { get; set; }

    [ForeignKey("CarClassID")]
    [InverseProperty("Cars")]
    public virtual CarClass CarClass { get; set; }

    [ForeignKey("MemberID")]
    [InverseProperty("Cars")]
    public virtual Member Member { get; set; }

    [InverseProperty("Car")]
    public virtual ICollection<RaceDetail> RaceDetails { get; set; } = new List<RaceDetail>();
}