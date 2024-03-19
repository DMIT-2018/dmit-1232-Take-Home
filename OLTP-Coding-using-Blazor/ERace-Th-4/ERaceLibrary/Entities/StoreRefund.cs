﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ERaceLibrary.Entities;

internal partial class StoreRefund
{
    [Key]
    public int RefundID { get; set; }

    public int InvoiceID { get; set; }

    public int ProductID { get; set; }

    public int OriginalInvoiceID { get; set; }

    [Required]
    [StringLength(150)]
    public string Reason { get; set; }

    public bool RemoveFromViewFlag { get; set; }

    [ForeignKey("InvoiceID")]
    [InverseProperty("StoreRefundInvoices")]
    public virtual Invoice Invoice { get; set; }

    [ForeignKey("OriginalInvoiceID")]
    [InverseProperty("StoreRefundOriginalInvoices")]
    public virtual Invoice OriginalInvoice { get; set; }

    [ForeignKey("ProductID")]
    [InverseProperty("StoreRefunds")]
    public virtual Product Product { get; set; }
}