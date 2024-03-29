﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ERaceLibrary.Entities;

[Index("ProductID", Name = "IDX_VendorCatalogs_ProductID")]
[Index("VendorID", Name = "IDX_VendorCatalogs_VendorID")]
internal partial class VendorCatalog
{
    [Key]
    public int VendorCatalogID { get; set; }

    public int ProductID { get; set; }

    public int VendorID { get; set; }

    [Required]
    [StringLength(6)]
    [Unicode(false)]
    public string OrderUnitType { get; set; }

    public int OrderUnitSize { get; set; }

    [Column(TypeName = "money")]
    public decimal OrderUnitCost { get; set; }

    public bool RemoveFromViewFlag { get; set; }

    [ForeignKey("ProductID")]
    [InverseProperty("VendorCatalogs")]
    public virtual Product Product { get; set; }

    [ForeignKey("VendorID")]
    [InverseProperty("VendorCatalogs")]
    public virtual Vendor Vendor { get; set; }
}