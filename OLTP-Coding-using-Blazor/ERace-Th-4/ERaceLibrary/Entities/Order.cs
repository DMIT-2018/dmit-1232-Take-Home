﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ERaceLibrary.Entities;

[Index("EmployeeID", Name = "IDX_Orders_EmployeeID")]
[Index("VendorID", Name = "IDX_Orders_VendorID")]
internal partial class Order
{
    [Key]
    public int OrderID { get; set; }

    public int? OrderNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    public int EmployeeID { get; set; }

    [Column(TypeName = "smallmoney")]
    public decimal TaxGST { get; set; }

    [Column(TypeName = "money")]
    public decimal SubTotal { get; set; }

    public int VendorID { get; set; }

    public bool Closed { get; set; }

    [StringLength(255)]
    public string Comment { get; set; }

    public bool RemoveFromViewFlag { get; set; }

    [ForeignKey("EmployeeID")]
    [InverseProperty("Orders")]
    public virtual Employee Employee { get; set; }

    [InverseProperty("Order")]
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    [InverseProperty("Order")]
    public virtual ICollection<ReceiveOrder> ReceiveOrders { get; set; } = new List<ReceiveOrder>();

    [ForeignKey("VendorID")]
    [InverseProperty("Orders")]
    public virtual Vendor Vendor { get; set; }
}