﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ERaceLibrary.Entities;

[Index("EmployeeID", Name = "IDX_ReceiveOrders_EmployeeID")]
[Index("OrderID", Name = "IDX_ReceiveOrders_OrderID")]
internal partial class ReceiveOrder
{
    [Key]
    public int ReceiveOrderID { get; set; }

    public int OrderID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ReceiveDate { get; set; }

    public int EmployeeID { get; set; }

    public bool RemoveFromViewFlag { get; set; }

    [ForeignKey("EmployeeID")]
    [InverseProperty("ReceiveOrders")]
    public virtual Employee Employee { get; set; }

    [ForeignKey("OrderID")]
    [InverseProperty("ReceiveOrders")]
    public virtual Order Order { get; set; }

    [InverseProperty("ReceiveOrder")]
    public virtual ICollection<ReceiveOrderItem> ReceiveOrderItems { get; set; } = new List<ReceiveOrderItem>();

    [InverseProperty("ReceiveOrder")]
    public virtual ICollection<ReturnOrderItem> ReturnOrderItems { get; set; } = new List<ReturnOrderItem>();
}