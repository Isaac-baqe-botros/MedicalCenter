using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Medical_Center.Models;
// Models/Billing.cs
public partial class Billing
{
    [Required]
    [Key]
    public int BillId { get; set; } // Primary key

    public int? PatientId { get; set; }

    public DateTime? DateOfBill { get; set; }

    public decimal? Amount { get; set; }

    public string? PaymentStatus { get; set; }

    public string? PaymentMethod { get; set; }

    public virtual Patient? Patient { get; set; }
}


